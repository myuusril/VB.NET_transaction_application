Imports System.Data.Odbc
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Da = New OdbcDataAdapter("select kodebrg,namabrg,hargajual,satuan from barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView1.DataSource = Ds.Tables("barang")
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(0).HeaderText = "KODE BARANG"
        DataGridView1.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(2).HeaderText = "HARGA BARANG"
        DataGridView1.Columns(3).HeaderText = "SATUAN"
        DataGridView1.Columns(0).Width = 130
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 130
        DataGridView1.Columns(2).DefaultCellStyle.Format = "Rp ###,###"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        Cmd = New OdbcCommand("select * from barang where namabrg like '%" & TextBox1.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call koneksi()
            Da = New OdbcDataAdapter("select * from barang where namabrg like '%" & TextBox1.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DataGridView1.DataSource = Ds.Tables(0)
        Else
            MsgBox("Data Tidak di Temukan", MsgBoxStyle.Information, "Warning")
        End If
    End Sub
End Class