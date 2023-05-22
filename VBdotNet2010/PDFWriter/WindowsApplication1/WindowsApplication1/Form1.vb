Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbofont.Items.Add("Arial")
        cbofont.Items.Add("Tahoma")
        cbofont.Items.Add("Times New Roman")
        cbofont.Items.Add("Courier New")
        cbofont.SelectedIndex = 0


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim strFont As String
        Dim bResult As Boolean
        ' strFont = "Arial"
        strFont = cbofont.Text

        AxImageViewer1.PDFWriterClearAll()
        AxImageViewer1.PDFWriterAddPage(4, False)

        AxImageViewer1.PDFWriterDrawImage(0, Application.StartupPath + "\\company-invoice-logo.jpg", 10, 100, 0.5, 0.5)
        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 450, 50, txtcaption.Text, 30, 0, 0, 0)
        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 450, 110, "Date:", 12, 0, 0, 0)

        'draw sample date
        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 490, 110, txtdate.Text, 12, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 450, 90, "Invoice No.:", 12, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 40, 150, "Bill To:", 12, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 40, 200, "Name:", 12, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 40, 250, "Address:", 12, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 40, 300, "Email:", 12, 0, 0, 0)

        'draw sample company
        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 96, 150, txtbillto.Text, 12, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawRectange(0, 40, 380, 550, 35, 1, 74, 74, 74, True)

        'draw caption
        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 40, 365, "DESCRIPTION", 18, 255, 255, 255)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 250, 365, "UNIT", 18, 255, 255, 255)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 350, 365, "UNIT PRICE", 18, 255, 255, 255)

        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 500, 365, "AMOUNT", 18, 255, 255, 255)

        'draw item 1
        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 40, 400, "Item 1", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 250, 400, "1", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 350, 400, "100.00", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 500, 400, "$100.00", 20, 0, 0, 0)

        'draw item 2
        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 40, 430, "Item 2", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 250, 430, "2", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 350, 430, "100.00", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 500, 430, "$200.00", 20, 0, 0, 0)

        'draw item 3
        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 40, 460, "Item 3", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 250, 460, "2", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 350, 460, "200.00", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 500, 460, "$400.00", 20, 0, 0, 0)

        'draw item 4
        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 40, 490, "Item 4", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 250, 490, "1", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 350, 490, "500.00", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 500, 490, "$500.00", 20, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawLine(0, 40, 498, 550 + 40, 495, 1, 0, 0, 0)

        'draw total
        AxImageViewer1.PDFWriterDrawText(0, strFont, True, False, False, 40, 540, "TOTAL", 18, 0, 0, 0)

        AxImageViewer1.PDFWriterDrawText(0, strFont, False, False, False, 496, 540, "$1200.00", 20, 0, 0, 0)


        Me.SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"


        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then


            bResult = AxImageViewer1.PDFWriterCreatePDF(SaveFileDialog1.FileName, "my creator", "my author", "my title", "my subject", "my keywords", "my producer")

            If bResult Then

                MessageBox.Show("PDF Created")
            End If

        End If


    End Sub
End Class
