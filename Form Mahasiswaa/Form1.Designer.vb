<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbfakultas = New System.Windows.Forms.ComboBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbl = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbp = New System.Windows.Forms.RadioButton()
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
        Me.Label3.Location = New System.Drawing.Point(28, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FAKULTAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JURUSAN"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(138, 25)
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
        'cbfakultas
        '
        Me.cbfakultas.FormattingEnabled = True
        Me.cbfakultas.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.cbfakultas.Location = New System.Drawing.Point(138, 139)
        Me.cbfakultas.Name = "cbfakultas"
        Me.cbfakultas.Size = New System.Drawing.Size(121, 21)
        Me.cbfakultas.TabIndex = 6
        '
        'cbjurusan
        '
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Items.AddRange(New Object() {"MATEMATIKA", "KIMIA", "BIOLOGI", "FISIKA", "ILMU KOMPUTER"})
        Me.cbjurusan.Location = New System.Drawing.Point(138, 167)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(121, 21)
        Me.cbjurusan.TabIndex = 7
        '
        'btnprocess
        '
        Me.btnprocess.Location = New System.Drawing.Point(138, 217)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(75, 23)
        Me.btnprocess.TabIndex = 8
        Me.btnprocess.Text = "Process"
        Me.btnprocess.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 261)
        Me.Controls.Add(Me.rbp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnprocess)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.cbfakultas)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btnprocess As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbl As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbp As System.Windows.Forms.RadioButton

End Class
