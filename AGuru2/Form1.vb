Public Class Form1
    Sub Atur()
        NIPTxt.Text = ""
        NamaTxt.Text = ""
        NIPTxt.Enabled = True
        NIPTxt.Focus()

        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
        BatalBtn.Enabled = False
    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If NIPTxt.Text = "" Then NIPTxt.Focus() : Exit Sub
        If NamaTxt.Text = "" Then NamaTxt.Focus() : Exit Sub
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Insert into tabelguru values('" & NIPTxt.Text & "','" & NamaTxt.Text & "')"
            DMLSql.ExecuteNonQuery()

            Call Atur()

            MsgBox("Data sudah diproses", vbInformation, "Message")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If NIPTxt.Text = "" Then NIPTxt.Focus() : Exit Sub
        If NamaTxt.Text = "" Then NamaTxt.Focus() : Exit Sub
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "update tabelguru set Nama_Guru = '" & NamaTxt.Text & "' where NIP = '" & NIPTxt.Text & "'"
            DMLSql.ExecuteNonQuery()

            Call Atur()

            MsgBox("Data sudah diproses", vbInformation, "Message")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Delete from tabelguru where NIP = '" & NIPTxt.Text & "'"
            DMLSql.ExecuteNonQuery()

            Call Atur()

            MsgBox("Data sudah diproses", vbInformation, "Message")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        Call Atur()
    End Sub
    Private Sub RecordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordBtn.Click
        FormRecordGuru.ShowDialog()
    End Sub

End Class