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
        private uint clrHashForeColor;
        private uint clrHashBackColor;

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

        private void Form1_Load(object sender, EventArgs e)
        {
        
            this.clrHashForeColor =this.Color2Uint32( Color.Black);
            this.clrHashBackColor = this.Color2Uint32(Color.White);

        
         

        }

      

        private void textStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         }

        

        private void greyScaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void showTWAIN_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void clearImage_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void captureAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.ApplyDefaultCap();
        }

        private void ApplyDefaultCap()
        {
          
        }

   



        private void rotate90Button_Click(object sender, EventArgs e)
        {

         

           this.axImageViewer1.Rotate90();
        }

        private void zoom200Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 7;
            this.axImageViewer1.SetControlFocus();
        }

        private void zoom33Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 2;
            this.axImageViewer1.SetControlFocus();
        }

        private void zoom25Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 1;
            this.axImageViewer1.SetControlFocus();
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageViewer1.SetBackgroundColor(this.Color2Uint32(cd.Color));
                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
        }

        private void saveMultiPageTiffButton_Click(object sender, EventArgs e)
        {
          
        }

        private void SaveToPDF()
        {
            this.saveFileDialog1.Filter = "PDF File (*.pdf)|*.pdf";
            this.saveFileDialog1.DefaultExt = "pdf";

       
        }
        private void saveMultiPagePDFButton_Click(object sender, EventArgs e)
        {
            SaveToPDF();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           

        }

        private void RefreshPageNo()
        {
        }

        private void saveBySizeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void rotate180Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Rotate180();
        }

        private void ratioButton_Click(object sender, EventArgs e)
        {
            axImageViewer1.View = 12;
            axImageViewer1.SetControlFocus();
        }

        private void saveToClipboardButton_Click(object sender, EventArgs e)
        {
           
        }

        private void saveToPictureboxButton_Click(object sender, EventArgs e)
        {
           
        }

        private void saveToHBButton_Click(object sender, EventArgs e)
        {
            
        }

        private void rotate270Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.Rotate270();
        }

        private void goToPageButton_Click(object sender, EventArgs e)
        {
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           
        }

    



   
        private void scanButton_Click(object sender, EventArgs e)
        {
          


          
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 9;
            this.axImageViewer1.SetControlFocus();
        }

        private void zoom150Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 7;
            this.axImageViewer1.SetControlFocus();
        }

        private void zoom100Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 5;
            this.axImageViewer1.SetControlFocus();
        }

        private void zoom50Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 3;
            this.axImageViewer1.SetControlFocus();
        }

        private void zoom75Button_Click(object sender, EventArgs e)
        {
            this.axImageViewer1.View = 4;
            this.axImageViewer1.SetControlFocus();
        }

        private void SetBorder()
        {
            this.axImageViewer1.Border = this.borderOnRadioButton.Checked;
        }

        private void borderOnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SetBorder();
        }

        private void hqYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SetHighQ();
        }

        private void SetHighQ()
        {
            this.axImageViewer1.HighQuality = this.hqYesRadioButton.Checked;
        }

    

        private void userDefineNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void leftLocation_ValueChanged(object sender, EventArgs e)
        {
            RefreshFileLocation();
        }

        private void RefreshFileLocation()
        {
          
        }

        private void topLocation_ValueChanged(object sender, EventArgs e)
        {
            this.RefreshFileLocation();
        }

   

        private void axScanner1_EndScan_1(object sender, EventArgs e)
        {
           
           

            this.RefreshPageNo();
        }
        private void axScanner1_ScanningError(object sender, EventArgs e)
        {
          
        }
        private void axScanner1_EndAllScan(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chkpanning.Checked)
                axImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.LeftPanOnly;
            else
                axImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.DefaultMode;

            openFileDialog1.Filter = "PDF (*.pdf)|*.pdf";

            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                  textBox1.Text = openFileDialog1.FileName;
                  axImageViewer1.PDFUseAdvancedViewer = true;
                  axImageViewer1.LoadMultiPage(openFileDialog1.FileName,1);

               

                  this.totalPageLabel.Text = axImageViewer1.GetTotalPage().ToString();

     
            }

            listBox1.Items.Clear();

            lbltotalpdfformfield.Text = axImageViewer1.PDFFormFieldsCount().ToString();
            for (int i = 0; i < axImageViewer1.PDFFormFieldsCount(); i++)
            {
                short iType = axImageViewer1.PDFFormFieldsWidgetType((short)i);
                string strLabel = axImageViewer1.PDFFormFieldsLabel((short)i);
                string strFieldName = axImageViewer1.PDFFormFieldsName((short)i);
                string strItem;
                string strValue = "";

             

               strItem = "Index " + i.ToString() + " " + "FieldName:" + strFieldName + " "+"Label:" + strLabel + " WidgetType: " + GetWidgetType(iType) ;

                listBox1.Items.Add(strItem);
            }

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }

                
        }


        public string GetWidgetType(int iType)
        {
            string strType = "";

            if (iType == 0)
                strType = "UNKNOWN";
            else if (iType == 1)
                strType = "BUTTON";
            else if (iType == 2)
                strType = "CHECKBOX";
            else if (iType == 3)
                strType = "COMBOBOX";
            else if (iType == 4)
                strType = "LISTBOX";
            else if (iType == 5)
                strType = "RADIOBUTTON";
            else if (iType == 6)
                strType = "SIGNATURE";
            else if (iType == 7)
                strType = "TEXT";

            return strType;
        }

        private void chkpanning_CheckedChanged(object sender, EventArgs e)
        {
           
         
        }

        private void btnEditField_Click(object sender, EventArgs e)
        {
            int iSelIndex = listBox1.SelectedIndex;

            if (iSelIndex < 0)
                return;

            short iType = axImageViewer1.PDFFormFieldsWidgetType((short)iSelIndex);

        

            if (iType == 3) //combo, list box
            {
                FormCombobox frm = new FormCombobox();
                frm.FieldIndex = iSelIndex;
                frm.ComboBoxIndex = axImageViewer1.PDFFormFieldsCboListBoxIndex((short)iSelIndex);

                if (frm.ShowDialog() == DialogResult.OK)
                {

                    axImageViewer1.PDFFormFieldsSetCboListBoxIndex((short)iSelIndex, (short)frm.ComboBoxIndex);
                    axImageViewer1.PDFFormFieldsUpdate("",-1);
                }
            }
            else if (iType == 7) // textbox
            {
                FormTextBox frm = new FormTextBox();
                frm.Value = axImageViewer1.PDFFormFieldsText((short)iSelIndex);
                frm.FieldIndex = iSelIndex;

                if (frm.ShowDialog() == DialogResult.OK)
                {

                    axImageViewer1.PDFFormFieldsSetText((short)iSelIndex, frm.Value);
                    axImageViewer1.PDFFormFieldsUpdate("",-1);


                }
            }
            else if (iType == 2)
            {
                FormCheckBox frm = new FormCheckBox();
                frm.Checked = axImageViewer1.PDFFormFieldsIsCheck((short)iSelIndex);
                frm.FieldIndex = iSelIndex;


                if (frm.ShowDialog() == DialogResult.OK)
                {

                    axImageViewer1.PDFFormFieldsSetChecked((short)iSelIndex, (short)frm.Checked);

                    axImageViewer1.PDFFormFieldsUpdate("",-1);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
             saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";


            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (chkexportcurrentpage.Checked)
                     axImageViewer1.PDFFormFieldsUpdate(saveFileDialog1.FileName, Convert.ToInt16(txtPage.Text));
                   
                else
                    axImageViewer1.PDFFormFieldsUpdate(saveFileDialog1.FileName, -1);
               
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axImageViewer1.LoadMultiPage(openFileDialog1.FileName, Convert.ToInt16(txtPage.Text));
            listBox1.Items.Clear();

            lbltotalpdfformfield.Text = axImageViewer1.PDFFormFieldsCount().ToString();
            for (int i = 0; i < axImageViewer1.PDFFormFieldsCount(); i++)
            {
                short iType = axImageViewer1.PDFFormFieldsWidgetType((short)i);
                string strLabel = axImageViewer1.PDFFormFieldsLabel((short)i);
                string strFieldName = axImageViewer1.PDFFormFieldsName((short)i);
                string strItem;
              



                strItem = "Index " + i.ToString() + " " + "FieldName:" + strFieldName + " " + "Label:" + strLabel + " WidgetType: " + GetWidgetType(iType);

                listBox1.Items.Add(strItem);
            }

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
        }

      
     


    }
}