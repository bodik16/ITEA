namespace VigenèreCipher
{
    partial class Form1
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
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedLabel = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptTextBox.Location = new System.Drawing.Point(57, 63);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.Size = new System.Drawing.Size(853, 68);
            this.EncryptTextBox.TabIndex = 0;
            this.EncryptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EncryptTextBox.TextChanged += new System.EventHandler(this.EncryptedTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text you wont to Encrypt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyLabel
            // 
            this.KeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KeyLabel.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLabel.Location = new System.Drawing.Point(188, 153);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(576, 43);
            this.KeyLabel.TabIndex = 3;
            this.KeyLabel.Text = "Key";
            this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KeyLabel.Visible = false;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.Location = new System.Drawing.Point(194, 226);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(570, 33);
            this.KeyTextBox.TabIndex = 5;
            this.KeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyTextBox.Visible = false;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EncryptButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EncryptButton.Location = new System.Drawing.Point(770, 226);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(112, 33);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Visible = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            this.EncryptButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EncryptButton_MouseClick);
            this.EncryptButton.MouseLeave += new System.EventHandler(this.EncryptButton_MouseLeave);
            this.EncryptButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EncryptButton_MouseMove);
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptedTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EncryptedTextBox.Font = new System.Drawing.Font("Engravers MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedTextBox.ForeColor = System.Drawing.Color.White;
            this.EncryptedTextBox.Location = new System.Drawing.Point(53, 343);
            this.EncryptedTextBox.Multiline = true;
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.ReadOnly = true;
            this.EncryptedTextBox.Size = new System.Drawing.Size(853, 85);
            this.EncryptedTextBox.TabIndex = 7;
            this.EncryptedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EncryptedTextBox.Visible = false;
            this.EncryptedTextBox.TextChanged += new System.EventHandler(this.EncryptedTextBox_TextChanged);
            // 
            // EncryptedLabel
            // 
            this.EncryptedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EncryptedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EncryptedLabel.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedLabel.ForeColor = System.Drawing.Color.White;
            this.EncryptedLabel.Location = new System.Drawing.Point(194, 273);
            this.EncryptedLabel.Name = "EncryptedLabel";
            this.EncryptedLabel.Size = new System.Drawing.Size(570, 55);
            this.EncryptedLabel.TabIndex = 8;
            this.EncryptedLabel.Text = "Encrypted Text";
            this.EncryptedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EncryptedLabel.Visible = false;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DecryptButton.Location = new System.Drawing.Point(770, 434);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(112, 33);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Visible = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            this.DecryptButton.MouseLeave += new System.EventHandler(this.DecryptButton_MouseLeave);
            this.DecryptButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DecryptButton_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptedLabel);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.Label EncryptedLabel;
        private System.Windows.Forms.Button DecryptButton;
    }
}

