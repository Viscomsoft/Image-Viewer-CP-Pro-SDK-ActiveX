using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
          

        }

        private void button10_Click(object sender, EventArgs e)
        {
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtlinesourcepdf.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            bool bResult = false;

            if(txtlinesourcepdf.Text == "")
            {
                MessageBox.Show("Please select PDF file");
             return;
            }

          saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
           if(chklineallpage.Checked)
                bResult =axImageViewer1.PDFEditAddWatermarkLines(txtlinesourcepdf.Text, saveFileDialog1.FileName, -1, -1, Convert.ToInt16(txtlinestroke.Text), Convert.ToInt16(txtlineR.Text), Convert.ToInt16(txtlineG.Text), Convert.ToInt16(txtlineB.Text));
                  
           else
               bResult= axImageViewer1.PDFEditAddWatermarkLines(txtlinesourcepdf.Text, saveFileDialog1.FileName, (short)(Convert.ToInt16(txtlineStartPage.Text)-1), (short)(Convert.ToInt16(txtlineEndtPage.Text)-1), Convert.ToInt16(txtlinestroke.Text), Convert.ToInt16(txtlineR.Text), Convert.ToInt16(txtlineG.Text), Convert.ToInt16(txtlineB.Text));
          

        }
            if(bResult)
                MessageBox.Show("Add watermark lines (X) completed");
            else
                MessageBox.Show("Add watermark lines (X) failed");
      
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtwt1sourcepdf.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cborotation.Items.Add("90");
            cborotation.Items.Add("180");
            cborotation.Items.Add("270");
            cborotation.SelectedIndex = 0;

            cbowt1font.Items.Add("Arial");
            cbowt1font.Items.Add("Impact");
            cbowt1font.Items.Add("Times New Roman");
            cbowt1font.Items.Add("Comic Sans MS");
            cbowt1font.SelectedIndex = 0;

            cbowt2font.Items.Add("Arial");
            cbowt2font.Items.Add("Impact");
            cbowt2font.Items.Add("Times New Roman");
            cbowt2font.Items.Add("Comic Sans MS");
            cbowt2font.SelectedIndex = 1;

            cbowt1hori.Items.Add("Left");
            cbowt1hori.Items.Add("Center");
            cbowt1hori.Items.Add("Right");
            cbowt1hori.SelectedIndex = 1;

            cbowt1vert.Items.Add("Top");
            cbowt1vert.Items.Add("Center");
            cbowt1vert.Items.Add("Bottom");
            cbowt1vert.SelectedIndex = 1;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
           if(txtwt1sourcepdf.Text == "")
           {
               MessageBox.Show("Please select PDF file");
            return;
           }

       saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

       if( saveFileDialog1.ShowDialog() == DialogResult.OK)
       {
           if (chkwt1allpage.Checked)
               axImageViewer1.PDFEditAddWatermarkText1(txtwt1sourcepdf.Text, saveFileDialog1.FileName, txtwt1text.Text, -1, -1, Convert.ToInt16(txtwt1fontsize.Text), cbowt1font.Text, false, false, Convert.ToInt16(txtwt1rotation.Text), (short)cbowt1hori.SelectedIndex, (short)cbowt1vert.SelectedIndex, Convert.ToInt16(cbowt1red.Text), Convert.ToInt16(cbowt1green.Text), Convert.ToInt16(cbowt1blue.Text));

           else
               axImageViewer1.PDFEditAddWatermarkText1(txtwt1sourcepdf.Text, saveFileDialog1.FileName, txtwt1text.Text, Convert.ToInt16(txtwt1StartPage.Text),Convert.ToInt16( txtwt1EndPage.Text), Convert.ToInt16(txtwt1fontsize.Text), cbowt1font.Text, false, false, Convert.ToInt16(txtwt1rotation.Text), (short)cbowt1hori.SelectedIndex, (short)cbowt1vert.SelectedIndex, Convert.ToInt16(cbowt1red.Text), Convert.ToInt16(cbowt1green.Text), Convert.ToInt16(cbowt1blue.Text));
           

       }

        MessageBox.Show("Add watermark text 1 completed");
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtwt2sourcepdf.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            bool bResult = false;

             if(txtwt2sourcepdf.Text == "")
             {
             MessageBox.Show("Please select PDF file");
             return;
             }

             saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            if(chkwt2allpage.Checked)
                bResult =axImageViewer1.PDFEditAddWatermarkText2(txtwt2sourcepdf.Text, saveFileDialog1.FileName, txtwt2text.Text, -1, -1, Convert.ToInt16(txtwt2fontsize.Text), cbowt2font.Text, true, true, Convert.ToInt16(txtwt2rotation.Text), Convert.ToInt32(txtwt2xpos.Text), Convert.ToInt32(txtwt2ypos.Text), Convert.ToInt16(cbowt2red.Text), Convert.ToInt16(cbowt2green.Text), Convert.ToInt16(cbowt2blue.Text));

            else
               bResult= axImageViewer1.PDFEditAddWatermarkText2(txtwt2sourcepdf.Text, saveFileDialog1.FileName, txtwt2text.Text, (short)(Convert.ToInt16(txtwt2StartPage.Text)-1),  (short)(Convert.ToInt16(txtwt2EndPage.Text)-1), Convert.ToInt16(txtwt2fontsize.Text), cbowt2font.Text, true, true, Convert.ToInt16(txtwt2rotation.Text), Convert.ToInt32(txtwt2xpos.Text), Convert.ToInt32(txtwt2ypos.Text), Convert.ToInt16(cbowt2red.Text), Convert.ToInt16(cbowt2green.Text), Convert.ToInt16(cbowt2blue.Text));
           

        }

            if(bResult)
                 MessageBox.Show("Add watermark text 2 completed");
            else
                MessageBox.Show("Add watermark text 2 failed");
    
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            bool bResult = false;

             if( txtwipdfsource.Text== "")
             {
                  MessageBox.Show("Please select PDF file");
                      return;
             }

           if(txtwiimage.Text == "")
           {
                MessageBox.Show("Please select Image file");
                return;
           }
        saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            if (chkwiallpage.Checked)
                bResult=axImageViewer1.PDFEditAddWatermarkImage(txtwipdfsource.Text, saveFileDialog1.FileName, txtwiimage.Text, -1, -1, Convert.ToInt32(txtwixpos.Text), Convert.ToInt32(txtwiypos.Text), Convert.ToDouble(txtwiscalex.Text), Convert.ToDouble(txtwiscaley.Text));

            else
                bResult= axImageViewer1.PDFEditAddWatermarkImage(txtwipdfsource.Text, saveFileDialog1.FileName, txtwiimage.Text, (short)(Convert.ToInt16(txtwistartpage.Text) - 1), (short)(Convert.ToInt16(txtwiendpage.Text) - 1), Convert.ToInt32(txtwixpos.Text), Convert.ToInt32(txtwiypos.Text), Convert.ToDouble(txtwiscalex.Text), Convert.ToDouble(txtwiscaley.Text));
            

        }

            if (bResult)
                 MessageBox.Show("Add watermark image completed");
            else
                MessageBox.Show("Add watermark image failed");
    
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF (*.pdf)|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtwipdfsource.Text =openFileDialog1.FileName;

            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG (*.jpg)|*.jpg|TIF (*.tif)|*.tif";

               if( openFileDialog1.ShowDialog() == DialogResult.OK)
               {
                   txtwiimage.Text = openFileDialog1.FileName;
               }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF (*.pdf)|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtaddpasspdfsource.Text = openFileDialog1.FileName;

            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
             if( txtaddpasspdfsource.Text == "")
             {
                MessageBox.Show("Please select PDF file");
                return;
             }

      
                saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

               if(saveFileDialog1.ShowDialog() == DialogResult.OK)
               {
                    axImageViewer1.PDFEditEncrypt(txtaddpasspdfsource.Text, saveFileDialog1.FileName, txtaddpassuser.Text, txtaddpassowner.Text);

               }

               MessageBox.Show("Add user password completed");
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF (*.pdf)|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtimgextpdfsource.Text = openFileDialog1.FileName;

            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
              folderBrowserDialog1.ShowDialog();
              txtimgextoutputfolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            bool bResult = false;

           if(txtimgextpdfsource.Text == "")
           {
            MessageBox.Show("Please select PDF file");
            return;
           }



            if(txtimgextoutputfolder.Text == "")
            {
                MessageBox.Show("Please select Output folder");
                return;
            }

           bResult=axImageViewer1.PDFEditImageExtract(txtimgextpdfsource.Text, txtimgextoutputfolder.Text);

            if(bResult)
                MessageBox.Show("Image Extract completed");
            else
                MessageBox.Show("Image Extract failed");
       
        }

        private void Button29_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox1.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox2.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void chkcreatebookmarks_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcreatebookmarks.Checked)
            {
                txtroottitle.Enabled = true;
                txtoutline1text.Enabled = true;
                txtoutline2text.Enabled = true;

            }
            else
            {
                txtroottitle.Enabled = false;
                txtoutline1text.Enabled = false;
                txtoutline2text.Enabled = false;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool bResult;

            if (TextBox1.Text == "" || TextBox2.Text == "")
                MessageBox.Show("Please select PDF file");
            else
            {
                saveFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(chkcreatebookmarks.Checked)
                    {
                        bResult = axImageViewer1.PDFEditMergeWithBookmarks(TextBox1.Text, TextBox2.Text, saveFileDialog1.FileName, txtroottitle.Text, txtoutline1text.Text, txtoutline2text.Text);
                    }
                    else
                        bResult=axImageViewer1.PDFEditMerge(TextBox1.Text, TextBox2.Text, saveFileDialog1.FileName);

                    if (bResult)
                          MessageBox.Show("Merge Completed");
                    else
                          MessageBox.Show("Merge Failed");

                }
                else
                    return;
            }

        }

        private void txtroottitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox3.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            bool bResult;
            short page;
            page = Convert.ToInt16(this.TextBox4.Text);
            
            //first page is zero 
            page = (short)(page - 1);


            if (TextBox3.Text == "")
            {
                MessageBox.Show("Please select PDF file!");
                return;
            }
            else
            {
                bResult=axImageViewer1.PDFEditDeletePage(TextBox3.Text, page);
                if (bResult)
                 MessageBox.Show("Delete Page Completed!");
                else
                    MessageBox.Show("Delete Page Failed");
         
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox5.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox6.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            bool bResult;
            if (TextBox5.Text == "")
            {
                MessageBox.Show("Please select PDF Source file!");
                return;
            }
            if (TextBox6.Text == "")
            {
                MessageBox.Show("Please select Append from PDF File!");
                return;
            }
            saveFileDialog1.Filter = "PDF Files(*,pdf)|*.pdf||";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                short page;
                page = Convert.ToInt16(TextBox7.Text);
                page = (short)(page -1);

               bResult= axImageViewer1.PDFEditAddPage(TextBox5.Text, page, TextBox6.Text, saveFileDialog1.FileName);

               if (bResult)
                 MessageBox.Show("Add Page Completed!");
               else
                   MessageBox.Show("Add Page Failed!");
          
            }
            else
                return;
            
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox8.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            bool bResult;
            short page;
            page = Convert.ToInt16(TextBox9.Text);
            page = (short)(page - 1);

            if (TextBox8.Text == "")
            {
                MessageBox.Show("Please select PDF source file!");
                return;
            }
            saveFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            saveFileDialog2.Filter = "PDF File(*.pdf)|*.pdf||";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    bResult=axImageViewer1.PDFEditSplit(TextBox8.Text, page, saveFileDialog1.FileName, saveFileDialog2.FileName);

                    if (bResult)
                        MessageBox.Show("Split Completed!");
                    else
                        MessageBox.Show("Split Failed!");
            
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            bool bResult;
            short page;
            page = Convert.ToInt16(TextBox9.Text);
            page = (short)(page - 1);

            if (TextBox20.Text == "")
            {
                MessageBox.Show("Please select PDF source file!");
                return;
            }

             saveFileDialog1.Filter = "PDF Files(*,pdf)|*.pdf||";
             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                bResult= axImageViewer1.PDFEditRotate(TextBox20.Text, saveFileDialog1.FileName, page, Convert.ToInt16(cborotation.Text));

                if (bResult)
                    MessageBox.Show("Rotate PDF Page Completed");
                else
                    MessageBox.Show("Rotate PDF Page Failed");
        

             }
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox20.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void GroupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void Button11_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                TextBox10.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button12_Click_1(object sender, EventArgs e)
        {
            bool bResult;
           

            if (TextBox10.Text == "")
            {
                MessageBox.Show("Please select PDF source file!");
                return;
            }

              saveFileDialog1.Filter = "PDF Files(*,pdf)|*.pdf||";
              if (saveFileDialog1.ShowDialog() == DialogResult.OK)
              {
                  axImageViewer1.PDFEditCrop(TextBox10.Text, Convert.ToInt32(TextBox11.Text), Convert.ToInt32(TextBox12.Text), Convert.ToInt32(TextBox13.Text), Convert.ToInt32(TextBox14.Text), saveFileDialog1.FileName);
                  MessageBox.Show("Crop Completed!");

              }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            bool bResult=false;
            short iStartPage = Convert.ToInt16(txtmaskingStartPage.Text);
            iStartPage = (short)(iStartPage - 1);

            short iEndPage = Convert.ToInt16(txtmaskingEndPage.Text);
            iEndPage = (short)(iEndPage - 1);

            if (txtmaskingpdf.Text == "")
            {
                MessageBox.Show("Please select PDF file");
                return;
            }

            saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (chkMaskingAllPage.Checked)
                    bResult=axImageViewer1.PDFEditMasking(txtmaskingpdf.Text, saveFileDialog1.FileName, -1, -1, Convert.ToInt32(txtmaskingX.Text), Convert.ToInt32(txtmaskingY.Text), Convert.ToInt32(txtmaskingWidth.Text), Convert.ToInt32(txtmaskingHeight.Text), Convert.ToInt16(txtmaskingR.Text), Convert.ToInt16(txtmaskingG.Text), Convert.ToInt16(txtmaskingB.Text));

                else
                   bResult= axImageViewer1.PDFEditMasking(txtmaskingpdf.Text, saveFileDialog1.FileName, iStartPage, iEndPage, Convert.ToInt32(txtmaskingX.Text), Convert.ToInt32(txtmaskingY.Text), Convert.ToInt32(txtmaskingWidth.Text), Convert.ToInt32(txtmaskingHeight.Text), Convert.ToInt16(txtmaskingR.Text), Convert.ToInt16(txtmaskingG.Text), Convert.ToInt16(txtmaskingB.Text));


            }

            if (bResult)
               MessageBox.Show("PDF Masking completed");
            else
                MessageBox.Show("PDF Masking failed");
        

        }

        private void Button34_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtmaskingpdf.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button16_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File(*.pdf)|*.pdf||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtwt1sourcepdf.Text = openFileDialog1.FileName;
            else
                return;
        }

        private void Button15_Click_1(object sender, EventArgs e)
        {
            bool bResult = false;

            if (txtwt1sourcepdf.Text == "")
            {
                MessageBox.Show("Please select PDF file");
                return;
            }

            saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (chkwt1allpage.Checked)
                    bResult =axImageViewer1.PDFEditAddWatermarkText1(txtwt1sourcepdf.Text, saveFileDialog1.FileName, txtwt1text.Text, -1, -1, Convert.ToInt16(txtwt1fontsize.Text), cbowt1font.Text, false, false, Convert.ToInt16(txtwt1rotation.Text), (short)cbowt1hori.SelectedIndex, (short)cbowt1vert.SelectedIndex, Convert.ToInt16(cbowt1red.Text), Convert.ToInt16(cbowt1green.Text), Convert.ToInt16(cbowt1blue.Text));

                else
                    bResult = axImageViewer1.PDFEditAddWatermarkText1(txtwt1sourcepdf.Text, saveFileDialog1.FileName, txtwt1text.Text, (short) (Convert.ToInt16(txtwt1StartPage.Text)-1), (short)(Convert.ToInt16(txtwt1EndPage.Text)-1), Convert.ToInt16(txtwt1fontsize.Text), cbowt1font.Text, false, false, Convert.ToInt16(txtwt1rotation.Text), (short)cbowt1hori.SelectedIndex, (short)cbowt1vert.SelectedIndex, Convert.ToInt16(cbowt1red.Text), Convert.ToInt16(cbowt1green.Text), Convert.ToInt16(cbowt1blue.Text));


            }

            if (bResult)
              MessageBox.Show("Add watermark text 1 completed");
            else
                MessageBox.Show("Add watermark text 1 failed");
      
        }

        private void Button22_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF (*.pdf)|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtaddpasspdfsource.Text = openFileDialog1.FileName;

            }
        }

        private void Button23_Click_1(object sender, EventArgs e)
        {
            bool bResult = false;

            if (txtaddpasspdfsource.Text == "")
            {
                MessageBox.Show("Please select PDF file");
                return;
            }


            saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bResult=axImageViewer1.PDFEditEncrypt(txtaddpasspdfsource.Text, saveFileDialog1.FileName, txtaddpassuser.Text, txtaddpassowner.Text);

            }

            if(bResult)
                MessageBox.Show("Add user password completed");
            else
                MessageBox.Show("Add user password failed");
        }
    }
}
;