<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSistem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.RekapAbsensiBtn = New System.Windows.Forms.Button()
        Me.GuruBtn = New System.Windows.Forms.Button()
        Me.AturJamBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(53, 185)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(178, 23)
        Me.TutupBtn.TabIndex = 7
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'RekapAbsensiBtn
        '
        Me.RekapAbsensiBtn.Location = New System.Drawing.Point(53, 110)
        Me.RekapAbsensiBtn.Name = "RekapAbsensiBtn"
        Me.RekapAbsensiBtn.Size = New System.Drawing.Size(178, 23)
        Me.RekapAbsensiBtn.TabIndex = 6
        Me.RekapAbsensiBtn.Text = "Rekap Absensi"
        Me.RekapAbsensiBtn.UseVisualStyleBackColor = True
        '
        'GuruBtn
        '
        Me.GuruBtn.Location = New System.Drawing.Point(53, 81)
        Me.GuruBtn.Name = "GuruBtn"
        Me.GuruBtn.Size = New System.Drawing.Size(178, 23)
        Me.GuruBtn.TabIndex = 5
        Me.GuruBtn.Text = "Data Guru"
        Me.GuruBtn.UseVisualStyleBackColor = True
        '
        'AturJamBtn
        '
        Me.AturJamBtn.Location = New System.Drawing.Point(53, 52)
        Me.AturJamBtn.Name = "AturJamBtn"
        Me.AturJamBtn.Size = New System.Drawing.Size(178, 23)
        Me.AturJamBtn.TabIndex = 4
        Me.AturJamBtn.Text = "Atur Jam Masuk dan Pulang"
        Me.AturJamBtn.UseVisualStyleBackColor = True
        '
        'FormSistem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.RekapAbsensiBtn)
        Me.Controls.Add(Me.GuruBtn)
        Me.Controls.Add(Me.AturJamBtn)
        Me.Name = "FormSistem"
        Me.Text = "FormSistem"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents RekapAbsensiBtn As System.Windows.Forms.Button
    Friend WithEvents GuruBtn As System.Windows.Forms.Button
    Friend WithEvents AturJamBtn As System.Windows.Forms.Button
End Class
