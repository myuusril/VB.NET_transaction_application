Imports System.Data.Odbc
Public Class Form3
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200&
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label16.Visible = False
        Label6.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label1.Visible = False
        Label64.Visible = False
        Paneladmin.Visible = True
        Panelbarang.Visible = False
        Paneltransaksi.Visible = False
        Panelhome.Visible = False
        Panelnota.Visible = False
        Panellaporan.Visible = False
        Call awaldata()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label16.Visible = False
        Label6.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = True
        Label1.Visible = False
        Label64.Visible = False
        Panelhome.Visible = True
        Paneladmin.Visible = False
        Panellaporan.Visible = False
        Panelbarang.Visible = False
        Paneltransaksi.Visible = False
        Panelnota.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label16.Visible = False
        Label6.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label1.Visible = False
        Label64.Visible = False
        Paneladmin.Visible = False
        Panelbarang.Visible = False
        Paneltransaksi.Visible = True
        Panelhome.Visible = False
        Panelnota.Visible = False
        Panellaporan.Visible = False
        Call awaltransaksi()
        Call semuakolom()
    End Sub
    Sub semuakolom()
        DataGridView3.Columns(0).HeaderText = "KODE BARANG"
        DataGridView3.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView3.Columns(2).HeaderText = "HARGA BELI"
        DataGridView3.Columns(3).HeaderText = "HARGA JUAL"
        DataGridView3.Columns(4).HeaderText = "SATUAN"
        DataGridView3.Columns(0).Width = 120
        DataGridView3.Columns(1).Width = 380
        DataGridView3.Columns(2).Width = 120
        DataGridView3.Columns(3).Width = 120
        DataGridView3.Columns(4).Width = 120
        DataGridView3.Columns(2).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView3.Columns(3).DefaultCellStyle.Format = "Rp ###,###"

        DataGridView2.Columns(0).HeaderText = "KODE BARANG"
        DataGridView2.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView2.Columns(2).HeaderText = "HARGA BELI"
        DataGridView2.Columns(3).HeaderText = "HARGA JUAL"
        DataGridView2.Columns(4).HeaderText = "SATUAN"
        DataGridView2.Columns(0).Width = 120
        DataGridView2.Columns(1).Width = 380
        DataGridView2.Columns(2).Width = 120
        DataGridView2.Columns(3).Width = 120
        DataGridView2.Columns(4).Width = 120
        DataGridView2.Columns(2).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView2.Columns(3).DefaultCellStyle.Format = "Rp ###,###"

        DataGridView4.Columns(6).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView4.Columns(7).DefaultCellStyle.Format = "Rp ###,###"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Panelbarang
            TextBox6.Focus()
        End With
        Label16.Visible = False
        Label6.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
        Label5.Visible = False
        Label1.Visible = False
        Label64.Visible = False
        Paneladmin.Visible = False
        Panelbarang.Visible = True
        Paneltransaksi.Visible = False
        Panelhome.Visible = False
        Panelnota.Visible = False
        Panellaporan.Visible = False
        Call awalbarang()
        Call semuakolom()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label16.Visible = False
        Label4.Visible = True
        Label6.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label1.Visible = False
        Label64.Visible = False
        Call awalnota()
        Call semuakolom()
        Panelnota.Visible = True
        Paneladmin.Visible = False
        Panelbarang.Visible = False
        Paneltransaksi.Visible = False
        Panelhome.Visible = False
        Panellaporan.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.Visible = True
        If Button7.Text = "      LOGOUT" Then
            Select Case MsgBox("Anda Akan Logout" & vbCrLf & "Apakah Anda Yakin???", vbYesNo Or vbQuestion Or vbDefaultButton1, "Warning")
                Case vbNo
                    Exit Sub
                Case vbYes
            End Select
            Me.Close()
            Form1.Show()
        End If
        Label6.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        Label1.Visible = True
        If Button7.Text = "LogOut" Then
            Select Case MsgBox("Anda Akan Logout" & vbCrLf & "Apakah Anda Yakin???", vbYesNo Or vbQuestion Or vbDefaultButton1, "Warning")
                Case vbNo
                    Exit Sub
                Case vbYes
            End Select
            Me.Close()
        End If
        Form1.ShowDialog()
        Label6.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panelhome.Visible = True
        Paneladmin.Visible = False
        Panelbarang.Visible = False
        Paneltransaksi.Visible = False
        Panelnota.Visible = False
        Panellaporan.Visible = False
        Label8.Text = "Riri"
        Call awaldata()
        Call awalbarang()
        Call awaltransaksi()
        Call awalnota()
        Call awallaporan()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = TimeOfDay
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label16.Visible = True
        Label6.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label1.Visible = False
        Label64.Visible = False
        Panellaporan.Visible = True
        Panelhome.Visible = False
        Paneladmin.Visible = False
        Panelnota.Visible = False
        Panelbarang.Visible = False
        Paneltransaksi.Visible = False
        Call awallaporan()
    End Sub
    Sub namapelanggantransaksi()
        Call koneksi()
        Cmd = New OdbcCommand("select distinct namapelanggan from pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        Do While Rd.Read
            ComboBox2.Items.Add(Rd.Item("namapelanggan"))
            ComboBox3.Items.Add(Rd.Item("namapelanggan"))
            ComboBox4.Items.Add(Rd.Item("namapelanggan"))
        Loop
    End Sub
    Sub awallaporan()
        DataGridView5.Enabled = False
        ComboBox4.Enabled = False
        TextBox20.Enabled = False
        TextBox11.Enabled = False
        TextBox21.Enabled = False
        TextBox22.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        Button18.Enabled = False
        Button21.Enabled = False
        Button23.Enabled = False
        Button24.Enabled = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        Label56.Text = "Data"
        DataGridView5.Columns.Clear()
        ComboBox4.Text = ""
        TextBox20.Text = ""
        Label55.Text = ""
        Label57.Text = ""
        TextBox11.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        Label60.Text = Format(DateTimePicker1.Value, "yyyy, MM, dd")
        Label61.Text = Format(DateTimePicker2.Value, "yyyy, MM, dd")
    End Sub
    Sub awaltransaksi()
        ComboBox2.Focus()
        Label42.Text = ""
        ComboBox2.Text = ""
        DataGridView3.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Call noruttransaksi()
        Call namapelanggantransaksi()
        Call isitransaksi()
    End Sub
    Sub isitransaksi()
        TextBox10.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        Label41.Text = Today
        Label41.Text = Format(Today, "yyyy-MM-dd")
        Call koneksi()
        Da = New OdbcDataAdapter("select kodebrg,namabrg,hargabeli,hargajual,satuan from barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView3.DataSource = Ds.Tables("barang")
        DataGridView3.ReadOnly = True
    End Sub
    Sub awalbarang()
        'TextBox6.Focus()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox1.Text = ""
        Button13.Enabled = False
        Button14.Enabled = False
        Call satuanbarang()
        Call norutbrg()
        Call koneksi()
        Da = New OdbcDataAdapter("select kodebrg,namabrg,hargabeli,hargajual,satuan from barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView2.DataSource = Ds.Tables("barang")
        DataGridView2.ReadOnly = True
    End Sub
    Sub awaldata()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label11.Text = "Data"
        Label18.Text = "ID"
        Label19.Text = "Nama"
        Label20.Text = "Alamat"
        Label21.Text = "Telepon"
        DataGridView1.Columns.Clear()
    End Sub
    Sub isi()
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = True
    End Sub
    Sub noruttransaksi()
        Call koneksi()
        Cmd = New Odbc.OdbcCommand("select * from transaksibrg where nonota in (select max(nonota) from transaksibrg)", Conn)
        Dim uruttransaksi As String
        Dim hitungtransaksi As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            uruttransaksi = "TRA" + Format(Now, "yyMMdd") + "0001"
        Else
            hitungtransaksi = Microsoft.VisualBasic.Right(Rd.GetString(0), 10) + 1
            uruttransaksi = "TRA" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitungtransaksi, 4)
        End If
        Label40.Text = uruttransaksi
    End Sub
    Sub norutpelanggan()
        Call koneksi()
        Cmd = New Odbc.OdbcCommand("select * from pelanggan where idpelanggan in (select max(idpelanggan) from pelanggan)", Conn)
        Dim urutplg As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutplg = "PLG" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutplg = "PLG" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutplg
        TextBox2.Focus()
    End Sub
    Sub norutadmin()
        Call koneksi()
        Cmd = New Odbc.OdbcCommand("select * from admin where idadmin in (select max(idadmin) from admin)", Conn)
        Dim urutadmin As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutadmin = "ADM" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutadmin = "ADM" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutadmin
    End Sub
    Sub norutbrg()
        Call koneksi()
        Cmd = New Odbc.OdbcCommand("select * from barang where kodebrg in (select max(kodebrg) from barang)", Conn)
        Dim urutbrg As String
        Dim hitungbrg As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutbrg = "BRG" + "001"
        Else
            hitungbrg = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutbrg = "BRG" + Microsoft.VisualBasic.Right("000" & hitungbrg, 3)
        End If
        TextBox5.Text = urutbrg
        TextBox6.Focus()
    End Sub
    Sub norutcetak()
        Call koneksi()
        Cmd = New Odbc.OdbcCommand("select * from lapprint where nocetak in (select max(nocetak) from lapprint)", Conn)
        Dim urutcetak As String
        Dim hitungcetak As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutcetak = "AF" + "001"
        Else
            hitungcetak = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutcetak = "AF" + Microsoft.VisualBasic.Right("000" & hitungcetak, 3)
        End If
        Label48.Text = urutcetak
        Label58.Text = urutcetak
    End Sub
    Sub satuanbarang()
        Call koneksi()
        Cmd = New OdbcCommand("select distinct satuan from barang", Conn)
        Rd = Cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item("satuan"))
        Loop
    End Sub
    Sub awalnota()
        ComboBox3.Text = ""
        Button19.Enabled = False
        Button20.Enabled = False
        ComboBox3.Focus()
        Call namapelanggantransaksi()
        Call totalnota()
        Call totalitem()
        Call kolomnota()
        Call norutcetak()
    End Sub
    Sub kolomnota()
        Call koneksi()
        Da = New OdbcDataAdapter("select * from transaksibrg", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "transaksibrg")
        DataGridView4.DataSource = Ds.Tables("transaksibrg")
        DataGridView4.ReadOnly = True
    End Sub
    Sub kolomsaatini()
        Call koneksi()
        Da = New OdbcDataAdapter("select * from transaksibrg", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "transaksibrg")
        DataGridView5.DataSource = Ds.Tables("transaksibrg")
        DataGridView5.ReadOnly = True
    End Sub
    Sub kolomtercetak()
        Call koneksi()
        Da = New OdbcDataAdapter("select * from lapcetak", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "lapcetak")
        DataGridView5.DataSource = Ds.Tables("lapcetak")
        DataGridView5.ReadOnly = True
    End Sub
    Sub kolomawalsekali()
        Call koneksi()
        Da = New OdbcDataAdapter("select * from detailjualan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "detailjualan")
        DataGridView5.DataSource = Ds.Tables("detailjualan")
        DataGridView5.ReadOnly = True
    End Sub
    Sub kolomplg()
        Call koneksi()
        Da = New OdbcDataAdapter("select idpelanggan,namapelanggan,alamat,telepon from pelanggan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pelanggan")
        DataGridView1.DataSource = Ds.Tables("pelanggan")
        DataGridView1.ReadOnly = True
    End Sub
    Sub kolomadmin()
        Call koneksi()
        Da = New OdbcDataAdapter("select idadmin,username,nama from admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "admin")
        DataGridView1.DataSource = Ds.Tables("admin")
        DataGridView1.ReadOnly = True
    End Sub
    Sub totalnota()
        Dim jumlahtotal As Integer = 0
        For i As Integer = 0 To DataGridView4.Rows.Count - 1
            jumlahtotal = jumlahtotal + DataGridView4.Rows(i).Cells(7).Value
            Label46.Text = jumlahtotal
            Label44.Text = jumlahtotal
            Label44.Text = FormatCurrency(jumlahtotal)
        Next
    End Sub
    Sub totalitem()
        Dim jumlahitem As Integer = 0
        For i As Integer = 0 To DataGridView4.Rows.Count - 1
            jumlahitem = jumlahitem + DataGridView4.Rows(i).Cells(4).Value
            Label50.Text = jumlahitem
        Next
    End Sub
    Sub itemtra()
        Dim jumlahitem As Integer = 0
        For i As Integer = 0 To DataGridView5.Rows.Count - 1
            jumlahitem = jumlahitem + DataGridView5.Rows(i).Cells(4).Value
            Label54.Text = jumlahitem
        Next
    End Sub
    Sub itemcetak()
        Dim jumlahitem As Integer = 0
        For i As Integer = 0 To DataGridView5.Rows.Count - 1
            jumlahitem = jumlahitem + DataGridView5.Rows(i).Cells(4).Value
            Label54.Text = jumlahitem
        Next
    End Sub
    Sub itemawal()
        Dim jumlahitem As Integer = 0
        For i As Integer = 0 To DataGridView5.Rows.Count - 1
            jumlahitem = jumlahitem + DataGridView5.Rows(i).Cells(5).Value
            Label54.Text = jumlahitem
        Next
    End Sub
    Sub totaltransaksi()
        Dim totaltra As Integer = 0
        For i As Integer = 0 To DataGridView5.Rows.Count - 1
            totaltra = totaltra + DataGridView5.Rows(i).Cells(7).Value
            Label55.Text = totaltra
            Label57.Text = totaltra
            Label57.Text = FormatCurrency(totaltra)
        Next
    End Sub
    Sub totalcetak()
        Dim totaltra As Integer = 0
        For i As Integer = 0 To DataGridView5.Rows.Count - 1
            totaltra = totaltra + DataGridView5.Rows(i).Cells(7).Value
            Label55.Text = totaltra
            Label57.Text = totaltra
            Label57.Text = FormatCurrency(totaltra)
        Next
    End Sub
    Sub totaldariawal()
        Dim totaldariawal As Integer = 0
        For i As Integer = 0 To DataGridView5.Rows.Count - 1
            totaldariawal = totaldariawal + DataGridView5.Rows(i).Cells(8).Value
            Label55.Text = totaldariawal
            Label57.Text = totaldariawal
            Label57.Text = FormatCurrency(totaldariawal)
        Next
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Call isi()
        Call norutpelanggan()
        Label11.Text = "Data Pelanggan"
        Label18.Text = "ID - Pelanggan"
        Label19.Text = "Nama"
        Label20.Text = "Alamat"
        Label21.Text = "Telepon"
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Call kolomplg()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(2).Width = 250
        DataGridView1.Columns(3).Width = 150
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call awaldata()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Call isi()
        Call norutadmin()
        Label11.Text = "Data Admin"
        Label18.Text = "ID - Admin"
        Label19.Text = "Username"
        Label20.Text = "Nama"
        Label21.Text = "Pasword"
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Call kolomadmin()
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RadioButton1.Checked = True Then
            If TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Isi Data Dengan Benar", MsgBoxStyle.Information, "Warning")
            Else
                MyDB = "insert into pelanggan (idpelanggan, namapelanggan, alamat, telepon) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                Cmd = New Odbc.OdbcCommand(MyDB, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diinputkan", MsgBoxStyle.Information, "Warning")
                Call kolomplg()
            End If
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox2.Focus()
            Call norutpelanggan()
        End If
        If RadioButton2.Checked = True Then
            If TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Isi Data Dengan Benar", MsgBoxStyle.Information, "Warning")
            Else
                MyDB = "insert into admin (idadmin, username, password, nama) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "')"
                Cmd = New Odbc.OdbcCommand(MyDB, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diinputkan", MsgBoxStyle.Information, "Warning")
                Call kolomadmin()
            End If
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox2.Focus()
            Call norutadmin()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RadioButton1.Checked = True Then
            If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Isi Semua Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
            Else
                Call koneksi()
                Dim Editdata As String = "update pelanggan set namapelanggan ='" & TextBox2.Text & "',alamat='" & TextBox3.Text & "',telepon='" & TextBox4.Text & "' where idpelanggan='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(Editdata, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil", MsgBoxStyle.Information, "Warning")
                TextBox2.Focus()
                Call kolomplg()
                Call norutpelanggan()
            End If
        End If
        If RadioButton2.Checked = True Then
            If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Isi Semua Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
            Else
                Call koneksi()
                Dim Editdata As String = "update admin set username ='" & TextBox2.Text & "',password='" & TextBox4.Text & "',nama='" & TextBox3.Text & "' where idadmin='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(Editdata, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil", MsgBoxStyle.Information, "Warning")
                TextBox2.Focus()
                Call kolomadmin()
                Call norutadmin()
            End If
        End If
        Button8.Enabled = True
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton1.Checked = True Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Isi Semua Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
            Else
                Call koneksi()
                Dim Hapusdata As String = "delete from pelanggan where idpelanggan='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(Hapusdata, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil", MsgBoxStyle.Information, "Warning")
                TextBox3.Focus()
                Call awaldata()
            End If
        End If
        If RadioButton2.Checked = True Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Isi Semua Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
            Else
                Call koneksi()
                Dim Hapusdata As String = "delete from admin where idadmin='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(Hapusdata, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil", MsgBoxStyle.Information, "Warning")
                Call awaldata()
            End If
        End If
        Button8.Enabled = True
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If RadioButton1.Checked = True Then
            If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Call awalbarang()
        Button12.Enabled = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Isi Data Dengan Benar", MsgBoxStyle.Information, "Warning")
        Else
            MyDB = "insert into barang (kodebrg, namabrg, hargabeli, hargajual, satuan) values ('" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & ComboBox1.Text & "')"
            Cmd = New Odbc.OdbcCommand(MyDB, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinputkan", MsgBoxStyle.Information, "Warning")
        End If
        DataGridView2.Columns(0).Width = 100
        DataGridView2.Columns(1).Width = 300
        DataGridView2.Columns(2).Width = 100
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(4).Width = 100
        Call awalbarang()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Isi Semua Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
        Else
            Call koneksi()
            Dim Editdata As String = "update barang set namabrg ='" & TextBox6.Text & "',hargabeli='" & TextBox7.Text & "',hargajual='" & TextBox8.Text & "',satuan='" & ComboBox1.Text & "' where kodebrg='" & TextBox5.Text & "'"
            Cmd = New OdbcCommand(Editdata, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Update Data Berhasil", MsgBoxStyle.Information, "Warning")
            Call awalbarang()
            Call norutbrg()
            Button12.Enabled = True
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Isi Semua Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
        Else
            Call koneksi()
            Dim Hapusdata As String = "delete from barang where kodebrg='" & TextBox5.Text & "'"
            Cmd = New OdbcCommand(Hapusdata, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil", MsgBoxStyle.Information, "Warning")
            Call norutbrg()
            Call awalbarang()
            Button12.Enabled = True
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Call koneksi()
        Cmd = New OdbcCommand("select * from barang where namabrg like '%" & TextBox9.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call koneksi()
            Da = New OdbcDataAdapter("select * from barang where namabrg like '%" & TextBox9.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DataGridView2.DataSource = Ds.Tables(0)
        Else
            MsgBox("Data Tidak di Temukan", MsgBoxStyle.Information, "Warning")
            TextBox9.Text = ""
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        Button12.Enabled = False
        Button13.Enabled = True
        Button14.Enabled = True
        TextBox5.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        TextBox6.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString()
        TextBox7.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString()
        TextBox8.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        On Error Resume Next
        Button8.Enabled = False
        Button9.Enabled = True
        Button10.Enabled = True
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Call koneksi()
        Cmd = New OdbcCommand("select * from barang where namabrg like '%" & TextBox10.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call koneksi()
            Da = New OdbcDataAdapter("select * from barang where namabrg like '%" & TextBox10.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DataGridView3.DataSource = Ds.Tables(0)
        Else
            MsgBox("Data Tidak di Temukan", MsgBoxStyle.Information, "Warning")
            TextBox10.Text = ""
        End If
    End Sub

    Private Sub DataGridView3_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView3.DoubleClick
        TextBox12.Text = DataGridView3.CurrentRow.Cells(0).Value.ToString()
        TextBox16.Text = DataGridView3.CurrentRow.Cells(1).Value.ToString()
        TextBox18.Text = DataGridView3.CurrentRow.Cells(3).Value.ToString()
        TextBox17.Text = DataGridView3.CurrentRow.Cells(4).Value.ToString()
        TextBox13.Focus()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        On Error Resume Next
        TextBox19.Text = Val(TextBox14.Text) * Val(TextBox18.Text)
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        On Error Resume Next
        TextBox19.Text = Val(TextBox14.Text) * Val(TextBox18.Text)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Call awaltransaksi()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox14.Text = "" Or TextBox12.Text = "" Or ComboBox2.Text = "" Or Label42.Text = "" Then
            MsgBox("Isi Data Dengan Benar", MsgBoxStyle.Information, "Warning")
        Else
            Dim transaksibrg As String = "insert into transaksibrg values ('" & Label40.Text & "','" & Label41.Text & "','" & TextBox16.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "','" & TextBox15.Text & "','" & Label42.Text & "','" & ComboBox2.Text & "')"
            Cmd = New OdbcCommand(transaksibrg, Conn)
            Cmd.ExecuteNonQuery()

            Dim detailjualan As String = "insert into detailjualan values('" & Label40.Text & "','" & TextBox12.Text & "','" & Label41.Text & "','" & TextBox16.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "','" & TextBox15.Text & "','" & ComboBox2.Text & "','" & Label8.Text & "')"
            Cmd = New OdbcCommand(detailjualan, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput", MsgBoxStyle.Information, "Warning")
            Call noruttransaksi()
            Call isitransaksi()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        DataGridView3.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Call koneksi()
        Cmd = New OdbcCommand("select * from pelanggan where namapelanggan ='" & ComboBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Label42.Text = Rd!idpelanggan
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Call awalnota()
        ComboBox3.Text = ""
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If ComboBox3.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Cek Nama Pelanggan", MsgBoxStyle.Information, "Warning")
        Else
            Select Case MsgBox("Apakah Data Sudah Benar???" & vbCrLf & "Apakah Anda Yakin???", vbYesNo Or vbQuestion Or vbDefaultButton1, "Warning")
                Case vbNo
                    Exit Sub
                Case vbYes
            End Select
            Dim lapprint As String = "insert into lapprint values ('" & Label48.Text & "','" & Label41.Text & "','" & ComboBox3.Text & "','" & Label50.Text & "','" & Label46.Text & "','" & Label59.Text & "')"
            Cmd = New OdbcCommand(lapprint, Conn)
            Cmd.ExecuteNonQuery()
            For baris As Integer = 0 To DataGridView4.Rows.Count - 2
                Dim lapcetakk As String = "insert into lapcetak values('" & Label48.Text & "','" & DataGridView4.Rows(baris).Cells(0).Value & "','" & DataGridView4.Rows(baris).Cells(2).Value & "','" & DataGridView4.Rows(baris).Cells(3).Value & "','" & DataGridView4.Rows(baris).Cells(4).Value & "','" & DataGridView4.Rows(baris).Cells(5).Value & "','" & DataGridView4.Rows(baris).Cells(6).Value & "','" & DataGridView4.Rows(baris).Cells(7).Value & "','" & DataGridView4.Rows(baris).Cells(8).Value & "','" & DataGridView4.Rows(baris).Cells(9).Value & "','" & ComboBox3.Text & "')"
                Cmd = New OdbcCommand(lapcetakk, Conn)
                Cmd.ExecuteNonQuery()
            Next

            If MessageBox.Show("Apakah Anda ingin Cetak Nota...?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MsgBox("Silahkan Hubungi yang punya aplikasi kalau mau pakai aplikasi ini", MsgBoxStyle.Information, "Warning")
                'AxCrystalReport2.SelectionFormula = "totext({lapprint.nocetak})='" & Label48.Text & "'"
                'AxCrystalReport2.ReportFileName = "notatransaksii.rpt"
                'AxCrystalReport2.WindowState = Crystal.WindowStateConstants.crptMaximized
                'AxCrystalReport2.RetrieveDataFiles()
                'AxCrystalReport2.Action = 1
            End If
        End If
        Call norutcetak()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If ComboBox3.Text = "" Then
            MsgBox("Cek Nama Pelanggan", MsgBoxStyle.Information, "Warning")
        Else
            Select Case MsgBox("DATA AKAN DIHAPUS!!!" & vbCrLf & "Apakah Anda Yakin???", vbYesNo Or vbQuestion Or vbDefaultButton1, "WARNING!!!")
                Case vbNo
                    Exit Sub
                Case vbYes
            End Select
            Call koneksi()
            Dim Hapusnota As String = "delete from transaksibrg where namapelanggan='" & ComboBox3.Text & "'"
            Cmd = New OdbcCommand(Hapusnota, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil", MsgBoxStyle.Information, "Warning")
            Call awalnota()
            Call totalnota()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Button19.Enabled = True
        Button20.Enabled = True
        Call koneksi()
        Cmd = New OdbcCommand("select * from transaksibrg where namapelanggan like '%" & ComboBox3.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call koneksi()
            Da = New OdbcDataAdapter("select * from transaksibrg where namapelanggan like '%" & ComboBox3.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DataGridView4.DataSource = Ds.Tables(0)
        Else
            MsgBox("Data Tidak di Temukan", MsgBoxStyle.Information, "Warning")
            Call awalnota()
        End If
        Call totalnota()
        Call totalitem()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ComboBox4.Text = ""
        Label56.Text = "Data Transaksi Saat ini"
        DataGridView5.Enabled = True
        ComboBox4.Enabled = True
        TextBox11.Enabled = True
        TextBox21.Enabled = True
        TextBox22.Enabled = True
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        Button18.Enabled = False
        Button21.Enabled = True
        Button23.Enabled = True
        Button24.Enabled = True
        Call namapelanggantransaksi()
        Call kolomsaatini()
        Call totaltransaksi()
        Call itemtra()
        DataGridView5.Columns(6).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView5.Columns(7).DefaultCellStyle.Format = "Rp ###,###"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Call awallaporan()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ComboBox4.Text = ""
        Label56.Text = "Data Siap Cetak"
        DataGridView5.Enabled = True
        ComboBox4.Enabled = True
        TextBox20.Enabled = False
        TextBox11.Enabled = False
        TextBox21.Enabled = False
        TextBox22.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        Button18.Enabled = True
        Button21.Enabled = False
        Button23.Enabled = True
        Button24.Enabled = False
        Call kolomtercetak()
        Call totalcetak()
        Call itemcetak()
        Call koneksi()
        Cmd = New OdbcCommand("select distinct nocetak from lapcetak", Conn)
        Rd = Cmd.ExecuteReader
        ComboBox4.Items.Clear()
        Do While Rd.Read
            ComboBox4.Items.Add(Rd.Item("nocetak"))
        Loop
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Label56.Text = "Data Dari Awal Sekali"
        DataGridView5.Enabled = True
        ComboBox4.Enabled = False
        TextBox20.Enabled = False
        TextBox11.Enabled = False
        TextBox21.Enabled = False
        TextBox22.Enabled = False
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        Button18.Enabled = True
        Button21.Enabled = False
        Button23.Enabled = True
        Button24.Enabled = False
        Call kolomawalsekali()
        Call totaldariawal()
        Call itemawal()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If RadioButton4.Checked = True Then
            Call koneksi()
            Cmd = New OdbcCommand("select * from transaksibrg where namapelanggan like '%" & ComboBox4.Text & "%'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call koneksi()
                Da = New OdbcDataAdapter("select * from transaksibrg where namapelanggan like '%" & ComboBox4.Text & "%'", Conn)
                Ds = New DataSet
                Da.Fill(Ds)
                DataGridView5.DataSource = Ds.Tables(0)
                Call totaltransaksi()
                Call itemtra()
            Else
                MsgBox("Data Tidak di Temukan", MsgBoxStyle.Information, "Warning")
                ComboBox4.Text = ""
            End If
        End If
        If RadioButton3.Checked = True Then
            Call koneksi()
            Cmd = New OdbcCommand("select * from lapcetak where nocetak like '%" & ComboBox4.Text & "%'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call koneksi()
                Da = New OdbcDataAdapter("select * from lapcetak where nocetak like '%" & ComboBox4.Text & "%'", Conn)
                Ds = New DataSet
                Da.Fill(Ds)
                DataGridView5.DataSource = Ds.Tables(0)
                Call totalcetak()
                Call itemcetak()
            Else
                MsgBox("Data Tidak di Temukan", MsgBoxStyle.Information, "Warning")
                ComboBox4.Text = ""
            End If
        End If
    End Sub

    Private Sub DataGridView5_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView5.DoubleClick
        TextBox20.Text = DataGridView5.CurrentRow.Cells(0).Value.ToString()
        TextBox11.Text = DataGridView5.CurrentRow.Cells(3).Value.ToString()
        Label62.Text = DataGridView5.CurrentRow.Cells(6).Value.ToString()
        TextBox22.Text = DataGridView5.CurrentRow.Cells(8).Value.ToString()
        TextBox21.Text = DataGridView5.CurrentRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox20.Text = "" Or ComboBox4.Text = "" Then
            MsgBox("Pilih Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
        Else
            Select Case MsgBox("DATA AKAN DIHAPUS!!!" & vbCrLf & "Apakah Anda Yakin???", vbYesNo Or vbQuestion Or vbDefaultButton1, "WARNING!!!")
                Case vbNo
                    Exit Sub
                Case vbYes
            End Select
            Call koneksi()
            Dim Hapustra As String = "delete from transaksibrg where nonota='" & TextBox20.Text & "'"
            Cmd = New OdbcCommand(Hapustra, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil", MsgBoxStyle.Information, "Warning")
            ComboBox4.Text = ""
            TextBox20.Text = ""
            Call kolomsaatini()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If RadioButton3.Checked = True Then
            Select Case MsgBox("Apakah Data Sudah Benar???" & vbCrLf & "Apakah Anda Yakin???", vbYesNo Or vbQuestion Or vbDefaultButton1, "Warning")
                Case vbNo
                    Exit Sub
                Case vbYes
            End Select
            Dim lapprint As String = "insert into lapprint values ('" & Label58.Text & "','" & Label41.Text & "','" & RadioButton5.Text & "','" & Label54.Text & "','" & Label55.Text & "','" & RadioButton5.Text & "')"
            Cmd = New OdbcCommand(lapprint, Conn)
            Cmd.ExecuteNonQuery()

            If MessageBox.Show("Apakah Anda ingin Cetak Nota...?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MsgBox("Silahkan Hubungi yang punya aplikasi kalau mau pakai aplikasi ini", MsgBoxStyle.Information, "Warning")
                'AxCrystalReport1.SelectionFormula = "totext({lapprint.nocetak})='" & ComboBox4.Text & "'"
                'AxCrystalReport1.ReportFileName = "transaksinota.rpt"
                'AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                'AxCrystalReport1.RetrieveDataFiles()
                'AxCrystalReport1.Action = 1
            End If
        End If
        If RadioButton5.Checked = True Then
            Select Case MsgBox("Apakah Data Sudah Benar???" & vbCrLf & "Apakah Anda Yakin???", vbYesNo Or vbQuestion Or vbDefaultButton1, "Warning")
                Case vbNo
                    Exit Sub
                Case vbYes
            End Select
            Dim lapprint As String = "insert into lapprint values ('" & Label58.Text & "','" & Label41.Text & "','" & RadioButton5.Text & "','" & Label54.Text & "','" & Label55.Text & "','" & RadioButton5.Text & "')"
            Cmd = New OdbcCommand(lapprint, Conn)
            Cmd.ExecuteNonQuery()

            If MessageBox.Show("Apakah Anda ingin Cetak Laporan...?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MsgBox("Silahkan Hubungi yang punya aplikasi kalau mau pakai aplikasi ini", MsgBoxStyle.Information, "Warning")
                'AxCrystalReport1.SelectionFormula = "{detailjualan.tanggal} in date (" & Label60.Text & ") to date (" & Label61.Text & ")"
                'AxCrystalReport1.ReportFileName = "lapawal.rpt"
                'AxCrystalReport1.RetrieveDataFiles()
                'AxCrystalReport1.Action = 1
            End If
        End If
        Call norutcetak()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label60.Text = Format(DateTimePicker1.Value, "yyyy, MM, dd")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Label61.Text = Format(DateTimePicker2.Value, "yyyy, MM, dd")
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        On Error Resume Next
        Label63.Text = Val(TextBox21.Text) * Val(Label62.Text)
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click
        On Error Resume Next
        Label63.Text = Val(TextBox21.Text) * Val(Label62.Text)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TextBox20.Text = "" Or TextBox21.Text = "" Then
            MsgBox("Isi Semua Data Terlebih Dahulu", MsgBoxStyle.Information, "Warning")
        Else
            Call koneksi()
            Dim Editdata As String = "update transaksibrg set ket='" & TextBox11.Text & "',jumlahitem='" & TextBox21.Text & "',hargajual='" & Label62.Text & "',totaljual='" & Label63.Text & "',keterangan='" & TextBox22.Text & "' where nonota='" & TextBox20.Text & "'"
            Cmd = New OdbcCommand(Editdata, Conn)
            Cmd.ExecuteNonQuery()

            Dim Editdataawal As String = "update detailjualan set ket='" & TextBox11.Text & "',jumlahitem='" & TextBox21.Text & "',hargajual='" & Label62.Text & "',totaljual='" & Label63.Text & "',keterangan='" & TextBox22.Text & "' where nonota='" & TextBox20.Text & "'"
            Cmd = New OdbcCommand(Editdataawal, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Update Data Berhasil", MsgBoxStyle.Information, "Warning")
            ComboBox4.Text = ""
            TextBox20.Text = ""
            TextBox11.Text = ""
            TextBox21.Text = ""
            TextBox22.Text = ""
            Label62.Text = ""
            Label63.Text = ""
            Call kolomsaatini()
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Label16.Visible = False
        Label6.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label1.Visible = False
        Label64.Visible = True
        Form2.ShowDialog()
    End Sub
End Class