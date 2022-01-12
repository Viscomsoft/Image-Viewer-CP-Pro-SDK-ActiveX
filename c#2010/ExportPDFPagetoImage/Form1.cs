using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbopdfscale.Items.Add("0.5");
            cbopdfscale.Items.Add("1.3");
            cbopdfscale.Items.Add("2.0");
            cbopdfscale.Items.Add("2.5");
            cbopdfscale.Items.Add("3.0");
            cbopdfscale.SelectedIndex = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Please select PDF file");
                return;
            }

            saveFileDialog1.Filter = "BMP Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|TIF Files (*.tif)|*.tif|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // AxImageViewer1.TIFCompression = SCRIBBLELib.TIF_COMPRESSION.CompressionCCITT3
                axImageViewer1.PDFUseAdvancedViewer = true;
                axImageViewer1.PDFEditGetBitmapBySize(textBox1.Text, Convert.ToInt16(txtpageno.Text), double.Parse(cbopdfscale.Text), saveFileDialog1.FileName);
            }

        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter ="PDF (*.pdf)|*.pdf";
             if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
             {

                 textBox1.Text = this.openFileDialog1.FileName;
             }

        }
    }
}