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
            this.openFileDialog.Filter = "DICOM files (*.dcm)|*.dcm";
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
              
                this.axImageViewer1.DICOMLoadImage (openFileDialog.FileName);
                this.txttotalpage.Text = this.axImageViewer1.DICOMGetTotalPage().ToString();

                this.listBox1.Items.Clear();
                this.listBox2.Items.Clear();
                this.listBox3.Items.Clear();

                int iCount = this.axImageViewer1.DICOMGetTagsCount();
                for(int i=0;i<iCount;i++)
                    listBox1.Items.Add(this.axImageViewer1.DICOMGetTagsName(i));

                if(listBox1.Items.Count>0)
                    listBox1.SelectedIndex=0;

                if (Convert.ToInt16(this.txttotalpage.Text) > 1)
                    this.txtcurpage.Enabled = true;
                else
                    this.txtcurpage.Enabled = false;

                this.axImageViewer1.Focus();

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

        private void zoomHeightButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 11;
            this.axImageViewer1.Focus();
        }

      
      

        private void savePosButton_Click(object sender, EventArgs e)
        {
            this.iX = this.axImageViewer1.GetHorzScrollBarPos();
            this.iY = this.axImageViewer1.GetVertScrollBarPos();

            this.axImageViewer1.Focus();
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

      
        private void clearSelButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.ClearSelectionRect();
        }

        private void importPictureBoxButton_Click(object sender, EventArgs e)
        {
        }

     

        private void pasteClipboardButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.PasteFromClipboard();
        }
     
        private void borderColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.clrBorderFrameColor = this.Color2Uint32(this.colorDialog.Color);
            }
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

            this.axImageViewer1.DICOMLoadImage(Application.StartupPath + "\\sampledcm.dcm");
            this.txttotalpage.Text = this.axImageViewer1.DICOMGetTotalPage().ToString();

            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();

            int iCount = this.axImageViewer1.DICOMGetTagsCount();
            for (int i = 0; i < iCount; i++)
                listBox1.Items.Add(this.axImageViewer1.DICOMGetTagsName(i));

            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;

            if (Convert.ToInt16(this.txttotalpage.Text) > 1)
                this.txtcurpage.Enabled = true;
            else
                this.txtcurpage.Enabled = false;

      
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



        private void axImageViewer1_DICOMPlaying(object sender, AxSCRIBBLELib._DImageViewerEvents_DICOMPlayingEvent e)
        {
            txtcurpage.Text = e.iFrameIndex.ToString();

        }

        private void axImageViewer1_SelectionRectDrawn_1(object sender, AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent e)
        {
            this.selRectPosLabel.Text = "Selection Rectangle Position" + Environment.NewLine +
        "L:" + e.iLeft.ToString() + ", T:" + e.iTop.ToString() + ", W:" + e.iWidth.ToString() + ", H:" + e.iHeight.ToString();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 12;
            this.axImageViewer1.Focus();
        }

        private void outputImageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void greyScaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                this.axImageViewer1.DICOMDisplayAllFrame(Convert.ToInt16(txtelapse.Text));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                int iCount = this.axImageViewer1.DICOMGetTagsSubItemCount(this.listBox1.SelectedIndex);
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                for (int i = 0; i < iCount; i++)
                    listBox2.Items.Add(this.axImageViewer1.DICOMGetTagsSubItemName(this.listBox1.SelectedIndex, i));
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex != -1)
            {
                listBox3.Items.Clear();
                listBox3.Items.Add(this.axImageViewer1.DICOMGetTagsSubItemValue(this.listBox1.SelectedIndex, this.listBox2.SelectedIndex));
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.axImageViewer1.DICOMDisplayFrame(Convert.ToInt16(this.txtcurpage.Text));
        }

      






























  









 













 
































    }
}