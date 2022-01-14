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
    Friend WithEvents btnrotate As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblwidthheight As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotalpage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcurpage As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtelapse As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.btnselectfile = New System.Windows.Forms.Button
        Me.btnrotate = New System.Windows.Forms.Button
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.Button5 = New System.Windows.Forms.Button
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblwidthheight = New System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Button10 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtelapse = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtcurpage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttotalpage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'btnrotate
        '
        Me.btnrotate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrotate.Location = New System.Drawing.Point(8, 40)
        Me.btnrotate.Name = "btnrotate"
        Me.btnrotate.Size = New System.Drawing.Size(104, 24)
        Me.btnrotate.TabIndex = 2
        Me.btnrotate.Text = "Rotate"
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
        Me.btnbgcolor.Location = New System.Drawing.Point(8, 504)
        Me.btnbgcolor.Name = "btnbgcolor"
        Me.btnbgcolor.Size = New System.Drawing.Size(112, 32)
        Me.btnbgcolor.TabIndex = 17
        Me.btnbgcolor.Text = "Background color"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton7)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Location = New System.Drawing.Point(280, 608)
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
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(8, 408)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 24)
        Me.Button8.TabIndex = 67
        Me.Button8.Text = "Zoom to height"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(288, 560)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(280, 24)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Hold down right mouse button for panning"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 584)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 24)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "After Drawn selection Rectangle and hold down shfit key then click left mouse but" & _
        "ton you can move the rectangle"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label10.Location = New System.Drawing.Point(144, 568)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 24)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Selection Rectangle Position"
        '
        'lblwidthheight
        '
        Me.lblwidthheight.Location = New System.Drawing.Point(136, 592)
        Me.lblwidthheight.Name = "lblwidthheight"
        Me.lblwidthheight.Size = New System.Drawing.Size(128, 16)
        Me.lblwidthheight.TabIndex = 71
        Me.lblwidthheight.Text = "0,0 0x0"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button16)
        Me.GroupBox3.Controls.Add(Me.Button15)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 600)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 88)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Make Selection First"
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(16, 48)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(112, 23)
        Me.Button16.TabIndex = 1
        Me.Button16.Text = "Crop to Clipboard"
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(16, 16)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(112, 24)
        Me.Button15.TabIndex = 0
        Me.Button15.Text = "Crop to Image File"
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
        Me.AxImageViewer1.Location = New System.Drawing.Point(128, 72)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(448, 480)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtelapse)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtcurpage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txttotalpage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 72)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'txtelapse
        '
        Me.txtelapse.Location = New System.Drawing.Point(304, 48)
        Me.txtelapse.Name = "txtelapse"
        Me.txtelapse.Size = New System.Drawing.Size(88, 20)
        Me.txtelapse.TabIndex = 7
        Me.txtelapse.Text = "500"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(168, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Elapse (milliseconds)"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Display All Frames"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button1.Location = New System.Drawing.Point(272, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Go to Specific Page"
        '
        'txtcurpage
        '
        Me.txtcurpage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.txtcurpage.Location = New System.Drawing.Point(216, 16)
        Me.txtcurpage.Name = "txtcurpage"
        Me.txtcurpage.Size = New System.Drawing.Size(48, 20)
        Me.txtcurpage.TabIndex = 3
        Me.txtcurpage.Text = "1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Page"
        '
        'txttotalpage
        '
        Me.txttotalpage.Enabled = False
        Me.txttotalpage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.txttotalpage.Location = New System.Drawing.Point(88, 16)
        Me.txttotalpage.Name = "txttotalpage"
        Me.txttotalpage.Size = New System.Drawing.Size(32, 20)
        Me.txttotalpage.TabIndex = 1
        Me.txttotalpage.Text = "1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Page"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(584, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Tags"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(584, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(352, 160)
        Me.ListBox1.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(584, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "SubItems"
        '
        'ListBox2
        '
        Me.ListBox2.Location = New System.Drawing.Point(584, 240)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(352, 160)
        Me.ListBox2.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(592, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Values"
        '
        'ListBox3
        '
        Me.ListBox3.Location = New System.Drawing.Point(584, 432)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(352, 108)
        Me.ListBox3.TabIndex = 91
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(968, 750)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.lblwidthheight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox4)
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
        Me.Text = "DICOM Viewer"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnselectfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectfile.Click
        Dim strFilter As String
        Dim iCount As Integer
        Dim i As Integer
      
        OpenFileDialog1.Filter = "DICOM Images (*.dcm)|*.dcm"


      
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AxImageViewer1.DICOMLoadImage(OpenFileDialog1.FileName)
            txttotalpage.Text = AxImageViewer1.DICOMGetTotalPage

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()

            iCount = AxImageViewer1.DICOMGetTagsCount

            For i = 0 To iCount - 1
                ListBox1.Items.Add(AxImageViewer1.DICOMGetTagsName(i))


            Next

            If ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = 0
            End If

            If txttotalpage.Text > 1 Then

                txtcurpage.Enabled = True
            Else
                txtcurpage.Enabled = False

            End If

            AxImageViewer1.Focus()



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

        strFile = "c:\test"
        strType = "tif"
        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If
        AxImageViewer1.Focus()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        AxImageViewer1.PrintImage(True)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.Copy2Clipboard()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer







    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        iX = AxImageViewer1.GetHorzScrollBarPos
        iY = AxImageViewer1.GetVertScrollBarPos
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.SetScrollBarPos(iX, iY)
        AxImageViewer1.Focus()
    End Sub



    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnloadtif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

   


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.PasteFromClipboard()
    End Sub





    Private Sub cmdtextcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ColorDialog1.ShowDialog() Then
            AxImageViewer1.TextColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.InvertColor()

    End Sub



    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer


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

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxImageViewer1.Rotate(7)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxImageViewer1.DICOMDisplayAllFrame(txtelapse.Text)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim iCount As Integer
        Dim i As Integer
        iCount = Me.AxImageViewer1.DICOMGetTagsSubItemCount(Me.ListBox1.SelectedIndex)

        Me.ListBox2.Items.Clear()
        Me.ListBox3.Items.Clear()

        For i = 0 To iCount - 1

            ListBox2.Items.Add(Me.AxImageViewer1.DICOMGetTagsSubItemName(Me.ListBox1.SelectedIndex, i))

        Next

    End Sub

    Private Sub AxImageViewer1_DICOMPlaying(ByVal sender As Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_DICOMPlayingEvent) Handles AxImageViewer1.DICOMPlaying
        txtcurpage.Text = e.iFrameIndex
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Me.ListBox3.Items.Clear()
        Me.ListBox3.Items.Add(Me.AxImageViewer1.DICOMGetTagsSubItemValue(ListBox1.SelectedIndex, ListBox2.SelectedIndex))
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.AxImageViewer1.DICOMDisplayFrame(txtcurpage.Text)
    End Sub
End Class
