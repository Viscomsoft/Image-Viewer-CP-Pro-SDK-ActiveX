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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbarcodevalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbobarcodestand = new System.Windows.Forms.ComboBox();
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbarcodewidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbarcodeheight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbofontsize = new System.Windows.Forms.ComboBox();
            this.chkshowtext = new System.Windows.Forms.CheckBox();
            this.chkshowcheckdigit = new System.Windows.Forms.CheckBox();
            this.chkfitrect = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtleft = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbooutputimage = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.axImageViewer2 = new AxSCRIBBLELib.AxImageViewer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode value";
            // 
            // txtbarcodevalue
            // 
            this.txtbarcodevalue.Location = new System.Drawing.Point(114, 16);
            this.txtbarcodevalue.Name = "txtbarcodevalue";
            this.txtbarcodevalue.Size = new System.Drawing.Size(153, 20);
            this.txtbarcodevalue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode Type";
            // 
            // cbobarcodestand
            // 
            this.cbobarcodestand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobarcodestand.FormattingEnabled = true;
            this.cbobarcodestand.Location = new System.Drawing.Point(114, 51);
            this.cbobarcodestand.Name = "cbobarcodestand";
            this.cbobarcodestand.Size = new System.Drawing.Size(153, 21);
            this.cbobarcodestand.TabIndex = 3;
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(403, 12);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(261, 251);
            this.axImageViewer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbarcodeheight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbarcodewidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Image Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width";
            // 
            // txtbarcodewidth
            // 
            this.txtbarcodewidth.Location = new System.Drawing.Point(67, 25);
            this.txtbarcodewidth.Name = "txtbarcodewidth";
            this.txtbarcodewidth.Size = new System.Drawing.Size(53, 20);
            this.txtbarcodewidth.TabIndex = 1;
            this.txtbarcodewidth.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Height";
            // 
            // txtbarcodeheight
            // 
            this.txtbarcodeheight.Location = new System.Drawing.Point(67, 54);
            this.txtbarcodeheight.Name = "txtbarcodeheight";
            this.txtbarcodeheight.Size = new System.Drawing.Size(53, 20);
            this.txtbarcodeheight.TabIndex = 3;
            this.txtbarcodeheight.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pixel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pixel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Font Size";
            // 
            // cbofontsize
            // 
            this.cbofontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofontsize.FormattingEnabled = true;
            this.cbofontsize.Location = new System.Drawing.Point(259, 202);
            this.cbofontsize.Name = "cbofontsize";
            this.cbofontsize.Size = new System.Drawing.Size(114, 21);
            this.cbofontsize.TabIndex = 7;
            // 
            // chkshowtext
            // 
            this.chkshowtext.AutoSize = true;
            this.chkshowtext.Checked = true;
            this.chkshowtext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkshowtext.Location = new System.Drawing.Point(15, 215);
            this.chkshowtext.Name = "chkshowtext";
            this.chkshowtext.Size = new System.Drawing.Size(77, 17);
            this.chkshowtext.TabIndex = 8;
            this.chkshowtext.Text = "Show Text";
            this.chkshowtext.UseVisualStyleBackColor = true;
            // 
            // chkshowcheckdigit
            // 
            this.chkshowcheckdigit.AutoSize = true;
            this.chkshowcheckdigit.Checked = true;
            this.chkshowcheckdigit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkshowcheckdigit.Location = new System.Drawing.Point(15, 259);
            this.chkshowcheckdigit.Name = "chkshowcheckdigit";
            this.chkshowcheckdigit.Size = new System.Drawing.Size(111, 17);
            this.chkshowcheckdigit.TabIndex = 9;
            this.chkshowcheckdigit.Text = "Show Check Digit";
            this.chkshowcheckdigit.UseVisualStyleBackColor = true;
            // 
            // chkfitrect
            // 
            this.chkfitrect.AutoSize = true;
            this.chkfitrect.Checked = true;
            this.chkfitrect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkfitrect.Location = new System.Drawing.Point(15, 308);
            this.chkfitrect.Name = "chkfitrect";
            this.chkfitrect.Size = new System.Drawing.Size(101, 17);
            this.chkfitrect.TabIndex = 10;
            this.chkfitrect.Text = "Fit to Rectangle";
            this.chkfitrect.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtheight);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txttop);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtleft);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 133);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Left";
            // 
            // txtleft
            // 
            this.txtleft.Location = new System.Drawing.Point(58, 16);
            this.txtleft.Name = "txtleft";
            this.txtleft.Size = new System.Drawing.Size(53, 20);
            this.txtleft.TabIndex = 12;
            this.txtleft.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Top";
            // 
            // txttop
            // 
            this.txttop.Location = new System.Drawing.Point(58, 47);
            this.txttop.Name = "txttop";
            this.txttop.Size = new System.Drawing.Size(53, 20);
            this.txttop.TabIndex = 14;
            this.txttop.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Height";
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(58, 81);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(53, 20);
            this.txtheight.TabIndex = 16;
            this.txtheight.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Pixel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Pixel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Pixel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 12;
            // 
            // cbooutputimage
            // 
            this.cbooutputimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooutputimage.FormattingEnabled = true;
            this.cbooutputimage.Location = new System.Drawing.Point(371, 272);
            this.cbooutputimage.Name = "cbooutputimage";
            this.cbooutputimage.Size = new System.Drawing.Size(180, 21);
            this.cbooutputimage.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generate barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(237, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Save as image format";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(235, 318);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(139, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Draw barcode on image";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(233, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "Select Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axImageViewer2
            // 
            this.axImageViewer2.Enabled = true;
            this.axImageViewer2.Location = new System.Drawing.Point(693, 12);
            this.axImageViewer2.Name = "axImageViewer2";
            this.axImageViewer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer2.OcxState")));
            this.axImageViewer2.Size = new System.Drawing.Size(321, 386);
            this.axImageViewer2.TabIndex = 19;
            this.axImageViewer2.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 500);
            this.Controls.Add(this.axImageViewer2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.axImageViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbooutputimage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkfitrect);
            this.Controls.Add(this.chkshowcheckdigit);
            this.Controls.Add(this.chkshowtext);
            this.Controls.Add(this.cbofontsize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbobarcodestand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbarcodevalue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Barcode Writer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbarcodevalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbobarcodestand;
        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbarcodeheight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbarcodewidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbofontsize;
        private System.Windows.Forms.CheckBox chkshowtext;
        private System.Windows.Forms.CheckBox chkshowcheckdigit;
        private System.Windows.Forms.CheckBox chkfitrect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtleft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbooutputimage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private AxSCRIBBLELib.AxImageViewer axImageViewer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

