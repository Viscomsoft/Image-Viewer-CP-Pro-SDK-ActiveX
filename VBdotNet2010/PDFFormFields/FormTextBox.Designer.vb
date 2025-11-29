<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTextBox
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
        Me.lblindex = New System.Windows.Forms.Label()
        Me.lblindexcaption = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblindex
        '
        Me.lblindex.AutoSize = True
        Me.lblindex.Location = New System.Drawing.Point(196, 10)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(15, 15)
        Me.lblindex.TabIndex = 12
        Me.lblindex.Text = "0"
        '
        'lblindexcaption
        '
        Me.lblindexcaption.AutoSize = True
        Me.lblindexcaption.Location = New System.Drawing.Point(12, 9)
        Me.lblindexcaption.Name = "lblindexcaption"
        Me.lblindexcaption.Size = New System.Drawing.Size(175, 15)
        Me.lblindexcaption.TabIndex = 11
        Me.lblindexcaption.Text = "The idex of fields is"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(246, 108)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(102, 35)
        Me.button1.TabIndex = 10
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(15, 67)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(211, 25)
        Me.textBox1.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(183, 15)
        Me.label1.TabIndex = 8
        Me.label1.Text = "The text of this field"
        '
        'FormTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 152)
        Me.Controls.Add(Me.lblindex)
        Me.Controls.Add(Me.lblindexcaption)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "FormTextBox"
        Me.Text = "TextBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblindex As System.Windows.Forms.Label
    Private WithEvents lblindexcaption As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
