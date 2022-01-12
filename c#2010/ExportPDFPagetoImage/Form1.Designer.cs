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
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpageno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbopdfscale = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(478, 114);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(107, 65);
            this.axImageViewer1.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 12);
            this.label14.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Export PDF Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(23, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 21);
            this.textBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 22);
            this.button2.TabIndex = 18;
            this.button2.Text = "Select PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Page";
            // 
            // txtpageno
            // 
            this.txtpageno.Location = new System.Drawing.Point(82, 68);
            this.txtpageno.Name = "txtpageno";
            this.txtpageno.Size = new System.Drawing.Size(100, 21);
            this.txtpageno.TabIndex = 20;
            this.txtpageno.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "You can export to BMP, JPEG, TIF, PNG, GIF image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "PDF Scale";
            // 
            // cbopdfscale
            // 
            this.cbopdfscale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopdfscale.FormattingEnabled = true;
            this.cbopdfscale.Location = new System.Drawing.Point(111, 114);
            this.cbopdfscale.Name = "cbopdfscale";
            this.cbopdfscale.Size = new System.Drawing.Size(121, 20);
            this.cbopdfscale.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 264);
            this.Controls.Add(this.cbopdfscale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpageno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axImageViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Name = "Form1";
            this.Text = "Export PDF Page to Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpageno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbopdfscale;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

