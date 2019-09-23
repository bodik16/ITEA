namespace parallel_lab4
{
    partial class ClickDrawForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Drawcheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonEllipseClick = new System.Windows.Forms.RadioButton();
            this.RadioButtonSquareClick = new System.Windows.Forms.RadioButton();
            this.RadioButtonRectangleClick = new System.Windows.Forms.RadioButton();
            this.RadioButtonCircleClick = new System.Windows.Forms.RadioButton();
            this.LoopCheck = new System.Windows.Forms.CheckBox();
            this.ClearButtonClickDrawing = new System.Windows.Forms.Button();
            this.CloseButtonClickDrawing = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Xpoint = new System.Windows.Forms.TextBox();
            this.Ypoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Xposition = new System.Windows.Forms.TextBox();
            this.Yposition = new System.Windows.Forms.TextBox();
            this.ClickDrawPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Shapewidth = new System.Windows.Forms.TextBox();
            this.Shapeheight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FreeDrawingCheck = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Elastic = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(911, 63);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(260, 344);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.Click += new System.EventHandler(this.CheckedListBox1_Click);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // Drawcheck
            // 
            this.Drawcheck.AutoSize = true;
            this.Drawcheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Drawcheck.Location = new System.Drawing.Point(127, 3);
            this.Drawcheck.Name = "Drawcheck";
            this.Drawcheck.Size = new System.Drawing.Size(132, 21);
            this.Drawcheck.TabIndex = 1;
            this.Drawcheck.Text = "Draw by click     ";
            this.Drawcheck.UseVisualStyleBackColor = false;
            this.Drawcheck.CheckedChanged += new System.EventHandler(this.Drawcheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.RadioButtonEllipseClick);
            this.panel1.Controls.Add(this.RadioButtonSquareClick);
            this.panel1.Controls.Add(this.RadioButtonRectangleClick);
            this.panel1.Controls.Add(this.RadioButtonCircleClick);
            this.panel1.Location = new System.Drawing.Point(16, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 58);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // RadioButtonEllipseClick
            // 
            this.RadioButtonEllipseClick.AutoSize = true;
            this.RadioButtonEllipseClick.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonEllipseClick.Location = new System.Drawing.Point(103, 31);
            this.RadioButtonEllipseClick.Name = "RadioButtonEllipseClick";
            this.RadioButtonEllipseClick.Size = new System.Drawing.Size(74, 21);
            this.RadioButtonEllipseClick.TabIndex = 3;
            this.RadioButtonEllipseClick.TabStop = true;
            this.RadioButtonEllipseClick.Text = "Ellipse ";
            this.RadioButtonEllipseClick.UseVisualStyleBackColor = false;
            this.RadioButtonEllipseClick.CheckedChanged += new System.EventHandler(this.RadioButtonEllipseClick_CheckedChanged);
            // 
            // RadioButtonSquareClick
            // 
            this.RadioButtonSquareClick.AutoSize = true;
            this.RadioButtonSquareClick.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonSquareClick.Location = new System.Drawing.Point(104, 4);
            this.RadioButtonSquareClick.Name = "RadioButtonSquareClick";
            this.RadioButtonSquareClick.Size = new System.Drawing.Size(75, 21);
            this.RadioButtonSquareClick.TabIndex = 2;
            this.RadioButtonSquareClick.TabStop = true;
            this.RadioButtonSquareClick.Text = "Square";
            this.RadioButtonSquareClick.UseVisualStyleBackColor = false;
            this.RadioButtonSquareClick.CheckedChanged += new System.EventHandler(this.RadioButtonSquareClick_CheckedChanged);
            // 
            // RadioButtonRectangleClick
            // 
            this.RadioButtonRectangleClick.AutoSize = true;
            this.RadioButtonRectangleClick.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonRectangleClick.Location = new System.Drawing.Point(4, 31);
            this.RadioButtonRectangleClick.Name = "RadioButtonRectangleClick";
            this.RadioButtonRectangleClick.Size = new System.Drawing.Size(93, 21);
            this.RadioButtonRectangleClick.TabIndex = 1;
            this.RadioButtonRectangleClick.TabStop = true;
            this.RadioButtonRectangleClick.Text = "Rectangle";
            this.RadioButtonRectangleClick.UseVisualStyleBackColor = false;
            this.RadioButtonRectangleClick.CheckedChanged += new System.EventHandler(this.RadioButtonRectangleClick_CheckedChanged);
            // 
            // RadioButtonCircleClick
            // 
            this.RadioButtonCircleClick.AutoSize = true;
            this.RadioButtonCircleClick.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonCircleClick.Location = new System.Drawing.Point(4, 4);
            this.RadioButtonCircleClick.Name = "RadioButtonCircleClick";
            this.RadioButtonCircleClick.Size = new System.Drawing.Size(92, 21);
            this.RadioButtonCircleClick.TabIndex = 0;
            this.RadioButtonCircleClick.TabStop = true;
            this.RadioButtonCircleClick.Text = " Circle      ";
            this.RadioButtonCircleClick.UseVisualStyleBackColor = false;
            this.RadioButtonCircleClick.CheckedChanged += new System.EventHandler(this.RadioButtonCircleClick_CheckedChanged);
            // 
            // LoopCheck
            // 
            this.LoopCheck.AutoSize = true;
            this.LoopCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoopCheck.Location = new System.Drawing.Point(127, 30);
            this.LoopCheck.Name = "LoopCheck";
            this.LoopCheck.Size = new System.Drawing.Size(131, 21);
            this.LoopCheck.TabIndex = 4;
            this.LoopCheck.Text = "Loop of drawing";
            this.LoopCheck.UseVisualStyleBackColor = false;
            this.LoopCheck.CheckedChanged += new System.EventHandler(this.LoopCheck_CheckedChanged);
            // 
            // ClearButtonClickDrawing
            // 
            this.ClearButtonClickDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButtonClickDrawing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButtonClickDrawing.Location = new System.Drawing.Point(815, 549);
            this.ClearButtonClickDrawing.Name = "ClearButtonClickDrawing";
            this.ClearButtonClickDrawing.Size = new System.Drawing.Size(99, 54);
            this.ClearButtonClickDrawing.TabIndex = 6;
            this.ClearButtonClickDrawing.Text = "Clear";
            this.ClearButtonClickDrawing.UseVisualStyleBackColor = false;
            this.ClearButtonClickDrawing.Click += new System.EventHandler(this.ClearButtonClickDrawing_Click);
            // 
            // CloseButtonClickDrawing
            // 
            this.CloseButtonClickDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonClickDrawing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButtonClickDrawing.Location = new System.Drawing.Point(1062, 553);
            this.CloseButtonClickDrawing.Name = "CloseButtonClickDrawing";
            this.CloseButtonClickDrawing.Size = new System.Drawing.Size(99, 55);
            this.CloseButtonClickDrawing.TabIndex = 7;
            this.CloseButtonClickDrawing.Text = "Close";
            this.CloseButtonClickDrawing.UseVisualStyleBackColor = false;
            this.CloseButtonClickDrawing.Click += new System.EventHandler(this.CloseButtonClickDrawing_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(605, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 620);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(393, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pen width";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Xpoint
            // 
            this.Xpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Xpoint.Location = new System.Drawing.Point(1017, 11);
            this.Xpoint.Multiline = true;
            this.Xpoint.Name = "Xpoint";
            this.Xpoint.Size = new System.Drawing.Size(61, 21);
            this.Xpoint.TabIndex = 0;
            this.Xpoint.TextChanged += new System.EventHandler(this.Xpoint_TextChanged);
            // 
            // Ypoint
            // 
            this.Ypoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ypoint.Location = new System.Drawing.Point(1017, 39);
            this.Ypoint.Multiline = true;
            this.Ypoint.Name = "Ypoint";
            this.Ypoint.Size = new System.Drawing.Size(61, 22);
            this.Ypoint.TabIndex = 16;
            this.Ypoint.TextChanged += new System.EventHandler(this.Ypoint_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(981, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = ":X:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(982, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = ":Y:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1086, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 19;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Xposition
            // 
            this.Xposition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Xposition.BackColor = System.Drawing.Color.Lime;
            this.Xposition.Location = new System.Drawing.Point(911, 11);
            this.Xposition.Multiline = true;
            this.Xposition.Name = "Xposition";
            this.Xposition.ReadOnly = true;
            this.Xposition.Size = new System.Drawing.Size(61, 22);
            this.Xposition.TabIndex = 20;
            this.Xposition.TextChanged += new System.EventHandler(this.Xposition_TextChanged);
            // 
            // Yposition
            // 
            this.Yposition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Yposition.BackColor = System.Drawing.Color.Lime;
            this.Yposition.Location = new System.Drawing.Point(911, 40);
            this.Yposition.Multiline = true;
            this.Yposition.Name = "Yposition";
            this.Yposition.ReadOnly = true;
            this.Yposition.Size = new System.Drawing.Size(61, 22);
            this.Yposition.TabIndex = 21;
            // 
            // ClickDrawPanel
            // 
            this.ClickDrawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClickDrawPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClickDrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClickDrawPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClickDrawPanel.Location = new System.Drawing.Point(16, 66);
            this.ClickDrawPanel.Name = "ClickDrawPanel";
            this.ClickDrawPanel.Size = new System.Drawing.Size(889, 478);
            this.ClickDrawPanel.TabIndex = 22;
            this.ClickDrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ClickDrawPanel_Paint);
            this.ClickDrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickDrawPanel_MouseClick_1);
            this.ClickDrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDrawPanel_MouseDown);
            this.ClickDrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickDrawPanel_MouseMove_1);
            this.ClickDrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickDrawPanel_MouseUp);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Open",
            "Save"});
            this.comboBox1.Location = new System.Drawing.Point(13, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.FormatStringChanged += new System.EventHandler(this.ComboBox1_FormatStringChanged);
            // 
            // Shapewidth
            // 
            this.Shapewidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Shapewidth.Location = new System.Drawing.Point(393, 553);
            this.Shapewidth.Name = "Shapewidth";
            this.Shapewidth.Size = new System.Drawing.Size(33, 22);
            this.Shapewidth.TabIndex = 25;
            this.Shapewidth.TextChanged += new System.EventHandler(this.Shapewidth_TextChanged);
            // 
            // Shapeheight
            // 
            this.Shapeheight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Shapeheight.Location = new System.Drawing.Point(393, 581);
            this.Shapeheight.Name = "Shapeheight";
            this.Shapeheight.Size = new System.Drawing.Size(33, 22);
            this.Shapeheight.TabIndex = 26;
            this.Shapeheight.ReadOnlyChanged += new System.EventHandler(this.Shapeheight_ReadOnlyChanged);
            this.Shapeheight.TextChanged += new System.EventHandler(this.Shapeheight_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Shape width:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Shape height:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // FreeDrawingCheck
            // 
            this.FreeDrawingCheck.AutoSize = true;
            this.FreeDrawingCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FreeDrawingCheck.Location = new System.Drawing.Point(272, 3);
            this.FreeDrawingCheck.Name = "FreeDrawingCheck";
            this.FreeDrawingCheck.Size = new System.Drawing.Size(112, 21);
            this.FreeDrawingCheck.TabIndex = 34;
            this.FreeDrawingCheck.Text = "Free drawing";
            this.FreeDrawingCheck.UseVisualStyleBackColor = false;
            this.FreeDrawingCheck.CheckedChanged += new System.EventHandler(this.FreeDrawingCheck_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(465, 5);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(440, 56);
            this.trackBar1.TabIndex = 35;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Save/Open";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(710, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 54);
            this.button4.TabIndex = 38;
            this.button4.Text = "Cut";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(272, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 21);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Cut               ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(941, 553);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 55);
            this.BackButton.TabIndex = 40;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(912, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(915, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 108);
            this.label8.TabIndex = 42;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Elastic
            // 
            this.Elastic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Elastic.AutoSize = true;
            this.Elastic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Elastic.Location = new System.Drawing.Point(504, 571);
            this.Elastic.Name = "Elastic";
            this.Elastic.Size = new System.Drawing.Size(95, 21);
            this.Elastic.TabIndex = 44;
            this.Elastic.Text = "Elastic      ";
            this.Elastic.UseVisualStyleBackColor = false;
            this.Elastic.CheckedChanged += new System.EventHandler(this.Elastic_CheckedChanged);
            // 
            // ClickDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1180, 620);
            this.Controls.Add(this.Elastic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FreeDrawingCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Shapeheight);
            this.Controls.Add(this.Shapewidth);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClickDrawPanel);
            this.Controls.Add(this.Xposition);
            this.Controls.Add(this.Yposition);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ypoint);
            this.Controls.Add(this.Xpoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.CloseButtonClickDrawing);
            this.Controls.Add(this.ClearButtonClickDrawing);
            this.Controls.Add(this.LoopCheck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Drawcheck);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "ClickDrawForm";
            this.Text = "ClickDrawForm";
            this.Load += new System.EventHandler(this.ClickDrawForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickDrawForm_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox Drawcheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButtonSquareClick;
        private System.Windows.Forms.RadioButton RadioButtonRectangleClick;
        private System.Windows.Forms.RadioButton RadioButtonCircleClick;
        private System.Windows.Forms.RadioButton RadioButtonEllipseClick;
        private System.Windows.Forms.CheckBox LoopCheck;
        private System.Windows.Forms.Button ClearButtonClickDrawing;
        private System.Windows.Forms.Button CloseButtonClickDrawing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Xpoint;
        private System.Windows.Forms.TextBox Ypoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Xposition;
        private System.Windows.Forms.TextBox Yposition;
        private System.Windows.Forms.Panel ClickDrawPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Shapewidth;
        private System.Windows.Forms.TextBox Shapeheight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox FreeDrawingCheck;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Elastic;
    }
}