Public Class FormRekapAbsensi
    Sub Data_Record()
        ' Try
        Call Koneksi()

        Ds = New DataSet

        Tabel = "SELECT * FROM tabelabsen where Tanggal >= '" & Format(AwalDP.Value, "yyyy/MM/dd") & "' and Tanggal <= '" & Format(AkhirDP.Value, "yyyy/MM/dd") & "'"
        Grid = New MySql.Data.MySqlClient.MySqlDataAdapter(Tabel, Database)
        Grid.Fill(Ds, "tabelabsen")

        Dim GridView As New DataView(Ds.Tables("tabelabsen"))
        DGGuru.DataSource = GridView
        DGGuru.Columns(2).Width = 200
        DGGuru.Columns(3).Width = 50
        DGGuru.Columns(4).Width = 50
        DGGuru.Columns(5).Width = 55
        DGGuru.Columns(6).Visible = False
        DGGuru.Columns(7).Width = 175
        'Catch ex As Exception
        'MsgBox(ex.ToString())
        'End Try
    End Sub
    Private Sub FormRekapAbsensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AwalDP.Value = Format(Now, "dd/MM/yyyy")
        AkhirDP.Value = Format(Now, "dd/MM/yyyy")
        Call Data_Record()
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        Call Data_Record()
    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
End Class