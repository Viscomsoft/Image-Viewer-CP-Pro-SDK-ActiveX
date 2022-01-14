Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpdfajpegquality As System.Windows.Forms.TextBox
    Friend WithEvents chkpdfausejpeg As System.Windows.Forms.CheckBox
    Friend WithEvents cmdprevpage As System.Windows.Forms.Button
    Friend WithEvents cmdnextpage As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents OptAsync As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkuseadvpdf As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optlang42 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang41 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang40 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang39 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang38 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang37 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang36 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang35 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang34 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang33 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang32 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang31 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang30 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang29 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang28 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang27 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang26 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang25 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang24 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang23 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang22 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang21 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang20 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang19 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang18 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang17 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang16 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang15 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang14 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang13 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang12 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang11 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang10 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang9 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang8 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang7 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang6 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang5 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang4 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang3 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang2 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtfontfile As System.Windows.Forms.TextBox
    Friend WithEvents txtfontname As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonFontFile As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFontName As System.Windows.Forms.RadioButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
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
        Me.chkpdfausejpeg = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpdfajpegquality = New System.Windows.Forms.TextBox()
        Me.cmdprevpage = New System.Windows.Forms.Button()
        Me.cmdnextpage = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.OptAsync = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.chkuseadvpdf = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optlang42 = New System.Windows.Forms.RadioButton()
        Me.optlang41 = New System.Windows.Forms.RadioButton()
        Me.optlang40 = New System.Windows.Forms.RadioButton()
        Me.optlang39 = New System.Windows.Forms.RadioButton()
        Me.optlang38 = New System.Windows.Forms.RadioButton()
        Me.optlang37 = New System.Windows.Forms.RadioButton()
        Me.optlang36 = New System.Windows.Forms.RadioButton()
        Me.optlang35 = New System.Windows.Forms.RadioButton()
        Me.optlang34 = New System.Windows.Forms.RadioButton()
        Me.optlang33 = New System.Windows.Forms.RadioButton()
        Me.optlang32 = New System.Windows.Forms.RadioButton()
        Me.optlang31 = New System.Windows.Forms.RadioButton()
        Me.optlang30 = New System.Windows.Forms.RadioButton()
        Me.optlang29 = New System.Windows.Forms.RadioButton()
        Me.optlang28 = New System.Windows.Forms.RadioButton()
        Me.optlang27 = New System.Windows.Forms.RadioButton()
        Me.optlang26 = New System.Windows.Forms.RadioButton()
        Me.optlang25 = New System.Windows.Forms.RadioButton()
        Me.optlang24 = New System.Windows.Forms.RadioButton()
        Me.optlang23 = New System.Windows.Forms.RadioButton()
        Me.optlang22 = New System.Windows.Forms.RadioButton()
        Me.optlang21 = New System.Windows.Forms.RadioButton()
        Me.optlang20 = New System.Windows.Forms.RadioButton()
        Me.optlang19 = New System.Windows.Forms.RadioButton()
        Me.optlang18 = New System.Windows.Forms.RadioButton()
        Me.optlang17 = New System.Windows.Forms.RadioButton()
        Me.optlang16 = New System.Windows.Forms.RadioButton()
        Me.optlang15 = New System.Windows.Forms.RadioButton()
        Me.optlang14 = New System.Windows.Forms.RadioButton()
        Me.optlang13 = New System.Windows.Forms.RadioButton()
        Me.optlang12 = New System.Windows.Forms.RadioButton()
        Me.optlang11 = New System.Windows.Forms.RadioButton()
        Me.optlang10 = New System.Windows.Forms.RadioButton()
        Me.optlang9 = New System.Windows.Forms.RadioButton()
        Me.optlang8 = New System.Windows.Forms.RadioButton()
        Me.optlang7 = New System.Windows.Forms.RadioButton()
        Me.optlang6 = New System.Windows.Forms.RadioButton()
        Me.optlang5 = New System.Windows.Forms.RadioButton()
        Me.optlang4 = New System.Windows.Forms.RadioButton()
        Me.optlang3 = New System.Windows.Forms.RadioButton()
        Me.optlang2 = New System.Windows.Forms.RadioButton()
        Me.optlang1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtfontfile = New System.Windows.Forms.TextBox()
        Me.txtfontname = New System.Windows.Forms.TextBox()
        Me.RadioButtonFontFile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFontName = New System.Windows.Forms.RadioButton()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(0, 3)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(561, 579)
        Me.AxImageViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(586, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select Image"
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(576, 95)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(413, 21)
        Me.txtfilename.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(576, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Page"
        '
        'txttotpage
        '
        Me.txttotpage.Location = New System.Drawing.Point(662, 120)
        Me.txttotpage.Name = "txttotpage"
        Me.txttotpage.Size = New System.Drawing.Size(68, 21)
        Me.txttotpage.TabIndex = 4
        Me.txttotpage.Text = "1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(749, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Page No"
        '
        'txtPageNo
        '
        Me.txtPageNo.Location = New System.Drawing.Point(845, 120)
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
        Me.GroupBox1.Location = New System.Drawing.Point(576, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 95)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recognize Mode"
        '
        'optmode3
        '
        Me.optmode3.Checked = True
        Me.optmode3.Location = New System.Drawing.Point(10, 69)
        Me.optmode3.Name = "optmode3"
        Me.optmode3.Size = New System.Drawing.Size(163, 17)
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
        Me.GroupBox2.Location = New System.Drawing.Point(817, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 76)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Character Filter"
        '
        'optfilter4
        '
        Me.optfilter4.Location = New System.Drawing.Point(216, 43)
        Me.optfilter4.Name = "optfilter4"
        Me.optfilter4.Size = New System.Drawing.Size(269, 17)
        Me.optfilter4.TabIndex = 3
        Me.optfilter4.Text = "Recognize lowercase only"
        '
        'optfilter3
        '
        Me.optfilter3.Location = New System.Drawing.Point(216, 17)
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
        Me.GroupBox4.Controls.Add(Me.txtfilewidth)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txttop)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtleft)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.chkfullpage)
        Me.GroupBox4.Location = New System.Drawing.Point(195, 606)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(394, 120)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Zone"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(19, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(365, 26)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "You may draw the selection rectangle on image and click Start Convert to Searchab" & _
            "le PDF/A Button"
        '
        'txtfileheight
        '
        Me.txtfileheight.Location = New System.Drawing.Point(346, 52)
        Me.txtfileheight.Name = "txtfileheight"
        Me.txtfileheight.Size = New System.Drawing.Size(38, 21)
        Me.txtfileheight.TabIndex = 9
        Me.txtfileheight.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(288, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Height"
        '
        'txtfilewidth
        '
        Me.txtfilewidth.Location = New System.Drawing.Point(240, 52)
        Me.txtfilewidth.Name = "txtfilewidth"
        Me.txtfilewidth.Size = New System.Drawing.Size(38, 21)
        Me.txtfilewidth.TabIndex = 7
        Me.txtfilewidth.Text = "0"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(192, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Width"
        '
        'txttop
        '
        Me.txttop.Location = New System.Drawing.Point(144, 52)
        Me.txttop.Name = "txttop"
        Me.txttop.Size = New System.Drawing.Size(38, 21)
        Me.txttop.TabIndex = 5
        Me.txttop.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(106, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Top"
        '
        'txtleft
        '
        Me.txtleft.Location = New System.Drawing.Point(58, 52)
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
        Me.Label3.Location = New System.Drawing.Point(134, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 26)
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
        Me.GroupBox5.Location = New System.Drawing.Point(602, 613)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(264, 69)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Output"
        '
        'optoutput2
        '
        Me.optoutput2.Location = New System.Drawing.Point(29, 43)
        Me.optoutput2.Name = "optoutput2"
        Me.optoutput2.Size = New System.Drawing.Size(211, 17)
        Me.optoutput2.TabIndex = 1
        Me.optoutput2.Text = "Multi-page searchable PDF/A"
        '
        'optoutput1
        '
        Me.optoutput1.Checked = True
        Me.optoutput1.Location = New System.Drawing.Point(29, 17)
        Me.optoutput1.Name = "optoutput1"
        Me.optoutput1.Size = New System.Drawing.Size(221, 26)
        Me.optoutput1.TabIndex = 0
        Me.optoutput1.TabStop = True
        Me.optoutput1.Text = "Single page searchable PDF/A"
        '
        'chkpdfausejpeg
        '
        Me.chkpdfausejpeg.Location = New System.Drawing.Point(12, 588)
        Me.chkpdfausejpeg.Name = "chkpdfausejpeg"
        Me.chkpdfausejpeg.Size = New System.Drawing.Size(192, 26)
        Me.chkpdfausejpeg.TabIndex = 12
        Me.chkpdfausejpeg.Text = "Use JPEG Compression"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(986, 621)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(288, 61)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Convert to Searchable PDF/A"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(10, 623)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Quality (0-100)"
        '
        'txtpdfajpegquality
        '
        Me.txtpdfajpegquality.Enabled = False
        Me.txtpdfajpegquality.Location = New System.Drawing.Point(112, 623)
        Me.txtpdfajpegquality.Name = "txtpdfajpegquality"
        Me.txtpdfajpegquality.Size = New System.Drawing.Size(77, 21)
        Me.txtpdfajpegquality.TabIndex = 16
        Me.txtpdfajpegquality.Text = "80"
        '
        'cmdprevpage
        '
        Me.cmdprevpage.Location = New System.Drawing.Point(778, 52)
        Me.cmdprevpage.Name = "cmdprevpage"
        Me.cmdprevpage.Size = New System.Drawing.Size(57, 26)
        Me.cmdprevpage.TabIndex = 17
        Me.cmdprevpage.Text = "<<"
        '
        'cmdnextpage
        '
        Me.cmdnextpage.Location = New System.Drawing.Point(854, 52)
        Me.cmdnextpage.Name = "cmdnextpage"
        Me.cmdnextpage.Size = New System.Drawing.Size(58, 26)
        Me.cmdnextpage.TabIndex = 18
        Me.cmdnextpage.Text = ">>"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton2)
        Me.GroupBox6.Controls.Add(Me.OptAsync)
        Me.GroupBox6.Location = New System.Drawing.Point(595, 692)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(307, 43)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Mode"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(192, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(125, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Blocking"
        '
        'OptAsync
        '
        Me.OptAsync.Checked = True
        Me.OptAsync.Location = New System.Drawing.Point(10, 17)
        Me.OptAsync.Name = "OptAsync"
        Me.OptAsync.Size = New System.Drawing.Size(144, 17)
        Me.OptAsync.TabIndex = 0
        Me.OptAsync.TabStop = True
        Me.OptAsync.Text = "Asynchronous"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(986, 692)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(288, 17)
        Me.ProgressBar1.TabIndex = 20
        '
        'chkuseadvpdf
        '
        Me.chkuseadvpdf.AutoSize = True
        Me.chkuseadvpdf.Location = New System.Drawing.Point(577, 6)
        Me.chkuseadvpdf.Name = "chkuseadvpdf"
        Me.chkuseadvpdf.Size = New System.Drawing.Size(162, 16)
        Me.chkuseadvpdf.TabIndex = 21
        Me.chkuseadvpdf.Text = "Use Advanced PDF Viewer"
        Me.chkuseadvpdf.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optlang42)
        Me.GroupBox3.Controls.Add(Me.optlang41)
        Me.GroupBox3.Controls.Add(Me.optlang40)
        Me.GroupBox3.Controls.Add(Me.optlang39)
        Me.GroupBox3.Controls.Add(Me.optlang38)
        Me.GroupBox3.Controls.Add(Me.optlang37)
        Me.GroupBox3.Controls.Add(Me.optlang36)
        Me.GroupBox3.Controls.Add(Me.optlang35)
        Me.GroupBox3.Controls.Add(Me.optlang34)
        Me.GroupBox3.Controls.Add(Me.optlang33)
        Me.GroupBox3.Controls.Add(Me.optlang32)
        Me.GroupBox3.Controls.Add(Me.optlang31)
        Me.GroupBox3.Controls.Add(Me.optlang30)
        Me.GroupBox3.Controls.Add(Me.optlang29)
        Me.GroupBox3.Controls.Add(Me.optlang28)
        Me.GroupBox3.Controls.Add(Me.optlang27)
        Me.GroupBox3.Controls.Add(Me.optlang26)
        Me.GroupBox3.Controls.Add(Me.optlang25)
        Me.GroupBox3.Controls.Add(Me.optlang24)
        Me.GroupBox3.Controls.Add(Me.optlang23)
        Me.GroupBox3.Controls.Add(Me.optlang22)
        Me.GroupBox3.Controls.Add(Me.optlang21)
        Me.GroupBox3.Controls.Add(Me.optlang20)
        Me.GroupBox3.Controls.Add(Me.optlang19)
        Me.GroupBox3.Controls.Add(Me.optlang18)
        Me.GroupBox3.Controls.Add(Me.optlang17)
        Me.GroupBox3.Controls.Add(Me.optlang16)
        Me.GroupBox3.Controls.Add(Me.optlang15)
        Me.GroupBox3.Controls.Add(Me.optlang14)
        Me.GroupBox3.Controls.Add(Me.optlang13)
        Me.GroupBox3.Controls.Add(Me.optlang12)
        Me.GroupBox3.Controls.Add(Me.optlang11)
        Me.GroupBox3.Controls.Add(Me.optlang10)
        Me.GroupBox3.Controls.Add(Me.optlang9)
        Me.GroupBox3.Controls.Add(Me.optlang8)
        Me.GroupBox3.Controls.Add(Me.optlang7)
        Me.GroupBox3.Controls.Add(Me.optlang6)
        Me.GroupBox3.Controls.Add(Me.optlang5)
        Me.GroupBox3.Controls.Add(Me.optlang4)
        Me.GroupBox3.Controls.Add(Me.optlang3)
        Me.GroupBox3.Controls.Add(Me.optlang2)
        Me.GroupBox3.Controls.Add(Me.optlang1)
        Me.GroupBox3.Location = New System.Drawing.Point(578, 289)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(855, 237)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Language"
        '
        'optlang42
        '
        Me.optlang42.ForeColor = System.Drawing.Color.Blue
        Me.optlang42.Location = New System.Drawing.Point(710, 48)
        Me.optlang42.Name = "optlang42"
        Me.optlang42.Size = New System.Drawing.Size(104, 25)
        Me.optlang42.TabIndex = 41
        Me.optlang42.Text = "Vietnamese"
        '
        'optlang41
        '
        Me.optlang41.ForeColor = System.Drawing.Color.Blue
        Me.optlang41.Location = New System.Drawing.Point(710, 22)
        Me.optlang41.Name = "optlang41"
        Me.optlang41.Size = New System.Drawing.Size(104, 26)
        Me.optlang41.TabIndex = 40
        Me.optlang41.Text = "Ukrainian"
        '
        'optlang40
        '
        Me.optlang40.ForeColor = System.Drawing.Color.Blue
        Me.optlang40.Location = New System.Drawing.Point(551, 207)
        Me.optlang40.Name = "optlang40"
        Me.optlang40.Size = New System.Drawing.Size(145, 25)
        Me.optlang40.TabIndex = 39
        Me.optlang40.Text = "Turkish"
        '
        'optlang39
        '
        Me.optlang39.ForeColor = System.Drawing.Color.Blue
        Me.optlang39.Location = New System.Drawing.Point(551, 179)
        Me.optlang39.Name = "optlang39"
        Me.optlang39.Size = New System.Drawing.Size(145, 25)
        Me.optlang39.TabIndex = 38
        Me.optlang39.Text = "Thai"
        '
        'optlang38
        '
        Me.optlang38.ForeColor = System.Drawing.Color.Blue
        Me.optlang38.Location = New System.Drawing.Point(551, 153)
        Me.optlang38.Name = "optlang38"
        Me.optlang38.Size = New System.Drawing.Size(145, 26)
        Me.optlang38.TabIndex = 37
        Me.optlang38.Text = "Tagalog"
        '
        'optlang37
        '
        Me.optlang37.ForeColor = System.Drawing.Color.Blue
        Me.optlang37.Location = New System.Drawing.Point(551, 127)
        Me.optlang37.Name = "optlang37"
        Me.optlang37.Size = New System.Drawing.Size(145, 26)
        Me.optlang37.TabIndex = 36
        Me.optlang37.Text = "Swedish (Fraktur)"
        '
        'optlang36
        '
        Me.optlang36.ForeColor = System.Drawing.Color.Blue
        Me.optlang36.Location = New System.Drawing.Point(551, 99)
        Me.optlang36.Name = "optlang36"
        Me.optlang36.Size = New System.Drawing.Size(145, 26)
        Me.optlang36.TabIndex = 35
        Me.optlang36.Text = "Swedish"
        '
        'optlang35
        '
        Me.optlang35.ForeColor = System.Drawing.Color.Blue
        Me.optlang35.Location = New System.Drawing.Point(551, 73)
        Me.optlang35.Name = "optlang35"
        Me.optlang35.Size = New System.Drawing.Size(145, 26)
        Me.optlang35.TabIndex = 34
        Me.optlang35.Text = "Serbian (Latin)"
        '
        'optlang34
        '
        Me.optlang34.ForeColor = System.Drawing.Color.Blue
        Me.optlang34.Location = New System.Drawing.Point(551, 48)
        Me.optlang34.Name = "optlang34"
        Me.optlang34.Size = New System.Drawing.Size(145, 25)
        Me.optlang34.TabIndex = 33
        Me.optlang34.Text = "Slovenian"
        '
        'optlang33
        '
        Me.optlang33.ForeColor = System.Drawing.Color.Blue
        Me.optlang33.Location = New System.Drawing.Point(551, 22)
        Me.optlang33.Name = "optlang33"
        Me.optlang33.Size = New System.Drawing.Size(145, 26)
        Me.optlang33.TabIndex = 32
        Me.optlang33.Text = "Slovakian Fraktur"
        '
        'optlang32
        '
        Me.optlang32.ForeColor = System.Drawing.Color.Blue
        Me.optlang32.Location = New System.Drawing.Point(442, 207)
        Me.optlang32.Name = "optlang32"
        Me.optlang32.Size = New System.Drawing.Size(97, 25)
        Me.optlang32.TabIndex = 31
        Me.optlang32.Text = "Slovakian "
        '
        'optlang31
        '
        Me.optlang31.ForeColor = System.Drawing.Color.Blue
        Me.optlang31.Location = New System.Drawing.Point(442, 179)
        Me.optlang31.Name = "optlang31"
        Me.optlang31.Size = New System.Drawing.Size(153, 25)
        Me.optlang31.TabIndex = 30
        Me.optlang31.Text = "Russian"
        '
        'optlang30
        '
        Me.optlang30.ForeColor = System.Drawing.Color.Blue
        Me.optlang30.Location = New System.Drawing.Point(442, 155)
        Me.optlang30.Name = "optlang30"
        Me.optlang30.Size = New System.Drawing.Size(153, 26)
        Me.optlang30.TabIndex = 29
        Me.optlang30.Text = "Romanian"
        '
        'optlang29
        '
        Me.optlang29.ForeColor = System.Drawing.Color.Blue
        Me.optlang29.Location = New System.Drawing.Point(442, 127)
        Me.optlang29.Name = "optlang29"
        Me.optlang29.Size = New System.Drawing.Size(153, 26)
        Me.optlang29.TabIndex = 28
        Me.optlang29.Text = "Polish"
        '
        'optlang28
        '
        Me.optlang28.ForeColor = System.Drawing.Color.Blue
        Me.optlang28.Location = New System.Drawing.Point(442, 99)
        Me.optlang28.Name = "optlang28"
        Me.optlang28.Size = New System.Drawing.Size(153, 26)
        Me.optlang28.TabIndex = 27
        Me.optlang28.Text = "Norwegian"
        '
        'optlang27
        '
        Me.optlang27.ForeColor = System.Drawing.Color.Blue
        Me.optlang27.Location = New System.Drawing.Point(442, 73)
        Me.optlang27.Name = "optlang27"
        Me.optlang27.Size = New System.Drawing.Size(153, 26)
        Me.optlang27.TabIndex = 26
        Me.optlang27.Text = "Lithuanian"
        '
        'optlang26
        '
        Me.optlang26.ForeColor = System.Drawing.Color.Blue
        Me.optlang26.Location = New System.Drawing.Point(442, 48)
        Me.optlang26.Name = "optlang26"
        Me.optlang26.Size = New System.Drawing.Size(153, 25)
        Me.optlang26.TabIndex = 25
        Me.optlang26.Text = "Latvian"
        '
        'optlang25
        '
        Me.optlang25.ForeColor = System.Drawing.Color.Blue
        Me.optlang25.Location = New System.Drawing.Point(442, 22)
        Me.optlang25.Name = "optlang25"
        Me.optlang25.Size = New System.Drawing.Size(153, 26)
        Me.optlang25.TabIndex = 24
        Me.optlang25.Text = "Korean"
        '
        'optlang24
        '
        Me.optlang24.ForeColor = System.Drawing.Color.Blue
        Me.optlang24.Location = New System.Drawing.Point(334, 207)
        Me.optlang24.Name = "optlang24"
        Me.optlang24.Size = New System.Drawing.Size(153, 25)
        Me.optlang24.TabIndex = 23
        Me.optlang24.Text = "Japanese"
        '
        'optlang23
        '
        Me.optlang23.ForeColor = System.Drawing.Color.Blue
        Me.optlang23.Location = New System.Drawing.Point(334, 179)
        Me.optlang23.Name = "optlang23"
        Me.optlang23.Size = New System.Drawing.Size(153, 25)
        Me.optlang23.TabIndex = 22
        Me.optlang23.Text = "Indonesian"
        '
        'optlang22
        '
        Me.optlang22.ForeColor = System.Drawing.Color.Blue
        Me.optlang22.Location = New System.Drawing.Point(334, 153)
        Me.optlang22.Name = "optlang22"
        Me.optlang22.Size = New System.Drawing.Size(153, 26)
        Me.optlang22.TabIndex = 21
        Me.optlang22.Text = "Hungarian"
        '
        'optlang21
        '
        Me.optlang21.ForeColor = System.Drawing.Color.Blue
        Me.optlang21.Location = New System.Drawing.Point(331, 127)
        Me.optlang21.Name = "optlang21"
        Me.optlang21.Size = New System.Drawing.Size(154, 26)
        Me.optlang21.TabIndex = 20
        Me.optlang21.Text = "Hindi"
        '
        'optlang20
        '
        Me.optlang20.ForeColor = System.Drawing.Color.Blue
        Me.optlang20.Location = New System.Drawing.Point(331, 99)
        Me.optlang20.Name = "optlang20"
        Me.optlang20.Size = New System.Drawing.Size(103, 26)
        Me.optlang20.TabIndex = 19
        Me.optlang20.Text = "Hebrew"
        '
        'optlang19
        '
        Me.optlang19.ForeColor = System.Drawing.Color.Blue
        Me.optlang19.Location = New System.Drawing.Point(334, 73)
        Me.optlang19.Name = "optlang19"
        Me.optlang19.Size = New System.Drawing.Size(86, 26)
        Me.optlang19.TabIndex = 18
        Me.optlang19.Text = "French"
        '
        'optlang18
        '
        Me.optlang18.ForeColor = System.Drawing.Color.Blue
        Me.optlang18.Location = New System.Drawing.Point(334, 48)
        Me.optlang18.Name = "optlang18"
        Me.optlang18.Size = New System.Drawing.Size(153, 25)
        Me.optlang18.TabIndex = 17
        Me.optlang18.Text = "Finnish"
        '
        'optlang17
        '
        Me.optlang17.ForeColor = System.Drawing.Color.Blue
        Me.optlang17.Location = New System.Drawing.Point(334, 22)
        Me.optlang17.Name = "optlang17"
        Me.optlang17.Size = New System.Drawing.Size(153, 26)
        Me.optlang17.TabIndex = 16
        Me.optlang17.Text = "Greek"
        '
        'optlang16
        '
        Me.optlang16.ForeColor = System.Drawing.Color.Blue
        Me.optlang16.Location = New System.Drawing.Point(173, 207)
        Me.optlang16.Name = "optlang16"
        Me.optlang16.Size = New System.Drawing.Size(153, 25)
        Me.optlang16.TabIndex = 15
        Me.optlang16.Text = "Danish (Fraktur)"
        '
        'optlang15
        '
        Me.optlang15.ForeColor = System.Drawing.Color.Blue
        Me.optlang15.Location = New System.Drawing.Point(173, 179)
        Me.optlang15.Name = "optlang15"
        Me.optlang15.Size = New System.Drawing.Size(153, 25)
        Me.optlang15.TabIndex = 14
        Me.optlang15.Text = "Danish"
        '
        'optlang14
        '
        Me.optlang14.ForeColor = System.Drawing.Color.Blue
        Me.optlang14.Location = New System.Drawing.Point(173, 153)
        Me.optlang14.Name = "optlang14"
        Me.optlang14.Size = New System.Drawing.Size(153, 26)
        Me.optlang14.TabIndex = 13
        Me.optlang14.Text = "Cheroke"
        '
        'optlang13
        '
        Me.optlang13.ForeColor = System.Drawing.Color.Blue
        Me.optlang13.Location = New System.Drawing.Point(173, 127)
        Me.optlang13.Name = "optlang13"
        Me.optlang13.Size = New System.Drawing.Size(153, 26)
        Me.optlang13.TabIndex = 12
        Me.optlang13.Text = "Czech"
        '
        'optlang12
        '
        Me.optlang12.ForeColor = System.Drawing.Color.Blue
        Me.optlang12.Location = New System.Drawing.Point(173, 99)
        Me.optlang12.Name = "optlang12"
        Me.optlang12.Size = New System.Drawing.Size(153, 26)
        Me.optlang12.TabIndex = 11
        Me.optlang12.Text = "Catalan"
        '
        'optlang11
        '
        Me.optlang11.ForeColor = System.Drawing.Color.Blue
        Me.optlang11.Location = New System.Drawing.Point(173, 73)
        Me.optlang11.Name = "optlang11"
        Me.optlang11.Size = New System.Drawing.Size(153, 26)
        Me.optlang11.TabIndex = 10
        Me.optlang11.Text = "Bulgarian"
        '
        'optlang10
        '
        Me.optlang10.ForeColor = System.Drawing.Color.Blue
        Me.optlang10.Location = New System.Drawing.Point(173, 48)
        Me.optlang10.Name = "optlang10"
        Me.optlang10.Size = New System.Drawing.Size(153, 25)
        Me.optlang10.TabIndex = 9
        Me.optlang10.Text = "Arabic"
        '
        'optlang9
        '
        Me.optlang9.ForeColor = System.Drawing.Color.Blue
        Me.optlang9.Location = New System.Drawing.Point(173, 22)
        Me.optlang9.Name = "optlang9"
        Me.optlang9.Size = New System.Drawing.Size(153, 26)
        Me.optlang9.TabIndex = 8
        Me.optlang9.Text = "Chinese (Traditional)"
        '
        'optlang8
        '
        Me.optlang8.Location = New System.Drawing.Point(19, 207)
        Me.optlang8.Name = "optlang8"
        Me.optlang8.Size = New System.Drawing.Size(154, 25)
        Me.optlang8.TabIndex = 7
        Me.optlang8.Text = "Chinese (Simplified)"
        '
        'optlang7
        '
        Me.optlang7.Location = New System.Drawing.Point(19, 179)
        Me.optlang7.Name = "optlang7"
        Me.optlang7.Size = New System.Drawing.Size(115, 25)
        Me.optlang7.TabIndex = 6
        Me.optlang7.Text = "Spanish"
        '
        'optlang6
        '
        Me.optlang6.Location = New System.Drawing.Point(19, 153)
        Me.optlang6.Name = "optlang6"
        Me.optlang6.Size = New System.Drawing.Size(115, 26)
        Me.optlang6.TabIndex = 5
        Me.optlang6.Text = "Portuguese"
        '
        'optlang5
        '
        Me.optlang5.Location = New System.Drawing.Point(19, 132)
        Me.optlang5.Name = "optlang5"
        Me.optlang5.Size = New System.Drawing.Size(125, 16)
        Me.optlang5.TabIndex = 4
        Me.optlang5.Text = "Dutch"
        '
        'optlang4
        '
        Me.optlang4.Location = New System.Drawing.Point(19, 104)
        Me.optlang4.Name = "optlang4"
        Me.optlang4.Size = New System.Drawing.Size(106, 16)
        Me.optlang4.TabIndex = 3
        Me.optlang4.Text = "Italian"
        '
        'optlang3
        '
        Me.optlang3.Location = New System.Drawing.Point(19, 78)
        Me.optlang3.Name = "optlang3"
        Me.optlang3.Size = New System.Drawing.Size(96, 17)
        Me.optlang3.TabIndex = 2
        Me.optlang3.Text = "Fraktur"
        '
        'optlang2
        '
        Me.optlang2.Location = New System.Drawing.Point(19, 52)
        Me.optlang2.Name = "optlang2"
        Me.optlang2.Size = New System.Drawing.Size(87, 17)
        Me.optlang2.TabIndex = 1
        Me.optlang2.Text = "German"
        '
        'optlang1
        '
        Me.optlang1.Checked = True
        Me.optlang1.Location = New System.Drawing.Point(19, 26)
        Me.optlang1.Name = "optlang1"
        Me.optlang1.Size = New System.Drawing.Size(96, 17)
        Me.optlang1.TabIndex = 0
        Me.optlang1.TabStop = True
        Me.optlang1.Text = "English"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(580, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(377, 12)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Unzip the file and copy all files to dictfiles/tessdata folder"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(580, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(689, 12)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "For additional language (blue color), you need download the language pack from ww" & _
            "w.viscomsoft.com/ocrlanguage.zip "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(583, 619)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 12)
        Me.Label12.TabIndex = 28
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Controls.Add(Me.txtfontfile)
        Me.GroupBox7.Controls.Add(Me.txtfontname)
        Me.GroupBox7.Controls.Add(Me.RadioButtonFontFile)
        Me.GroupBox7.Controls.Add(Me.RadioButtonFontName)
        Me.GroupBox7.Location = New System.Drawing.Point(578, 532)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(806, 66)
        Me.GroupBox7.TabIndex = 30
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Font for Non English Lanauge "
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(703, 44)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 22)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Select"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(270, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 21)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Select"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtfontfile
        '
        Me.txtfontfile.Enabled = False
        Me.txtfontfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfontfile.Location = New System.Drawing.Point(559, 25)
        Me.txtfontfile.Name = "txtfontfile"
        Me.txtfontfile.Size = New System.Drawing.Size(172, 18)
        Me.txtfontfile.TabIndex = 3
        '
        'txtfontname
        '
        Me.txtfontname.Enabled = False
        Me.txtfontname.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfontname.Location = New System.Drawing.Point(134, 20)
        Me.txtfontname.Name = "txtfontname"
        Me.txtfontname.Size = New System.Drawing.Size(222, 18)
        Me.txtfontname.TabIndex = 2
        '
        'RadioButtonFontFile
        '
        Me.RadioButtonFontFile.AutoSize = True
        Me.RadioButtonFontFile.Location = New System.Drawing.Point(439, 26)
        Me.RadioButtonFontFile.Name = "RadioButtonFontFile"
        Me.RadioButtonFontFile.Size = New System.Drawing.Size(107, 16)
        Me.RadioButtonFontFile.TabIndex = 1
        Me.RadioButtonFontFile.Text = "Font File Name"
        Me.RadioButtonFontFile.UseVisualStyleBackColor = True
        '
        'RadioButtonFontName
        '
        Me.RadioButtonFontName.AutoSize = True
        Me.RadioButtonFontName.Checked = True
        Me.RadioButtonFontName.Location = New System.Drawing.Point(24, 26)
        Me.RadioButtonFontName.Name = "RadioButtonFontName"
        Me.RadioButtonFontName.Size = New System.Drawing.Size(83, 16)
        Me.RadioButtonFontName.TabIndex = 0
        Me.RadioButtonFontName.TabStop = True
        Me.RadioButtonFontName.Text = " Font Name"
        Me.RadioButtonFontName.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1281, 746)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkuseadvpdf)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.cmdprevpage)
        Me.Controls.Add(Me.txtpdfajpegquality)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chkpdfausejpeg)
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
        Me.Text = "OCR to searchable PDF/A "
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
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

        AxImageViewer1.MouseTrackMode = 2

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim iLangIndex As Integer
        Dim iMode As Integer
        Dim iResult As Integer

        ProgressBar1.Value = 0

        If OptAsync.Checked Then

            Me.AxImageViewer1.OCRScanTextAsync(True)
        Else
            Me.AxImageViewer1.OCRScanTextAsync(False)
        End If

        iLangIndex = 0

        If optlang1.Checked Then
            iLangIndex = 0
        End If

        If optlang2.Checked Then
            iLangIndex = 1
        End If

        If optlang3.Checked Then
            iLangIndex = 2
        End If

        If optlang4.Checked Then
            iLangIndex = 3
        End If

        If optlang5.Checked Then
            iLangIndex = 4
        End If

        If optlang6.Checked Then
            iLangIndex = 5
        End If

        If optlang7.Checked Then
            iLangIndex = 6
        End If

        If optlang8.Checked Then
            iLangIndex = 7
        End If

        If optlang9.Checked Then
            iLangIndex = 8
        End If

        If optlang10.Checked Then
            iLangIndex = 9
        End If

        If optlang11.Checked Then
            iLangIndex = 10
        End If

        If optlang12.Checked Then
            iLangIndex = 11
        End If

        If optlang13.Checked Then
            iLangIndex = 12
        End If

        If optlang14.Checked Then
            iLangIndex = 13
        End If

        If optlang15.Checked Then
            iLangIndex = 14
        End If

        If optlang16.Checked Then
            iLangIndex = 15
        End If

        If optlang17.Checked Then
            iLangIndex = 16
        End If

        If optlang18.Checked Then
            iLangIndex = 17
        End If

        If optlang19.Checked Then
            iLangIndex = 18
        End If

        If optlang20.Checked Then
            iLangIndex = 19
        End If

        If optlang21.Checked Then
            iLangIndex = 20
        End If

        If optlang22.Checked Then
            iLangIndex = 21
        End If

        If optlang23.Checked Then
            iLangIndex = 22
        End If

        If optlang24.Checked Then
            iLangIndex = 23
        End If

        If optlang25.Checked Then
            iLangIndex = 24
        End If

        If optlang26.Checked Then
            iLangIndex = 25
        End If

        If optlang27.Checked Then
            iLangIndex = 26
        End If

        If optlang28.Checked Then
            iLangIndex = 27
        End If

        If optlang29.Checked Then
            iLangIndex = 28
        End If

        If optlang30.Checked Then
            iLangIndex = 29
        End If

        If optlang31.Checked Then
            iLangIndex = 30
        End If

        If optlang32.Checked Then
            iLangIndex = 31
        End If

        If optlang33.Checked Then
            iLangIndex = 32
        End If

        If optlang34.Checked Then
            iLangIndex = 33
        End If

        If optlang35.Checked Then
            iLangIndex = 34
        End If

        If optlang36.Checked Then
            iLangIndex = 35
        End If

        If optlang37.Checked Then
            iLangIndex = 36
        End If

        If optlang38.Checked Then
            iLangIndex = 37
        End If

        If optlang39.Checked Then
            iLangIndex = 38
        End If

        If optlang40.Checked Then
            iLangIndex = 39
        End If

        If optlang41.Checked Then
            iLangIndex = 40
        End If

        If optlang42.Checked Then
            iLangIndex = 41
        End If


        If iLangIndex > 0 And txtfontname.Text = "" And txtfontfile.Text = "" Then
            MessageBox.Show("Select select font name or font file")
            Exit Sub
        End If

        If RadioButtonFontName.Checked Then
            AxImageViewer1.OCR2SearchablePDFFontName = txtfontname.Text
        End If

        If RadioButtonFontFile.Checked Then
            AxImageViewer1.OCR2SearchablePDFFontFile = txtfontfile.Text
        End If

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
            Me.AxImageViewer1.OCRSetRect(txtleft.Text, txttop.Text, txtfilewidth.Text, txtfileheight.Text)

        End If

        If chkpdfausejpeg.Checked Then
            Me.AxImageViewer1.PDFJPEGQuality = Val(txtpdfajpegquality.Text)
            Me.AxImageViewer1.PDFUseJPEGCompression = True
        Else
            Me.AxImageViewer1.PDFUseJPEGCompression = False
        End If




        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then



            If optoutput1.Checked Then
                iResult = Me.AxImageViewer1.OCR2SearchablePDF(SaveFileDialog1.FileName, iLangIndex, "dictfiles")

            Else

                iResult = Me.AxImageViewer1.OCR2SearchableMultipagePDF(SaveFileDialog1.FileName, iLangIndex, "dictfiles")

            End If

        End If



        If iResult = -3 Then
            MessageBox.Show("Please select image first")
            Exit Sub
        Else

            If OptAsync.Checked = False Then


                If iResult <> 1 Then
                    MessageBox.Show("Start OCR Failed")
                Else
                    MessageBox.Show("Save to " + SaveFileDialog1.FileName + " completed")

                End If
            Else
                Button2.Enabled = False
            End If

        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpdfausejpeg.CheckedChanged
        If chkpdfausejpeg.Checked Then
            txtpdfajpegquality.Enabled = True
        Else
            txtpdfajpegquality.Enabled = False

        End If
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

    Private Sub AxImageViewer1_SelectionRectDrawn(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent) Handles AxImageViewer1.SelectionRectDrawn
        If Not chkfullpage.Checked Then

            txtleft.Text = e.iLeft
            txttop.Text = e.iTop
            txtfilewidth.Text = e.iWidth
            txtfileheight.Text = e.iHeight
        End If


    End Sub

    Private Sub AxImageViewer1_OCRPDFA(ByVal sender As Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_OCRPDFAEvent) Handles AxImageViewer1.OCRPDFA
        ProgressBar1.Value = e.iProgress
        If e.iProgress = 100 Then
            MessageBox.Show("save to " + SaveFileDialog1.FileName + " completed")
            Button2.Enabled = True
        End If


    End Sub

    Private Sub chkuseadvpdf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkuseadvpdf.CheckedChanged
        If chkuseadvpdf.Checked Then
            Me.AxImageViewer1.PDFUseAdvancedViewer = True
        Else
            Me.AxImageViewer1.PDFUseAdvancedViewer = False

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtfontname.Text = FontDialog1.Font.FontFamily.Name
            txtfontfile.Text = ""
        End If

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "True type font(*.TTF file)|*.ttf"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtfontfile.Text = OpenFileDialog1.FileName
            txtfontname.Text = ""
        End If
    End Sub

    Sub Disable_SelectFont()
        txtfontname.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False

    End Sub

    Sub Enable_SelectFont()
        txtfontname.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

    End Sub
    Private Sub optlang1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub optlang1_Click(sender As Object, e As System.EventArgs) Handles optlang1.Click
        Disable_SelectFont()
    End Sub

    Private Sub optlang2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optlang2.CheckedChanged

    End Sub

    Private Sub optlang2_Click(sender As System.Object, e As System.EventArgs) Handles optlang2.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang3_Click(sender As System.Object, e As System.EventArgs) Handles optlang3.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang4_Click(sender As System.Object, e As System.EventArgs) Handles optlang4.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang5_Click(sender As System.Object, e As System.EventArgs) Handles optlang5.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang6_Click(sender As System.Object, e As System.EventArgs) Handles optlang6.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang7_Click(sender As System.Object, e As System.EventArgs) Handles optlang7.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang8_Click(sender As System.Object, e As System.EventArgs) Handles optlang8.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang9_Click(sender As System.Object, e As System.EventArgs) Handles optlang9.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang10_Click(sender As System.Object, e As System.EventArgs) Handles optlang10.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang11_Click(sender As System.Object, e As System.EventArgs) Handles optlang11.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optlang12.CheckedChanged

    End Sub

    Private Sub optlang12_Click(sender As System.Object, e As System.EventArgs) Handles optlang12.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang13_Click(sender As System.Object, e As System.EventArgs) Handles optlang13.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang14_Click(sender As System.Object, e As System.EventArgs) Handles optlang14.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang15_Click(sender As System.Object, e As System.EventArgs) Handles optlang15.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang16_Click(sender As System.Object, e As System.EventArgs) Handles optlang16.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang17_Click(sender As System.Object, e As System.EventArgs) Handles optlang17.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang18_Click(sender As System.Object, e As System.EventArgs) Handles optlang18.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang19_Click(sender As System.Object, e As System.EventArgs) Handles optlang19.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang20_Click(sender As System.Object, e As System.EventArgs) Handles optlang20.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang21_Click(sender As System.Object, e As System.EventArgs) Handles optlang21.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang22_Click(sender As System.Object, e As System.EventArgs) Handles optlang22.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang23_Click(sender As System.Object, e As System.EventArgs) Handles optlang23.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang24_Click(sender As System.Object, e As System.EventArgs) Handles optlang24.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang25_Click(sender As System.Object, e As System.EventArgs) Handles optlang25.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang26_Click(sender As System.Object, e As System.EventArgs) Handles optlang26.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang27_Click(sender As System.Object, e As System.EventArgs) Handles optlang27.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang28_Click(sender As System.Object, e As System.EventArgs) Handles optlang28.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang29_Click(sender As System.Object, e As System.EventArgs) Handles optlang29.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang30_Click(sender As System.Object, e As System.EventArgs) Handles optlang30.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang31_Click(sender As System.Object, e As System.EventArgs) Handles optlang31.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang32_Click(sender As System.Object, e As System.EventArgs) Handles optlang32.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang33_Click(sender As System.Object, e As System.EventArgs) Handles optlang33.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang34_Click(sender As System.Object, e As System.EventArgs) Handles optlang34.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang35_Click(sender As System.Object, e As System.EventArgs) Handles optlang35.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang36_Click(sender As System.Object, e As System.EventArgs) Handles optlang36.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang37_Click(sender As System.Object, e As System.EventArgs) Handles optlang37.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang38_Click(sender As System.Object, e As System.EventArgs) Handles optlang38.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang39_Click(sender As System.Object, e As System.EventArgs) Handles optlang39.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang40_Click(sender As System.Object, e As System.EventArgs) Handles optlang40.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang41_Click(sender As System.Object, e As System.EventArgs) Handles optlang41.Click
        Enable_SelectFont()
    End Sub

    Private Sub optlang42_Click(sender As System.Object, e As System.EventArgs) Handles optlang42.Click
        Enable_SelectFont()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

