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
    Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents txtImage As System.Windows.Forms.TextBox
	Public WithEvents txtTop As System.Windows.Forms.TextBox
	Public WithEvents txtLeft As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.cbooutputtype = New System.Windows.Forms.ComboBox
        Me.Command5 = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.Command4 = New System.Windows.Forms.Button
        Me.Command3 = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.txtImage = New System.Windows.Forms.TextBox
        Me.txtTop = New System.Windows.Forms.TextBox
        Me.txtLeft = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Command1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Frame1.SuspendLayout()
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
        Me.Text2.Location = New System.Drawing.Point(640, 16)
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
        Me.Text1.Location = New System.Drawing.Point(488, 16)
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
        Me.cbooutputtype.Location = New System.Drawing.Point(176, 384)
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
        Me.Command5.Location = New System.Drawing.Point(288, 376)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(81, 33)
        Me.Command5.TabIndex = 15
        Me.Command5.Text = "Save"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.TrackBar1)
        Me.Frame1.Controls.Add(Me.Command4)
        Me.Frame1.Controls.Add(Me.Command3)
        Me.Frame1.Controls.Add(Me.Command2)
        Me.Frame1.Controls.Add(Me.txtImage)
        Me.Frame1.Controls.Add(Me.txtTop)
        Me.Frame1.Controls.Add(Me.txtLeft)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(424, 40)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(337, 256)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Overlay image"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(64, 120)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(264, 45)
        Me.TrackBar1.TabIndex = 15
        Me.TrackBar1.Value = 255
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.Color.Red
        Me.Command4.Location = New System.Drawing.Point(48, 208)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(168, 32)
        Me.Command4.TabIndex = 14
        Me.Command4.Text = "Update the Image"
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(120, 168)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(65, 17)
        Me.Command3.TabIndex = 13
        Me.Command3.Text = "Select Color"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(48, 88)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 17)
        Me.Command2.TabIndex = 10
        Me.Command2.Text = "Select Image"
        '
        'txtImage
        '
        Me.txtImage.AcceptsReturn = True
        Me.txtImage.AutoSize = False
        Me.txtImage.BackColor = System.Drawing.SystemColors.Window
        Me.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImage.Enabled = False
        Me.txtImage.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtImage.Location = New System.Drawing.Point(48, 56)
        Me.txtImage.MaxLength = 0
        Me.txtImage.Name = "txtImage"
        Me.txtImage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImage.Size = New System.Drawing.Size(281, 19)
        Me.txtImage.TabIndex = 9
        Me.txtImage.Text = ""
        '
        'txtTop
        '
        Me.txtTop.AcceptsReturn = True
        Me.txtTop.AutoSize = False
        Me.txtTop.BackColor = System.Drawing.SystemColors.Window
        Me.txtTop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTop.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTop.Location = New System.Drawing.Point(144, 24)
        Me.txtTop.MaxLength = 0
        Me.txtTop.Name = "txtTop"
        Me.txtTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTop.Size = New System.Drawing.Size(33, 19)
        Me.txtTop.TabIndex = 7
        Me.txtTop.Text = "0"
        '
        'txtLeft
        '
        Me.txtLeft.AcceptsReturn = True
        Me.txtLeft.AutoSize = False
        Me.txtLeft.BackColor = System.Drawing.SystemColors.Window
        Me.txtLeft.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLeft.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeft.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLeft.Location = New System.Drawing.Point(40, 24)
        Me.txtLeft.MaxLength = 0
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLeft.Size = New System.Drawing.Size(33, 19)
        Me.txtLeft.TabIndex = 5
        Me.txtLeft.Text = "0"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Transparent Color"
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
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Alpha"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Image"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(96, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Top"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Left"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(16, 376)
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
        Me.Label8.Location = New System.Drawing.Point(568, 16)
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
        Me.Label7.Location = New System.Drawing.Point(424, 16)
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
        Me.Label6.Location = New System.Drawing.Point(104, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Ouput Format"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(16, 24)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(392, 328)
        Me.AxImageViewer1.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(785, 492)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.cbooutputtype)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Overlay Image"
        Me.Frame1.ResumeLayout(False)
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

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click

        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|JPEG (*.jpg)|*.jpg|WMF (*.wmf)|*.wmf|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|Gif (*.gif)|*.gif|PNG (*.png)|*.png|Icon (*.ico)|*.ico"


       

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            txtImage.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            clrtrancolor = ColorDialog1.Color
        End If

    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click

        If txtImage.Text = "" Then
            MsgBox("please select overlay image")
            Exit Sub
        End If

        AxImageViewer1.ResetDefaultImage(False)


        Me.AxImageViewer1.DrawImage(CShort(txtLeft.Text), CShort(txtTop.Text), txtImage.Text, Color2Uint32(clrtrancolor), TrackBar1.Value)

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

    End Sub

   
End Class