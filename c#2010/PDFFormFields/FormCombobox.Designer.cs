namespace WindowsApplication1
{
    partial class FormCombobox
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
            this.lblindex = new System.Windows.Forms.Label();
            this.lblindexcaption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcomboboxindex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblindex
            // 
            this.lblindex.AutoSize = true;
            this.lblindex.Location = new System.Drawing.Point(206, 24);
            this.lblindex.Name = "lblindex";
            this.lblindex.Size = new System.Drawing.Size(15, 15);
            this.lblindex.TabIndex = 8;
            this.lblindex.Text = "0";
            // 
            // lblindexcaption
            // 
            this.lblindexcaption.AutoSize = true;
            this.lblindexcaption.Location = new System.Drawing.Point(25, 24);
            this.lblindexcaption.Name = "lblindexcaption";
            this.lblindexcaption.Size = new System.Drawing.Size(175, 15);
            this.lblindexcaption.TabIndex = 7;
            this.lblindexcaption.Text = "The idex of fields is";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "The index of this Combo box/ListBox ";
            // 
            // txtcomboboxindex
            // 
            this.txtcomboboxindex.Location = new System.Drawing.Point(326, 71);
            this.txtcomboboxindex.Name = "txtcomboboxindex";
            this.txtcomboboxindex.Size = new System.Drawing.Size(54, 25);
            this.txtcomboboxindex.TabIndex = 10;
            this.txtcomboboxindex.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcomboboxindex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblindex);
            this.Controls.Add(this.lblindexcaption);
            this.Name = "FormCombobox";
            this.Text = "Combo box or List Box";
            this.Load += new System.EventHandler(this.FormCombobox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblindex;
        private System.Windows.Forms.Label lblindexcaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcomboboxindex;
        private System.Windows.Forms.Button button1;
    }
}