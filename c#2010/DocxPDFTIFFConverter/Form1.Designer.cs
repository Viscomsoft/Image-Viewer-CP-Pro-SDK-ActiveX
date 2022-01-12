namespace WindowsFormsApplication1
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
            this.textImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            this.chkuseadvpdf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textImage
            // 
            this.textImage.Location = new System.Drawing.Point(78, 58);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(310, 20);
            this.textImage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Convert to docx";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(376, 129);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(1, 6);
            this.axImageViewer1.TabIndex = 4;
            // 
            // chkuseadvpdf
            // 
            this.chkuseadvpdf.AutoSize = true;
            this.chkuseadvpdf.Location = new System.Drawing.Point(15, 22);
            this.chkuseadvpdf.Name = "chkuseadvpdf";
            this.chkuseadvpdf.Size = new System.Drawing.Size(156, 17);
            this.chkuseadvpdf.TabIndex = 5;
            this.chkuseadvpdf.Text = "Use Advanced PDF Viewer";
            this.chkuseadvpdf.UseVisualStyleBackColor = true;
            this.chkuseadvpdf.CheckedChanged += new System.EventHandler(this.chkuseadvpdf_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 208);
            this.Controls.Add(this.chkuseadvpdf);
            this.Controls.Add(this.axImageViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textImage);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        private System.Windows.Forms.CheckBox chkuseadvpdf;
    }
}

