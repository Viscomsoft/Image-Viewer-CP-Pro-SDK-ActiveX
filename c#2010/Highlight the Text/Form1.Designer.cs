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
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotpage = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.outputImageComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtalpha = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.axImageViewer1 = new AxSCRIBBLELib.AxImageViewer();
            ((System.ComponentModel.ISupportInitialize)(this.axImageViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 480);
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
            this.txtfilename.Location = new System.Drawing.Point(12, 538);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(326, 20);
            this.txtfilename.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Page";
            // 
            // txttotpage
            // 
            this.txttotpage.Location = new System.Drawing.Point(428, 538);
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
            this.label3.Location = new System.Drawing.Point(527, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Output Format";
            // 
            // outputImageComboBox
            // 
            this.outputImageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputImageComboBox.FormattingEnabled = true;
            this.outputImageComboBox.Location = new System.Drawing.Point(630, 485);
            this.outputImageComboBox.Name = "outputImageComboBox";
            this.outputImageComboBox.Size = new System.Drawing.Size(128, 21);
            this.outputImageComboBox.TabIndex = 24;
            this.outputImageComboBox.SelectedIndexChanged += new System.EventHandler(this.outputImageComboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "Save hightlight for all pages";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(655, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 40);
            this.button3.TabIndex = 26;
            this.button3.Text = "Save hightlight for page 2 only";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(141, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 41);
            this.button4.TabIndex = 27;
            this.button4.Text = "Hightlight";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hightlight Alpha(0-255)";
            // 
            // txtalpha
            // 
            this.txtalpha.Location = new System.Drawing.Point(258, 515);
            this.txtalpha.Name = "txtalpha";
            this.txtalpha.Size = new System.Drawing.Size(70, 20);
            this.txtalpha.TabIndex = 29;
            this.txtalpha.Text = "128";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(344, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 41);
            this.button5.TabIndex = 30;
            this.button5.Text = "Undo Last Hightlight";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // axImageViewer1
            // 
            this.axImageViewer1.Enabled = true;
            this.axImageViewer1.Location = new System.Drawing.Point(12, 12);
            this.axImageViewer1.Name = "axImageViewer1";
            this.axImageViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageViewer1.OcxState")));
            this.axImageViewer1.Size = new System.Drawing.Size(768, 451);
            this.axImageViewer1.TabIndex = 0;
            this.axImageViewer1.SelectionRectDrawn += new AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEventHandler(this.axImageViewer1_SelectionRectDrawn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 570);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtalpha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
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
            this.Text = "Highlight the text - DrawFillRectangle ";
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtalpha;
        private System.Windows.Forms.Button button5;
    }
}

