Public Class FormCheckBox

    Public Property Checked() As Integer
        Get
            If checkBox1.Checked Then
                Return 1
            Else
                Return 0
            End If

        End Get

        Set(ByVal value As Integer)

            If value = 1 Then
                checkBox1.Checked = True
            Else
                checkBox1.Checked = False

            End If
        End Set

    End Property

    Public Property FieldIndex() As Integer
        Get
            Return Val(lblindex.Text)
        End Get

        Set(ByVal value As Integer)

            lblindex.Text = value.ToString()
        End Set

    End Property
    Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub FormCheckBox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class