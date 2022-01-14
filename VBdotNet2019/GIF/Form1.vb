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
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents chkdiffusion As System.Windows.Forms.CheckBox
	Public WithEvents cbogifquantizer As System.Windows.Forms.ComboBox
	Public WithEvents cbomaxcolor As System.Windows.Forms.ComboBox
	Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ImageViewer1 As AxSCRIBBLELib.AxImageViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command3 = New System.Windows.Forms.Button
        Me.chkdiffusion = New System.Windows.Forms.CheckBox
        Me.cbogifquantizer = New System.Windows.Forms.ComboBox
        Me.cbomaxcolor = New System.Windows.Forms.ComboBox
        Me.Command2 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.ImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        CType(Me.ImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Enabled = False
        Me.Command3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(120, 216)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(81, 17)
        Me.Command3.TabIndex = 9
        Me.Command3.Text = "Select Color"
        '
        'chkdiffusion
        '
        Me.chkdiffusion.BackColor = System.Drawing.SystemColors.Control
        Me.chkdiffusion.Checked = True
        Me.chkdiffusion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkdiffusion.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkdiffusion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdiffusion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkdiffusion.Location = New System.Drawing.Point(16, 184)
        Me.chkdiffusion.Name = "chkdiffusion"
        Me.chkdiffusion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkdiffusion.Size = New System.Drawing.Size(120, 17)
        Me.chkdiffusion.TabIndex = 7
        Me.chkdiffusion.Text = "Error Diffusion"
        '
        'cbogifquantizer
        '
        Me.cbogifquantizer.BackColor = System.Drawing.SystemColors.Window
        Me.cbogifquantizer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbogifquantizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogifquantizer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogifquantizer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbogifquantizer.Location = New System.Drawing.Point(112, 152)
        Me.cbogifquantizer.Name = "cbogifquantizer"
        Me.cbogifquantizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbogifquantizer.Size = New System.Drawing.Size(81, 22)
        Me.cbogifquantizer.TabIndex = 6
        '
        'cbomaxcolor
        '
        Me.cbomaxcolor.BackColor = System.Drawing.SystemColors.Window
        Me.cbomaxcolor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbomaxcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomaxcolor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomaxcolor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbomaxcolor.Location = New System.Drawing.Point(112, 120)
        Me.cbomaxcolor.Name = "cbomaxcolor"
        Me.cbomaxcolor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbomaxcolor.Size = New System.Drawing.Size(81, 22)
        Me.cbomaxcolor.TabIndex = 4
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(16, 256)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(129, 25)
        Me.Command2.TabIndex = 2
        Me.Command2.Text = "Save as GIF"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(8, 64)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(129, 25)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Select Image File"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Transparent color"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Quantizer"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GIF Max Color"
        '
        'ImageViewer1
        '
        Me.ImageViewer1.Enabled = True
        Me.ImageViewer1.Location = New System.Drawing.Point(232, 32)
        Me.ImageViewer1.Name = "ImageViewer1"
        Me.ImageViewer1.OcxState = CType(resources.GetObject("ImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImageViewer1.Size = New System.Drawing.Size(464, 368)
        Me.ImageViewer1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(711, 436)
        Me.Controls.Add(Me.ImageViewer1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.chkdiffusion)
        Me.Controls.Add(Me.cbogifquantizer)
        Me.Controls.Add(Me.cbomaxcolor)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.ImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim clrtrancolor As Color
	
	'UPGRADE_WARNING: Event chkdiffusion.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkdiffusion_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkdiffusion.CheckStateChanged
		
		
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"

		
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            ImageViewer1.HighQuality = True

            ImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode

            ImageViewer1.FileName = OpenFileDialog1.FileName

            ImageViewer1.View = 9
        End If

		
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim a As Integer
		
        ImageViewer1.GIFMaxColor = Val(cbomaxcolor.Items(cbomaxcolor.SelectedIndex))
		ImageViewer1.GIFQuantizer = cbogifquantizer.SelectedIndex
		
		If chkdiffusion.CheckState = 0 Then
            ImageViewer1.GIFErrorDiffusion = chkdiffusion.Checked
			
            ImageViewer1.GIFTranColor = clrtrancolor
		Else
            ImageViewer1.GIFErrorDiffusion = chkdiffusion.Checked
		End If
		
		a = ImageViewer1.Save("c:\testgif", "gif")
		
		If a = 1 Then
			MsgBox("Save Completed")
		Else
			MsgBox("Save Failed")
		End If
		
	End Sub
	
	Private Sub Command22_Click()
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        ColorDialog1.ShowDialog()
        clrtrancolor = ColorDialog1.Color
	End Sub
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		cbomaxcolor.Items.Add("16")
		cbomaxcolor.Items.Add("32")
		cbomaxcolor.Items.Add("64")
		cbomaxcolor.Items.Add("128")
		cbomaxcolor.Items.Add("256")
		cbomaxcolor.SelectedIndex = 4
		
		cbogifquantizer.Items.Add("Basic")
		cbogifquantizer.Items.Add("Octree")
		cbogifquantizer.Items.Add("Mediancut")
		cbogifquantizer.Items.Add("NeuralNet")
		cbogifquantizer.SelectedIndex = 1
	End Sub

    Private Sub chkdiffusion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdiffusion.CheckedChanged
        If chkdiffusion.Checked Then
            Command3.Enabled = False
        Else
            Command3.Enabled = True
        End If
    End Sub
End Class