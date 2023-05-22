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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbofont.Items.Add("Arial");
            cbofont.Items.Add("Tahoma");
            cbofont.Items.Add("Times New Roman");
            cbofont.Items.Add("Courier New");
            cbofont.SelectedIndex = 0;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string strFont;
            bool bResult=false;
            
            strFont = cbofont.Text;

        axImageViewer1.PDFWriterClearAll();
        axImageViewer1.PDFWriterAddPage(4, false);

        axImageViewer1.PDFWriterDrawImage(0, Application.StartupPath + "\\company-invoice-logo.jpg", 10, 100, 0.5, 0.5);
        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 450, 50, txtcaption.Text, 30, 0, 0, 0);
        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 450, 110, "Date:", 12, 0, 0, 0);

    
        //draw sample date
        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 490, 110, txtdate.Text, 12, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 450, 90, "Invoice No.:", 12, 0, 0, 0);

       axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 40, 150, "Bill To:", 12, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 40, 200, "Name:", 12, 0, 0, 0);

       axImageViewer1.PDFWriterDrawText(0, strFont, true, false,false, 40, 250, "Address:", 12, 0, 0, 0);

       axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 40, 300, "Email:", 12, 0, 0, 0);

      
        //draw sample company
        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 96, 150, txtbillto.Text, 12, 0, 0, 0);

        axImageViewer1.PDFWriterDrawRectange(0, 40, 380, 550, 35, 1, 74, 74, 74, true);

        //draw caption
        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 40, 365, "DESCRIPTION", 18, 255, 255, 255);

        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 250, 365, "UNIT", 18, 255, 255, 255);

        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 350, 365, "UNIT PRICE", 18, 255, 255, 255);

        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 500, 365, "AMOUNT", 18, 255, 255, 255);

        //draw item 1
        axImageViewer1.PDFWriterDrawText(0, strFont, false, false,false, 40, 400, "Item 1", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 250, 400, "1", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 350, 400, "100.00", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false,false, false, 500, 400, "$100.00", 20, 0, 0, 0);

        //draw item 2
        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 40, 430, "Item 2", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 250, 430, "2", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 350, 430, "100.00", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 500, 430, "$200.00", 20, 0, 0, 0);

        //draw item 3
        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 40, 460, "Item 3", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 250, 460, "2", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 350, 460, "200.00", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 500, 460, "$400.00", 20, 0, 0, 0);

        //draw item 4
        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 40, 490, "Item 4", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 250, 490, "1", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 350, 490, "500.00", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 500, 490, "$500.00", 20, 0, 0, 0);

        axImageViewer1.PDFWriterDrawLine(0, 40, 498, 550 + 40, 495, 1, 0, 0, 0);
        
        //draw total
        axImageViewer1.PDFWriterDrawText(0, strFont, true, false, false, 40, 540, "TOTAL", 18, 0, 0, 0);

        axImageViewer1.PDFWriterDrawText(0, strFont, false, false, false, 496, 540, "$1200.00", 20, 0, 0, 0);

         saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";


        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
        {

            bResult = axImageViewer1.PDFWriterCreatePDF(saveFileDialog1.FileName, "my creator", "my author", "my title", "my subject", "my keywords", "my producer");

            if (bResult)
                MessageBox.Show("PDF Created");
            

        }


        }
    }
}
