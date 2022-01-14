using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "PDF (*.pdf)|*.pdf|Tif (*.tif)|*.tif";
            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
             {

                 textImage.Text= this.openFileDialog1.FileName;

             }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            string strImage = textImage.Text;

            if (strImage == "")
            {
                MessageBox.Show("Please select the image");
                return;
            }
            strImage.ToLower();

                if (strImage.Substring(strImage.Length - 3) == "pdf")
                {
                    if (axImageViewer1.DocxPDF2Docx(strImage, "c:\\test1.docx"))
                        MessageBox.Show("c:\\test1.docx completed");

                }
                else
                {
                    if (axImageViewer1.DocxTIFF2Docx(strImage, "c:\\test1.docx"))
                        MessageBox.Show("c:\\test1.docx completed");


                }

        }

        private void chkuseadvpdf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkuseadvpdf.Checked)
                this.axImageViewer1.PDFUseAdvancedViewer = true;
            else
                this.axImageViewer1.PDFUseAdvancedViewer = false;
     
        }
    }
}
