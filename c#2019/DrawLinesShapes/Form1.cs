using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SCRIBBLELib;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFile;
            string strType,strType2;

             this.openFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico";
             if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
             {
                 strFile =this.openFileDialog1.FileName;
                 strType =strFile.Substring(strFile.Length-3);
                 strType2 = strFile.Substring(strFile.Length - 4);
                 txtfilename.Text = strFile;
 
                 if (strType == "pdf" || strType == "tif" || strType =="tiff")
                 {
                     axImageViewer1.LoadMultiPage(strFile, 0);
                     this.txttotpage.Text = axImageViewer1.GetTotalPage().ToString();
                   

                 }
                 else
                 {
                     this.axImageViewer1.FileName = strFile;
                     this.txttotpage.Text = "1";

                 }

                 axImageViewer1.Focus();
                 axImageViewer1.HighQuality = true;
                 axImageViewer1.View = 5;
                 axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.NoSelectionRectMode;

                 axImageViewer1.DrawArc(10, 10, 100, 100, 2, 0, 0, 90, Color2Uint32(Color.FromArgb(255, 255, 255)), 255, true);
                 axImageViewer1.DrawBezier(50, 0, 100, 200, 300, 100, 300, 20, 4, 0, Color2Uint32(Color.FromArgb(255, 255, 0)), 255, true);
                 axImageViewer1.DrawEllipse(200, 200, 300, 300, 3, 1, Color2Uint32(Color.FromArgb(0, 0, 255)), 255, true);
                 axImageViewer1.DrawFillEllipse(400, 0, 100, 200, Color2Uint32(Color.FromArgb(0, 0, 255)), 100, true);
                 axImageViewer1.DrawFillEllipse(350, 0, 80, 150, Color2Uint32(Color.FromArgb(0, 255, 255)), 100, true);
                 axImageViewer1.DrawFillPie(0, 300, 50, 50, 0, 270, Color2Uint32(Color.FromArgb(128, 255, 255)), 255, true);
                 axImageViewer1.DrawFillRectangle(0, 0, 30, 100, Color2Uint32(Color.FromArgb(255, 255, 0)), 100, true);
                 axImageViewer1.DrawFillRectangle(100, 0, 100, 30, Color2Uint32(Color.FromArgb(255, 0, 255)), 20, true);
                 axImageViewer1.DrawLine(0, 0, 400, 200, 5, 2, Color2Uint32(Color.FromArgb(255, 0, 0)), 255, true);
                 axImageViewer1.DrawPie(150, 120, 150, 150, 2, 0, 0, 90, Color2Uint32(Color.FromArgb(100, 200, 100)), 255, true);
                 axImageViewer1.DrawRectangle(80, 120, 60, 60, 10, 0, Color2Uint32(Color.FromArgb(0, 255, 0)), 255, true);


             }

        }

        public uint Color2Uint32(Color clr)
        {

            int t;
            byte[] a;

            t = ColorTranslator.ToOle(clr);

            a = BitConverter.GetBytes(t);

            return BitConverter.ToUInt32(a, 0);

        }

       
      
       

      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.outputImageComboBox.Items.AddRange(new string[]{"Bmp","JPG","TIF","PDF","WBMP","GIF","PCX","TGA",
"JP2","JPC","RAS","PGX","PNM","PNG"});
            this.outputImageComboBox.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strType = this.outputImageComboBox.Text;

            this.saveFileDialog1.DefaultExt = strType;

            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                axImageViewer1.ClearDrawPageOnly();

                string strFileName = saveFileDialog1.FileName;
                strFileName=strFileName.Substring(0,strFileName.Length-4);
                short a = 0;
                a = this.axImageViewer1.Save(strFileName, strType);
                if (a == 1)
                {
                    MessageBox.Show("Save " + strFileName + "." + strType + " Complete");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strType = this.outputImageComboBox.Text;

            this.saveFileDialog1.DefaultExt = strType;

            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                axImageViewer1.DrawPageOnly(2);

                string strFileName = saveFileDialog1.FileName;
                strFileName = strFileName.Substring(0, strFileName.Length - 4);
                short a = 0;
                a = this.axImageViewer1.Save(strFileName, strType);
                if (a == 1)
                {
                    MessageBox.Show("Save " + strFileName + "." + strType + " Complete");
                }

            }
        }

        private void outputImageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              string strType = this.outputImageComboBox.Text;

              if (strType == "TIF" || strType == "PDF")
              {
                  if(axImageViewer1.GetTotalPage() > 1)
                  button3.Enabled = true;

              }
              else
                  button3.Enabled = false;

        }   

        

    }
}