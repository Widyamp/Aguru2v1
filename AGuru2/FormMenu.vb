Public Class FormMenu
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Format(Now, "dddd, dd-MMMM-yyyy")
    End Sub

    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        FormLogin.Show()
    End Sub


    Private Sub AbsenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsenBtn.Click
        FormAbsen.ShowDialog()
    End Sub
End Class