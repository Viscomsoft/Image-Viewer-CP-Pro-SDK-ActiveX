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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optlang1 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang2 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang3 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang4 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang5 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang6 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang7 As System.Windows.Forms.RadioButton
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents optfilter4 As System.Windows.Forms.RadioButton
    Friend WithEvents optfilter3 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdprevpage As System.Windows.Forms.Button
    Friend WithEvents cmdnextpage As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents OptAsync As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkuseadvpdf As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optlang7 = New System.Windows.Forms.RadioButton()
        Me.optlang6 = New System.Windows.Forms.RadioButton()
        Me.optlang5 = New System.Windows.Forms.RadioButton()
        Me.optlang4 = New System.Windows.Forms.RadioButton()
        Me.optlang3 = New System.Windows.Forms.RadioButton()
        Me.optlang2 = New System.Windows.Forms.RadioButton()
        Me.optlang1 = New System.Windows.Forms.RadioButton()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdprevpage = New System.Windows.Forms.Button()
        Me.cmdnextpage = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.OptAsync = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.chkuseadvpdf = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(16, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(448, 552)
        Me.AxImageViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(488, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select Image"
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(480, 88)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(344, 20)
        Me.txtfilename.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(480, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Page"
        '
        'txttotpage
        '
        Me.txttotpage.Location = New System.Drawing.Point(552, 112)
        Me.txttotpage.Name = "txttotpage"
        Me.txttotpage.Size = New System.Drawing.Size(56, 20)
        Me.txttotpage.TabIndex = 4
        Me.txttotpage.Text = "1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(624, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Page No"
        '
        'txtPageNo
        '
        Me.txtPageNo.Location = New System.Drawing.Point(704, 112)
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.Size = New System.Drawing.Size(48, 20)
        Me.txtPageNo.TabIndex = 6
        Me.txtPageNo.Text = "1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optmode3)
        Me.GroupBox1.Controls.Add(Me.optmode2)
        Me.GroupBox1.Controls.Add(Me.optmode1)
        Me.GroupBox1.Location = New System.Drawing.Point(480, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 88)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recognize Mode"
        '
        'optmode3
        '
        Me.optmode3.Location = New System.Drawing.Point(8, 64)
        Me.optmode3.Name = "optmode3"
        Me.optmode3.Size = New System.Drawing.Size(136, 16)
        Me.optmode3.TabIndex = 2
        Me.optmode3.Text = "Excellent"
        '
        'optmode2
        '
        Me.optmode2.Checked = True
        Me.optmode2.Location = New System.Drawing.Point(8, 40)
        Me.optmode2.Name = "optmode2"
        Me.optmode2.Size = New System.Drawing.Size(88, 16)
        Me.optmode2.TabIndex = 1
        Me.optmode2.TabStop = True
        Me.optmode2.Text = "Normal"
        '
        'optmode1
        '
        Me.optmode1.Location = New System.Drawing.Point(8, 16)
        Me.optmode1.Name = "optmode1"
        Me.optmode1.Size = New System.Drawing.Size(56, 16)
        Me.optmode1.TabIndex = 0
        Me.optmode1.Text = "Fast"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optfilter4)
        Me.GroupBox2.Controls.Add(Me.optfilter3)
        Me.GroupBox2.Controls.Add(Me.optfilter2)
        Me.GroupBox2.Controls.Add(Me.optfilter1)
        Me.GroupBox2.Location = New System.Drawing.Point(828, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 104)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Character Filter"
        '
        'optfilter4
        '
        Me.optfilter4.Location = New System.Drawing.Point(8, 88)
        Me.optfilter4.Name = "optfilter4"
        Me.optfilter4.Size = New System.Drawing.Size(224, 16)
        Me.optfilter4.TabIndex = 3
        Me.optfilter4.Text = "Recognize lowercase only"
        '
        'optfilter3
        '
        Me.optfilter3.Location = New System.Drawing.Point(8, 64)
        Me.optfilter3.Name = "optfilter3"
        Me.optfilter3.Size = New System.Drawing.Size(240, 16)
        Me.optfilter3.TabIndex = 2
        Me.optfilter3.Text = "Recognize uppercase only"
        '
        'optfilter2
        '
        Me.optfilter2.Location = New System.Drawing.Point(8, 40)
        Me.optfilter2.Name = "optfilter2"
        Me.optfilter2.Size = New System.Drawing.Size(224, 16)
        Me.optfilter2.TabIndex = 1
        Me.optfilter2.Text = "Recognize numeric only "
        '
        'optfilter1
        '
        Me.optfilter1.Checked = True
        Me.optfilter1.Location = New System.Drawing.Point(8, 16)
        Me.optfilter1.Name = "optfilter1"
        Me.optfilter1.Size = New System.Drawing.Size(144, 16)
        Me.optfilter1.TabIndex = 0
        Me.optfilter1.TabStop = True
        Me.optfilter1.Text = "No Filter"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optlang7)
        Me.GroupBox3.Controls.Add(Me.optlang6)
        Me.GroupBox3.Controls.Add(Me.optlang5)
        Me.GroupBox3.Controls.Add(Me.optlang4)
        Me.GroupBox3.Controls.Add(Me.optlang3)
        Me.GroupBox3.Controls.Add(Me.optlang2)
        Me.GroupBox3.Controls.Add(Me.optlang1)
        Me.GroupBox3.Location = New System.Drawing.Point(483, 250)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 104)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Language"
        '
        'optlang7
        '
        Me.optlang7.Location = New System.Drawing.Point(120, 72)
        Me.optlang7.Name = "optlang7"
        Me.optlang7.Size = New System.Drawing.Size(96, 24)
        Me.optlang7.TabIndex = 6
        Me.optlang7.Text = "Spanish"
        '
        'optlang6
        '
        Me.optlang6.Location = New System.Drawing.Point(120, 48)
        Me.optlang6.Name = "optlang6"
        Me.optlang6.Size = New System.Drawing.Size(96, 24)
        Me.optlang6.TabIndex = 5
        Me.optlang6.Text = "Portuguese"
        '
        'optlang5
        '
        Me.optlang5.Location = New System.Drawing.Point(120, 24)
        Me.optlang5.Name = "optlang5"
        Me.optlang5.Size = New System.Drawing.Size(104, 16)
        Me.optlang5.TabIndex = 4
        Me.optlang5.Text = "Dutch"
        '
        'optlang4
        '
        Me.optlang4.Location = New System.Drawing.Point(232, 24)
        Me.optlang4.Name = "optlang4"
        Me.optlang4.Size = New System.Drawing.Size(88, 16)
        Me.optlang4.TabIndex = 3
        Me.optlang4.Text = "Italian"
        '
        'optlang3
        '
        Me.optlang3.Location = New System.Drawing.Point(16, 72)
        Me.optlang3.Name = "optlang3"
        Me.optlang3.Size = New System.Drawing.Size(80, 16)
        Me.optlang3.TabIndex = 2
        Me.optlang3.Text = "Fraktur"
        '
        'optlang2
        '
        Me.optlang2.Location = New System.Drawing.Point(16, 48)
        Me.optlang2.Name = "optlang2"
        Me.optlang2.Size = New System.Drawing.Size(72, 16)
        Me.optlang2.TabIndex = 1
        Me.optlang2.Text = "German"
        '
        'optlang1
        '
        Me.optlang1.Checked = True
        Me.optlang1.Location = New System.Drawing.Point(16, 24)
        Me.optlang1.Name = "optlang1"
        Me.optlang1.Size = New System.Drawing.Size(80, 16)
        Me.optlang1.TabIndex = 0
        Me.optlang1.TabStop = True
        Me.optlang1.Text = "English"
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
        Me.GroupBox4.Location = New System.Drawing.Point(828, 261)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 112)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Zone"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(16, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "You may draw the selection rectangle on image and click Start Convert to Searchab" & _
    "le PDF/A Button"
        '
        'txtfileheight
        '
        Me.txtfileheight.Location = New System.Drawing.Point(288, 48)
        Me.txtfileheight.Name = "txtfileheight"
        Me.txtfileheight.Size = New System.Drawing.Size(32, 20)
        Me.txtfileheight.TabIndex = 9
        Me.txtfileheight.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(240, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Height"
        '
        'txtfilewidth
        '
        Me.txtfilewidth.Location = New System.Drawing.Point(200, 48)
        Me.txtfilewidth.Name = "txtfilewidth"
        Me.txtfilewidth.Size = New System.Drawing.Size(32, 20)
        Me.txtfilewidth.TabIndex = 7
        Me.txtfilewidth.Text = "0"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(160, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Width"
        '
        'txttop
        '
        Me.txttop.Location = New System.Drawing.Point(120, 48)
        Me.txttop.Name = "txttop"
        Me.txttop.Size = New System.Drawing.Size(32, 20)
        Me.txttop.TabIndex = 5
        Me.txttop.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(88, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Top"
        '
        'txtleft
        '
        Me.txtleft.Location = New System.Drawing.Point(48, 48)
        Me.txtleft.Name = "txtleft"
        Me.txtleft.Size = New System.Drawing.Size(32, 20)
        Me.txtleft.TabIndex = 3
        Me.txtleft.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Left"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(112, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "uncheck this button recognize for specific zone"
        '
        'chkfullpage
        '
        Me.chkfullpage.Checked = True
        Me.chkfullpage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfullpage.Location = New System.Drawing.Point(16, 16)
        Me.chkfullpage.Name = "chkfullpage"
        Me.chkfullpage.Size = New System.Drawing.Size(80, 24)
        Me.chkfullpage.TabIndex = 0
        Me.chkfullpage.Text = "Full Page"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(488, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(328, 56)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "1. Convert to Searchable Text File"
        '
        'cmdprevpage
        '
        Me.cmdprevpage.Location = New System.Drawing.Point(648, 48)
        Me.cmdprevpage.Name = "cmdprevpage"
        Me.cmdprevpage.Size = New System.Drawing.Size(48, 24)
        Me.cmdprevpage.TabIndex = 17
        Me.cmdprevpage.Text = "<<"
        '
        'cmdnextpage
        '
        Me.cmdnextpage.Location = New System.Drawing.Point(712, 48)
        Me.cmdnextpage.Name = "cmdnextpage"
        Me.cmdnextpage.Size = New System.Drawing.Size(48, 24)
        Me.cmdnextpage.TabIndex = 18
        Me.cmdnextpage.Text = ">>"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton2)
        Me.GroupBox6.Controls.Add(Me.OptAsync)
        Me.GroupBox6.Location = New System.Drawing.Point(488, 385)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(328, 40)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Mode"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(160, 16)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Blocking"
        '
        'OptAsync
        '
        Me.OptAsync.Checked = True
        Me.OptAsync.Location = New System.Drawing.Point(8, 16)
        Me.OptAsync.Name = "OptAsync"
        Me.OptAsync.Size = New System.Drawing.Size(120, 16)
        Me.OptAsync.TabIndex = 0
        Me.OptAsync.TabStop = True
        Me.OptAsync.Text = "Asynchronous"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(488, 431)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(240, 16)
        Me.ProgressBar1.TabIndex = 20
        '
        'chkuseadvpdf
        '
        Me.chkuseadvpdf.AutoSize = True
        Me.chkuseadvpdf.Location = New System.Drawing.Point(481, 6)
        Me.chkuseadvpdf.Name = "chkuseadvpdf"
        Me.chkuseadvpdf.Size = New System.Drawing.Size(156, 17)
        Me.chkuseadvpdf.TabIndex = 21
        Me.chkuseadvpdf.Text = "Use Advanced PDF Viewer"
        Me.chkuseadvpdf.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(487, 542)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(589, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "If your output text file name output.txt, the first page of text file will named " & _
    "output0001.txt. Next page named output0002.txt..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(482, 575)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(454, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "The output text file will record each  recognized  characters and left, top, righ" & _
    "t , bottom position."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(487, 603)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(659, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Before you convert to searchable PDF, you may edit/delete/add the character of te" & _
    "xt file, finally let the searchable PDF file more accuracy "
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(490, 648)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(328, 56)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "2. Convert to Searchable PDF File"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1217, 778)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkuseadvpdf)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.cmdprevpage)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.Text = "Pre-processing Searchable PDF - OCR to searchable Text File, let you have chance " & _
    "change the text before output searchable PDF"
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
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

        chkfullpage.Checked = True

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




        SaveFileDialog1.Filter = "Text file (*.txt)|*.txt||"

        SaveFileDialog1.DefaultExt = "txt"

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            iResult = Me.AxImageViewer1.OCR2SearchableTextFile(SaveFileDialog1.FileName, iLangIndex, "dictfiles")

        End If




            If OptAsync.Checked = False Then


                If iResult <> 1 Then
                MessageBox.Show("Failed")
                Else
                MessageBox.Show("The save to text file completed, you may open these text file and editing the text,let the text of Searchable PDF file more accuracy")
                Button3.Enabled = True
            End If

            Else
                Button2.Enabled = False
            End If




    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub AxImageViewer1_OCRPDFATextFile(sender As Object, e As AxSCRIBBLELib._DImageViewerEvents_OCRPDFATextFileEvent) Handles AxImageViewer1.OCRPDFATextFile
        ProgressBar1.Value = e.iProgress
        If e.iProgress = 100 Then
            MessageBox.Show("The save to text file completed, you may open these text file and editing the text,let the text of Searchable PDF file more accuracy")
            Button2.Enabled = True
            Button3.Enabled = True

        End If

    End Sub

    Private Sub AxImageViewer1_OCRRecognized(sender As Object, e As AxSCRIBBLELib._DImageViewerEvents_OCRRecognizedEvent) Handles AxImageViewer1.OCRRecognized

    End Sub

    Private Sub AxImageViewer1_SelectionRectDrawn(ByVal sender As System.Object, ByVal e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent) Handles AxImageViewer1.SelectionRectDrawn
        If Not chkfullpage.Checked Then

            txtleft.Text = e.iLeft
            txttop.Text = e.iTop
            txtfilewidth.Text = e.iWidth
            txtfileheight.Text = e.iHeight
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
        Dim iResult As Integer
        SaveFileDialog2.Filter = "PDF file (*.pdf)|*.pdf||"

        SaveFileDialog2.DefaultExt = "pdf"

        If chkfullpage.Checked <> True Then

            Me.AxImageViewer1.DrawSelectionRect(txtleft.Text, txttop.Text, txtfilewidth.Text, txtfileheight.Text)
            Me.AxImageViewer1.Crop()
        End If

        SaveFileDialog2.Filter = "PDF file (*.pdf)|*.pdf||"

        SaveFileDialog2.DefaultExt = "pdf"

        If SaveFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            iResult = Me.AxImageViewer1.OCRTextFile2SearchablePDF(SaveFileDialog1.FileName, SaveFileDialog2.FileName)

            If iResult = 1 Then

                MessageBox.Show("Save " + SaveFileDialog2.FileName + " Completed")
            End If

            If iResult = -1 Then

                MsgBox("Save " + SaveFileDialog2.FileName + " Completed, but some page cannot matched the text files")
            End If

        End If

    End Sub
End Class

