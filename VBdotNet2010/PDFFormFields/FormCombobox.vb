Public Class FormCombobox
    Public Property FieldIndex() As Integer
        Get
            Return Val(lblindex.Text)
        End Get

        Set(ByVal value As Integer)

            lblindex.Text = value.ToString()
        End Set

    End Property


    Public Property ComboBoxIndex() As Integer
        Get
            Return Val(txtcomboboxindex.Text)
        End Get

        Set(ByVal value As Integer)

            txtcomboboxindex.Text = value.ToString()
        End Set

    End Property

    Private Sub FormCombobox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class