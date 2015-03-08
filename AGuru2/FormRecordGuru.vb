Public Class FormRecordGuru
    Sub Data_Record()
        Try
            Call Koneksi()

            Ds = New DataSet

            Tabel = "SELECT * FROM tabelguru"
            Grid = New MySql.Data.MySqlClient.MySqlDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "tabelguru")

            Dim GridView As New DataView(Ds.Tables("tabelguru"))
            DGGuru.DataSource = GridView
            DGGuru.Columns(0).Width = 75
            DGGuru.Columns(1).Width = 275
            DGGuru.Columns(3).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub FormRecordGuru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub
End Class