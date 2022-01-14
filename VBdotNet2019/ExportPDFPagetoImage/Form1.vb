Public Class Form1
    Inherits System.Windows.Forms.Form


    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function
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
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtsourceimage As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpageno As System.Windows.Forms.TextBox
    Friend WithEvents cbopdfscale As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsourceimage = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpageno = New System.Windows.Forms.TextBox()
        Me.cbopdfscale = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(1326, 24)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(82, 96)
        Me.AxImageViewer1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(457, 68)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Export PDF Page"
        '
        'txtsourceimage
        '
        Me.txtsourceimage.Enabled = False
        Me.txtsourceimage.Location = New System.Drawing.Point(54, 64)
        Me.txtsourceimage.Name = "txtsourceimage"
        Me.txtsourceimage.Size = New System.Drawing.Size(811, 35)
        Me.txtsourceimage.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(910, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(249, 52)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Select PDF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Page"
        '
        'txtpageno
        '
        Me.txtpageno.Location = New System.Drawing.Point(186, 140)
        Me.txtpageno.Name = "txtpageno"
        Me.txtpageno.Size = New System.Drawing.Size(217, 35)
        Me.txtpageno.TabIndex = 19
        Me.txtpageno.Text = "1"
        '
        'cbopdfscale
        '
        Me.cbopdfscale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopdfscale.FormattingEnabled = True
        Me.cbopdfscale.Location = New System.Drawing.Point(186, 211)
        Me.cbopdfscale.Name = "cbopdfscale"
        Me.cbopdfscale.Size = New System.Drawing.Size(263, 32)
        Me.cbopdfscale.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "PDF Scale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(586, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "You can export to BMP, JPEG, TIF, PNG, GIF image"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(13, 28)
        Me.ClientSize = New System.Drawing.Size(1518, 555)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbopdfscale)
        Me.Controls.Add(Me.txtpageno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtsourceimage)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Export PDF Page to Image"
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer


        cbopdfscale.Items.Add("0.5")
        cbopdfscale.Items.Add("1.3")
        cbopdfscale.Items.Add("2.0")
        cbopdfscale.Items.Add("2.5")
        cbopdfscale.Items.Add("3.0")
        cbopdfscale.SelectedIndex = 1



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtsourceimage.Text = "" Then
            MessageBox.Show("Please select the PDF file first")
            Exit Sub
        End If

        SaveFileDialog1.Filter = "BMP Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|TIF Files (*.tif)|*.tif|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif||"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            '  AxImageViewer1.TIFCompression = SCRIBBLELib.TIF_COMPRESSION.CompressionCCITT3

            AxImageViewer1.PDFEditGetBitmapBySize(txtsourceimage.Text, txtpageno.Text, cbopdfscale.Text, SaveFileDialog1.FileName)
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf"





        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            AxImageViewer1.PDFUseAdvancedViewer = True

            txtsourceimage.Text = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub chkdrawbarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

   
End Class
