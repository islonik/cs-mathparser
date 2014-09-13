using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI : Form
    {
        static bool trigger = true;
        static bool helpTrigger = true;
        Parser.ExpressionParsing calc = new Parser.ExpressionParsing();
      
        public GUI()
        {
            InitializeComponent();
            calc.setTrigonometry(0);
        }
        void CalculateOnClickButton(object obj, EventArgs ea)
        {
            string str = inputTextBox.Text;
            outputTextBox.Clear();
            outputTextBox.AppendText(Convert.ToString(calc.calculate(str)));
        }
        void zeroOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("0");
        }
        void oneOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("1");
        }
        void twoOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("2");
        }
        void threeOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("3");
        }
        void fourOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("4");
        }
        void fiveOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("5");
        }
        void sixOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("6");
        }
        void sevenOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("7");
        }
        void eightOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("8");
        }
        void nineOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("9");
        }
        void plusOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("+");
        }
        void minusOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("-");
        }
        void multiOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("*");
        }
        void divideOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("/");
        }
        void modalDivideOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("%");
        }
        void indexOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("^");
        }
        void openBracketOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText("(");
        }
        void closeBracketOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText(")");
        }
        void clearOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.Clear();
        }
        void pointOnClickButton(object obj, EventArgs ea)
        {
            inputTextBox.AppendText(".");
        }
        void helpOnClickButton(object obj, EventArgs ea)
        {
            if (helpTrigger == true)
            {
                helpText();
                helpTrigger = false;
            }
            else
            {
                logBox.Clear();
                helpTrigger = true;
            }
        }
        void MoreOnClickButton(object obj, EventArgs ea)
        {
            if (trigger == false)
            {
                hideShow();
                this.ClientSize = new System.Drawing.Size(436, 105);
                trigger = true;
            }
            else
            {
                hideShow();
                this.ClientSize = new System.Drawing.Size(436, 320);
                trigger = false;
            }
        }
        void hideShow()
        {
            this.degreeRadioButton.Visible = trigger;
            this.GradusRadioButton.Visible = trigger;
            this.RadianRadioButton.Visible = trigger;
            this.logBox.Visible = trigger;
            this.zeroButton.Visible = trigger;
            this.oneButton.Visible = trigger;
            this.twoButton.Visible = trigger;
            this.threeButton.Visible = trigger;
            this.fourButton.Visible = trigger;
            this.fiveButton.Visible = trigger;
            this.sixButton.Visible = trigger;
            this.sevenButton.Visible = trigger;
            this.eightButton.Visible = trigger;
            this.nineButton.Visible = trigger;
            this.multiButton.Visible = trigger;
            this.divideButton.Visible = trigger;
            this.modalDivideButton.Visible = trigger;
            this.plusButton.Visible = trigger;
            this.pointButton.Visible = trigger;
            this.minusButton.Visible = trigger;
            this.helpButton.Visible = trigger;
            this.clearButton.Visible = trigger;
            this.indexButton.Visible = trigger;
            this.openBracketButton.Visible = trigger;
            this.closeBracketButton.Visible = trigger;
        }
        void helpText()
        {
            logBox.AppendText("\t\tHelp\n\r");
            logBox.AppendText("\tYou can use the next tokens:\n");
            logBox.AppendText("One-parameter functions: \n");
            logBox.AppendText("Abs(), Acos(), Asin(), Atan(), Cos(), Log10(), Round(), Sin(), Sqrt(), Tan() \n\r");
            logBox.AppendText("Two-parameter functions: \n");
            logBox.AppendText("Log(), Pow() \n\r");
            logBox.AppendText("Multi-parameter functions: \n");
            logBox.AppendText("Max(), Min(), Sum() \n\r");
            logBox.AppendText("and operators: \n");
            logBox.AppendText("'+' , '-' , '*' , '/' , '\\' , '%' , '^' \n\r");
            logBox.AppendText("and constans: \n");
            logBox.AppendText("PI and E \n\r");
        }
        private void degreeOnClick(object sender, EventArgs e)
        {
            calc.setTrigonometry(0);
        }
        private void RadianOnClick(object sender, EventArgs e)
        {
            calc.setTrigonometry(2);
        }
        private void GradusOnClick(object sender, EventArgs e)
        {
            calc.setTrigonometry(1);
        }
    }
}
