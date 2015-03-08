Imports MySql.Data.MySqlClient
Module ModKoneksi
    Public Database As New MySqlConnection
    Public Tampil As New MySql.Data.MySqlClient.MySqlCommand
    Public Tampilkan As MySql.Data.MySqlClient.MySqlDataReader
    Public Grid As New MySql.Data.MySqlClient.MySqlDataAdapter
    Public Ds As New DataSet
    Public Tabel As String
    Public record As New BindingSource
    Public DMLSql As New MySql.Data.MySqlClient.MySqlCommand
    Public Sub Koneksi()
        Try
            Database.Close()
            Database.ConnectionString = "server=localhost;" _
           & "user id=root;" _
           & "password=maxikom;" _
           & "database=aguru"
            Database.Open()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Module
