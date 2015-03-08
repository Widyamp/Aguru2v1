Public Class FormAbsen
    Sub Atur()
        NIPTxt.Text = ""
        NamaTxt.Text = ""
        KeteranganTxt.Text = "-"
        NIPTxt.Enabled = True
        NIPTxt.Focus()
    End Sub
    Sub Jam_Masuk_Pulang()
        Try
            Call Koneksi()
            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text
            Tampil.CommandText = "select * from tabeljam"
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                Label4.Text = "Masuk : " & (Tampilkan("Masuk").ToString) & ""
                Label5.Text = "Pulang : " & (Tampilkan("Pulang").ToString) & ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NIPTxt.Text = "" Then NIPTxt.Focus() : Exit Sub
        Try

            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select * from tabelabsen where NIP = '" & NIPTxt.Text & "' and Tanggal = '" & Format(Now, "yyyy/MM/dd") & "'"
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Dim Tanya = MessageBox.Show("Anda Mau Absen Pulang ?", "Absen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Select Case Tanya
                    Case Windows.Forms.DialogResult.Yes
                        Tampilkan.Read()
                        Call Koneksi()
                        DMLSql.Connection = Database
                        DMLSql.CommandType = CommandType.Text
                        DMLSql.CommandText = "Update tabelabsen set Pulang ='" & Format(Now, "hh:mm:ss") & "',Status ='Absen Pulang', Keterangan = '" & KeteranganTxt.Text & "' where Nik = '" & NIPTxt.Text & "' and Tanggal = '" & Format(Now, "yyyy/MM/dd") & "'"
                        DMLSql.ExecuteNonQuery()
                    Case Else
                        Call Atur()
                        Exit Sub
                End Select
            Else
                Dim Lama_Telat As String

                Dim Jam = Format(Now, "HH") - Microsoft.VisualBasic.Mid(LblMasuk.Text, 9, 2)
                Dim Menit = Format(Now, "mm") - Microsoft.VisualBasic.Mid(LblMasuk.Text, 12, 2)
                Dim Detik = Format(Now, "ss") - Microsoft.VisualBasic.Mid(LblMasuk.Text, 15, 2)

                Lama_Telat = "" & Jam & ":" & Menit & ":" & Detik & ""

                Call Koneksi()
                DMLSql.Connection = Database
                DMLSql.CommandType = CommandType.Text
                DMLSql.CommandText = "Insert into tabelabsen(Tanggal, NIP, Masuk, Terlambat, Keterangan)values('" & Format(Now, "yyyy/MM/dd") & "','" & NIPTxt.Text & "','" & Format(Now, "hh:mm:ss") & "','" & Lama_Telat & "','Absen Masuk','" & KeteranganTxt.Text & "')"
                DMLSql.ExecuteNonQuery()
            End If

            Call Atur()
            MsgBox("Data sudah diproses", vbInformation, "Message")

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub NIPTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NIPTxt.TextChanged
        Try
            Call Koneksi()
            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text
            Tampil.CommandText = "select * from tabelguru where NIP = '" & NIPTxt.Text & "'"
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                NamaTxt.Text = (Tampilkan("Nama_Guru"))
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

End Class