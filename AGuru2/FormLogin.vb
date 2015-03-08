Public Class FormLogin
    Sub Login()
        If PswTxt.Text = "" Then Exit Sub

        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from tabellogin where password = '" & PswTxt.Text & "'"
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            PswTxt.Text = ""
            Me.Hide()
            FormSistem.Show()
        Else
            MsgBox("Login tidak berhasil")
            PswTxt.Text = ""
            PswTxt.Focus()
        End If
    End Sub
    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        Call Login()
    End Sub

   
    Private Sub BatalBtl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtl.Click
        Me.Close()
    End Sub
End Class