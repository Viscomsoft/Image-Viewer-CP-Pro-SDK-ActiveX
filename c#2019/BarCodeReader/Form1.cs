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

             this.openFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico";
             if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
             {
                 strFile =this.openFileDialog1.FileName;
                 strType =strFile.Substring(strFile.Length-3);
                 strType2 = strFile.Substring(strFile.Length - 4);
                 txtfilename.Text = strFile;

              
                if (chkuseadvbarpdf.Checked)
                 {
                     axImageViewer1.LoadMultiPage(strFile, 0);
                     this.txttotpage.Text = axImageViewer1.GetTotalPage().ToString();
                     this.txtPageNo.Text = "1";
                     this.btnprev.Enabled = true;
                     this.btnnext.Enabled = true;
                     AdvBarcodeReader_OpenPDF(strFile);
                 }

                 else if (strType == "pdf" || strType == "tif" || strType =="tiff")
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



        private void AdvBarcodeReader_OpenPDF(string strFileName)
        {
            int iPDFPageCount=0;
            int i =0;

        cbopdfpage.Items.Clear();
        cbopdfimagecount.Items.Clear();

        iPDFPageCount =axImageViewer1.BarCodeReadPDFOpen(strFileName);

        cbopdfpage.Items.Clear();

        for( i = 1 ; i<=iPDFPageCount ;i++)
        {
            cbopdfpage.Items.Add("Page " + i.ToString());
        }
     
            if(cbopdfpage.Items.Count >0)
                cbopdfpage.SelectedIndex=0;
        
              chkScanMultiple.Checked = false;
              chkScan45CounterRotation.Checked = false;
              chkScan90Rotation.Checked = false;
              chkScan45Rotation.Checked = false;

        }


        private void btnnext_Click(object sender, EventArgs e)
        {
            int CurrentIndex=0;
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

            if(chkuseadvbarpdf.Checked)
            CurrentIndex = cbopdfpage.SelectedIndex + 1;

            if(CurrentIndex < cbopdfpage.Items.Count)
                cbopdfpage.SelectedIndex = CurrentIndex;

            
       

        }

        private void btnscan_Click(object sender, EventArgs e)
        {
            
            short ibarcodeCount = 0;
            string str1;
            string strtmp;

            axImageViewer1.BarCodeReadScanMultiple = chkScanMultiple.Checked;
            axImageViewer1.BarCodeReadScanWithoutRotation = chkscannorotation.Checked;
            axImageViewer1.BarCodeReadScan45Rotation = chkScan45Rotation.Checked;
            axImageViewer1.BarCodeReadScan45CouterRotation = chkScan45CounterRotation.Checked;
            axImageViewer1.BarCodeReadScan90Rotation = chkScan90Rotation.Checked;
            axImageViewer1.BarCodeReadCustomRotation = Convert.ToDouble( txtcustomrotation.Text);
            axImageViewer1.BarCodeReadScanAccuracy = chkscanmore.Checked;

            if (chkuseadvbarpdf.Checked)

                ibarcodeCount = axImageViewer1.BarCodeReadPDFScan((short)(cbopdfpage.SelectedIndex + 1), (short)(cbopdfimagecount.SelectedIndex + 1));

            else if (chkfullpage.Checked)
                ibarcodeCount = axImageViewer1.BarCodeReadFullPage();
            else
                ibarcodeCount = axImageViewer1.BarCodeReadByZone(Convert.ToInt16(txtleft.Text), Convert.ToInt16(txttop.Text), Convert.ToInt16(txtfilewidth.Text), Convert.ToInt16(txtfileheight.Text));


            if (ibarcodeCount < 1)
            {
                MessageBox.Show("No barcode found");
                return;
            }

            str1 = "Total " + ibarcodeCount.ToString() + " BarCode detected" + "\r\n";

            for (short i = 0; i < ibarcodeCount ; i++)
            {
                strtmp = axImageViewer1.BarCodeGetType(i) + " score:" + axImageViewer1.BarCodeGetScore(i).ToString() + " value:" + axImageViewer1.BarCodeGetValue(i).ToString();
                str1 = str1 + "\r\n" + strtmp;

            }

            MessageBox.Show(str1);
 
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            int CurrentIndex=0;
            short page = Convert.ToInt16(this.txtPageNo.Text);
            if (page > 1)
            {
                page--;
            }
            this.txtPageNo.Text = page.ToString();
            axImageViewer1.LoadMultiPage(this.txtfilename.Text, page);


            if(chkuseadvbarpdf.Checked)
            CurrentIndex = cbopdfpage.SelectedIndex - 1;

            if(CurrentIndex != -1)
                cbopdfpage.SelectedIndex = CurrentIndex;

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

     

        private void chkfullpage_CheckedChanged(object sender, EventArgs e)
        {
                if(!chkfullpage.Checked)
                    axImageViewer1.MouseTrackMode=MOUSE_TRACKMODE.SelectionRectMode;
            else
                    axImageViewer1.MouseTrackMode=MOUSE_TRACKMODE.NoSelectionRectMode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            int iFindIndex;
            strApp = Application.ExecutablePath;
            iFindIndex = strApp.IndexOf("Examples");

            strApp = strApp.Substring(0, iFindIndex);
            strApp = strApp + "barcodeimage";

            this.txtPageNo.Text = "1";
            this.txttotpage.Text = "1";
            this.btnprev.Enabled = false;
            this.btnnext.Enabled = false;
            axImageViewer1.MouseTrackMode = MOUSE_TRACKMODE.NoSelectionRectMode;

        }

        private void chkuseadvpdf_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkuseadvbarpdf.Checked)
                this.axImageViewer1.PDFUseAdvancedViewer = true;
            else
                this.axImageViewer1.PDFUseAdvancedViewer = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chkuseadvbarpdf.Checked = false;

            axImageViewer1.FileName = strApp + "\\barcodetest1.jpg";
            txttotpage.Text = "1";
            txtPageNo.Text = "1";
            btnnext.Enabled = false;
            btnprev.Enabled = false;
            txtfilename.Text = "";

            chkfullpage.Checked = true;
            txtleft.Text = "0";
            txttop.Text = "0";
            txtfilewidth.Text = axImageViewer1.FileWidth.ToString();
            txtfileheight.Text = axImageViewer1.FileHeight.ToString();
       }

        private void button3_Click(object sender, EventArgs e)
        {
            chkuseadvbarpdf.Checked = false;

            axImageViewer1.FileName = strApp + "\\barcodetest2.jpg";
            txttotpage.Text = "1";
            txtPageNo.Text = "1";
            btnnext.Enabled = false;
            btnprev.Enabled = false;
            txtfilename.Text = "";

            chkfullpage.Checked = true;
            txtleft.Text = "0";
            txttop.Text = "0";
            txtfilewidth.Text = axImageViewer1.FileWidth.ToString();
            txtfileheight.Text = axImageViewer1.FileHeight.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chkuseadvbarpdf.Checked = false;
            chkScanMultiple.Checked = true;

            axImageViewer1.FileName = strApp + "\\barcodetest3.jpg";
            txttotpage.Text = "1";
            txtPageNo.Text = "1";
            btnnext.Enabled = false;
            btnprev.Enabled = false;
            txtfilename.Text = "";

            chkfullpage.Checked = true;
            txtleft.Text = "0";
            txttop.Text = "0";
            txtfilewidth.Text = axImageViewer1.FileWidth.ToString();
            txtfileheight.Text = axImageViewer1.FileHeight.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chkuseadvbarpdf.Checked = false;

            axImageViewer1.FileName = strApp + "\\barcodetest4.png";
            txttotpage.Text = "1";
            txtPageNo.Text = "1";
            btnnext.Enabled = false;
            btnprev.Enabled = false;
            txtfilename.Text = "";

            chkfullpage.Checked = true;
            txtleft.Text = "0";
            txttop.Text = "0";
            txtfilewidth.Text = axImageViewer1.FileWidth.ToString();
            txtfileheight.Text = axImageViewer1.FileHeight.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chkuseadvbarpdf.Checked = false;
            chkScan90Rotation.Checked = true;

            axImageViewer1.FileName = strApp + "\\barcodetest5.jpg";
            txttotpage.Text = "1";
            txtPageNo.Text = "1";
            btnnext.Enabled = false;
            btnprev.Enabled = false;
            txtfilename.Text = "";

            chkfullpage.Checked = true;
            chkScan90Rotation.Checked = true;

            txtleft.Text = "0";
            txttop.Text = "0";
            txtfilewidth.Text = axImageViewer1.FileWidth.ToString();
            txtfileheight.Text = axImageViewer1.FileHeight.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chkuseadvbarpdf.Checked = false;

            txttotpage.Text = "1";
            txtPageNo.Text = "1";
            btnnext.Enabled = false;
            btnprev.Enabled = false;
            txtfilename.Text = "";

            chkfullpage.Checked = true;
            txtleft.Text = "0";
            txttop.Text = "0";
            txtfilewidth.Text = axImageViewer1.FileWidth.ToString();
            txtfileheight.Text = axImageViewer1.FileHeight.ToString();

            chkuseadvbarpdf.Checked=true;


            AdvBarcodeReader_OpenPDF(strApp + "\\barcodetest6.pdf");


          axImageViewer1.LoadMultiPage(strApp + "\\barcodetest6.pdf", 1);

        }

        private void cbopdfpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iImageCountPerPage=0;
            int i =0;

            this.cbopdfimagecount.Items.Clear();
         
        iImageCountPerPage =axImageViewer1.BarCodeReadPDFImageCount((short)(cbopdfpage.SelectedIndex + 1));
        for( i = 1; i<= iImageCountPerPage; i++)
        {
            cbopdfimagecount.Items.Add("Image " + i.ToString());
        }

          if(cbopdfimagecount.Items.Count > 0)
            cbopdfimagecount.SelectedIndex = 0;

          txtPageNo.Text = (cbopdfpage.SelectedIndex + 1).ToString();
        }

       

        

    }
}