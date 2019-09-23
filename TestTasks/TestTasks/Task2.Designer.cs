namespace TestTasks
{
    partial class Task2
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
            this.MainTextMox2 = new System.Windows.Forms.TextBox();
            this.InputTextLabel1 = new System.Windows.Forms.Label();
            this.LastLetterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfLabel2 = new System.Windows.Forms.Label();
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
            this.Task1Assignment.TabIndex = 1;
            this.Task1Assignment.Text = "Assignment:";
            this.Task1Assignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assignment1
            // 
            this.Assignment1.BackColor = System.Drawing.SystemColors.Info;
            this.Assignment1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignment1.Location = new System.Drawing.Point(220, 9);
            this.Assignment1.Name = "Assignment1";
            this.Assignment1.Size = new System.Drawing.Size(548, 40);
            this.Assignment1.TabIndex = 2;
            this.Assignment1.Text = "Get last character of the string GetLastCharacter";
            this.Assignment1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTextMox2
            // 
            this.MainTextMox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextMox2.Location = new System.Drawing.Point(12, 85);
            this.MainTextMox2.Multiline = true;
            this.MainTextMox2.Name = "MainTextMox2";
            this.MainTextMox2.Size = new System.Drawing.Size(396, 304);
            this.MainTextMox2.TabIndex = 3;
            this.MainTextMox2.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // InputTextLabel1
            // 
            this.InputTextLabel1.AutoSize = true;
            this.InputTextLabel1.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.InputTextLabel1.Location = new System.Drawing.Point(105, 61);
            this.InputTextLabel1.Name = "InputTextLabel1";
            this.InputTextLabel1.Size = new System.Drawing.Size(211, 21);
            this.InputTextLabel1.TabIndex = 4;
            this.InputTextLabel1.Text = "Input the text below";
            // 
            // LastLetterTextBox
            // 
            this.LastLetterTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LastLetterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastLetterTextBox.Font = new System.Drawing.Font("Ravie", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLetterTextBox.Location = new System.Drawing.Point(467, 96);
            this.LastLetterTextBox.Multiline = true;
            this.LastLetterTextBox.Name = "LastLetterTextBox";
            this.LastLetterTextBox.ReadOnly = true;
            this.LastLetterTextBox.Size = new System.Drawing.Size(282, 252);
            this.LastLetterTextBox.TabIndex = 5;
            this.LastLetterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last letter is";
            // 
            // InfLabel2
            // 
            this.InfLabel2.AutoSize = true;
            this.InfLabel2.BackColor = System.Drawing.SystemColors.Info;
            this.InfLabel2.Location = new System.Drawing.Point(464, 360);
            this.InfLabel2.Name = "InfLabel2";
            this.InfLabel2.Size = new System.Drawing.Size(86, 17);
            this.InfLabel2.TabIndex = 7;
            this.InfLabel2.Text = "*_ _ - Space";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.InfLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastLetterTextBox);
            this.Controls.Add(this.InputTextLabel1);
            this.Controls.Add(this.MainTextMox2);
            this.Controls.Add(this.Assignment1);
            this.Controls.Add(this.Task1Assignment);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Task1Assignment;
        private System.Windows.Forms.Label Assignment1;
        private System.Windows.Forms.TextBox MainTextMox2;
        private System.Windows.Forms.Label InputTextLabel1;
        private System.Windows.Forms.TextBox LastLetterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfLabel2;
    }
}