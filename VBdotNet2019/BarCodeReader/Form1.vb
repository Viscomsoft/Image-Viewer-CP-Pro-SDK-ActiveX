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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cmdprevpage As System.Windows.Forms.Button
    Friend WithEvents txtPageNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttotpage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdnextpage As System.Windows.Forms.Button
    Friend WithEvents txtfileheight As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfilewidth As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttop As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtleft As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkfullpage As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkscanmore As System.Windows.Forms.CheckBox
    Friend WithEvents txtcustomrotation As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkScan90Rotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkScan45CounterRotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkScan45Rotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkscannorotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkScanMultiple As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbopdfimagecount As System.Windows.Forms.ComboBox
    Friend WithEvents cbopdfpage As System.Windows.Forms.ComboBox
    Friend WithEvents chkuseadvbarpdf As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.cmdprevpage = New System.Windows.Forms.Button()
        Me.txtPageNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttotpage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdnextpage = New System.Windows.Forms.Button()
        Me.txtfileheight = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfilewidth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttop = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtleft = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkfullpage = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkscanmore = New System.Windows.Forms.CheckBox()
        Me.txtcustomrotation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkScan90Rotation = New System.Windows.Forms.CheckBox()
        Me.chkScan45CounterRotation = New System.Windows.Forms.CheckBox()
        Me.chkScan45Rotation = New System.Windows.Forms.CheckBox()
        Me.chkscannorotation = New System.Windows.Forms.CheckBox()
        Me.chkScanMultiple = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbopdfimagecount = New System.Windows.Forms.ComboBox()
        Me.cbopdfpage = New System.Windows.Forms.ComboBox()
        Me.chkuseadvbarpdf = New System.Windows.Forms.CheckBox()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(18, 16)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(515, 451)
        Me.AxImageViewer1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(557, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Read QR Code Demo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(738, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 33)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Read 1D Barcode Demo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(916, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 33)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Read Multiple Barcode Demo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(557, 52)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(156, 31)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Read DataMatrix Demo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(738, 55)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(156, 38)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Read barcode at any orientation"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(915, 55)
        Me.Button7.Name = "Button7"
        Me.Button7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button7.Size = New System.Drawing.Size(188, 32)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Read barcode from PDF using Advanced Barcode Reader"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'cmdprevpage
        '
        Me.cmdprevpage.Location = New System.Drawing.Point(729, 177)
        Me.cmdprevpage.Name = "cmdprevpage"
        Me.cmdprevpage.Size = New System.Drawing.Size(57, 26)
        Me.cmdprevpage.TabIndex = 27
        Me.cmdprevpage.Text = "<<"
        '
        'txtPageNo
        '
        Me.txtPageNo.Location = New System.Drawing.Point(816, 234)
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.Size = New System.Drawing.Size(58, 21)
        Me.txtPageNo.TabIndex = 26
        Me.txtPageNo.Text = "1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(720, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 26)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Page No"
        '
        'txttotpage
        '
        Me.txttotpage.Location = New System.Drawing.Point(634, 234)
        Me.txttotpage.Name = "txttotpage"
        Me.txttotpage.Size = New System.Drawing.Size(67, 21)
        Me.txttotpage.TabIndex = 24
        Me.txttotpage.Text = "1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(547, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Total Page"
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(547, 208)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(327, 21)
        Me.txtfilename.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(557, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 35)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Select Image"
        '
        'cmdnextpage
        '
        Me.cmdnextpage.Location = New System.Drawing.Point(806, 177)
        Me.cmdnextpage.Name = "cmdnextpage"
        Me.cmdnextpage.Size = New System.Drawing.Size(57, 26)
        Me.cmdnextpage.TabIndex = 28
        Me.cmdnextpage.Text = ">>"
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
        Me.GroupBox4.Controls.Add(Me.chkfullpage)
        Me.GroupBox4.Location = New System.Drawing.Point(551, 277)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(719, 89)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Zone - Selected specific zone to  increase barcode recognition accuracy"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(106, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(606, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Uncheck this button, You may draw the selection rectangle on image and click Dete" & _
            "ct BarCode button"
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
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(554, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 2)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(554, 550)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(236, 78)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Detect Barcode"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkscanmore)
        Me.GroupBox2.Controls.Add(Me.txtcustomrotation)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkScan90Rotation)
        Me.GroupBox2.Controls.Add(Me.chkScan45CounterRotation)
        Me.GroupBox2.Controls.Add(Me.chkScan45Rotation)
        Me.GroupBox2.Controls.Add(Me.chkscannorotation)
        Me.GroupBox2.Controls.Add(Me.chkScanMultiple)
        Me.GroupBox2.Location = New System.Drawing.Point(557, 386)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(675, 147)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UnSelected some option, it will scan more faster"
        '
        'chkscanmore
        '
        Me.chkscanmore.AutoSize = True
        Me.chkscanmore.Checked = True
        Me.chkscanmore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkscanmore.Location = New System.Drawing.Point(264, 121)
        Me.chkscanmore.Name = "chkscanmore"
        Me.chkscanmore.Size = New System.Drawing.Size(132, 16)
        Me.chkscanmore.TabIndex = 7
        Me.chkscanmore.Text = "Scan More Accuracy"
        Me.chkscanmore.UseVisualStyleBackColor = True
        '
        'txtcustomrotation
        '
        Me.txtcustomrotation.Location = New System.Drawing.Point(386, 93)
        Me.txtcustomrotation.Name = "txtcustomrotation"
        Me.txtcustomrotation.Size = New System.Drawing.Size(128, 21)
        Me.txtcustomrotation.TabIndex = 6
        Me.txtcustomrotation.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Custom Rotation"
        '
        'chkScan90Rotation
        '
        Me.chkScan90Rotation.AutoSize = True
        Me.chkScan90Rotation.Checked = True
        Me.chkScan90Rotation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScan90Rotation.Location = New System.Drawing.Point(264, 62)
        Me.chkScan90Rotation.Name = "chkScan90Rotation"
        Me.chkScan90Rotation.Size = New System.Drawing.Size(192, 16)
        Me.chkScan90Rotation.TabIndex = 4
        Me.chkScan90Rotation.Text = "Scan With 90 Degree Rotation"
        Me.chkScan90Rotation.UseVisualStyleBackColor = True
        '
        'chkScan45CounterRotation
        '
        Me.chkScan45CounterRotation.AutoSize = True
        Me.chkScan45CounterRotation.Checked = True
        Me.chkScan45CounterRotation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScan45CounterRotation.Location = New System.Drawing.Point(264, 29)
        Me.chkScan45CounterRotation.Name = "chkScan45CounterRotation"
        Me.chkScan45CounterRotation.Size = New System.Drawing.Size(300, 16)
        Me.chkScan45CounterRotation.TabIndex = 3
        Me.chkScan45CounterRotation.Text = "Scan With 45 Degree Counter Clockwise Rotation"
        Me.chkScan45CounterRotation.UseVisualStyleBackColor = True
        '
        'chkScan45Rotation
        '
        Me.chkScan45Rotation.AutoSize = True
        Me.chkScan45Rotation.Checked = True
        Me.chkScan45Rotation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScan45Rotation.Location = New System.Drawing.Point(25, 97)
        Me.chkScan45Rotation.Name = "chkScan45Rotation"
        Me.chkScan45Rotation.Size = New System.Drawing.Size(192, 16)
        Me.chkScan45Rotation.TabIndex = 2
        Me.chkScan45Rotation.Text = "Scan With 45 Degree Rotation"
        Me.chkScan45Rotation.UseVisualStyleBackColor = True
        '
        'chkscannorotation
        '
        Me.chkscannorotation.AutoSize = True
        Me.chkscannorotation.Checked = True
        Me.chkscannorotation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkscannorotation.Location = New System.Drawing.Point(25, 62)
        Me.chkscannorotation.Name = "chkscannorotation"
        Me.chkscannorotation.Size = New System.Drawing.Size(150, 16)
        Me.chkscannorotation.TabIndex = 1
        Me.chkscannorotation.Text = "Scan Without Rotation"
        Me.chkscannorotation.UseVisualStyleBackColor = True
        '
        'chkScanMultiple
        '
        Me.chkScanMultiple.AutoSize = True
        Me.chkScanMultiple.Checked = True
        Me.chkScanMultiple.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScanMultiple.Location = New System.Drawing.Point(25, 29)
        Me.chkScanMultiple.Name = "chkScanMultiple"
        Me.chkScanMultiple.Size = New System.Drawing.Size(150, 16)
        Me.chkScanMultiple.TabIndex = 0
        Me.chkScanMultiple.Text = "Scan Multiple Barcode"
        Me.chkScanMultiple.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbopdfimagecount)
        Me.GroupBox3.Controls.Add(Me.cbopdfpage)
        Me.GroupBox3.Controls.Add(Me.chkuseadvbarpdf)
        Me.GroupBox3.Location = New System.Drawing.Point(554, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 64)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        '
        'cbopdfimagecount
        '
        Me.cbopdfimagecount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopdfimagecount.FormattingEnabled = True
        Me.cbopdfimagecount.Location = New System.Drawing.Point(119, 41)
        Me.cbopdfimagecount.Name = "cbopdfimagecount"
        Me.cbopdfimagecount.Size = New System.Drawing.Size(75, 20)
        Me.cbopdfimagecount.TabIndex = 2
        '
        'cbopdfpage
        '
        Me.cbopdfpage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopdfpage.FormattingEnabled = True
        Me.cbopdfpage.Location = New System.Drawing.Point(18, 41)
        Me.cbopdfpage.Name = "cbopdfpage"
        Me.cbopdfpage.Size = New System.Drawing.Size(75, 20)
        Me.cbopdfpage.TabIndex = 1
        '
        'chkuseadvbarpdf
        '
        Me.chkuseadvbarpdf.AutoSize = True
        Me.chkuseadvbarpdf.Location = New System.Drawing.Point(12, 17)
        Me.chkuseadvbarpdf.Name = "chkuseadvbarpdf"
        Me.chkuseadvbarpdf.Size = New System.Drawing.Size(210, 16)
        Me.chkuseadvbarpdf.TabIndex = 0
        Me.chkuseadvbarpdf.Text = "Advanced Barcode Reader for PDF"
        Me.chkuseadvbarpdf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1115, 650)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdprevpage)
        Me.Controls.Add(Me.txtPageNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotpage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfilename)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdnextpage)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "1D and 2D Barcode Reader"
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public strApp As String

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AxImageViewer1.BarCodeReadPDFClose()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iFindIndex As Integer
        strApp = Application.ExecutablePath
        iFindIndex = strApp.IndexOf("Examples")

        If iFindIndex <> -1 Then

        strApp = strApp.Substring(0, iFindIndex)

        strApp = strApp + "barcodeimage"
        End If


        AxImageViewer1.MouseTrackMode = 2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif|PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"





        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then


            '    txtsourceimage.Text = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub chkdrawbarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub chkfitrect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub AdvBarcodeReader_OpenPDF(ByVal strFileName As String)
        Dim iPDFPageCount As Integer
        Dim i As Integer
        cbopdfpage.Items.Clear()
        cbopdfimagecount.Items.Clear()

        iPDFPageCount = AxImageViewer1.BarCodeReadPDFOpen(strFileName)

        cbopdfpage.Items.Clear()
        For i = 1 To iPDFPageCount
            cbopdfpage.Items.Add("Page " + Trim(Str(i)))
        Next

        If cbopdfpage.Items.Count > 0 Then
            cbopdfpage.SelectedIndex = 0

        End If

        chkScanMultiple.Checked = False
        chkScan45CounterRotation.Checked = False
        chkScan90Rotation.Checked = False
        chkScan45Rotation.Checked = False
    End Sub


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim strFile As String

        Dim i As Integer
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtfilename.Text = OpenFileDialog1.FileName

            strFile = OpenFileDialog1.FileName

            If strFile.Substring(strFile.Length - 3, 3) = "tif" Or strFile.Substring(strFile.Length - 3, 3) = "pdf" Or strFile.Substring(strFile.Length - 3, 3) = "iff" Then

                If chkuseadvbarpdf.Checked Then

                    AxImageViewer1.LoadMultiPage(txtfilename.Text, 1)
                    txtPageNo.Text = "1"
                    txttotpage.Text = CStr(AxImageViewer1.GetTotalPage)
                    cmdnextpage.Enabled = True
                    cmdprevpage.Enabled = True

                    AdvBarcodeReader_OpenPDF(txtfilename.Text)

                Else
                    AxImageViewer1.LoadMultiPage(txtfilename.Text, 1)
                    txtPageNo.Text = "1"
                    txttotpage.Text = CStr(AxImageViewer1.GetTotalPage)
                    cmdnextpage.Enabled = True
                    cmdprevpage.Enabled = True

                End If


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

    End Sub

    Private Sub cmdnextpage_Click(sender As System.Object, e As System.EventArgs) Handles cmdnextpage.Click
        Dim CurrentIndex As Integer
        If txtPageNo.Text < AxImageViewer1.GetTotalPage Then
            txtPageNo.Text = txtPageNo.Text + 1
        Else
            txttotpage.Text = AxImageViewer1.GetTotalPage
        End If

        Me.AxImageViewer1.LoadMultiPage(txtfilename.Text, txtPageNo.Text)

        If chkuseadvbarpdf.Checked Then
            CurrentIndex = cbopdfpage.SelectedIndex + 1

            If CurrentIndex < cbopdfpage.Items.Count Then
                cbopdfpage.SelectedIndex = CurrentIndex

            End If
        End If

    End Sub

    Private Sub cmdprevpage_Click(sender As System.Object, e As System.EventArgs) Handles cmdprevpage.Click

        

        Dim CurrentIndex As Integer




        If txtPageNo.Text > 1 Then
            txtPageNo.Text = txtPageNo.Text - 1
        Else
            txtPageNo.Text = 1
        End If

        Me.AxImageViewer1.LoadMultiPage(txtfilename.Text, txtPageNo.Text)


        If chkuseadvbarpdf.Checked Then
            CurrentIndex = cbopdfpage.SelectedIndex - 1

            If CurrentIndex <> -1 Then
                cbopdfpage.SelectedIndex = CurrentIndex

            End If
        End If

    End Sub

    Private Sub chkfullpage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkfullpage.CheckedChanged

    End Sub

    Private Sub chkfullpage_Click(sender As Object, e As System.EventArgs) Handles chkfullpage.Click
        If chkfullpage.Checked Then

            AxImageViewer1.MouseTrackMode = 2
        Else
            AxImageViewer1.MouseTrackMode = 1
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim ibarcodeCount As Integer
        Dim str1 As String
        Dim i As Integer
        Dim strTmp As String

        Me.AxImageViewer1.BarCodeReadScanMultiple = chkScanMultiple.Checked
        Me.AxImageViewer1.BarCodeReadScanWithoutRotation = chkscannorotation.Checked
        Me.AxImageViewer1.BarCodeReadScan45Rotation = chkScan45Rotation.Checked
        Me.AxImageViewer1.BarCodeReadScan45CouterRotation = chkScan45CounterRotation.Checked
        Me.AxImageViewer1.BarCodeReadScan90Rotation = chkScan90Rotation.Checked
        Me.AxImageViewer1.BarCodeReadCustomRotation = txtcustomrotation.Text
        Me.AxImageViewer1.BarCodeReadScanAccuracy = chkscanmore.Checked

        If chkuseadvbarpdf.Checked Then
          
            ibarcodeCount = Me.AxImageViewer1.BarCodeReadPDFScan(Me.cbopdfpage.SelectedIndex + 1, Me.cbopdfimagecount.SelectedIndex + 1)

        Else


            If chkfullpage.Checked Then

                ibarcodeCount = Me.AxImageViewer1.BarCodeReadFullPage
            Else
                ibarcodeCount = Me.AxImageViewer1.BarCodeReadByZone(txtleft.Text, txttop.Text, txtfilewidth.Text, txtfileheight.Text)
            End If

        End If

        If ibarcodeCount < 1 Then

            MessageBox.Show("No barcode found")
            Exit Sub
        End If


        str1 = "Total " + Str(ibarcodeCount) + " BarCode detected" + Chr(13) + Chr(10)

        For i = 0 To ibarcodeCount - 1

            strTmp = Me.AxImageViewer1.BarCodeGetType(i) + " score:" + Str(Me.AxImageViewer1.BarCodeGetScore(i)) + " value:" + Me.AxImageViewer1.BarCodeGetValue(i)

            str1 = str1 + Chr(13) + Chr(10) + strTmp
        Next

        MessageBox.Show(str1)



    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        chkuseadvbarpdf.Checked = False
       
        Me.AxImageViewer1.FileName = strApp + "\barcodetest1.jpg"
        txttotpage.Text = 1
        txtPageNo.Text = 1
        cmdnextpage.Enabled = False
        cmdprevpage.Enabled = False
        txtfilename.Text = ""

        chkfullpage.Checked = True
        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        chkuseadvbarpdf.Checked = False

        Me.AxImageViewer1.FileName = strApp + "\barcodetest2.jpg"
        txttotpage.Text = 1
        txtPageNo.Text = 1
        cmdnextpage.Enabled = False
        cmdprevpage.Enabled = False
        txtfilename.Text = ""

        chkfullpage.Checked = True
        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight

    End Sub

    Private Sub AxImageViewer1_SelectionRectDrawn(sender As System.Object, e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent) Handles AxImageViewer1.SelectionRectDrawn
        If Not chkfullpage.Checked Then

            txtleft.Text = e.iLeft
            txttop.Text = e.iTop
            txtfilewidth.Text = e.iWidth
            txtfileheight.Text = e.iHeight
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.AxImageViewer1.FileName = strApp + "\barcodetest3.jpg"

        chkuseadvbarpdf.Checked = False
        chkScanMultiple.Checked = True

        txttotpage.Text = 1
        txtPageNo.Text = 1
        cmdnextpage.Enabled = False
        cmdprevpage.Enabled = False
        txtfilename.Text = ""

        chkfullpage.Checked = True
        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        chkuseadvbarpdf.Checked = False

        Me.AxImageViewer1.FileName = strApp + "\barcodetest4.png"
        txttotpage.Text = 1
        txtPageNo.Text = 1
        cmdnextpage.Enabled = False
        cmdprevpage.Enabled = False
        txtfilename.Text = ""

        chkfullpage.Checked = True
        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        chkuseadvbarpdf.Checked = False

        Me.AxImageViewer1.FileName = strApp + "\barcodetest5.jpg"
        txttotpage.Text = 1
        txtPageNo.Text = 1
        cmdnextpage.Enabled = False
        cmdprevpage.Enabled = False
        txtfilename.Text = ""

        chkfullpage.Checked = True
        chkScan90Rotation.Checked = True
        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        chkuseadvbarpdf.Checked = True
        chkscanmore.Checked = True
        chkscannorotation.Checked = True

        Me.AxImageViewer1.LoadMultiPage(strApp + "\barcodetest6.pdf", 1)

        AdvBarcodeReader_OpenPDF(strApp + "\barcodetest6.pdf")

        txttotpage.Text = 1
        txtPageNo.Text = 1
        cmdnextpage.Enabled = False
        cmdprevpage.Enabled = False
        txtfilename.Text = ""

        chkfullpage.Checked = True
        txtleft.Text = 0
        txttop.Text = 0
        txtfilewidth.Text = Me.AxImageViewer1.FileWidth
        txtfileheight.Text = Me.AxImageViewer1.FileHeight
    End Sub

    Private Sub cbopdfpage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopdfpage.Click
        
    End Sub

    Private Sub cbopdfpage_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbopdfpage.SelectedIndexChanged
        Dim iImageCountPerPage As Integer
        Dim i As Integer
        Me.cbopdfimagecount.Items.Clear()
        'first page is 1
        iImageCountPerPage = Me.AxImageViewer1.BarCodeReadPDFImageCount(cbopdfpage.SelectedIndex + 1)
        For i = 1 To iImageCountPerPage
            cbopdfimagecount.Items.Add("Image " + Trim(Str(i)))
        Next

        If cbopdfimagecount.Items.Count > 0 Then
            cbopdfimagecount.SelectedIndex = 0

        End If

        txtPageNo.Text = cbopdfpage.SelectedIndex + 1
    End Sub
End Class
