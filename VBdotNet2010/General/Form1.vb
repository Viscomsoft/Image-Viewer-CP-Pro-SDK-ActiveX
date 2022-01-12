Imports Microsoft
Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim iX As Integer
    Dim iY As Integer
    Dim clrHashForeColor As Color
    Dim clrHashBackColor As Color
    Friend WithEvents chkuseadvpdf As System.Windows.Forms.CheckBox
    Friend WithEvents chksavemultipage As System.Windows.Forms.CheckBox
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnselectfile
        '
        Me.btnselectfile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectfile.Location = New System.Drawing.Point(14, 46)
        Me.btnselectfile.Name = "btnselectfile"
        Me.btnselectfile.Size = New System.Drawing.Size(125, 26)
        Me.btnselectfile.TabIndex = 1
        Me.btnselectfile.Text = "Select File"
        '
        'btnrotate
        '
        Me.btnrotate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrotate.Location = New System.Drawing.Point(14, 81)
        Me.btnrotate.Name = "btnrotate"
        Me.btnrotate.Size = New System.Drawing.Size(125, 26)
        Me.btnrotate.TabIndex = 2
        Me.btnrotate.Text = "Rotate"
        '
        'btn25
        '
        Me.btn25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn25.Location = New System.Drawing.Point(14, 115)
        Me.btn25.Name = "btn25"
        Me.btn25.Size = New System.Drawing.Size(125, 26)
        Me.btn25.TabIndex = 3
        Me.btn25.Text = "25% of Original"
        '
        'btn33
        '
        Me.btn33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn33.Location = New System.Drawing.Point(14, 150)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(125, 26)
        Me.btn33.TabIndex = 4
        Me.btn33.Text = "33% of Original"
        '
        'btn50
        '
        Me.btn50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.Location = New System.Drawing.Point(14, 184)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(125, 26)
        Me.btn50.TabIndex = 5
        Me.btn50.Text = "50% of Original"
        '
        'btn75
        '
        Me.btn75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn75.Location = New System.Drawing.Point(14, 219)
        Me.btn75.Name = "btn75"
        Me.btn75.Size = New System.Drawing.Size(125, 25)
        Me.btn75.TabIndex = 6
        Me.btn75.Text = "75% of Original"
        '
        'btn100
        '
        Me.btn100.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.Location = New System.Drawing.Point(14, 253)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(125, 26)
        Me.btn100.TabIndex = 7
        Me.btn100.Text = "100% of Original"
        '
        'btn150
        '
        Me.btn150.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn150.Location = New System.Drawing.Point(14, 288)
        Me.btn150.Name = "btn150"
        Me.btn150.Size = New System.Drawing.Size(125, 25)
        Me.btn150.TabIndex = 8
        Me.btn150.Text = "150% of Original"
        '
        'btn200
        '
        Me.btn200.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.Location = New System.Drawing.Point(14, 322)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(125, 26)
        Me.btn200.TabIndex = 9
        Me.btn200.Text = "200% of Original"
        '
        'btnFit
        '
        Me.btnFit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFit.Location = New System.Drawing.Point(14, 356)
        Me.btnFit.Name = "btnFit"
        Me.btnFit.Size = New System.Drawing.Size(125, 35)
        Me.btnFit.TabIndex = 10
        Me.btnFit.Text = "Fit to Window    (aspect ratio)"
        '
        'btnAspectRatio
        '
        Me.btnAspectRatio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAspectRatio.Location = New System.Drawing.Point(14, 443)
        Me.btnAspectRatio.Name = "btnAspectRatio"
        Me.btnAspectRatio.Size = New System.Drawing.Size(125, 25)
        Me.btnAspectRatio.TabIndex = 11
        Me.btnAspectRatio.Text = "Zoom to width"
        '
        'btnbgcolor
        '
        Me.btnbgcolor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbgcolor.Location = New System.Drawing.Point(979, 26)
        Me.btnbgcolor.Name = "btnbgcolor"
        Me.btnbgcolor.Size = New System.Drawing.Size(154, 26)
        Me.btnbgcolor.TabIndex = 17
        Me.btnbgcolor.Text = "Background color"
        '
        'btnprintimage
        '
        Me.btnprintimage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprintimage.Location = New System.Drawing.Point(979, 60)
        Me.btnprintimage.Name = "btnprintimage"
        Me.btnprintimage.Size = New System.Drawing.Size(154, 26)
        Me.btnprintimage.TabIndex = 18
        Me.btnprintimage.Text = "Print Image"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(758, 276)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(39, 21)
        Me.txtWidth.TabIndex = 21
        Me.txtWidth.Text = "640"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(826, 276)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(38, 21)
        Me.txtHeight.TabIndex = 23
        Me.txtHeight.Text = "480"
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(720, 233)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(144, 25)
        Me.Button17.TabIndex = 24
        Me.Button17.Text = "SaveBySize"
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(979, 138)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(154, 26)
        Me.Button18.TabIndex = 25
        Me.Button18.Text = "Save to Clipboard"
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(979, 172)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(154, 26)
        Me.Button19.TabIndex = 26
        Me.Button19.Text = "Save to PictureBox"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(989, 233)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 103)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(979, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Picture Box"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(758, 551)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 104)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "When the image is larger than display area, you can save the scroll position and " & _
            "restore the position"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(154, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 34)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Restore  Position"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(29, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 34)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Save Position"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chksavemultipage)
        Me.GroupBox2.Controls.Add(Me.txtTifFileName)
        Me.GroupBox2.Controls.Add(Me.lbltotalpage)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.txtTIFPageNo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnloadtif)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 638)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 146)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multi Page Demo"
        '
        'chksavemultipage
        '
        Me.chksavemultipage.AutoSize = True
        Me.chksavemultipage.Checked = True
        Me.chksavemultipage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksavemultipage.Location = New System.Drawing.Point(15, 19)
        Me.chksavemultipage.Name = "chksavemultipage"
        Me.chksavemultipage.Size = New System.Drawing.Size(273, 18)
        Me.chksavemultipage.TabIndex = 7
        Me.chksavemultipage.Text = "Save MultiPage when call Save or SaveBySize"
        Me.chksavemultipage.UseVisualStyleBackColor = True
        '
        'txtTifFileName
        '
        Me.txtTifFileName.Location = New System.Drawing.Point(178, 114)
        Me.txtTifFileName.Name = "txtTifFileName"
        Me.txtTifFileName.Size = New System.Drawing.Size(110, 20)
        Me.txtTifFileName.TabIndex = 6
        '
        'lbltotalpage
        '
        Me.lbltotalpage.Location = New System.Drawing.Point(119, 117)
        Me.lbltotalpage.Name = "lbltotalpage"
        Me.lbltotalpage.Size = New System.Drawing.Size(38, 26)
        Me.lbltotalpage.TabIndex = 5
        Me.lbltotalpage.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 26)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Page No."
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(203, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 26)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "go"
        '
        'txtTIFPageNo
        '
        Me.txtTIFPageNo.Location = New System.Drawing.Point(115, 77)
        Me.txtTIFPageNo.Name = "txtTIFPageNo"
        Me.txtTIFPageNo.Size = New System.Drawing.Size(67, 20)
        Me.txtTIFPageNo.TabIndex = 2
        Me.txtTIFPageNo.Text = "1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(19, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Page No."
        '
        'btnloadtif
        '
        Me.btnloadtif.Location = New System.Drawing.Point(6, 42)
        Me.btnloadtif.Name = "btnloadtif"
        Me.btnloadtif.Size = New System.Drawing.Size(115, 26)
        Me.btnloadtif.TabIndex = 0
        Me.btnloadtif.Text = "Load Multi Page "
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(979, 95)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(154, 26)
        Me.Button7.TabIndex = 51
        Me.Button7.Text = "Paste from Clipboard"
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(720, 164)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(144, 26)
        Me.Button11.TabIndex = 54
        Me.Button11.Text = "Save"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button6.Location = New System.Drawing.Point(983, 435)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 35)
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
        Me.GroupBox4.Location = New System.Drawing.Point(336, 612)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(355, 155)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mouse Track Mode"
        '
        'RadioButton7
        '
        Me.RadioButton7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(19, 121)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(173, 17)
        Me.RadioButton7.TabIndex = 5
        Me.RadioButton7.Text = "(Left Mouse Panning Only)"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(211, 121)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 25)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Clear Selection "
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(19, 95)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Nothing"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(19, 69)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(259, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "(Right Mouse Panning Only)"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(19, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(192, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "(Selection Rectangle + Panning) "
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(19, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(355, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Default (Include Selection Rectangle + Panning + Auto Zoom)"
        '
        'cbooutputimage
        '
        Me.cbooutputimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputimage.Location = New System.Drawing.Point(720, 103)
        Me.cbooutputimage.Name = "cbooutputimage"
        Me.cbooutputimage.Size = New System.Drawing.Size(125, 20)
        Me.cbooutputimage.Sorted = True
        Me.cbooutputimage.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(720, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Save as Image Format"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(720, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "ico file should 16x16 or 32x32"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(720, 276)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 17)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "size"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(806, 276)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 17)
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
        Me.GroupBox5.Location = New System.Drawing.Point(720, 310)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(173, 112)
        Me.GroupBox5.TabIndex = 63
        Me.GroupBox5.TabStop = False
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(14, 78)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(92, 25)
        Me.Button12.TabIndex = 67
        Me.Button12.Text = "back color"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 17)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "x"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "size"
        '
        'txtThumbnailHeight
        '
        Me.txtThumbnailHeight.Location = New System.Drawing.Point(110, 52)
        Me.txtThumbnailHeight.Name = "txtThumbnailHeight"
        Me.txtThumbnailHeight.Size = New System.Drawing.Size(39, 21)
        Me.txtThumbnailHeight.TabIndex = 64
        Me.txtThumbnailHeight.Text = "120"
        '
        'txtThumbnailWidth
        '
        Me.txtThumbnailWidth.Location = New System.Drawing.Point(43, 52)
        Me.txtThumbnailWidth.Name = "txtThumbnailWidth"
        Me.txtThumbnailWidth.Size = New System.Drawing.Size(39, 21)
        Me.txtThumbnailWidth.TabIndex = 63
        Me.txtThumbnailWidth.Text = "160"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(10, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 26)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Make Thumbnail"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(720, 689)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 17)
        Me.Label27.TabIndex = 64
        Me.Label27.Text = "URL"
        '
        'txturl
        '
        Me.txturl.Location = New System.Drawing.Point(768, 689)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(346, 21)
        Me.txturl.TabIndex = 65
        Me.txturl.Text = "http://www.viscomsoft.com/images/imageviewerpro1.gif"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(768, 715)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(106, 35)
        Me.Button13.TabIndex = 66
        Me.Button13.Text = "Load from url"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(14, 477)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(125, 26)
        Me.Button8.TabIndex = 67
        Me.Button8.Text = "Zoom to height"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(346, 560)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(336, 26)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Hold down right mouse button for panning"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label9.Location = New System.Drawing.Point(346, 586)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 26)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "After Drawn selection Rectangle and hold down shfit key then click left mouse but" & _
            "ton you can move the rectangle"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label10.Location = New System.Drawing.Point(173, 569)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 25)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Selection Rectangle Position"
        '
        'lblwidthheight
        '
        Me.lblwidthheight.Location = New System.Drawing.Point(163, 594)
        Me.lblwidthheight.Name = "lblwidthheight"
        Me.lblwidthheight.Size = New System.Drawing.Size(154, 18)
        Me.lblwidthheight.TabIndex = 71
        Me.lblwidthheight.Text = "0,0 0x0"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(14, 512)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(125, 25)
        Me.Button9.TabIndex = 72
        Me.Button9.Text = "Zoom In"
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(14, 546)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(125, 26)
        Me.Button14.TabIndex = 73
        Me.Button14.Text = "Zoom Out"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(720, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "DPI"
        '
        'txtXDPI
        '
        Me.txtXDPI.Location = New System.Drawing.Point(768, 138)
        Me.txtXDPI.Name = "txtXDPI"
        Me.txtXDPI.Size = New System.Drawing.Size(29, 21)
        Me.txtXDPI.TabIndex = 75
        Me.txtXDPI.Text = "96"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(806, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 26)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "X"
        '
        'txtYDPI
        '
        Me.txtYDPI.Location = New System.Drawing.Point(835, 138)
        Me.txtYDPI.Name = "txtYDPI"
        Me.txtYDPI.Size = New System.Drawing.Size(39, 21)
        Me.txtYDPI.TabIndex = 77
        Me.txtYDPI.Text = "96"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button16)
        Me.GroupBox3.Controls.Add(Me.Button15)
        Me.GroupBox3.Location = New System.Drawing.Point(720, 431)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 95)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Make Selection First"
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(19, 52)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(135, 24)
        Me.Button16.TabIndex = 1
        Me.Button16.Text = "Crop to Clipboard"
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(19, 17)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(135, 26)
        Me.Button15.TabIndex = 0
        Me.Button15.Text = "Crop to Image File"
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(979, 353)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(144, 26)
        Me.Button20.TabIndex = 79
        Me.Button20.Text = "Flip Vertical    "
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(979, 388)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(144, 26)
        Me.Button21.TabIndex = 80
        Me.Button21.Text = "Flip Horizontal"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton6)
        Me.GroupBox6.Controls.Add(Me.RadioButton5)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 586)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(144, 43)
        Me.GroupBox6.TabIndex = 81
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "High Quality"
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(77, 17)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton6.TabIndex = 1
        Me.RadioButton6.Text = "Off"
        '
        'RadioButton5
        '
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(10, 17)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton5.TabIndex = 0
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "On"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(160, 35)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(522, 522)
        Me.AxImageViewer1.TabIndex = 82
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(14, 408)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(125, 26)
        Me.Button10.TabIndex = 83
        Me.Button10.Text = "Center Image"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(720, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(288, 17)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Change bpp (It can affect the output file size)"
        '
        'cbopixelformat
        '
        Me.cbopixelformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopixelformat.Location = New System.Drawing.Point(720, 26)
        Me.cbopixelformat.Name = "cbopixelformat"
        Me.cbopixelformat.Size = New System.Drawing.Size(144, 20)
        Me.cbopixelformat.TabIndex = 85
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button22.Location = New System.Drawing.Point(883, 26)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(67, 26)
        Me.Button22.TabIndex = 86
        Me.Button22.Text = "Change"
        '
        'chkuseadvpdf
        '
        Me.chkuseadvpdf.AutoSize = True
        Me.chkuseadvpdf.Location = New System.Drawing.Point(14, 13)
        Me.chkuseadvpdf.Name = "chkuseadvpdf"
        Me.chkuseadvpdf.Size = New System.Drawing.Size(294, 16)
        Me.chkuseadvpdf.TabIndex = 87
        Me.chkuseadvpdf.Text = "Use Advanced PDF Viewer for PDF and XPS files"
        Me.chkuseadvpdf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1146, 827)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnselectfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectfile.Click
        Dim strFilter As String

        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|Open XML Paper Specification (*.xps *.oxps)|*.xps;*.oxps|PhotoShop (*.psd)|*.psd|Mng (*.mng *.jng)|*.mng;*.jng|Raw Image format(*.cr2 *.nef *.crw *.mrw *.raf *.erf *.3fr *.dcr *.raw *.dng *.pef *.x3f *.arw *.sr2 *.mef *.prf)|*.cr2;*.nef;*.crw;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.prf|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AxImageViewer1.FileName = OpenFileDialog1.FileName
            AxImageViewer1.Focus()

            txtWidth.Text = AxImageViewer1.FileWidth
            txtHeight.Text = AxImageViewer1.FileHeight
            txtXDPI.Text = AxImageViewer1.Xdpi
            txtYDPI.Text = AxImageViewer1.Ydpi

        End If
    End Sub

    Private Sub btnrotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrotate.Click
        AxImageViewer1.Rotate90()
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn25.Click
        AxImageViewer1.View = 1
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn33.Click
        AxImageViewer1.View = 2
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn50.Click
        AxImageViewer1.View = 3
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn75.Click
        AxImageViewer1.View = 4
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100.Click
        AxImageViewer1.View = 5
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn150.Click
        AxImageViewer1.View = 6
        AxImageViewer1.Focus()
    End Sub

    Private Sub btn200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200.Click
        AxImageViewer1.View = 7
        AxImageViewer1.Focus()
    End Sub

    Private Sub btnFit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFit.Click
        AxImageViewer1.View = 9
        AxImageViewer1.Focus()
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

        AxImageViewer1.Focus()
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

        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        strFile = "c:\test"
        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)

        iResult = AxImageViewer1.SaveBySize(strFile, strType, txtWidth.Text, txtHeight.Text)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If
        AxImageViewer1.Focus()
    End Sub

    Private Sub btnbgcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbgcolor.Click
        If ColorDialog1.ShowDialog() Then
            AxImageViewer1.SetBackgroundColor(Color2Uint32(ColorDialog1.Color))
        End If

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
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        AxImageViewer1.Copy2Clipboard()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer



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
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxImageViewer1.SetScrollBarPos(iX, iY)
        AxImageViewer1.Focus()
    End Sub



    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        PictureBox1.Image = AxImageViewer1.Copy2PictureBox
    End Sub

    Private Sub btnloadtif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloadtif.Click
        OpenFileDialog1.Filter = "PDF file|*.pdf|TIF File|*.tif|Open XML Paper Specification (*.xps *.oxps)|*.xps;*.oxps||"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtTifFileName.Text = OpenFileDialog1.FileName
            AxImageViewer1.LoadMultiPage(txtTifFileName.Text, 1)
            AxImageViewer1.Focus()

            lbltotalpage.Text = AxImageViewer1.GetTotalPage
            txtTIFPageNo.Text = 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtTifFileName.Text <> "" Then
            AxImageViewer1.LoadMultiPage(txtTifFileName.Text, txtTIFPageNo.Text)
            AxImageViewer1.Focus()
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



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AxImageViewer1.PasteFromClipboard()
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

        AxImageViewer1.IsSaveMultiPage = chksavemultipage.Checked

        strFile = "c:\test"
        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)
        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        If strType = "ICO" Then
            iResult = AxImageViewer1.SaveBySize(strFile, "ico", 32, 32)

        Else
            iResult = AxImageViewer1.Save(strFile, strType)

        End If

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If

        AxImageViewer1.Focus()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.InvertColor()

    End Sub



    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim color1 As Color
        color1 = Color.FromArgb(255, 255, 255)

        AxImageViewer1.AddBorder(5, Color2Uint32(color1))
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

        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        strFile = "c:\test"
        strType = cbooutputimage.Items(cbooutputimage.SelectedIndex)
        iResult = AxImageViewer1.CreateThumbnail("c:\test1", strType, txtThumbnailWidth.Text, txtThumbnailHeight.Text, Color2Uint32(clrThumbnailBackColor))

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If

        AxImageViewer1.Focus()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If ColorDialog1.ShowDialog() Then
            clrThumbnailBackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AxImageViewer1.LoadImageFromURL(txturl.Text, 0)
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AxImageViewer1.View = 11
        AxImageViewer1.Focus()

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.NormalMode
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AxImageViewer1.ZoomIn()

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AxImageViewer1.ZoomOut()
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

        AxImageViewer1.Focus()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        AxImageViewer1.Xdpi = txtXDPI.Text
        AxImageViewer1.Ydpi = txtYDPI.Text

        iResult = AxImageViewer1.Crop2Clipboard()

        If iResult = True Then
            MsgBox("Save Complete")
        Else
            MsgBox("Save Failed")

        End If

        AxImageViewer1.Focus()
    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AxImageViewer1.ClearSelectionRect()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        AxImageViewer1.Rotate(7)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        AxImageViewer1.Rotate(3)
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
        AxImageViewer1.Focus()
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
End Class
