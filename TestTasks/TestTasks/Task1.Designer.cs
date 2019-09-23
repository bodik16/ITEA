namespace TestTasks
{
    partial class Task1
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
            this.Task1Assignment = new System.Windows.Forms.Label();
            this.Assignment1 = new System.Windows.Forms.Label();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.InputTextLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FromFileCheckBox = new System.Windows.Forms.CheckBox();
            this.manuallyCheckBox = new System.Windows.Forms.CheckBox();
            this.Letters = new System.Windows.Forms.Label();
            this.Words = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.LettersOnly = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task1Assignment
            // 
            this.Task1Assignment.AutoSize = true;
            this.Task1Assignment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task1Assignment.Font = new System.Drawing.Font("Road Rage(RUS BY LYAJKA)", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task1Assignment.Location = new System.Drawing.Point(12, 9);
            this.Task1Assignment.Name = "Task1Assignment";
            this.Task1Assignment.Size = new System.Drawing.Size(183, 40);
            this.Task1Assignment.TabIndex = 0;
            this.Task1Assignment.Text = "Assignment:";
            this.Task1Assignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assignment1
            // 
            this.Assignment1.BackColor = System.Drawing.SystemColors.Info;
            this.Assignment1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignment1.Location = new System.Drawing.Point(211, 9);
            this.Assignment1.Name = "Assignment1";
            this.Assignment1.Size = new System.Drawing.Size(548, 40);
            this.Assignment1.TabIndex = 1;
            this.Assignment1.Text = "Get string length GetStringLength";
            this.Assignment1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainTextBox.Location = new System.Drawing.Point(12, 91);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(412, 302);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            // 
            // InputTextLabel1
            // 
            this.InputTextLabel1.AutoSize = true;
            this.InputTextLabel1.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.InputTextLabel1.Location = new System.Drawing.Point(40, 67);
            this.InputTextLabel1.Name = "InputTextLabel1";
            this.InputTextLabel1.Size = new System.Drawing.Size(357, 21);
            this.InputTextLabel1.TabIndex = 3;
            this.InputTextLabel1.Text = "Input the text you want to count it ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FromFileCheckBox);
            this.panel1.Controls.Add(this.manuallyCheckBox);
            this.panel1.Location = new System.Drawing.Point(431, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 56);
            this.panel1.TabIndex = 4;
            // 
            // FromFileCheckBox
            // 
            this.FromFileCheckBox.AutoSize = true;
            this.FromFileCheckBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FromFileCheckBox.Location = new System.Drawing.Point(3, 30);
            this.FromFileCheckBox.Name = "FromFileCheckBox";
            this.FromFileCheckBox.Size = new System.Drawing.Size(88, 21);
            this.FromFileCheckBox.TabIndex = 1;
            this.FromFileCheckBox.Text = "From File";
            this.FromFileCheckBox.UseVisualStyleBackColor = false;
            this.FromFileCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // manuallyCheckBox
            // 
            this.manuallyCheckBox.AutoSize = true;
            this.manuallyCheckBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.manuallyCheckBox.Location = new System.Drawing.Point(3, 3);
            this.manuallyCheckBox.Name = "manuallyCheckBox";
            this.manuallyCheckBox.Size = new System.Drawing.Size(86, 21);
            this.manuallyCheckBox.TabIndex = 0;
            this.manuallyCheckBox.Text = "Manually";
            this.manuallyCheckBox.UseVisualStyleBackColor = false;
            this.manuallyCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Letters
            // 
            this.Letters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Letters.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letters.Location = new System.Drawing.Point(568, 67);
            this.Letters.Name = "Letters";
            this.Letters.Size = new System.Drawing.Size(220, 107);
            this.Letters.TabIndex = 6;
            this.Letters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Words
            // 
            this.Words.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Words.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Words.Location = new System.Drawing.Point(569, 184);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(219, 107);
            this.Words.TabIndex = 5;
            this.Words.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenButton.Location = new System.Drawing.Point(12, 399);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(113, 39);
            this.OpenButton.TabIndex = 7;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Visible = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // LettersOnly
            // 
            this.LettersOnly.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LettersOnly.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LettersOnly.Location = new System.Drawing.Point(569, 300);
            this.LettersOnly.Name = "LettersOnly";
            this.LettersOnly.Size = new System.Drawing.Size(219, 107);
            this.LettersOnly.TabIndex = 8;
            this.LettersOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Symbols";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Letters";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LettersOnly);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.Letters);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputTextLabel1);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.Assignment1);
            this.Controls.Add(this.Task1Assignment);
            this.Name = "Task1";
            this.Text = "Task1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Task1Assignment;
        private System.Windows.Forms.Label Assignment1;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Label InputTextLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox FromFileCheckBox;
        private System.Windows.Forms.CheckBox manuallyCheckBox;
        private System.Windows.Forms.Label Letters;
        private System.Windows.Forms.Label Words;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label LettersOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}