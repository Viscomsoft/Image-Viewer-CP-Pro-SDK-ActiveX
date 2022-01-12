Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf|TIF (*.tif)|*.tif||"




        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtimagefile.Text = OpenFileDialog1.FileName

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strFile As String


        strFile = Me.txtimagefile.Text

        If strFile = "" Then

            MessageBox.Show("Please select the image")
            Exit Sub
        End If

        strFile.ToLower()

        If strFile.Substring(strFile.Length() - 3) = "pdf" Then


            If Me.AxImageViewer1.DocxPDF2Docx(txtimagefile.Text, "c:\test1.docx") Then
                MessageBox.Show("Save c:\test1.docx completed")
                Exit Sub
            End If

        Else
            If Me.AxImageViewer1.DocxTIFF2Docx(txtimagefile.Text, "c:\test1.docx") Then
                MessageBox.Show("Save c:\test1.docx completed")
                Exit Sub
            End If


        End If

    End Sub

    Private Sub chkuseadvpdf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkuseadvpdf.CheckedChanged
        If chkuseadvpdf.Checked Then
            Me.AxImageViewer1.PDFUseAdvancedViewer = True
        Else
            Me.AxImageViewer1.PDFUseAdvancedViewer = False

        End If

    End Sub
End Class
