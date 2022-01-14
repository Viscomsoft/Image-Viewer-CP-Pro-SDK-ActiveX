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
            this.button1 = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotpage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPageNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optfilter4 = new System.Windows.Forms.RadioButton();
            this.optfilter3 = new System.Windows.Forms.RadioButton();
            this.optfilter2 = new System.Windows.Forms.RadioButton();
            this.optfilter1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optmode3 = new System.Windows.Forms.RadioButton();
            this.optmode2 = new System.Windows.Forms.RadioButton();
            this.optmode1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optlang7 = new System.Windows.Forms.RadioButton();
            this.optlang6 = new System.Windows.Forms.RadioButton();
            this.optlang5 = new System.Windows.Forms.RadioButton();
            this.optlang4 = new System.Windows.Forms.RadioButton();
            this.optlang3 = new System.Windows.Forms.RadioButton();
            this.optlang2 = new System.Windows.Forms.RadioButton();
            this.optlang1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfileheight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfilewidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtleft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkfullpage = new System.Windows.Forms.CheckBox();
            this.btnscan = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.optasync = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkuseadvpdf = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsearchablePDF = new System.Windows.Forms.Button();
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(594, 50);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(65, 25);
            this.btnprev.TabIndex = 2;
            this.btnprev.Text = "<<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(665, 50);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(65, 25);
            this.btnnext.TabIndex = 3;
            this.btnnext.Text = ">>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Enabled = false;
            this.txtfilename.Location = new System.Drawing.Point(477, 95);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(326, 20);
            this.txtfilename.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Page";
            // 
            // txttotpage
            // 
            this.txttotpage.Location = new System.Drawing.Point(554, 129);
            this.txttotpage.Name = "txttotpage";
            this.txttotpage.Size = new System.Drawing.Size(40, 20);
            this.txttotpage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Page No.";
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(676, 129);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(40, 20);
            this.txtPageNo.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optfilter4);
            this.groupBox1.Controls.Add(this.optfilter3);
            this.groupBox1.Controls.Add(this.optfilter2);
            this.groupBox1.Controls.Add(this.optfilter1);
            this.groupBox1.Location = new System.Drawing.Point(722, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Filter";
            // 
            // optfilter4
            // 
            this.optfilter4.AutoSize = true;
            this.optfilter4.Location = new System.Drawing.Point(9, 88);
            this.optfilter4.Name = "optfilter4";
            this.optfilter4.Size = new System.Drawing.Size(149, 17);
            this.optfilter4.TabIndex = 3;
            this.optfilter4.Text = "Recognize lowercase only";
            this.optfilter4.UseVisualStyleBackColor = true;
            // 
            // optfilter3
            // 
            this.optfilter3.AutoSize = true;
            this.optfilter3.Location = new System.Drawing.Point(9, 65);
            this.optfilter3.Name = "optfilter3";
            this.optfilter3.Size = new System.Drawing.Size(151, 17);
            this.optfilter3.TabIndex = 2;
            this.optfilter3.Text = "Recognize uppercase only";
            this.optfilter3.UseVisualStyleBackColor = true;
            // 
            // optfilter2
            // 
            this.optfilter2.AutoSize = true;
            this.optfilter2.Location = new System.Drawing.Point(9, 42);
            this.optfilter2.Name = "optfilter2";
            this.optfilter2.Size = new System.Drawing.Size(138, 17);
            this.optfilter2.TabIndex = 1;
            this.optfilter2.Text = "Recognize numeric only";
            this.optfilter2.UseVisualStyleBackColor = true;
            // 
            // optfilter1
            // 
            this.optfilter1.AutoSize = true;
            this.optfilter1.Checked = true;
            this.optfilter1.Location = new System.Drawing.Point(9, 19);
            this.optfilter1.Name = "optfilter1";
            this.optfilter1.Size = new System.Drawing.Size(64, 17);
            this.optfilter1.TabIndex = 0;
            this.optfilter1.TabStop = true;
            this.optfilter1.Text = "No Filter";
            this.optfilter1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optmode3);
            this.groupBox2.Controls.Add(this.optmode2);
            this.groupBox2.Controls.Add(this.optmode1);
            this.groupBox2.Location = new System.Drawing.Point(481, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognize Mode";
            // 
            // optmode3
            // 
            this.optmode3.AutoSize = true;
            this.optmode3.Location = new System.Drawing.Point(13, 68);
            this.optmode3.Name = "optmode3";
            this.optmode3.Size = new System.Drawing.Size(68, 17);
            this.optmode3.TabIndex = 2;
            this.optmode3.Text = "Excellent";
            this.optmode3.UseVisualStyleBackColor = true;
            // 
            // optmode2
            // 
            this.optmode2.AutoSize = true;
            this.optmode2.Checked = true;
            this.optmode2.Location = new System.Drawing.Point(13, 45);
            this.optmode2.Name = "optmode2";
            this.optmode2.Size = new System.Drawing.Size(58, 17);
            this.optmode2.TabIndex = 1;
            this.optmode2.TabStop = true;
            this.optmode2.Text = "Normal";
            this.optmode2.UseVisualStyleBackColor = true;
            // 
            // optmode1
            // 
            this.optmode1.AutoSize = true;
            this.optmode1.Location = new System.Drawing.Point(13, 22);
            this.optmode1.Name = "optmode1";
            this.optmode1.Size = new System.Drawing.Size(45, 17);
            this.optmode1.TabIndex = 0;
            this.optmode1.Text = "Fast";
            this.optmode1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optlang7);
            this.groupBox3.Controls.Add(this.optlang6);
            this.groupBox3.Controls.Add(this.optlang5);
            this.groupBox3.Controls.Add(this.optlang4);
            this.groupBox3.Controls.Add(this.optlang3);
            this.groupBox3.Controls.Add(this.optlang2);
            this.groupBox3.Controls.Add(this.optlang1);
            this.groupBox3.Location = new System.Drawing.Point(479, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 125);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Language";
            // 
            // optlang7
            // 
            this.optlang7.AutoSize = true;
            this.optlang7.Location = new System.Drawing.Point(111, 78);
            this.optlang7.Name = "optlang7";
            this.optlang7.Size = new System.Drawing.Size(63, 17);
            this.optlang7.TabIndex = 6;
            this.optlang7.Text = "Spanish";
            this.optlang7.UseVisualStyleBackColor = true;
            // 
            // optlang6
            // 
            this.optlang6.AutoSize = true;
            this.optlang6.Location = new System.Drawing.Point(111, 51);
            this.optlang6.Name = "optlang6";
            this.optlang6.Size = new System.Drawing.Size(79, 17);
            this.optlang6.TabIndex = 5;
            this.optlang6.Text = "Portuguese";
            this.optlang6.UseVisualStyleBackColor = true;
            // 
            // optlang5
            // 
            this.optlang5.AutoSize = true;
            this.optlang5.Location = new System.Drawing.Point(111, 28);
            this.optlang5.Name = "optlang5";
            this.optlang5.Size = new System.Drawing.Size(54, 17);
            this.optlang5.TabIndex = 4;
            this.optlang5.Text = "Dutch";
            this.optlang5.UseVisualStyleBackColor = true;
            // 
            // optlang4
            // 
            this.optlang4.AutoSize = true;
            this.optlang4.Location = new System.Drawing.Point(204, 28);
            this.optlang4.Name = "optlang4";
            this.optlang4.Size = new System.Drawing.Size(53, 17);
            this.optlang4.TabIndex = 3;
            this.optlang4.Text = "Italian";
            this.optlang4.UseVisualStyleBackColor = true;
            // 
            // optlang3
            // 
            this.optlang3.AutoSize = true;
            this.optlang3.Location = new System.Drawing.Point(11, 75);
            this.optlang3.Name = "optlang3";
            this.optlang3.Size = new System.Drawing.Size(58, 17);
            this.optlang3.TabIndex = 2;
            this.optlang3.Text = "Fraktur";
            this.optlang3.UseVisualStyleBackColor = true;
            // 
            // optlang2
            // 
            this.optlang2.AutoSize = true;
            this.optlang2.Location = new System.Drawing.Point(10, 51);
            this.optlang2.Name = "optlang2";
            this.optlang2.Size = new System.Drawing.Size(62, 17);
            this.optlang2.TabIndex = 1;
            this.optlang2.Text = "German";
            this.optlang2.UseVisualStyleBackColor = true;
            // 
            // optlang1
            // 
            this.optlang1.AutoSize = true;
            this.optlang1.Checked = true;
            this.optlang1.Location = new System.Drawing.Point(10, 28);
            this.optlang1.Name = "optlang1";
            this.optlang1.Size = new System.Drawing.Size(59, 17);
            this.optlang1.TabIndex = 0;
            this.optlang1.TabStop = true;
            this.optlang1.Text = "English";
            this.optlang1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtfileheight);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtfilewidth);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txttop);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtleft);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.chkfullpage);
            this.groupBox4.Location = new System.Drawing.Point(812, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 122);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "click Start Regcognize button";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "You may draw the selection rectangle on image and ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(86, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "uncheck this button recognize for specific zone";
            // 
            // txtfileheight
            // 
            this.txtfileheight.Location = new System.Drawing.Point(271, 50);
            this.txtfileheight.Name = "txtfileheight";
            this.txtfileheight.Size = new System.Drawing.Size(39, 20);
            this.txtfileheight.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Height";
            // 
            // txtfilewidth
            // 
            this.txtfilewidth.Location = new System.Drawing.Point(191, 50);
            this.txtfilewidth.Name = "txtfilewidth";
            this.txtfilewidth.Size = new System.Drawing.Size(39, 20);
            this.txtfilewidth.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Width";
            // 
            // txttop
            // 
            this.txttop.Location = new System.Drawing.Point(116, 50);
            this.txttop.Name = "txttop";
            this.txttop.Size = new System.Drawing.Size(39, 20);
            this.txttop.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Top";
            // 
            // txtleft
            // 
            this.txtleft.Location = new System.Drawing.Point(39, 50);
            this.txtleft.Name = "txtleft";
            this.txtleft.Size = new System.Drawing.Size(39, 20);
            this.txtleft.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Left";
            // 
            // chkfullpage
            // 
            this.chkfullpage.AutoSize = true;
            this.chkfullpage.Checked = true;
            this.chkfullpage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkfullpage.Location = new System.Drawing.Point(12, 18);
            this.chkfullpage.Name = "chkfullpage";
            this.chkfullpage.Size = new System.Drawing.Size(70, 17);
            this.chkfullpage.TabIndex = 0;
            this.chkfullpage.Text = "Full Page";
            this.chkfullpage.UseVisualStyleBackColor = true;
            this.chkfullpage.CheckedChanged += new System.EventHandler(this.chkfullpage_CheckedChanged);
            // 
            // btnscan
            // 
            this.btnscan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscan.Location = new System.Drawing.Point(481, 533);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(315, 45);
            this.btnscan.TabIndex = 16;
            this.btnscan.Text = "1. Convert to Searchable Text File";
            this.btnscan.UseVisualStyleBackColor = true;
            this.btnscan.Click += new System.EventHandler(this.btnscan_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.optasync);
            this.groupBox6.Location = new System.Drawing.Point(481, 424);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(315, 53);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mode";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Blocking";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // optasync
            // 
            this.optasync.AutoSize = true;
            this.optasync.Checked = true;
            this.optasync.Location = new System.Drawing.Point(17, 19);
            this.optasync.Name = "optasync";
            this.optasync.Size = new System.Drawing.Size(92, 17);
            this.optasync.TabIndex = 0;
            this.optasync.TabStop = true;
            this.optasync.Text = "Asynchronous";
            this.optasync.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(481, 489);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(217, 25);
            this.progressBar1.TabIndex = 24;
            // 
            // chkuseadvpdf
            // 
            this.chkuseadvpdf.AutoSize = true;
            this.chkuseadvpdf.Location = new System.Drawing.Point(477, 9);
            this.chkuseadvpdf.Name = "chkuseadvpdf";
            this.chkuseadvpdf.Size = new System.Drawing.Size(156, 17);
            this.chkuseadvpdf.TabIndex = 25;
            this.chkuseadvpdf.Text = "Use Advanced PDF Viewer";
            this.chkuseadvpdf.UseVisualStyleBackColor = true;
            this.chkuseadvpdf.CheckedChanged += new System.EventHandler(this.chkuseadvpdf_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(589, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "If your output text file name output.txt, the first page of text file will named " +
    "output0001.txt. Next page named output0002.txt...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(479, 628);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(448, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "The output text file will record each recognized characters and left, top, right " +
    ", bottom position.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(480, 658);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(659, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Before you convert to searchable PDF, you may edit/delete/add the character of te" +
    "xt file, finally let the searchable PDF file more accuracy ";
            // 
            // btnsearchablePDF
            // 
            this.btnsearchablePDF.Enabled = false;
            this.btnsearchablePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchablePDF.Location = new System.Drawing.Point(481, 698);
            this.btnsearchablePDF.Name = "btnsearchablePDF";
            this.btnsearchablePDF.Size = new System.Drawing.Size(315, 45);
            this.btnsearchablePDF.TabIndex = 29;
            this.btnsearchablePDF.Text = "2. Convert to Searchable PDF File";
            this.btnsearchablePDF.UseVisualStyleBackColor = true;
            this.btnsearchablePDF.Click += new System.EventHandler(this.btnsearchablePDF_Click);
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(12, 12);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(456, 451);
            this.axImageViewer1.TabIndex = 0;
            this.axImageViewer1.SelectionRectDrawn += new AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEventHandler(this.axImageViewer1_SelectionRectDrawn);
            this.axImageViewer1.OCRRecognized += new AxSCRIBBLELib._DImageViewerEvents_OCRRecognizedEventHandler(this.axImageViewer1_OCRRecognized);
            this.axImageViewer1.OCRPDFA += new AxSCRIBBLELib._DImageViewerEvents_OCRPDFAEventHandler(this.axImageViewer1_OCRPDFA);
            this.axImageViewer1.OCRPDFATextFile += new AxSCRIBBLELib._DImageViewerEvents_OCRPDFATextFileEventHandler(this.axImageViewer1_OCRPDFATextFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 774);
            this.Controls.Add(this.btnsearchablePDF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkuseadvpdf);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnscan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPageNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axImageViewer1);
            this.Name = "Form1";
            this.Text = "Pre-processing Searchable PDF - OCR to searchable Text File, let you have chance " +
    "change the text before output searchable PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPageNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optfilter2;
        private System.Windows.Forms.RadioButton optfilter1;
        private System.Windows.Forms.RadioButton optfilter4;
        private System.Windows.Forms.RadioButton optfilter3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optmode3;
        private System.Windows.Forms.RadioButton optmode2;
        private System.Windows.Forms.RadioButton optmode1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton optlang1;
        private System.Windows.Forms.RadioButton optlang7;
        private System.Windows.Forms.RadioButton optlang6;
        private System.Windows.Forms.RadioButton optlang5;
        private System.Windows.Forms.RadioButton optlang4;
        private System.Windows.Forms.RadioButton optlang3;
        private System.Windows.Forms.RadioButton optlang2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfileheight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfilewidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtleft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkfullpage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnscan;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton optasync;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chkuseadvpdf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsearchablePDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

