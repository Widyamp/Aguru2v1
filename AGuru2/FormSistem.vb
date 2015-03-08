Public Class FormSistem
    Private Sub AturJamBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AturJamBtn.Click
        FormJam.ShowDialog()
    End Sub

    Private Sub GuruBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuruBtn.Click
        Form1.ShowDialog()
    End Sub



    Private Sub RekapAbsensiBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekapAbsensiBtn.Click
        FormRekapAbsensi.ShowDialog()
    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
End Class