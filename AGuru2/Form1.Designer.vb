<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.RecordBtn = New System.Windows.Forms.Button()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.NamaTxt = New System.Windows.Forms.TextBox()
        Me.NIPTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(192, 75)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 23)
        Me.UbahBtn.TabIndex = 19
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(192, 104)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.HapusBtn.TabIndex = 18
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Location = New System.Drawing.Point(192, 133)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(75, 23)
        Me.BatalBtn.TabIndex = 17
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'RecordBtn
        '
        Me.RecordBtn.Location = New System.Drawing.Point(192, 162)
        Me.RecordBtn.Name = "RecordBtn"
        Me.RecordBtn.Size = New System.Drawing.Size(75, 23)
        Me.RecordBtn.TabIndex = 16
        Me.RecordBtn.Text = "Record"
        Me.RecordBtn.UseVisualStyleBackColor = True
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(192, 191)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 23)
        Me.TutupBtn.TabIndex = 15
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(192, 46)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 23)
        Me.SimpanBtn.TabIndex = 14
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'NamaTxt
        '
        Me.NamaTxt.Location = New System.Drawing.Point(74, 137)
        Me.NamaTxt.Name = "NamaTxt"
        Me.NamaTxt.Size = New System.Drawing.Size(100, 20)
        Me.NamaTxt.TabIndex = 13
        '
        'NIPTxt
        '
        Me.NIPTxt.Location = New System.Drawing.Point(75, 71)
        Me.NIPTxt.Name = "NIPTxt"
        Me.NIPTxt.Size = New System.Drawing.Size(100, 20)
        Me.NIPTxt.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NIP:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.RecordBtn)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.NamaTxt)
        Me.Controls.Add(Me.NIPTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Data Guru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents RecordBtn As System.Windows.Forms.Button
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents NamaTxt As System.Windows.Forms.TextBox
    Friend WithEvents NIPTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
fffff
End Class
