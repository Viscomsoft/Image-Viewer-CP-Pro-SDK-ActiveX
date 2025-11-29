<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCombobox
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
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtcomboboxindex = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblindex = New System.Windows.Forms.Label()
        Me.lblindexcaption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(278, 101)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(84, 29)
        Me.button1.TabIndex = 16
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtcomboboxindex
        '
        Me.txtcomboboxindex.Location = New System.Drawing.Point(313, 65)
        Me.txtcomboboxindex.Name = "txtcomboboxindex"
        Me.txtcomboboxindex.Size = New System.Drawing.Size(54, 25)
        Me.txtcomboboxindex.TabIndex = 15
        Me.txtcomboboxindex.Text = "0"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 68)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(295, 15)
        Me.label1.TabIndex = 14
        Me.label1.Text = "The index of this Combo box/ListBox "
        '
        'lblindex
        '
        Me.lblindex.AutoSize = True
        Me.lblindex.Location = New System.Drawing.Point(193, 18)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(15, 15)
        Me.lblindex.TabIndex = 13
        Me.lblindex.Text = "0"
        '
        'lblindexcaption
        '
        Me.lblindexcaption.AutoSize = True
        Me.lblindexcaption.Location = New System.Drawing.Point(12, 18)
        Me.lblindexcaption.Name = "lblindexcaption"
        Me.lblindexcaption.Size = New System.Drawing.Size(175, 15)
        Me.lblindexcaption.TabIndex = 12
        Me.lblindexcaption.Text = "The idex of fields is"
        '
        'FormCombobox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 151)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtcomboboxindex)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblindex)
        Me.Controls.Add(Me.lblindexcaption)
        Me.Name = "FormCombobox"
        Me.Text = "Combo box or List Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtcomboboxindex As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblindex As System.Windows.Forms.Label
    Private WithEvents lblindexcaption As System.Windows.Forms.Label
End Class
