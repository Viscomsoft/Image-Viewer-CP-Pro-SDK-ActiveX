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
            else if(optlang2.Checked)
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

            if (optmode1.Checked)
                imode = 0;
            else if (optmode2.Checked)
                imode = 1;
            else if (optmode3.Checked)
                imode = 2;

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


            this.saveFileDialog1.Filter = "Text file (*.txt)|*.txt||";
            this.saveFileDialog1.DefaultExt = "txt";

            short iresult=0;
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                iresult = axImageViewer1.OCR2SearchableTextFile(saveFileDialog1.FileName, ilangindex, "dictfiles");
            
          
           
                if (!optasync.Checked)
                {
                    if (iresult == 1)
                    {
                        MessageBox.Show("The save to text file completed, you may open these text file and editing the text,let the text of Searchable PDF file more accuracy");

                        btnsearchablePDF.Enabled = true;
                    }
                    else
                        MessageBox.Show("Failed");
                }
	        	else
			        btnscan.Enabled=false;
	
            
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

        private void axImageViewer1_OCRPDFATextFile(object sender, AxSCRIBBLELib._DImageViewerEvents_OCRPDFATextFileEvent e)
        {
            progressBar1.Value = e.iProgress;

            if (e.iProgress == 100)
            {
                MessageBox.Show("The save to text file completed, you may open these text file and editing the text,let the text of Searchable PDF file more accuracy");
                btnscan.Enabled = true;
                btnsearchablePDF.Enabled = true;
            }

        }
        private void axImageViewer1_OCRPDFA(object sender, AxSCRIBBLELib._DImageViewerEvents_OCRPDFAEvent e)
        {
       		
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

        private void btnsearchablePDF_Click(object sender, EventArgs e)
        {
            this.saveFileDialog2.Filter = "PDF file (*.pdf)|*.pdf||";
            this.saveFileDialog2.DefaultExt = "pdf";

            
             if(!chkfullpage.Checked )
             {
                 axImageViewer1.DrawSelectionRect(Convert.ToInt16(txtleft.Text), Convert.ToInt16(txttop.Text), Convert.ToInt16(txtfilewidth.Text), Convert.ToInt16(txtfileheight.Text));
                 axImageViewer1.Crop();
             }

        saveFileDialog2.Filter = "PDF file (*.pdf)|*.pdf||";

        saveFileDialog2.DefaultExt = "pdf";
            short iResult = 0;
        
            if (this.saveFileDialog2.ShowDialog(this) == DialogResult.OK)
            {
                iResult = axImageViewer1.OCRTextFile2SearchablePDF(saveFileDialog1.FileName, saveFileDialog2.FileName);

                if (iResult == 1)
                    MessageBox.Show("Save " + saveFileDialog2.FileName + " Completed");

                if (iResult == -1)
                    MessageBox.Show("Save " + saveFileDialog2.FileName + " Completed, but some page cannot matched the text files");
               


            }


        }   

        

    }
}