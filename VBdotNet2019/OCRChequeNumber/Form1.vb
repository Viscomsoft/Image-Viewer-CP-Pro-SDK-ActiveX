Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim strApp As String
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
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotpage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPageNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optmode1 As System.Windows.Forms.RadioButton
    Friend WithEvents optmode2 As System.Windows.Forms.RadioButton
    Friend WithEvents optmode3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optfilter1 As System.Windows.Forms.RadioButton
    Friend WithEvents optfilter2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkfullpage As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtleft As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttop As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfilewidth As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfileheight As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents optfilter4 As System.Windows.Forms.RadioButton
    Friend WithEvents optfilter3 As System.Windows.Forms.RadioButton
    Friend WithEvents optoutput1 As System.Windows.Forms.RadioButton
    Friend WithEvents optoutput2 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdprevpage As System.Windows.Forms.Button
    Friend WithEvents cmdnextpage As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents OptMode As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkuseadvpdf As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttotpage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPageNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optmode3 = New System.Windows.Forms.RadioButton()
        Me.optmode2 = New System.Windows.Forms.RadioButton()
        Me.optmode1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optfilter4 = New System.Windows.Forms.RadioButton()
        Me.optfilter3 = New System.Windows.Forms.RadioButton()
        Me.optfilter2 = New System.Windows.Forms.RadioButton()
        Me.optfilter1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfileheight = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.OptMode = New System.Windows.Forms.RadioButton()
        Me.txtfilewidth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttop = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtleft = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkfullpage = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optoutput2 = New System.Windows.Forms.RadioButton()
        Me.optoutput1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdprevpage = New System.Windows.Forms.Button()
        Me.cmdnextpage = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.chkuseadvpdf = New System.Windows.Forms.CheckBox()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(13, 154)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(980, 328)
        Me.AxImageViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select Image"
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(13, 100)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(413, 21)
        Me.txtfilename.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Page"
        '
        'txttotpage
        '
        Me.txttotpage.Location = New System.Drawing.Point(99, 126)
        Me.txttotpage.Name = "txttotpage"
        Me.txttotpage.Size = New System.Drawing.Size(68, 21)
        Me.txttotpage.TabIndex = 4
        Me.txttotpage.Text = "1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(186, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Page No"
        '
        'txtPageNo
        '
        Me.txtPageNo.Location = New System.Drawing.Point(282, 126)
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.Size = New System.Drawing.Size(57, 21)
        Me.txtPageNo.TabIndex = 6
        Me.txtPageNo.Text = "1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optmode3)
        Me.GroupBox1.Controls.Add(Me.optmode2)
        Me.GroupBox1.Controls.Add(Me.optmode1)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 95)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recognize Mode"
        '
        'optmode3
        '
        Me.optmode3.Checked = True
        Me.optmode3.Location = New System.Drawing.Point(10, 69)
        Me.optmode3.Name = "optmode3"
        Me.optmode3.Size = New System.Drawing.Size(122, 17)
        Me.optmode3.TabIndex = 2
        Me.optmode3.TabStop = True
        Me.optmode3.Text = "Excellent"
        '
        'optmode2
        '
        Me.optmode2.Location = New System.Drawing.Point(10, 43)
        Me.optmode2.Name = "optmode2"
        Me.optmode2.Size = New System.Drawing.Size(105, 17)
        Me.optmode2.TabIndex = 1
        Me.optmode2.Text = "Normal"
        '
        'optmode1
        '
        Me.optmode1.Location = New System.Drawing.Point(10, 17)
        Me.optmode1.Name = "optmode1"
        Me.optmode1.Size = New System.Drawing.Size(67, 17)
        Me.optmode1.TabIndex = 0
        Me.optmode1.Text = "Fast"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optfilter4)
        Me.GroupBox2.Controls.Add(Me.optfilter3)
        Me.GroupBox2.Controls.Add(Me.optfilter2)
        Me.GroupBox2.Controls.Add(Me.optfilter1)
        Me.GroupBox2.Location = New System.Drawing.Point(611, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(485, 78)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Character Filter"
        '
        'optfilter4
        '
        Me.optfilter4.Location = New System.Drawing.Point(190, 43)
        Me.optfilter4.Name = "optfilter4"
        Me.optfilter4.Size = New System.Drawing.Size(268, 17)
        Me.optfilter4.TabIndex = 3
        Me.optfilter4.Text = "Recognize lowercase only"
        '
        'optfilter3
        '
        Me.optfilter3.Location = New System.Drawing.Point(190, 17)
        Me.optfilter3.Name = "optfilter3"
        Me.optfilter3.Size = New System.Drawing.Size(288, 17)
        Me.optfilter3.TabIndex = 2
        Me.optfilter3.Text = "Recognize uppercase only"
        '
        'optfilter2
        '
        Me.optfilter2.Location = New System.Drawing.Point(10, 43)
        Me.optfilter2.Name = "optfilter2"
        Me.optfilter2.Size = New System.Drawing.Size(268, 17)
        Me.optfilter2.TabIndex = 1
        Me.optfilter2.Text = "Recognize numeric only "
        '
        'optfilter1
        '
        Me.optfilter1.Checked = True
        Me.optfilter1.Location = New System.Drawing.Point(10, 17)
        Me.optfilter1.Name = "optfilter1"
        Me.optfilter1.Size = New System.Drawing.Size(172, 17)
        Me.optfilter1.TabIndex = 0
        Me.optfilter1.TabStop = True
        Me.optfilter1.Text = "No Filter"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtfileheight)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.txtfilewidth)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txttop)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtleft)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.chkfullpage)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 500)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(369, 109)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Zone"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(19, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(365, 50)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "You may draw the selection rectangle on image and click Start Regcognize button"
        '
        'txtfileheight
        '
        Me.txtfileheight.Location = New System.Drawing.Point(283, 52)
        Me.txtfileheight.Name = "txtfileheight"
        Me.txtfileheight.Size = New System.Drawing.Size(38, 21)
        Me.txtfileheight.TabIndex = 9
        Me.txtfileheight.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(239, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Height"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton2)
        Me.GroupBox6.Controls.Add(Me.OptMode)
        Me.GroupBox6.Location = New System.Drawing.Point(334, 92)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(432, 52)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(202, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(192, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Blocking Mode"
        '
        'OptMode
        '
        Me.OptMode.Checked = True
        Me.OptMode.Location = New System.Drawing.Point(29, 26)
        Me.OptMode.Name = "OptMode"
        Me.OptMode.Size = New System.Drawing.Size(153, 17)
        Me.OptMode.TabIndex = 0
        Me.OptMode.TabStop = True
        Me.OptMode.Text = "Asynchronous Mode"
        '
        'txtfilewidth
        '
        Me.txtfilewidth.Location = New System.Drawing.Point(197, 52)
        Me.txtfilewidth.Name = "txtfilewidth"
        Me.txtfilewidth.Size = New System.Drawing.Size(38, 21)
        Me.txtfilewidth.TabIndex = 7
        Me.txtfilewidth.Text = "0"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(149, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Width"
        '
        'txttop
        '
        Me.txttop.Location = New System.Drawing.Point(111, 52)
        Me.txttop.Name = "txttop"
        Me.txttop.Size = New System.Drawing.Size(38, 21)
        Me.txttop.TabIndex = 5
        Me.txttop.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(85, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Top"
        '
        'txtleft
        '
        Me.txtleft.Location = New System.Drawing.Point(41, 52)
        Me.txtleft.Name = "txtleft"
        Me.txtleft.Size = New System.Drawing.Size(38, 21)
        Me.txtleft.TabIndex = 3
        Me.txtleft.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Left"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(94, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "uncheck this button recognize for specific zone"
        '
        'chkfullpage
        '
        Me.chkfullpage.Checked = True
        Me.chkfullpage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfullpage.Location = New System.Drawing.Point(19, 17)
        Me.chkfullpage.Name = "chkfullpage"
        Me.chkfullpage.Size = New System.Drawing.Size(96, 26)
        Me.chkfullpage.TabIndex = 0
        Me.chkfullpage.Text = "Full Page"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optoutput2)
        Me.GroupBox5.Controls.Add(Me.optoutput1)
        Me.GroupBox5.Location = New System.Drawing.Point(387, 500)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(301, 86)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Output"
        '
        'optoutput2
        '
        Me.optoutput2.Location = New System.Drawing.Point(8, 52)
        Me.optoutput2.Name = "optoutput2"
        Me.optoutput2.Size = New System.Drawing.Size(272, 26)
        Me.optoutput2.TabIndex = 1
        Me.optoutput2.Text = "Write the recognized text to text file"
        '
        'optoutput1
        '
        Me.optoutput1.Checked = True
        Me.optoutput1.Location = New System.Drawing.Point(8, 26)
        Me.optoutput1.Name = "optoutput1"
        Me.optoutput1.Size = New System.Drawing.Size(238, 26)
        Me.optoutput1.TabIndex = 0
        Me.optoutput1.TabStop = True
        Me.optoutput1.Text = "Display the recognized text"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(745, 496)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 52)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Start Recognize"
        '
        'cmdprevpage
        '
        Me.cmdprevpage.Location = New System.Drawing.Point(215, 57)
        Me.cmdprevpage.Name = "cmdprevpage"
        Me.cmdprevpage.Size = New System.Drawing.Size(57, 25)
        Me.cmdprevpage.TabIndex = 17
        Me.cmdprevpage.Text = "<<"
        '
        'cmdnextpage
        '
        Me.cmdnextpage.Location = New System.Drawing.Point(291, 57)
        Me.cmdnextpage.Name = "cmdnextpage"
        Me.cmdnextpage.Size = New System.Drawing.Size(58, 25)
        Me.cmdnextpage.TabIndex = 18
        Me.cmdnextpage.Text = ">>"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(17, 615)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 26)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Recognized Character"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(238, 615)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 21)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "0"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(745, 557)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 52)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Stop"
        '
        'chkuseadvpdf
        '
        Me.chkuseadvpdf.AutoSize = True
        Me.chkuseadvpdf.Location = New System.Drawing.Point(19, 12)
        Me.chkuseadvpdf.Name = "chkuseadvpdf"
        Me.chkuseadvpdf.Size = New System.Drawing.Size(162, 16)
        Me.chkuseadvpdf.TabIndex = 23
        Me.chkuseadvpdf.Text = "Use Advanced PDF Viewer"
        Me.chkuseadvpdf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1276, 682)
        Me.Controls.Add(Me.chkuseadvpdf)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdprevpage)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPageNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotpage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfilename)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdnextpage)
        Me.Name = "Form1"
        Me.Text = "OCR Cheque number"
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strFile As String
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtfilename.Text = OpenFileDialog1.FileName

            strFile = OpenFileDialog1.FileName

            Me.chkfullpage.Checked = True

            If strFile.Substring(strFile.Length - 3, 3) = "tif" Or strFile.Substring(strFile.Length - 3, 3) = "pdf" Or strFile.Substring(strFile.Length - 3, 3) = "iff" Then

                AxImageViewer1.LoadMultiPage(txtfilename.Text, 1)
                txtPageNo.Text = "1"
                txttotpage.Text = CStr(AxImageViewer1.GetTotalPage)
                cmdnextpage.Enabled = True
                cmdprevpage.Enabled = True



            Else
                AxImageViewer1.FileName = strFile
                txtPageNo.Text = "1"
                cmdnextpage.Enabled = False
                cmdprevpage.Enabled = False



            End If
        End If

        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight
        AxImageViewer1.View = 9
        AxImageViewer1.MouseTrackMode = 2
        Button2.Enabled = True
        Button3.Enabled = True

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim iLangIndex As Integer
        Dim iMode As Integer
        Dim iResult As Integer
        Dim bResult As Boolean

        'OCR MICR Cheque Number
        iLangIndex = 99

      
        iMode = 0

        If optmode1.Checked Then
            iMode = 0
        End If

        If optmode2.Checked Then
            iMode = 1
        End If

        If optmode3.Checked Then
            iMode = 2
        End If



        If optfilter1.Checked Then
            Me.AxImageViewer1.OCRCharFilter = ""
        End If

        If optfilter2.Checked Then
            Me.AxImageViewer1.OCRCharFilter = "0123456789"
        End If

        If optfilter3.Checked Then
            Me.AxImageViewer1.OCRCharFilter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        End If

        If optfilter4.Checked Then
            Me.AxImageViewer1.OCRCharFilter = "abcdefghijklmnopqrstuvwxyz"
        End If

        Me.AxImageViewer1.OCRRecognizeMode = iMode


        If chkfullpage.Checked Then

            Me.AxImageViewer1.OCRSetRect(0, 0, 0, 0)
        Else
            Me.AxImageViewer1.OCRSetRect(Val(txtleft.Text), Val(txttop.Text), Val(txtfilewidth.Text), Val(txtfileheight.Text))

        End If

        If OptMode.Checked = True Then
            Me.AxImageViewer1.OCRScanTextAsync(True)
        Else
            Me.AxImageViewer1.OCRScanTextAsync(False)
        End If



        iResult = Me.AxImageViewer1.OCRStartScan(iLangIndex, "dictfiles")


        If iResult = -3 Then
            MessageBox.Show("Please select image first")
            Exit Sub
        Else
            If iResult <> 1 Then
                MessageBox.Show("Start OCR Failed")
                Exit Sub
            End If


            If OptMode.Checked = False Then
                TextBox1.Text = AxImageViewer1.OCRGetRecognizedCharCount

                If optoutput1.Checked Then

                    MessageBox.Show(AxImageViewer1.OCRGetRecognizedText)
                    Exit Sub
                End If

                If optoutput2.Checked Then

                    SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"

                    If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                        bResult = AxImageViewer1.OCRSaveRecognizedText(SaveFileDialog1.FileName)

                        If bResult Then
                            MessageBox.Show("Save completed")
                        Else
                            MessageBox.Show("Save failed")
                        End If

                    End If

                    Exit Sub


                End If

            End If


        End If

        Button2.Enabled = False
        Button3.Enabled = True

    End Sub



    Private Sub chkfullpage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfullpage.CheckedChanged


    End Sub

    Private Sub chkfullpage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkfullpage.Click
        If chkfullpage.Checked Then

            AxImageViewer1.MouseTrackMode = 2
        Else
            AxImageViewer1.MouseTrackMode = 1
        End If
    End Sub

    Private Sub cmdnextpage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnextpage.Click
        If txtPageNo.Text < AxImageViewer1.GetTotalPage Then
            txtPageNo.Text = txtPageNo.Text + 1
        Else
            txtPageNo.Text = AxImageViewer1.GetTotalPage
        End If


        Me.AxImageViewer1.LoadMultiPage(txtfilename.Text, txtPageNo.Text)
    End Sub

    Private Sub cmdprevpage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprevpage.Click
        If txtPageNo.Text > 1 Then
            txtPageNo.Text = txtPageNo.Text - 1
        Else
            txtPageNo.Text = 1
        End If

        Me.AxImageViewer1.LoadMultiPage(txtfilename.Text, txtPageNo.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.AxImageViewer1.OCRStopScan()


        Button2.Enabled = True
        Button3.Enabled = False
        TextBox1.Text = 0
    End Sub

    Private Sub AxImageViewer1_SelectionRectDrawn(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent) Handles AxImageViewer1.SelectionRectDrawn
        If Not chkfullpage.Checked Then

            txtleft.Text = e.iLeft
            txttop.Text = e.iTop
            txtfilewidth.Text = e.iWidth
            txtfileheight.Text = e.iHeight
        End If

    End Sub

    Private Sub AxImageViewer1_OCRRecognized(ByVal sender As Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_OCRRecognizedEvent) Handles AxImageViewer1.OCRRecognized
        Dim bresult As Boolean


        If e.bSuccess Then

            TextBox1.Text = AxImageViewer1.OCRGetRecognizedCharCount

            If optoutput1.Checked Then

                MessageBox.Show(AxImageViewer1.OCRGetRecognizedText)
            End If

            If optoutput2.Checked Then

                SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"

                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                    bresult = AxImageViewer1.OCRSaveRecognizedText(SaveFileDialog1.FileName)

                    If bresult Then
                        MessageBox.Show("Save completed")
                    Else
                        MessageBox.Show("Save failed")
                    End If
                End If



            End If



        End If



        Button2.Enabled = True
        Button3.Enabled = False

    End Sub

    Private Sub chkuseadvpdf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkuseadvpdf.CheckedChanged
        If chkuseadvpdf.Checked Then
            Me.AxImageViewer1.PDFUseAdvancedViewer = True
        Else
            Me.AxImageViewer1.PDFUseAdvancedViewer = False

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iFindIndex As Integer
        strApp = Application.ExecutablePath
        iFindIndex = strApp.IndexOf("Examples")

        If iFindIndex <> -1 Then

            strApp = strApp.Substring(0, iFindIndex)

            strApp = strApp + "barcodeimage"
        End If



        AxImageViewer1.FileName = strApp + "\cheque-sample.jpg"
        txtPageNo.Text = "1"
        cmdnextpage.Enabled = False
        cmdprevpage.Enabled = False


        chkfullpage.Checked = False

        txtleft.Text = "293"
        txttop.Text = "673"
        txtfilewidth.Text = "903"
        txtfileheight.Text = "87"
        AxImageViewer1.DrawSelectionRect(293, 673, 903, 97)
        AxImageViewer1.View = 9
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode

    End Sub
End Class
