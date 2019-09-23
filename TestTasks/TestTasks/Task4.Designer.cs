namespace TestTasks
{
    partial class Task4
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
            this.CountriescheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Assignment1 = new System.Windows.Forms.Label();
            this.Task1Assignment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCountryButton = new System.Windows.Forms.Button();
            this.CountryNameTextBox = new System.Windows.Forms.TextBox();
            this.CountryPopulationTExtBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PopulationLabel = new System.Windows.Forms.Label();
            this.AddCountryButtonFinally = new System.Windows.Forms.Button();
            this.InfLabel4 = new System.Windows.Forms.Label();
            this.AveragePopulationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AveragePopulationLabelEveryCountriesFromList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountriescheckedListBox1
            // 
            this.CountriescheckedListBox1.FormattingEnabled = true;
            this.CountriescheckedListBox1.Location = new System.Drawing.Point(12, 114);
            this.CountriescheckedListBox1.Name = "CountriescheckedListBox1";
            this.CountriescheckedListBox1.Size = new System.Drawing.Size(255, 310);
            this.CountriescheckedListBox1.TabIndex = 0;
            this.CountriescheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.CountriescheckedListBox1_SelectedIndexChanged);
            // 
            // Assignment1
            // 
            this.Assignment1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Assignment1.BackColor = System.Drawing.SystemColors.Info;
            this.Assignment1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignment1.Location = new System.Drawing.Point(211, 30);
            this.Assignment1.Name = "Assignment1";
            this.Assignment1.Size = new System.Drawing.Size(545, 40);
            this.Assignment1.TabIndex = 5;
            this.Assignment1.Text = "Calculate Average population\r\n\r\n";
            this.Assignment1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task1Assignment
            // 
            this.Task1Assignment.AutoSize = true;
            this.Task1Assignment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task1Assignment.Font = new System.Drawing.Font("Road Rage(RUS BY LYAJKA)", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task1Assignment.Location = new System.Drawing.Point(12, 30);
            this.Task1Assignment.Name = "Task1Assignment";
            this.Task1Assignment.Size = new System.Drawing.Size(183, 40);
            this.Task1Assignment.TabIndex = 4;
            this.Task1Assignment.Text = "Assignment:";
            this.Task1Assignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "List of Countries";
            // 
            // AddCountryButton
            // 
            this.AddCountryButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCountryButton.Font = new System.Drawing.Font("Road Rage", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCountryButton.Location = new System.Drawing.Point(286, 114);
            this.AddCountryButton.Name = "AddCountryButton";
            this.AddCountryButton.Size = new System.Drawing.Size(137, 48);
            this.AddCountryButton.TabIndex = 7;
            this.AddCountryButton.Text = "Add";
            this.AddCountryButton.UseVisualStyleBackColor = false;
            this.AddCountryButton.Click += new System.EventHandler(this.AddCountryButton_Click);
            // 
            // CountryNameTextBox
            // 
            this.CountryNameTextBox.Location = new System.Drawing.Point(541, 109);
            this.CountryNameTextBox.Name = "CountryNameTextBox";
            this.CountryNameTextBox.Size = new System.Drawing.Size(156, 22);
            this.CountryNameTextBox.TabIndex = 8;
            this.CountryNameTextBox.Visible = false;
            this.CountryNameTextBox.TextChanged += new System.EventHandler(this.CountryNameTextBox_TextChanged);
            // 
            // CountryPopulationTExtBox
            // 
            this.CountryPopulationTExtBox.Location = new System.Drawing.Point(541, 138);
            this.CountryPopulationTExtBox.Name = "CountryPopulationTExtBox";
            this.CountryPopulationTExtBox.Size = new System.Drawing.Size(156, 22);
            this.CountryPopulationTExtBox.TabIndex = 9;
            this.CountryPopulationTExtBox.Visible = false;
            this.CountryPopulationTExtBox.TextChanged += new System.EventHandler(this.CountryPopulationTExtBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(442, 114);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            this.NameLabel.Visible = false;
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.AutoSize = true;
            this.PopulationLabel.Location = new System.Drawing.Point(442, 143);
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(75, 17);
            this.PopulationLabel.TabIndex = 11;
            this.PopulationLabel.Text = "Population";
            this.PopulationLabel.Visible = false;
            // 
            // AddCountryButtonFinally
            // 
            this.AddCountryButtonFinally.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCountryButtonFinally.Location = new System.Drawing.Point(703, 109);
            this.AddCountryButtonFinally.Name = "AddCountryButtonFinally";
            this.AddCountryButtonFinally.Size = new System.Drawing.Size(85, 53);
            this.AddCountryButtonFinally.TabIndex = 12;
            this.AddCountryButtonFinally.Text = "Add Country";
            this.AddCountryButtonFinally.UseVisualStyleBackColor = false;
            this.AddCountryButtonFinally.Visible = false;
            this.AddCountryButtonFinally.Click += new System.EventHandler(this.AddCountryButtonFinally_Click);
            // 
            // InfLabel4
            // 
            this.InfLabel4.BackColor = System.Drawing.SystemColors.Info;
            this.InfLabel4.Location = new System.Drawing.Point(296, 386);
            this.InfLabel4.Name = "InfLabel4";
            this.InfLabel4.Size = new System.Drawing.Size(335, 55);
            this.InfLabel4.TabIndex = 13;
            // 
            // AveragePopulationLabel
            // 
            this.AveragePopulationLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AveragePopulationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveragePopulationLabel.Location = new System.Drawing.Point(294, 216);
            this.AveragePopulationLabel.Name = "AveragePopulationLabel";
            this.AveragePopulationLabel.Size = new System.Drawing.Size(223, 148);
            this.AveragePopulationLabel.TabIndex = 14;
            this.AveragePopulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Average Population";
            // 
            // AveragePopulationLabelEveryCountriesFromList
            // 
            this.AveragePopulationLabelEveryCountriesFromList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AveragePopulationLabelEveryCountriesFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveragePopulationLabelEveryCountriesFromList.Location = new System.Drawing.Point(536, 216);
            this.AveragePopulationLabelEveryCountriesFromList.Name = "AveragePopulationLabelEveryCountriesFromList";
            this.AveragePopulationLabelEveryCountriesFromList.Size = new System.Drawing.Size(252, 148);
            this.AveragePopulationLabelEveryCountriesFromList.TabIndex = 16;
            this.AveragePopulationLabelEveryCountriesFromList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Average Population";
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AveragePopulationLabelEveryCountriesFromList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AveragePopulationLabel);
            this.Controls.Add(this.InfLabel4);
            this.Controls.Add(this.AddCountryButtonFinally);
            this.Controls.Add(this.PopulationLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CountryPopulationTExtBox);
            this.Controls.Add(this.CountryNameTextBox);
            this.Controls.Add(this.AddCountryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Assignment1);
            this.Controls.Add(this.Task1Assignment);
            this.Controls.Add(this.CountriescheckedListBox1);
            this.Name = "Task4";
            this.Text = "Task4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CountriescheckedListBox1;
        private System.Windows.Forms.Label Assignment1;
        private System.Windows.Forms.Label Task1Assignment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCountryButton;
        private System.Windows.Forms.TextBox CountryNameTextBox;
        private System.Windows.Forms.TextBox CountryPopulationTExtBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PopulationLabel;
        private System.Windows.Forms.Button AddCountryButtonFinally;
        private System.Windows.Forms.Label InfLabel4;
        private System.Windows.Forms.Label AveragePopulationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AveragePopulationLabelEveryCountriesFromList;
        private System.Windows.Forms.Label label4;
    }
}