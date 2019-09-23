namespace TestTasks
{
    partial class Task5
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
            this.Assignment1 = new System.Windows.Forms.Label();
            this.Task1Assignment = new System.Windows.Forms.Label();
            this.InputTextBox1 = new System.Windows.Forms.TextBox();
            this.InputLetterstextBox1 = new System.Windows.Forms.TextBox();
            this.SolveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InfLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Assignment1
            // 
            this.Assignment1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Assignment1.BackColor = System.Drawing.SystemColors.Info;
            this.Assignment1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignment1.Location = new System.Drawing.Point(207, 9);
            this.Assignment1.Name = "Assignment1";
            this.Assignment1.Size = new System.Drawing.Size(545, 71);
            this.Assignment1.TabIndex = 7;
            this.Assignment1.Text = "Check if none letter from pattern is in the phrase HasNoneLetters";
            this.Assignment1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task1Assignment
            // 
            this.Task1Assignment.AutoSize = true;
            this.Task1Assignment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task1Assignment.Font = new System.Drawing.Font("Road Rage(RUS BY LYAJKA)", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task1Assignment.Location = new System.Drawing.Point(12, 28);
            this.Task1Assignment.Name = "Task1Assignment";
            this.Task1Assignment.Size = new System.Drawing.Size(183, 40);
            this.Task1Assignment.TabIndex = 6;
            this.Task1Assignment.Text = "Assignment:";
            this.Task1Assignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputTextBox1
            // 
            this.InputTextBox1.Location = new System.Drawing.Point(26, 139);
            this.InputTextBox1.Multiline = true;
            this.InputTextBox1.Name = "InputTextBox1";
            this.InputTextBox1.Size = new System.Drawing.Size(237, 198);
            this.InputTextBox1.TabIndex = 8;
            // 
            // InputLetterstextBox1
            // 
            this.InputLetterstextBox1.Location = new System.Drawing.Point(445, 178);
            this.InputLetterstextBox1.Name = "InputLetterstextBox1";
            this.InputLetterstextBox1.Size = new System.Drawing.Size(237, 22);
            this.InputLetterstextBox1.TabIndex = 9;
            // 
            // SolveButton
            // 
            this.SolveButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SolveButton.Font = new System.Drawing.Font("Road Rage", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolveButton.Location = new System.Drawing.Point(269, 283);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(172, 54);
            this.SolveButton.TabIndex = 10;
            this.SolveButton.Text = "Run";
            this.SolveButton.UseVisualStyleBackColor = false;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Your Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Letters you want to check";
            // 
            // InfLabel
            // 
            this.InfLabel.BackColor = System.Drawing.SystemColors.Info;
            this.InfLabel.Location = new System.Drawing.Point(448, 283);
            this.InfLabel.Name = "InfLabel";
            this.InfLabel.Size = new System.Drawing.Size(254, 54);
            this.InfLabel.TabIndex = 13;
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.InfLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.InputLetterstextBox1);
            this.Controls.Add(this.InputTextBox1);
            this.Controls.Add(this.Assignment1);
            this.Controls.Add(this.Task1Assignment);
            this.Name = "Task5";
            this.Text = "Task5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Assignment1;
        private System.Windows.Forms.Label Task1Assignment;
        private System.Windows.Forms.TextBox InputTextBox1;
        private System.Windows.Forms.TextBox InputLetterstextBox1;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InfLabel;
    }
}