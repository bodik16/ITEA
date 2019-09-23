namespace TestTasks
{
    partial class Task3
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
            this.InputTextLabel1 = new System.Windows.Forms.Label();
            this.InputArrTextBox = new System.Windows.Forms.TextBox();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InfLabel = new System.Windows.Forms.Label();
            this.OpenButton3 = new System.Windows.Forms.Button();
            this.ReadFromFileCheckBox = new System.Windows.Forms.CheckBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1Assignment
            // 
            this.Task1Assignment.AutoSize = true;
            this.Task1Assignment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task1Assignment.Font = new System.Drawing.Font("Road Rage(RUS BY LYAJKA)", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task1Assignment.Location = new System.Drawing.Point(12, 31);
            this.Task1Assignment.Name = "Task1Assignment";
            this.Task1Assignment.Size = new System.Drawing.Size(183, 40);
            this.Task1Assignment.TabIndex = 2;
            this.Task1Assignment.Text = "Assignment:";
            this.Task1Assignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assignment1
            // 
            this.Assignment1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Assignment1.BackColor = System.Drawing.SystemColors.Info;
            this.Assignment1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignment1.Location = new System.Drawing.Point(211, 9);
            this.Assignment1.Name = "Assignment1";
            this.Assignment1.Size = new System.Drawing.Size(545, 77);
            this.Assignment1.TabIndex = 3;
            this.Assignment1.Text = "Find smallest element in the array FindSmallestElement";
            this.Assignment1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputTextLabel1
            // 
            this.InputTextLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputTextLabel1.AutoSize = true;
            this.InputTextLabel1.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.InputTextLabel1.Location = new System.Drawing.Point(36, 99);
            this.InputTextLabel1.Name = "InputTextLabel1";
            this.InputTextLabel1.Size = new System.Drawing.Size(274, 21);
            this.InputTextLabel1.TabIndex = 5;
            this.InputTextLabel1.Text = "Input the array below by \',\'\r\n";
            // 
            // InputArrTextBox
            // 
            this.InputArrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputArrTextBox.Location = new System.Drawing.Point(12, 129);
            this.InputArrTextBox.Multiline = true;
            this.InputArrTextBox.Name = "InputArrTextBox";
            this.InputArrTextBox.Size = new System.Drawing.Size(328, 256);
            this.InputArrTextBox.TabIndex = 6;
            this.InputArrTextBox.TextChanged += new System.EventHandler(this.InputArrTextBox_TextChanged);
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinValueLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinValueLabel.Font = new System.Drawing.Font("Road Rage", 42F);
            this.MinValueLabel.Location = new System.Drawing.Point(440, 145);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(265, 225);
            this.MinValueLabel.TabIndex = 7;
            this.MinValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Smallest element is";
            // 
            // InfLabel
            // 
            this.InfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfLabel.BackColor = System.Drawing.SystemColors.Info;
            this.InfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfLabel.Location = new System.Drawing.Point(380, 388);
            this.InfLabel.Name = "InfLabel";
            this.InfLabel.Size = new System.Drawing.Size(363, 53);
            this.InfLabel.TabIndex = 9;
            // 
            // OpenButton3
            // 
            this.OpenButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenButton3.Location = new System.Drawing.Point(12, 391);
            this.OpenButton3.Name = "OpenButton3";
            this.OpenButton3.Size = new System.Drawing.Size(100, 50);
            this.OpenButton3.TabIndex = 10;
            this.OpenButton3.Text = "Open";
            this.OpenButton3.UseVisualStyleBackColor = false;
            this.OpenButton3.Visible = false;
            this.OpenButton3.Click += new System.EventHandler(this.OpenButton3_Click);
            // 
            // ReadFromFileCheckBox
            // 
            this.ReadFromFileCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReadFromFileCheckBox.AutoSize = true;
            this.ReadFromFileCheckBox.Location = new System.Drawing.Point(339, 102);
            this.ReadFromFileCheckBox.Name = "ReadFromFileCheckBox";
            this.ReadFromFileCheckBox.Size = new System.Drawing.Size(156, 21);
            this.ReadFromFileCheckBox.TabIndex = 11;
            this.ReadFromFileCheckBox.Text = "Read Array from file";
            this.ReadFromFileCheckBox.UseVisualStyleBackColor = true;
            this.ReadFromFileCheckBox.CheckedChanged += new System.EventHandler(this.ReadFromFileCheckBox_CheckedChanged);
            // 
            // CalcButton
            // 
            this.CalcButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CalcButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalcButton.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.Location = new System.Drawing.Point(240, 391);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(100, 50);
            this.CalcButton.TabIndex = 12;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = false;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.ReadFromFileCheckBox);
            this.Controls.Add(this.OpenButton3);
            this.Controls.Add(this.InfLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinValueLabel);
            this.Controls.Add(this.InputArrTextBox);
            this.Controls.Add(this.InputTextLabel1);
            this.Controls.Add(this.Assignment1);
            this.Controls.Add(this.Task1Assignment);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Task1Assignment;
        private System.Windows.Forms.Label Assignment1;
        private System.Windows.Forms.Label InputTextLabel1;
        private System.Windows.Forms.TextBox InputArrTextBox;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InfLabel;
        private System.Windows.Forms.Button OpenButton3;
        private System.Windows.Forms.CheckBox ReadFromFileCheckBox;
        private System.Windows.Forms.Button CalcButton;
    }
}