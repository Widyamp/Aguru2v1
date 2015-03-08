<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsen
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
        Me.NamaTxt = New System.Windows.Forms.TextBox()
        Me.KeteranganTxt = New System.Windows.Forms.TextBox()
        Me.NIPTxt = New System.Windows.Forms.TextBox()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblMasuk = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NamaTxt
        '
        Me.NamaTxt.Location = New System.Drawing.Point(125, 56)
        Me.NamaTxt.Name = "NamaTxt"
        Me.NamaTxt.Size = New System.Drawing.Size(192, 20)
        Me.NamaTxt.TabIndex = 19
        '
        'KeteranganTxt
        '
        Me.KeteranganTxt.Location = New System.Drawing.Point(125, 82)
        Me.KeteranganTxt.Name = "KeteranganTxt"
        Me.KeteranganTxt.Size = New System.Drawing.Size(192, 20)
        Me.KeteranganTxt.TabIndex = 18
        '
        'NIPTxt
        '
        Me.NIPTxt.Location = New System.Drawing.Point(125, 29)
        Me.NIPTxt.Name = "NIPTxt"
        Me.NIPTxt.Size = New System.Drawing.Size(192, 20)
        Me.NIPTxt.TabIndex = 17
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(318, 177)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 23)
        Me.TutupBtn.TabIndex = 16
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(264, 177)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(40, 23)
        Me.OkBtn.TabIndex = 15
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Pulang:"
        '
        'LblMasuk
        '
        Me.LblMasuk.AutoSize = True
        Me.LblMasuk.Location = New System.Drawing.Point(15, 182)
        Me.LblMasuk.Name = "LblMasuk"
        Me.LblMasuk.Size = New System.Drawing.Size(42, 13)
        Me.LblMasuk.TabIndex = 13
        Me.LblMasuk.Text = "Masuk:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Keterangan:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NIP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Masuk:"
        '
        'FormAbsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 228)
        Me.Controls.Add(Me.NamaTxt)
        Me.Controls.Add(Me.KeteranganTxt)
        Me.Controls.Add(Me.NIPTxt)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblMasuk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAbsen"
        Me.Text = "FormAbsen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NamaTxt As System.Windows.Forms.TextBox
    Friend WithEvents KeteranganTxt As System.Windows.Forms.TextBox
    Friend WithEvents NIPTxt As System.Windows.Forms.TextBox
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblMasuk As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
