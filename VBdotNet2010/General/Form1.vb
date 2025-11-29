Imports Microsoft
Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim iX As Integer
    Dim iY As Integer
    Dim clrHashForeColor As Color
    Dim clrHashBackColor As Color
    Friend WithEvents chkuseadvpdf As System.Windows.Forms.CheckBox
    Friend WithEvents chksavemultipage As System.Windows.Forms.CheckBox
    Private WithEvents groupBox12 As System.Windows.Forms.GroupBox
    Private WithEvents radioChangePage3 As System.Windows.Forms.RadioButton
    Private WithEvents radioChangePage2 As System.Windows.Forms.RadioButton
    Private WithEvents radioChangePage1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbldeskewangle As System.Windows.Forms.Label
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents cboexporttype As System.Windows.Forms.ComboBox
    Private WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents groupBox13 As System.Windows.Forms.GroupBox
    Private WithEvents cboencryptmode As System.Windows.Forms.ComboBox
    Private WithEvents label21 As System.Windows.Forms.Label
    Private WithEvents btnSavePDFKeepQualityPermission As System.Windows.Forms.Button
    Private WithEvents txtsavepassword As System.Windows.Forms.TextBox
    Private WithEvents label20 As System.Windows.Forms.Label
    Private WithEvents btnSavePDFKeepQualityPassword As System.Windows.Forms.Button
    Private WithEvents chkfastwebview As System.Windows.Forms.CheckBox
    Private WithEvents btnSavePDFKeepQuality As System.Windows.Forms.Button
    Dim clrThumbnailBackColor As Color

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
    Friend WithEvents btnselectfile As System.Windows.Forms.Button
    Friend WithEvents btnrotate As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents btn25 As System.Windows.Forms.Button
    Friend WithEvents btn33 As System.Windows.Forms.Button
    Friend WithEvents btn50 As System.Windows.Forms.Button
    Friend WithEvents btn75 As System.Windows.Forms.Button
    Friend WithEvents btn100 As System.Windows.Forms.Button
    Friend WithEvents btn150 As System.Windows.Forms.Button
    Friend WithEvents btn200 As System.Windows.Forms.Button
    Friend WithEvents btnFit As System.Windows.Forms.Button
    Friend WithEvents btnAspectRatio As System.Windows.Forms.Button
    Friend WithEvents btnbgcolor As System.Windows.Forms.Button
    Friend WithEvents btnprintimage As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnloadtif As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTIFPageNo As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotalpage As System.Windows.Forms.Label
    Friend WithEvents txtTifFileName As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents cbooutputimage As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtThumbnailHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtThumbnailWidth As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents txturl As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblwidthheight As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtXDPI As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtYDPI As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbopixelformat As System.Windows.Forms.ComboBox
    Friend WithEvents Button22 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnselectfile = New System.Windows.Forms.Button()
        Me.btnrotate = New System.Windows.Forms.Button()
        Me.btn25 = New System.Windows.Forms.Button()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn75 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn150 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btnFit = New System.Windows.Forms.Button()
        Me.btnAspectRatio = New System.Windows.Forms.Button()
        Me.btnbgcolor = New System.Windows.Forms.Button()
        Me.btnprintimage = New System.Windows.Forms.Button()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.cboexporttype = New System.Windows.Forms.ComboBox()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.chksavemultipage = New System.Windows.Forms.CheckBox()
        Me.txtTifFileName = New System.Windows.Forms.TextBox()
        Me.lbltotalpage = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtTIFPageNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnloadtif = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cbooutputimage = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtThumbnailHeight = New System.Windows.Forms.TextBox()
        Me.txtThumbnailWidth = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblwidthheight = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtXDPI = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtYDPI = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbopixelformat = New System.Windows.Forms.ComboBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.chkuseadvpdf = New System.Windows.Forms.CheckBox()
        Me.groupBox12 = New System.Windows.Forms.GroupBox()
        Me.radioChangePage3 = New System.Windows.Forms.RadioButton()
        Me.radioChangePage2 = New System.Windows.Forms.RadioButton()
        Me.radioChangePage1 = New System.Windows.Forms.RadioButton()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbldeskewangle = New System.Windows.Forms.Label()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.groupBox13 = New System.Windows.Forms.GroupBox()
        Me.cboencryptmode = New System.Windows.Forms.ComboBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.btnSavePDFKeepQualityPermission = New System.Windows.Forms.Button()
        Me.txtsavepassword = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.btnSavePDFKeepQualityPassword = New System.Windows.Forms.Button()
        Me.chkfastwebview = New System.Windows.Forms.CheckBox()
        Me.btnSavePDFKeepQuality = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox12.SuspendLayout()
        Me.groupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnselectfile
        '
        Me.btnselectfile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectfile.Location = New System.Drawing.Point(17, 32)
        Me.btnselectfile.Name = "btnselectfile"
        Me.btnselectfile.Size = New System.Drawing.Size(104, 25)
        Me.btnselectfile.TabIndex = 1
        Me.btnselectfile.Text = "Select File"
        '
        'btnrotate
        '
        Me.btnrotate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrotate.Location = New System.Drawing.Point(17, 152)
        Me.btnrotate.Name = "btnrotate"
        Me.btnrotate.Size = New System.Drawing.Size(104, 24)
        Me.btnrotate.TabIndex = 2
        Me.btnrotate.Text = "Rotate"
        '
        'btn25
        '
        Me.btn25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn25.Location = New System.Drawing.Point(17, 187)
        Me.btn25.Name = "btn25"
        Me.btn25.Size = New System.Drawing.Size(104, 24)
        Me.btn25.TabIndex = 3
        Me.btn25.Text = "25% of Original"
        '
        'btn33
        '
        Me.btn33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn33.Location = New System.Drawing.Point(17, 219)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(104, 24)
        Me.btn33.TabIndex = 4
        Me.btn33.Text = "33% of Original"
        '
        'btn50
        '
        Me.btn50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.Location = New System.Drawing.Point(17, 251)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(104, 24)
        Me.btn50.TabIndex = 5
        Me.btn50.Text = "50% of Original"
        '
        'btn75
        '
        Me.btn75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn75.Location = New System.Drawing.Point(17, 283)
        Me.btn75.Name = "btn75"
        Me.btn75.Size = New System.Drawing.Size(104, 23)
        Me.btn75.TabIndex = 6
        Me.btn75.Text = "75% of Original"
        '
        'btn100
        '
        Me.btn100.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.Location = New System.Drawing.Point(17, 315)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(104, 24)
        Me.btn100.TabIndex = 7
        Me.btn100.Text = "100% of Original"
        '
        'btn150
        '
        Me.btn150.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn150.Location = New System.Drawing.Point(17, 347)
        Me.btn150.Name = "btn150"
        Me.btn150.Size = New System.Drawing.Size(104, 23)
        Me.btn150.TabIndex = 8
        Me.btn150.Text = "150% of Original"
        '
        'btn200
        '
        Me.btn200.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.Location = New System.Drawing.Point(17, 379)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(104, 24)
        Me.btn200.TabIndex = 9
        Me.btn200.Text = "200% of Original"
        '
        'btnFit
        '
        Me.btnFit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFit.Location = New System.Drawing.Point(17, 408)
        Me.btnFit.Name = "btnFit"
        Me.btnFit.Size = New System.Drawing.Size(104, 32)
        Me.btnFit.TabIndex = 10
        Me.btnFit.Text = "Fit to Window    (aspect ratio)"
        '
        'btnAspectRatio
        '
        Me.btnAspectRatio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAspectRatio.Location = New System.Drawing.Point(17, 488)
        Me.btnAspectRatio.Name = "btnAspectRatio"
        Me.btnAspectRatio.Size = New System.Drawing.Size(104, 24)
        Me.btnAspectRatio.TabIndex = 11
        Me.btnAspectRatio.Text = "Zoom to width"
        '
        'btnbgcolor
        '
        Me.btnbgcolor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbgcolor.Location = New System.Drawing.Point(816, 24)
        Me.btnbgcolor.Name = "btnbgcolor"
        Me.btnbgcolor.Size = New System.Drawing.Size(128, 24)
        Me.btnbgcolor.TabIndex = 17
        Me.btnbgcolor.Text = "Background color"
        '
        'btnprintimage
        '
        Me.btnprintimage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprintimage.Location = New System.Drawing.Point(816, 56)
        Me.btnprintimage.Name = "btnprintimage"
        Me.btnprintimage.Size = New System.Drawing.Size(128, 24)
        Me.btnprintimage.TabIndex = 18
        Me.btnprintimage.Text = "Print Image"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(632, 256)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(32, 20)
        Me.txtWidth.TabIndex = 21
        Me.txtWidth.Text = "640"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(688, 256)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(32, 20)
        Me.txtHeight.TabIndex = 23
        Me.txtHeight.Text = "480"
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(600, 216)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(120, 24)
        Me.Button17.TabIndex = 24
        Me.Button17.Text = "SaveBySize"
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(816, 128)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(128, 24)
        Me.Button18.TabIndex = 25
        Me.Button18.Text = "Save to Clipboard"
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(816, 160)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(128, 24)
        Me.Button19.TabIndex = 26
        Me.Button19.Text = "Save to PictureBox"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(824, 216)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 60)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(816, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Picture Box"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(891, 527)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 104)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "When the image is larger than display area, you can save the scroll position and " & _
            "restore the position"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(88, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 32)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Restore  Position"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Save Position"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.label19)
        Me.GroupBox2.Controls.Add(Me.cboexporttype)
        Me.GroupBox2.Controls.Add(Me.Button25)
        Me.GroupBox2.Controls.Add(Me.chksavemultipage)
        Me.GroupBox2.Controls.Add(Me.txtTifFileName)
        Me.GroupBox2.Controls.Add(Me.lbltotalpage)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.txtTIFPageNo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnloadtif)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(600, 509)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 136)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multi Page Demo"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(136, 98)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(71, 14)
        Me.label19.TabIndex = 44
        Me.label19.Text = "Export Type"
        '
        'cboexporttype
        '
        Me.cboexporttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboexporttype.FormattingEnabled = True
        Me.cboexporttype.Location = New System.Drawing.Point(200, 96)
        Me.cboexporttype.Name = "cboexporttype"
        Me.cboexporttype.Size = New System.Drawing.Size(68, 22)
        Me.cboexporttype.TabIndex = 43
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(157, 68)
        Me.Button25.Margin = New System.Windows.Forms.Padding(4)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(110, 18)
        Me.Button25.TabIndex = 41
        Me.Button25.Text = "Export Text/XML/HTML "
        Me.Button25.UseVisualStyleBackColor = True
        '
        'chksavemultipage
        '
        Me.chksavemultipage.AutoSize = True
        Me.chksavemultipage.Checked = True
        Me.chksavemultipage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksavemultipage.Location = New System.Drawing.Point(12, 18)
        Me.chksavemultipage.Name = "chksavemultipage"
        Me.chksavemultipage.Size = New System.Drawing.Size(273, 18)
        Me.chksavemultipage.TabIndex = 7
        Me.chksavemultipage.Text = "Save MultiPage when call Save or SaveBySize"
        Me.chksavemultipage.UseVisualStyleBackColor = True
        '
        'txtTifFileName
        '
        Me.txtTifFileName.Location = New System.Drawing.Point(106, 42)
        Me.txtTifFileName.Name = "txtTifFileName"
        Me.txtTifFileName.Size = New System.Drawing.Size(159, 20)
        Me.txtTifFileName.TabIndex = 6
        '
        'lbltotalpage
        '
        Me.lbltotalpage.Location = New System.Drawing.Point(99, 109)
        Me.lbltotalpage.Name = "lbltotalpage"
        Me.lbltotalpage.Size = New System.Drawing.Size(32, 24)
        Me.lbltotalpage.TabIndex = 5
        Me.lbltotalpage.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(13, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Page No."
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(108, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "go"
        '
        'txtTIFPageNo
        '
        Me.txtTIFPageNo.Location = New System.Drawing.Point(69, 71)
        Me.txtTIFPageNo.Name = "txtTIFPageNo"
        Me.txtTIFPageNo.Size = New System.Drawing.Size(35, 20)
        Me.txtTIFPageNo.TabIndex = 2
        Me.txtTIFPageNo.Text = "1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Page No."
        '
        'btnloadtif
        '
        Me.btnloadtif.Location = New System.Drawing.Point(5, 39)
        Me.btnloadtif.Name = "btnloadtif"
        Me.btnloadtif.Size = New System.Drawing.Size(96, 24)
        Me.btnloadtif.TabIndex = 0
        Me.btnloadtif.Text = "Load Multi Page "
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(816, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 24)
        Me.Button7.TabIndex = 51
        Me.Button7.Text = "Paste from Clipboard"
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(600, 152)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(120, 24)
        Me.Button11.TabIndex = 54
        Me.Button11.Text = "Save"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button6.Location = New System.Drawing.Point(967, 220)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 33)
        Me.Button6.TabIndex = 56
        Me.Button6.Text = "Add Photo Border"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton7)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Location = New System.Drawing.Point(280, 568)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 144)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mouse Track Mode"
        '
        'RadioButton7
        '
        Me.RadioButton7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(16, 112)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(144, 16)
        Me.RadioButton7.TabIndex = 5
        Me.RadioButton7.Text = "(Left Mouse Panning Only)"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(176, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 24)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Clear Selection "
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(16, 88)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(96, 16)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Nothing"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(16, 64)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(216, 16)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "(Right Mouse Panning Only)"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(160, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "(Selection Rectangle + Panning) "
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(296, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Default (Include Selection Rectangle + Panning + Auto Zoom)"
        '
        'cbooutputimage
        '
        Me.cbooutputimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputimage.Location = New System.Drawing.Point(600, 96)
        Me.cbooutputimage.Name = "cbooutputimage"
        Me.cbooutputimage.Size = New System.Drawing.Size(104, 21)
        Me.cbooutputimage.Sorted = True
        Me.cbooutputimage.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(600, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Save as Image Format"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(600, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "ico file should 16x16 or 32x32"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(600, 256)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(24, 16)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "size"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(672, 256)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(8, 16)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "x"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button12)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txtThumbnailHeight)
        Me.GroupBox5.Controls.Add(Me.txtThumbnailWidth)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Location = New System.Drawing.Point(600, 288)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(144, 104)
        Me.GroupBox5.TabIndex = 63
        Me.GroupBox5.TabStop = False
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(12, 72)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(76, 24)
        Me.Button12.TabIndex = 67
        Me.Button12.Text = "back color"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "x"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "size"
        '
        'txtThumbnailHeight
        '
        Me.txtThumbnailHeight.Location = New System.Drawing.Point(92, 48)
        Me.txtThumbnailHeight.Name = "txtThumbnailHeight"
        Me.txtThumbnailHeight.Size = New System.Drawing.Size(32, 20)
        Me.txtThumbnailHeight.TabIndex = 64
        Me.txtThumbnailHeight.Text = "120"
        '
        'txtThumbnailWidth
        '
        Me.txtThumbnailWidth.Location = New System.Drawing.Point(36, 48)
        Me.txtThumbnailWidth.Name = "txtThumbnailWidth"
        Me.txtThumbnailWidth.Size = New System.Drawing.Size(32, 20)
        Me.txtThumbnailWidth.TabIndex = 63
        Me.txtThumbnailWidth.Text = "160"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(8, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Make Thumbnail"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(616, 655)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 15)
        Me.Label27.TabIndex = 64
        Me.Label27.Text = "URL"
        '
        'txturl
        '
        Me.txturl.Location = New System.Drawing.Point(656, 655)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(288, 20)
        Me.txturl.TabIndex = 65
        Me.txturl.Text = "http://www.viscomsoft.com/images/imageviewerpro1.gif"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(656, 679)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(88, 32)
        Me.Button13.TabIndex = 66
        Me.Button13.Text = "Load from url"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(17, 520)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 24)
        Me.Button8.TabIndex = 67
        Me.Button8.Text = "Zoom to height"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(288, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(280, 24)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Hold down right mouse button for panning"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 544)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 24)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "After Drawn selection Rectangle and hold down shfit key then click left mouse but" & _
            "ton you can move the rectangle"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label10.Location = New System.Drawing.Point(144, 528)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 24)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Selection Rectangle Position"
        '
        'lblwidthheight
        '
        Me.lblwidthheight.Location = New System.Drawing.Point(136, 552)
        Me.lblwidthheight.Name = "lblwidthheight"
        Me.lblwidthheight.Size = New System.Drawing.Size(128, 16)
        Me.lblwidthheight.TabIndex = 71
        Me.lblwidthheight.Text = "0,0 0x0"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(17, 552)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 24)
        Me.Button9.TabIndex = 72
        Me.Button9.Text = "Zoom In"
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(17, 584)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(104, 24)
        Me.Button14.TabIndex = 73
        Me.Button14.Text = "Zoom Out"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(600, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "DPI"
        '
        'txtXDPI
        '
        Me.txtXDPI.Location = New System.Drawing.Point(640, 128)
        Me.txtXDPI.Name = "txtXDPI"
        Me.txtXDPI.Size = New System.Drawing.Size(24, 20)
        Me.txtXDPI.TabIndex = 75
        Me.txtXDPI.Text = "96"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(672, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 24)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "X"
        '
        'txtYDPI
        '
        Me.txtYDPI.Location = New System.Drawing.Point(696, 128)
        Me.txtYDPI.Name = "txtYDPI"
        Me.txtYDPI.Size = New System.Drawing.Size(32, 20)
        Me.txtYDPI.TabIndex = 77
        Me.txtYDPI.Text = "96"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button16)
        Me.GroupBox3.Controls.Add(Me.Button15)
        Me.GroupBox3.Location = New System.Drawing.Point(967, 268)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 88)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Make Selection First"
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(6, 48)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(112, 23)
        Me.Button16.TabIndex = 1
        Me.Button16.Text = "Crop to Clipboard"
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(6, 18)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(112, 24)
        Me.Button15.TabIndex = 0
        Me.Button15.Text = "Crop to Image File"
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(967, 160)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(120, 24)
        Me.Button20.TabIndex = 79
        Me.Button20.Text = "Flip Vertical    "
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(967, 190)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(120, 24)
        Me.Button21.TabIndex = 80
        Me.Button21.Text = "Flip Horizontal"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton6)
        Me.GroupBox6.Controls.Add(Me.RadioButton5)
        Me.GroupBox6.Location = New System.Drawing.Point(280, 723)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox6.TabIndex = 81
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "High Quality"
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(64, 16)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(40, 16)
        Me.RadioButton6.TabIndex = 1
        Me.RadioButton6.Text = "Off"
        '
        'RadioButton5
        '
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(8, 16)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(40, 16)
        Me.RadioButton5.TabIndex = 0
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "On"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(142, 48)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(434, 440)
        Me.AxImageViewer1.TabIndex = 82
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(17, 456)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(104, 24)
        Me.Button10.TabIndex = 83
        Me.Button10.Text = "Center Image"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(600, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(240, 16)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Change bpp (It can affect the output file size)"
        '
        'cbopixelformat
        '
        Me.cbopixelformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopixelformat.Location = New System.Drawing.Point(600, 24)
        Me.cbopixelformat.Name = "cbopixelformat"
        Me.cbopixelformat.Size = New System.Drawing.Size(120, 21)
        Me.cbopixelformat.TabIndex = 85
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button22.Location = New System.Drawing.Point(736, 24)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(56, 24)
        Me.Button22.TabIndex = 86
        Me.Button22.Text = "Change"
        '
        'chkuseadvpdf
        '
        Me.chkuseadvpdf.AutoSize = True
        Me.chkuseadvpdf.Location = New System.Drawing.Point(12, 12)
        Me.chkuseadvpdf.Name = "chkuseadvpdf"
        Me.chkuseadvpdf.Size = New System.Drawing.Size(261, 17)
        Me.chkuseadvpdf.TabIndex = 87
        Me.chkuseadvpdf.Text = "Use Advanced PDF Viewer for PDF and XPS files"
        Me.chkuseadvpdf.UseVisualStyleBackColor = True
        '
        'groupBox12
        '
        Me.groupBox12.Controls.Add(Me.radioChangePage3)
        Me.groupBox12.Controls.Add(Me.radioChangePage2)
        Me.groupBox12.Controls.Add(Me.radioChangePage1)
        Me.groupBox12.Location = New System.Drawing.Point(17, 629)
        Me.groupBox12.Name = "groupBox12"
        Me.groupBox12.Size = New System.Drawing.Size(238, 119)
        Me.groupBox12.TabIndex = 88
        Me.groupBox12.TabStop = False
        Me.groupBox12.Text = "change pages by scrolling mouse wheel "
        '
        'radioChangePage3
        '
        Me.radioChangePage3.AutoSize = True
        Me.radioChangePage3.Location = New System.Drawing.Point(9, 70)
        Me.radioChangePage3.Name = "radioChangePage3"
        Me.radioChangePage3.Size = New System.Drawing.Size(232, 17)
        Me.radioChangePage3.TabIndex = 2
        Me.radioChangePage3.Text = "Right mouse button + scrolling mouse wheel"
        Me.radioChangePage3.UseVisualStyleBackColor = True
        '
        'radioChangePage2
        '
        Me.radioChangePage2.AutoSize = True
        Me.radioChangePage2.Checked = True
        Me.radioChangePage2.Location = New System.Drawing.Point(10, 45)
        Me.radioChangePage2.Name = "radioChangePage2"
        Me.radioChangePage2.Size = New System.Drawing.Size(179, 17)
        Me.radioChangePage2.TabIndex = 1
        Me.radioChangePage2.TabStop = True
        Me.radioChangePage2.Text = " Ctrl Key + scrolling mouse wheel"
        Me.radioChangePage2.UseVisualStyleBackColor = True
        '
        'radioChangePage1
        '
        Me.radioChangePage1.AutoSize = True
        Me.radioChangePage1.Location = New System.Drawing.Point(10, 19)
        Me.radioChangePage1.Name = "radioChangePage1"
        Me.radioChangePage1.Size = New System.Drawing.Size(130, 17)
        Me.radioChangePage1.TabIndex = 0
        Me.radioChangePage1.Text = "Scrolling mouse wheel"
        Me.radioChangePage1.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(17, 72)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(104, 25)
        Me.Button23.TabIndex = 89
        Me.Button23.Text = "Deskew"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Deskew Angle is"
        '
        'lbldeskewangle
        '
        Me.lbldeskewangle.AutoSize = True
        Me.lbldeskewangle.Location = New System.Drawing.Point(89, 103)
        Me.lbldeskewangle.Name = "lbldeskewangle"
        Me.lbldeskewangle.Size = New System.Drawing.Size(13, 13)
        Me.lbldeskewangle.TabIndex = 91
        Me.lbldeskewangle.Text = "0"
        '
        'Button24
        '
        Me.Button24.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Location = New System.Drawing.Point(17, 124)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(104, 25)
        Me.Button24.TabIndex = 92
        Me.Button24.Text = "Auto Boder Remove"
        '
        'groupBox13
        '
        Me.groupBox13.Controls.Add(Me.cboencryptmode)
        Me.groupBox13.Controls.Add(Me.label21)
        Me.groupBox13.Controls.Add(Me.btnSavePDFKeepQualityPermission)
        Me.groupBox13.Controls.Add(Me.txtsavepassword)
        Me.groupBox13.Controls.Add(Me.label20)
        Me.groupBox13.Controls.Add(Me.btnSavePDFKeepQualityPassword)
        Me.groupBox13.Controls.Add(Me.chkfastwebview)
        Me.groupBox13.Controls.Add(Me.btnSavePDFKeepQuality)
        Me.groupBox13.Location = New System.Drawing.Point(757, 295)
        Me.groupBox13.Name = "groupBox13"
        Me.groupBox13.Size = New System.Drawing.Size(187, 193)
        Me.groupBox13.TabIndex = 93
        Me.groupBox13.TabStop = False
        Me.groupBox13.Text = " Keep high Quality, Without losing Quality"
        '
        'cboencryptmode
        '
        Me.cboencryptmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboencryptmode.FormattingEnabled = True
        Me.cboencryptmode.Location = New System.Drawing.Point(99, 131)
        Me.cboencryptmode.Name = "cboencryptmode"
        Me.cboencryptmode.Size = New System.Drawing.Size(81, 21)
        Me.cboencryptmode.TabIndex = 7
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label21.Location = New System.Drawing.Point(16, 134)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(63, 12)
        Me.label21.TabIndex = 6
        Me.label21.Text = "Encrypt Mode"
        '
        'btnSavePDFKeepQualityPermission
        '
        Me.btnSavePDFKeepQualityPermission.Location = New System.Drawing.Point(10, 156)
        Me.btnSavePDFKeepQualityPermission.Name = "btnSavePDFKeepQualityPermission"
        Me.btnSavePDFKeepQualityPermission.Size = New System.Drawing.Size(171, 28)
        Me.btnSavePDFKeepQualityPermission.TabIndex = 5
        Me.btnSavePDFKeepQualityPermission.Text = "Save PDF with Permissions"
        Me.btnSavePDFKeepQualityPermission.UseVisualStyleBackColor = True
        '
        'txtsavepassword
        '
        Me.txtsavepassword.Location = New System.Drawing.Point(76, 98)
        Me.txtsavepassword.Name = "txtsavepassword"
        Me.txtsavepassword.Size = New System.Drawing.Size(58, 20)
        Me.txtsavepassword.TabIndex = 4
        Me.txtsavepassword.Text = "123"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(16, 101)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(52, 13)
        Me.label20.TabIndex = 3
        Me.label20.Text = "password"
        '
        'btnSavePDFKeepQualityPassword
        '
        Me.btnSavePDFKeepQualityPassword.Location = New System.Drawing.Point(10, 65)
        Me.btnSavePDFKeepQualityPassword.Name = "btnSavePDFKeepQualityPassword"
        Me.btnSavePDFKeepQualityPassword.Size = New System.Drawing.Size(170, 28)
        Me.btnSavePDFKeepQualityPassword.TabIndex = 2
        Me.btnSavePDFKeepQualityPassword.Text = "Save PDF with password"
        Me.btnSavePDFKeepQualityPassword.UseVisualStyleBackColor = True
        '
        'chkfastwebview
        '
        Me.chkfastwebview.AutoSize = True
        Me.chkfastwebview.Location = New System.Drawing.Point(89, 36)
        Me.chkfastwebview.Name = "chkfastwebview"
        Me.chkfastwebview.Size = New System.Drawing.Size(91, 17)
        Me.chkfastwebview.TabIndex = 1
        Me.chkfastwebview.Text = "fast web view"
        Me.chkfastwebview.UseVisualStyleBackColor = True
        '
        'btnSavePDFKeepQuality
        '
        Me.btnSavePDFKeepQuality.Location = New System.Drawing.Point(11, 32)
        Me.btnSavePDFKeepQuality.Name = "btnSavePDFKeepQuality"
        Me.btnSavePDFKeepQuality.Size = New System.Drawing.Size(70, 28)
        Me.btnSavePDFKeepQuality.TabIndex = 0
        Me.btnSavePDFKeepQuality.Text = "Save PDF"
        Me.btnSavePDFKeepQuality.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1148, 677)
        Me.Controls.Add(Me.groupBox13)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.lbldeskewangle)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.groupBox12)
        Me.Controls.Add(Me.chkuseadvpdf)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.cbopixelformat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtYDPI)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtXDPI)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.lblwidthheight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbooutputimage)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.btnprintimage)
        Me.Controls.Add(Me.btnbgcolor)
        Me.Controls.Add(Me.btnAspectRatio)
        Me.Controls.Add(Me.btnFit)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn150)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn75)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn25)
        Me.Controls.Add(Me.btnrotate)
        Me.Controls.Add(Me.btnselectfile)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Viewer CP Pro ActiveX"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox12.ResumeLayout(False)
        Me.groupBox12.PerformLayout()
        Me.groupBox13.ResumeLayout(False)
        Me.groupBox13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnselectfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectfile.Click


        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|Open XML Paper Specification (*.xps *.oxps)|*.xps;*.oxps|PhotoShop (*.psd)|*.psd|Mng (*.mng *.jng)|*.mng;*.jng|Raw Image format(*.cr2 *.nef *.crw *.mrw *.raf *.erf *.3fr *.dcr *.raw *.dng *.pef *.x3f *.arw *.sr2 *.mef *.prf)|*.cr2;*.nef;*.crw;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.prf|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AxImageViewer1.FileName = OpenFileDialog1.FileName
            AxImageViewer1.SetControlFocus()

            txtWidth.Text = AxImageViewer1.FileWidth
            txtHeight.Text = AxImageViewer1.FileHeight
            txtXDPI.Text = AxImageViewer1.Xdpi
            txtYDPI.Text = AxImageViewer1.Ydpi

        End If

    End Sub

    Private Sub btnrotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrotate.Click
        AxImageViewer1.Rotate90()
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btn25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn25.Click
        AxImageViewer1.View = 1
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btn33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn33.Click
        AxImageViewer1.View = 2
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btn50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn50.Click
        AxImageViewer1.View = 3
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn75.Click
        AxImageViewer1.View = 4
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btn100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100.Click
        AxImageViewer1.View = 5
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btn150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn150.Click
        AxImageViewer1.View = 6
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btn200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200.Click
        AxImageViewer1.View = 7
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btnFit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFit.Click
        AxImageViewer1.View = 9
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btnAspectRatio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAspectRatio.Click
        AxImageViewer1.View = 10
        AxImageViewer1.Focus()
    End Sub

    Private Sub btnbmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = "bmp"
        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If

        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btnjpg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = "jpg"
        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If
        AxImageViewer1.Focus()
    End Sub

    Private Sub btngif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = "gif"
        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If
        AxImageViewer1.Focus()
    End Sub

    Private Sub btnpng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = "png"
        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If
        AxImageViewer1.Focus()
    End Sub

    Private Sub btntif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        AxImageViewer1.IsSaveMultiPage = chksavemultipage.Checked

        strFile = "c:\test"
        strType = "tif"
        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If
        AxImageViewer1.Focus()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer
        Dim iFindIndex As Integer

        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)

        SaveFileDialog1.Filter = strType + " file (*." + strType + ")|*." + strType + "||"

        SaveFileDialog1.DefaultExt = strType


        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFile = SaveFileDialog1.FileName

            'cut the extension string
            iFindIndex = strFile.IndexOf("." + strType)

            If iFindIndex <> -1 Then
                strFile = strFile.Substring(0, iFindIndex)
            End If

            iResult = AxImageViewer1.SaveBySize(strFile, strType, txtWidth.Text, txtHeight.Text)

            If iResult = 1 Then
                MsgBox("Save " + strFile + "." + strType + " Complete")
            End If
        End If

        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btnbgcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbgcolor.Click
        If ColorDialog1.ShowDialog() Then
            AxImageViewer1.SetBackgroundColor(Color2Uint32(ColorDialog1.Color))
        End If
        AxImageViewer1.SetControlFocus()
    End Sub

    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

    Private Sub btnprintimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintimage.Click
        AxImageViewer1.PrintImage(True)
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        AxImageViewer1.Copy2Clipboard()
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        cboencryptmode.Items.Add("RC4 40 bit")
        cboencryptmode.Items.Add("RC4 128 bit")
        cboencryptmode.Items.Add("AES 128 bit")
        cboencryptmode.Items.Add("AES 256 bit")
        cboencryptmode.SelectedIndex = 0

        cboexporttype.Items.Add("Txt (Unicode)")
        cboexporttype.Items.Add("Xml")
        cboexporttype.Items.Add("Html")
        cboexporttype.SelectedIndex = 0

        cbooutputimage.Items.Add("Bmp")
        cbooutputimage.Items.Add("JPG")
        cbooutputimage.Items.Add("TIF")
        cbooutputimage.Items.Add("PDF")
        cbooutputimage.Items.Add("WBMP")
        cbooutputimage.Items.Add("GIF")
        cbooutputimage.Items.Add("PCX")
        cbooutputimage.Items.Add("TGA")
        cbooutputimage.Items.Add("ICO")
        cbooutputimage.Items.Add("JP2")
        cbooutputimage.Items.Add("JPC")
        cbooutputimage.Items.Add("RAS")
        cbooutputimage.Items.Add("PGX")
        cbooutputimage.Items.Add("PNM")
        cbooutputimage.Items.Add("PNG")
        cbooutputimage.SelectedIndex = 0




        cbopixelformat.Items.Add("Convert to 1bpp")
        cbopixelformat.Items.Add("Convert to 4bpp")
        cbopixelformat.Items.Add("Convert to 8bpp")
        cbopixelformat.Items.Add("Convert to 8bpp Grayscale")
        cbopixelformat.Items.Add("Convert to 16bpp RGB555")
        cbopixelformat.Items.Add("Convert to 16bpp RGB565")
        cbopixelformat.Items.Add("Convert to 24bpp")
        cbopixelformat.Items.Add("Convert to 32bpp")
        cbopixelformat.Items.Add("Convert to 32bpp ARGB")

        cbopixelformat.SelectedIndex = 0

        chkuseadvpdf.Checked = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        iX = AxImageViewer1.GetHorzScrollBarPos
        iY = AxImageViewer1.GetVertScrollBarPos
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxImageViewer1.SetScrollBarPos(iX, iY)
        AxImageViewer1.SetControlFocus()
    End Sub



    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        PictureBox1.Image = AxImageViewer1.Copy2PictureBox
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub btnloadtif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloadtif.Click
        OpenFileDialog1.Filter = "PDF file|*.pdf|TIF File|*.tif|Open XML Paper Specification (*.xps *.oxps)|*.xps;*.oxps||"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtTifFileName.Text = OpenFileDialog1.FileName

            AxImageViewer1.LoadMultiPage(txtTifFileName.Text, 1)
            AxImageViewer1.SetControlFocus()

            lbltotalpage.Text = AxImageViewer1.GetTotalPage
            txtTIFPageNo.Text = 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtTifFileName.Text <> "" Then
            AxImageViewer1.LoadMultiPage(txtTifFileName.Text, txtTIFPageNo.Text)
            AxImageViewer1.SetControlFocus()
        End If


    End Sub

    Private Sub txtleft_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txttop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtleft_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txttop_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub chkselrect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AxImageViewer1.PasteFromClipboard()
        AxImageViewer1.SetControlFocus()
    End Sub





    Private Sub cbofontsize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub



    Private Sub chkshowtext_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmdtextcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ColorDialog1.ShowDialog() Then
            AxImageViewer1.TextColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer
        Dim iFindIndex As Integer

        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)


        SaveFileDialog1.Filter = strType + " file (*." + strType + ")|*." + strType + "||"

        SaveFileDialog1.DefaultExt = strType


        AxImageViewer1.IsSaveMultiPage = chksavemultipage.Checked

           AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            strFile = SaveFileDialog1.FileName

            'cut the extension string
            iFindIndex = strFile.IndexOf("." + strType)

            If iFindIndex <> -1 Then
                strFile = strFile.Substring(0, iFindIndex)
            End If

            If strType = "ICO" Then
                iResult = AxImageViewer1.SaveBySize(strFile, "ico", 32, 32)

            Else
                iResult = AxImageViewer1.Save(strFile, strType)

            End If

            If iResult = 1 Then
                MsgBox("Save " + strFile + "." + strType + " Complete")
            End If
        End If

        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.InvertColor()

    End Sub



    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim color1 As Color
        color1 = Color.FromArgb(255, 255, 255)

        AxImageViewer1.AddBorder(5, Color2Uint32(color1))
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.DefaultMode

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.NoSelectionRectMode

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer
        Dim iFindIndex As Integer

        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)

        SaveFileDialog1.Filter = strType + " file (*." + strType + ")|*." + strType + "||"

        SaveFileDialog1.DefaultExt = strType

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFile = SaveFileDialog1.FileName

            'cut the extension string
            iFindIndex = strFile.IndexOf("." + strType)

            If iFindIndex <> -1 Then
                strFile = strFile.Substring(0, iFindIndex)
            End If


        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)
            iResult = AxImageViewer1.CreateThumbnail(strFile, strType, txtThumbnailWidth.Text, txtThumbnailHeight.Text, Color2Uint32(clrThumbnailBackColor))

            If iResult = 1 Then
                MsgBox("Save " + strFile + "." + strType + " Complete")
            End If

        End If


        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If ColorDialog1.ShowDialog() Then
            clrThumbnailBackColor = ColorDialog1.Color
        End If
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AxImageViewer1.LoadImageFromURL(txturl.Text, 0)
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AxImageViewer1.View = 11
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.NormalMode
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AxImageViewer1.ZoomIn()
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AxImageViewer1.ZoomOut()
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub AxImageViewer1_SelectionRectDrawn(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent)
        lblwidthheight.Text = CStr(e.iLeft) + " " + CStr(e.iTop) + " " + CStr(e.iWidth) + " x " + CStr(e.iHeight)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)
        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text


        iResult = AxImageViewer1.Crop2ImageFile(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If

        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click

        Dim iResult As Integer

        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        iResult = AxImageViewer1.Crop2Clipboard()

        If iResult = True Then
            MsgBox("Save Complete")
        Else
            MsgBox("Save Failed")

        End If

        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AxImageViewer1.ClearSelectionRect()
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        AxImageViewer1.Rotate(7)
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        AxImageViewer1.Rotate(3)
        AxImageViewer1.SetControlFocus()
    End Sub


    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub RadioButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.Click
        AxImageViewer1.HighQuality = True
    End Sub

    Private Sub RadioButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.Click
        AxImageViewer1.HighQuality = False
    End Sub


    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.LeftPanOnly

    End Sub


    Private Sub AxImageViewer1_SelectionRectDrawn_1(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent) Handles AxImageViewer1.SelectionRectDrawn
        lblwidthheight.Text = CStr(e.iLeft) + " " + CStr(e.iTop) + " " + CStr(e.iWidth) + " x " + CStr(e.iHeight)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        AxImageViewer1.View = 12
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Select Case cbopixelformat.SelectedIndex

            Case 0
                Me.AxImageViewer1.ConvertTo1bpp()
            Case 1
                Me.AxImageViewer1.ConvertTo4bpp()
            Case 2
                Me.AxImageViewer1.ConvertTo8bpp()
            Case 3
                Me.AxImageViewer1.ConvertTo8bppGrayScale()
            Case 4
                Me.AxImageViewer1.ConvertTo16bppRGB555()
            Case 5
                Me.AxImageViewer1.ConvertTo16bppRGB565()
            Case 6
                Me.AxImageViewer1.ConvertTo24bpp()
            Case 7
                Me.AxImageViewer1.ConvertTo32bpp()
            Case 8
                Me.AxImageViewer1.ConvertTo32bppARGB()
        End Select
    End Sub

    Private Sub chkuseadvpdf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkuseadvpdf.CheckedChanged

        If chkuseadvpdf.Checked Then
            Me.AxImageViewer1.PDFUseAdvancedViewer = True
        Else
            Me.AxImageViewer1.PDFUseAdvancedViewer = False

        End If
    End Sub

    Private Sub RefreshPageNo()
        txtTIFPageNo.Text = AxImageViewer1.GetCurrentPage().ToString()
    End Sub
    Private Sub AxImageViewer1_OnMouseWheel(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_OnMouseWheelEvent) Handles AxImageViewer1.OnMouseWheel
        If (radioChangePage1.Checked) Then

            ChangePage(e.iDelta)
            RefreshPageNo()


        ElseIf radioChangePage2.Checked Then

            If (e.bControlDown) Then


                ChangePage(e.iDelta)
                RefreshPageNo()
            End If

        ElseIf (radioChangePage3.Checked) Then

            If (e.bRButtonDown) Then

                ChangePage(e.iDelta)
                RefreshPageNo()

            End If
        End If
        '
    End Sub

    Private Sub ChangePage(ByVal iDelta As Double)

        Dim iCurrentPage As Integer

        If iDelta > 0 Then  ' wheel up

            iCurrentPage = AxImageViewer1.GetCurrentPage()
            iCurrentPage = iCurrentPage - 1

            If iCurrentPage <= 0 Then
                iCurrentPage = 1
            End If

            AxImageViewer1.LoadMultiPage(txtTifFileName.Text, iCurrentPage)


        Else
            iCurrentPage = AxImageViewer1.GetCurrentPage()
            iCurrentPage = iCurrentPage + 1

            If (iCurrentPage > AxImageViewer1.GetTotalPage()) Then
                iCurrentPage = AxImageViewer1.GetTotalPage()
            End If
            AxImageViewer1.LoadMultiPage(txtTifFileName.Text, iCurrentPage)
        End If


    End Sub


    Private Sub radioChangePage1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioChangePage1.CheckedChanged
        If AxImageViewer1.IsHandleCreated Then
            AxImageViewer1.SetControlFocus()
        End If

    End Sub

    Private Sub radioChangePage2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioChangePage2.CheckedChanged
        If AxImageViewer1.IsHandleCreated Then
            AxImageViewer1.SetControlFocus()
        End If
    End Sub

    Private Sub radioChangePage3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioChangePage3.CheckedChanged
        If AxImageViewer1.IsHandleCreated Then
            AxImageViewer1.SetControlFocus()
        End If
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim iAngle As Double
        iAngle = AxImageViewer1.DeSkew()
        lbldeskewangle.Text = iAngle.ToString()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        AxImageViewer1.AutoBorderRemove()
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click

        If cboexporttype.SelectedIndex = 0 Then

            SaveFileDialog1.Filter = "Text file (*.txt)|*.txt||"
            SaveFileDialog1.DefaultExt = "txt"

        ElseIf cboexporttype.SelectedIndex = 1 Then

            SaveFileDialog1.Filter = "XML file (*.xml)|*.xml||"
            SaveFileDialog1.DefaultExt = "xml"


        ElseIf cboexporttype.SelectedIndex = 2 Then

            SaveFileDialog1.Filter = "Html file (*.html)|*.html||"
            SaveFileDialog1.DefaultExt = "html"

        End If

        Dim bResult As Boolean = False

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            bResult = AxImageViewer1.PDFExportText(SaveFileDialog1.FileName, txtTIFPageNo.Text, cboexporttype.SelectedIndex)

            If bResult Then
                MessageBox.Show("Export text completed")

            End If
        End If


    End Sub

    Private Sub btnSavePDFKeepQuality_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePDFKeepQuality.Click

        If AxImageViewer1.IsPDF <> True Then
            MessageBox.Show("Please input PDF file")
            Exit Sub
        End If

        Dim bResult As Boolean
        SaveFileDialog1.Filter = "PDF file (*.pdf)|*.pdf||"
        SaveFileDialog1.DefaultExt = "pdf"

        bResult = False

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            bResult = AxImageViewer1.SavePDF(SaveFileDialog1.FileName, chkfastwebview.Checked)

            If bResult = True Then
                MessageBox.Show("Save PDF Completed")

            End If
        End If

    End Sub

    Private Sub btnSavePDFKeepQualityPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePDFKeepQualityPassword.Click
        If AxImageViewer1.IsPDF <> True Then
            MessageBox.Show("Please input PDF file")
            Exit Sub
        End If

        Dim bResult As Boolean
        SaveFileDialog1.Filter = "PDF file (*.pdf)|*.pdf||"
        SaveFileDialog1.DefaultExt = "pdf"

        bResult = False
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            bResult = AxImageViewer1.SavePDFWithPassword(SaveFileDialog1.FileName, chkfastwebview.Checked, cboencryptmode.SelectedIndex, txtsavepassword.Text, txtsavepassword.Text)

            If bResult = True Then
                MessageBox.Show("Save PDF Completed")
            End If
        End If

    End Sub

    Private Sub btnSavePDFKeepQualityPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePDFKeepQualityPermission.Click
        If AxImageViewer1.IsPDF <> True Then
            MessageBox.Show("Please input PDF file")
            Exit Sub
        End If

        Dim bResult As Boolean
        SaveFileDialog1.Filter = "PDF file (*.pdf)|*.pdf||"
        SaveFileDialog1.DefaultExt = "pdf"

        bResult = False
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            'set print, HQ print , modify the PDF permissions to false
            bResult = AxImageViewer1.SavePDFWithPermissions(SaveFileDialog1.FileName, chkfastwebview.Checked, cboencryptmode.SelectedIndex, False, False, False, True, True, True, False)

            If (bResult) Then
                MessageBox.Show("Save PDF Completed")

            End If
        End If


    End Sub

    Private Sub cbooutputimage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbooutputimage.SelectedIndexChanged

    End Sub
End Class
