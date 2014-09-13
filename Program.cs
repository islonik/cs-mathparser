using System;
using System.Collections;
using System.Windows.Forms;

namespace GUI
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}
namespace Parser
{
    /// <ParsingError>
    /// Private specificators
    ///     Класс вывода ошибок на экран
    /// </ParsingError>
    class ParsingError : ApplicationException
    {
        public ParsingError(string str) : base(str) { }
        public override string ToString()
        {
            //return base.ToString();
            return Message;
        }
    }

    class ExpressionParsing
    {
        enum Types { NONE, DELIMITER, VARIABLE, NUMBER, FUNCTION };
        enum Error { SYNTAX, UNBALPARENTS, NOEXP, DIVBYZERO, UNKNOWNEXPRESSION, UNKNOWNVARIABLE };
        bool errorExist;                       /// <note-1> Есть или нет ошибка в выражение </note-1>
        int trigonometry;                      /// <note-2> Как высчитывать углы - в радианах или в градусах </note-2>
        int numberError;                       /// <note-3> Номер ошибки </note-3>
        int idString;                          /// <note-4> Указатель на символ в строке </note-4>
        string storString;                     /// <note-5> Хранит всю строку </note-5>
        string storToken;                      /// <note-6> Хранит текущий токен </note-6>
        Types typeToken;                       /// <note-7> Тип токена </note-7>
        Hashtable storVars = new Hashtable();  /// <note-8> Хранит значения переменных</note-8>
        Hashtable storInit = new Hashtable();  /// <note-9> Хранит объявление переменных</note-9>

        /// <Public>
        /// Public specificators
        ///     setTrigonometry - устанавливает как вычислять в градусах или в углах
        ///     calculate - точка входа в рекурсивно-нисходящий анализ
        ///     ToDouble - метод, извлекающий из строки число
        /// </Public>
        public void setTrigonometry(int grad)
        {
            trigonometry = grad;
        }
        public string calculate(string str)
        {
            storString = str;
            idString = 0;
            errorExist = false;
            try
            {
                _getToken();
                if (storToken == "")
                {
                    _syntaxError(Error.NOEXP);
                    return _storError(numberError);
                }
                double temp;
                _firstStepParsing(out temp);
                if (storToken != "")
                {
                    _syntaxError(Error.SYNTAX);
                }
                if (errorExist)
                {
                    return _storError(numberError);
                }
                return Convert.ToString(temp);
            }
            catch (ParsingError)
            {
                return "Parsing Error";
            }
            catch (StackOverflowException)
            {
                return "Fatal Error";
            }
        }
        public double ToDouble(string str)
        {
            string strNumber = "0123456789";
            double result = 0.0;
            double temp;
            int index = 0;
            bool beforePoint = false;
            bool isNumber = false;
            for (int k = 0; k < str.Length; k++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (str[k] == '.')
                    {
                        isNumber = true;
                        break;
                    }
                    else if (str[k] == strNumber[i])
                    {
                        temp = i;
                        if (!beforePoint)
                        {
                            result = result * 10 + temp;
                        }
                        else
                        {
                            result = result + temp / (Math.Pow(10.0, (double)index));
                            index++;
                        }
                        isNumber = true;
                        break;
                    }
                }
                if (!isNumber)
                {
                    return result;
                }
                else if (!beforePoint && str[k] == '.')
                {
                    index = 1;
                    beforePoint = true;
                }
                isNumber = false;
            }
            return result;
        }
        /// <Private>
        /// Private specificators
        ///     _firstStepParsing - присваивает переменным значения
        ///     _secondStepParsing - производит операции '+' и '-'
        ///     _thirdStepParsing - производит операции '/' , '%' и '*'
        ///     _fourthStepParsing - возводит в степень
        ///     _fifthStepParsing - производит операции с унарным '-' и '+'
        ///     _sixthStepParsing - вычисляет выражение в скобках
        ///     _seventhStepParsing - определяет константы
        ///     _atom - определяет тип токена и передает управление соответстующей функции
        ///     _functions - произодит действия с функциями
        ///     _getToken - ключевая функция в программе - извлекает токен из строки
        ///     _syntaxError - устаналивает наличие ошибки
        ///     _toStringWithoutSpace - пропускает пробелы
        ///     _putBack - возвращает указатель(idString) на начало строки
        ///     _findVar - возвращает значения переменной
        ///     _storError - хранит сообщения об ошибках
        ///     _isDelimiter - определяет разделитель
        /// </Private>
        private void _firstStepParsing(out double result)
        {
            string str;
            Types tempType;
            if (typeToken == Types.VARIABLE)
            {
                str = String.Copy(storToken);
                tempType = Types.VARIABLE;
                if (!storVars.ContainsKey(str))
                {
                    storVars.Add(str, 0.0);
                    if (!storInit.ContainsKey(str))
                    {
                        storInit.Add(str, false);
                    }
                }
                _getToken();
                if (storToken != "=")
                {
                    _putBack();
                    if (!Convert.ToBoolean(storInit[str]))
                    {
                        storVars.Remove(str);
                    }
                    storToken = String.Copy(str);
                    typeToken = tempType;
                }
                else
                {
                    _getToken();
                    _secondStepParsing(out result);
                    storVars[str] = result;
                    storInit[str] = true;
                    return;
                }
            }
            _secondStepParsing(out result);
        }
        private void _putBack()
        {
            for (int i = 0; i < storToken.Length; i++) idString--;
        }
        private void _secondStepParsing(out double result)
        {
            _thirdStepParsing(out result);
            string str;
            while ((str = storToken) == "+" || str == "-")
            {
                _getToken();
                double temp;
                _thirdStepParsing(out temp);
                switch (str)
                {
                    case "-":
                        result = result - temp;
                        break;
                    case "+":
                        result = result + temp;
                        break;
                }
            }
        }
        private void _thirdStepParsing(out double result)
        {
            _fourthStepParsing(out result);
            string str;
            while ((str = storToken) == "*" || str == "/" || str == "%" || str == "\\")
            {
                _getToken();
                double temp = 0.0;
                _fourthStepParsing(out temp);
                switch (str)
                {
                    case "\\":
                    case "/":
                        if (temp == 0.0)
                            _syntaxError(Error.DIVBYZERO);
                        result = result / temp;
                        break;
                    case "%":
                        if (temp == 0.0)
                            _syntaxError(Error.DIVBYZERO);
                        result = result % temp;
                        break;
                    case "*":
                        result = result * temp;
                        break;
                }
            }
        }
        private void _fourthStepParsing(out double result)
        {
            _fifthStepParsing(out result);
            if (storToken == "^")
            {
                _getToken();
                double temp;
                _fourthStepParsing(out temp);
                double index;
                index = result;
                if (temp == 0.0)
                {
                    result = 1.0;
                    return;
                }
                for (int t = (int)temp - 1; t > 0; t--)
                {
                    result = result * (double)index;
                }
            }
        }
        private void _fifthStepParsing(out double result)
        {
            string str = "";
            if ((typeToken == Types.DELIMITER) && storToken == "+" || storToken == "-")
            {
                str = storToken;
                _getToken();
            }
            _sixthStepParsing(out result);
            if (str == "-")
                result = -result;
        }
        private void _sixthStepParsing(out double result)
        {
            if (storToken == "(")
            {
                _getToken();
                _firstStepParsing(out result);
                if (storToken != ")")
                    _syntaxError(Error.UNBALPARENTS);
                _getToken();
            }
            else
            {
                _seventhStepParsing(out result);
            }
        }
        private void _seventhStepParsing(out double result)
        {
            if (storToken == "e" || storToken == "pi")
            {
                result = 0.0;
                switch (storToken)
                {
                    case "e":
                        result = Math.E;
                        _getToken();
                        return;
                    case "pi":
                        result = Math.PI;
                        _getToken();
                        return;
                }
            }
            else
            {
                _atom(out result);
            }
        }
        private void _atom(out double result)
        {
            switch (typeToken)
            {
                case Types.NUMBER:
                    try
                    {
                        result = ToDouble(storToken);
                    }
                    catch (FormatException)
                    {
                        result = 0.0;
                        _syntaxError(Error.SYNTAX);
                    }
                    _getToken();
                    return;
                case Types.FUNCTION:
                    _functions(out result);
                    return;
                case Types.VARIABLE:
                    result = _findVar(storToken);
                    _getToken();
                    return;
                default:
                    result = 0.0;
                    _syntaxError(Error.SYNTAX);
                    break;
            }
        }
        private double _findVar(string vname)
        {
            if (!storVars.ContainsKey(vname))
            {
                _syntaxError(Error.UNKNOWNVARIABLE);
                return 0.0;
            }
            return Convert.ToDouble(storVars[vname]);
        }
        /// <_functions>
        /// В этом методе определены все функции:
        ///     <one-parameter>
        ///         abs   - возводит в модуль число
        ///         acos  - находит арккосинус числа
        ///         asin  - находит арксинус числа
        ///         atan  - находит арктангенс числа
        ///         cos   - находит косинус угла
        ///         log10 - находит значение 10-ого логарифма
        ///         round - округляет число
        ///         sin   - находит синус градуса 
        ///         sqrt  - находит корень из числа
        ///         tan   - находит тангенс градуса
        ///     </one-parameter>
        ///     <two-parameter>
        ///         pow   - возводит в степень базу
        ///         log   - находит логарифм по базису и степени
        ///     </two-parameter>
        ///     <multi-parameter>
        ///         min   - находит наименьшее значение в скобках
        ///         max   - находит наибольшее значение в скобках
        ///         sum   - подсчитывает все значения в скобках
        ///     </multi-parameter>
        /// </_functions>
        private void _functions(out double result)
        {
            result = 0.0;
            string str;
            if ((str = storToken) == "abs" || str == "acos" || str == "asin" ||
                 str == "atan" || str == "cos" || str == "log10" || str == "round" ||
                 str == "sin" || str == "sqrt" || str == "tan")
            {
                _oneParameterFunctions(out result, ref str);
            }
            else if ((str = storToken) == "pow" || str == "log")
            {
                _twoParameterFunctions(out result, str);
            }
            else if ((str = storToken) == "min" || str == "max" || str == "sum")
            {
                _multiParameterFunctions(out result, str);
            }
            else
            {
                _syntaxError(Error.SYNTAX);
            }
        }
        private void _oneParameterFunctions(out double result, ref string str)
        {
            _getToken();
            _sixthStepParsing(out result);
            switch (str)
            {
                case "abs":
                    result = Math.Abs(result); break;
                case "log10":
                    result = Math.Log10(result); break;
                case "round":
                    result = Math.Round(result); break;
                case "sqrt":
                    result = Math.Sqrt(result); break;
                case "acos":
                    _GradRad(ref result); result = Math.Acos(result); break;
                case "asin":
                    _GradRad(ref result); result = Math.Asin(result); break;
                case "atan":
                    _GradRad(ref result); result = Math.Atan(result); break;
                case "cos":
                    _GradRad(ref result); result = Math.Cos(result); break;
                case "sin":
                    _GradRad(ref result); result = Math.Sin(result); break;
                case "tan":
                    _GradRad(ref result); result = Math.Tan(result); break;
            }
        }
        private void _GradRad(ref double result)
        {
            switch (trigonometry)
            {
                case 0:
                    result = result * Math.PI / 180;
                    break;
                case 1:
                    result = result * Math.PI / 200;
                    break;
                default:
                    break;
            }
        }
        private void _twoParameterFunctions(out double result, string str)
        {
            _getToken(); // скобка
            _getToken(); // число или что-нибудь
            _firstStepParsing(out result);
            if (storToken == ",")
            {
                _getToken();
                double temp;
                _firstStepParsing(out temp);
                switch (str)
                {
                    case "pow": result = Math.Pow(result, temp); break;
                    case "log": result = Math.Log(temp, result); break;
                }
                if (storToken == ",")
                {
                    _syntaxError(Error.SYNTAX);
                }
                else if (storToken != ")")
                {
                    _syntaxError(Error.UNBALPARENTS);
                }
                _getToken();
            }
            else
            {
                _syntaxError(Error.SYNTAX);
            }
        }
        private void _multiParameterFunctions(out double result, string str)
        {
            _getToken(); // открыть скобку
            _getToken(); // получить результат до разделителя
            _firstStepParsing(out result);
            for (; ; )
            {
                if (storToken == ",")
                {
                    _getToken();
                    double temp;
                    _firstStepParsing(out temp);
                    if (str == "min" && result > temp) // наименьшее
                    {
                        result = temp;
                    }
                    else if (str == "max" && result < temp) // наибольшее
                    {
                        result = temp;
                    }
                    else if (str == "sum") // сумма
                    {
                        result += temp;
                    }
                }
                else if (storToken == ")")
                {
                    _getToken();
                    break;
                }
                else
                {
                    _syntaxError(Error.UNBALPARENTS);
                }
            }
        }
        private void _getToken()
        {

            typeToken = Types.NONE;
            storToken = "";
            if (idString == storString.Length)
                return;

            _toStringWithoutSpace();

            if (idString == storString.Length)
                return;

            if (_isDelimiter(storString[idString]))
            {
                storToken += storString[idString];
                idString++;
                typeToken = Types.DELIMITER;
            }
            else if (Char.IsLetter(storString[idString]))
            {
                int ctrl = 0;
                while (!_isDelimiter(storString[idString]))
                {
                    storToken += storString[idString].ToString().ToLower();
                    idString++;
                    if (idString >= storString.Length)
                        break;
                    ctrl++;
                    if (ctrl >= 32)
                        _syntaxError(Error.UNKNOWNEXPRESSION);
                }
                _toStringWithoutSpace();
                if (idString < storString.Length && storString[idString] == '(')
                    typeToken = Types.FUNCTION;
                else
                    typeToken = Types.VARIABLE;
            }
            else if (Char.IsDigit(storString[idString]))
            {
                while (!_isDelimiter(storString[idString]))
                {
                    storToken += storString[idString];
                    idString++;
                    if (idString >= storString.Length)
                        break;
                }
                typeToken = Types.NUMBER;
            }
        }
        private void _toStringWithoutSpace()
        {
            while (idString < storString.Length && Char.IsWhiteSpace(storString[idString]))
                ++idString;
        }
        private bool _isDelimiter(char ctr)
        {
            if (" +-/\\*%^=(),".IndexOf(ctr) != -1)
                return true;
            return false;
        }
        private void _syntaxError(Error error)
        {
            numberError = (int)error;
            errorExist = true;
        }
        private string _storError(int error)
        {
            string[] strError = 
        {
            "Синтаксическая ошибка", // 01
            "Дисбаланс скобок",      // 02
            "Выражение отсутствует", // 03 
            "Деление на ноль",       // 04
            "Неизвестное выражение", // 05
            "Неизвестная переменная" // 06
        };
            return strError[error];
        }
    }
}
