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
            this.rotate90Button = new System.Windows.Forms.Button();
            this.rotate180Button = new System.Windows.Forms.Button();
            this.rotate270Button = new System.Windows.Forms.Button();
            this.zoom25Button = new System.Windows.Forms.Button();
            this.zoom33Button = new System.Windows.Forms.Button();
            this.zoom50Button = new System.Windows.Forms.Button();
            this.zoom75Button = new System.Windows.Forms.Button();
            this.zoom100Button = new System.Windows.Forms.Button();
            this.zoom150Button = new System.Windows.Forms.Button();
            this.zoom200Button = new System.Windows.Forms.Button();
            this.fitButton = new System.Windows.Forms.Button();
            this.ratioButton = new System.Windows.Forms.Button();
            this.totalPageLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.borderOffRadioButton = new System.Windows.Forms.RadioButton();
            this.borderOnRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.hqNoRadioButton = new System.Windows.Forms.RadioButton();
            this.hqYesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkpanning = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEditField = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalpdfformfield = new System.Windows.Forms.Label();
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkexportcurrentpage = new System.Windows.Forms.CheckBox();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // rotate90Button
            // 
            this.rotate90Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate90Button.Location = new System.Drawing.Point(12, 130);
            this.rotate90Button.Name = "rotate90Button";
            this.rotate90Button.Size = new System.Drawing.Size(85, 21);
            this.rotate90Button.TabIndex = 1;
            this.rotate90Button.Text = "Rotate 90";
            this.rotate90Button.UseVisualStyleBackColor = true;
            this.rotate90Button.Click += new System.EventHandler(this.rotate90Button_Click);
            // 
            // rotate180Button
            // 
            this.rotate180Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate180Button.Location = new System.Drawing.Point(12, 157);
            this.rotate180Button.Name = "rotate180Button";
            this.rotate180Button.Size = new System.Drawing.Size(85, 21);
            this.rotate180Button.TabIndex = 2;
            this.rotate180Button.Text = "Rotate 180";
            this.rotate180Button.UseVisualStyleBackColor = true;
            this.rotate180Button.Click += new System.EventHandler(this.rotate180Button_Click);
            // 
            // rotate270Button
            // 
            this.rotate270Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate270Button.Location = new System.Drawing.Point(12, 184);
            this.rotate270Button.Name = "rotate270Button";
            this.rotate270Button.Size = new System.Drawing.Size(85, 21);
            this.rotate270Button.TabIndex = 3;
            this.rotate270Button.Text = "Rotate 270";
            this.rotate270Button.UseVisualStyleBackColor = true;
            this.rotate270Button.Click += new System.EventHandler(this.rotate270Button_Click);
            // 
            // zoom25Button
            // 
            this.zoom25Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoom25Button.Location = new System.Drawing.Point(12, 211);
            this.zoom25Button.Name = "zoom25Button";
            this.zoom25Button.Size = new System.Drawing.Size(85, 21);
            this.zoom25Button.TabIndex = 4;
            this.zoom25Button.Text = "25% of Original";
            this.zoom25Button.UseVisualStyleBackColor = true;
            this.zoom25Button.Click += new System.EventHandler(this.zoom25Button_Click);
            // 
            // zoom33Button
            // 
            this.zoom33Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoom33Button.Location = new System.Drawing.Point(12, 238);
            this.zoom33Button.Name = "zoom33Button";
            this.zoom33Button.Size = new System.Drawing.Size(85, 21);
            this.zoom33Button.TabIndex = 5;
            this.zoom33Button.Text = "33% of Original";
            this.zoom33Button.UseVisualStyleBackColor = true;
            this.zoom33Button.Click += new System.EventHandler(this.zoom33Button_Click);
            // 
            // zoom50Button
            // 
            this.zoom50Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoom50Button.Location = new System.Drawing.Point(12, 264);
            this.zoom50Button.Name = "zoom50Button";
            this.zoom50Button.Size = new System.Drawing.Size(85, 21);
            this.zoom50Button.TabIndex = 6;
            this.zoom50Button.Text = "50% of Original";
            this.zoom50Button.UseVisualStyleBackColor = true;
            this.zoom50Button.Click += new System.EventHandler(this.zoom50Button_Click);
            // 
            // zoom75Button
            // 
            this.zoom75Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoom75Button.Location = new System.Drawing.Point(12, 291);
            this.zoom75Button.Name = "zoom75Button";
            this.zoom75Button.Size = new System.Drawing.Size(85, 21);
            this.zoom75Button.TabIndex = 7;
            this.zoom75Button.Text = "75% of Original";
            this.zoom75Button.UseVisualStyleBackColor = true;
            this.zoom75Button.Click += new System.EventHandler(this.zoom75Button_Click);
            // 
            // zoom100Button
            // 
            this.zoom100Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoom100Button.Location = new System.Drawing.Point(12, 318);
            this.zoom100Button.Name = "zoom100Button";
            this.zoom100Button.Size = new System.Drawing.Size(85, 21);
            this.zoom100Button.TabIndex = 8;
            this.zoom100Button.Text = "100% of Original";
            this.zoom100Button.UseVisualStyleBackColor = true;
            this.zoom100Button.Click += new System.EventHandler(this.zoom100Button_Click);
            // 
            // zoom150Button
            // 
            this.zoom150Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoom150Button.Location = new System.Drawing.Point(12, 345);
            this.zoom150Button.Name = "zoom150Button";
            this.zoom150Button.Size = new System.Drawing.Size(85, 21);
            this.zoom150Button.TabIndex = 9;
            this.zoom150Button.Text = "150% of Original";
            this.zoom150Button.UseVisualStyleBackColor = true;
            this.zoom150Button.Click += new System.EventHandler(this.zoom150Button_Click);
            // 
            // zoom200Button
            // 
            this.zoom200Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoom200Button.Location = new System.Drawing.Point(12, 371);
            this.zoom200Button.Name = "zoom200Button";
            this.zoom200Button.Size = new System.Drawing.Size(85, 21);
            this.zoom200Button.TabIndex = 10;
            this.zoom200Button.Text = "200% of Original";
            this.zoom200Button.UseVisualStyleBackColor = true;
            this.zoom200Button.Click += new System.EventHandler(this.zoom200Button_Click);
            // 
            // fitButton
            // 
            this.fitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fitButton.Location = new System.Drawing.Point(12, 398);
            this.fitButton.Name = "fitButton";
            this.fitButton.Size = new System.Drawing.Size(85, 21);
            this.fitButton.TabIndex = 11;
            this.fitButton.Text = "Fit to Window";
            this.fitButton.UseVisualStyleBackColor = true;
            this.fitButton.Click += new System.EventHandler(this.fitButton_Click);
            // 
            // ratioButton
            // 
            this.ratioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratioButton.Location = new System.Drawing.Point(12, 425);
            this.ratioButton.Name = "ratioButton";
            this.ratioButton.Size = new System.Drawing.Size(85, 21);
            this.ratioButton.TabIndex = 12;
            this.ratioButton.Text = "Aspect Ratio";
            this.ratioButton.UseVisualStyleBackColor = true;
            this.ratioButton.Click += new System.EventHandler(this.ratioButton_Click);
            // 
            // totalPageLabel
            // 
            this.totalPageLabel.AutoSize = true;
            this.totalPageLabel.Location = new System.Drawing.Point(219, 524);
            this.totalPageLabel.Name = "totalPageLabel";
            this.totalPageLabel.Size = new System.Drawing.Size(11, 12);
            this.totalPageLabel.TabIndex = 20;
            this.totalPageLabel.Tag = "Total Pages: {0}/{1}";
            this.totalPageLabel.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Files (*.*)|*.*|JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|Gif" +
                " (*.gif)|*.gif |PNG (*.png)|*.png|Icon (*.ico)|*.ico";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.borderOffRadioButton);
            this.groupBox5.Controls.Add(this.borderOnRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(9, 604);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 42);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Border";
            // 
            // borderOffRadioButton
            // 
            this.borderOffRadioButton.AutoSize = true;
            this.borderOffRadioButton.Location = new System.Drawing.Point(50, 18);
            this.borderOffRadioButton.Name = "borderOffRadioButton";
            this.borderOffRadioButton.Size = new System.Drawing.Size(31, 13);
            this.borderOffRadioButton.TabIndex = 1;
            this.borderOffRadioButton.Text = "Off";
            this.borderOffRadioButton.UseVisualStyleBackColor = true;
            // 
            // borderOnRadioButton
            // 
            this.borderOnRadioButton.AutoSize = true;
            this.borderOnRadioButton.Checked = true;
            this.borderOnRadioButton.Location = new System.Drawing.Point(11, 17);
            this.borderOnRadioButton.Name = "borderOnRadioButton";
            this.borderOnRadioButton.Size = new System.Drawing.Size(26, 13);
            this.borderOnRadioButton.TabIndex = 0;
            this.borderOnRadioButton.TabStop = true;
            this.borderOnRadioButton.Text = "On";
            this.borderOnRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.hqNoRadioButton);
            this.groupBox6.Controls.Add(this.hqYesRadioButton);
            this.groupBox6.Location = new System.Drawing.Point(9, 642);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(93, 42);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "High Quality";
            // 
            // hqNoRadioButton
            // 
            this.hqNoRadioButton.AutoSize = true;
            this.hqNoRadioButton.Location = new System.Drawing.Point(57, 18);
            this.hqNoRadioButton.Name = "hqNoRadioButton";
            this.hqNoRadioButton.Size = new System.Drawing.Size(26, 13);
            this.hqNoRadioButton.TabIndex = 1;
            this.hqNoRadioButton.Text = "No";
            this.hqNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // hqYesRadioButton
            // 
            this.hqYesRadioButton.AutoSize = true;
            this.hqYesRadioButton.Checked = true;
            this.hqYesRadioButton.Location = new System.Drawing.Point(8, 18);
            this.hqYesRadioButton.Name = "hqYesRadioButton";
            this.hqYesRadioButton.Size = new System.Drawing.Size(31, 13);
            this.hqYesRadioButton.TabIndex = 0;
            this.hqYesRadioButton.TabStop = true;
            this.hqYesRadioButton.Text = "Yes";
            this.hqYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.chkpanning);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Location = new System.Drawing.Point(12, 11);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(511, 113);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "You may find the PDF form sample in C:\\Program Files (x86)\\Image Viewer CP Pro Ac" +
                "tiveX Control\\PDFFormFields";
            // 
            // chkpanning
            // 
            this.chkpanning.AutoSize = true;
            this.chkpanning.Checked = true;
            this.chkpanning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkpanning.Location = new System.Drawing.Point(94, 80);
            this.chkpanning.Name = "chkpanning";
            this.chkpanning.Size = new System.Drawing.Size(130, 13);
            this.chkpanning.TabIndex = 2;
            this.chkpanning.Text = "Enable Panning with Mouse";
            this.chkpanning.UseVisualStyleBackColor = true;
            this.chkpanning.CheckedChanged += new System.EventHandler(this.chkpanning_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "Select Image";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(547, 83);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 136);
            this.listBox1.TabIndex = 59;
            // 
            // btnEditField
            // 
            this.btnEditField.Location = new System.Drawing.Point(547, 245);
            this.btnEditField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditField.Name = "btnEditField";
            this.btnEditField.Size = new System.Drawing.Size(160, 28);
            this.btnEditField.TabIndex = 60;
            this.btnEditField.Text = "Edit PDF Form Fields";
            this.btnEditField.UseVisualStyleBackColor = true;
            this.btnEditField.Click += new System.EventHandler(this.btnEditField_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(732, 245);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 28);
            this.button3.TabIndex = 61;
            this.button3.Text = "Export to PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 62;
            this.label1.Text = "Total PDF Form Fields";
            // 
            // lbltotalpdfformfield
            // 
            this.lbltotalpdfformfield.AutoSize = true;
            this.lbltotalpdfformfield.Location = new System.Drawing.Point(694, 34);
            this.lbltotalpdfformfield.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalpdfformfield.Name = "lbltotalpdfformfield";
            this.lbltotalpdfformfield.Size = new System.Drawing.Size(11, 12);
            this.lbltotalpdfformfield.TabIndex = 63;
            this.lbltotalpdfformfield.Text = "0";
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(142, 130);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(375, 383);
            this.axImageViewer1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "Total Pages";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 24);
            this.button1.TabIndex = 66;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(338, 519);
            this.txtPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(36, 21);
            this.txtPage.TabIndex = 67;
            this.txtPage.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 68;
            this.label4.Text = "Page";
            // 
            // chkexportcurrentpage
            // 
            this.chkexportcurrentpage.AutoSize = true;
            this.chkexportcurrentpage.Location = new System.Drawing.Point(732, 297);
            this.chkexportcurrentpage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkexportcurrentpage.Name = "chkexportcurrentpage";
            this.chkexportcurrentpage.Size = new System.Drawing.Size(168, 16);
            this.chkexportcurrentpage.TabIndex = 69;
            this.chkexportcurrentpage.Text = "Export Current Page only";
            this.chkexportcurrentpage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 670);
            this.Controls.Add(this.chkexportcurrentpage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.axImageViewer1);
            this.Controls.Add(this.lbltotalpdfformfield);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditField);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.totalPageLabel);
            this.Controls.Add(this.ratioButton);
            this.Controls.Add(this.fitButton);
            this.Controls.Add(this.zoom200Button);
            this.Controls.Add(this.zoom150Button);
            this.Controls.Add(this.zoom100Button);
            this.Controls.Add(this.zoom75Button);
            this.Controls.Add(this.zoom50Button);
            this.Controls.Add(this.zoom33Button);
            this.Controls.Add(this.zoom25Button);
            this.Controls.Add(this.rotate270Button);
            this.Controls.Add(this.rotate180Button);
            this.Controls.Add(this.rotate90Button);
            this.Name = "Form1";
            this.Text = "PDF Form Fields  (Load PDF need purchase Advanced PDF Viewer plugin)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rotate90Button;
        private System.Windows.Forms.Button rotate180Button;
        private System.Windows.Forms.Button rotate270Button;
        private System.Windows.Forms.Button zoom25Button;
        private System.Windows.Forms.Button zoom33Button;
        private System.Windows.Forms.Button zoom50Button;
        private System.Windows.Forms.Button zoom75Button;
        private System.Windows.Forms.Button zoom100Button;
        private System.Windows.Forms.Button zoom150Button;
        private System.Windows.Forms.Button zoom200Button;
        private System.Windows.Forms.Button fitButton;
        private System.Windows.Forms.Button ratioButton;
        private System.Windows.Forms.Label totalPageLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton borderOffRadioButton;
        private System.Windows.Forms.RadioButton borderOnRadioButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton hqNoRadioButton;
        private System.Windows.Forms.RadioButton hqYesRadioButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkpanning;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEditField;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalpdfformfield;
        private System.Windows.Forms.Label label2;
        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkexportcurrentpage;
    }
}

