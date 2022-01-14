Imports Microsoft
Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim iX As Integer
    Dim iY As Integer
    Dim clrHashForeColor As Color
    Dim clrHashBackColor As Color
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
    Friend WithEvents Button17 As System.Windows.Forms.Button
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
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Button11 As System.Windows.Forms.Button
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
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtXDPI As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtYDPI As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbopixelformat As System.Windows.Forms.ComboBox
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtbgr As System.Windows.Forms.TextBox
    Friend WithEvents txtbgg As System.Windows.Forms.TextBox
    Friend WithEvents txtbgb As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.btnselectfile = New System.Windows.Forms.Button
        Me.btn25 = New System.Windows.Forms.Button
        Me.btn33 = New System.Windows.Forms.Button
        Me.btn50 = New System.Windows.Forms.Button
        Me.btn75 = New System.Windows.Forms.Button
        Me.btn100 = New System.Windows.Forms.Button
        Me.btn150 = New System.Windows.Forms.Button
        Me.btn200 = New System.Windows.Forms.Button
        Me.btnFit = New System.Windows.Forms.Button
        Me.btnAspectRatio = New System.Windows.Forms.Button
        Me.btnbgcolor = New System.Windows.Forms.Button
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.Button17 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Button11 = New System.Windows.Forms.Button
        Me.cbooutputimage = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtThumbnailHeight = New System.Windows.Forms.TextBox
        Me.txtThumbnailWidth = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtXDPI = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtYDPI = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Button10 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbopixelformat = New System.Windows.Forms.ComboBox
        Me.Button22 = New System.Windows.Forms.Button
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtbgr = New System.Windows.Forms.TextBox
        Me.txtbgg = New System.Windows.Forms.TextBox
        Me.txtbgb = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnselectfile
        '
        Me.btnselectfile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectfile.Location = New System.Drawing.Point(8, 8)
        Me.btnselectfile.Name = "btnselectfile"
        Me.btnselectfile.Size = New System.Drawing.Size(104, 24)
        Me.btnselectfile.TabIndex = 1
        Me.btnselectfile.Text = "Select File"
        '
        'btn25
        '
        Me.btn25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn25.Location = New System.Drawing.Point(8, 72)
        Me.btn25.Name = "btn25"
        Me.btn25.Size = New System.Drawing.Size(104, 24)
        Me.btn25.TabIndex = 3
        Me.btn25.Text = "25% of Original"
        '
        'btn33
        '
        Me.btn33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn33.Location = New System.Drawing.Point(8, 104)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(104, 24)
        Me.btn33.TabIndex = 4
        Me.btn33.Text = "33% of Original"
        '
        'btn50
        '
        Me.btn50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.Location = New System.Drawing.Point(8, 136)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(104, 24)
        Me.btn50.TabIndex = 5
        Me.btn50.Text = "50% of Original"
        '
        'btn75
        '
        Me.btn75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn75.Location = New System.Drawing.Point(8, 168)
        Me.btn75.Name = "btn75"
        Me.btn75.Size = New System.Drawing.Size(104, 24)
        Me.btn75.TabIndex = 6
        Me.btn75.Text = "75% of Original"
        '
        'btn100
        '
        Me.btn100.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.Location = New System.Drawing.Point(8, 200)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(104, 24)
        Me.btn100.TabIndex = 7
        Me.btn100.Text = "100% of Original"
        '
        'btn150
        '
        Me.btn150.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn150.Location = New System.Drawing.Point(8, 232)
        Me.btn150.Name = "btn150"
        Me.btn150.Size = New System.Drawing.Size(104, 24)
        Me.btn150.TabIndex = 8
        Me.btn150.Text = "150% of Original"
        '
        'btn200
        '
        Me.btn200.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.Location = New System.Drawing.Point(8, 264)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(104, 24)
        Me.btn200.TabIndex = 9
        Me.btn200.Text = "200% of Original"
        '
        'btnFit
        '
        Me.btnFit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFit.Location = New System.Drawing.Point(8, 296)
        Me.btnFit.Name = "btnFit"
        Me.btnFit.Size = New System.Drawing.Size(104, 32)
        Me.btnFit.TabIndex = 10
        Me.btnFit.Text = "Fit to Window    (aspect ratio)"
        '
        'btnAspectRatio
        '
        Me.btnAspectRatio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAspectRatio.Location = New System.Drawing.Point(8, 376)
        Me.btnAspectRatio.Name = "btnAspectRatio"
        Me.btnAspectRatio.Size = New System.Drawing.Size(104, 24)
        Me.btnAspectRatio.TabIndex = 11
        Me.btnAspectRatio.Text = "Zoom to width"
        '
        'btnbgcolor
        '
        Me.btnbgcolor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbgcolor.Location = New System.Drawing.Point(8, 40)
        Me.btnbgcolor.Name = "btnbgcolor"
        Me.btnbgcolor.Size = New System.Drawing.Size(112, 24)
        Me.btnbgcolor.TabIndex = 17
        Me.btnbgcolor.Text = "Background color"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(632, 256)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(32, 20)
        Me.txtWidth.TabIndex = 21
        Me.txtWidth.Text = ""
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(688, 256)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(32, 20)
        Me.txtHeight.TabIndex = 23
        Me.txtHeight.Text = ""
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
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(600, 152)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(120, 24)
        Me.Button11.TabIndex = 54
        Me.Button11.Text = "Save"
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
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(8, 408)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 24)
        Me.Button8.TabIndex = 67
        Me.Button8.Text = "Zoom to height"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(8, 440)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 24)
        Me.Button9.TabIndex = 72
        Me.Button9.Text = "Zoom In"
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(8, 472)
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
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton6)
        Me.GroupBox6.Controls.Add(Me.RadioButton5)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 544)
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
        Me.AxImageViewer1.Location = New System.Drawing.Point(136, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(448, 488)
        Me.AxImageViewer1.TabIndex = 82
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(8, 344)
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
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(152, 568)
        Me.HScrollBar1.Maximum = 360
        Me.HScrollBar1.Minimum = -360
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(424, 24)
        Me.HScrollBar1.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(144, 544)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "-360"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(568, 544)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "360"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(136, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Background Color"
        '
        'txtbgr
        '
        Me.txtbgr.Location = New System.Drawing.Point(256, 520)
        Me.txtbgr.Name = "txtbgr"
        Me.txtbgr.Size = New System.Drawing.Size(32, 20)
        Me.txtbgr.TabIndex = 91
        Me.txtbgr.Text = "0"
        '
        'txtbgg
        '
        Me.txtbgg.Location = New System.Drawing.Point(304, 520)
        Me.txtbgg.Name = "txtbgg"
        Me.txtbgg.Size = New System.Drawing.Size(32, 20)
        Me.txtbgg.TabIndex = 92
        Me.txtbgg.Text = "0"
        '
        'txtbgb
        '
        Me.txtbgb.Location = New System.Drawing.Point(352, 520)
        Me.txtbgb.Name = "txtbgb"
        Me.txtbgb.Size = New System.Drawing.Size(40, 20)
        Me.txtbgb.TabIndex = 93
        Me.txtbgb.Text = "0"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(256, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "R"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(304, 504)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 16)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "G"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(352, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "B"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(592, 568)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Default"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(968, 654)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbgb)
        Me.Controls.Add(Me.txtbgg)
        Me.Controls.Add(Me.txtbgr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.cbopixelformat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.txtYDPI)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtXDPI)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbooutputimage)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWidth)
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
        Me.Controls.Add(Me.btnselectfile)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rotate By Angle"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnselectfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectfile.Click
        Dim strFilter As String

      
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|Mng (*.mng *.jng)|*.mng;*.jng|Raw Image format(*.cr2 *.nef *.crw *.mrw *.raf *.erf *.3fr *.dcr *.raw *.dng *.pef *.x3f *.arw *.sr2 *.mef *.prf)|*.cr2;*.nef;*.crw;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.raw;*.dng;*.pef;*.x3f;*.arw;*.sr2;*.mef;*.prf|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"


      
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AxImageViewer1.FileName = OpenFileDialog1.FileName
            AxImageViewer1.Focus()

            txtWidth.Text = AxImageViewer1.FileWidth
            txtHeight.Text = AxImageViewer1.FileHeight
            txtXDPI.Text = AxImageViewer1.Xdpi
            txtYDPI.Text = AxImageViewer1.Ydpi
        
        End If
    End Sub

    Private Sub btnrotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnprintimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub



    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnloadtif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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



    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.DefaultMode

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AxImageViewer1.View = 11
        AxImageViewer1.Focus()

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.NormalMode
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AxImageViewer1.ZoomIn()

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AxImageViewer1.ZoomOut()
    End Sub

    Private Sub AxImageViewer1_SelectionRectDrawn(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.LeftPanOnly
    End Sub


    Private Sub AxImageViewer1_SelectionRectDrawn_1(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent) Handles AxImageViewer1.SelectionRectDrawn
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

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        AxImageViewer1.ResetDefaultImage(False)
        AxImageViewer1.RotateAt(HScrollBar1.Value, txtbgr.Text, txtbgg.Text, txtbgb.Text)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HScrollBar1.Value = 0
        AxImageViewer1.ResetDefaultImage(False)
        AxImageViewer1.RotateAt(HScrollBar1.Value, txtbgr.Text, txtbgg.Text, txtbgb.Text)
    End Sub
End Class
