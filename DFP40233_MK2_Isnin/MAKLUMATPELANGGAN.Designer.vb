<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAKLUMATPELANGGAN
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
        Label1 = New Label()
        LblNama = New Label()
        LblNotel = New Label()
        LblAlamat = New Label()
        CbNegeri = New ComboBox()
        LblNegeri = New Label()
        LblJantina = New Label()
        RbtnLelaki = New RadioButton()
        RbtnPerempuan = New RadioButton()
        RbtnCash = New RadioButton()
        RbtnCashless = New RadioButton()
        LblKaedahBayaran = New Label()
        LblPerisa = New Label()
        CbMilo = New CheckBox()
        CbKopi = New CheckBox()
        CbCoklat = New CheckBox()
        CbStrawberry = New CheckBox()
        CbPisang = New CheckBox()
        TxtNama = New TextBox()
        TxtNotel = New TextBox()
        TxtAlamat = New TextBox()
        LblTarikh = New Label()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        DTPTarikh = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Bil = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        No_tel = New DataGridViewTextBoxColumn()
        GbKaedahBayaran = New GroupBox()
        GbJantina = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GbKaedahBayaran.SuspendLayout()
        GbJantina.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 38)
        Label1.TabIndex = 0
        Label1.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Location = New Point(30, 61)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(52, 20)
        LblNama.TabIndex = 1
        LblNama.Text = "Nama:"
        ' 
        ' LblNotel
        ' 
        LblNotel.AutoSize = True
        LblNotel.Location = New Point(30, 98)
        LblNotel.Name = "LblNotel"
        LblNotel.Size = New Size(54, 20)
        LblNotel.TabIndex = 2
        LblNotel.Text = "No.Tel:"
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
        ' CbNegeri
        ' 
        CbNegeri.FormattingEnabled = True
        CbNegeri.Items.AddRange(New Object() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terangganu", "Kuala Lumpur", "Putrajaya"})
        CbNegeri.Location = New Point(90, 234)
        CbNegeri.Name = "CbNegeri"
        CbNegeri.Size = New Size(253, 28)
        CbNegeri.TabIndex = 4
        ' 
        ' LblNegeri
        ' 
        LblNegeri.AutoSize = True
        LblNegeri.Location = New Point(27, 237)
        LblNegeri.Name = "LblNegeri"
        LblNegeri.Size = New Size(57, 20)
        LblNegeri.TabIndex = 5
        LblNegeri.Text = "Negeri:"
        ' 
        ' LblJantina
        ' 
        LblJantina.AutoSize = True
        LblJantina.Location = New Point(26, 268)
        LblJantina.Name = "LblJantina"
        LblJantina.Size = New Size(58, 20)
        LblJantina.TabIndex = 6
        LblJantina.Text = "Jantina:"
        ' 
        ' RbtnLelaki
        ' 
        RbtnLelaki.AutoSize = True
        RbtnLelaki.Location = New Point(6, 26)
        RbtnLelaki.Name = "RbtnLelaki"
        RbtnLelaki.Size = New Size(68, 24)
        RbtnLelaki.TabIndex = 7
        RbtnLelaki.TabStop = True
        RbtnLelaki.Text = "Lelaki"
        RbtnLelaki.UseVisualStyleBackColor = True
        ' 
        ' RbtnPerempuan
        ' 
        RbtnPerempuan.AutoSize = True
        RbtnPerempuan.Location = New Point(6, 56)
        RbtnPerempuan.Name = "RbtnPerempuan"
        RbtnPerempuan.Size = New Size(104, 24)
        RbtnPerempuan.TabIndex = 8
        RbtnPerempuan.TabStop = True
        RbtnPerempuan.Text = "Perempuan"
        RbtnPerempuan.UseVisualStyleBackColor = True
        ' 
        ' RbtnCash
        ' 
        RbtnCash.AutoSize = True
        RbtnCash.Location = New Point(12, 26)
        RbtnCash.Name = "RbtnCash"
        RbtnCash.Size = New Size(61, 24)
        RbtnCash.TabIndex = 9
        RbtnCash.TabStop = True
        RbtnCash.Text = "Cash"
        RbtnCash.UseVisualStyleBackColor = True
        ' 
        ' RbtnCashless
        ' 
        RbtnCashless.AutoSize = True
        RbtnCashless.Location = New Point(12, 56)
        RbtnCashless.Name = "RbtnCashless"
        RbtnCashless.Size = New Size(85, 24)
        RbtnCashless.TabIndex = 10
        RbtnCashless.TabStop = True
        RbtnCashless.Text = "Cashless"
        RbtnCashless.UseVisualStyleBackColor = True
        ' 
        ' LblKaedahBayaran
        ' 
        LblKaedahBayaran.AutoSize = True
        LblKaedahBayaran.Location = New Point(360, 61)
        LblKaedahBayaran.Name = "LblKaedahBayaran"
        LblKaedahBayaran.Size = New Size(119, 20)
        LblKaedahBayaran.TabIndex = 11
        LblKaedahBayaran.Text = "Kaedah Bayaran:"
        ' 
        ' LblPerisa
        ' 
        LblPerisa.AutoSize = True
        LblPerisa.Location = New Point(429, 154)
        LblPerisa.Name = "LblPerisa"
        LblPerisa.Size = New Size(50, 20)
        LblPerisa.TabIndex = 12
        LblPerisa.Text = "Perisa:"
        ' 
        ' CbMilo
        ' 
        CbMilo.AutoSize = True
        CbMilo.Location = New Point(485, 153)
        CbMilo.Name = "CbMilo"
        CbMilo.Size = New Size(61, 24)
        CbMilo.TabIndex = 13
        CbMilo.Text = "Milo"
        CbMilo.UseVisualStyleBackColor = True
        ' 
        ' CbKopi
        ' 
        CbKopi.AutoSize = True
        CbKopi.Location = New Point(485, 183)
        CbKopi.Name = "CbKopi"
        CbKopi.Size = New Size(62, 24)
        CbKopi.TabIndex = 14
        CbKopi.Text = "Kopi"
        CbKopi.UseVisualStyleBackColor = True
        ' 
        ' CbCoklat
        ' 
        CbCoklat.AutoSize = True
        CbCoklat.Location = New Point(485, 213)
        CbCoklat.Name = "CbCoklat"
        CbCoklat.Size = New Size(73, 24)
        CbCoklat.TabIndex = 15
        CbCoklat.Text = "Coklat"
        CbCoklat.UseVisualStyleBackColor = True
        ' 
        ' CbStrawberry
        ' 
        CbStrawberry.AutoSize = True
        CbStrawberry.Location = New Point(485, 243)
        CbStrawberry.Name = "CbStrawberry"
        CbStrawberry.Size = New Size(102, 24)
        CbStrawberry.TabIndex = 16
        CbStrawberry.Text = "Strawberry"
        CbStrawberry.UseVisualStyleBackColor = True
        ' 
        ' CbPisang
        ' 
        CbPisang.AutoSize = True
        CbPisang.Location = New Point(485, 273)
        CbPisang.Name = "CbPisang"
        CbPisang.Size = New Size(74, 24)
        CbPisang.TabIndex = 17
        CbPisang.Text = "Pisang"
        CbPisang.UseVisualStyleBackColor = True
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(90, 58)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(253, 27)
        TxtNama.TabIndex = 18
        ' 
        ' TxtNotel
        ' 
        TxtNotel.Location = New Point(90, 95)
        TxtNotel.Name = "TxtNotel"
        TxtNotel.Size = New Size(253, 27)
        TxtNotel.TabIndex = 19
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(90, 130)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(253, 98)
        TxtAlamat.TabIndex = 20
        ' 
        ' LblTarikh
        ' 
        LblTarikh.AutoSize = True
        LblTarikh.Location = New Point(429, 313)
        LblTarikh.Name = "LblTarikh"
        LblTarikh.Size = New Size(50, 20)
        LblTarikh.TabIndex = 22
        LblTarikh.Text = "Tarikh:"
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
        ' DTPTarikh
        ' 
        DTPTarikh.Location = New Point(485, 306)
        DTPTarikh.Name = "DTPTarikh"
        DTPTarikh.Size = New Size(250, 27)
        DTPTarikh.TabIndex = 28
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Bil, Nama, No_tel})
        DataGridView1.Location = New Point(30, 374)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(389, 188)
        DataGridView1.TabIndex = 29
        ' 
        ' Bil
        ' 
        Bil.HeaderText = "Bil"
        Bil.MinimumWidth = 6
        Bil.Name = "Bil"
        Bil.Width = 125
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama"
        Nama.MinimumWidth = 6
        Nama.Name = "Nama"
        Nama.Width = 125
        ' 
        ' No_tel
        ' 
        No_tel.HeaderText = "No_tel"
        No_tel.MinimumWidth = 6
        No_tel.Name = "No_tel"
        No_tel.Width = 125
        ' 
        ' GbKaedahBayaran
        ' 
        GbKaedahBayaran.Controls.Add(RbtnCash)
        GbKaedahBayaran.Controls.Add(RbtnCashless)
        GbKaedahBayaran.Location = New Point(485, 58)
        GbKaedahBayaran.Name = "GbKaedahBayaran"
        GbKaedahBayaran.Size = New Size(250, 89)
        GbKaedahBayaran.TabIndex = 30
        GbKaedahBayaran.TabStop = False
        GbKaedahBayaran.Text = "GroupBox1"
        ' 
        ' GbJantina
        ' 
        GbJantina.Controls.Add(RbtnLelaki)
        GbJantina.Controls.Add(RbtnPerempuan)
        GbJantina.Location = New Point(90, 273)
        GbJantina.Name = "GbJantina"
        GbJantina.Size = New Size(250, 84)
        GbJantina.TabIndex = 31
        GbJantina.TabStop = False
        GbJantina.Text = "GroupBox2"
        ' 
        ' MAKLUMATPELANGGAN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 614)
        Controls.Add(GbJantina)
        Controls.Add(GbKaedahBayaran)
        Controls.Add(DataGridView1)
        Controls.Add(DTPTarikh)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(LblTarikh)
        Controls.Add(TxtAlamat)
        Controls.Add(TxtNotel)
        Controls.Add(TxtNama)
        Controls.Add(CbPisang)
        Controls.Add(CbStrawberry)
        Controls.Add(CbCoklat)
        Controls.Add(CbKopi)
        Controls.Add(CbMilo)
        Controls.Add(LblPerisa)
        Controls.Add(LblKaedahBayaran)
        Controls.Add(LblJantina)
        Controls.Add(LblNegeri)
        Controls.Add(CbNegeri)
        Controls.Add(LblAlamat)
        Controls.Add(LblNotel)
        Controls.Add(LblNama)
        Controls.Add(Label1)
        Name = "MAKLUMATPELANGGAN"
        Text = "MAKLUMAT PELANGGAN"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GbKaedahBayaran.ResumeLayout(False)
        GbKaedahBayaran.PerformLayout()
        GbJantina.ResumeLayout(False)
        GbJantina.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblNotel As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents CbNegeri As ComboBox
    Friend WithEvents LblNegeri As Label
    Friend WithEvents LblJantina As Label
    Friend WithEvents RbtnLelaki As RadioButton
    Friend WithEvents RbtnPerempuan As RadioButton
    Friend WithEvents RbtnCash As RadioButton
    Friend WithEvents RbtnCashless As RadioButton
    Friend WithEvents LblKaedahBayaran As Label
    Friend WithEvents LblPerisa As Label
    Friend WithEvents CbMilo As CheckBox
    Friend WithEvents CbKopi As CheckBox
    Friend WithEvents CbCoklat As CheckBox
    Friend WithEvents CbStrawberry As CheckBox
    Friend WithEvents CbPisang As CheckBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNotel As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents LblTarikh As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DTPTarikh As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Bil As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents No_tel As DataGridViewTextBoxColumn
    Friend WithEvents GbKaedahBayaran As GroupBox
    Friend WithEvents GbJantina As GroupBox

End Class
