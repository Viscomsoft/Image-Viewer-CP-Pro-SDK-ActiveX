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
	Public WithEvents ImageViewer1 As AxSCRIBBLELib.AxImageViewer
	Public WithEvents Command9 As System.Windows.Forms.Button
	Public WithEvents txtimagefile As System.Windows.Forms.TextBox
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cboExportType As System.Windows.Forms.ComboBox
	Public WithEvents Command6 As System.Windows.Forms.Button
	Public WithEvents txtPageNo As System.Windows.Forms.TextBox
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents txtSourceFile As System.Windows.Forms.TextBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents OptCITT3 As System.Windows.Forms.RadioButton
	Public WithEvents OptNone As System.Windows.Forms.RadioButton
	Public WithEvents OptLZW As System.Windows.Forms.RadioButton
	Public WithEvents OptCITT4 As System.Windows.Forms.RadioButton
	Public WithEvents OptRLE As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox

	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents List1 As System.Windows.Forms.ListBox

	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.Command9 = New System.Windows.Forms.Button
        Me.txtimagefile = New System.Windows.Forms.TextBox
        Me.Command8 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cboExportType = New System.Windows.Forms.ComboBox
        Me.Command6 = New System.Windows.Forms.Button
        Me.txtPageNo = New System.Windows.Forms.TextBox
        Me.Command5 = New System.Windows.Forms.Button
        Me.txtSourceFile = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Command4 = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.OptCITT3 = New System.Windows.Forms.RadioButton
        Me.OptNone = New System.Windows.Forms.RadioButton
        Me.OptLZW = New System.Windows.Forms.RadioButton
        Me.OptCITT4 = New System.Windows.Forms.RadioButton
        Me.OptRLE = New System.Windows.Forms.RadioButton
        Me.Command3 = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.List1 = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Command9)
        Me.Frame3.Controls.Add(Me.txtimagefile)
        Me.Frame3.Controls.Add(Me.Command8)
        Me.Frame3.Controls.Add(Me.Label7)
        Me.Frame3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(16, 416)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(481, 97)
        Me.Frame3.TabIndex = 22
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Convert Image to Single/Multipage PDF file"
        '
        'Command9
        '
        Me.Command9.BackColor = System.Drawing.SystemColors.Control
        Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command9.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command9.Location = New System.Drawing.Point(104, 56)
        Me.Command9.Name = "Command9"
        Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command9.Size = New System.Drawing.Size(105, 25)
        Me.Command9.TabIndex = 26
        Me.Command9.Text = "Convert to PDF"
        '
        'txtimagefile
        '
        Me.txtimagefile.AcceptsReturn = True
        Me.txtimagefile.AutoSize = False
        Me.txtimagefile.BackColor = System.Drawing.SystemColors.Window
        Me.txtimagefile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtimagefile.Enabled = False
        Me.txtimagefile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimagefile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtimagefile.Location = New System.Drawing.Point(104, 24)
        Me.txtimagefile.MaxLength = 0
        Me.txtimagefile.Name = "txtimagefile"
        Me.txtimagefile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtimagefile.Size = New System.Drawing.Size(265, 19)
        Me.txtimagefile.TabIndex = 24
        Me.txtimagefile.Text = ""
        '
        'Command8
        '
        Me.Command8.BackColor = System.Drawing.SystemColors.Control
        Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command8.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command8.Location = New System.Drawing.Point(384, 24)
        Me.Command8.Name = "Command8"
        Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command8.Size = New System.Drawing.Size(81, 17)
        Me.Command8.TabIndex = 23
        Me.Command8.Text = "Select File"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Image File"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cboExportType)
        Me.Frame2.Controls.Add(Me.Command6)
        Me.Frame2.Controls.Add(Me.txtPageNo)
        Me.Frame2.Controls.Add(Me.Command5)
        Me.Frame2.Controls.Add(Me.txtSourceFile)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(16, 280)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(481, 129)
        Me.Frame2.TabIndex = 13
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Export Page"
        '
        'cboExportType
        '
        Me.cboExportType.BackColor = System.Drawing.SystemColors.Window
        Me.cboExportType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExportType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExportType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboExportType.Location = New System.Drawing.Point(104, 56)
        Me.cboExportType.Name = "cboExportType"
        Me.cboExportType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboExportType.Size = New System.Drawing.Size(129, 22)
        Me.cboExportType.TabIndex = 21
        '
        'Command6
        '
        Me.Command6.BackColor = System.Drawing.SystemColors.Control
        Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command6.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command6.Location = New System.Drawing.Point(168, 88)
        Me.Command6.Name = "Command6"
        Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command6.Size = New System.Drawing.Size(105, 25)
        Me.Command6.TabIndex = 19
        Me.Command6.Text = "Export"
        '
        'txtPageNo
        '
        Me.txtPageNo.AcceptsReturn = True
        Me.txtPageNo.AutoSize = False
        Me.txtPageNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPageNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPageNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPageNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPageNo.Location = New System.Drawing.Point(104, 88)
        Me.txtPageNo.MaxLength = 0
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPageNo.Size = New System.Drawing.Size(41, 19)
        Me.txtPageNo.TabIndex = 18
        Me.txtPageNo.Text = "1"
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(384, 24)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(81, 17)
        Me.Command5.TabIndex = 16
        Me.Command5.Text = "Select File"
        '
        'txtSourceFile
        '
        Me.txtSourceFile.AcceptsReturn = True
        Me.txtSourceFile.AutoSize = False
        Me.txtSourceFile.BackColor = System.Drawing.SystemColors.Window
        Me.txtSourceFile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSourceFile.Enabled = False
        Me.txtSourceFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSourceFile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSourceFile.Location = New System.Drawing.Point(104, 24)
        Me.txtSourceFile.MaxLength = 0
        Me.txtSourceFile.Name = "txtSourceFile"
        Me.txtSourceFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSourceFile.Size = New System.Drawing.Size(265, 19)
        Me.txtSourceFile.TabIndex = 15
        Me.txtSourceFile.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Export Type"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Page No"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "TIF File Name"
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(328, 224)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(73, 25)
        Me.Command4.TabIndex = 12
        Me.Command4.Text = "Delete All"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.OptCITT3)
        Me.Frame1.Controls.Add(Me.OptNone)
        Me.Frame1.Controls.Add(Me.OptLZW)
        Me.Frame1.Controls.Add(Me.OptCITT4)
        Me.Frame1.Controls.Add(Me.OptRLE)
        Me.Frame1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(369, 57)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "TIF Compression "
        '
        'OptCITT3
        '
        Me.OptCITT3.BackColor = System.Drawing.SystemColors.Control
        Me.OptCITT3.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptCITT3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCITT3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptCITT3.Location = New System.Drawing.Point(72, 24)
        Me.OptCITT3.Name = "OptCITT3"
        Me.OptCITT3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptCITT3.Size = New System.Drawing.Size(57, 17)
        Me.OptCITT3.TabIndex = 2
        Me.OptCITT3.TabStop = True
        Me.OptCITT3.Text = "CITT3"
        '
        'OptNone
        '
        Me.OptNone.BackColor = System.Drawing.SystemColors.Control
        Me.OptNone.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptNone.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNone.Location = New System.Drawing.Point(296, 24)
        Me.OptNone.Name = "OptNone"
        Me.OptNone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptNone.Size = New System.Drawing.Size(65, 17)
        Me.OptNone.TabIndex = 5
        Me.OptNone.TabStop = True
        Me.OptNone.Text = "None"
        '
        'OptLZW
        '
        Me.OptLZW.BackColor = System.Drawing.SystemColors.Control
        Me.OptLZW.Checked = True
        Me.OptLZW.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptLZW.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLZW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptLZW.Location = New System.Drawing.Point(16, 24)
        Me.OptLZW.Name = "OptLZW"
        Me.OptLZW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptLZW.Size = New System.Drawing.Size(49, 17)
        Me.OptLZW.TabIndex = 1
        Me.OptLZW.TabStop = True
        Me.OptLZW.Text = "LZW"
        '
        'OptCITT4
        '
        Me.OptCITT4.BackColor = System.Drawing.SystemColors.Control
        Me.OptCITT4.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptCITT4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCITT4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptCITT4.Location = New System.Drawing.Point(144, 24)
        Me.OptCITT4.Name = "OptCITT4"
        Me.OptCITT4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptCITT4.Size = New System.Drawing.Size(57, 17)
        Me.OptCITT4.TabIndex = 3
        Me.OptCITT4.TabStop = True
        Me.OptCITT4.Text = "CITT4"
        '
        'OptRLE
        '
        Me.OptRLE.BackColor = System.Drawing.SystemColors.Control
        Me.OptRLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptRLE.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptRLE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptRLE.Location = New System.Drawing.Point(208, 24)
        Me.OptRLE.Name = "OptRLE"
        Me.OptRLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptRLE.Size = New System.Drawing.Size(64, 17)
        Me.OptRLE.TabIndex = 4
        Me.OptRLE.TabStop = True
        Me.OptRLE.Text = "Packbits"
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(328, 184)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(73, 25)
        Me.Command3.TabIndex = 9
        Me.Command3.Text = "Create TIF"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(328, 144)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(73, 25)
        Me.Command2.TabIndex = 8
        Me.Command2.Text = "Delete file"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(328, 104)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(73, 25)
        Me.Command1.TabIndex = 7
        Me.Command1.Text = "Add file"
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 12
        Me.List1.Location = New System.Drawing.Point(16, 104)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(289, 136)
        Me.List1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(273, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "The following files will create multi page TIF"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(416, 152)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(72, 56)
        Me.AxImageViewer1.TabIndex = 23
        Me.AxImageViewer1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(509, 539)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIF Sample"
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
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
				m_vb6FormDefInstance = New Form1()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"



        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.List1.Items.Add(OpenFileDialog1.FileName)

        End If

     
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		
		If List1.SelectedIndex <> -1 Then
			List1.Items.RemoveAt(List1.SelectedIndex)
		End If
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Dim result As Object
		Dim i As Object
		
		
        Me.AxImageViewer1.RemoveAllTIF()

        For i = 0 To List1.Items.Count - 1
            AxImageViewer1.AddTIF(List1.Items(i))
        Next

        result = AxImageViewer1.SaveTIF("c:\test.tif")

        If result Then
            MsgBox("Save c:\test.tif completed")
        End If


    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click

        List1.Items.Clear()
        AxImageViewer1.RemoveAllTIF()

    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        OpenFileDialog1.Filter = "TIF (*.tif)|*.tif||"



        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtSourceFile.Text = OpenFileDialog1.FileName

        End If
       
    End Sub

    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        Dim result As Object
        Dim strtype As Object

        If Len(txtSourceFile.Text) = 0 Then
            MsgBox("Please input TIF File Name")
            Exit Sub
        End If


        Me.AxImageViewer1.PDFAuthor = "Viscom Software"
        Me.AxImageViewer1.PDFCreator = "Viscom Software"
        Me.AxImageViewer1.PDFKeyword = "image viewer cp pro activex"
        Me.AxImageViewer1.PDFProducer = "Viscom Software"
        Me.AxImageViewer1.PDFSubject = "image viewer cp pro activex"
        Me.AxImageViewer1.PDFTitle = "Demo"


        strtype = cboExportType.Items(cboExportType.SelectedIndex)


        result = AxImageViewer1.ExportTIF(txtSourceFile.Text, "c:\test", strtype, CShort(txtPageNo.Text), 24)


        If result = 1 Then
            MsgBox("export c:\test." & LCase(strtype) & " completed")
        Else
            MsgBox("failed")
        End If

    End Sub

    Private Sub Command7_Click()

    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click

        OpenFileDialog1.Filter = "TIF (*.tif)|*.tif||"



        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtimagefile.Text = OpenFileDialog1.FileName

        End If
        '		

    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
        Dim result As Object


        If Len(txtimagefile.Text) = 0 Then
            MsgBox("Please input Image File Name")
            Exit Sub
        End If


        Me.AxImageViewer1.PDFAuthor = "Viscom Software"
        Me.AxImageViewer1.PDFCreator = "Viscom Software"
        Me.AxImageViewer1.PDFKeyword = "image viewer cp pro activex"
        Me.AxImageViewer1.PDFProducer = "Viscom Software"
        Me.AxImageViewer1.PDFSubject = "image viewer cp pro activex"
        Me.AxImageViewer1.PDFTitle = "Demo"


        result = AxImageViewer1.Image2PDF(txtimagefile.Text, "c:\test.pdf")


        If result = 1 Then

            MsgBox("Save c:\test.pdf completed")
        End If


    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        cboExportType.Items.Add("BMP")
        cboExportType.Items.Add("JPG")
        cboExportType.Items.Add("TIF")
        cboExportType.Items.Add("GIF")
        cboExportType.Items.Add("PNG")
        cboExportType.Items.Add("EMF")
        cboExportType.Items.Add("PDF")
        cboExportType.SelectedIndex = 0






    End Sub

    'UPGRADE_WARNING: Event OptCITT3.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub OptCITT3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptCITT3.CheckedChanged

    End Sub

    'UPGRADE_WARNING: Event OptCITT4.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub OptCITT4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptCITT4.CheckedChanged

    End Sub

    'UPGRADE_WARNING: Event OptLZW.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub OptLZW_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptLZW.CheckedChanged

    End Sub

    'UPGRADE_WARNING: Event OptNone.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub OptNone_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptNone.CheckedChanged

    End Sub

    'UPGRADE_WARNING: Event OptRLE.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub OptRLE_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptRLE.CheckedChanged


    End Sub

    Private Sub OptCITT3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptCITT3.Click

        AxImageViewer1.TIFCompression = SCRIBBLELib.TIF_COMPRESSION.CompressionCCITT3
    End Sub

  
    Private Sub OptNone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptNone.Click
        AxImageViewer1.TIFCompression = SCRIBBLELib.TIF_COMPRESSION.CompressionNone
    End Sub

    Private Sub OptLZW_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptLZW.Click
        AxImageViewer1.TIFCompression = SCRIBBLELib.TIF_COMPRESSION.CompressionLZW
    End Sub

    Private Sub OptCITT4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptCITT4.Click
        AxImageViewer1.TIFCompression = SCRIBBLELib.TIF_COMPRESSION.CompressionCCITT4
    End Sub
End Class