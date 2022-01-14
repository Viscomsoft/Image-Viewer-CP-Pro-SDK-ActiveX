Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim bResult As Boolean
        If TextBox1.Text = "" Then
            MessageBox.Show("Please select PDF 1 file")
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MessageBox.Show("Please select PDF 2 file")
            Exit Sub
        End If


        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            If chkcreatebookmarks.Checked Then
                bResult = AxImageViewer1.PDFEditMergeWithBookmarks(TextBox1.Text, TextBox2.Text, SaveFileDialog1.FileName, txtroottitle.Text, txtoutline1text.Text, txtoutline2text.Text)
            Else
                bResult = AxImageViewer1.PDFEditMerge(TextBox1.Text, TextBox2.Text, SaveFileDialog1.FileName)
            End If

            If bResult Then
                MessageBox.Show("Merge Completed")
            Else
                MessageBox.Show("Merge Failed")
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim bResult As Boolean
        If TextBox3.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

        'first page is zero
        bResult = AxImageViewer1.PDFEditDeletePage(TextBox3.Text, Int16.Parse(TextBox4.Text) - 1)
        If bResult Then
            MessageBox.Show("Delete Page Completed")
        Else
            MessageBox.Show("Delete Page Failed")
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox5.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox6.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim bResult As Boolean
        If TextBox5.Text = "" Then
            MessageBox.Show("Please select PDF Source file")
            Exit Sub
        End If

        If TextBox6.Text = "" Then
            MessageBox.Show("Please select Append from PDF File")
            Exit Sub
        End If
        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            bResult = AxImageViewer1.PDFEditAddPage(TextBox5.Text, TextBox7.Text - 1, TextBox6.Text, SaveFileDialog1.FileName)
            If bResult Then
                MessageBox.Show("Add Page Completed")
            Else
                MessageBox.Show("Add Page Failed")
            End If
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox8.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim bResult As Boolean
        If TextBox8.Text = "" Then
            MessageBox.Show("Please select PDF source File")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
        SaveFileDialog2.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            If SaveFileDialog2.ShowDialog() = DialogResult.OK Then

                bResult = AxImageViewer1.PDFEditSplit(TextBox8.Text, TextBox9.Text - 1, SaveFileDialog1.FileName, SaveFileDialog2.FileName)
                If bResult Then
                    MessageBox.Show("Split PDF Completed")
                Else
                    MessageBox.Show("Split PDF Failed")

                End If
            End If
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox10.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        If TextBox10.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            AxImageViewer1.PDFEditCrop(TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, SaveFileDialog1.FileName)
        End If

        MessageBox.Show("Crop Completed")

    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtlinesourcepdf.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Dim bResult As Boolean
        If txtlinesourcepdf.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If chklineallpage.Checked Then
                bResult = AxImageViewer1.PDFEditAddWatermarkLines(txtlinesourcepdf.Text, SaveFileDialog1.FileName, -1, -1, txtlinestroke.Text, txtlineR.Text, txtlineG.Text, txtlineB.Text)

            Else
                bResult = AxImageViewer1.PDFEditAddWatermarkLines(txtlinesourcepdf.Text, SaveFileDialog1.FileName, txtlineStartPage.Text - 1, txtlineEndtPage.Text - 1, txtlinestroke.Text, txtlineR.Text, txtlineG.Text, txtlineB.Text)
            End If

        End If
        If bResult Then
            MessageBox.Show("Add watermark lines (X) completed")
        Else
            MessageBox.Show("Add watermark lines (X) failed")

        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cborotation.Items.Add("90")
        cborotation.Items.Add("180")
        cborotation.Items.Add("270")
        cborotation.SelectedIndex = 0


        cbowt1font.Items.Add("Arial")
        cbowt1font.Items.Add("Impact")
        cbowt1font.Items.Add("Times New Roman")
        cbowt1font.Items.Add("Comic Sans MS")
        cbowt1font.SelectedIndex = 0

        cbowt2font.Items.Add("Arial")
        cbowt2font.Items.Add("Impact")
        cbowt2font.Items.Add("Times New Roman")
        cbowt2font.Items.Add("Comic Sans MS")
        cbowt2font.SelectedIndex = 1

        cbowt1hori.Items.Add("Left")
        cbowt1hori.Items.Add("Center")
        cbowt1hori.Items.Add("Right")
        cbowt1hori.SelectedIndex = 1

        cbowt1vert.Items.Add("Top")
        cbowt1vert.Items.Add("Center")
        cbowt1vert.Items.Add("Bottom")
        cbowt1vert.SelectedIndex = 1
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtwt1sourcepdf.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Dim bResult As Boolean
        If txtwt1sourcepdf.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If chkwt1allpage.Checked Then
                bResult = AxImageViewer1.PDFEditAddWatermarkText1(txtwt1sourcepdf.Text, SaveFileDialog1.FileName, txtwt1text.Text, -1, -1, txtwt1fontsize.Text, cbowt1font.Text, False, False, txtwt1rotation.Text, cbowt1hori.SelectedIndex, cbowt1vert.SelectedIndex, cbowt1red.Text, cbowt1green.Text, cbowt1blue.Text)

            Else
                bResult = AxImageViewer1.PDFEditAddWatermarkText1(txtwt1sourcepdf.Text, SaveFileDialog1.FileName, txtwt1text.Text, txtwt1StartPage.Text - 1, txtwt1EndPage.Text - 1, txtwt1fontsize.Text, cbowt1font.Text, False, False, txtwt1rotation.Text, cbowt1hori.SelectedIndex, cbowt1vert.SelectedIndex, cbowt1red.Text, cbowt1green.Text, cbowt1blue.Text)
            End If

        End If

        If bResult Then
            MessageBox.Show("Add watermark text 1 completed")
        Else
            MessageBox.Show("Add watermark text 1 failed")

        End If

    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtwt2sourcepdf.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Dim bResult As Boolean
        If txtwt2sourcepdf.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If chkwt2allpage.Checked Then
                bResult = AxImageViewer1.PDFEditAddWatermarkText2(txtwt2sourcepdf.Text, SaveFileDialog1.FileName, txtwt2text.Text, -1, -1, txtwt2fontsize.Text, cbowt2font.Text, True, True, txtwt2rotation.Text, txtwt2xpos.Text, txtwt2ypos.Text, cbowt2red.Text, cbowt2green.Text, cbowt2blue.Text)

            Else
                bResult = AxImageViewer1.PDFEditAddWatermarkText2(txtwt2sourcepdf.Text, SaveFileDialog1.FileName, txtwt2text.Text, txtwt2StartPage.Text - 1, txtwt2EndPage.Text - 1, txtwt2fontsize.Text, cbowt2font.Text, True, True, txtwt2rotation.Text, txtwt2xpos.Text, txtwt2ypos.Text, cbowt2red.Text, cbowt2green.Text, cbowt2blue.Text)
            End If

        End If

        If bResult Then
            MessageBox.Show("Add watermark text 2 completed")
        Else
            MessageBox.Show("Add watermark text 2 faild")

        End If

    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtwipdfsource.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        OpenFileDialog1.Filter = "JPEG (*.jpg)|*.jpg|TIF (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtwiimage.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Dim bResult As Boolean
        If txtwipdfsource.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

        If txtwiimage.Text = "" Then
            MessageBox.Show("Please select Image file")
            Exit Sub
        End If
        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If chkwiallpage.Checked Then
                bResult = AxImageViewer1.PDFEditAddWatermarkImage(txtwipdfsource.Text, SaveFileDialog1.FileName, txtwiimage.Text, -1, -1, txtwixpos.Text, txtwiypos.Text, txtwiscalex.Text, txtwiscaley.Text)

            Else
                bResult = AxImageViewer1.PDFEditAddWatermarkImage(txtwipdfsource.Text, SaveFileDialog1.FileName, txtwiimage.Text, txtwistartpage.Text - 1, txtwiendpage.Text - 1, txtwixpos.Text, txtwiypos.Text, txtwiscalex.Text, txtwiscaley.Text)
            End If

        End If

        If bResult Then
            MessageBox.Show("Add watermark image completed")
        Else
            MessageBox.Show("Add watermark image failed")
        End If

    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtaddpasspdfsource.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        Dim bResult As Boolean
        If txtaddpasspdfsource.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

      
        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            bResult = AxImageViewer1.PDFEditEncrypt(txtaddpasspdfsource.Text, SaveFileDialog1.FileName, txtaddpassuser.Text, txtaddpassowner.Text)

        End If

        If bResult Then
            MessageBox.Show("Add user password completed")
        Else
            MessageBox.Show("Add user password failed")
        End If

    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        FolderBrowserDialog1.ShowDialog()
        txtimgextoutputfolder.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        Dim bResult As Boolean
        If txtimgextpdfsource.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If



        If txtimgextoutputfolder.Text = "" Then
            MessageBox.Show("Please select Output folder")
            Exit Sub
        End If

        bResult = AxImageViewer1.PDFEditImageExtract(txtimgextpdfsource.Text, txtimgextoutputfolder.Text)

        If bResult Then
            MessageBox.Show("Image Extract completed")
        Else
            MessageBox.Show("Image Extract failed")

        End If

    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtimgextpdfsource.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub chkcreatebookmarks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcreatebookmarks.CheckedChanged
        If chkcreatebookmarks.Checked Then
            txtroottitle.Enabled = True
            txtoutline1text.Enabled = True
            txtoutline2text.Enabled = True
        Else
            txtroottitle.Enabled = False
            txtoutline1text.Enabled = False
            txtoutline2text.Enabled = False
        End If
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Dim bResult As Boolean
        If TextBox20.Text = "" Then
            MessageBox.Show("Please select PDF source File")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            bResult = AxImageViewer1.PDFEditRotate(TextBox20.Text, SaveFileDialog1.FileName, txtrotatepage.Text - 1, cborotation.Text)

            If bResult Then
                MessageBox.Show("Rotate PDF Page Completed")
            Else
                MessageBox.Show("Rotate PDF Page Failed")

            End If

        End If


    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox20.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtmaskingpdf.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Dim bResult As Boolean
        If txtmaskingpdf.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If chkMaskingAllPage.Checked Then
                bResult = AxImageViewer1.PDFEditMasking(txtmaskingpdf.Text, SaveFileDialog1.FileName, -1, -1, txtmaskingX.Text, txtmaskingY.Text, txtmaskingWidth.Text, txtmaskingHeight.Text, txtmaskingR.Text, txtmaskingG.Text, txtmaskingB.Text)

      
            Else
                bResult = AxImageViewer1.PDFEditMasking(txtmaskingpdf.Text, SaveFileDialog1.FileName, txtmaskingStartPage.Text - 1, txtmaskingEndPage.Text - 1, txtmaskingX.Text, txtmaskingY.Text, txtmaskingWidth.Text, txtmaskingHeight.Text, txtmaskingR.Text, txtmaskingG.Text, txtmaskingB.Text)
            End If

        End If

        If bResult Then
            MessageBox.Show("PDF Masking completed")
        Else
            MessageBox.Show("PDF Masking failed")
        End If

    End Sub
End Class
