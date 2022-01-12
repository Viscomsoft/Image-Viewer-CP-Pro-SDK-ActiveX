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
           public string strApp;
        private void button1_Click(object sender, EventArgs e)
        {
            string strFile;
            string strType,strType2;

            chkfullpage.Checked = true;

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
          
            //MICR
            short ilangindex = 99;
            short imode = 0;

            


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



            axImageViewer1.OCRStartScan(ilangindex, "dictfiles");
 
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
            if (e.bSuccess)
            {
                txttotalchar.Text = axImageViewer1.OCRGetRecognizedCharCount().ToString();

                if (optoutput1.Checked)
                {
                    MessageBox.Show(axImageViewer1.OCRGetRecognizedText());

                }
                else
                {
                        this.saveFileDialog1.Filter = "Text File (*.txt)|*.txt";

                        if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                        {
                            bool bresult;
                            bresult = axImageViewer1.OCRSaveRecognizedText(saveFileDialog1.FileName);

                            if (bresult)
                                MessageBox.Show("Save completed");
                            else
                                MessageBox.Show("Save failed");
                         
                        }

                }

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

        private void chkuseadvpdf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkuseadvpdf.Checked)
                this.axImageViewer1.PDFUseAdvancedViewer = true;
            else
                this.axImageViewer1.PDFUseAdvancedViewer = false;
     

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             int iFindIndex;
            strApp = Application.ExecutablePath;
            iFindIndex = strApp.IndexOf("Examples");

            strApp = strApp.Substring(0, iFindIndex);
            strApp = strApp + "barcodeimage";

            
            axImageViewer1.FileName = strApp + "\\cheque-sample.jpg";
            txtPageNo.Text = "1";
            this.btnprev.Enabled = false;
            this.btnnext.Enabled = false;


            chkfullpage.Checked = false;

            txtleft.Text = "293";
            txttop.Text = "673";
            txtfilewidth.Text = "903";
            txtfileheight.Text = "87";
            axImageViewer1.DrawSelectionRect(293, 673, 903, 97);
            axImageViewer1.View = 9;
            axImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode;
        }   

        

    }
}