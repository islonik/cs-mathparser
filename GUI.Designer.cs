namespace GUI
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.moreButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.openBracketButton = new System.Windows.Forms.Button();
            this.closeBracketButton = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.modalDivideButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.degreeRadioButton = new System.Windows.Forms.RadioButton();
            this.RadianRadioButton = new System.Windows.Forms.RadioButton();
            this.GradusRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(6, 16);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(34, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(6, 45);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Output:";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.BorderSize = 2;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(272, 68);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 30);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateOnClickButton);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(47, 42);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(383, 20);
            this.outputTextBox.TabIndex = 5;
            // 
            // moreButton
            // 
            this.moreButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.moreButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.moreButton.FlatAppearance.BorderSize = 2;
            this.moreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreButton.Location = new System.Drawing.Point(355, 68);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(75, 30);
            this.moreButton.TabIndex = 6;
            this.moreButton.Text = "More";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.MoreOnClickButton);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zeroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zeroButton.FlatAppearance.BorderSize = 2;
            this.zeroButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.zeroButton.Location = new System.Drawing.Point(272, 284);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(75, 30);
            this.zeroButton.TabIndex = 9;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Visible = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroOnClickButton);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.oneButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.oneButton.FlatAppearance.BorderSize = 2;
            this.oneButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.oneButton.Location = new System.Drawing.Point(272, 248);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(35, 30);
            this.oneButton.TabIndex = 10;
            this.oneButton.Text = "1";
            this.oneButton.UseCompatibleTextRendering = true;
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Visible = false;
            this.oneButton.Click += new System.EventHandler(this.oneOnClickButton);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.twoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.twoButton.FlatAppearance.BorderSize = 2;
            this.twoButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.twoButton.Location = new System.Drawing.Point(313, 248);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(35, 30);
            this.twoButton.TabIndex = 11;
            this.twoButton.Text = "2";
            this.twoButton.UseCompatibleTextRendering = true;
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Visible = false;
            this.twoButton.Click += new System.EventHandler(this.twoOnClickButton);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.threeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.threeButton.FlatAppearance.BorderSize = 2;
            this.threeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.threeButton.Location = new System.Drawing.Point(354, 248);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(35, 30);
            this.threeButton.TabIndex = 12;
            this.threeButton.Text = "3";
            this.threeButton.UseCompatibleTextRendering = true;
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Visible = false;
            this.threeButton.Click += new System.EventHandler(this.threeOnClickButton);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fourButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fourButton.FlatAppearance.BorderSize = 2;
            this.fourButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fourButton.Location = new System.Drawing.Point(272, 212);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(35, 30);
            this.fourButton.TabIndex = 13;
            this.fourButton.Text = "4";
            this.fourButton.UseCompatibleTextRendering = true;
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Visible = false;
            this.fourButton.Click += new System.EventHandler(this.fourOnClickButton);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fiveButton.FlatAppearance.BorderSize = 2;
            this.fiveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fiveButton.Location = new System.Drawing.Point(313, 212);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(35, 30);
            this.fiveButton.TabIndex = 14;
            this.fiveButton.Text = "5";
            this.fiveButton.UseCompatibleTextRendering = true;
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Visible = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveOnClickButton);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sixButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sixButton.FlatAppearance.BorderSize = 2;
            this.sixButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sixButton.Location = new System.Drawing.Point(354, 212);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(35, 30);
            this.sixButton.TabIndex = 15;
            this.sixButton.Text = "6";
            this.sixButton.UseCompatibleTextRendering = true;
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Visible = false;
            this.sixButton.Click += new System.EventHandler(this.sixOnClickButton);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sevenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sevenButton.FlatAppearance.BorderSize = 2;
            this.sevenButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sevenButton.Location = new System.Drawing.Point(272, 176);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(35, 30);
            this.sevenButton.TabIndex = 16;
            this.sevenButton.Text = "7";
            this.sevenButton.UseCompatibleTextRendering = true;
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Visible = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenOnClickButton);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eightButton.FlatAppearance.BorderSize = 2;
            this.eightButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.eightButton.Location = new System.Drawing.Point(313, 176);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(35, 30);
            this.eightButton.TabIndex = 17;
            this.eightButton.Text = "8";
            this.eightButton.UseCompatibleTextRendering = true;
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Visible = false;
            this.eightButton.Click += new System.EventHandler(this.eightOnClickButton);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nineButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nineButton.FlatAppearance.BorderSize = 2;
            this.nineButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nineButton.Location = new System.Drawing.Point(354, 176);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(35, 30);
            this.nineButton.TabIndex = 18;
            this.nineButton.Text = "9";
            this.nineButton.UseCompatibleTextRendering = true;
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Visible = false;
            this.nineButton.Click += new System.EventHandler(this.nineOnClickButton);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pointButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pointButton.FlatAppearance.BorderSize = 2;
            this.pointButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pointButton.Location = new System.Drawing.Point(354, 284);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(35, 30);
            this.pointButton.TabIndex = 19;
            this.pointButton.Text = ".";
            this.pointButton.UseCompatibleTextRendering = true;
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Visible = false;
            this.pointButton.Click += new System.EventHandler(this.pointOnClickButton);
            // 
            // openBracketButton
            // 
            this.openBracketButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openBracketButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openBracketButton.FlatAppearance.BorderSize = 2;
            this.openBracketButton.ForeColor = System.Drawing.Color.Crimson;
            this.openBracketButton.Location = new System.Drawing.Point(272, 140);
            this.openBracketButton.Name = "openBracketButton";
            this.openBracketButton.Size = new System.Drawing.Size(35, 30);
            this.openBracketButton.TabIndex = 22;
            this.openBracketButton.Text = "(";
            this.openBracketButton.UseCompatibleTextRendering = true;
            this.openBracketButton.UseVisualStyleBackColor = true;
            this.openBracketButton.Visible = false;
            this.openBracketButton.Click += new System.EventHandler(this.openBracketOnClickButton);
            // 
            // closeBracketButton
            // 
            this.closeBracketButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeBracketButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeBracketButton.FlatAppearance.BorderSize = 2;
            this.closeBracketButton.ForeColor = System.Drawing.Color.Crimson;
            this.closeBracketButton.Location = new System.Drawing.Point(313, 140);
            this.closeBracketButton.Name = "closeBracketButton";
            this.closeBracketButton.Size = new System.Drawing.Size(35, 30);
            this.closeBracketButton.TabIndex = 23;
            this.closeBracketButton.Text = ")";
            this.closeBracketButton.UseCompatibleTextRendering = true;
            this.closeBracketButton.UseVisualStyleBackColor = true;
            this.closeBracketButton.Visible = false;
            this.closeBracketButton.Click += new System.EventHandler(this.closeBracketOnClickButton);
            // 
            // indexButton
            // 
            this.indexButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.indexButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.indexButton.FlatAppearance.BorderSize = 2;
            this.indexButton.ForeColor = System.Drawing.Color.Crimson;
            this.indexButton.Location = new System.Drawing.Point(354, 140);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(35, 30);
            this.indexButton.TabIndex = 24;
            this.indexButton.Text = "^";
            this.indexButton.UseCompatibleTextRendering = true;
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Visible = false;
            this.indexButton.Click += new System.EventHandler(this.indexOnClickButton);
            // 
            // multiButton
            // 
            this.multiButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.multiButton.FlatAppearance.BorderSize = 2;
            this.multiButton.ForeColor = System.Drawing.Color.Crimson;
            this.multiButton.Location = new System.Drawing.Point(395, 140);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(35, 30);
            this.multiButton.TabIndex = 25;
            this.multiButton.Text = "*";
            this.multiButton.UseCompatibleTextRendering = true;
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Visible = false;
            this.multiButton.Click += new System.EventHandler(this.multiOnClickButton);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.helpButton.FlatAppearance.BorderSize = 2;
            this.helpButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.helpButton.Location = new System.Drawing.Point(272, 104);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(76, 30);
            this.helpButton.TabIndex = 27;
            this.helpButton.Text = "Help";
            this.helpButton.UseCompatibleTextRendering = true;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Visible = false;
            this.helpButton.Click += new System.EventHandler(this.helpOnClickButton);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.clearButton.Location = new System.Drawing.Point(354, 104);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(76, 30);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "Clear";
            this.clearButton.UseCompatibleTextRendering = true;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearOnClickButton);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divideButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.divideButton.FlatAppearance.BorderSize = 2;
            this.divideButton.ForeColor = System.Drawing.Color.Crimson;
            this.divideButton.Location = new System.Drawing.Point(395, 176);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(35, 30);
            this.divideButton.TabIndex = 30;
            this.divideButton.Text = "/";
            this.divideButton.UseCompatibleTextRendering = true;
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Visible = false;
            this.divideButton.Click += new System.EventHandler(this.divideOnClickButton);
            // 
            // modalDivideButton
            // 
            this.modalDivideButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modalDivideButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modalDivideButton.FlatAppearance.BorderSize = 2;
            this.modalDivideButton.ForeColor = System.Drawing.Color.Crimson;
            this.modalDivideButton.Location = new System.Drawing.Point(395, 212);
            this.modalDivideButton.Name = "modalDivideButton";
            this.modalDivideButton.Size = new System.Drawing.Size(35, 30);
            this.modalDivideButton.TabIndex = 31;
            this.modalDivideButton.Text = "%";
            this.modalDivideButton.UseCompatibleTextRendering = true;
            this.modalDivideButton.UseVisualStyleBackColor = true;
            this.modalDivideButton.Visible = false;
            this.modalDivideButton.Click += new System.EventHandler(this.modalDivideOnClickButton);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minusButton.FlatAppearance.BorderSize = 2;
            this.minusButton.ForeColor = System.Drawing.Color.Crimson;
            this.minusButton.Location = new System.Drawing.Point(395, 248);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(35, 30);
            this.minusButton.TabIndex = 32;
            this.minusButton.Text = "-";
            this.minusButton.UseCompatibleTextRendering = true;
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Visible = false;
            this.minusButton.Click += new System.EventHandler(this.minusOnClickButton);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plusButton.FlatAppearance.BorderSize = 2;
            this.plusButton.ForeColor = System.Drawing.Color.Crimson;
            this.plusButton.Location = new System.Drawing.Point(395, 284);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(35, 30);
            this.plusButton.TabIndex = 33;
            this.plusButton.Text = "+";
            this.plusButton.UseCompatibleTextRendering = true;
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Visible = false;
            this.plusButton.Click += new System.EventHandler(this.plusOnClickButton);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(9, 140);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(257, 174);
            this.logBox.TabIndex = 34;
            this.logBox.Text = "";
            this.logBox.Visible = false;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(47, 13);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(383, 20);
            this.inputTextBox.TabIndex = 35;
            // 
            // degreeRadioButton
            // 
            this.degreeRadioButton.AutoSize = true;
            this.degreeRadioButton.Checked = true;
            this.degreeRadioButton.Location = new System.Drawing.Point(12, 111);
            this.degreeRadioButton.Name = "degreeRadioButton";
            this.degreeRadioButton.Size = new System.Drawing.Size(68, 17);
            this.degreeRadioButton.TabIndex = 36;
            this.degreeRadioButton.TabStop = true;
            this.degreeRadioButton.Text = "Градусы";
            this.degreeRadioButton.UseVisualStyleBackColor = true;
            this.degreeRadioButton.Visible = false;
            this.degreeRadioButton.CheckedChanged += new System.EventHandler(this.degreeOnClick);
            // 
            // RadianRadioButton
            // 
            this.RadianRadioButton.AutoSize = true;
            this.RadianRadioButton.Location = new System.Drawing.Point(110, 111);
            this.RadianRadioButton.Name = "RadianRadioButton";
            this.RadianRadioButton.Size = new System.Drawing.Size(70, 17);
            this.RadianRadioButton.TabIndex = 37;
            this.RadianRadioButton.Text = "Радианы";
            this.RadianRadioButton.UseVisualStyleBackColor = true;
            this.RadianRadioButton.Visible = false;
            this.RadianRadioButton.CheckedChanged += new System.EventHandler(this.RadianOnClick);
            // 
            // GradusRadioButton
            // 
            this.GradusRadioButton.AutoSize = true;
            this.GradusRadioButton.Location = new System.Drawing.Point(209, 111);
            this.GradusRadioButton.Name = "GradusRadioButton";
            this.GradusRadioButton.Size = new System.Drawing.Size(57, 17);
            this.GradusRadioButton.TabIndex = 38;
            this.GradusRadioButton.Text = "Грады";
            this.GradusRadioButton.UseVisualStyleBackColor = true;
            this.GradusRadioButton.Visible = false;
            this.GradusRadioButton.CheckedChanged += new System.EventHandler(this.GradusOnClick);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 105);
            this.Controls.Add(this.GradusRadioButton);
            this.Controls.Add(this.RadianRadioButton);
            this.Controls.Add(this.degreeRadioButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.modalDivideButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.indexButton);
            this.Controls.Add(this.closeBracketButton);
            this.Controls.Add(this.openBracketButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "Parsing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button openBracketButton;
        private System.Windows.Forms.Button closeBracketButton;
        private System.Windows.Forms.Button indexButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button modalDivideButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RadioButton degreeRadioButton;
        private System.Windows.Forms.RadioButton RadianRadioButton;
        private System.Windows.Forms.RadioButton GradusRadioButton;
    }
}

