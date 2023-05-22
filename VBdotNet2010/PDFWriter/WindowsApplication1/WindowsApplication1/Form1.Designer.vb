<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.cbofont = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcaption = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbillto = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(824, 52)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(138, 179)
        Me.AxImageViewer1.TabIndex = 0
        '
        'cbofont
        '
        Me.cbofont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofont.FormattingEnabled = True
        Me.cbofont.Location = New System.Drawing.Point(240, 36)
        Me.cbofont.Name = "cbofont"
        Me.cbofont.Size = New System.Drawing.Size(282, 32)
        Me.cbofont.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Font"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 82)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Create PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Caption"
        '
        'txtcaption
        '
        Me.txtcaption.Location = New System.Drawing.Point(240, 109)
        Me.txtcaption.Name = "txtcaption"
        Me.txtcaption.Size = New System.Drawing.Size(282, 35)
        Me.txtcaption.TabIndex = 5
        Me.txtcaption.Text = "INVOICE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bill To:"
        '
        'txtbillto
        '
        Me.txtbillto.Location = New System.Drawing.Point(240, 250)
        Me.txtbillto.Name = "txtbillto"
        Me.txtbillto.Size = New System.Drawing.Size(282, 35)
        Me.txtbillto.TabIndex = 7
        Me.txtbillto.Text = "ABC Company"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(240, 183)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(282, 35)
        Me.txtdate.TabIndex = 8
        Me.txtdate.Text = "9-5-2023"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 528)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txtbillto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcaption)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbofont)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Name = "Form1"
        Me.Text = "PDF Writer Demo"
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents cbofont As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcaption As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbillto As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
