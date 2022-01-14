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
    Friend WithEvents optlang8 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang9 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang12 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang11 As System.Windows.Forms.RadioButton
    Friend WithEvents optlang10 As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optoutput2 = New System.Windows.Forms.RadioButton()
        Me.optoutput1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdprevpage = New System.Windows.Forms.Button()
        Me.cmdnextpage = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.OptMode = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.chkuseadvpdf = New System.Windows.Forms.CheckBox()
        Me.optlang8 = New System.Windows.Forms.RadioButton()
        Me.optlang9 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.optlang10 = New System.Windows.Forms.RadioButton()
        Me.optlang11 = New System.Windows.Forms.RadioButton()
        Me.optlang12 = New System.Windows.Forms.RadioButton()
        Me.optlang13 = New System.Windows.Forms.RadioButton()
        Me.optlang14 = New System.Windows.Forms.RadioButton()
        Me.optlang15 = New System.Windows.Forms.RadioButton()
        Me.optlang16 = New System.Windows.Forms.RadioButton()
        Me.optlang17 = New System.Windows.Forms.RadioButton()
        Me.optlang18 = New System.Windows.Forms.RadioButton()
        Me.optlang19 = New System.Windows.Forms.RadioButton()
        Me.optlang20 = New System.Windows.Forms.RadioButton()
        Me.optlang21 = New System.Windows.Forms.RadioButton()
        Me.optlang22 = New System.Windows.Forms.RadioButton()
        Me.optlang23 = New System.Windows.Forms.RadioButton()
        Me.optlang24 = New System.Windows.Forms.RadioButton()
        Me.optlang25 = New System.Windows.Forms.RadioButton()
        Me.optlang26 = New System.Windows.Forms.RadioButton()
        Me.optlang27 = New System.Windows.Forms.RadioButton()
        Me.optlang28 = New System.Windows.Forms.RadioButton()
        Me.optlang29 = New System.Windows.Forms.RadioButton()
        Me.optlang30 = New System.Windows.Forms.RadioButton()
        Me.optlang31 = New System.Windows.Forms.RadioButton()
        Me.optlang32 = New System.Windows.Forms.RadioButton()
        Me.optlang33 = New System.Windows.Forms.RadioButton()
        Me.optlang34 = New System.Windows.Forms.RadioButton()
        Me.optlang35 = New System.Windows.Forms.RadioButton()
        Me.optlang36 = New System.Windows.Forms.RadioButton()
        Me.optlang37 = New System.Windows.Forms.RadioButton()
        Me.optlang38 = New System.Windows.Forms.RadioButton()
        Me.optlang39 = New System.Windows.Forms.RadioButton()
        Me.optlang40 = New System.Windows.Forms.RadioButton()
        Me.optlang41 = New System.Windows.Forms.RadioButton()
        Me.optlang42 = New System.Windows.Forms.RadioButton()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(16, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(448, 584)
        Me.AxImageViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(488, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select Image"
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(480, 100)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(344, 20)
        Me.txtfilename.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(480, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Page"
        '
        'txttotpage
        '
        Me.txttotpage.Location = New System.Drawing.Point(552, 124)
        Me.txttotpage.Name = "txttotpage"
        Me.txttotpage.Size = New System.Drawing.Size(56, 20)
        Me.txttotpage.TabIndex = 4
        Me.txttotpage.Text = "1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(624, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Page No"
        '
        'txtPageNo
        '
        Me.txtPageNo.Location = New System.Drawing.Point(704, 124)
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
        Me.GroupBox1.Location = New System.Drawing.Point(480, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 88)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recognize Mode"
        '
        'optmode3
        '
        Me.optmode3.Checked = True
        Me.optmode3.Location = New System.Drawing.Point(8, 64)
        Me.optmode3.Name = "optmode3"
        Me.optmode3.Size = New System.Drawing.Size(136, 16)
        Me.optmode3.TabIndex = 2
        Me.optmode3.TabStop = True
        Me.optmode3.Text = "Excellent"
        '
        'optmode2
        '
        Me.optmode2.Location = New System.Drawing.Point(8, 40)
        Me.optmode2.Name = "optmode2"
        Me.optmode2.Size = New System.Drawing.Size(88, 16)
        Me.optmode2.TabIndex = 1
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
        Me.GroupBox2.Location = New System.Drawing.Point(480, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 72)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Character Filter"
        '
        'optfilter4
        '
        Me.optfilter4.Location = New System.Drawing.Point(158, 40)
        Me.optfilter4.Name = "optfilter4"
        Me.optfilter4.Size = New System.Drawing.Size(224, 16)
        Me.optfilter4.TabIndex = 3
        Me.optfilter4.Text = "Recognize lowercase only"
        '
        'optfilter3
        '
        Me.optfilter3.Location = New System.Drawing.Point(158, 16)
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
        Me.GroupBox3.Location = New System.Drawing.Point(480, 357)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(713, 220)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Language"
        '
        'optlang7
        '
        Me.optlang7.Location = New System.Drawing.Point(16, 166)
        Me.optlang7.Name = "optlang7"
        Me.optlang7.Size = New System.Drawing.Size(96, 24)
        Me.optlang7.TabIndex = 6
        Me.optlang7.Text = "Spanish"
        '
        'optlang6
        '
        Me.optlang6.Location = New System.Drawing.Point(16, 142)
        Me.optlang6.Name = "optlang6"
        Me.optlang6.Size = New System.Drawing.Size(96, 24)
        Me.optlang6.TabIndex = 5
        Me.optlang6.Text = "Portuguese"
        '
        'optlang5
        '
        Me.optlang5.Location = New System.Drawing.Point(16, 122)
        Me.optlang5.Name = "optlang5"
        Me.optlang5.Size = New System.Drawing.Size(104, 16)
        Me.optlang5.TabIndex = 4
        Me.optlang5.Text = "Dutch"
        '
        'optlang4
        '
        Me.optlang4.Location = New System.Drawing.Point(16, 96)
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
        Me.GroupBox4.Location = New System.Drawing.Point(480, 584)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 101)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Zone"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(16, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 47)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "You may draw the selection rectangle on image and click Start Regcognize button"
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optoutput2)
        Me.GroupBox5.Controls.Add(Me.optoutput1)
        Me.GroupBox5.Location = New System.Drawing.Point(480, 699)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(328, 80)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Output"
        '
        'optoutput2
        '
        Me.optoutput2.Location = New System.Drawing.Point(24, 48)
        Me.optoutput2.Name = "optoutput2"
        Me.optoutput2.Size = New System.Drawing.Size(288, 24)
        Me.optoutput2.TabIndex = 1
        Me.optoutput2.Text = "Write the recognized text to text file"
        '
        'optoutput1
        '
        Me.optoutput1.Checked = True
        Me.optoutput1.Location = New System.Drawing.Point(24, 24)
        Me.optoutput1.Name = "optoutput1"
        Me.optoutput1.Size = New System.Drawing.Size(288, 24)
        Me.optoutput1.TabIndex = 0
        Me.optoutput1.TabStop = True
        Me.optoutput1.Text = "Display the recognized text"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(24, 680)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 48)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Start Recognize"
        '
        'cmdprevpage
        '
        Me.cmdprevpage.Location = New System.Drawing.Point(648, 60)
        Me.cmdprevpage.Name = "cmdprevpage"
        Me.cmdprevpage.Size = New System.Drawing.Size(48, 24)
        Me.cmdprevpage.TabIndex = 17
        Me.cmdprevpage.Text = "<<"
        '
        'cmdnextpage
        '
        Me.cmdnextpage.Location = New System.Drawing.Point(712, 60)
        Me.cmdnextpage.Name = "cmdnextpage"
        Me.cmdnextpage.Size = New System.Drawing.Size(48, 24)
        Me.cmdnextpage.TabIndex = 18
        Me.cmdnextpage.Text = ">>"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 600)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Recognized Character"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(208, 600)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "0"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(192, 680)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 48)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Stop"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton2)
        Me.GroupBox6.Controls.Add(Me.OptMode)
        Me.GroupBox6.Location = New System.Drawing.Point(24, 624)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(360, 48)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(168, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(160, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Blocking Mode"
        '
        'OptMode
        '
        Me.OptMode.Checked = True
        Me.OptMode.Location = New System.Drawing.Point(24, 24)
        Me.OptMode.Name = "OptMode"
        Me.OptMode.Size = New System.Drawing.Size(128, 16)
        Me.OptMode.TabIndex = 0
        Me.OptMode.TabStop = True
        Me.OptMode.Text = "Asynchronous Mode"
        '
        'chkuseadvpdf
        '
        Me.chkuseadvpdf.AutoSize = True
        Me.chkuseadvpdf.Location = New System.Drawing.Point(485, 19)
        Me.chkuseadvpdf.Name = "chkuseadvpdf"
        Me.chkuseadvpdf.Size = New System.Drawing.Size(156, 17)
        Me.chkuseadvpdf.TabIndex = 23
        Me.chkuseadvpdf.Text = "Use Advanced PDF Viewer"
        Me.chkuseadvpdf.UseVisualStyleBackColor = True
        '
        'optlang8
        '
        Me.optlang8.Location = New System.Drawing.Point(16, 192)
        Me.optlang8.Name = "optlang8"
        Me.optlang8.Size = New System.Drawing.Size(128, 24)
        Me.optlang8.TabIndex = 7
        Me.optlang8.Text = "Chinese (Simplified)"
        '
        'optlang9
        '
        Me.optlang9.ForeColor = System.Drawing.Color.Blue
        Me.optlang9.Location = New System.Drawing.Point(144, 20)
        Me.optlang9.Name = "optlang9"
        Me.optlang9.Size = New System.Drawing.Size(128, 24)
        Me.optlang9.TabIndex = 8
        Me.optlang9.Text = "Chinese (Traditional)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(488, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(572, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "For additional language (blue color), you need download the language pack from ww" & _
    "w.viscomsoft.com/ocrlanguage.zip "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(488, 341)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(273, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Unzip the file and copy all files to dictfiles/tessdata folder"
        '
        'optlang10
        '
        Me.optlang10.ForeColor = System.Drawing.Color.Blue
        Me.optlang10.Location = New System.Drawing.Point(144, 44)
        Me.optlang10.Name = "optlang10"
        Me.optlang10.Size = New System.Drawing.Size(128, 24)
        Me.optlang10.TabIndex = 9
        Me.optlang10.Text = "Arabic"
        '
        'optlang11
        '
        Me.optlang11.ForeColor = System.Drawing.Color.Blue
        Me.optlang11.Location = New System.Drawing.Point(144, 68)
        Me.optlang11.Name = "optlang11"
        Me.optlang11.Size = New System.Drawing.Size(128, 24)
        Me.optlang11.TabIndex = 10
        Me.optlang11.Text = "Bulgarian"
        '
        'optlang12
        '
        Me.optlang12.ForeColor = System.Drawing.Color.Blue
        Me.optlang12.Location = New System.Drawing.Point(144, 92)
        Me.optlang12.Name = "optlang12"
        Me.optlang12.Size = New System.Drawing.Size(128, 24)
        Me.optlang12.TabIndex = 11
        Me.optlang12.Text = "Catalan"
        '
        'optlang13
        '
        Me.optlang13.ForeColor = System.Drawing.Color.Blue
        Me.optlang13.Location = New System.Drawing.Point(144, 118)
        Me.optlang13.Name = "optlang13"
        Me.optlang13.Size = New System.Drawing.Size(128, 24)
        Me.optlang13.TabIndex = 12
        Me.optlang13.Text = "Czech"
        '
        'optlang14
        '
        Me.optlang14.ForeColor = System.Drawing.Color.Blue
        Me.optlang14.Location = New System.Drawing.Point(144, 142)
        Me.optlang14.Name = "optlang14"
        Me.optlang14.Size = New System.Drawing.Size(128, 24)
        Me.optlang14.TabIndex = 13
        Me.optlang14.Text = "Cheroke"
        '
        'optlang15
        '
        Me.optlang15.ForeColor = System.Drawing.Color.Blue
        Me.optlang15.Location = New System.Drawing.Point(144, 166)
        Me.optlang15.Name = "optlang15"
        Me.optlang15.Size = New System.Drawing.Size(128, 24)
        Me.optlang15.TabIndex = 14
        Me.optlang15.Text = "Danish"
        '
        'optlang16
        '
        Me.optlang16.ForeColor = System.Drawing.Color.Blue
        Me.optlang16.Location = New System.Drawing.Point(144, 192)
        Me.optlang16.Name = "optlang16"
        Me.optlang16.Size = New System.Drawing.Size(128, 24)
        Me.optlang16.TabIndex = 15
        Me.optlang16.Text = "Danish (Fraktur)"
        '
        'optlang17
        '
        Me.optlang17.ForeColor = System.Drawing.Color.Blue
        Me.optlang17.Location = New System.Drawing.Point(278, 20)
        Me.optlang17.Name = "optlang17"
        Me.optlang17.Size = New System.Drawing.Size(128, 24)
        Me.optlang17.TabIndex = 16
        Me.optlang17.Text = "Greek"
        '
        'optlang18
        '
        Me.optlang18.ForeColor = System.Drawing.Color.Blue
        Me.optlang18.Location = New System.Drawing.Point(278, 44)
        Me.optlang18.Name = "optlang18"
        Me.optlang18.Size = New System.Drawing.Size(128, 24)
        Me.optlang18.TabIndex = 17
        Me.optlang18.Text = "Finnish"
        '
        'optlang19
        '
        Me.optlang19.ForeColor = System.Drawing.Color.Blue
        Me.optlang19.Location = New System.Drawing.Point(278, 68)
        Me.optlang19.Name = "optlang19"
        Me.optlang19.Size = New System.Drawing.Size(72, 24)
        Me.optlang19.TabIndex = 18
        Me.optlang19.Text = "French"
        '
        'optlang20
        '
        Me.optlang20.ForeColor = System.Drawing.Color.Blue
        Me.optlang20.Location = New System.Drawing.Point(276, 92)
        Me.optlang20.Name = "optlang20"
        Me.optlang20.Size = New System.Drawing.Size(86, 24)
        Me.optlang20.TabIndex = 19
        Me.optlang20.Text = "Hebrew"
        '
        'optlang21
        '
        Me.optlang21.ForeColor = System.Drawing.Color.Blue
        Me.optlang21.Location = New System.Drawing.Point(276, 118)
        Me.optlang21.Name = "optlang21"
        Me.optlang21.Size = New System.Drawing.Size(128, 24)
        Me.optlang21.TabIndex = 20
        Me.optlang21.Text = "Hindi"
        '
        'optlang22
        '
        Me.optlang22.ForeColor = System.Drawing.Color.Blue
        Me.optlang22.Location = New System.Drawing.Point(278, 142)
        Me.optlang22.Name = "optlang22"
        Me.optlang22.Size = New System.Drawing.Size(128, 24)
        Me.optlang22.TabIndex = 21
        Me.optlang22.Text = "Hungarian"
        '
        'optlang23
        '
        Me.optlang23.ForeColor = System.Drawing.Color.Blue
        Me.optlang23.Location = New System.Drawing.Point(278, 166)
        Me.optlang23.Name = "optlang23"
        Me.optlang23.Size = New System.Drawing.Size(128, 24)
        Me.optlang23.TabIndex = 22
        Me.optlang23.Text = "Indonesian"
        '
        'optlang24
        '
        Me.optlang24.ForeColor = System.Drawing.Color.Blue
        Me.optlang24.Location = New System.Drawing.Point(278, 192)
        Me.optlang24.Name = "optlang24"
        Me.optlang24.Size = New System.Drawing.Size(128, 24)
        Me.optlang24.TabIndex = 23
        Me.optlang24.Text = "Japanese"
        '
        'optlang25
        '
        Me.optlang25.ForeColor = System.Drawing.Color.Blue
        Me.optlang25.Location = New System.Drawing.Point(368, 20)
        Me.optlang25.Name = "optlang25"
        Me.optlang25.Size = New System.Drawing.Size(128, 24)
        Me.optlang25.TabIndex = 24
        Me.optlang25.Text = "Korean"
        '
        'optlang26
        '
        Me.optlang26.ForeColor = System.Drawing.Color.Blue
        Me.optlang26.Location = New System.Drawing.Point(368, 44)
        Me.optlang26.Name = "optlang26"
        Me.optlang26.Size = New System.Drawing.Size(128, 24)
        Me.optlang26.TabIndex = 25
        Me.optlang26.Text = "Latvian"
        '
        'optlang27
        '
        Me.optlang27.ForeColor = System.Drawing.Color.Blue
        Me.optlang27.Location = New System.Drawing.Point(368, 68)
        Me.optlang27.Name = "optlang27"
        Me.optlang27.Size = New System.Drawing.Size(128, 24)
        Me.optlang27.TabIndex = 26
        Me.optlang27.Text = "Lithuanian"
        '
        'optlang28
        '
        Me.optlang28.ForeColor = System.Drawing.Color.Blue
        Me.optlang28.Location = New System.Drawing.Point(368, 92)
        Me.optlang28.Name = "optlang28"
        Me.optlang28.Size = New System.Drawing.Size(128, 24)
        Me.optlang28.TabIndex = 27
        Me.optlang28.Text = "Norwegian"
        '
        'optlang29
        '
        Me.optlang29.ForeColor = System.Drawing.Color.Blue
        Me.optlang29.Location = New System.Drawing.Point(368, 118)
        Me.optlang29.Name = "optlang29"
        Me.optlang29.Size = New System.Drawing.Size(128, 24)
        Me.optlang29.TabIndex = 28
        Me.optlang29.Text = "Polish"
        '
        'optlang30
        '
        Me.optlang30.ForeColor = System.Drawing.Color.Blue
        Me.optlang30.Location = New System.Drawing.Point(368, 144)
        Me.optlang30.Name = "optlang30"
        Me.optlang30.Size = New System.Drawing.Size(128, 24)
        Me.optlang30.TabIndex = 29
        Me.optlang30.Text = "Romanian"
        '
        'optlang31
        '
        Me.optlang31.ForeColor = System.Drawing.Color.Blue
        Me.optlang31.Location = New System.Drawing.Point(368, 166)
        Me.optlang31.Name = "optlang31"
        Me.optlang31.Size = New System.Drawing.Size(128, 24)
        Me.optlang31.TabIndex = 30
        Me.optlang31.Text = "Russian"
        '
        'optlang32
        '
        Me.optlang32.ForeColor = System.Drawing.Color.Blue
        Me.optlang32.Location = New System.Drawing.Point(368, 192)
        Me.optlang32.Name = "optlang32"
        Me.optlang32.Size = New System.Drawing.Size(81, 24)
        Me.optlang32.TabIndex = 31
        Me.optlang32.Text = "Slovakian "
        '
        'optlang33
        '
        Me.optlang33.ForeColor = System.Drawing.Color.Blue
        Me.optlang33.Location = New System.Drawing.Point(459, 20)
        Me.optlang33.Name = "optlang33"
        Me.optlang33.Size = New System.Drawing.Size(121, 24)
        Me.optlang33.TabIndex = 32
        Me.optlang33.Text = "Slovakian Fraktur"
        '
        'optlang34
        '
        Me.optlang34.ForeColor = System.Drawing.Color.Blue
        Me.optlang34.Location = New System.Drawing.Point(459, 44)
        Me.optlang34.Name = "optlang34"
        Me.optlang34.Size = New System.Drawing.Size(121, 24)
        Me.optlang34.TabIndex = 33
        Me.optlang34.Text = "Slovenian"
        '
        'optlang35
        '
        Me.optlang35.ForeColor = System.Drawing.Color.Blue
        Me.optlang35.Location = New System.Drawing.Point(459, 68)
        Me.optlang35.Name = "optlang35"
        Me.optlang35.Size = New System.Drawing.Size(121, 24)
        Me.optlang35.TabIndex = 34
        Me.optlang35.Text = "Serbian (Latin)"
        '
        'optlang36
        '
        Me.optlang36.ForeColor = System.Drawing.Color.Blue
        Me.optlang36.Location = New System.Drawing.Point(459, 92)
        Me.optlang36.Name = "optlang36"
        Me.optlang36.Size = New System.Drawing.Size(121, 24)
        Me.optlang36.TabIndex = 35
        Me.optlang36.Text = "Swedish"
        '
        'optlang37
        '
        Me.optlang37.ForeColor = System.Drawing.Color.Blue
        Me.optlang37.Location = New System.Drawing.Point(459, 118)
        Me.optlang37.Name = "optlang37"
        Me.optlang37.Size = New System.Drawing.Size(121, 24)
        Me.optlang37.TabIndex = 36
        Me.optlang37.Text = "Swedish (Fraktur)"
        '
        'optlang38
        '
        Me.optlang38.ForeColor = System.Drawing.Color.Blue
        Me.optlang38.Location = New System.Drawing.Point(459, 142)
        Me.optlang38.Name = "optlang38"
        Me.optlang38.Size = New System.Drawing.Size(121, 24)
        Me.optlang38.TabIndex = 37
        Me.optlang38.Text = "Tagalog"
        '
        'optlang39
        '
        Me.optlang39.ForeColor = System.Drawing.Color.Blue
        Me.optlang39.Location = New System.Drawing.Point(459, 166)
        Me.optlang39.Name = "optlang39"
        Me.optlang39.Size = New System.Drawing.Size(121, 24)
        Me.optlang39.TabIndex = 38
        Me.optlang39.Text = "Thai"
        '
        'optlang40
        '
        Me.optlang40.ForeColor = System.Drawing.Color.Blue
        Me.optlang40.Location = New System.Drawing.Point(459, 192)
        Me.optlang40.Name = "optlang40"
        Me.optlang40.Size = New System.Drawing.Size(121, 24)
        Me.optlang40.TabIndex = 39
        Me.optlang40.Text = "Turkish"
        '
        'optlang41
        '
        Me.optlang41.ForeColor = System.Drawing.Color.Blue
        Me.optlang41.Location = New System.Drawing.Point(592, 20)
        Me.optlang41.Name = "optlang41"
        Me.optlang41.Size = New System.Drawing.Size(86, 24)
        Me.optlang41.TabIndex = 40
        Me.optlang41.Text = "Ukrainian"
        '
        'optlang42
        '
        Me.optlang42.ForeColor = System.Drawing.Color.Blue
        Me.optlang42.Location = New System.Drawing.Point(592, 44)
        Me.optlang42.Name = "optlang42"
        Me.optlang42.Size = New System.Drawing.Size(86, 24)
        Me.optlang42.TabIndex = 41
        Me.optlang42.Text = "Vietnamese"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1205, 778)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkuseadvpdf)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdprevpage)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
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
        Me.Text = "OCR to text"
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
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

        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight

        AxImageViewer1.MouseTrackMode = 2
        Button2.Enabled = True
        Button3.Enabled = True

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim iLangIndex As Integer
        Dim iMode As Integer
        Dim iResult As Integer
        Dim bResult As Boolean

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

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optlang12.CheckedChanged

    End Sub
End Class
