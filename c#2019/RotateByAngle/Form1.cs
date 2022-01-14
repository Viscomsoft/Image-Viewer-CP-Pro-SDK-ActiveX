using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ADODB;
using SCRIBBLELib;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        uint clrThumbnailBackColor;
       


        public Form1()
        {
            InitializeComponent();
        }

        public uint Color2Uint32(Color clr)
        {

            int t;
            byte[] a;

            t = ColorTranslator.ToOle(clr);

            a = BitConverter.GetBytes(t);

            return BitConverter.ToUInt32(a, 0);

        }

     

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|Mng (*.mng *.jng)|*.mng;*.jng|Raw Image format(*.cr2 *.nef *.crw *.mrw *.raf *.erf *.3fr *.dcr *.raw *.dng *.pef *.x3f *.arw *.sr2 *.mef *.prf)|*.cr2;*.nef;*.crw;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.prf|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico";
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
              
                this.axImageViewer1.FileName = this.openFileDialog.FileName;
                this.axImageViewer1.Focus();

                if(this.axImageViewer1.PDFIsEncrypted && this.axImageViewer1.FileHeight==0)
                    MessageBox.Show("PDF is encrypted with password, password required");

                this.dpiXTextBox.Text = this.axImageViewer1.Xdpi.ToString();
                this.dpiYTextBox.Text = this.axImageViewer1.Ydpi.ToString();
                this.heightTextBox.Text = this.axImageViewer1.FileHeight.ToString();
                this.widthTextBox.Text = this.axImageViewer1.FileWidth.ToString();
            }
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.ZoomIn();
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.ZoomOut();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 1;
            this.axImageViewer1.Focus();
        }

        private void button200_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 7;
            this.axImageViewer1.Focus();
        }

        private void thumbButton_Click(object sender, EventArgs e)
        {
            string strType = this.outputImageComboBox.Text;

            this.axImageViewer1.Xdpi = Convert.ToInt16(this.dpiXTextBox.Text);
            this.axImageViewer1.Ydpi = Convert.ToInt16(this.dpiYTextBox.Text);
            
          
            short result = this.axImageViewer1.CreateThumbnail("c:\\test1", strType, Convert.ToInt16(this.thumbWidthTextBox.Text), Convert.ToInt16(this.thumbHeightTextBox.Text), this.clrThumbnailBackColor);

            if (result==1)
            {
                MessageBox.Show("Save " + "c:\\test" + "." + strType + " Complete");
            }
            else
            {
                MessageBox.Show("Save to c:\\ failed, if you run on win vista, make sure you turn off user control or have admin right");
            }
        }

        private void zoomHeightButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 11;
            this.axImageViewer1.Focus();
        }

       

        private void thumbBackColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.clrThumbnailBackColor = this.Color2Uint32(this.colorDialog.Color);
            }
        }

      

        private void saveBySizeButton_Click(object sender, EventArgs e)
        {

            string strFile = "c:\\test";
            string strType = this.outputImageComboBox.Text;

            this.axImageViewer1.Xdpi = Convert.ToInt16(this.dpiXTextBox.Text);
            this.axImageViewer1.Ydpi = Convert.ToInt16(this.dpiYTextBox.Text);

           
            short a = this.axImageViewer1.SaveBySize(strFile, strType, Convert.ToInt16(this.widthTextBox.Text), Convert.ToInt16(this.heightTextBox.Text));

            if (a == 1)
            {
                MessageBox.Show("Save " + strFile + "." + strType + " Complete");
            }
            else
            {
                 MessageBox.Show("Save to c:\\ failed, if you run on win vista, make sure you turn off user control or have admin right");
            }
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 9;
            this.axImageViewer1.Focus();
        }

        private void zoomWidthButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 10;
            this.axImageViewer1.Focus();
        }

        private void multiPageButton_Click(object sender, EventArgs e)
        {
              }

        private void goButton_Click(object sender, EventArgs e)
        {
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
        }

        private void saveClipboardButton_Click(object sender, EventArgs e)
        {
         }

        private void savePictureBoxButton_Click(object sender, EventArgs e)
        {
        }

        private void saveHBitmapButton_Click(object sender, EventArgs e)
        {
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
             }

        private void lastButton_Click(object sender, EventArgs e)
        {
        }

     
        private void advRotateButton_Click(object sender, EventArgs e)
        {

        }

     
        private void flipVButton_Click(object sender, EventArgs e)
        {
        }

        private void flipHButton_Click(object sender, EventArgs e)
        {
        }

        private void cropHBitmapButton_Click(object sender, EventArgs e)
        {
           }

        private void clearSelButton_Click(object sender, EventArgs e)
        {
          }

        private void importPictureBoxButton_Click(object sender, EventArgs e)
        {
        }

        private void borderWidthButton_Click(object sender, EventArgs e)
        {
            }

        private void pasteClipboardButton_Click(object sender, EventArgs e)
        {
         }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            string strFile = "c:\\test";
            string strType = this.outputImageComboBox.Text;

            this.axImageViewer1.Xdpi = Convert.ToInt16(this.dpiXTextBox.Text);
            this.axImageViewer1.Ydpi = Convert.ToInt16(this.dpiYTextBox.Text);

            short a=0;
            if (strType == "ICO")
            {
                a=this.axImageViewer1.SaveBySize(strFile, "ico", 32, 32);
            }
            else
            {
                a=this.axImageViewer1.Save(strFile, strType);
            }

            if (a == 1)
            {
                MessageBox.Show("Save " + strFile + "." + strType + " Complete");
            }
            else
            {
                 MessageBox.Show("Save to c:\\ failed, if you run on win vista, make sure you turn off user control or have admin right");
            }

            this.axImageViewer1.Focus();
        }

        private void borderColorButton_Click(object sender, EventArgs e)
        {
          
        }

        private void urlButton_Click(object sender, EventArgs e)
        {
         }

        private void button33_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 2;
            this.axImageViewer1.Focus();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 5;
            this.axImageViewer1.Focus();
        }

        private void button150_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 6;
            this.axImageViewer1.Focus();
        }
        
        private void backColorButton_Click(object sender, EventArgs e)
        {
            if(this.colorDialog.ShowDialog(this)==DialogResult.OK)
            {
                this.axImageViewer1.SetBackgroundColor(this.Color2Uint32(this.colorDialog.Color));
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 3;
            this.axImageViewer1.Focus();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 4;
            this.axImageViewer1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.axImageViewer1.FileName = Application.StartupPath + "\\demo.bmp";
            this.widthTextBox.Text = this.axImageViewer1.FileWidth.ToString();
            this.heightTextBox.Text = this.axImageViewer1.FileHeight.ToString();

         
            this.outputImageComboBox.Items.AddRange(new string[]{"Bmp","JPG","TIF","PDF","WBMP","GIF","PCX","TGA",
"ICO","JP2","JPC","RAS","PGX","PNM","PNG"});
            this.outputImageComboBox.SelectedIndex = 0;

            cbopixelformat.Items.Add("Convert to 1bpp");
            cbopixelformat.Items.Add("Convert to 4bpp");
            cbopixelformat.Items.Add("Convert to 8bpp");
            cbopixelformat.Items.Add("Convert to 8bpp Grayscale");
            cbopixelformat.Items.Add("Convert to 16bpp RGB555");
            cbopixelformat.Items.Add("Convert to 16bpp RGB565");
            cbopixelformat.Items.Add("Convert to 24bpp");
            cbopixelformat.Items.Add("Convert to 32bpp");
            cbopixelformat.Items.Add("Convert to 32bpp ARGB");
            cbopixelformat.SelectedIndex = 3;


        
        }

        private void axImageViewer1_SelectionRectDrawn(object sender, AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent e)
        {
          }

        private void borderRadioButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Border = this.borderOnRadioButton.Checked;
        }

        private void radioButton0_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.DefaultMode;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.SelectionRectMode;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.NoSelectionRectMode;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.NormalMode;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.LeftPanOnly;
        }

        private void highQRadioButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.HighQuality = this.highQOnRadioButton.Checked;
        }

        private void axImageViewer1_SelectionRectDrawn_1(object sender, AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 12;
            this.axImageViewer1.Focus();
        }

        private void outputImageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strType = this.outputImageComboBox.Text;

            if (strType == "PDF")
            {
                optpdfopt1.Enabled = true;
                optpdfopt2.Enabled = true;
                optpdfopt3.Enabled = true;
                optpdfopt4.Enabled = true;
                optpdfopt5.Enabled = true;

            }
            else
            {
                optpdfopt1.Enabled = false;
                optpdfopt2.Enabled = false;
                optpdfopt3.Enabled = false;
                optpdfopt4.Enabled = false;
                optpdfopt5.Enabled = false;
            }         
        }

        private void greyScaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.cbopixelformat.SelectedIndex == 0)
                this.axImageViewer1.ConvertTo1bpp();
            else if (this.cbopixelformat.SelectedIndex == 1)
                this.axImageViewer1.ConvertTo4bpp();
            else if (this.cbopixelformat.SelectedIndex == 2)
                this.axImageViewer1.ConvertTo8bpp();
            else if (this.cbopixelformat.SelectedIndex == 3)
                this.axImageViewer1.ConvertTo8bppGrayScale();
            else if (this.cbopixelformat.SelectedIndex == 4)
                this.axImageViewer1.ConvertTo16bppRGB555();
            else if (this.cbopixelformat.SelectedIndex == 5)
                this.axImageViewer1.ConvertTo16bppRGB565();
            else if (this.cbopixelformat.SelectedIndex == 6)
                this.axImageViewer1.ConvertTo24bpp();
            else if (this.cbopixelformat.SelectedIndex == 7)
                this.axImageViewer1.ConvertTo32bpp();
            else if (this.cbopixelformat.SelectedIndex == 8)
                this.axImageViewer1.ConvertTo32bppARGB();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axImageViewer1.ResetDefaultImage(false); 
            axImageViewer1.RotateAt(trackBar1.Value, Convert.ToInt16(txtbgR.Text), Convert.ToInt16(txtbgG.Text), Convert.ToInt16(txtbgB.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            axImageViewer1.ResetDefaultImage(false);
            axImageViewer1.RotateAt(trackBar1.Value, Convert.ToInt16(txtbgR.Text), Convert.ToInt16(txtbgG.Text), Convert.ToInt16(txtbgB.Text));
      
        }

      






























  









 













 
































    }
}