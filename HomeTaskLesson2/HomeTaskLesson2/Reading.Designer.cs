namespace HomeTaskLesson2
{
    partial class Reading
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.manuallyCheckBox = new System.Windows.Forms.CheckBox();
            this.FromFileCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CountTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Words = new System.Windows.Forms.TextBox();
            this.Ex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenButton.Location = new System.Drawing.Point(3, 404);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 34);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Visible = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CountButton
            // 
            this.CountButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CountButton.Location = new System.Drawing.Point(412, 404);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 34);
            this.CountButton.TabIndex = 1;
            this.CountButton.Tag = "";
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = false;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainTextBox.Location = new System.Drawing.Point(3, 12);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(484, 386);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            // 
            // manuallyCheckBox
            // 
            this.manuallyCheckBox.AutoSize = true;
            this.manuallyCheckBox.Location = new System.Drawing.Point(3, 3);
            this.manuallyCheckBox.Name = "manuallyCheckBox";
            this.manuallyCheckBox.Size = new System.Drawing.Size(86, 21);
            this.manuallyCheckBox.TabIndex = 3;
            this.manuallyCheckBox.Text = "Manually";
            this.manuallyCheckBox.UseVisualStyleBackColor = true;
            this.manuallyCheckBox.CheckedChanged += new System.EventHandler(this.ManuallyCheckBox_CheckedChanged);
            // 
            // FromFileCheckBox
            // 
            this.FromFileCheckBox.AutoSize = true;
            this.FromFileCheckBox.Location = new System.Drawing.Point(3, 30);
            this.FromFileCheckBox.Name = "FromFileCheckBox";
            this.FromFileCheckBox.Size = new System.Drawing.Size(88, 21);
            this.FromFileCheckBox.TabIndex = 4;
            this.FromFileCheckBox.Text = "From File";
            this.FromFileCheckBox.UseVisualStyleBackColor = true;
            this.FromFileCheckBox.CheckedChanged += new System.EventHandler(this.FromFileCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.manuallyCheckBox);
            this.panel1.Controls.Add(this.FromFileCheckBox);
            this.panel1.Location = new System.Drawing.Point(493, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 58);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(493, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input count of the letters you want to check\r\nfrom 1 to 9\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CountTextBox2
            // 
            this.CountTextBox2.Location = new System.Drawing.Point(602, 122);
            this.CountTextBox2.MaxLength = 2;
            this.CountTextBox2.Multiline = true;
            this.CountTextBox2.Name = "CountTextBox2";
            this.CountTextBox2.Size = new System.Drawing.Size(100, 48);
            this.CountTextBox2.TabIndex = 7;
            this.CountTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountTextBox2.TextChanged += new System.EventHandler(this.CountTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(602, 215);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 52);
            this.ResultTextBox.TabIndex = 9;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Words:";
            // 
            // Words
            // 
            this.Words.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Words.Location = new System.Drawing.Point(493, 285);
            this.Words.Multiline = true;
            this.Words.Name = "Words";
            this.Words.ReadOnly = true;
            this.Words.Size = new System.Drawing.Size(145, 113);
            this.Words.TabIndex = 11;
            this.Words.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ex
            // 
            this.Ex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ex.Location = new System.Drawing.Point(644, 285);
            this.Ex.Multiline = true;
            this.Ex.Name = "Ex";
            this.Ex.ReadOnly = true;
            this.Ex.Size = new System.Drawing.Size(144, 113);
            this.Ex.TabIndex = 12;
            this.Ex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ex.TextChanged += new System.EventHandler(this.Ex_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Letters:";
            // 
            // Reading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.OpenButton);
            this.Name = "Reading";
            this.Text = "Reading";
            this.Load += new System.EventHandler(this.Reading_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.CheckBox manuallyCheckBox;
        private System.Windows.Forms.CheckBox FromFileCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Words;
        private System.Windows.Forms.TextBox Ex;
        private System.Windows.Forms.Label label4;
    }
}