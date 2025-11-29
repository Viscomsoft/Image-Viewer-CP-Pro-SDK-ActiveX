Public Class FormTextBox

    Public Property FieldIndex() As Integer
        Get
            Return Val(lblindex.Text)

        End Get

        Set(ByVal value As Integer)

            lblindex.Text = value
        End Set

    End Property


    Public Property Value() As String
        Get
            Return textBox1.Text

        End Get

        Set(ByVal myValue As String)

            textBox1.Text = myvalue
        End Set

    End Property

    Private Sub FormTextBox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class