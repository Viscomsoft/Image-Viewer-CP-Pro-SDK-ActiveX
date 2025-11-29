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
    Public WithEvents opthighyes As System.Windows.Forms.RadioButton
    Public WithEvents opthighno As System.Windows.Forms.RadioButton
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents optborderon As System.Windows.Forms.RadioButton
    Public WithEvents optborderoff As System.Windows.Forms.RadioButton
    Public WithEvents _Frame1_0 As System.Windows.Forms.GroupBox
    Public WithEvents Command12 As System.Windows.Forms.Button
    Public WithEvents Command11 As System.Windows.Forms.Button
    Public WithEvents Command7 As System.Windows.Forms.Button
    Public WithEvents Command6 As System.Windows.Forms.Button
    Public WithEvents Command8 As System.Windows.Forms.Button
    Public WithEvents Command9 As System.Windows.Forms.Button
    Public WithEvents Command10 As System.Windows.Forms.Button
    Public WithEvents Command5 As System.Windows.Forms.Button
    Public WithEvents Command20 As System.Windows.Forms.Button
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents lblcurrentpage As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents lbltotalpage As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    'Public WithEvents Frame1 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents chkpanning As System.Windows.Forms.CheckBox
    Private WithEvents lbltotalpdfformfield As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents btnEditField As System.Windows.Forms.Button
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtPage As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents chkexportcurrentpage As System.Windows.Forms.CheckBox
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.opthighyes = New System.Windows.Forms.RadioButton()
        Me.opthighno = New System.Windows.Forms.RadioButton()
        Me._Frame1_0 = New System.Windows.Forms.GroupBox()
        Me.optborderon = New System.Windows.Forms.RadioButton()
        Me.optborderoff = New System.Windows.Forms.RadioButton()
        Me.Command12 = New System.Windows.Forms.Button()
        Me.Command11 = New System.Windows.Forms.Button()
        Me.Command7 = New System.Windows.Forms.Button()
        Me.Command6 = New System.Windows.Forms.Button()
        Me.Command8 = New System.Windows.Forms.Button()
        Me.Command9 = New System.Windows.Forms.Button()
        Me.Command10 = New System.Windows.Forms.Button()
        Me.Command5 = New System.Windows.Forms.Button()
        Me.Command20 = New System.Windows.Forms.Button()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.lblcurrentpage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltotalpage = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkpanning = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbltotalpdfformfield = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.btnEditField = New System.Windows.Forms.Button()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.chkexportcurrentpage = New System.Windows.Forms.CheckBox()
        Me.Frame2.SuspendLayout()
        Me._Frame1_0.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.opthighyes)
        Me.Frame2.Controls.Add(Me.opthighno)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(3, 574)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(105, 49)
        Me.Frame2.TabIndex = 21
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "High Quality"
        '
        'opthighyes
        '
        Me.opthighyes.BackColor = System.Drawing.SystemColors.Control
        Me.opthighyes.Checked = True
        Me.opthighyes.Cursor = System.Windows.Forms.Cursors.Default
        Me.opthighyes.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opthighyes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opthighyes.Location = New System.Drawing.Point(8, 16)
        Me.opthighyes.Name = "opthighyes"
        Me.opthighyes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.opthighyes.Size = New System.Drawing.Size(41, 25)
        Me.opthighyes.TabIndex = 23
        Me.opthighyes.TabStop = True
        Me.opthighyes.Text = "Yes"
        Me.opthighyes.UseVisualStyleBackColor = False
        '
        'opthighno
        '
        Me.opthighno.BackColor = System.Drawing.SystemColors.Control
        Me.opthighno.Cursor = System.Windows.Forms.Cursors.Default
        Me.opthighno.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opthighno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opthighno.Location = New System.Drawing.Point(56, 16)
        Me.opthighno.Name = "opthighno"
        Me.opthighno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.opthighno.Size = New System.Drawing.Size(41, 25)
        Me.opthighno.TabIndex = 22
        Me.opthighno.TabStop = True
        Me.opthighno.Text = "No"
        Me.opthighno.UseVisualStyleBackColor = False
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame1_0.Controls.Add(Me.optborderon)
        Me._Frame1_0.Controls.Add(Me.optborderoff)
        Me._Frame1_0.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame1_0.Location = New System.Drawing.Point(9, 521)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_0.Size = New System.Drawing.Size(97, 48)
        Me._Frame1_0.TabIndex = 18
        Me._Frame1_0.TabStop = False
        Me._Frame1_0.Text = "Border"
        '
        'optborderon
        '
        Me.optborderon.BackColor = System.Drawing.SystemColors.Control
        Me.optborderon.Checked = True
        Me.optborderon.Cursor = System.Windows.Forms.Cursors.Default
        Me.optborderon.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optborderon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optborderon.Location = New System.Drawing.Point(8, 16)
        Me.optborderon.Name = "optborderon"
        Me.optborderon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optborderon.Size = New System.Drawing.Size(41, 25)
        Me.optborderon.TabIndex = 20
        Me.optborderon.TabStop = True
        Me.optborderon.Text = "On"
        Me.optborderon.UseVisualStyleBackColor = False
        '
        'optborderoff
        '
        Me.optborderoff.BackColor = System.Drawing.SystemColors.Control
        Me.optborderoff.Cursor = System.Windows.Forms.Cursors.Default
        Me.optborderoff.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optborderoff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optborderoff.Location = New System.Drawing.Point(48, 16)
        Me.optborderoff.Name = "optborderoff"
        Me.optborderoff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optborderoff.Size = New System.Drawing.Size(41, 25)
        Me.optborderoff.TabIndex = 19
        Me.optborderoff.TabStop = True
        Me.optborderoff.Text = "Off"
        Me.optborderoff.UseVisualStyleBackColor = False
        '
        'Command12
        '
        Me.Command12.BackColor = System.Drawing.SystemColors.Control
        Me.Command12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command12.Location = New System.Drawing.Point(11, 235)
        Me.Command12.Name = "Command12"
        Me.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command12.Size = New System.Drawing.Size(89, 25)
        Me.Command12.TabIndex = 12
        Me.Command12.Text = "25% of Original"
        Me.Command12.UseVisualStyleBackColor = False
        '
        'Command11
        '
        Me.Command11.BackColor = System.Drawing.SystemColors.Control
        Me.Command11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command11.Location = New System.Drawing.Point(11, 267)
        Me.Command11.Name = "Command11"
        Me.Command11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command11.Size = New System.Drawing.Size(89, 25)
        Me.Command11.TabIndex = 11
        Me.Command11.Text = "33% of Original"
        Me.Command11.UseVisualStyleBackColor = False
        '
        'Command7
        '
        Me.Command7.BackColor = System.Drawing.SystemColors.Control
        Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command7.Location = New System.Drawing.Point(11, 363)
        Me.Command7.Name = "Command7"
        Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command7.Size = New System.Drawing.Size(89, 25)
        Me.Command7.TabIndex = 10
        Me.Command7.Text = "100% of Original"
        Me.Command7.UseVisualStyleBackColor = False
        '
        'Command6
        '
        Me.Command6.BackColor = System.Drawing.SystemColors.Control
        Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command6.Location = New System.Drawing.Point(11, 395)
        Me.Command6.Name = "Command6"
        Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command6.Size = New System.Drawing.Size(89, 25)
        Me.Command6.TabIndex = 9
        Me.Command6.Text = "150% of Original"
        Me.Command6.UseVisualStyleBackColor = False
        '
        'Command8
        '
        Me.Command8.BackColor = System.Drawing.SystemColors.Control
        Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command8.Location = New System.Drawing.Point(11, 299)
        Me.Command8.Name = "Command8"
        Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command8.Size = New System.Drawing.Size(89, 25)
        Me.Command8.TabIndex = 8
        Me.Command8.Text = "50% of Original"
        Me.Command8.UseVisualStyleBackColor = False
        '
        'Command9
        '
        Me.Command9.BackColor = System.Drawing.SystemColors.Control
        Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command9.Location = New System.Drawing.Point(11, 331)
        Me.Command9.Name = "Command9"
        Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command9.Size = New System.Drawing.Size(89, 25)
        Me.Command9.TabIndex = 7
        Me.Command9.Text = "75% of Original"
        Me.Command9.UseVisualStyleBackColor = False
        '
        'Command10
        '
        Me.Command10.BackColor = System.Drawing.SystemColors.Control
        Me.Command10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command10.Location = New System.Drawing.Point(11, 427)
        Me.Command10.Name = "Command10"
        Me.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command10.Size = New System.Drawing.Size(89, 25)
        Me.Command10.TabIndex = 6
        Me.Command10.Text = "200% of Original"
        Me.Command10.UseVisualStyleBackColor = False
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(11, 459)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(89, 25)
        Me.Command5.TabIndex = 5
        Me.Command5.Text = "Fit to Window"
        Me.Command5.UseVisualStyleBackColor = False
        '
        'Command20
        '
        Me.Command20.BackColor = System.Drawing.SystemColors.Control
        Me.Command20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command20.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command20.Location = New System.Drawing.Point(11, 491)
        Me.Command20.Name = "Command20"
        Me.Command20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command20.Size = New System.Drawing.Size(89, 25)
        Me.Command20.TabIndex = 4
        Me.Command20.Text = "Aspect Ratio"
        Me.Command20.UseVisualStyleBackColor = False
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(11, 203)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(89, 25)
        Me.Command3.TabIndex = 3
        Me.Command3.Text = "Rotate 270"
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(11, 171)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(89, 25)
        Me.Command2.TabIndex = 2
        Me.Command2.Text = "Rotate 180"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(11, 139)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(89, 25)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Rotate 90"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'lblcurrentpage
        '
        Me.lblcurrentpage.BackColor = System.Drawing.SystemColors.Control
        Me.lblcurrentpage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcurrentpage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentpage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcurrentpage.Location = New System.Drawing.Point(200, 552)
        Me.lblcurrentpage.Name = "lblcurrentpage"
        Me.lblcurrentpage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcurrentpage.Size = New System.Drawing.Size(41, 17)
        Me.lblcurrentpage.TabIndex = 31
        Me.lblcurrentpage.Text = "0"
        Me.lblcurrentpage.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(248, 552)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(9, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "/"
        '
        'lbltotalpage
        '
        Me.lbltotalpage.BackColor = System.Drawing.SystemColors.Control
        Me.lbltotalpage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltotalpage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalpage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltotalpage.Location = New System.Drawing.Point(264, 552)
        Me.lbltotalpage.Name = "lbltotalpage"
        Me.lbltotalpage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltotalpage.Size = New System.Drawing.Size(57, 17)
        Me.lbltotalpage.TabIndex = 29
        Me.lbltotalpage.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(112, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Total Pages"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkpanning)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 99)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "You may find the PDF form sample in C:\Program Files (x86)\Image Viewer Pro Activ" & _
            "eX Control\PDFFormFields"
        '
        'chkpanning
        '
        Me.chkpanning.AutoSize = True
        Me.chkpanning.Checked = True
        Me.chkpanning.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpanning.Location = New System.Drawing.Point(92, 65)
        Me.chkpanning.Name = "chkpanning"
        Me.chkpanning.Size = New System.Drawing.Size(158, 18)
        Me.chkpanning.TabIndex = 2
        Me.chkpanning.Text = "Enable Panning with Mouse"
        Me.chkpanning.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(343, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 27)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Select Image"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(465, 20)
        Me.TextBox1.TabIndex = 0
        '
        'lbltotalpdfformfield
        '
        Me.lbltotalpdfformfield.AutoSize = True
        Me.lbltotalpdfformfield.Location = New System.Drawing.Point(717, 12)
        Me.lbltotalpdfformfield.Name = "lbltotalpdfformfield"
        Me.lbltotalpdfformfield.Size = New System.Drawing.Size(13, 14)
        Me.lbltotalpdfformfield.TabIndex = 125
        Me.lbltotalpdfformfield.Text = "0"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(552, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(109, 14)
        Me.label1.TabIndex = 124
        Me.label1.Text = "Total PDF Form Fields"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(760, 227)
        Me.button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(104, 28)
        Me.button3.TabIndex = 123
        Me.button3.Text = "Export to PDF"
        Me.button3.UseVisualStyleBackColor = True
        '
        'btnEditField
        '
        Me.btnEditField.Location = New System.Drawing.Point(554, 227)
        Me.btnEditField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditField.Name = "btnEditField"
        Me.btnEditField.Size = New System.Drawing.Size(178, 28)
        Me.btnEditField.TabIndex = 122
        Me.btnEditField.Text = "Edit PDF Form Fields"
        Me.btnEditField.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 14
        Me.listBox1.Location = New System.Drawing.Point(554, 63)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(404, 102)
        Me.listBox1.TabIndex = 121
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(135, 144)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(373, 381)
        Me.AxImageViewer1.TabIndex = 126
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(361, 556)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(31, 14)
        Me.label4.TabIndex = 129
        Me.label4.Text = "Page"
        '
        'txtPage
        '
        Me.txtPage.Location = New System.Drawing.Point(398, 553)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(39, 20)
        Me.txtPage.TabIndex = 128
        Me.txtPage.Text = "1"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(453, 552)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(40, 24)
        Me.button1.TabIndex = 127
        Me.button1.Text = "Go"
        Me.button1.UseVisualStyleBackColor = True
        '
        'chkexportcurrentpage
        '
        Me.chkexportcurrentpage.AutoSize = True
        Me.chkexportcurrentpage.Location = New System.Drawing.Point(760, 267)
        Me.chkexportcurrentpage.Name = "chkexportcurrentpage"
        Me.chkexportcurrentpage.Size = New System.Drawing.Size(146, 18)
        Me.chkexportcurrentpage.TabIndex = 130
        Me.chkexportcurrentpage.Text = "Export Current Page only"
        Me.chkexportcurrentpage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1148, 838)
        Me.Controls.Add(Me.chkexportcurrentpage)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtPage)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.lbltotalpdfformfield)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.btnEditField)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._Frame1_0)
        Me.Controls.Add(Me.Command12)
        Me.Controls.Add(Me.Command11)
        Me.Controls.Add(Me.Command7)
        Me.Controls.Add(Me.Command6)
        Me.Controls.Add(Me.Command8)
        Me.Controls.Add(Me.Command9)
        Me.Controls.Add(Me.Command10)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Command20)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.lblcurrentpage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbltotalpage)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "PDF Form Fields  (Load PDF need purchase Advanced PDF Viewer plugin)"
        Me.Frame2.ResumeLayout(False)
        Me._Frame1_0.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
        Set(ByVal value As Form1)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region
    Dim iX As Short
    Dim iY As Short

    Dim clrHashForeColor As Object
    Dim clrHashBackColor As Object

    Private Structure PictDesc
        Dim cbSizeofStruct As Integer
        Dim picType As Integer
        Dim hImage As Integer
        Dim xExt As Integer
        Dim yExt As Integer
    End Structure

    Private Structure Guid
        Dim Data1 As Integer
        Dim Data2 As Short
        Dim Data3 As Short
        <VBFixedArray(7)> Dim Data4() As Byte

        Public Sub Initialize()
            ReDim Data4(7)
        End Sub
    End Structure

    Private Declare Function OleCreatePictureIndirect Lib "olepro32.dll" (ByRef lpPictDesc As PictDesc, ByRef riid As Guid, ByVal fPictureOwnsHandle As Integer, ByRef ipic As System.Drawing.Image) As Integer




    Private Sub cbohashbrushstyle_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    'UPGRADE_WARNING: Event cbotextstyle.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub cbotextstyle_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub

    Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)



    End Sub

    Private Sub Check2_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    End Sub

    'UPGRADE_WARNING: Event Check4.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub Check4_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)



    End Sub

    'UPGRADE_WARNING: Event chkdefaultcap.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub chkdefaultcap_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)




    End Sub

    'UPGRADE_WARNING: Event chkshowtext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub chkshowtext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub

    Private Sub cmdhashbackcolor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub cmdhashforecolor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub cmdoutlineback_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub cmdoutlineborder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub cmdtextcolor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    End Sub


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Me.AxImageViewer1.Rotate90()
    End Sub

    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click

        AxImageViewer1.View = 7
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
        AxImageViewer1.View = 2
        AxImageViewer1.SetControlFocus()
    End Sub

    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click

        AxImageViewer1.View = 1
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Command13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If ColorDialog1.ShowDialog() Then

            Me.AxImageViewer1.SetBackgroundColor(Color2Uint32(ColorDialog1.Color))

        End If

    End Sub

    Private Sub Command14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        AxImageViewer1.PrintImage(True)
    End Sub

    Private Sub Command15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)




    End Sub

    Private Sub Command16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)





    End Sub

    Private Sub Command17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    End Sub

    Private Sub Command18_Click()


    End Sub

    Private Sub Command19_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.AxImageViewer1.Rotate180()
    End Sub

    Private Sub Command20_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command20.Click

        AxImageViewer1.View = 12
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Command21_Click()



    End Sub

    Private Sub Command22_Click()

    End Sub

    Private Sub Command23_Click()



    End Sub

    Private Sub Command24_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        AxImageViewer1.Copy2Clipboard()


    End Sub

    Private Sub Command25_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub Command26_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub Command27_Click()



    End Sub

    Private Sub Command28_Click()


    End Sub

    Private Sub Command29_Click()



    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Me.AxImageViewer1.Rotate270()
    End Sub


    Private Sub Command31_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    End Sub

    Private Sub Command32_Click()


    End Sub

    Private Sub Command33_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub Command34_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub

    Private Sub Command35_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub

    Private Sub Command36_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub

    Private Sub Command37_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub

    Private Sub Command38_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub

    Private Sub Command39_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)








    End Sub

    Private Sub Command40_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click

        AxImageViewer1.View = 9
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click

        AxImageViewer1.View = 7
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
        AxImageViewer1.View = 5
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
        AxImageViewer1.View = 3
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click

        AxImageViewer1.View = 4
        AxImageViewer1.SetControlFocus()

    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
       


        AxImageViewer1.HighQuality = True



    End Sub

    Private Sub optborderoff_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optborderoff.CheckedChanged

    End Sub

    Private Sub optborderon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optborderon.CheckedChanged



    End Sub

    Private Sub Option3_Click()

    End Sub

    Private Sub opthighno_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opthighno.CheckedChanged

    End Sub

    Private Sub opthighyes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opthighyes.CheckedChanged

    End Sub





    Private Sub Text1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs)

    End Sub



    Private Sub chkdefaultcap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub Check3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub opthighyes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles opthighyes.Click

        If Me.opthighyes.Checked = True Then
            AxImageViewer1.HighQuality = True
        Else
            AxImageViewer1.HighQuality = False
        End If



    End Sub

    Private Sub optborderon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optborderon.Click
        If Me.optborderon.Checked = True Then
            AxImageViewer1.Border = True
        Else
            AxImageViewer1.Border = False
        End If

    End Sub

    Private Sub optborderoff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optborderoff.Click
        If Me.optborderon.Checked = True Then
            AxImageViewer1.Border = True
        Else
            AxImageViewer1.Border = False
        End If

    End Sub

    Private Sub opthighno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles opthighno.Click


    End Sub



    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim strFilter As String
        Dim iType As Integer
        Dim i As Integer
        Dim strLabel As String
        Dim strItem As String
        strFilter = "PDF (*.pdf)|*.pdf|Open XML Paper Specification (*.xps *.oxps)|*.xps;*.oxps|TIFF (*.tiff)|*.tif|JPEG (*.jpg)|*.jpg|BMP (*.bmp)|*.bmp|PNG (*.png)|*.png|GIF (*.gif)|*.gif"

        If chkpanning.Checked Then
            AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.LeftPanOnly
        Else
            AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.DefaultMode
        End If

        OpenFileDialog1.Filter = strFilter

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            TextBox1.Text = OpenFileDialog1.FileName
            AxImageViewer1.PDFUseAdvancedViewer = True
            AxImageViewer1.LoadMultiPage(OpenFileDialog1.FileName, 1)
        

            lbltotalpage.Text = CStr(Me.AxImageViewer1.GetTotalPage)
            lblcurrentpage.Text = 1


            listBox1.Items.Clear()

            lbltotalpdfformfield.Text = AxImageViewer1.PDFFormFieldsCount().ToString()

            For i = 0 To AxImageViewer1.PDFFormFieldsCount() - 1

                iType = AxImageViewer1.PDFFormFieldsWidgetType(i)
                strLabel = AxImageViewer1.PDFFormFieldsLabel(i)



                strItem = "Index " + i.ToString() + " " + "Label:" + strLabel + " WidgetType: " + GetWidgetType(iType)

                listBox1.Items.Add(strItem)
            Next

            If listBox1.Items.Count > 0 Then

                listBox1.SelectedIndex = 0
            End If



        End If
    End Sub


    Public Function GetWidgetType(ByVal iType As Integer) As String

        Dim strType As String

        If (iType = 0) Then
            strType = "UNKNOWN"
        ElseIf (iType = 1) Then
            strType = "BUTTON"
        ElseIf (iType = 2) Then
            strType = "CHECKBOX"
        ElseIf (iType = 3) Then
            strType = "COMBOBOX"
        ElseIf (iType = 4) Then
            strType = "LISTBOX"
        ElseIf (iType = 5) Then
            strType = "RADIOBUTTON"
        ElseIf (iType = 6) Then
            strType = "SIGNATURE"
        ElseIf (iType = 7) Then
            strType = "TEXT"
        End If

        Return strType
    End Function

    Private Sub chkpanning_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpanning.CheckedChanged
       

    End Sub

    Private Sub btnEditField_Click(sender As System.Object, e As System.EventArgs) Handles btnEditField.Click
        Dim iSelIndex As Integer
        Dim iType As Integer
        iSelIndex = listBox1.SelectedIndex

        If iSelIndex < 0 Then
            Exit Sub
        End If

        iType = AxImageViewer1.PDFFormFieldsWidgetType(iSelIndex)

        If iType = 2 Then
            Dim frm As New FormCheckBox
            frm.Checked = AxImageViewer1.PDFFormFieldsIsCheck(iSelIndex)
            frm.FieldIndex = iSelIndex

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                AxImageViewer1.PDFFormFieldsSetChecked(iSelIndex, frm.Checked)

                AxImageViewer1.PDFFormFieldsUpdate("", -1)
            End If

        ElseIf iType = 3 Then
            Dim frm As New FormCombobox
            frm.FieldIndex = iSelIndex
            frm.ComboBoxIndex = AxImageViewer1.PDFFormFieldsCboListBoxIndex(iSelIndex)

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                AxImageViewer1.PDFFormFieldsSetCboListBoxIndex(iSelIndex, frm.ComboBoxIndex)
                AxImageViewer1.PDFFormFieldsUpdate("", -1)
            End If
        ElseIf iType = 7 Then


            Dim frm As New FormTextBox
            frm.Value = AxImageViewer1.PDFFormFieldsText(iSelIndex)
            frm.FieldIndex = iSelIndex


            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                AxImageViewer1.PDFFormFieldsSetText(iSelIndex, frm.Value)
                AxImageViewer1.PDFFormFieldsUpdate("", -1)
            End If
        End If


    End Sub

    Private Sub button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Me.SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"


        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If chkexportcurrentpage.Checked Then
                AxImageViewer1.PDFFormFieldsUpdate(SaveFileDialog1.FileName, txtPage.Text)
            Else
                AxImageViewer1.PDFFormFieldsUpdate(SaveFileDialog1.FileName, -1)
            End If
        End If

    End Sub

    Private Sub button1_Click_1(sender As System.Object, e As System.EventArgs) Handles button1.Click
        Dim iType As Integer
        Dim i As Integer
        Dim strLabel As String
        Dim strItem As String


        AxImageViewer1.LoadMultiPage(OpenFileDialog1.FileName, txtPage.Text)



        lbltotalpage.Text = CStr(Me.AxImageViewer1.GetTotalPage)
        lblcurrentpage.Text = AxImageViewer1.GetCurrentPage()


        listBox1.Items.Clear()

        lbltotalpdfformfield.Text = AxImageViewer1.PDFFormFieldsCount().ToString()

        For i = 0 To AxImageViewer1.PDFFormFieldsCount() - 1

            iType = AxImageViewer1.PDFFormFieldsWidgetType(i)
            strLabel = AxImageViewer1.PDFFormFieldsLabel(i)



            strItem = "Index " + i.ToString() + " " + "Label:" + strLabel + " WidgetType: " + GetWidgetType(iType)

            listBox1.Items.Add(strItem)
        Next

        If listBox1.Items.Count > 0 Then

            listBox1.SelectedIndex = 0
        End If

    End Sub
End Class