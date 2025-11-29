<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckBox
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.lblindex = New System.Windows.Forms.Label()
        Me.lblindexcaption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 63)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(223, 15)
        Me.label1.TabIndex = 14
        Me.label1.Text = "The value of this check box"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(249, 93)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(84, 29)
        Me.button1.TabIndex = 13
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(249, 61)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(18, 17)
        Me.checkBox1.TabIndex = 12
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'lblindex
        '
        Me.lblindex.AutoSize = True
        Me.lblindex.Location = New System.Drawing.Point(193, 19)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(15, 15)
        Me.lblindex.TabIndex = 11
        Me.lblindex.Text = "0"
        '
        'lblindexcaption
        '
        Me.lblindexcaption.AutoSize = True
        Me.lblindexcaption.Location = New System.Drawing.Point(12, 19)
        Me.lblindexcaption.Name = "lblindexcaption"
        Me.lblindexcaption.Size = New System.Drawing.Size(175, 15)
        Me.lblindexcaption.TabIndex = 10
        Me.lblindexcaption.Text = "The idex of fields is"
        '
        'FormCheckBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 143)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.lblindex)
        Me.Controls.Add(Me.lblindexcaption)
        Me.Name = "FormCheckBox"
        Me.Text = "CheckBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents lblindex As System.Windows.Forms.Label
    Private WithEvents lblindexcaption As System.Windows.Forms.Label
End Class
