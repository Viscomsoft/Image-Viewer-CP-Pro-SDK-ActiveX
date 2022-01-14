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
    Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents chkstretch As System.Windows.Forms.CheckBox
	Public WithEvents chkoutline As System.Windows.Forms.CheckBox
	Public WithEvents cmdprint As System.Windows.Forms.Button
	Public WithEvents cbohoralign As System.Windows.Forms.ComboBox
	Public WithEvents cbovertalign As System.Windows.Forms.ComboBox
	Public WithEvents txtMarginy As System.Windows.Forms.TextBox
	Public WithEvents txtMarginx As System.Windows.Forms.TextBox
	Public WithEvents txtspacex As System.Windows.Forms.TextBox
	Public WithEvents spacey As System.Windows.Forms.TextBox
	Public WithEvents txtStartPage As System.Windows.Forms.TextBox
	Public WithEvents txtEndPage As System.Windows.Forms.TextBox
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents optprintall As System.Windows.Forms.RadioButton
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents txtrow As System.Windows.Forms.TextBox
	Public WithEvents txtcol As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents lbltotalpage As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents chkshowprintdialog As System.Windows.Forms.CheckBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command1 = New System.Windows.Forms.Button
        Me.chkstretch = New System.Windows.Forms.CheckBox
        Me.chkoutline = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdprint = New System.Windows.Forms.Button
        Me.cbohoralign = New System.Windows.Forms.ComboBox
        Me.cbovertalign = New System.Windows.Forms.ComboBox
        Me.txtMarginy = New System.Windows.Forms.TextBox
        Me.txtMarginx = New System.Windows.Forms.TextBox
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.txtspacex = New System.Windows.Forms.TextBox
        Me.spacey = New System.Windows.Forms.TextBox
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.txtStartPage = New System.Windows.Forms.TextBox
        Me.txtEndPage = New System.Windows.Forms.TextBox
        Me.Option2 = New System.Windows.Forms.RadioButton
        Me.optprintall = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtrow = New System.Windows.Forms.TextBox
        Me.txtcol = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbltotalpage = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkshowprintdialog = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(16, 416)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(89, 25)
        Me.Command1.TabIndex = 24
        Me.Command1.Text = "Select Image"
        '
        'chkstretch
        '
        Me.chkstretch.BackColor = System.Drawing.SystemColors.Control
        Me.chkstretch.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkstretch.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkstretch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkstretch.Location = New System.Drawing.Point(448, 120)
        Me.chkstretch.Name = "chkstretch"
        Me.chkstretch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkstretch.Size = New System.Drawing.Size(161, 17)
        Me.chkstretch.TabIndex = 3
        Me.chkstretch.Text = "Stretch Image "
        '
        'chkoutline
        '
        Me.chkoutline.BackColor = System.Drawing.SystemColors.Control
        Me.chkoutline.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkoutline.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkoutline.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkoutline.Location = New System.Drawing.Point(448, 88)
        Me.chkoutline.Name = "chkoutline"
        Me.chkoutline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkoutline.Size = New System.Drawing.Size(161, 17)
        Me.chkoutline.TabIndex = 2
        Me.chkoutline.Text = "Show Outline Box"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdprint)
        Me.Frame1.Controls.Add(Me.cbohoralign)
        Me.Frame1.Controls.Add(Me.cbovertalign)
        Me.Frame1.Controls.Add(Me.txtMarginy)
        Me.Frame1.Controls.Add(Me.txtMarginx)
        Me.Frame1.Controls.Add(Me.Frame2)
        Me.Frame1.Controls.Add(Me.chkshowprintdialog)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(432, 32)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(393, 369)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Print Setting"
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdprint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdprint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdprint.Location = New System.Drawing.Point(8, 336)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdprint.Size = New System.Drawing.Size(73, 25)
        Me.cmdprint.TabIndex = 25
        Me.cmdprint.Text = "Print"
        '
        'cbohoralign
        '
        Me.cbohoralign.BackColor = System.Drawing.SystemColors.Window
        Me.cbohoralign.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbohoralign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohoralign.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbohoralign.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbohoralign.Location = New System.Drawing.Point(288, 96)
        Me.cbohoralign.Name = "cbohoralign"
        Me.cbohoralign.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbohoralign.Size = New System.Drawing.Size(65, 20)
        Me.cbohoralign.TabIndex = 23
        '
        'cbovertalign
        '
        Me.cbovertalign.BackColor = System.Drawing.SystemColors.Window
        Me.cbovertalign.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovertalign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovertalign.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovertalign.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovertalign.Location = New System.Drawing.Point(288, 72)
        Me.cbovertalign.Name = "cbovertalign"
        Me.cbovertalign.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovertalign.Size = New System.Drawing.Size(65, 20)
        Me.cbovertalign.TabIndex = 21
        '
        'txtMarginy
        '
        Me.txtMarginy.AcceptsReturn = True
        Me.txtMarginy.AutoSize = False
        Me.txtMarginy.BackColor = System.Drawing.SystemColors.Window
        Me.txtMarginy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMarginy.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginy.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMarginy.Location = New System.Drawing.Point(288, 48)
        Me.txtMarginy.MaxLength = 0
        Me.txtMarginy.Name = "txtMarginy"
        Me.txtMarginy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMarginy.Size = New System.Drawing.Size(57, 19)
        Me.txtMarginy.TabIndex = 19
        Me.txtMarginy.Text = "10"
        '
        'txtMarginx
        '
        Me.txtMarginx.AcceptsReturn = True
        Me.txtMarginx.AutoSize = False
        Me.txtMarginx.BackColor = System.Drawing.SystemColors.Window
        Me.txtMarginx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMarginx.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMarginx.Location = New System.Drawing.Point(288, 24)
        Me.txtMarginx.MaxLength = 0
        Me.txtMarginx.Name = "txtMarginx"
        Me.txtMarginx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMarginx.Size = New System.Drawing.Size(57, 19)
        Me.txtMarginx.TabIndex = 17
        Me.txtMarginx.Text = "10"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtspacex)
        Me.Frame2.Controls.Add(Me.spacey)
        Me.Frame2.Controls.Add(Me.Frame3)
        Me.Frame2.Controls.Add(Me.txtrow)
        Me.Frame2.Controls.Add(Me.txtcol)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.lbltotalpage)
        Me.Frame2.Controls.Add(Me.Label11)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 136)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(369, 177)
        Me.Frame2.TabIndex = 4
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Mulit Page Printing Setting"
        '
        'txtspacex
        '
        Me.txtspacex.AcceptsReturn = True
        Me.txtspacex.AutoSize = False
        Me.txtspacex.BackColor = System.Drawing.SystemColors.Window
        Me.txtspacex.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtspacex.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspacex.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtspacex.Location = New System.Drawing.Point(104, 128)
        Me.txtspacex.MaxLength = 0
        Me.txtspacex.Name = "txtspacex"
        Me.txtspacex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtspacex.Size = New System.Drawing.Size(57, 19)
        Me.txtspacex.TabIndex = 29
        Me.txtspacex.Text = "10"
        '
        'spacey
        '
        Me.spacey.AcceptsReturn = True
        Me.spacey.AutoSize = False
        Me.spacey.BackColor = System.Drawing.SystemColors.Window
        Me.spacey.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.spacey.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spacey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.spacey.Location = New System.Drawing.Point(104, 152)
        Me.spacey.MaxLength = 0
        Me.spacey.Name = "spacey"
        Me.spacey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.spacey.Size = New System.Drawing.Size(57, 19)
        Me.spacey.TabIndex = 28
        Me.spacey.Text = "10"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.txtStartPage)
        Me.Frame3.Controls.Add(Me.txtEndPage)
        Me.Frame3.Controls.Add(Me.Option2)
        Me.Frame3.Controls.Add(Me.optprintall)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(160, 16)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(201, 105)
        Me.Frame3.TabIndex = 9
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Print All Pages"
        '
        'txtStartPage
        '
        Me.txtStartPage.AcceptsReturn = True
        Me.txtStartPage.AutoSize = False
        Me.txtStartPage.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartPage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartPage.Enabled = False
        Me.txtStartPage.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartPage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartPage.Location = New System.Drawing.Point(88, 56)
        Me.txtStartPage.MaxLength = 0
        Me.txtStartPage.Name = "txtStartPage"
        Me.txtStartPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartPage.Size = New System.Drawing.Size(41, 19)
        Me.txtStartPage.TabIndex = 15
        Me.txtStartPage.Text = "1"
        '
        'txtEndPage
        '
        Me.txtEndPage.AcceptsReturn = True
        Me.txtEndPage.AutoSize = False
        Me.txtEndPage.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndPage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndPage.Enabled = False
        Me.txtEndPage.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndPage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndPage.Location = New System.Drawing.Point(88, 80)
        Me.txtEndPage.MaxLength = 0
        Me.txtEndPage.Name = "txtEndPage"
        Me.txtEndPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndPage.Size = New System.Drawing.Size(41, 19)
        Me.txtEndPage.TabIndex = 14
        Me.txtEndPage.Text = "1"
        '
        'Option2
        '
        Me.Option2.BackColor = System.Drawing.SystemColors.Control
        Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option2.Location = New System.Drawing.Point(88, 24)
        Me.Option2.Name = "Option2"
        Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option2.Size = New System.Drawing.Size(49, 17)
        Me.Option2.TabIndex = 11
        Me.Option2.TabStop = True
        Me.Option2.Text = "No"
        '
        'optprintall
        '
        Me.optprintall.BackColor = System.Drawing.SystemColors.Control
        Me.optprintall.Checked = True
        Me.optprintall.Cursor = System.Windows.Forms.Cursors.Default
        Me.optprintall.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optprintall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optprintall.Location = New System.Drawing.Point(16, 24)
        Me.optprintall.Name = "optprintall"
        Me.optprintall.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optprintall.Size = New System.Drawing.Size(49, 17)
        Me.optprintall.TabIndex = 10
        Me.optprintall.TabStop = True
        Me.optprintall.Text = "Yes"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "End Page"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Start Page"
        '
        'txtrow
        '
        Me.txtrow.AcceptsReturn = True
        Me.txtrow.AutoSize = False
        Me.txtrow.BackColor = System.Drawing.SystemColors.Window
        Me.txtrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrow.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtrow.Location = New System.Drawing.Point(16, 104)
        Me.txtrow.MaxLength = 0
        Me.txtrow.Name = "txtrow"
        Me.txtrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtrow.Size = New System.Drawing.Size(41, 19)
        Me.txtrow.TabIndex = 8
        Me.txtrow.Text = "1"
        '
        'txtcol
        '
        Me.txtcol.AcceptsReturn = True
        Me.txtcol.AutoSize = False
        Me.txtcol.BackColor = System.Drawing.SystemColors.Window
        Me.txtcol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcol.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcol.Location = New System.Drawing.Point(16, 64)
        Me.txtcol.MaxLength = 0
        Me.txtcol.Name = "txtcol"
        Me.txtcol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcol.Size = New System.Drawing.Size(41, 19)
        Me.txtcol.TabIndex = 6
        Me.txtcol.Text = "1"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Space X (mm)"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Space Y (mm)"
        '
        'lbltotalpage
        '
        Me.lbltotalpage.BackColor = System.Drawing.SystemColors.Control
        Me.lbltotalpage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltotalpage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalpage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltotalpage.Location = New System.Drawing.Point(88, 24)
        Me.lbltotalpage.Name = "lbltotalpage"
        Me.lbltotalpage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltotalpage.Size = New System.Drawing.Size(49, 17)
        Me.lbltotalpage.TabIndex = 27
        Me.lbltotalpage.Text = "0"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Total Page"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number of row image in Page"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of colum image in Page"
        '
        'chkshowprintdialog
        '
        Me.chkshowprintdialog.BackColor = System.Drawing.SystemColors.Control
        Me.chkshowprintdialog.Checked = True
        Me.chkshowprintdialog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkshowprintdialog.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkshowprintdialog.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkshowprintdialog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkshowprintdialog.Location = New System.Drawing.Point(16, 24)
        Me.chkshowprintdialog.Name = "chkshowprintdialog"
        Me.chkshowprintdialog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkshowprintdialog.Size = New System.Drawing.Size(137, 17)
        Me.chkshowprintdialog.TabIndex = 1
        Me.chkshowprintdialog.Text = "Show Printer Dialog Box"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(200, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Horizontal Align"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(200, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Vertical Align"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(200, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Margin Y (mm)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(200, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Margin X (mm)"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(8, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(408, 392)
        Me.AxImageViewer1.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(841, 471)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.chkstretch)
        Me.Controls.Add(Me.chkoutline)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Printing"
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
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
	Private Sub cmdprint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdprint.Click
		Dim Result As Object
		Dim txtspacey As Object
        AxImageViewer1.PrintOutline = chkoutline.CheckState
        AxImageViewer1.PrintStretch = chkstretch.CheckState
        AxImageViewer1.PrintMarginX = CShort(txtMarginx.Text)
        AxImageViewer1.PrintMarginY = CShort(txtMarginy.Text)
        AxImageViewer1.PrintSpaceX = CShort(txtspacex.Text)
        AxImageViewer1.PrintSpaceY = txtspacey
		
        AxImageViewer1.PrintVertAlign = Me.cbovertalign.SelectedIndex
        AxImageViewer1.PrintHorzAlign = Me.cbohoralign.SelectedIndex
		
        AxImageViewer1.PrintColCount = CShort(txtcol.Text)
        AxImageViewer1.PrintRowCount = CShort(txtrow.Text)
		
		If optprintall.Checked = True Then
            AxImageViewer1.PrintStartPage = -1
            AxImageViewer1.PrintEndPage = -1
		Else
            AxImageViewer1.PrintStartPage = CShort(txtStartPage.Text)
            AxImageViewer1.PrintEndPage = CShort(txtEndPage.Text)
		End If
		
		
	    Result = AxImageViewer1.PrintImage(chkshowprintdialog.CheckState)
		
		If Result = 0 Then
			MsgBox("Print failed")
		End If
		
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim strFile As String
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"



        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            strFile = OpenFileDialog1.FileName

            If Mid(strFile, Len(strFile) - 3) = ".tif" Or Mid(strFile, Len(strFile) - 3) = ".TIF" Or Mid(strFile, Len(strFile) - 3) = ".pdf" Or Mid(strFile, Len(strFile) - 3) = ".PDF" Then
                Me.AxImageViewer1.LoadMultiPage(strFile, 1)
                txtEndPage.Text = CStr(AxImageViewer1.GetTotalPage)
                lbltotalpage.Text = txtEndPage.Text

            Else
                Me.AxImageViewer1.FileName = strFile
                txtEndPage.Text = "1"
                lbltotalpage.Text = txtEndPage.Text

            End If




            Me.AxImageViewer1.View = 9
        End If

	End Sub
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cbovertalign.Items.Add("Top")
		cbovertalign.Items.Add("Center")
		cbovertalign.Items.Add("Bottom")
		
		cbohoralign.Items.Add("Left")
		cbohoralign.Items.Add("Center")
		cbohoralign.Items.Add("Right")
		
		cbovertalign.SelectedIndex = 1
		cbohoralign.SelectedIndex = 1
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode
		
	End Sub
	
	Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
		If eventSender.Checked Then
			txtStartPage.Enabled = True
			txtEndPage.Enabled = True
		End If
	End Sub
	
	Private Sub optprintall_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optprintall.CheckedChanged
		If eventSender.Checked Then
			txtStartPage.Enabled = False
			txtEndPage.Enabled = False
			
		End If
	End Sub
End Class