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
            for (int i = 8; i <= 60; i++)
            {
                this.cbofontsize.Items.Add(i.ToString());
            }
            this.cbofontsize.SelectedIndex = 0;
           
            cbobarcodestand.Items.Add("Codabar");
            cbobarcodestand.Items.Add("Code11");
            cbobarcodestand.Items.Add("Code128A");
            cbobarcodestand.Items.Add("Code128B");
            cbobarcodestand.Items.Add("Code128C");
            cbobarcodestand.Items.Add("Code39");
            cbobarcodestand.Items.Add("EAN8");
            cbobarcodestand.Items.Add("EAN13");
            cbobarcodestand.Items.Add("Industrial25");
            cbobarcodestand.Items.Add("Interleaved25");
            cbobarcodestand.Items.Add("Matrix25");
            cbobarcodestand.Items.Add("Plessey");
            cbobarcodestand.Items.Add("UPCA");
            cbobarcodestand.Items.Add("UPCE");
            cbobarcodestand.SelectedIndex = 0;

            cbooutputimage.Items.Add("Bmp");
            cbooutputimage.Items.Add("JPG");
            cbooutputimage.Items.Add("TIF");
            cbooutputimage.Items.Add("GIF");
            cbooutputimage.Items.Add("PCX");
            cbooutputimage.Items.Add("JP2");
            cbooutputimage.Items.Add("JPC");
            cbooutputimage.Items.Add("RAS");
            cbooutputimage.Items.Add("PGX");
            cbooutputimage.Items.Add("PNM");
            cbooutputimage.Items.Add("PNG");
            cbooutputimage.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtbarcodevalue.Text == "")
            {
                MessageBox.Show("Please enter the barcode value");
                return;
            }

            string strFile = "c:\\test1";
            axImageViewer1.BarCodeWriterSetValue(txtbarcodevalue.Text);
            axImageViewer1.BarCodeWriterSetStandard((short)cbobarcodestand.SelectedIndex);
            axImageViewer1.BarCodeWriterSetOutputArea(Convert.ToInt16(txtbarcodewidth.Text), Convert.ToInt16(txtbarcodeheight.Text));
            axImageViewer1.BarCodeWriterShowCheckDigit( chkshowcheckdigit.Checked);
            axImageViewer1.BarCodeWriterShowText(chkshowtext.Checked);
            axImageViewer1.BarCodeWriterFitToRect(chkfitrect.Checked);

            axImageViewer1.BarCodeWriterSetFontSize( Convert.ToInt16(cbofontsize.Text));
            axImageViewer1.BarCodeWriterLeftTopPos(Convert.ToInt16(txtleft.Text),Convert.ToInt16(txttop.Text));
            axImageViewer1.BarCodeWriterSetHeight(Convert.ToInt16(txtheight.Text));

            axImageViewer1.BarCodeWriterPreview();

            string strError = axImageViewer1.BarCodeWriterGetErrorMessage();
            if (strError != "")
            {
                MessageBox.Show(strError);
                return;
            }


            if (this.checkBox1.Checked)
            {
                string strType = cbooutputimage.Text;

                short iresult = axImageViewer1.BarCodeWriterSave(strFile, strType);

                if (iresult == 0)
                {
                    strError = axImageViewer1.BarCodeWriterGetErrorMessage();
                    MessageBox.Show(strError);

                }
                else
                    MessageBox.Show("Save " + strFile + "." + strType + " Complete");

            }

            if (this.checkBox2.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please input the source image");
                    return;
                }

              //  axImageViewer2.MouseTrackMode = MOUSE_TRACKMODE.NoSelectionRectMode;
                axImageViewer2.FileName = textBox1.Text;
                axImageViewer2.ShowImage = true;
                int bitmaphandle = axImageViewer1.BarCodeWriterSaveHBITMAP();
                axImageViewer2.DrawImageHBITMAP(0, 0, bitmaphandle, Color2Uint32(Color.FromArgb(255, 0, 0)), 255);
                axImageViewer2.DeleteBitmapHandle(bitmaphandle);

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


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                axImageViewer2.Visible = true;
            else
                axImageViewer2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|Mng (*.mng *.jng)|*.mng;*.jng|Raw Image format(*.cr2 *.nef *.crw *.mrw *.raf *.erf *.3fr *.dcr *.raw *.dng *.pef *.x3f *.arw *.sr2 *.mef *.prf)|*.cr2;*.nef;*.crw;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.prf|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico";
             if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
             {

                 textBox1.Text = this.openFileDialog1.FileName;
             }

        }
    }
}