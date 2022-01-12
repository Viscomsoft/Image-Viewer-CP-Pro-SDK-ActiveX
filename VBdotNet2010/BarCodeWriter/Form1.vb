Public Class Form1
    Inherits System.Windows.Forms.Form


    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbarcodevalue As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbobarcodestand As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbarcodewidth As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbarcodeheight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkshowtext As System.Windows.Forms.CheckBox
    Friend WithEvents chkshowcheckdigit As System.Windows.Forms.CheckBox
    Friend WithEvents chkfitrect As System.Windows.Forms.CheckBox
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbofontsize As System.Windows.Forms.ComboBox
    Friend WithEvents cbooutputimage As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtleft As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttop As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtheight As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chksave As System.Windows.Forms.CheckBox
    Friend WithEvents chkdrawbarcode As System.Windows.Forms.CheckBox
    Friend WithEvents txtsourceimage As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AxImageViewer2 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbarcodevalue = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbobarcodestand = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtbarcodeheight = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtbarcodewidth = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkshowtext = New System.Windows.Forms.CheckBox
        Me.chkshowcheckdigit = New System.Windows.Forms.CheckBox
        Me.chkfitrect = New System.Windows.Forms.CheckBox
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbofontsize = New System.Windows.Forms.ComboBox
        Me.chksave = New System.Windows.Forms.CheckBox
        Me.cbooutputimage = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtleft = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttop = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtheight = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkdrawbarcode = New System.Windows.Forms.CheckBox
        Me.txtsourceimage = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.AxImageViewer2 = New AxSCRIBBLELib.AxImageViewer
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AxImageViewer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode value"
        '
        'txtbarcodevalue
        '
        Me.txtbarcodevalue.Location = New System.Drawing.Point(112, 16)
        Me.txtbarcodevalue.Name = "txtbarcodevalue"
        Me.txtbarcodevalue.Size = New System.Drawing.Size(160, 20)
        Me.txtbarcodevalue.TabIndex = 1
        Me.txtbarcodevalue.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Barcode Standard"
        '
        'cbobarcodestand
        '
        Me.cbobarcodestand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobarcodestand.Location = New System.Drawing.Point(112, 48)
        Me.cbobarcodestand.Name = "cbobarcodestand"
        Me.cbobarcodestand.Size = New System.Drawing.Size(160, 21)
        Me.cbobarcodestand.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtbarcodeheight)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbarcodewidth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 96)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output Image Area"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(152, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "pixel"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(152, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "pixel"
        '
        'txtbarcodeheight
        '
        Me.txtbarcodeheight.Location = New System.Drawing.Point(80, 56)
        Me.txtbarcodeheight.Name = "txtbarcodeheight"
        Me.txtbarcodeheight.Size = New System.Drawing.Size(64, 20)
        Me.txtbarcodeheight.TabIndex = 3
        Me.txtbarcodeheight.Text = "100"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Height"
        '
        'txtbarcodewidth
        '
        Me.txtbarcodewidth.Location = New System.Drawing.Point(80, 24)
        Me.txtbarcodewidth.Name = "txtbarcodewidth"
        Me.txtbarcodewidth.Size = New System.Drawing.Size(64, 20)
        Me.txtbarcodewidth.TabIndex = 1
        Me.txtbarcodewidth.Text = "200"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Width"
        '
        'chkshowtext
        '
        Me.chkshowtext.Checked = True
        Me.chkshowtext.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkshowtext.Location = New System.Drawing.Point(8, 192)
        Me.chkshowtext.Name = "chkshowtext"
        Me.chkshowtext.Size = New System.Drawing.Size(80, 24)
        Me.chkshowtext.TabIndex = 5
        Me.chkshowtext.Text = "Show Text"
        '
        'chkshowcheckdigit
        '
        Me.chkshowcheckdigit.Checked = True
        Me.chkshowcheckdigit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkshowcheckdigit.Location = New System.Drawing.Point(8, 224)
        Me.chkshowcheckdigit.Name = "chkshowcheckdigit"
        Me.chkshowcheckdigit.Size = New System.Drawing.Size(120, 24)
        Me.chkshowcheckdigit.TabIndex = 6
        Me.chkshowcheckdigit.Text = "Show Check Digit"
        '
        'chkfitrect
        '
        Me.chkfitrect.Checked = True
        Me.chkfitrect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfitrect.Location = New System.Drawing.Point(8, 256)
        Me.chkfitrect.Name = "chkfitrect"
        Me.chkfitrect.Size = New System.Drawing.Size(120, 24)
        Me.chkfitrect.TabIndex = 7
        Me.chkfitrect.Text = "Fit to Rectangle"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(328, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(272, 264)
        Me.AxImageViewer1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(144, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Font Size"
        '
        'cbofontsize
        '
        Me.cbofontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofontsize.Location = New System.Drawing.Point(216, 200)
        Me.cbofontsize.Name = "cbofontsize"
        Me.cbofontsize.Size = New System.Drawing.Size(104, 21)
        Me.cbofontsize.TabIndex = 10
        '
        'chksave
        '
        Me.chksave.Location = New System.Drawing.Point(328, 280)
        Me.chksave.Name = "chksave"
        Me.chksave.Size = New System.Drawing.Size(144, 24)
        Me.chksave.TabIndex = 11
        Me.chksave.Text = "Save as Image Format"
        '
        'cbooutputimage
        '
        Me.cbooutputimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputimage.Location = New System.Drawing.Point(480, 280)
        Me.cbooutputimage.Name = "cbooutputimage"
        Me.cbooutputimage.Size = New System.Drawing.Size(136, 21)
        Me.cbooutputimage.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Generate barcode"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtheight)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txttop)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtleft)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 144)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Left"
        '
        'txtleft
        '
        Me.txtleft.Enabled = False
        Me.txtleft.Location = New System.Drawing.Point(80, 16)
        Me.txtleft.Name = "txtleft"
        Me.txtleft.Size = New System.Drawing.Size(56, 20)
        Me.txtleft.TabIndex = 1
        Me.txtleft.Text = "0"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(144, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "pixel"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Top"
        '
        'txttop
        '
        Me.txttop.Enabled = False
        Me.txttop.Location = New System.Drawing.Point(80, 48)
        Me.txttop.Name = "txttop"
        Me.txttop.Size = New System.Drawing.Size(56, 20)
        Me.txttop.TabIndex = 4
        Me.txttop.Text = "0"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(144, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "pixel"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Height"
        '
        'txtheight
        '
        Me.txtheight.Enabled = False
        Me.txtheight.Location = New System.Drawing.Point(80, 72)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(56, 20)
        Me.txtheight.TabIndex = 7
        Me.txtheight.Text = "100"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(144, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 24)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "pixel"
        '
        'chkdrawbarcode
        '
        Me.chkdrawbarcode.Location = New System.Drawing.Point(328, 320)
        Me.chkdrawbarcode.Name = "chkdrawbarcode"
        Me.chkdrawbarcode.Size = New System.Drawing.Size(184, 16)
        Me.chkdrawbarcode.TabIndex = 15
        Me.chkdrawbarcode.Text = "Draw barcode on image"
        '
        'txtsourceimage
        '
        Me.txtsourceimage.Enabled = False
        Me.txtsourceimage.Location = New System.Drawing.Point(328, 344)
        Me.txtsourceimage.Name = "txtsourceimage"
        Me.txtsourceimage.Size = New System.Drawing.Size(312, 20)
        Me.txtsourceimage.TabIndex = 16
        Me.txtsourceimage.Text = ""
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(544, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 24)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Select Image"
        '
        'AxImageViewer2
        '
        Me.AxImageViewer2.Enabled = True
        Me.AxImageViewer2.Location = New System.Drawing.Point(640, 8)
        Me.AxImageViewer2.Name = "AxImageViewer2"
        Me.AxImageViewer2.OcxState = CType(resources.GetObject("AxImageViewer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer2.Size = New System.Drawing.Size(352, 400)
        Me.AxImageViewer2.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1000, 446)
        Me.Controls.Add(Me.AxImageViewer2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtsourceimage)
        Me.Controls.Add(Me.chkdrawbarcode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbooutputimage)
        Me.Controls.Add(Me.chksave)
        Me.Controls.Add(Me.cbofontsize)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkfitrect)
        Me.Controls.Add(Me.chkshowcheckdigit)
        Me.Controls.Add(Me.chkshowtext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbobarcodestand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbarcodevalue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Barcode Writer"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AxImageViewer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 8 To 60
            cbofontsize.Items.Add(Trim(CStr(i)))
        Next

        cbofontsize.SelectedIndex = 10

        cbobarcodestand.Items.Add("Codabar")
        cbobarcodestand.Items.Add("Code11")
        cbobarcodestand.Items.Add("Code128A")
        cbobarcodestand.Items.Add("Code128B")
        cbobarcodestand.Items.Add("Code128C")
        cbobarcodestand.Items.Add("Code39")
        cbobarcodestand.Items.Add("EAN8")
        cbobarcodestand.Items.Add("EAN13")
        cbobarcodestand.Items.Add("Industrial25")
        cbobarcodestand.Items.Add("Interleaved25")
        cbobarcodestand.Items.Add("Matrix25")
        cbobarcodestand.Items.Add("Plessey")
        cbobarcodestand.Items.Add("UPCA")
        cbobarcodestand.Items.Add("UPCE")
        cbobarcodestand.SelectedIndex = 0

        cbooutputimage.Items.Add("Bmp")
        cbooutputimage.Items.Add("JPG")
        cbooutputimage.Items.Add("TIF")
        cbooutputimage.Items.Add("GIF")
        cbooutputimage.Items.Add("PCX")
        cbooutputimage.Items.Add("JP2")
        cbooutputimage.Items.Add("JPC")
        cbooutputimage.Items.Add("RAS")
        cbooutputimage.Items.Add("PGX")
        cbooutputimage.Items.Add("PNM")
        cbooutputimage.Items.Add("PNG")
        cbooutputimage.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strFile As String
        Dim strError As String
        Dim strType As String
        Dim iresult As Integer
        Dim bitmaphandle As Long
        Dim clrtrancolor As Color

        If txtbarcodevalue.Text = "" Then
            MessageBox.Show("Please enter the barcode value")
            Exit Sub
        End If

        strFile = "c:\test1"

        AxImageViewer1.BarCodeWriterSetValue(txtbarcodevalue.Text)
        AxImageViewer1.BarCodeWriterSetStandard(cbobarcodestand.SelectedIndex)
        AxImageViewer1.BarCodeWriterSetOutputArea(txtbarcodewidth.Text, txtbarcodeheight.Text)
        AxImageViewer1.BarCodeWriterShowCheckDigit(chkshowcheckdigit.Checked)
        AxImageViewer1.BarCodeWriterShowText(chkshowtext.Checked)
        AxImageViewer1.BarCodeWriterFitToRect(chkfitrect.Checked)

        AxImageViewer1.BarCodeWriterSetFontSize(Val(cbofontsize.Items(cbofontsize.SelectedIndex)))
        AxImageViewer1.BarCodeWriterLeftTopPos(txtleft.Text, txttop.Text)
        AxImageViewer1.BarCodeWriterSetHeight(txtheight.Text)

        AxImageViewer1.BarCodeWriterPreview()

        strError = AxImageViewer1.BarCodeWriterGetErrorMessage

        If strError <> "" Then
            MessageBox.Show(strError)
            Exit Sub
        End If


        If chksave.Checked Then

            strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)

            iresult = AxImageViewer1.BarCodeWriterSave(strFile, strType)

            If iresult = 0 Then

                MessageBox.Show(AxImageViewer1.BarCodeWriterGetErrorMessage)

            Else
                MessageBox.Show("Save " + strFile + "." + strType + " Complete")

            End If

        End If

        If chkdrawbarcode.Checked Then

            If txtsourceimage.Text = "" Then
                MessageBox.Show("Please input the source image")
                Exit Sub

            End If

            AxImageViewer2.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.NoSelectionRectMode
            AxImageViewer2.FileName = txtsourceimage.Text

            AxImageViewer2.ShowImage = True ' must set showimage if call DrawImageHBITMAP

            bitmaphandle = AxImageViewer1.BarCodeWriterSaveHBITMAP

            clrtrancolor = Color.FromArgb(255, 0, 0)

            AxImageViewer2.DrawImageHBITMAP(0, 0, bitmaphandle, Color2Uint32(clrtrancolor), 255)


            AxImageViewer1.DeleteBitmapHandle(bitmaphandle)




        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif|PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"





        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

     
            txtsourceimage.Text = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub chkdrawbarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdrawbarcode.CheckedChanged
        If chkdrawbarcode.Checked Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False

        End If
    End Sub

    Private Sub chkfitrect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfitrect.CheckedChanged
        If chkfitrect.Checked Then
            txtleft.Enabled = False
            txttop.Enabled = False
            txtheight.Enabled = False
        Else
            txtleft.Enabled = True
            txttop.Enabled = True
            txtheight.Enabled = True

        End If
    End Sub
End Class
