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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.chkscanmore = new System.Windows.Forms.CheckBox();
            this.txtcustomrotation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkScan90Rotation = new System.Windows.Forms.CheckBox();
            this.chkScanMultiple = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.chkScan45CounterRotation = new System.Windows.Forms.CheckBox();
            this.chkScan45Rotation = new System.Windows.Forms.CheckBox();
            this.chkscannorotation = new System.Windows.Forms.CheckBox();
            this.cbopdfimagecount = new System.Windows.Forms.ComboBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbopdfpage = new System.Windows.Forms.ComboBox();
            this.chkuseadvbarpdf = new System.Windows.Forms.CheckBox();
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            this.groupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(594, 179);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(65, 23);
            this.btnprev.TabIndex = 2;
            this.btnprev.Text = "<<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(665, 179);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(65, 23);
            this.btnnext.TabIndex = 3;
            this.btnnext.Text = ">>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Enabled = false;
            this.txtfilename.Location = new System.Drawing.Point(477, 221);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(326, 21);
            this.txtfilename.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Page";
            // 
            // txttotpage
            // 
            this.txttotpage.Location = new System.Drawing.Point(554, 252);
            this.txttotpage.Name = "txttotpage";
            this.txttotpage.Size = new System.Drawing.Size(40, 21);
            this.txttotpage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Page No.";
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(676, 252);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(40, 21);
            this.txtPageNo.TabIndex = 8;
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
            this.groupBox4.Location = new System.Drawing.Point(481, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 128);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zone - Selected specific zone to  increase barcode recognition accuracy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "click Detect BarCode button";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "You may draw the selection rectangle on image and ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(86, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "uncheck this button recognize for specific zone";
            // 
            // txtfileheight
            // 
            this.txtfileheight.Location = new System.Drawing.Point(271, 46);
            this.txtfileheight.Name = "txtfileheight";
            this.txtfileheight.Size = new System.Drawing.Size(39, 21);
            this.txtfileheight.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Height";
            // 
            // txtfilewidth
            // 
            this.txtfilewidth.Location = new System.Drawing.Point(191, 46);
            this.txtfilewidth.Name = "txtfilewidth";
            this.txtfilewidth.Size = new System.Drawing.Size(39, 21);
            this.txtfilewidth.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Width";
            // 
            // txttop
            // 
            this.txttop.Location = new System.Drawing.Point(116, 46);
            this.txttop.Name = "txttop";
            this.txttop.Size = new System.Drawing.Size(39, 21);
            this.txttop.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Top";
            // 
            // txtleft
            // 
            this.txtleft.Location = new System.Drawing.Point(39, 46);
            this.txtleft.Name = "txtleft";
            this.txtleft.Size = new System.Drawing.Size(39, 21);
            this.txtleft.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Left";
            // 
            // chkfullpage
            // 
            this.chkfullpage.AutoSize = true;
            this.chkfullpage.Checked = true;
            this.chkfullpage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkfullpage.Location = new System.Drawing.Point(12, 17);
            this.chkfullpage.Name = "chkfullpage";
            this.chkfullpage.Size = new System.Drawing.Size(78, 16);
            this.chkfullpage.TabIndex = 0;
            this.chkfullpage.Text = "Full Page";
            this.chkfullpage.UseVisualStyleBackColor = true;
            this.chkfullpage.CheckedChanged += new System.EventHandler(this.chkfullpage_CheckedChanged);
            // 
            // btnscan
            // 
            this.btnscan.Location = new System.Drawing.Point(489, 561);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(160, 49);
            this.btnscan.TabIndex = 16;
            this.btnscan.Text = "Detect BarCode";
            this.btnscan.UseVisualStyleBackColor = true;
            this.btnscan.Click += new System.EventHandler(this.btnscan_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "Read QR Code Demo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "Read 1D Barcode Demo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(810, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 38);
            this.button4.TabIndex = 20;
            this.button4.Text = "Read Multiple Barcode Demo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(482, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 40);
            this.button5.TabIndex = 21;
            this.button5.Text = "Read DataMatrix Demo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(645, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 40);
            this.button6.TabIndex = 22;
            this.button6.Text = "Read barcode at any orientation";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(810, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 40);
            this.button7.TabIndex = 23;
            this.button7.Text = "Read barcode from PDF ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // chkscanmore
            // 
            this.chkscanmore.AutoSize = true;
            this.chkscanmore.Checked = true;
            this.chkscanmore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkscanmore.Location = new System.Drawing.Point(220, 103);
            this.chkscanmore.Name = "chkscanmore";
            this.chkscanmore.Size = new System.Drawing.Size(132, 16);
            this.chkscanmore.TabIndex = 7;
            this.chkscanmore.Text = "Scan More Accuracy";
            this.chkscanmore.UseVisualStyleBackColor = true;
            // 
            // txtcustomrotation
            // 
            this.txtcustomrotation.Location = new System.Drawing.Point(322, 79);
            this.txtcustomrotation.Name = "txtcustomrotation";
            this.txtcustomrotation.Size = new System.Drawing.Size(106, 21);
            this.txtcustomrotation.TabIndex = 6;
            this.txtcustomrotation.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "Custom Rotation";
            // 
            // chkScan90Rotation
            // 
            this.chkScan90Rotation.AutoSize = true;
            this.chkScan90Rotation.Checked = true;
            this.chkScan90Rotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScan90Rotation.Location = new System.Drawing.Point(220, 54);
            this.chkScan90Rotation.Name = "chkScan90Rotation";
            this.chkScan90Rotation.Size = new System.Drawing.Size(192, 16);
            this.chkScan90Rotation.TabIndex = 4;
            this.chkScan90Rotation.Text = "Scan With 90 Degree Rotation";
            this.chkScan90Rotation.UseVisualStyleBackColor = true;
            // 
            // chkScanMultiple
            // 
            this.chkScanMultiple.AutoSize = true;
            this.chkScanMultiple.Checked = true;
            this.chkScanMultiple.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScanMultiple.Location = new System.Drawing.Point(21, 25);
            this.chkScanMultiple.Name = "chkScanMultiple";
            this.chkScanMultiple.Size = new System.Drawing.Size(150, 16);
            this.chkScanMultiple.TabIndex = 0;
            this.chkScanMultiple.Text = "Scan Multiple Barcode";
            this.chkScanMultiple.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.chkscanmore);
            this.GroupBox2.Controls.Add(this.txtcustomrotation);
            this.GroupBox2.Controls.Add(this.label10);
            this.GroupBox2.Controls.Add(this.chkScan90Rotation);
            this.GroupBox2.Controls.Add(this.chkScan45CounterRotation);
            this.GroupBox2.Controls.Add(this.chkScan45Rotation);
            this.GroupBox2.Controls.Add(this.chkscannorotation);
            this.GroupBox2.Controls.Add(this.chkScanMultiple);
            this.GroupBox2.Location = new System.Drawing.Point(482, 423);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(563, 126);
            this.GroupBox2.TabIndex = 33;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "UnSelected some option, it will scan more faster";
            // 
            // chkScan45CounterRotation
            // 
            this.chkScan45CounterRotation.AutoSize = true;
            this.chkScan45CounterRotation.Checked = true;
            this.chkScan45CounterRotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScan45CounterRotation.Location = new System.Drawing.Point(220, 25);
            this.chkScan45CounterRotation.Name = "chkScan45CounterRotation";
            this.chkScan45CounterRotation.Size = new System.Drawing.Size(300, 16);
            this.chkScan45CounterRotation.TabIndex = 3;
            this.chkScan45CounterRotation.Text = "Scan With 45 Degree Counter Clockwise Rotation";
            this.chkScan45CounterRotation.UseVisualStyleBackColor = true;
            // 
            // chkScan45Rotation
            // 
            this.chkScan45Rotation.AutoSize = true;
            this.chkScan45Rotation.Checked = true;
            this.chkScan45Rotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScan45Rotation.Location = new System.Drawing.Point(21, 83);
            this.chkScan45Rotation.Name = "chkScan45Rotation";
            this.chkScan45Rotation.Size = new System.Drawing.Size(192, 16);
            this.chkScan45Rotation.TabIndex = 2;
            this.chkScan45Rotation.Text = "Scan With 45 Degree Rotation";
            this.chkScan45Rotation.UseVisualStyleBackColor = true;
            // 
            // chkscannorotation
            // 
            this.chkscannorotation.AutoSize = true;
            this.chkscannorotation.Checked = true;
            this.chkscannorotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkscannorotation.Location = new System.Drawing.Point(21, 54);
            this.chkscannorotation.Name = "chkscannorotation";
            this.chkscannorotation.Size = new System.Drawing.Size(150, 16);
            this.chkscannorotation.TabIndex = 1;
            this.chkscannorotation.Text = "Scan Without Rotation";
            this.chkscannorotation.UseVisualStyleBackColor = true;
            // 
            // cbopdfimagecount
            // 
            this.cbopdfimagecount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopdfimagecount.FormattingEnabled = true;
            this.cbopdfimagecount.Location = new System.Drawing.Point(287, 39);
            this.cbopdfimagecount.Name = "cbopdfimagecount";
            this.cbopdfimagecount.Size = new System.Drawing.Size(75, 20);
            this.cbopdfimagecount.TabIndex = 2;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.label12);
            this.GroupBox3.Controls.Add(this.label11);
            this.GroupBox3.Controls.Add(this.cbopdfimagecount);
            this.GroupBox3.Controls.Add(this.cbopdfpage);
            this.GroupBox3.Controls.Add(this.chkuseadvbarpdf);
            this.GroupBox3.Location = new System.Drawing.Point(474, 101);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(404, 64);
            this.GroupBox3.TabIndex = 34;
            this.GroupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Select Image";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "Select PDF Page";
            // 
            // cbopdfpage
            // 
            this.cbopdfpage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopdfpage.FormattingEnabled = true;
            this.cbopdfpage.Location = new System.Drawing.Point(113, 39);
            this.cbopdfpage.Name = "cbopdfpage";
            this.cbopdfpage.Size = new System.Drawing.Size(75, 20);
            this.cbopdfpage.TabIndex = 1;
            this.cbopdfpage.SelectedIndexChanged += new System.EventHandler(this.cbopdfpage_SelectedIndexChanged);
            // 
            // chkuseadvbarpdf
            // 
            this.chkuseadvbarpdf.AutoSize = true;
            this.chkuseadvbarpdf.Location = new System.Drawing.Point(12, 17);
            this.chkuseadvbarpdf.Name = "chkuseadvbarpdf";
            this.chkuseadvbarpdf.Size = new System.Drawing.Size(210, 16);
            this.chkuseadvbarpdf.TabIndex = 0;
            this.chkuseadvbarpdf.Text = "Advanced Barcode Reader for PDF";
            this.chkuseadvbarpdf.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 622);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.axImageViewer1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnscan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtPageNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "1D and 2D Barcode Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        internal System.Windows.Forms.CheckBox chkscanmore;
        internal System.Windows.Forms.TextBox txtcustomrotation;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.CheckBox chkScan90Rotation;
        internal System.Windows.Forms.CheckBox chkScanMultiple;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.CheckBox chkScan45CounterRotation;
        internal System.Windows.Forms.CheckBox chkScan45Rotation;
        internal System.Windows.Forms.CheckBox chkscannorotation;
        internal System.Windows.Forms.ComboBox cbopdfimagecount;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ComboBox cbopdfpage;
        internal System.Windows.Forms.CheckBox chkuseadvbarpdf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

