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
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotpage = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.outputImageComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(12, 12);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(456, 451);
            this.axImageViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Enabled = false;
            this.txtfilename.Location = new System.Drawing.Point(477, 62);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(326, 20);
            this.txtfilename.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Page";
            // 
            // txttotpage
            // 
            this.txttotpage.Location = new System.Drawing.Point(554, 96);
            this.txttotpage.Name = "txttotpage";
            this.txttotpage.Size = new System.Drawing.Size(40, 20);
            this.txttotpage.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Output Format";
            // 
            // outputImageComboBox
            // 
            this.outputImageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputImageComboBox.FormattingEnabled = true;
            this.outputImageComboBox.Location = new System.Drawing.Point(587, 139);
            this.outputImageComboBox.Name = "outputImageComboBox";
            this.outputImageComboBox.Size = new System.Drawing.Size(128, 21);
            this.outputImageComboBox.TabIndex = 24;
            this.outputImageComboBox.SelectedIndexChanged += new System.EventHandler(this.outputImageComboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "Save texts for all pages";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(630, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 40);
            this.button3.TabIndex = 26;
            this.button3.Text = "Save texts for page 2 only";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 570);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outputImageComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axImageViewer1);
            this.Name = "Form1";
            this.Text = "Draw Multiple Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotpage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox outputImageComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

