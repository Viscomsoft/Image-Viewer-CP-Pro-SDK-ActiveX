Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command14 As System.Windows.Forms.Button
	Public WithEvents Command25 As System.Windows.Forms.Button
	Public WithEvents Text25 As System.Windows.Forms.TextBox
	Public WithEvents Command24 As System.Windows.Forms.Button
	Public WithEvents Text24 As System.Windows.Forms.TextBox
	Public WithEvents Command23 As System.Windows.Forms.Button
	Public WithEvents cbonoisetype As System.Windows.Forms.ComboBox
	Public WithEvents Command22 As System.Windows.Forms.Button
	Public WithEvents Text23 As System.Windows.Forms.TextBox
	Public WithEvents Text22 As System.Windows.Forms.TextBox
	Public WithEvents Command15 As System.Windows.Forms.Button
	Public WithEvents cbomosaictype As System.Windows.Forms.ComboBox
	Public WithEvents Command21 As System.Windows.Forms.Button
	Public WithEvents Text21 As System.Windows.Forms.TextBox
	Public WithEvents Command20 As System.Windows.Forms.Button
	Public WithEvents Text20 As System.Windows.Forms.TextBox
	Public WithEvents Text19 As System.Windows.Forms.TextBox
	Public WithEvents Text18 As System.Windows.Forms.TextBox
	Public WithEvents Text17 As System.Windows.Forms.TextBox
	Public WithEvents Command19 As System.Windows.Forms.Button
	Public WithEvents cboembossdir As System.Windows.Forms.ComboBox
	Public WithEvents Text16 As System.Windows.Forms.TextBox
	Public WithEvents Command18 As System.Windows.Forms.Button
	Public WithEvents Text15 As System.Windows.Forms.TextBox
	Public WithEvents Command16 As System.Windows.Forms.Button
	Public WithEvents Text13 As System.Windows.Forms.TextBox
    Public WithEvents Command17 As System.Windows.Forms.Button
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Command13 As System.Windows.Forms.Button
	Public WithEvents Command12 As System.Windows.Forms.Button
	Public WithEvents Text11 As System.Windows.Forms.TextBox
	Public WithEvents Command11 As System.Windows.Forms.Button
	Public WithEvents Text10 As System.Windows.Forms.TextBox
	Public WithEvents Command10 As System.Windows.Forms.Button
	Public WithEvents Command9 As System.Windows.Forms.Button
	Public WithEvents Text9 As System.Windows.Forms.TextBox
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Text8 As System.Windows.Forms.TextBox
	Public WithEvents Command7 As System.Windows.Forms.Button
	Public WithEvents Text7 As System.Windows.Forms.TextBox
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Command6 As System.Windows.Forms.Button
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Command5 As System.Windows.Forms.Button

	Public WithEvents Command1 As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Public WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command14 = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.Command25 = New System.Windows.Forms.Button
        Me.Text25 = New System.Windows.Forms.TextBox
        Me.Command24 = New System.Windows.Forms.Button
        Me.Text24 = New System.Windows.Forms.TextBox
        Me.Command23 = New System.Windows.Forms.Button
        Me.cbonoisetype = New System.Windows.Forms.ComboBox
        Me.Command22 = New System.Windows.Forms.Button
        Me.Text23 = New System.Windows.Forms.TextBox
        Me.Text22 = New System.Windows.Forms.TextBox
        Me.Command15 = New System.Windows.Forms.Button
        Me.cbomosaictype = New System.Windows.Forms.ComboBox
        Me.Command21 = New System.Windows.Forms.Button
        Me.Text21 = New System.Windows.Forms.TextBox
        Me.Command20 = New System.Windows.Forms.Button
        Me.Text20 = New System.Windows.Forms.TextBox
        Me.Text19 = New System.Windows.Forms.TextBox
        Me.Text18 = New System.Windows.Forms.TextBox
        Me.Text17 = New System.Windows.Forms.TextBox
        Me.Command19 = New System.Windows.Forms.Button
        Me.cboembossdir = New System.Windows.Forms.ComboBox
        Me.Text16 = New System.Windows.Forms.TextBox
        Me.Command18 = New System.Windows.Forms.Button
        Me.Text15 = New System.Windows.Forms.TextBox
        Me.Command16 = New System.Windows.Forms.Button
        Me.Text13 = New System.Windows.Forms.TextBox
        Me.Command17 = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Command13 = New System.Windows.Forms.Button
        Me.Command12 = New System.Windows.Forms.Button
        Me.Text11 = New System.Windows.Forms.TextBox
        Me.Command11 = New System.Windows.Forms.Button
        Me.Text10 = New System.Windows.Forms.TextBox
        Me.Command10 = New System.Windows.Forms.Button
        Me.Command9 = New System.Windows.Forms.Button
        Me.Text9 = New System.Windows.Forms.TextBox
        Me.Command8 = New System.Windows.Forms.Button
        Me.Text8 = New System.Windows.Forms.TextBox
        Me.Command7 = New System.Windows.Forms.Button
        Me.Text7 = New System.Windows.Forms.TextBox
        Me.Text6 = New System.Windows.Forms.TextBox
        Me.Text5 = New System.Windows.Forms.TextBox
        Me.Command6 = New System.Windows.Forms.Button
        Me.Text4 = New System.Windows.Forms.TextBox
        Me.Command4 = New System.Windows.Forms.Button
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Command3 = New System.Windows.Forms.Button
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Command2 = New System.Windows.Forms.Button
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Command5 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Frame3.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command14
        '
        Me.Command14.BackColor = System.Drawing.SystemColors.Control
        Me.Command14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command14.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command14.Location = New System.Drawing.Point(16, 416)
        Me.Command14.Name = "Command14"
        Me.Command14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command14.Size = New System.Drawing.Size(89, 33)
        Me.Command14.TabIndex = 83
        Me.Command14.Text = "Save "
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Button1)
        Me.Frame3.Controls.Add(Me.TextBox1)
        Me.Frame3.Controls.Add(Me.Label30)
        Me.Frame3.Controls.Add(Me.Command25)
        Me.Frame3.Controls.Add(Me.Text25)
        Me.Frame3.Controls.Add(Me.Command24)
        Me.Frame3.Controls.Add(Me.Text24)
        Me.Frame3.Controls.Add(Me.Command23)
        Me.Frame3.Controls.Add(Me.cbonoisetype)
        Me.Frame3.Controls.Add(Me.Command22)
        Me.Frame3.Controls.Add(Me.Text23)
        Me.Frame3.Controls.Add(Me.Text22)
        Me.Frame3.Controls.Add(Me.Command15)
        Me.Frame3.Controls.Add(Me.cbomosaictype)
        Me.Frame3.Controls.Add(Me.Command21)
        Me.Frame3.Controls.Add(Me.Text21)
        Me.Frame3.Controls.Add(Me.Command20)
        Me.Frame3.Controls.Add(Me.Text20)
        Me.Frame3.Controls.Add(Me.Text19)
        Me.Frame3.Controls.Add(Me.Text18)
        Me.Frame3.Controls.Add(Me.Text17)
        Me.Frame3.Controls.Add(Me.Command19)
        Me.Frame3.Controls.Add(Me.cboembossdir)
        Me.Frame3.Controls.Add(Me.Text16)
        Me.Frame3.Controls.Add(Me.Command18)
        Me.Frame3.Controls.Add(Me.Text15)
        Me.Frame3.Controls.Add(Me.Command16)
        Me.Frame3.Controls.Add(Me.Text13)
        Me.Frame3.Controls.Add(Me.Command17)
        Me.Frame3.Controls.Add(Me.Label29)
        Me.Frame3.Controls.Add(Me.Label28)
        Me.Frame3.Controls.Add(Me.Label27)
        Me.Frame3.Controls.Add(Me.Label16)
        Me.Frame3.Controls.Add(Me.Label15)
        Me.Frame3.Controls.Add(Me.Label26)
        Me.Frame3.Controls.Add(Me.Label25)
        Me.Frame3.Controls.Add(Me.Label24)
        Me.Frame3.Controls.Add(Me.Label23)
        Me.Frame3.Controls.Add(Me.Label22)
        Me.Frame3.Controls.Add(Me.Label21)
        Me.Frame3.Controls.Add(Me.Label20)
        Me.Frame3.Controls.Add(Me.Label19)
        Me.Frame3.Controls.Add(Me.Label17)
        Me.Frame3.Controls.Add(Me.Label18)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(664, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(345, 449)
        Me.Frame3.TabIndex = 40
        Me.Frame3.TabStop = False
        '
        'Command25
        '
        Me.Command25.BackColor = System.Drawing.SystemColors.Control
        Me.Command25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command25.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command25.Location = New System.Drawing.Point(208, 360)
        Me.Command25.Name = "Command25"
        Me.Command25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command25.Size = New System.Drawing.Size(57, 17)
        Me.Command25.TabIndex = 82
        Me.Command25.Text = "Change"
        '
        'Text25
        '
        Me.Text25.AcceptsReturn = True
        Me.Text25.AutoSize = False
        Me.Text25.BackColor = System.Drawing.SystemColors.Window
        Me.Text25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text25.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text25.Location = New System.Drawing.Point(128, 360)
        Me.Text25.MaxLength = 0
        Me.Text25.Name = "Text25"
        Me.Text25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text25.Size = New System.Drawing.Size(41, 19)
        Me.Text25.TabIndex = 81
        Me.Text25.Text = "100"
        '
        'Command24
        '
        Me.Command24.BackColor = System.Drawing.SystemColors.Control
        Me.Command24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command24.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command24.Location = New System.Drawing.Point(208, 328)
        Me.Command24.Name = "Command24"
        Me.Command24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command24.Size = New System.Drawing.Size(57, 17)
        Me.Command24.TabIndex = 79
        Me.Command24.Text = "Change"
        '
        'Text24
        '
        Me.Text24.AcceptsReturn = True
        Me.Text24.AutoSize = False
        Me.Text24.BackColor = System.Drawing.SystemColors.Window
        Me.Text24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text24.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text24.Location = New System.Drawing.Point(128, 328)
        Me.Text24.MaxLength = 0
        Me.Text24.Name = "Text24"
        Me.Text24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text24.Size = New System.Drawing.Size(41, 19)
        Me.Text24.TabIndex = 78
        Me.Text24.Text = "100"
        '
        'Command23
        '
        Me.Command23.BackColor = System.Drawing.SystemColors.Control
        Me.Command23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command23.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command23.Location = New System.Drawing.Point(128, 296)
        Me.Command23.Name = "Command23"
        Me.Command23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command23.Size = New System.Drawing.Size(57, 17)
        Me.Command23.TabIndex = 76
        Me.Command23.Text = "Change"
        '
        'cbonoisetype
        '
        Me.cbonoisetype.BackColor = System.Drawing.SystemColors.Window
        Me.cbonoisetype.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbonoisetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbonoisetype.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbonoisetype.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbonoisetype.Location = New System.Drawing.Point(176, 264)
        Me.cbonoisetype.Name = "cbonoisetype"
        Me.cbonoisetype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbonoisetype.Size = New System.Drawing.Size(97, 22)
        Me.cbonoisetype.TabIndex = 74
        '
        'Command22
        '
        Me.Command22.BackColor = System.Drawing.SystemColors.Control
        Me.Command22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command22.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command22.Location = New System.Drawing.Point(280, 264)
        Me.Command22.Name = "Command22"
        Me.Command22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command22.Size = New System.Drawing.Size(57, 17)
        Me.Command22.TabIndex = 73
        Me.Command22.Text = "Change"
        '
        'Text23
        '
        Me.Text23.AcceptsReturn = True
        Me.Text23.AutoSize = False
        Me.Text23.BackColor = System.Drawing.SystemColors.Window
        Me.Text23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text23.Location = New System.Drawing.Point(128, 264)
        Me.Text23.MaxLength = 0
        Me.Text23.Name = "Text23"
        Me.Text23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text23.Size = New System.Drawing.Size(41, 19)
        Me.Text23.TabIndex = 72
        Me.Text23.Text = "100"
        '
        'Text22
        '
        Me.Text22.AcceptsReturn = True
        Me.Text22.AutoSize = False
        Me.Text22.BackColor = System.Drawing.SystemColors.Window
        Me.Text22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text22.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text22.Location = New System.Drawing.Point(128, 232)
        Me.Text22.MaxLength = 0
        Me.Text22.Name = "Text22"
        Me.Text22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text22.Size = New System.Drawing.Size(41, 19)
        Me.Text22.TabIndex = 70
        Me.Text22.Text = "2"
        '
        'Command15
        '
        Me.Command15.BackColor = System.Drawing.SystemColors.Control
        Me.Command15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command15.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command15.Location = New System.Drawing.Point(280, 232)
        Me.Command15.Name = "Command15"
        Me.Command15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command15.Size = New System.Drawing.Size(57, 17)
        Me.Command15.TabIndex = 69
        Me.Command15.Text = "Change"
        '
        'cbomosaictype
        '
        Me.cbomosaictype.BackColor = System.Drawing.SystemColors.Window
        Me.cbomosaictype.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbomosaictype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomosaictype.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomosaictype.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbomosaictype.Location = New System.Drawing.Point(176, 232)
        Me.cbomosaictype.Name = "cbomosaictype"
        Me.cbomosaictype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbomosaictype.Size = New System.Drawing.Size(73, 22)
        Me.cbomosaictype.TabIndex = 68
        '
        'Command21
        '
        Me.Command21.BackColor = System.Drawing.SystemColors.Control
        Me.Command21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command21.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command21.Location = New System.Drawing.Point(208, 200)
        Me.Command21.Name = "Command21"
        Me.Command21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command21.Size = New System.Drawing.Size(57, 17)
        Me.Command21.TabIndex = 66
        Me.Command21.Text = "Change"
        '
        'Text21
        '
        Me.Text21.AcceptsReturn = True
        Me.Text21.AutoSize = False
        Me.Text21.BackColor = System.Drawing.SystemColors.Window
        Me.Text21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text21.Location = New System.Drawing.Point(128, 192)
        Me.Text21.MaxLength = 0
        Me.Text21.Name = "Text21"
        Me.Text21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text21.Size = New System.Drawing.Size(57, 25)
        Me.Text21.TabIndex = 65
        Me.Text21.Text = "100"
        '
        'Command20
        '
        Me.Command20.BackColor = System.Drawing.SystemColors.Control
        Me.Command20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command20.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command20.Location = New System.Drawing.Point(280, 168)
        Me.Command20.Name = "Command20"
        Me.Command20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command20.Size = New System.Drawing.Size(57, 17)
        Me.Command20.TabIndex = 63
        Me.Command20.Text = "Change"
        '
        'Text20
        '
        Me.Text20.AcceptsReturn = True
        Me.Text20.AutoSize = False
        Me.Text20.BackColor = System.Drawing.SystemColors.Window
        Me.Text20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text20.Location = New System.Drawing.Point(224, 160)
        Me.Text20.MaxLength = 0
        Me.Text20.Name = "Text20"
        Me.Text20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text20.Size = New System.Drawing.Size(25, 25)
        Me.Text20.TabIndex = 62
        Me.Text20.Text = "200"
        '
        'Text19
        '
        Me.Text19.AcceptsReturn = True
        Me.Text19.AutoSize = False
        Me.Text19.BackColor = System.Drawing.SystemColors.Window
        Me.Text19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text19.Location = New System.Drawing.Point(192, 160)
        Me.Text19.MaxLength = 0
        Me.Text19.Name = "Text19"
        Me.Text19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text19.Size = New System.Drawing.Size(25, 25)
        Me.Text19.TabIndex = 60
        Me.Text19.Text = "200"
        '
        'Text18
        '
        Me.Text18.AcceptsReturn = True
        Me.Text18.AutoSize = False
        Me.Text18.BackColor = System.Drawing.SystemColors.Window
        Me.Text18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text18.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text18.Location = New System.Drawing.Point(144, 160)
        Me.Text18.MaxLength = 0
        Me.Text18.Name = "Text18"
        Me.Text18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text18.Size = New System.Drawing.Size(25, 25)
        Me.Text18.TabIndex = 58
        Me.Text18.Text = "100"
        '
        'Text17
        '
        Me.Text17.AcceptsReturn = True
        Me.Text17.AutoSize = False
        Me.Text17.BackColor = System.Drawing.SystemColors.Window
        Me.Text17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text17.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text17.Location = New System.Drawing.Point(96, 160)
        Me.Text17.MaxLength = 0
        Me.Text17.Name = "Text17"
        Me.Text17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text17.Size = New System.Drawing.Size(25, 25)
        Me.Text17.TabIndex = 55
        Me.Text17.Text = "100"
        '
        'Command19
        '
        Me.Command19.BackColor = System.Drawing.SystemColors.Control
        Me.Command19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command19.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command19.Location = New System.Drawing.Point(280, 112)
        Me.Command19.Name = "Command19"
        Me.Command19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command19.Size = New System.Drawing.Size(57, 17)
        Me.Command19.TabIndex = 53
        Me.Command19.Text = "Change"
        '
        'cboembossdir
        '
        Me.cboembossdir.BackColor = System.Drawing.SystemColors.Window
        Me.cboembossdir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboembossdir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboembossdir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboembossdir.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboembossdir.Location = New System.Drawing.Point(176, 112)
        Me.cboembossdir.Name = "cboembossdir"
        Me.cboembossdir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboembossdir.Size = New System.Drawing.Size(81, 22)
        Me.cboembossdir.TabIndex = 52
        '
        'Text16
        '
        Me.Text16.AcceptsReturn = True
        Me.Text16.AutoSize = False
        Me.Text16.BackColor = System.Drawing.SystemColors.Window
        Me.Text16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text16.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text16.Location = New System.Drawing.Point(128, 112)
        Me.Text16.MaxLength = 0
        Me.Text16.Name = "Text16"
        Me.Text16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text16.Size = New System.Drawing.Size(33, 25)
        Me.Text16.TabIndex = 51
        Me.Text16.Text = "3"
        '
        'Command18
        '
        Me.Command18.BackColor = System.Drawing.SystemColors.Control
        Me.Command18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command18.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command18.Location = New System.Drawing.Point(208, 88)
        Me.Command18.Name = "Command18"
        Me.Command18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command18.Size = New System.Drawing.Size(57, 17)
        Me.Command18.TabIndex = 49
        Me.Command18.Text = "Change"
        '
        'Text15
        '
        Me.Text15.AcceptsReturn = True
        Me.Text15.AutoSize = False
        Me.Text15.BackColor = System.Drawing.SystemColors.Window
        Me.Text15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text15.Location = New System.Drawing.Point(128, 80)
        Me.Text15.MaxLength = 0
        Me.Text15.Name = "Text15"
        Me.Text15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text15.Size = New System.Drawing.Size(57, 25)
        Me.Text15.TabIndex = 48
        Me.Text15.Text = "3"
        '
        'Command16
        '
        Me.Command16.BackColor = System.Drawing.SystemColors.Control
        Me.Command16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command16.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command16.Location = New System.Drawing.Point(208, 24)
        Me.Command16.Name = "Command16"
        Me.Command16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command16.Size = New System.Drawing.Size(57, 17)
        Me.Command16.TabIndex = 44
        Me.Command16.Text = "Change"
        '
        'Text13
        '
        Me.Text13.AcceptsReturn = True
        Me.Text13.AutoSize = False
        Me.Text13.BackColor = System.Drawing.SystemColors.Window
        Me.Text13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text13.Location = New System.Drawing.Point(128, 16)
        Me.Text13.MaxLength = 0
        Me.Text13.Name = "Text13"
        Me.Text13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text13.Size = New System.Drawing.Size(57, 25)
        Me.Text13.TabIndex = 43
        Me.Text13.Text = "3"
        '
        'Command17
        '
        Me.Command17.BackColor = System.Drawing.SystemColors.Control
        Me.Command17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command17.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command17.Location = New System.Drawing.Point(208, 56)
        Me.Command17.Name = "Command17"
        Me.Command17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command17.Size = New System.Drawing.Size(57, 17)
        Me.Command17.TabIndex = 41
        Me.Command17.Text = "Change"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(16, 368)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(73, 25)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "Twirl 0-360 "
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(16, 328)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(73, 25)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "SharpenEdge"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(16, 296)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(41, 25)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Sharpen"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(16, 264)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(41, 25)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Noise"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(16, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(41, 25)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Mosaic"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(16, 200)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(105, 25)
        Me.Label26.TabIndex = 64
        Me.Label26.Text = "Monochrome (0-255)"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(224, 144)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(41, 17)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Y"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(192, 144)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(41, 17)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "X"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(144, 144)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(41, 17)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Radius2"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(96, 144)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(41, 17)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Radius1"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(16, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(49, 25)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "FocalBW"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(16, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(57, 25)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Emboss"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(16, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(57, 25)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Diffuse"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(16, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(97, 25)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "AntiNoise (1 -5)"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(16, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(97, 25)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Blur"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Command13)
        Me.Frame1.Controls.Add(Me.Command12)
        Me.Frame1.Controls.Add(Me.Text11)
        Me.Frame1.Controls.Add(Me.Command11)
        Me.Frame1.Controls.Add(Me.Text10)
        Me.Frame1.Controls.Add(Me.Command10)
        Me.Frame1.Controls.Add(Me.Command9)
        Me.Frame1.Controls.Add(Me.Text9)
        Me.Frame1.Controls.Add(Me.Command8)
        Me.Frame1.Controls.Add(Me.Text8)
        Me.Frame1.Controls.Add(Me.Command7)
        Me.Frame1.Controls.Add(Me.Text7)
        Me.Frame1.Controls.Add(Me.Text6)
        Me.Frame1.Controls.Add(Me.Text5)
        Me.Frame1.Controls.Add(Me.Command6)
        Me.Frame1.Controls.Add(Me.Text4)
        Me.Frame1.Controls.Add(Me.Command4)
        Me.Frame1.Controls.Add(Me.Text3)
        Me.Frame1.Controls.Add(Me.Command3)
        Me.Frame1.Controls.Add(Me.Text2)
        Me.Frame1.Controls.Add(Me.Command2)
        Me.Frame1.Controls.Add(Me.Text1)
        Me.Frame1.Controls.Add(Me.Label14)
        Me.Frame1.Controls.Add(Me.Label13)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.Controls.Add(Me.Label11)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(376, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(281, 449)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        '
        'Command13
        '
        Me.Command13.BackColor = System.Drawing.SystemColors.Control
        Me.Command13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command13.Location = New System.Drawing.Point(128, 408)
        Me.Command13.Name = "Command13"
        Me.Command13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command13.Size = New System.Drawing.Size(57, 25)
        Me.Command13.TabIndex = 25
        Me.Command13.Text = "Change"
        '
        'Command12
        '
        Me.Command12.BackColor = System.Drawing.SystemColors.Control
        Me.Command12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command12.Location = New System.Drawing.Point(168, 368)
        Me.Command12.Name = "Command12"
        Me.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command12.Size = New System.Drawing.Size(57, 25)
        Me.Command12.TabIndex = 24
        Me.Command12.Text = "Change"
        '
        'Text11
        '
        Me.Text11.AcceptsReturn = True
        Me.Text11.AutoSize = False
        Me.Text11.BackColor = System.Drawing.SystemColors.Window
        Me.Text11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text11.Location = New System.Drawing.Point(128, 368)
        Me.Text11.MaxLength = 0
        Me.Text11.Name = "Text11"
        Me.Text11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text11.Size = New System.Drawing.Size(33, 25)
        Me.Text11.TabIndex = 23
        Me.Text11.Text = "2"
        '
        'Command11
        '
        Me.Command11.BackColor = System.Drawing.SystemColors.Control
        Me.Command11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command11.Location = New System.Drawing.Point(168, 336)
        Me.Command11.Name = "Command11"
        Me.Command11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command11.Size = New System.Drawing.Size(57, 25)
        Me.Command11.TabIndex = 22
        Me.Command11.Text = "Change"
        '
        'Text10
        '
        Me.Text10.AcceptsReturn = True
        Me.Text10.AutoSize = False
        Me.Text10.BackColor = System.Drawing.SystemColors.Window
        Me.Text10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text10.Location = New System.Drawing.Point(128, 336)
        Me.Text10.MaxLength = 0
        Me.Text10.Name = "Text10"
        Me.Text10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text10.Size = New System.Drawing.Size(33, 25)
        Me.Text10.TabIndex = 21
        Me.Text10.Text = "120"
        '
        'Command10
        '
        Me.Command10.BackColor = System.Drawing.SystemColors.Control
        Me.Command10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command10.Location = New System.Drawing.Point(128, 296)
        Me.Command10.Name = "Command10"
        Me.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command10.Size = New System.Drawing.Size(57, 25)
        Me.Command10.TabIndex = 20
        Me.Command10.Text = "Change"
        '
        'Command9
        '
        Me.Command9.BackColor = System.Drawing.SystemColors.Control
        Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command9.Location = New System.Drawing.Point(168, 248)
        Me.Command9.Name = "Command9"
        Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command9.Size = New System.Drawing.Size(57, 25)
        Me.Command9.TabIndex = 19
        Me.Command9.Text = "Change"
        '
        'Text9
        '
        Me.Text9.AcceptsReturn = True
        Me.Text9.AutoSize = False
        Me.Text9.BackColor = System.Drawing.SystemColors.Window
        Me.Text9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text9.Location = New System.Drawing.Point(128, 248)
        Me.Text9.MaxLength = 0
        Me.Text9.Name = "Text9"
        Me.Text9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text9.Size = New System.Drawing.Size(33, 25)
        Me.Text9.TabIndex = 18
        Me.Text9.Text = "255"
        '
        'Command8
        '
        Me.Command8.BackColor = System.Drawing.SystemColors.Control
        Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command8.Location = New System.Drawing.Point(168, 208)
        Me.Command8.Name = "Command8"
        Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command8.Size = New System.Drawing.Size(57, 25)
        Me.Command8.TabIndex = 17
        Me.Command8.Text = "Change"
        '
        'Text8
        '
        Me.Text8.AcceptsReturn = True
        Me.Text8.AutoSize = False
        Me.Text8.BackColor = System.Drawing.SystemColors.Window
        Me.Text8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text8.Location = New System.Drawing.Point(128, 208)
        Me.Text8.MaxLength = 0
        Me.Text8.Name = "Text8"
        Me.Text8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text8.Size = New System.Drawing.Size(33, 25)
        Me.Text8.TabIndex = 16
        Me.Text8.Text = "255"
        '
        'Command7
        '
        Me.Command7.BackColor = System.Drawing.SystemColors.Control
        Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command7.Location = New System.Drawing.Point(168, 176)
        Me.Command7.Name = "Command7"
        Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command7.Size = New System.Drawing.Size(57, 25)
        Me.Command7.TabIndex = 15
        Me.Command7.Text = "Change"
        '
        'Text7
        '
        Me.Text7.AcceptsReturn = True
        Me.Text7.AutoSize = False
        Me.Text7.BackColor = System.Drawing.SystemColors.Window
        Me.Text7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text7.Location = New System.Drawing.Point(128, 176)
        Me.Text7.MaxLength = 0
        Me.Text7.Name = "Text7"
        Me.Text7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text7.Size = New System.Drawing.Size(33, 25)
        Me.Text7.TabIndex = 14
        Me.Text7.Text = "255"
        '
        'Text6
        '
        Me.Text6.AcceptsReturn = True
        Me.Text6.AutoSize = False
        Me.Text6.BackColor = System.Drawing.SystemColors.Window
        Me.Text6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text6.Location = New System.Drawing.Point(184, 136)
        Me.Text6.MaxLength = 0
        Me.Text6.Name = "Text6"
        Me.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text6.Size = New System.Drawing.Size(25, 25)
        Me.Text6.TabIndex = 13
        Me.Text6.Text = "127"
        '
        'Text5
        '
        Me.Text5.AcceptsReturn = True
        Me.Text5.AutoSize = False
        Me.Text5.BackColor = System.Drawing.SystemColors.Window
        Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text5.Location = New System.Drawing.Point(152, 136)
        Me.Text5.MaxLength = 0
        Me.Text5.Name = "Text5"
        Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text5.Size = New System.Drawing.Size(25, 25)
        Me.Text5.TabIndex = 12
        Me.Text5.Text = "0"
        '
        'Command6
        '
        Me.Command6.BackColor = System.Drawing.SystemColors.Control
        Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command6.Location = New System.Drawing.Point(216, 136)
        Me.Command6.Name = "Command6"
        Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command6.Size = New System.Drawing.Size(49, 25)
        Me.Command6.TabIndex = 11
        Me.Command6.Text = "Change"
        '
        'Text4
        '
        Me.Text4.AcceptsReturn = True
        Me.Text4.AutoSize = False
        Me.Text4.BackColor = System.Drawing.SystemColors.Window
        Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text4.Location = New System.Drawing.Point(120, 136)
        Me.Text4.MaxLength = 0
        Me.Text4.Name = "Text4"
        Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text4.Size = New System.Drawing.Size(25, 25)
        Me.Text4.TabIndex = 10
        Me.Text4.Text = "0"
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(168, 80)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(57, 25)
        Me.Command4.TabIndex = 9
        Me.Command4.Text = "Change"
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.AutoSize = False
        Me.Text3.BackColor = System.Drawing.SystemColors.Window
        Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.Location = New System.Drawing.Point(128, 80)
        Me.Text3.MaxLength = 0
        Me.Text3.Name = "Text3"
        Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text3.Size = New System.Drawing.Size(33, 25)
        Me.Text3.TabIndex = 8
        Me.Text3.Text = "2.0"
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(168, 48)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(57, 25)
        Me.Command3.TabIndex = 7
        Me.Command3.Text = "Change"
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.AutoSize = False
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(128, 48)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(33, 25)
        Me.Text2.TabIndex = 6
        Me.Text2.Text = "200"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(168, 16)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(57, 25)
        Me.Command2.TabIndex = 5
        Me.Command2.Text = "Change"
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.AutoSize = False
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(128, 16)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(33, 25)
        Me.Text1.TabIndex = 4
        Me.Text1.Text = "0"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 416)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(97, 25)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "DeSaturation "
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(104, 25)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Saturation (Default 100)"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(113, 25)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Ligthness (Default is 100)"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(97, 25)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Invert Color"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(97, 25)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Blue (0 - 255)"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(97, 25)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Green (0 - 255)"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Red (0 - 255)"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(184, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(17, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "B"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(152, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(17, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "G"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(120, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "R"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Hue (0 - 255)"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Gamma (Default 1.0)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Contrast (Default 100)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Brightness (-255 - 255)"
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(112, 368)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(153, 33)
        Me.Command5.TabIndex = 2
        Me.Command5.Text = "Restore Default Image"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(16, 368)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(89, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Select Image"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(16, 32)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(336, 320)
        Me.AxImageViewer1.TabIndex = 84
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(16, 408)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(73, 25)
        Me.Label30.TabIndex = 83
        Me.Label30.Text = "Median"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 408)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 18)
        Me.TextBox1.TabIndex = 84
        Me.TextBox1.Text = "3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 16)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Change"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1016, 502)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Command14)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Command1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Image Effects"
        Me.Frame3.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Form1
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Form1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Form1
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As Form1)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"


        AxImageViewer1.HighQuality = True

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AxImageViewer1.FileName = OpenFileDialog1.FileName
            AxImageViewer1.View = 9
        End If

        

    End Sub

    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
        Me.AxImageViewer1.InvertColor()
    End Sub

    Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
        Me.AxImageViewer1.Ligthness(CShort(Text10.Text), CShort(Text10.Text), CShort(Text10.Text))
    End Sub

    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click
        Me.AxImageViewer1.Saturation(CShort(Text11.Text))
    End Sub

    Private Sub Command13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command13.Click
        Me.AxImageViewer1.DeSaturation()
    End Sub

    Private Sub Command14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command14.Click
        Dim a As Object
        a = Me.AxImageViewer1.Save("c:\test", "jpg")

        If a = 1 Then
            MsgBox("Save c:\test.jpg completed")
        Else
            MsgBox("Save fail")
        End If



    End Sub

    Private Sub Command15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command15.Click
        Me.AxImageViewer1.Mosaic(Me.cbomosaictype.SelectedIndex, CShort(Text22.Text))
    End Sub

    Private Sub Command16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command16.Click
        Me.AxImageViewer1.AntiNoise(CShort(Text13.Text))
    End Sub

    Private Sub Command17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command17.Click
        Me.AxImageViewer1.Blur()
    End Sub

    Private Sub Command18_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command18.Click
        Me.AxImageViewer1.Diffuse(CShort(Text15.Text))
    End Sub

    Private Sub Command19_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command19.Click
        Me.AxImageViewer1.Emboss(CShort(Text16.Text), cboembossdir.SelectedIndex)
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.AxImageViewer1.Brightness(CShort(Text1.Text), CShort(Text1.Text), CShort(Text1.Text))
    End Sub

    Private Sub Command20_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command20.Click
        Me.AxImageViewer1.FocalBW(CShort(Text17.Text), CShort(Text18.Text), CShort(Text19.Text), CShort(Text20.Text))
    End Sub

    Private Sub Command21_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command21.Click
        Me.AxImageViewer1.Monochrome(CShort(Text21.Text), System.Convert.ToUInt32(RGB(255, 255, 255)), System.Convert.ToUInt32(RGB(0, 0, 0)))
    End Sub

    Private Sub Command22_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command22.Click
        Me.AxImageViewer1.Noise(CShort(Text23.Text), cbonoisetype.SelectedIndex)
    End Sub

    Private Sub Command23_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command23.Click
        Me.AxImageViewer1.Sharpen()
    End Sub

    Private Sub Command24_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command24.Click
        Me.AxImageViewer1.SharpenEdge(CShort(Text24.Text))
    End Sub

    Private Sub Command25_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command25.Click
        Me.AxImageViewer1.Twirl(CShort(Text25.Text))
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Me.AxImageViewer1.Contrast(CShort(Text2.Text))
    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        Me.AxImageViewer1.Gamma(CDbl(Text3.Text))
    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Me.AxImageViewer1.ResetDefaultImage(False)
        Me.AxImageViewer1.View = 9

    End Sub

    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        Me.AxImageViewer1.Hue(CShort(Text4.Text), CShort(Text5.Text), CShort(Text6.Text))
    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
        Me.AxImageViewer1.Brightness(CShort(Text7.Text), 0, 0)
    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
        Me.AxImageViewer1.Brightness(0, CShort(Text8.Text), 0)
    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
        Me.AxImageViewer1.Brightness(0, 0, CShort(Text9.Text))
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        cboembossdir.Items.Add("North")
        cboembossdir.Items.Add("North-East")
        cboembossdir.Items.Add("East")
        cboembossdir.Items.Add("South-East")
        cboembossdir.Items.Add("South")
        cboembossdir.Items.Add("South-West")
        cboembossdir.Items.Add("West")
        cboembossdir.Items.Add("North-West")
        cboembossdir.SelectedIndex = 0

        cbomosaictype.Items.Add("normal")
        cbomosaictype.Items.Add("soft")
        cbomosaictype.SelectedIndex = 0

        cbonoisetype.Items.Add("grayscale noise")
        cbonoisetype.Items.Add("color noise")
        cbonoisetype.SelectedIndex = 0
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode

    End Sub

    Private Sub axImageViewer1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxImageViewer1.Median(CShort(TextBox1.Text))
    End Sub
End Class