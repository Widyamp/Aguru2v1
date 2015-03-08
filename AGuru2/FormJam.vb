Public Class FormJam

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Delete From tabeljam"
            DMLSql.ExecuteNonQuery()

            DMLSql.CommandText = "Insert into tabeljam values('" & MasukME.Text & "','" & PulangME.Text & "')"
            DMLSql.ExecuteNonQuery()

            MsgBox("Data telah diproses", vbInformation, "Message")

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
End Class