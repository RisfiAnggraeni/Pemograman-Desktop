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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cbmatkul = New System.Windows.Forms.ComboBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbl = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbp = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttugas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mata Kuliah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JURUSAN"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(138, 28)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(121, 20)
        Me.txtnip.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(138, 64)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(121, 20)
        Me.txtnama.TabIndex = 5
        '
        'cbmatkul
        '
        Me.cbmatkul.FormattingEnabled = True
        Me.cbmatkul.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.cbmatkul.Location = New System.Drawing.Point(138, 181)
        Me.cbmatkul.Name = "cbmatkul"
        Me.cbmatkul.Size = New System.Drawing.Size(121, 21)
        Me.cbmatkul.TabIndex = 6
        '
        'cbjurusan
        '
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Items.AddRange(New Object() {"MATEMATIKA", "KIMIA", "BIOLOGI", "FISIKA", "ILMU KOMPUTER"})
        Me.cbjurusan.Location = New System.Drawing.Point(138, 151)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(121, 21)
        Me.cbjurusan.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jenis Kelamin"
        '
        'rbl
        '
        Me.rbl.AutoSize = True
        Me.rbl.Location = New System.Drawing.Point(138, 106)
        Me.rbl.Name = "rbl"
        Me.rbl.Size = New System.Drawing.Size(64, 17)
        Me.rbl.TabIndex = 10
        Me.rbl.TabStop = True
        Me.rbl.Text = "Laki laki"
        Me.rbl.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 11
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(208, 108)
        Me.rbp.Name = "rbp"
        Me.rbp.Size = New System.Drawing.Size(79, 17)
        Me.rbp.TabIndex = 12
        Me.rbp.TabStop = True
        Me.rbp.Text = "Perempuan"
        Me.rbp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "NILAI"
        '
        'txttugas
        '
        Me.txttugas.Location = New System.Drawing.Point(158, 220)
        Me.txttugas.Name = "txttugas"
        Me.txttugas.Size = New System.Drawing.Size(81, 20)
        Me.txttugas.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tugas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "UTS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(259, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 17
        '
        'txtuts
        '
        Me.txtuts.Location = New System.Drawing.Point(285, 220)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(81, 20)
        Me.txtuts.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(394, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "UAS"
        '
        'txtuas
        '
        Me.txtuas.Location = New System.Drawing.Point(429, 220)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(81, 20)
        Me.txtuas.TabIndex = 20
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Location = New System.Drawing.Point(548, 227)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(51, 13)
        Me.lblgrade.TabIndex = 21
        Me.lblgrade.Text = "-GRADE-"
        '
        'dgvdata
        '
        Me.dgvdata.AllowUserToAddRows = False
        Me.dgvdata.AllowUserToDeleteRows = False
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(18, 313)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.ReadOnly = True
        Me.dgvdata.Size = New System.Drawing.Size(715, 210)
        Me.dgvdata.TabIndex = 29
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "NIP"
        Me.dgnip.Name = "dgnip"
        Me.dgnip.ReadOnly = True
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "NAMA"
        Me.dgnama.Name = "dgnama"
        Me.dgnama.ReadOnly = True
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        Me.dgjeniskelamin.ReadOnly = True
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        Me.dgjurusan.ReadOnly = True
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        Me.dgmatkul.ReadOnly = True
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "Grade"
        Me.dggrade.Name = "dggrade"
        Me.dggrade.ReadOnly = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(304, 274)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 28
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(213, 274)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 27
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(123, 274)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 26
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(28, 274)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 25
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 574)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.lblgrade)
        Me.Controls.Add(Me.txtuas)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtuts)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttugas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.cbmatkul)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbmatkul As System.Windows.Forms.ComboBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbl As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbp As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttugas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtuts As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtuas As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button

End Class
