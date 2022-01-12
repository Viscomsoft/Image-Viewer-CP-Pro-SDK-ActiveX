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
        uint clrBorderFrameColor;
        short iX;
        short iY;


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

      

        private void rotateButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Rotate90();
            this.axImageViewer1.Focus();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|Open XML Paper Specification (*.xps *.oxps)|*.xps;*.oxps|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico";
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.axImageViewer1.FileName = this.openFileDialog.FileName;
                this.axImageViewer1.Focus();

                if(this.axImageViewer1.PDFIsEncrypted && this.axImageViewer1.FileHeight==0)
                    MessageBox.Show("PDF is encrypted with password, you need set PDFUserPassword property");

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

        private void cropImageFileButton_Click(object sender, EventArgs e)
        {
            string strFile = "c:\\test";
            string strType = this.outputImageComboBox.Text;


            this.axImageViewer1.Xdpi = Convert.ToInt16(this.dpiXTextBox.Text);
            this.axImageViewer1.Ydpi = Convert.ToInt16(this.dpiYTextBox.Text);


            short a = this.axImageViewer1.Crop2ImageFile(strFile, strType);

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

        private void cropClipboardButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Xdpi = Convert.ToInt16(this.dpiXTextBox.Text);
            this.axImageViewer1.Ydpi = Convert.ToInt16(this.dpiYTextBox.Text);

            bool a = this.axImageViewer1.Crop2Clipboard();

            if (a)
            {
                MessageBox.Show("Save Complete");
            }
            else
            {
                MessageBox.Show("Save fail");
            }
        }

        private void thumbBackColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.clrThumbnailBackColor = this.Color2Uint32(this.colorDialog.Color);
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            this.pageNoTextBox.Text = "1";
            this.MoveToPage();
        }

        private void MoveToPage()
        {
           
                this.axImageViewer1.LoadMultiPage(openFileDialog.FileName, Convert.ToInt16(this.pageNoTextBox.Text));
         

            this.totalPageLabel.Text = "Total Page " + this.axImageViewer1.GetTotalPage().ToString();
        }

        private void savePosButton_Click(object sender, EventArgs e)
        {
            this.iX = this.axImageViewer1.GetHorzScrollBarPos();
            this.iY = this.axImageViewer1.GetVertScrollBarPos();

            this.axImageViewer1.Focus();
        }

        private void restorePosButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.SetScrollBarPos(this.iX, this.iY);
        }

        private void saveBySizeButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.IsSaveMultiPage = chksavemultipage.Checked;

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
            this.openFileDialog.Filter = "PDF (*.pdf)|*.pdf|Open XML Paper Specification (*.xps *.oxps)|*.xps;*.oxps|TIF (*.tif)|*.tif";
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
  
                this.axImageViewer1.LoadMultiPage(this.openFileDialog.FileName, 1);

            
            }
       

            this.totalPageLabel.Text = "Total Page " + this.axImageViewer1.GetTotalPage().ToString();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            this.MoveToPage();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            short page = Convert.ToInt16(this.pageNoTextBox.Text);
            if (page > 1)
            {
                page --;
            }
            this.pageNoTextBox.Text = page.ToString();
            this.MoveToPage();
        }

        private void saveClipboardButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Copy2Clipboard();
        }

        private void savePictureBoxButton_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image=this.axImageViewer1.Copy2PictureBox();
        }

        private void saveHBitmapButton_Click(object sender, EventArgs e)
        {
            IntPtr hb=new IntPtr(this.axImageViewer1.Copy2HBITMAP());
            this.pictureBox1.Image = Image.FromHbitmap(hb);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            short page = Convert.ToInt16(this.pageNoTextBox.Text);
            short count = this.axImageViewer1.GetTotalPage();

            if (page < count)
            {
                page++;
            }
            else
            {
                page = count;
            }
            this.pageNoTextBox.Text = page.ToString();
            this.MoveToPage();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            this.pageNoTextBox.Text = this.axImageViewer1.GetTotalPage().ToString();
            this.MoveToPage();
        }

        /// <summary>
        /// Rotate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        ///   0 = 90-degree rotation without flipping
        ///  1 = 180-degree rotation without flipping
        ///  2 = 270-degree rotation without flipping
        ///  3 = no rotation and a horizontal flip
        ///  4 = 90-degree rotation followed by a horizontal flip
        ///  5 = 180-degree rotation followed by a horizontal flip
        ///  6 = 270-degree rotation followed by a horizontal flip
        ///  7 = no rotation and a vertical flip
        ///  8 = 90-degree rotation followed by a vertical flip
        ///  9 = 180-degree rotation followed by a vertical flip
        /// 10= 270-degree rotation followed by a vertical flip
        ///</remarks>
        private void advRotateButton_Click(object sender, EventArgs e)
        {
            if (this.rotRightRadioButton.Checked)
            {
                if (this.radioButton90.Checked)
                {
                    this.axImageViewer1.Rotate(0);
                }
                if (this.radioButton180.Checked)
                {
                    this.axImageViewer1.Rotate(1);
                }
                if (this.radioButton270.Checked)
                {
                    this.axImageViewer1.Rotate(2);
                }
            }
            else
            {
                if (this.radioButton90.Checked)
                {
                    this.axImageViewer1.Rotate(2);
                }
                if (this.radioButton180.Checked)
                {
                    this.axImageViewer1.Rotate(1);
                }
                if (this.radioButton270.Checked)
                {
                    this.axImageViewer1.Rotate(0);
                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.PrintImage(true);
        }

        private void flipVButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Rotate(7);
        }

        private void flipHButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Rotate(3);
        }

        private void cropHBitmapButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Xdpi = Convert.ToInt16(this.dpiXTextBox.Text);
            this.axImageViewer1.Ydpi = Convert.ToInt16(this.dpiYTextBox.Text);

            IntPtr hb = new IntPtr(this.axImageViewer1.Crop2HBITMAP());
            this.pictureBox1.Image = Image.FromHbitmap(hb);
        }

        private void clearSelButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.ClearSelectionRect();
        }

        private void importPictureBoxButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.ImportFromPictureBox(this.pictureBox1.Image);
        }

        private void borderWidthButton_Click(object sender, EventArgs e)
        {
            short iValue =Convert.ToInt16(this.borderWidthComboBox.Text);

            this.axImageViewer1.AddBorder(iValue, this.clrBorderFrameColor);
        }

        private void pasteClipboardButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.PasteFromClipboard();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.IsSaveMultiPage = chksavemultipage.Checked;

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
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.clrBorderFrameColor = this.Color2Uint32(this.colorDialog.Color);
            }
        }

        private void urlButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.LoadImageFromURL(this.urlTextBox.Text, 0);
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

            this.clrBorderFrameColor = this.Color2Uint32(Color.FromArgb(255, 255, 255));

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


            for (int i = -4; i <= 30; i++)
            {
                this.borderWidthComboBox.Items.Add(i.ToString());
            }
            this.borderWidthComboBox.SelectedIndex = 15;

            chkuseadvpdf.Checked = true;

            if (chkuseadvpdf.Checked)
                this.axImageViewer1.PDFUseAdvancedViewer = true;
            else
                this.axImageViewer1.PDFUseAdvancedViewer = false;

        }

        private void axImageViewer1_SelectionRectDrawn(object sender, AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent e)
        {
            this.selRectPosLabel.Text = "Selection Rectangle Position" + Environment.NewLine +
                "L:" + e.iLeft.ToString() + ", T:" + e.iTop.ToString() + ", W:" + e.iWidth.ToString() + ", H:" + e.iHeight.ToString();
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
            this.selRectPosLabel.Text = "Selection Rectangle Position" + Environment.NewLine +
               "L:" + e.iLeft.ToString() + ", T:" + e.iTop.ToString() + ", W:" + e.iWidth.ToString() + ", H:" + e.iHeight.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void chkuseadvpdf_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chkuseadvpdf.Checked)
                this.axImageViewer1.PDFUseAdvancedViewer = true;
            else
                this.axImageViewer1.PDFUseAdvancedViewer = false;
        
        }

        private void pdfRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

       





























  









 













 
































    }
}