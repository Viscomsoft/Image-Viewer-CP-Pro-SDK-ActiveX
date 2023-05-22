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
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtbillto = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtcaption = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbofont = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(775, 86);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(282, 309);
            this.axImageViewer1.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(37, 184);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 24);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Date:";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(245, 184);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(282, 35);
            this.txtdate.TabIndex = 17;
            this.txtdate.Text = "9-5-2023";
            // 
            // txtbillto
            // 
            this.txtbillto.Location = new System.Drawing.Point(245, 251);
            this.txtbillto.Name = "txtbillto";
            this.txtbillto.Size = new System.Drawing.Size(282, 35);
            this.txtbillto.TabIndex = 16;
            this.txtbillto.Text = "ABC Company";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(37, 254);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(106, 24);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Bill To:";
            // 
            // txtcaption
            // 
            this.txtcaption.Location = new System.Drawing.Point(245, 110);
            this.txtcaption.Name = "txtcaption";
            this.txtcaption.Size = new System.Drawing.Size(282, 35);
            this.txtcaption.TabIndex = 14;
            this.txtcaption.Text = "INVOICE";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(37, 110);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 24);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Caption";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(222, 357);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(242, 82);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "Create PDF";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(37, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 24);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Font";
            // 
            // cbofont
            // 
            this.cbofont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofont.FormattingEnabled = true;
            this.cbofont.Location = new System.Drawing.Point(245, 37);
            this.cbofont.Name = "cbofont";
            this.cbofont.Size = new System.Drawing.Size(282, 32);
            this.cbofont.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 486);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtbillto);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtcaption);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbofont);
            this.Controls.Add(this.axImageViewer1);
            this.Name = "Form1";
            this.Text = "PDF Writer Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSCRIBBLELib.AxImageViewer axImageViewer1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtdate;
        internal System.Windows.Forms.TextBox txtbillto;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtcaption;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbofont;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

