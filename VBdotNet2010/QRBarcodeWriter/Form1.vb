Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim clrBgColor As Color
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Dim clrFgColor As Color




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
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbooutputimage As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AxImageViewer2 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboversion As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboerrlevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtscale As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtsourceimage As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbarcodevalue = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbooutputimage = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboversion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboerrlevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtscale = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtsourceimage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.AxImageViewer2 = New AxSCRIBBLELib.AxImageViewer()
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxImageViewer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtbarcodevalue.Text = "http://www.viscomsoft.com"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(23, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Save Format"
        '
        'cbooutputimage
        '
        Me.cbooutputimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputimage.Location = New System.Drawing.Point(155, 225)
        Me.cbooutputimage.Name = "cbooutputimage"
        Me.cbooutputimage.Size = New System.Drawing.Size(136, 21)
        Me.cbooutputimage.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Generate barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Version"
        '
        'cboversion
        '
        Me.cboversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboversion.FormattingEnabled = True
        Me.cboversion.Location = New System.Drawing.Point(112, 59)
        Me.cboversion.Name = "cboversion"
        Me.cboversion.Size = New System.Drawing.Size(160, 21)
        Me.cboversion.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Err Level"
        '
        'cboerrlevel
        '
        Me.cboerrlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboerrlevel.FormattingEnabled = True
        Me.cboerrlevel.Location = New System.Drawing.Point(112, 101)
        Me.cboerrlevel.Name = "cboerrlevel"
        Me.cboerrlevel.Size = New System.Drawing.Size(160, 21)
        Me.cboerrlevel.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Scale (0.5 to 5)"
        '
        'txtscale
        '
        Me.txtscale.Location = New System.Drawing.Point(112, 137)
        Me.txtscale.Name = "txtscale"
        Me.txtscale.Size = New System.Drawing.Size(121, 20)
        Me.txtscale.TabIndex = 24
        Me.txtscale.Text = "1.0"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 32)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Background Color"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(164, 180)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 32)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Foreground Color"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtsourceimage)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 150)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(211, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 24)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Select Image"
        '
        'txtsourceimage
        '
        Me.txtsourceimage.Enabled = False
        Me.txtsourceimage.Location = New System.Drawing.Point(11, 115)
        Me.txtsourceimage.Name = "txtsourceimage"
        Me.txtsourceimage.Size = New System.Drawing.Size(312, 20)
        Me.txtsourceimage.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Source  image file"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(11, 63)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(140, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Draw Barcode on Image"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(11, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = " Barcode only"
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(328, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(272, 264)
        Me.AxImageViewer1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1000, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtscale)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboerrlevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboversion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AxImageViewer2)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbooutputimage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtbarcodevalue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "QR Barcode Writer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxImageViewer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer


        clrBgColor = Color.White
        clrFgColor = Color.Black

        For i = 1 To 40

            Me.cboversion.Items.Add(i.ToString())
        Next
        Me.cboversion.SelectedIndex = 0

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

        cboerrlevel.Items.Add("Level 1")

        cboerrlevel.Items.Add("Level 2")
        cboerrlevel.Items.Add("Level 3")
        cboerrlevel.Items.Add("Level 4")
        cboerrlevel.SelectedIndex = 0


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strFile As String
        Dim strError As String
        Dim strType As String
        Dim iresult As Integer
        Dim bitmaphandle As Long
        Dim clrtrancolor As Color
        Dim strFilter As String
        Dim strFileNamenoExt As String

        If txtbarcodevalue.Text = "" Then
            MessageBox.Show("Please enter the barcode value")
            Exit Sub
        End If



        strError = AxImageViewer1.BarCodeWriterGetErrorMessage

        If strError <> "" Then
            MessageBox.Show(strError)
            Exit Sub
        End If


        AxImageViewer1.FileName = ""


        If RadioButton1.Checked Then

            strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)

            strFilter = "Image File (*." + Trim(strType) + ")|*." + Trim(strType)

            SaveFileDialog1.Filter = strFilter
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                strFile = SaveFileDialog1.FileName
                strFileNamenoExt = strFile.Substring(0, strFile.Length - 4)

                AxImageViewer1.QRWriterSave(strFileNamenoExt, strType, txtbarcodevalue.Text, cboerrlevel.SelectedIndex, cboversion.SelectedIndex, 1, Color2Uint32(clrFgColor), Color2Uint32(clrBgColor), txtscale.Text)

                AxImageViewer1.FileName = strFileNamenoExt + "." + strType

            End If

        End If

        If RadioButton2.Checked Then

            If txtsourceimage.Text = "" Then
                MessageBox.Show("Please input the source image")
                Exit Sub

            End If

            strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)


            strFilter = "Image File (*." + Trim(strType) + ")|*." + Trim(strType)

            SaveFileDialog1.Filter = strFilter

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                strFile = SaveFileDialog1.FileName
                strFileNamenoExt = strFile.Substring(0, strFile.Length - 4)



            End If

            AxImageViewer2.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.NoSelectionRectMode
            AxImageViewer2.FileName = txtsourceimage.Text

            AxImageViewer2.ShowImage = True ' must set showimage if call DrawImageHBITMAP

            bitmaphandle = AxImageViewer1.QRWriterSaveHBITMAP(txtbarcodevalue.Text, cboerrlevel.SelectedIndex, cboversion.SelectedIndex, 1, Color2Uint32(clrFgColor), Color2Uint32(clrBgColor), txtscale.Text)


            clrtrancolor = Color.FromArgb(255, 0, 0)

            AxImageViewer2.DrawImageHBITMAP(0, 0, bitmaphandle, Color2Uint32(clrtrancolor), 255)

            AxImageViewer2.Save(strFileNamenoExt, strType)

            AxImageViewer1.DeleteBitmapHandle(bitmaphandle)




        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif|PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"





        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then


            txtsourceimage.Text = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub chkdrawbarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub chkfitrect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif|PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"


        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then


            txtsourceimage.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        clrBgColor = Me.ColorDialog1.Color

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        clrFgColor = Me.ColorDialog1.Color

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs) Handles RadioButton2.Click
        Button5.Enabled = True

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As System.EventArgs) Handles RadioButton1.Click
        Button5.Enabled = False

    End Sub

    Private Sub chksave_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
