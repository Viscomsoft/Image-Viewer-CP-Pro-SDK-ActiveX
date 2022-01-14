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
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.optoutput2 = new System.Windows.Forms.RadioButton();
            this.optoutput1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotalchar = new System.Windows.Forms.TextBox();
            this.btnscan = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chkuseadvpdf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(13, 130);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(1008, 262);
            this.axImageViewer1.TabIndex = 0;
            this.axImageViewer1.SelectionRectDrawn += new AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEventHandler(this.axImageViewer1_SelectionRectDrawn);
            this.axImageViewer1.OCRRecognized += new AxSCRIBBLELib._DImageViewerEvents_OCRRecognizedEventHandler(this.axImageViewer1_OCRRecognized);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(133, 38);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(65, 23);
            this.btnprev.TabIndex = 2;
            this.btnprev.Text = "<<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(204, 38);
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
            this.txtfilename.Location = new System.Drawing.Point(17, 76);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(326, 21);
            this.txtfilename.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Page";
            // 
            // txttotpage
            // 
            this.txttotpage.Location = new System.Drawing.Point(93, 103);
            this.txttotpage.Name = "txttotpage";
            this.txttotpage.Size = new System.Drawing.Size(40, 21);
            this.txttotpage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Page No.";
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(215, 103);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(40, 21);
            this.txtPageNo.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optfilter4);
            this.groupBox1.Controls.Add(this.optfilter3);
            this.groupBox1.Controls.Add(this.optfilter2);
            this.groupBox1.Controls.Add(this.optfilter1);
            this.groupBox1.Location = new System.Drawing.Point(646, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 66);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Filter";
            // 
            // optfilter4
            // 
            this.optfilter4.AutoSize = true;
            this.optfilter4.Location = new System.Drawing.Point(184, 39);
            this.optfilter4.Name = "optfilter4";
            this.optfilter4.Size = new System.Drawing.Size(167, 16);
            this.optfilter4.TabIndex = 3;
            this.optfilter4.Text = "Recognize lowercase only";
            this.optfilter4.UseVisualStyleBackColor = true;
            // 
            // optfilter3
            // 
            this.optfilter3.AutoSize = true;
            this.optfilter3.Location = new System.Drawing.Point(184, 18);
            this.optfilter3.Name = "optfilter3";
            this.optfilter3.Size = new System.Drawing.Size(167, 16);
            this.optfilter3.TabIndex = 2;
            this.optfilter3.Text = "Recognize uppercase only";
            this.optfilter3.UseVisualStyleBackColor = true;
            // 
            // optfilter2
            // 
            this.optfilter2.AutoSize = true;
            this.optfilter2.Location = new System.Drawing.Point(9, 39);
            this.optfilter2.Name = "optfilter2";
            this.optfilter2.Size = new System.Drawing.Size(155, 16);
            this.optfilter2.TabIndex = 1;
            this.optfilter2.Text = "Recognize numeric only";
            this.optfilter2.UseVisualStyleBackColor = true;
            // 
            // optfilter1
            // 
            this.optfilter1.AutoSize = true;
            this.optfilter1.Checked = true;
            this.optfilter1.Location = new System.Drawing.Point(9, 18);
            this.optfilter1.Name = "optfilter1";
            this.optfilter1.Size = new System.Drawing.Size(77, 16);
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
            this.groupBox2.Location = new System.Drawing.Point(412, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognize Mode";
            // 
            // optmode3
            // 
            this.optmode3.AutoSize = true;
            this.optmode3.Location = new System.Drawing.Point(13, 63);
            this.optmode3.Name = "optmode3";
            this.optmode3.Size = new System.Drawing.Size(77, 16);
            this.optmode3.TabIndex = 2;
            this.optmode3.Text = "Excellent";
            this.optmode3.UseVisualStyleBackColor = true;
            // 
            // optmode2
            // 
            this.optmode2.AutoSize = true;
            this.optmode2.Checked = true;
            this.optmode2.Location = new System.Drawing.Point(13, 42);
            this.optmode2.Name = "optmode2";
            this.optmode2.Size = new System.Drawing.Size(59, 16);
            this.optmode2.TabIndex = 1;
            this.optmode2.TabStop = true;
            this.optmode2.Text = "Normal";
            this.optmode2.UseVisualStyleBackColor = true;
            // 
            // optmode1
            // 
            this.optmode1.AutoSize = true;
            this.optmode1.Location = new System.Drawing.Point(13, 20);
            this.optmode1.Name = "optmode1";
            this.optmode1.Size = new System.Drawing.Size(47, 16);
            this.optmode1.TabIndex = 0;
            this.optmode1.Text = "Fast";
            this.optmode1.UseVisualStyleBackColor = true;
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
            this.groupBox4.Location = new System.Drawing.Point(12, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 113);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "click Start Regcognize button";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.optoutput2);
            this.groupBox5.Controls.Add(this.optoutput1);
            this.groupBox5.Location = new System.Drawing.Point(391, 412);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 85);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // optoutput2
            // 
            this.optoutput2.AutoSize = true;
            this.optoutput2.Location = new System.Drawing.Point(16, 56);
            this.optoutput2.Name = "optoutput2";
            this.optoutput2.Size = new System.Drawing.Size(251, 16);
            this.optoutput2.TabIndex = 1;
            this.optoutput2.Text = "Write the recognized text to text file";
            this.optoutput2.UseVisualStyleBackColor = true;
            // 
            // optoutput1
            // 
            this.optoutput1.AutoSize = true;
            this.optoutput1.Checked = true;
            this.optoutput1.Location = new System.Drawing.Point(15, 23);
            this.optoutput1.Name = "optoutput1";
            this.optoutput1.Size = new System.Drawing.Size(185, 16);
            this.optoutput1.TabIndex = 0;
            this.optoutput1.TabStop = true;
            this.optoutput1.Text = "Display the recognized text";
            this.optoutput1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Recognized Character";
            // 
            // txttotalchar
            // 
            this.txttotalchar.Location = new System.Drawing.Point(179, 512);
            this.txttotalchar.Name = "txttotalchar";
            this.txttotalchar.Size = new System.Drawing.Size(76, 21);
            this.txttotalchar.TabIndex = 15;
            this.txttotalchar.Text = "0";
            // 
            // btnscan
            // 
            this.btnscan.Location = new System.Drawing.Point(818, 398);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(160, 57);
            this.btnscan.TabIndex = 16;
            this.btnscan.Text = "Start Recognize";
            this.btnscan.UseVisualStyleBackColor = true;
            this.btnscan.Click += new System.EventHandler(this.btnscan_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(818, 468);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(160, 58);
            this.btnstop.TabIndex = 17;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkuseadvpdf
            // 
            this.chkuseadvpdf.AutoSize = true;
            this.chkuseadvpdf.Location = new System.Drawing.Point(17, 12);
            this.chkuseadvpdf.Name = "chkuseadvpdf";
            this.chkuseadvpdf.Size = new System.Drawing.Size(162, 16);
            this.chkuseadvpdf.TabIndex = 18;
            this.chkuseadvpdf.Text = "Use Advanced PDF Viewer";
            this.chkuseadvpdf.UseVisualStyleBackColor = true;
            this.chkuseadvpdf.CheckedChanged += new System.EventHandler(this.chkuseadvpdf_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 545);
            this.Controls.Add(this.chkuseadvpdf);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnscan);
            this.Controls.Add(this.txttotalchar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
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
            this.Text = "OCR Cheque number";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton optoutput2;
        private System.Windows.Forms.RadioButton optoutput1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotalchar;
        private System.Windows.Forms.Button btnscan;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chkuseadvpdf;
    }
}

