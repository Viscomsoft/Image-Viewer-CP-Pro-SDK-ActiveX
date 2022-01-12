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
    Public WithEvents cbooutputtype As System.Windows.Forms.ComboBox
	Public WithEvents Command5 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label6 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbooutputtype = New System.Windows.Forms.ComboBox
        Me.Command5 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbooutputtype
        '
        Me.cbooutputtype.BackColor = System.Drawing.SystemColors.Window
        Me.cbooutputtype.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbooutputtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputtype.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbooutputtype.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbooutputtype.Location = New System.Drawing.Point(512, 88)
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
        Me.Command5.Location = New System.Drawing.Point(432, 128)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(288, 33)
        Me.Command5.TabIndex = 15
        Me.Command5.Text = "Rotate all pages to 90 degree and save the image"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(424, 32)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Select Image"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(432, 88)
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
        Me.AxImageViewer1.Size = New System.Drawing.Size(392, 440)
        Me.AxImageViewer1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(432, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(288, 33)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Rotate first page to 90 degree only and save the image"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(432, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(288, 33)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Rotate page 1 and page 3  to 90 degree only and save the image"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(785, 492)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.cbooutputtype)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Rotate Multipage TIFF/PDF files"
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

        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|TIF (*.tif)|*.tif"
	

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

          
            Me.AxImageViewer1.FileName = OpenFileDialog1.FileName

            AxImageViewer1.View = 12

            

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

 

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = cbooutputtype.Items(cbooutputtype.SelectedIndex)

        AxImageViewer1.ClearRotateMultiPageOnly()
        AxImageViewer1.RotateMultiPage(SCRIBBLELib.ROTATE_TYPE.MRotate90FlipNone)

        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        Else
            MsgBox("Save failed, please select image first")
        End If


    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        clrtrancolor = Color.FromArgb(0, 0, 0)


     
        cbooutputtype.Items.Add("tif")
        cbooutputtype.Items.Add("pdf")
      
        cbooutputtype.SelectedIndex = 1
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.NoSelectionRectMode

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = cbooutputtype.Items(cbooutputtype.SelectedIndex)

        AxImageViewer1.ClearRotateMultiPageOnly()
        AxImageViewer1.RotateMultiPageOnly(0, SCRIBBLELib.ROTATE_TYPE.MRotate90FlipNone)
       

        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        Else
            MsgBox("Save failed, please select image first")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        strFile = "c:\test"
        strType = cbooutputtype.Items(cbooutputtype.SelectedIndex)

        AxImageViewer1.ClearRotateMultiPageOnly()
        AxImageViewer1.RotateMultiPageOnly(0, SCRIBBLELib.ROTATE_TYPE.MRotate90FlipNone)
        AxImageViewer1.RotateMultiPageOnly(2, SCRIBBLELib.ROTATE_TYPE.MRotate90FlipNone)


        iResult = AxImageViewer1.Save(strFile, strType)

        If iResult = 1 Then
            MsgBox("Save " + strFile + "." + strType + " Complete")
        Else
            MsgBox("Save failed, please select image first")
        End If
    End Sub
End Class