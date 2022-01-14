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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents txtdelpageno As System.Windows.Forms.TextBox
    Friend WithEvents txtaddpageno As System.Windows.Forms.TextBox
    Friend WithEvents axImageViewer1 As AxSCRIBBLELib.AxImageViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.txtdelpageno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtaddpageno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button8 = New System.Windows.Forms.Button
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.axImageViewer1 = New AxSCRIBBLELib.AxImageViewer
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.axImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Merge TIF"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(104, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 32)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Merge two tif files into one tif"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(432, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Select File"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(104, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(320, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TIF file 2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select File"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(104, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIF file 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 120)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Split TIF"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(440, 24)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 24)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Select File"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(224, 64)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 24)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Split one tif to two tif files"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(160, 64)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(48, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Split From Page No."
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(104, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(320, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TIF Source"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.txtdelpageno)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 80)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delete TIF Page"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(176, 48)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 24)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Delete Page"
        '
        'txtdelpageno
        '
        Me.txtdelpageno.Location = New System.Drawing.Point(112, 48)
        Me.txtdelpageno.Name = "txtdelpageno"
        Me.txtdelpageno.Size = New System.Drawing.Size(48, 20)
        Me.txtdelpageno.TabIndex = 4
        Me.txtdelpageno.Text = "1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Delete Page No."
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(440, 24)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 24)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Select File"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(96, 24)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(336, 20)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TIF Source"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtaddpageno)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 368)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 128)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Add TIF Page"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(120, 96)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(72, 32)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Add Page"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(440, 64)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(72, 24)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "Select File"
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(120, 64)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(312, 20)
        Me.TextBox9.TabIndex = 6
        Me.TextBox9.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Append From TIF"
        '
        'txtaddpageno
        '
        Me.txtaddpageno.Location = New System.Drawing.Point(120, 40)
        Me.txtaddpageno.Name = "txtaddpageno"
        Me.txtaddpageno.Size = New System.Drawing.Size(48, 20)
        Me.txtaddpageno.TabIndex = 4
        Me.txtaddpageno.Text = "1"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Insert At Page No."
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(440, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(72, 24)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Select File"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(120, 16)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(312, 20)
        Me.TextBox7.TabIndex = 1
        Me.TextBox7.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TIF Source"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button12)
        Me.GroupBox5.Controls.Add(Me.TextBox12)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TextBox11)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Controls.Add(Me.TextBox10)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 504)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(520, 104)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Swap TIF Page"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(216, 64)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(120, 24)
        Me.Button12.TabIndex = 7
        Me.Button12.Text = "Swap TIF"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(120, 72)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(64, 20)
        Me.TextBox12.TabIndex = 6
        Me.TextBox12.Text = "2"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Page No. b"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(120, 48)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(64, 20)
        Me.TextBox11.TabIndex = 4
        Me.TextBox11.Text = "1"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Page No. a"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(440, 16)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(72, 24)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "Select File"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(120, 16)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(312, 20)
        Me.TextBox10.TabIndex = 1
        Me.TextBox10.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "TIF Source"
        '
        'axImageViewer1
        '
        Me.axImageViewer1.Enabled = True
        Me.axImageViewer1.Location = New System.Drawing.Point(544, 576)
        Me.axImageViewer1.Name = "axImageViewer1"
        Me.axImageViewer1.OcxState = CType(resources.GetObject("axImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axImageViewer1.Size = New System.Drawing.Size(200, 200)
        Me.axImageViewer1.TabIndex = 5
        Me.axImageViewer1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(568, 630)
        Me.Controls.Add(Me.axImageViewer1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Merge, Split, Add, Delete, Swap page of TIF  (without decoding the image)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.axImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "TIFF file (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "TIFF file (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.Filter = "TIFF file (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenFileDialog1.Filter = "TIFF file (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox5.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        OpenFileDialog1.Filter = "TIFF file (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox7.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        OpenFileDialog1.Filter = "TIFF file (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox9.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        OpenFileDialog1.Filter = "TIFF file (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox10.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim result As Boolean
        If TextBox1.Text = "" Then

            MsgBox("Please input TIF 1 file")
            Exit Sub
        End If

        If TextBox2.Text = "" Then

            MsgBox("Please input TIF 2 file")
            Exit Sub
        End If

        result = axImageViewer1.TIFMerge(TextBox1.Text, TextBox2.Text, "c:\test.tif")

        If result Then

            MsgBox("merge c:\test.tif completed")

        Else
            MsgBox("merge failed")

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim result As Boolean
        If TextBox3.Text = "" Then

            MsgBox("Please input TIF 1 file")
            Exit Sub
        End If


        result = AxImageViewer1.TIFSplit(TextBox3.Text, TextBox4.Text, "c:\testsplit1.tif", "c:\testsplit2.tif")

        If result Then

            MsgBox("Split to c:\testsplit1.tif and c:\testsplit2.tif completed")

        Else
            MsgBox("Split failed")

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim result As Boolean
        If TextBox5.Text = "" Then

            MsgBox("Please input TIF Source")
            Exit Sub
        End If

        result = AxImageViewer1.TIFDeletePage(TextBox5.Text, txtdelpageno.Text)
        If result Then

            MsgBox("Delete Page Completed")

        Else
            MsgBox("Delete Page failed")


        End If

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim result As Boolean
        If TextBox7.Text = "" Then

            MsgBox("Please input TIF Source")
            Exit Sub
        End If


        If TextBox9.Text = "" Then

            MsgBox("Please input Append From TIF")
            Exit Sub
        End If


        result = AxImageViewer1.TIFAddPage(TextBox7.Text, txtaddpageno.Text, TextBox9.Text)

        If result Then

            MsgBox("Add Page Completed")

        Else
            MsgBox("Add failed")

        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim result As Boolean
        If TextBox10.Text = "" Then

            MsgBox("Please input TIF Source")
            Exit Sub
        End If


        result = AxImageViewer1.TIFSwap(TextBox10.Text, TextBox11.Text, TextBox12.Text)

        If result Then

            MsgBox("Swap Page Completed")

        Else
            MsgBox("Swap failed")

        End If
    End Sub
End Class
