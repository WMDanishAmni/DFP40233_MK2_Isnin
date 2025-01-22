<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMaklumatPelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTajuk = New Label()
        lblNama = New Label()
        lblNotel = New Label()
        LblAlamat = New Label()
        cbbNegeri = New ComboBox()
        lblNegeri = New Label()
        lblJantina = New Label()
        rdbLelaki = New RadioButton()
        rdbPerempuan = New RadioButton()
        rdbCash = New RadioButton()
        rdbCashless = New RadioButton()
        lblKaedahBayaran = New Label()
        lblPerisa = New Label()
        ckbMilo = New CheckBox()
        ckbKopi = New CheckBox()
        ckbCoklat = New CheckBox()
        ckbStrawberry = New CheckBox()
        ckbPisang = New CheckBox()
        txtNama = New TextBox()
        txtNotel = New TextBox()
        txtAlamat = New TextBox()
        lblTarikh = New Label()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        dtpTarikh = New DateTimePicker()
        dgvTable = New DataGridView()
        gpbKaedahBayaran = New GroupBox()
        gpbJantina = New GroupBox()
        clnBil = New DataGridViewTextBoxColumn()
        clnNama = New DataGridViewTextBoxColumn()
        clnNotel = New DataGridViewTextBoxColumn()
        CType(dgvTable, ComponentModel.ISupportInitialize).BeginInit()
        gpbKaedahBayaran.SuspendLayout()
        gpbJantina.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTajuk
        ' 
        lblTajuk.AutoSize = True
        lblTajuk.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTajuk.Location = New Point(12, 9)
        lblTajuk.Name = "lblTajuk"
        lblTajuk.Size = New Size(331, 38)
        lblTajuk.TabIndex = 0
        lblTajuk.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(30, 61)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(52, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama:"
        ' 
        ' lblNotel
        ' 
        lblNotel.AutoSize = True
        lblNotel.Location = New Point(30, 98)
        lblNotel.Name = "lblNotel"
        lblNotel.Size = New Size(54, 20)
        lblNotel.TabIndex = 2
        lblNotel.Text = "No.Tel:"
        ' 
        ' LblAlamat
        ' 
        LblAlamat.AutoSize = True
        LblAlamat.Location = New Point(30, 133)
        LblAlamat.Name = "LblAlamat"
        LblAlamat.Size = New Size(60, 20)
        LblAlamat.TabIndex = 3
        LblAlamat.Text = "Alamat:"
        ' 
        ' cbbNegeri
        ' 
        cbbNegeri.FormattingEnabled = True
        cbbNegeri.Items.AddRange(New Object() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terangganu", "Kuala Lumpur", "Putrajaya"})
        cbbNegeri.Location = New Point(90, 234)
        cbbNegeri.Name = "cbbNegeri"
        cbbNegeri.Size = New Size(253, 28)
        cbbNegeri.TabIndex = 4
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(27, 237)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(57, 20)
        lblNegeri.TabIndex = 5
        lblNegeri.Text = "Negeri:"
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Location = New Point(26, 268)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(58, 20)
        lblJantina.TabIndex = 6
        lblJantina.Text = "Jantina:"
        ' 
        ' rdbLelaki
        ' 
        rdbLelaki.AutoSize = True
        rdbLelaki.Location = New Point(6, 26)
        rdbLelaki.Name = "rdbLelaki"
        rdbLelaki.Size = New Size(68, 24)
        rdbLelaki.TabIndex = 7
        rdbLelaki.TabStop = True
        rdbLelaki.Text = "Lelaki"
        rdbLelaki.UseVisualStyleBackColor = True
        ' 
        ' rdbPerempuan
        ' 
        rdbPerempuan.AutoSize = True
        rdbPerempuan.Location = New Point(6, 56)
        rdbPerempuan.Name = "rdbPerempuan"
        rdbPerempuan.Size = New Size(104, 24)
        rdbPerempuan.TabIndex = 8
        rdbPerempuan.TabStop = True
        rdbPerempuan.Text = "Perempuan"
        rdbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rdbCash
        ' 
        rdbCash.AutoSize = True
        rdbCash.Location = New Point(12, 26)
        rdbCash.Name = "rdbCash"
        rdbCash.Size = New Size(61, 24)
        rdbCash.TabIndex = 9
        rdbCash.TabStop = True
        rdbCash.Text = "Cash"
        rdbCash.UseVisualStyleBackColor = True
        ' 
        ' rdbCashless
        ' 
        rdbCashless.AutoSize = True
        rdbCashless.Location = New Point(12, 56)
        rdbCashless.Name = "rdbCashless"
        rdbCashless.Size = New Size(85, 24)
        rdbCashless.TabIndex = 10
        rdbCashless.TabStop = True
        rdbCashless.Text = "Cashless"
        rdbCashless.UseVisualStyleBackColor = True
        ' 
        ' lblKaedahBayaran
        ' 
        lblKaedahBayaran.AutoSize = True
        lblKaedahBayaran.Location = New Point(360, 61)
        lblKaedahBayaran.Name = "lblKaedahBayaran"
        lblKaedahBayaran.Size = New Size(119, 20)
        lblKaedahBayaran.TabIndex = 11
        lblKaedahBayaran.Text = "Kaedah Bayaran:"
        ' 
        ' lblPerisa
        ' 
        lblPerisa.AutoSize = True
        lblPerisa.Location = New Point(429, 154)
        lblPerisa.Name = "lblPerisa"
        lblPerisa.Size = New Size(50, 20)
        lblPerisa.TabIndex = 12
        lblPerisa.Text = "Perisa:"
        ' 
        ' ckbMilo
        ' 
        ckbMilo.AutoSize = True
        ckbMilo.Location = New Point(485, 153)
        ckbMilo.Name = "ckbMilo"
        ckbMilo.Size = New Size(61, 24)
        ckbMilo.TabIndex = 13
        ckbMilo.Text = "Milo"
        ckbMilo.UseVisualStyleBackColor = True
        ' 
        ' ckbKopi
        ' 
        ckbKopi.AutoSize = True
        ckbKopi.Location = New Point(485, 183)
        ckbKopi.Name = "ckbKopi"
        ckbKopi.Size = New Size(62, 24)
        ckbKopi.TabIndex = 14
        ckbKopi.Text = "Kopi"
        ckbKopi.UseVisualStyleBackColor = True
        ' 
        ' ckbCoklat
        ' 
        ckbCoklat.AutoSize = True
        ckbCoklat.Location = New Point(485, 213)
        ckbCoklat.Name = "ckbCoklat"
        ckbCoklat.Size = New Size(73, 24)
        ckbCoklat.TabIndex = 15
        ckbCoklat.Text = "Coklat"
        ckbCoklat.UseVisualStyleBackColor = True
        ' 
        ' ckbStrawberry
        ' 
        ckbStrawberry.AutoSize = True
        ckbStrawberry.Location = New Point(485, 243)
        ckbStrawberry.Name = "ckbStrawberry"
        ckbStrawberry.Size = New Size(102, 24)
        ckbStrawberry.TabIndex = 16
        ckbStrawberry.Text = "Strawberry"
        ckbStrawberry.UseVisualStyleBackColor = True
        ' 
        ' ckbPisang
        ' 
        ckbPisang.AutoSize = True
        ckbPisang.Location = New Point(485, 273)
        ckbPisang.Name = "ckbPisang"
        ckbPisang.Size = New Size(74, 24)
        ckbPisang.TabIndex = 17
        ckbPisang.Text = "Pisang"
        ckbPisang.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(90, 58)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(253, 27)
        txtNama.TabIndex = 18
        ' 
        ' txtNotel
        ' 
        txtNotel.Location = New Point(90, 95)
        txtNotel.Name = "txtNotel"
        txtNotel.Size = New Size(253, 27)
        txtNotel.TabIndex = 19
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(90, 130)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(253, 98)
        txtAlamat.TabIndex = 20
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(429, 313)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(50, 20)
        lblTarikh.TabIndex = 22
        lblTarikh.Text = "Tarikh:"
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(25, 567)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(94, 29)
        BtnCreate.TabIndex = 24
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(125, 567)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(94, 29)
        BtnRead.TabIndex = 25
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(225, 567)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 26
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(325, 567)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 27
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(485, 306)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(250, 27)
        dtpTarikh.TabIndex = 28
        ' 
        ' dgvTable
        ' 
        dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTable.Columns.AddRange(New DataGridViewColumn() {clnBil, clnNama, clnNotel})
        dgvTable.Location = New Point(30, 374)
        dgvTable.Name = "dgvTable"
        dgvTable.RowHeadersWidth = 51
        dgvTable.Size = New Size(389, 188)
        dgvTable.TabIndex = 29
        ' 
        ' gpbKaedahBayaran
        ' 
        gpbKaedahBayaran.Controls.Add(rdbCash)
        gpbKaedahBayaran.Controls.Add(rdbCashless)
        gpbKaedahBayaran.Location = New Point(485, 58)
        gpbKaedahBayaran.Name = "gpbKaedahBayaran"
        gpbKaedahBayaran.Size = New Size(250, 89)
        gpbKaedahBayaran.TabIndex = 30
        gpbKaedahBayaran.TabStop = False
        ' 
        ' gpbJantina
        ' 
        gpbJantina.Controls.Add(rdbLelaki)
        gpbJantina.Controls.Add(rdbPerempuan)
        gpbJantina.Location = New Point(90, 273)
        gpbJantina.Name = "gpbJantina"
        gpbJantina.Size = New Size(250, 84)
        gpbJantina.TabIndex = 31
        gpbJantina.TabStop = False
        ' 
        ' clnBil
        ' 
        clnBil.HeaderText = "Bil"
        clnBil.MinimumWidth = 6
        clnBil.Name = "clnBil"
        clnBil.Width = 125
        ' 
        ' clnNama
        ' 
        clnNama.HeaderText = "Nama"
        clnNama.MinimumWidth = 6
        clnNama.Name = "clnNama"
        clnNama.Width = 125
        ' 
        ' clnNotel
        ' 
        clnNotel.HeaderText = "No_tel"
        clnNotel.MinimumWidth = 6
        clnNotel.Name = "clnNotel"
        clnNotel.Width = 125
        ' 
        ' FrmMaklumatPelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 614)
        Controls.Add(gpbJantina)
        Controls.Add(gpbKaedahBayaran)
        Controls.Add(dgvTable)
        Controls.Add(dtpTarikh)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(lblTarikh)
        Controls.Add(txtAlamat)
        Controls.Add(txtNotel)
        Controls.Add(txtNama)
        Controls.Add(ckbPisang)
        Controls.Add(ckbStrawberry)
        Controls.Add(ckbCoklat)
        Controls.Add(ckbKopi)
        Controls.Add(ckbMilo)
        Controls.Add(lblPerisa)
        Controls.Add(lblKaedahBayaran)
        Controls.Add(lblJantina)
        Controls.Add(lblNegeri)
        Controls.Add(cbbNegeri)
        Controls.Add(LblAlamat)
        Controls.Add(lblNotel)
        Controls.Add(lblNama)
        Controls.Add(lblTajuk)
        Name = "FrmMaklumatPelanggan"
        Text = "MAKLUMAT PELANGGAN"
        CType(dgvTable, ComponentModel.ISupportInitialize).EndInit()
        gpbKaedahBayaran.ResumeLayout(False)
        gpbKaedahBayaran.PerformLayout()
        gpbJantina.ResumeLayout(False)
        gpbJantina.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTajuk As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNotel As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents cbbNegeri As ComboBox
    Friend WithEvents lblNegeri As Label
    Friend WithEvents lblJantina As Label
    Friend WithEvents rdbLelaki As RadioButton
    Friend WithEvents rdbPerempuan As RadioButton
    Friend WithEvents rdbCash As RadioButton
    Friend WithEvents rdbCashless As RadioButton
    Friend WithEvents lblKaedahBayaran As Label
    Friend WithEvents lblPerisa As Label
    Friend WithEvents ckbMilo As CheckBox
    Friend WithEvents ckbKopi As CheckBox
    Friend WithEvents ckbCoklat As CheckBox
    Friend WithEvents ckbStrawberry As CheckBox
    Friend WithEvents ckbPisang As CheckBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNotel As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblTarikh As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents gpbKaedahBayaran As GroupBox
    Friend WithEvents gpbJantina As GroupBox
    Friend WithEvents clnBil As DataGridViewTextBoxColumn
    Friend WithEvents clnNama As DataGridViewTextBoxColumn
    Friend WithEvents clnNotel As DataGridViewTextBoxColumn

End Class
