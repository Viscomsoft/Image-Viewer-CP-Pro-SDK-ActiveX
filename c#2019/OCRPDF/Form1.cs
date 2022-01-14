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
                     this.txtPageNo.Text = "1";
                     this.btnprev.Enabled = true;
                     this.btnnext.Enabled = true;

                 }
                 else
                 {
                     this.axImageViewer1.FileName = strFile;
                     this.txtPageNo.Text = "1";
                     this.txttotpage.Text = "1";
                     this.btnprev.Enabled = false;
                     this.btnnext.Enabled = false;


                 }

                 axImageViewer1.Focus();
                 axImageViewer1.HighQuality = true;
                 axImageViewer1.View = 5;
                 this.txtleft.Text = "0";
                 this.txttop.Text = "0";
                 this.txtfilewidth.Text = axImageViewer1.FileWidth.ToString();
                 this.txtfileheight.Text = axImageViewer1.FileHeight.ToString();
                 this.chkfullpage.Checked = true;
                 axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.NoSelectionRectMode;



             }

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            short page = Convert.ToInt16(this.txtPageNo.Text);
            short count = this.axImageViewer1.GetTotalPage();

            if (page < count)
            {
                page++;
            }
            else
            {
                page = count;
            }
            this.txtPageNo.Text = page.ToString();

            axImageViewer1.LoadMultiPage(this.txtfilename.Text, page);

        }

        private void btnscan_Click(object sender, EventArgs e)
        {
            if (this.txtfilename.Text.Length == 0)
            {
                MessageBox.Show("Please select image first");
                return;
            }

            if (optasync.Checked)
                axImageViewer1.OCRScanTextAsync(true);
            else
                axImageViewer1.OCRScanTextAsync(false);

            short ilangindex = 0;
            short imode = 0;

            if (optlang1.Checked)
                ilangindex = 0;
            else if (optlang2.Checked)
                ilangindex = 1;
            else if (optlang3.Checked)
                ilangindex = 2;
            else if (optlang4.Checked)
                ilangindex = 3;
            else if (optlang5.Checked)
                ilangindex = 4;
            else if (optlang6.Checked)
                ilangindex = 5;
            else if (optlang7.Checked)
                ilangindex = 6;
            else if (optlang8.Checked)
                ilangindex = 7;
            else if (optlang9.Checked)
                ilangindex = 8;
            else if (optlang10.Checked)
                ilangindex = 9;
            else if (optlang11.Checked)
                ilangindex = 10;
            else if (optlang12.Checked)
                ilangindex = 11;
            else if (optlang13.Checked)
                ilangindex = 12;
            else if (optlang14.Checked)
                ilangindex = 13;
            else if (optlang15.Checked)
                ilangindex = 14;
            else if (optlang16.Checked)
                ilangindex = 15;
            else if (optlang17.Checked)
                ilangindex = 16;
            else if (optlang18.Checked)
                ilangindex = 17;
            else if (optlang19.Checked)
                ilangindex = 18;
            else if (optlang20.Checked)
                ilangindex = 19;
            else if (optlang21.Checked)
                ilangindex = 20;
            else if (optlang22.Checked)
                ilangindex = 21;
            else if (optlang23.Checked)
                ilangindex = 22;
            else if (optlang24.Checked)
                ilangindex = 23;
            else if (optlang25.Checked)
                ilangindex = 24;
            else if (optlang26.Checked)
                ilangindex = 25;
            else if (optlang27.Checked)
                ilangindex = 26;
            else if (optlang28.Checked)
                ilangindex = 27;
            else if (optlang29.Checked)
                ilangindex = 28;
            else if (optlang30.Checked)
                ilangindex = 29;
            else if (optlang31.Checked)
                ilangindex = 30;
            else if (optlang32.Checked)
                ilangindex = 31;
            else if (optlang33.Checked)
                ilangindex = 32;
            else if (optlang34.Checked)
                ilangindex = 33;
            else if (optlang35.Checked)
                ilangindex = 34;
            else if (optlang36.Checked)
                ilangindex = 35;
            else if (optlang37.Checked)
                ilangindex = 36;
            else if (optlang38.Checked)
                ilangindex = 37;
            else if (optlang39.Checked)
                ilangindex = 38;
            else if (optlang40.Checked)
                ilangindex = 39;
            else if (optlang41.Checked)
                ilangindex = 40;
            else if (optlang42.Checked)
                ilangindex = 41;

            if (optmode1.Checked)
                imode = 0;
            else if (optmode2.Checked)
                imode = 1;
            else if (optmode3.Checked)
                imode = 2;


            if( ilangindex > 0 && txtfontname.Text == "" && txtfontfile.Text == "")
            {
                MessageBox.Show("Select select font name or font file");
                return;
            }

        
            if (RadioButtonFontName.Checked)
                 axImageViewer1.OCR2SearchablePDFFontName = txtfontname.Text;

            if (RadioButtonFontFile.Checked)
                axImageViewer1.OCR2SearchablePDFFontFile = txtfontfile.Text;
       


            if (optfilter1.Checked)
                axImageViewer1.OCRCharFilter = "";
            else if (optfilter2.Checked)
                axImageViewer1.OCRCharFilter = "0123456789";
            else if (optfilter3.Checked)
                axImageViewer1.OCRCharFilter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            else if (optfilter4.Checked)
                axImageViewer1.OCRCharFilter = "abcdefghijklmnopqrstuvwxyz";


            if (chkfullpage.Checked)
                axImageViewer1.OCRSetRect(0, 0, 0, 0);
            else
                axImageViewer1.OCRSetRect(Convert.ToInt16(txtleft.Text), Convert.ToInt16(txttop.Text), Convert.ToInt16(txtfilewidth.Text), Convert.ToInt16(txtfileheight.Text));


            axImageViewer1.OCRRecognizeMode = imode;

           if (chkusejpegcomp.Checked)
           {
               axImageViewer1.PDFUseJPEGCompression = true;
               axImageViewer1.PDFJPEGQuality= Convert.ToInt16(textBox1.Text);    
           }
            this.saveFileDialog1.Filter = "PDF File (*.pdf)|*.pdf";

          
            short iresult;
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if (optoutput1.Checked)
                    iresult=axImageViewer1.OCR2SearchablePDF(saveFileDialog1.FileName,ilangindex, "dictfiles");
                else
                    iresult=axImageViewer1.OCR2SearchableMultipagePDF(saveFileDialog1.FileName, ilangindex, "dictfiles");

                if (!optasync.Checked)
                {
                    if (iresult == 1)
                        MessageBox.Show("Save completed");
                }
		else
			btnscan.Enabled=false;
	
            }
 
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            short page = Convert.ToInt16(this.txtPageNo.Text);
            if (page > 1)
            {
                page--;
            }
            this.txtPageNo.Text = page.ToString();
            axImageViewer1.LoadMultiPage(this.txtfilename.Text, page);


        }

        private void axImageViewer1_SelectionRectDrawn(object sender, AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent e)
        {
            if (!chkfullpage.Checked)
            {
                this.txtleft.Text = e.iLeft.ToString();
                this.txttop.Text = e.iTop.ToString();
                this.txtfilewidth.Text = e.iWidth.ToString();
                this.txtfileheight.Text = e.iHeight.ToString();

            }
        }

        private void axImageViewer1_OCRRecognized(object sender, AxSCRIBBLELib._DImageViewerEvents_OCRRecognizedEvent e)
        {
            
        }
        private void axImageViewer1_OCRPDFA(object sender, AxSCRIBBLELib._DImageViewerEvents_OCRPDFAEvent e)
        {
            progressBar1.Value = e.iProgress;

            if (e.iProgress==100)
   	    {
                MessageBox.Show("Save completed");
		btnscan.Enabled=true;
	    }		
        }

        

        private void chkfullpage_CheckedChanged(object sender, EventArgs e)
        {
                if(!chkfullpage.Checked)
                    axImageViewer1.MouseTrackMode=MOUSE_TRACKMODE.SelectionRectMode;
            else
                    axImageViewer1.MouseTrackMode=MOUSE_TRACKMODE.NoSelectionRectMode;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axImageViewer1.OCRStopScan();
        }

        void Enable_SelectFont()
        {
            txtfontname.Enabled=true;
            Button3.Enabled = true;
            Button4.Enabled = true;
        }

        void Disable_SelectFont()
        {
             txtfontname.Enabled = true;
             Button3.Enabled = false;
             Button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void chkuseadvpdf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkuseadvpdf.Checked)
                this.axImageViewer1.PDFUseAdvancedViewer = true;
            else
                this.axImageViewer1.PDFUseAdvancedViewer = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           if(fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
            txtfontname.Text = fontDialog1.Font.FontFamily.Name;
            txtfontfile.Text = "";
           }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "True type font(*.TTF file)|*.ttf";
                if(openFileDialog1.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
                {
                    txtfontfile.Text = openFileDialog1.FileName;
                    txtfontname.Text = "";
                }  
   
        }

        private void optlang1_Click(object sender, EventArgs e)
        {
            Disable_SelectFont();
        }

        private void optlang2_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang3_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang4_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang5_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang6_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang7_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang8_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang9_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang10_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang11_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang12_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang13_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang14_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang15_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang16_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang17_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang18_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang19_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang20_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang21_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang22_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang23_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang24_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang25_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang26_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang27_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang28_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang29_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang30_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang31_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang32_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang33_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang34_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang35_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang36_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang37_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang38_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang39_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang40_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang41_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang42_Click(object sender, EventArgs e)
        {
            Enable_SelectFont();
        }

        private void optlang1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

    }
}