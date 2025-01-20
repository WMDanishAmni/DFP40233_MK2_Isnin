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
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label7 = New Label()
        Label8 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        TxtNama = New TextBox()
        TxtNotel = New TextBox()
        TxtAlamat = New TextBox()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Bil = New DataGridViewTextBoxColumn()
        Name = New DataGridViewTextBoxColumn()
        No_tel = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terangganu", "Kuala Lumpur", "Putrajaya"})
        ComboBox1.Location = New Point(90, 234)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(253, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 5
        Label5.Text = "Negeri:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 268)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 20)
        Label6.TabIndex = 6
        Label6.Text = "Jantina:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(90, 268)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(68, 24)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Lelaki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(90, 298)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(104, 24)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(485, 61)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(61, 24)
        RadioButton3.TabIndex = 9
        RadioButton3.TabStop = True
        RadioButton3.Text = "Cash"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(485, 91)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(85, 24)
        RadioButton4.TabIndex = 10
        RadioButton4.TabStop = True
        RadioButton4.Text = "Cashless"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(360, 61)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 20)
        Label7.TabIndex = 11
        Label7.Text = "Kaedah Bayaran:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(429, 130)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 20)
        Label8.TabIndex = 12
        Label8.Text = "Perisa:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(485, 129)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(61, 24)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Milo"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(485, 159)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(62, 24)
        CheckBox2.TabIndex = 14
        CheckBox2.Text = "Kopi"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(485, 189)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(73, 24)
        CheckBox3.TabIndex = 15
        CheckBox3.Text = "Coklat"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(485, 219)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(102, 24)
        CheckBox4.TabIndex = 16
        CheckBox4.Text = "Strawberry"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(485, 249)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(74, 24)
        CheckBox5.TabIndex = 17
        CheckBox5.Text = "Pisang"
        CheckBox5.UseVisualStyleBackColor = True
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(429, 287)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 20)
        Label9.TabIndex = 22
        Label9.Text = "Tarikh:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Bil, Name, No_tel})
        DataGridView1.Location = New Point(30, 339)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(394, 188)
        DataGridView1.TabIndex = 23
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(30, 533)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 24
        Button1.Text = "Create"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(130, 533)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 25
        Button2.Text = "Read"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(230, 533)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 26
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(330, 533)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 27
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(485, 282)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 28
        ' 
        ' Bil
        ' 
        Bil.HeaderText = "Bil"
        Bil.MinimumWidth = 6
        Bil.Name = "Bil"
        Bil.Width = 125
        ' 
        ' Name
        ' 
        Name.HeaderText = "Name"
        Name.MinimumWidth = 6
        Name.Name = "Name"
        Name.Width = 125
        ' 
        ' No_tel
        ' 
        No_tel.HeaderText = "No_tel"
        No_tel.MinimumWidth = 6
        No_tel.Name = "No_tel"
        No_tel.Width = 125
        ' 
        ' MAKLUMATPELANGGAN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 585)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label9)
        Controls.Add(TxtAlamat)
        Controls.Add(TxtNotel)
        Controls.Add(TxtNama)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(LblAlamat)
        Controls.Add(LblNotel)
        Controls.Add(LblNama)
        Controls.Add(Label1)
        Name = "MAKLUMATPELANGGAN"
        Text = "MAKLUMAT PELANGGAN"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblNotel As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNotel As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Bil As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents No_tel As DataGridViewTextBoxColumn

End Class
