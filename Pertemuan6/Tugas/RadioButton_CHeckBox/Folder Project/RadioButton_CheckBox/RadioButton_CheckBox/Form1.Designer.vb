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
        Me.rbAnak = New System.Windows.Forms.RadioButton()
        Me.rbDewasa = New System.Windows.Forms.RadioButton()
        Me.cbBukanMember = New System.Windows.Forms.CheckBox()
        Me.gbTiketMasuk = New System.Windows.Forms.GroupBox()
        Me.gbMember = New System.Windows.Forms.GroupBox()
        Me.cbMember = New System.Windows.Forms.CheckBox()
        Me.btnTotalHarga = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbTiketMasuk.SuspendLayout()
        Me.gbMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Pemesanan Tiket Tempat Wisata"
        '
        'rbAnak
        '
        Me.rbAnak.AutoSize = True
        Me.rbAnak.Location = New System.Drawing.Point(26, 30)
        Me.rbAnak.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbAnak.Name = "rbAnak"
        Me.rbAnak.Size = New System.Drawing.Size(113, 24)
        Me.rbAnak.TabIndex = 1
        Me.rbAnak.TabStop = True
        Me.rbAnak.Text = "Anak-anak"
        Me.rbAnak.UseVisualStyleBackColor = True
        '
        'rbDewasa
        '
        Me.rbDewasa.AutoSize = True
        Me.rbDewasa.Location = New System.Drawing.Point(26, 60)
        Me.rbDewasa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbDewasa.Name = "rbDewasa"
        Me.rbDewasa.Size = New System.Drawing.Size(91, 24)
        Me.rbDewasa.TabIndex = 2
        Me.rbDewasa.TabStop = True
        Me.rbDewasa.Text = "Dewasa"
        Me.rbDewasa.UseVisualStyleBackColor = True
        '
        'cbBukanMember
        '
        Me.cbBukanMember.AutoSize = True
        Me.cbBukanMember.Location = New System.Drawing.Point(32, 29)
        Me.cbBukanMember.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbBukanMember.Name = "cbBukanMember"
        Me.cbBukanMember.Size = New System.Drawing.Size(148, 24)
        Me.cbBukanMember.TabIndex = 4
        Me.cbBukanMember.Text = "Bukan Member"
        Me.cbBukanMember.UseVisualStyleBackColor = True
        '
        'gbTiketMasuk
        '
        Me.gbTiketMasuk.Controls.Add(Me.rbAnak)
        Me.gbTiketMasuk.Controls.Add(Me.rbDewasa)
        Me.gbTiketMasuk.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTiketMasuk.Location = New System.Drawing.Point(63, 198)
        Me.gbTiketMasuk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbTiketMasuk.Name = "gbTiketMasuk"
        Me.gbTiketMasuk.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbTiketMasuk.Size = New System.Drawing.Size(183, 120)
        Me.gbTiketMasuk.TabIndex = 5
        Me.gbTiketMasuk.TabStop = False
        Me.gbTiketMasuk.Text = "Tiket Masuk"
        '
        'gbMember
        '
        Me.gbMember.Controls.Add(Me.cbMember)
        Me.gbMember.Controls.Add(Me.cbBukanMember)
        Me.gbMember.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMember.Location = New System.Drawing.Point(293, 198)
        Me.gbMember.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbMember.Name = "gbMember"
        Me.gbMember.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbMember.Size = New System.Drawing.Size(275, 120)
        Me.gbMember.TabIndex = 6
        Me.gbMember.TabStop = False
        Me.gbMember.Text = "Member"
        '
        'cbMember
        '
        Me.cbMember.AutoSize = True
        Me.cbMember.Location = New System.Drawing.Point(32, 61)
        Me.cbMember.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMember.Name = "cbMember"
        Me.cbMember.Size = New System.Drawing.Size(210, 24)
        Me.cbMember.TabIndex = 5
        Me.cbMember.Text = "Member (Diskon 10%)"
        Me.cbMember.UseVisualStyleBackColor = True
        '
        'btnTotalHarga
        '
        Me.btnTotalHarga.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalHarga.Location = New System.Drawing.Point(221, 348)
        Me.btnTotalHarga.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTotalHarga.Name = "btnTotalHarga"
        Me.btnTotalHarga.Size = New System.Drawing.Size(159, 32)
        Me.btnTotalHarga.TabIndex = 7
        Me.btnTotalHarga.Text = "Total Harga"
        Me.btnTotalHarga.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(221, 411)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(160, 27)
        Me.txtTotal.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 413)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Anak-anak = Rp20.000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Dewasa = Rp40.000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Harga Tiket Masuk"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(615, 467)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnTotalHarga)
        Me.Controls.Add(Me.gbMember)
        Me.Controls.Add(Me.gbTiketMasuk)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gbTiketMasuk.ResumeLayout(False)
        Me.gbTiketMasuk.PerformLayout()
        Me.gbMember.ResumeLayout(False)
        Me.gbMember.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbAnak As RadioButton
    Friend WithEvents rbDewasa As RadioButton
    Friend WithEvents cbBukanMember As CheckBox
    Friend WithEvents gbTiketMasuk As GroupBox
    Friend WithEvents gbMember As GroupBox
    Friend WithEvents cbMember As CheckBox
    Friend WithEvents btnTotalHarga As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
