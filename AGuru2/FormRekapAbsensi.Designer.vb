<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRekapAbsensi
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
        Me.DGGuru = New System.Windows.Forms.DataGridView()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.AkhirDP = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AwalDP = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGGuru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGGuru
        '
        Me.DGGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGuru.Location = New System.Drawing.Point(14, 70)
        Me.DGGuru.Name = "DGGuru"
        Me.DGGuru.Size = New System.Drawing.Size(729, 267)
        Me.DGGuru.TabIndex = 13
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(692, 32)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(51, 23)
        Me.TutupBtn.TabIndex = 12
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(616, 32)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(51, 23)
        Me.OkBtn.TabIndex = 11
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'AkhirDP
        '
        Me.AkhirDP.Location = New System.Drawing.Point(391, 33)
        Me.AkhirDP.Name = "AkhirDP"
        Me.AkhirDP.Size = New System.Drawing.Size(200, 20)
        Me.AkhirDP.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "S.D :"
        '
        'AwalDP
        '
        Me.AwalDP.Location = New System.Drawing.Point(129, 33)
        Me.AwalDP.Name = "AwalDP"
        Me.AwalDP.Size = New System.Drawing.Size(200, 20)
        Me.AwalDP.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Periode Tanggal:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(391, 33)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'FormRekapAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 369)
        Me.Controls.Add(Me.DGGuru)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.AkhirDP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AwalDP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRekapAbsensi"
        Me.Text = "FormRekapAbsensi"
        CType(Me.DGGuru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGGuru As System.Windows.Forms.DataGridView
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents AkhirDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AwalDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
