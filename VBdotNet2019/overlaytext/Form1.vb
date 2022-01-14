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
    Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents cbooutputtype As System.Windows.Forms.ComboBox
	Public WithEvents Command5 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents cmdtextureimage As System.Windows.Forms.Button
    Friend WithEvents txttextureimage As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents cmdhashbackcolor As System.Windows.Forms.Label
    Friend WithEvents cmdhashforecolor As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbohashbrushstyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmdoutlineback As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdoutlineborder As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdtextcolor As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbotextstyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkshowtext As System.Windows.Forms.CheckBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents txttext2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txttext1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTextTop As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTextLeft As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbofontstyle As System.Windows.Forms.ComboBox
    Friend WithEvents cbofontsize As System.Windows.Forms.ComboBox
    Friend WithEvents cbofont As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.cbooutputtype = New System.Windows.Forms.ComboBox
        Me.Command5 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.cmdtextureimage = New System.Windows.Forms.Button
        Me.txttextureimage = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button
        Me.cmdhashbackcolor = New System.Windows.Forms.Label
        Me.cmdhashforecolor = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbohashbrushstyle = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmdoutlineback = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmdoutlineborder = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmdtextcolor = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.cbotextstyle = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.chkshowtext = New System.Windows.Forms.CheckBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.txttext2 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txttext1 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTextTop = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtTextLeft = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbofontstyle = New System.Windows.Forms.ComboBox
        Me.cbofontsize = New System.Windows.Forms.ComboBox
        Me.cbofont = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.GroupBox3.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.AutoSize = False
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Enabled = False
        Me.Text2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(744, 16)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(65, 19)
        Me.Text2.TabIndex = 21
        Me.Text2.Text = "0"
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.AutoSize = False
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(592, 16)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(65, 19)
        Me.Text1.TabIndex = 19
        Me.Text1.Text = "0"
        '
        'cbooutputtype
        '
        Me.cbooutputtype.BackColor = System.Drawing.SystemColors.Window
        Me.cbooutputtype.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbooutputtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputtype.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbooutputtype.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbooutputtype.Location = New System.Drawing.Point(176, 608)
        Me.cbooutputtype.Name = "cbooutputtype"
        Me.cbooutputtype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbooutputtype.Size = New System.Drawing.Size(97, 20)
        Me.cbooutputtype.TabIndex = 16
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(288, 600)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(81, 33)
        Me.Command5.TabIndex = 15
        Me.Command5.Text = "Save"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(8, 600)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Select Image"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(672, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "File Height"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(528, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "File Width"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(96, 608)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Ouput Format"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TrackBar1)
        Me.GroupBox3.Controls.Add(Me.cmdtextureimage)
        Me.GroupBox3.Controls.Add(Me.txttextureimage)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.cmdhashbackcolor)
        Me.GroupBox3.Controls.Add(Me.cmdhashforecolor)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.cbohashbrushstyle)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.cmdoutlineback)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cmdoutlineborder)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.cmdtextcolor)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.cbotextstyle)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.chkshowtext)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.txttext2)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txttext1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTextTop)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtTextLeft)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cbofontstyle)
        Me.GroupBox3.Controls.Add(Me.cbofontsize)
        Me.GroupBox3.Controls.Add(Me.cbofont)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(528, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 616)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Text"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 16)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Alpha"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(72, 152)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(192, 45)
        Me.TrackBar1.TabIndex = 33
        Me.TrackBar1.TickFrequency = 100
        Me.TrackBar1.Value = 255
        '
        'cmdtextureimage
        '
        Me.cmdtextureimage.Location = New System.Drawing.Point(192, 504)
        Me.cmdtextureimage.Name = "cmdtextureimage"
        Me.cmdtextureimage.Size = New System.Drawing.Size(120, 24)
        Me.cmdtextureimage.TabIndex = 32
        Me.cmdtextureimage.Text = "Select Image"
        '
        'txttextureimage
        '
        Me.txttextureimage.Enabled = False
        Me.txttextureimage.Location = New System.Drawing.Point(8, 504)
        Me.txttextureimage.Name = "txttextureimage"
        Me.txttextureimage.Size = New System.Drawing.Size(176, 20)
        Me.txttextureimage.TabIndex = 31
        Me.txttextureimage.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 472)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 16)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Texture Brush Image"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(120, 432)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(64, 24)
        Me.Button9.TabIndex = 29
        Me.Button9.Text = "Change"
        '
        'cmdhashbackcolor
        '
        Me.cmdhashbackcolor.Location = New System.Drawing.Point(8, 440)
        Me.cmdhashbackcolor.Name = "cmdhashbackcolor"
        Me.cmdhashbackcolor.Size = New System.Drawing.Size(96, 16)
        Me.cmdhashbackcolor.TabIndex = 28
        Me.cmdhashbackcolor.Text = "Hash Back Color"
        '
        'cmdhashforecolor
        '
        Me.cmdhashforecolor.Location = New System.Drawing.Point(120, 400)
        Me.cmdhashforecolor.Name = "cmdhashforecolor"
        Me.cmdhashforecolor.Size = New System.Drawing.Size(64, 24)
        Me.cmdhashforecolor.TabIndex = 27
        Me.cmdhashforecolor.Text = "Change"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 408)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Hash Fore Color"
        '
        'cbohashbrushstyle
        '
        Me.cbohashbrushstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohashbrushstyle.Location = New System.Drawing.Point(8, 376)
        Me.cbohashbrushstyle.Name = "cbohashbrushstyle"
        Me.cbohashbrushstyle.Size = New System.Drawing.Size(136, 22)
        Me.cbohashbrushstyle.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 344)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Hash Brush"
        '
        'cmdoutlineback
        '
        Me.cmdoutlineback.Location = New System.Drawing.Point(120, 312)
        Me.cmdoutlineback.Name = "cmdoutlineback"
        Me.cmdoutlineback.Size = New System.Drawing.Size(64, 24)
        Me.cmdoutlineback.TabIndex = 23
        Me.cmdoutlineback.Text = "Change"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 320)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 16)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Outline back color"
        '
        'cmdoutlineborder
        '
        Me.cmdoutlineborder.Location = New System.Drawing.Point(120, 280)
        Me.cmdoutlineborder.Name = "cmdoutlineborder"
        Me.cmdoutlineborder.Size = New System.Drawing.Size(64, 24)
        Me.cmdoutlineborder.TabIndex = 21
        Me.cmdoutlineborder.Text = "Change"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 280)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 16)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Outline border color"
        '
        'cmdtextcolor
        '
        Me.cmdtextcolor.Location = New System.Drawing.Point(120, 240)
        Me.cmdtextcolor.Name = "cmdtextcolor"
        Me.cmdtextcolor.Size = New System.Drawing.Size(64, 24)
        Me.cmdtextcolor.TabIndex = 19
        Me.cmdtextcolor.Text = "Change"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 240)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Color"
        '
        'cbotextstyle
        '
        Me.cbotextstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotextstyle.Location = New System.Drawing.Point(80, 200)
        Me.cbotextstyle.Name = "cbotextstyle"
        Me.cbotextstyle.Size = New System.Drawing.Size(112, 22)
        Me.cbotextstyle.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 200)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 24)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Text Style"
        '
        'chkshowtext
        '
        Me.chkshowtext.Checked = True
        Me.chkshowtext.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkshowtext.Location = New System.Drawing.Point(32, 560)
        Me.chkshowtext.Name = "chkshowtext"
        Me.chkshowtext.Size = New System.Drawing.Size(80, 16)
        Me.chkshowtext.TabIndex = 15
        Me.chkshowtext.Text = "Show Text"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.Location = New System.Drawing.Point(128, 560)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(160, 32)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Update the text"
        '
        'txttext2
        '
        Me.txttext2.Location = New System.Drawing.Point(72, 128)
        Me.txttext2.Name = "txttext2"
        Me.txttext2.Size = New System.Drawing.Size(128, 20)
        Me.txttext2.TabIndex = 13
        Me.txttext2.Text = "www.viscomsoft.com"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(16, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Text 2"
        '
        'txttext1
        '
        Me.txttext1.Location = New System.Drawing.Point(72, 104)
        Me.txttext1.Name = "txttext1"
        Me.txttext1.Size = New System.Drawing.Size(128, 20)
        Me.txttext1.TabIndex = 11
        Me.txttext1.Text = "Viscom Software"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(16, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 24)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Text 1"
        '
        'txtTextTop
        '
        Me.txtTextTop.Location = New System.Drawing.Point(168, 80)
        Me.txtTextTop.Name = "txtTextTop"
        Me.txtTextTop.Size = New System.Drawing.Size(32, 20)
        Me.txtTextTop.TabIndex = 9
        Me.txtTextTop.Text = "0"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(120, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Top"
        '
        'txtTextLeft
        '
        Me.txtTextLeft.Location = New System.Drawing.Point(72, 80)
        Me.txtTextLeft.Name = "txtTextLeft"
        Me.txtTextLeft.Size = New System.Drawing.Size(32, 20)
        Me.txtTextLeft.TabIndex = 7
        Me.txtTextLeft.Text = "0"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 24)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Left"
        '
        'cbofontstyle
        '
        Me.cbofontstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofontstyle.Location = New System.Drawing.Point(88, 48)
        Me.cbofontstyle.Name = "cbofontstyle"
        Me.cbofontstyle.Size = New System.Drawing.Size(112, 22)
        Me.cbofontstyle.TabIndex = 5
        '
        'cbofontsize
        '
        Me.cbofontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofontsize.Location = New System.Drawing.Point(264, 24)
        Me.cbofontsize.Name = "cbofontsize"
        Me.cbofontsize.Size = New System.Drawing.Size(64, 22)
        Me.cbofontsize.TabIndex = 4
        '
        'cbofont
        '
        Me.cbofont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofont.Location = New System.Drawing.Point(88, 24)
        Me.cbofont.Name = "cbofont"
        Me.cbofont.Size = New System.Drawing.Size(112, 22)
        Me.cbofont.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Font Style"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(200, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 24)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Font Size"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Font Name"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(8, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(496, 576)
        Me.AxImageViewer1.TabIndex = 54
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(888, 694)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.cbooutputtype)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overlay Text"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public clrtrancolor As Color
    Dim clrHashForeColor As Color
    Dim clrHashBackColor As Color
   
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim strFile As Object
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif|PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"
	
	  

    

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Me.AxImageViewer1.ShowImage = True

            Me.AxImageViewer1.FileName = OpenFileDialog1.FileName

            Text1.Text = CStr(AxImageViewer1.FileWidth)
            Text2.Text = CStr(AxImageViewer1.FileHeight)

            

        End If



    End Sub
    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

     

    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            clrtrancolor = ColorDialog1.Color
        End If

    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        

    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = cbooutputtype.Items(cbooutputtype.SelectedIndex)

        If strType = "ICO" Then
            iResult = AxImageViewer1.SaveBySize(strFile, "ico", 32, 32)

        Else
            iResult = AxImageViewer1.Save(strFile, strType)

        End If

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        End If


    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        clrtrancolor = Color.FromArgb(0, 0, 0)


        cbooutputtype.Items.Add("Bmp")
        cbooutputtype.Items.Add("JPG")
        cbooutputtype.Items.Add("TIF")
        cbooutputtype.Items.Add("PDF")
        cbooutputtype.Items.Add("WBMP")
        cbooutputtype.Items.Add("GIF")
        cbooutputtype.Items.Add("PCX")
        cbooutputtype.Items.Add("TGA")
        cbooutputtype.Items.Add("ICO")
        cbooutputtype.Items.Add("JP2")
        cbooutputtype.Items.Add("JPC")
        cbooutputtype.Items.Add("RAS")
        cbooutputtype.Items.Add("PGX")
        cbooutputtype.Items.Add("PNM")
        cbooutputtype.Items.Add("PNG")
        cbooutputtype.SelectedIndex = 1
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode

        clrHashForeColor = Color.FromArgb(255, 255, 255)
        clrHashBackColor = Color.FromArgb(0, 0, 0)

        cbohashbrushstyle.Items.Add("HatchStyleHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleForwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleBackwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleCross ")
        cbohashbrushstyle.Items.Add("HatchStyleDiagonalCross ")
        cbohashbrushstyle.Items.Add("HatchStyle05Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle10Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle20Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle25Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle30Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle40Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle50Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle60Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle70Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle75Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle80Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle90Percent ")
        cbohashbrushstyle.Items.Add("HatchStyleLightDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleLightUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleWideDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleWideUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleLightVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleLightHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleNarrowVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleNarrowHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallConfetti ")
        cbohashbrushstyle.Items.Add("HatchStyleLargeConfetti ")
        cbohashbrushstyle.Items.Add("HatchStyleZigZag ")
        cbohashbrushstyle.Items.Add("HatchStyleWave ")
        cbohashbrushstyle.Items.Add("HatchStyleDiagonalBrick ")
        cbohashbrushstyle.Items.Add("HatchStyleHorizontalBrick ")
        cbohashbrushstyle.Items.Add("HatchStyleWeave ")
        cbohashbrushstyle.Items.Add("HatchStylePlaid ")
        cbohashbrushstyle.Items.Add("HatchStyleDivot ")
        cbohashbrushstyle.Items.Add("HatchStyleDottedGrid ")
        cbohashbrushstyle.Items.Add("HatchStyleDottedDiamond ")
        cbohashbrushstyle.Items.Add("HatchStyleShingle ")
        cbohashbrushstyle.Items.Add("HatchStyleTrellis ")
        cbohashbrushstyle.Items.Add("HatchStyleSphere ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallGrid ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallCheckerBoard ")
        cbohashbrushstyle.Items.Add("HatchStyleLargeCheckerBoard ")
        cbohashbrushstyle.Items.Add("HatchStyleOutlinedDiamond ")
        cbohashbrushstyle.Items.Add("HatchStyleSolidDiamond ")
        cbohashbrushstyle.SelectedIndex = 0

        cbofont.Items.Add("Arial")
        cbofont.Items.Add("Arial Black")
        cbofont.Items.Add("Comic Sans MS")
        cbofont.Items.Add("Times New Roman")
        cbofont.SelectedIndex = 0

        For i = 8 To 60 Step 2
            cbofontsize.Items.Add(Trim(CStr(i)))
        Next
        cbofontsize.SelectedIndex = 2

        cbotextstyle.Items.Add("Normal")
        cbotextstyle.Items.Add("Outline")
        cbotextstyle.Items.Add("Filled Outline")
        cbotextstyle.Items.Add("Hash Brush")
        cbotextstyle.Items.Add("Texture Brush")
        cbotextstyle.SelectedIndex = 0


        cbofontstyle.Items.Add("Regular")
        cbofontstyle.Items.Add("Bold")
        cbofontstyle.Items.Add("Italic")
        cbofontstyle.Items.Add("BoldItalic")
        cbofontstyle.Items.Add("Underline")
        cbofontstyle.SelectedIndex = 0

    End Sub


    Private Sub cmdtextureimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtextureimage.Click
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif|PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"




        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            txttextureimage.Text = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AxImageViewer1.ResetDefaultImage(False)
        AxImageViewer1.DrawText(txtTextLeft.Text, txtTextTop.Text, txttext1.Text + Chr(13) + Chr(10) + txttext2.Text, True)

    End Sub

    Private Sub cbofont_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofont.SelectedIndexChanged
        AxImageViewer1.TextFontName = cbofont.Items(cbofont.SelectedIndex)
    End Sub

    Private Sub cbofontsize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofontsize.SelectedIndexChanged
        AxImageViewer1.TextFontSize = Val(cbofontsize.Items(cbofontsize.SelectedIndex))
    End Sub

    Private Sub cbofontstyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofontstyle.SelectedIndexChanged
        AxImageViewer1.TextFontStyle = cbofontstyle.SelectedIndex

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        AxImageViewer1.TextAlphaValue = TrackBar1.Value

    End Sub

    Private Sub cmdtextcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtextcolor.Click
        If ColorDialog1.ShowDialog() Then
            AxImageViewer1.TextColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub cmdoutlineborder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutlineborder.Click
        If ColorDialog1.ShowDialog() Then
            AxImageViewer1.SetOutlineTextBorderColor(Color2Uint32(ColorDialog1.Color))
        End If

    End Sub

    Private Sub cmdoutlineback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutlineback.Click
        If ColorDialog1.ShowDialog() Then
            AxImageViewer1.SetOutlineTextBackColor(Color2Uint32(ColorDialog1.Color))
        End If

    End Sub

    Private Sub cbohashbrushstyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbohashbrushstyle.SelectedIndexChanged
        AxImageViewer1.SetHashBrushValue(cbohashbrushstyle.SelectedIndex, Color2Uint32(clrHashForeColor), Color2Uint32(clrHashBackColor))

    End Sub

    Private Sub cmdhashforecolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhashforecolor.Click
        If ColorDialog1.ShowDialog() Then
            clrHashForeColor = ColorDialog1.Color
            AxImageViewer1.SetHashBrushValue(cbohashbrushstyle.SelectedIndex, Color2Uint32(clrHashForeColor), Color2Uint32(clrHashBackColor))
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If ColorDialog1.ShowDialog() Then
            clrHashBackColor = ColorDialog1.Color
            AxImageViewer1.SetHashBrushValue(cbohashbrushstyle.SelectedIndex, Color2Uint32(clrHashForeColor), Color2Uint32(clrHashBackColor))
        End If

    End Sub

    Private Sub chkshowtext_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkshowtext.CheckedChanged

    End Sub

    Private Sub chkshowtext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkshowtext.Click
        If chkshowtext.Checked Then
            AxImageViewer1.ShowText = True
        Else
            AxImageViewer1.ShowText = False
        End If
    End Sub

    Private Sub cbotextstyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotextstyle.SelectedIndexChanged
        Select Case cbotextstyle.SelectedIndex

            Case 0
                cmdtextcolor.Enabled = True
                cmdoutlineborder.Enabled = False
                cmdoutlineback.Enabled = False
                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False
                cmdtextureimage.Enabled = False
            Case 1
                cmdtextcolor.Enabled = False
                cmdoutlineborder.Enabled = True
                cmdoutlineback.Enabled = False
                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False
                cmdtextureimage.Enabled = False

            Case 2
                cmdtextcolor.Enabled = False
                cmdoutlineborder.Enabled = True
                cmdoutlineback.Enabled = True
                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False
                cmdtextureimage.Enabled = False

            Case 3
                cmdtextcolor.Enabled = False
                cmdoutlineborder.Enabled = False
                cmdoutlineback.Enabled = False
                cbohashbrushstyle.Enabled = True
                cmdhashforecolor.Enabled = True
                cmdhashbackcolor.Enabled = True
                cmdtextureimage.Enabled = False

            Case 4

                cmdtextcolor.Enabled = False
                cmdoutlineborder.Enabled = False
                cmdoutlineback.Enabled = False
                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False
                cmdtextureimage.Enabled = True

                If txttextureimage.Text = "" Then
                    MsgBox("Please select texture brush")
                    Exit Sub
                End If

                AxImageViewer1.SetTextureBrushImage(txttextureimage.Text)


        End Select


        AxImageViewer1.TextStyle = cbotextstyle.SelectedIndex

    End Sub
End Class