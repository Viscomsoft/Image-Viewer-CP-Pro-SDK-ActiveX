namespace WindowsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.changeButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.button150 = new System.Windows.Forms.Button();
            this.button200 = new System.Windows.Forms.Button();
            this.fitButton = new System.Windows.Forms.Button();
            this.zoomWidthButton = new System.Windows.Forms.Button();
            this.zoomHeightButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borderOffRadioButton = new System.Windows.Forms.RadioButton();
            this.borderOnRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.highQOffRadioButton = new System.Windows.Forms.RadioButton();
            this.highQOnRadioButton = new System.Windows.Forms.RadioButton();
            this.selRectPosLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clearSelButton = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.backColorButton = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.flipHButton = new System.Windows.Forms.Button();
            this.flipVButton = new System.Windows.Forms.Button();
            this.advRotateButton = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.radioButton90 = new System.Windows.Forms.RadioButton();
            this.radioButton270 = new System.Windows.Forms.RadioButton();
            this.radioButton180 = new System.Windows.Forms.RadioButton();
            this.rotLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.rotRightRadioButton = new System.Windows.Forms.RadioButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtelapse = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcurpage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalpage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(12, 12);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(104, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Open";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(12, 41);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(104, 23);
            this.rotateButton.TabIndex = 3;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(12, 70);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(104, 23);
            this.button25.TabIndex = 4;
            this.button25.Text = " 25% of Original";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(12, 99);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(104, 23);
            this.button33.TabIndex = 5;
            this.button33.Text = " 33% of Original";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(12, 128);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(104, 23);
            this.button50.TabIndex = 6;
            this.button50.Text = " 50% of Original";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // button75
            // 
            this.button75.Location = new System.Drawing.Point(12, 157);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(104, 23);
            this.button75.TabIndex = 7;
            this.button75.Text = " 75% of Original";
            this.button75.UseVisualStyleBackColor = true;
            this.button75.Click += new System.EventHandler(this.button75_Click);
            // 
            // button100
            // 
            this.button100.Location = new System.Drawing.Point(12, 186);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(104, 23);
            this.button100.TabIndex = 8;
            this.button100.Text = "100% of Original";
            this.button100.UseVisualStyleBackColor = true;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // button150
            // 
            this.button150.Location = new System.Drawing.Point(12, 215);
            this.button150.Name = "button150";
            this.button150.Size = new System.Drawing.Size(104, 23);
            this.button150.TabIndex = 9;
            this.button150.Text = "150% of Original";
            this.button150.UseVisualStyleBackColor = true;
            this.button150.Click += new System.EventHandler(this.button150_Click);
            // 
            // button200
            // 
            this.button200.Location = new System.Drawing.Point(12, 244);
            this.button200.Name = "button200";
            this.button200.Size = new System.Drawing.Size(104, 23);
            this.button200.TabIndex = 10;
            this.button200.Text = "200% of Original";
            this.button200.UseVisualStyleBackColor = true;
            this.button200.Click += new System.EventHandler(this.button200_Click);
            // 
            // fitButton
            // 
            this.fitButton.Location = new System.Drawing.Point(12, 273);
            this.fitButton.Name = "fitButton";
            this.fitButton.Size = new System.Drawing.Size(104, 39);
            this.fitButton.TabIndex = 11;
            this.fitButton.Text = "Fit to Window\r\n(aspect ratio)";
            this.fitButton.UseVisualStyleBackColor = true;
            this.fitButton.Click += new System.EventHandler(this.fitButton_Click);
            // 
            // zoomWidthButton
            // 
            this.zoomWidthButton.Location = new System.Drawing.Point(12, 347);
            this.zoomWidthButton.Name = "zoomWidthButton";
            this.zoomWidthButton.Size = new System.Drawing.Size(104, 23);
            this.zoomWidthButton.TabIndex = 12;
            this.zoomWidthButton.Text = "Zoom to Width";
            this.zoomWidthButton.UseVisualStyleBackColor = true;
            this.zoomWidthButton.Click += new System.EventHandler(this.zoomWidthButton_Click);
            // 
            // zoomHeightButton
            // 
            this.zoomHeightButton.Location = new System.Drawing.Point(13, 372);
            this.zoomHeightButton.Name = "zoomHeightButton";
            this.zoomHeightButton.Size = new System.Drawing.Size(104, 23);
            this.zoomHeightButton.TabIndex = 13;
            this.zoomHeightButton.Text = "Zoom to Height";
            this.zoomHeightButton.UseVisualStyleBackColor = true;
            this.zoomHeightButton.Click += new System.EventHandler(this.zoomHeightButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(12, 401);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(104, 23);
            this.zoomInButton.TabIndex = 14;
            this.zoomInButton.Text = "Zoom In";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(13, 430);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(104, 23);
            this.zoomOutButton.TabIndex = 15;
            this.zoomOutButton.Text = "Zoom Out";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borderOffRadioButton);
            this.groupBox1.Controls.Add(this.borderOnRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 47);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // borderOffRadioButton
            // 
            this.borderOffRadioButton.AutoSize = true;
            this.borderOffRadioButton.Location = new System.Drawing.Point(54, 20);
            this.borderOffRadioButton.Name = "borderOffRadioButton";
            this.borderOffRadioButton.Size = new System.Drawing.Size(45, 17);
            this.borderOffRadioButton.TabIndex = 1;
            this.borderOffRadioButton.Text = "OFF";
            this.borderOffRadioButton.UseVisualStyleBackColor = true;
            this.borderOffRadioButton.Click += new System.EventHandler(this.borderRadioButton_Click);
            // 
            // borderOnRadioButton
            // 
            this.borderOnRadioButton.AutoSize = true;
            this.borderOnRadioButton.Checked = true;
            this.borderOnRadioButton.Location = new System.Drawing.Point(7, 20);
            this.borderOnRadioButton.Name = "borderOnRadioButton";
            this.borderOnRadioButton.Size = new System.Drawing.Size(41, 17);
            this.borderOnRadioButton.TabIndex = 0;
            this.borderOnRadioButton.TabStop = true;
            this.borderOnRadioButton.Text = "ON";
            this.borderOnRadioButton.UseVisualStyleBackColor = true;
            this.borderOnRadioButton.Click += new System.EventHandler(this.borderRadioButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.highQOffRadioButton);
            this.groupBox2.Controls.Add(this.highQOnRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 47);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "High Quality";
            // 
            // highQOffRadioButton
            // 
            this.highQOffRadioButton.AutoSize = true;
            this.highQOffRadioButton.Location = new System.Drawing.Point(54, 20);
            this.highQOffRadioButton.Name = "highQOffRadioButton";
            this.highQOffRadioButton.Size = new System.Drawing.Size(45, 17);
            this.highQOffRadioButton.TabIndex = 1;
            this.highQOffRadioButton.Text = "OFF";
            this.highQOffRadioButton.UseVisualStyleBackColor = true;
            this.highQOffRadioButton.Click += new System.EventHandler(this.highQRadioButton_Click);
            // 
            // highQOnRadioButton
            // 
            this.highQOnRadioButton.AutoSize = true;
            this.highQOnRadioButton.Checked = true;
            this.highQOnRadioButton.Location = new System.Drawing.Point(7, 20);
            this.highQOnRadioButton.Name = "highQOnRadioButton";
            this.highQOnRadioButton.Size = new System.Drawing.Size(41, 17);
            this.highQOnRadioButton.TabIndex = 0;
            this.highQOnRadioButton.TabStop = true;
            this.highQOnRadioButton.Text = "ON";
            this.highQOnRadioButton.UseVisualStyleBackColor = true;
            this.highQOnRadioButton.Click += new System.EventHandler(this.highQRadioButton_Click);
            // 
            // selRectPosLabel
            // 
            this.selRectPosLabel.Location = new System.Drawing.Point(120, 459);
            this.selRectPosLabel.Name = "selRectPosLabel";
            this.selRectPosLabel.Size = new System.Drawing.Size(153, 59);
            this.selRectPosLabel.TabIndex = 26;
            this.selRectPosLabel.Text = "Selection Rectangle Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(279, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hold down right mouse button for panning";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clearSelButton);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton0);
            this.groupBox4.Location = new System.Drawing.Point(282, 506);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 129);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mouse Mode";
            // 
            // clearSelButton
            // 
            this.clearSelButton.Location = new System.Drawing.Point(214, 81);
            this.clearSelButton.Name = "clearSelButton";
            this.clearSelButton.Size = new System.Drawing.Size(109, 23);
            this.clearSelButton.TabIndex = 5;
            this.clearSelButton.Text = "Clear Selection";
            this.clearSelButton.UseVisualStyleBackColor = true;
            this.clearSelButton.Click += new System.EventHandler(this.clearSelButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 107);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(149, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "(Left mouse Panning Only)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Nothing";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(156, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "(Right mouse Panning Only)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(181, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "(Selection Rectangle + Panning) ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Checked = true;
            this.radioButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton0.Location = new System.Drawing.Point(6, 15);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(317, 17);
            this.radioButton0.TabIndex = 0;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "Default (Include Selection Rectangle + Panning + Auto Zoom)";
            this.radioButton0.UseVisualStyleBackColor = true;
            this.radioButton0.Click += new System.EventHandler(this.radioButton0_Click);
            this.radioButton0.CheckedChanged += new System.EventHandler(this.radioButton0_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(279, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "After Drawn selection Rectangle and hold down shfit key then click left mouse but" +
                "ton you can move the rectangle";
            // 
            // backColorButton
            // 
            this.backColorButton.Location = new System.Drawing.Point(13, 568);
            this.backColorButton.Name = "backColorButton";
            this.backColorButton.Size = new System.Drawing.Size(104, 23);
            this.backColorButton.TabIndex = 1;
            this.backColorButton.Text = "Background Color";
            this.backColorButton.UseVisualStyleBackColor = true;
            this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.flipHButton);
            this.groupBox10.Controls.Add(this.flipVButton);
            this.groupBox10.Controls.Add(this.advRotateButton);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.rotLeftRadioButton);
            this.groupBox10.Controls.Add(this.rotRightRadioButton);
            this.groupBox10.Location = new System.Drawing.Point(624, 488);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(324, 103);
            this.groupBox10.TabIndex = 46;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Advance Rotate";
            // 
            // flipHButton
            // 
            this.flipHButton.Location = new System.Drawing.Point(84, 75);
            this.flipHButton.Name = "flipHButton";
            this.flipHButton.Size = new System.Drawing.Size(95, 23);
            this.flipHButton.TabIndex = 8;
            this.flipHButton.Text = "Flip Horizontal";
            this.flipHButton.UseVisualStyleBackColor = true;
            this.flipHButton.Click += new System.EventHandler(this.flipHButton_Click);
            // 
            // flipVButton
            // 
            this.flipVButton.Location = new System.Drawing.Point(3, 75);
            this.flipVButton.Name = "flipVButton";
            this.flipVButton.Size = new System.Drawing.Size(75, 23);
            this.flipVButton.TabIndex = 7;
            this.flipVButton.Text = "Flip Vertical";
            this.flipVButton.UseVisualStyleBackColor = true;
            this.flipVButton.Click += new System.EventHandler(this.flipVButton_Click);
            // 
            // advRotateButton
            // 
            this.advRotateButton.Location = new System.Drawing.Point(185, 75);
            this.advRotateButton.Name = "advRotateButton";
            this.advRotateButton.Size = new System.Drawing.Size(75, 23);
            this.advRotateButton.TabIndex = 6;
            this.advRotateButton.Text = "OK";
            this.advRotateButton.UseVisualStyleBackColor = true;
            this.advRotateButton.Click += new System.EventHandler(this.advRotateButton_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.radioButton90);
            this.groupBox11.Controls.Add(this.radioButton270);
            this.groupBox11.Controls.Add(this.radioButton180);
            this.groupBox11.Location = new System.Drawing.Point(97, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(213, 52);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            // 
            // radioButton90
            // 
            this.radioButton90.AutoSize = true;
            this.radioButton90.Checked = true;
            this.radioButton90.Location = new System.Drawing.Point(6, 19);
            this.radioButton90.Name = "radioButton90";
            this.radioButton90.Size = new System.Drawing.Size(37, 17);
            this.radioButton90.TabIndex = 2;
            this.radioButton90.TabStop = true;
            this.radioButton90.Text = "90";
            this.radioButton90.UseVisualStyleBackColor = true;
            // 
            // radioButton270
            // 
            this.radioButton270.AutoSize = true;
            this.radioButton270.Location = new System.Drawing.Point(103, 19);
            this.radioButton270.Name = "radioButton270";
            this.radioButton270.Size = new System.Drawing.Size(43, 17);
            this.radioButton270.TabIndex = 4;
            this.radioButton270.Text = "270";
            this.radioButton270.UseVisualStyleBackColor = true;
            // 
            // radioButton180
            // 
            this.radioButton180.AutoSize = true;
            this.radioButton180.Location = new System.Drawing.Point(54, 19);
            this.radioButton180.Name = "radioButton180";
            this.radioButton180.Size = new System.Drawing.Size(43, 17);
            this.radioButton180.TabIndex = 3;
            this.radioButton180.Text = "180";
            this.radioButton180.UseVisualStyleBackColor = true;
            // 
            // rotLeftRadioButton
            // 
            this.rotLeftRadioButton.AutoSize = true;
            this.rotLeftRadioButton.Location = new System.Drawing.Point(6, 42);
            this.rotLeftRadioButton.Name = "rotLeftRadioButton";
            this.rotLeftRadioButton.Size = new System.Drawing.Size(78, 17);
            this.rotLeftRadioButton.TabIndex = 1;
            this.rotLeftRadioButton.Text = "Rotate Left";
            this.rotLeftRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotRightRadioButton
            // 
            this.rotRightRadioButton.AutoSize = true;
            this.rotRightRadioButton.Checked = true;
            this.rotRightRadioButton.Location = new System.Drawing.Point(6, 19);
            this.rotRightRadioButton.Name = "rotRightRadioButton";
            this.rotRightRadioButton.Size = new System.Drawing.Size(85, 17);
            this.rotRightRadioButton.TabIndex = 0;
            this.rotRightRadioButton.TabStop = true;
            this.rotRightRadioButton.Text = "Rotate Right";
            this.rotRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(122, 53);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(464, 387);
            this.axImageViewer1.TabIndex = 50;
            this.axImageViewer1.SelectionRectDrawn += new AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEventHandler(this.axImageViewer1_SelectionRectDrawn_1);
            this.axImageViewer1.DICOMPlaying += new AxSCRIBBLELib._DImageViewerEvents_DICOMPlayingEventHandler(this.axImageViewer1_DICOMPlaying);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Center Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtelapse);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtcurpage);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txttotalpage);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(124, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 56);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Elapse (milliseconds)";
            // 
            // txtelapse
            // 
            this.txtelapse.Location = new System.Drawing.Point(289, 34);
            this.txtelapse.Name = "txtelapse";
            this.txtelapse.Size = new System.Drawing.Size(68, 20);
            this.txtelapse.TabIndex = 6;
            this.txtelapse.Text = "500";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "Display All Frame";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Go to Specific Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtcurpage
            // 
            this.txtcurpage.Location = new System.Drawing.Point(248, 9);
            this.txtcurpage.Name = "txtcurpage";
            this.txtcurpage.Size = new System.Drawing.Size(44, 20);
            this.txtcurpage.TabIndex = 3;
            this.txtcurpage.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Page";
            // 
            // txttotalpage
            // 
            this.txttotalpage.Enabled = false;
            this.txttotalpage.Location = new System.Drawing.Point(84, 9);
            this.txttotalpage.Name = "txttotalpage";
            this.txttotalpage.Size = new System.Drawing.Size(65, 20);
            this.txttotalpage.TabIndex = 1;
            this.txttotalpage.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tags";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(598, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 121);
            this.listBox1.TabIndex = 54;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "SubItems";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(598, 191);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(363, 121);
            this.listBox2.TabIndex = 56;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Values";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(598, 334);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(363, 121);
            this.listBox3.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 678);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axImageViewer1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.backColorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selRectPosLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.zoomHeightButton);
            this.Controls.Add(this.zoomWidthButton);
            this.Controls.Add(this.fitButton);
            this.Controls.Add(this.button200);
            this.Controls.Add(this.button150);
            this.Controls.Add(this.button100);
            this.Controls.Add(this.button75);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.changeButton);
            this.Name = "Form1";
            this.Text = "DICOM Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button75;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button button150;
        private System.Windows.Forms.Button button200;
        private System.Windows.Forms.Button fitButton;
        private System.Windows.Forms.Button zoomWidthButton;
        private System.Windows.Forms.Button zoomHeightButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton borderOffRadioButton;
        private System.Windows.Forms.RadioButton borderOnRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton highQOffRadioButton;
        private System.Windows.Forms.RadioButton highQOnRadioButton;
        private System.Windows.Forms.Label selRectPosLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearSelButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button backColorButton;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radioButton270;
        private System.Windows.Forms.RadioButton radioButton180;
        private System.Windows.Forms.RadioButton radioButton90;
        private System.Windows.Forms.RadioButton rotLeftRadioButton;
        private System.Windows.Forms.RadioButton rotRightRadioButton;
        private System.Windows.Forms.Button flipHButton;
        private System.Windows.Forms.Button flipVButton;
        private System.Windows.Forms.Button advRotateButton;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ColorDialog colorDialog;
        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcurpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtelapse;
    }
}

