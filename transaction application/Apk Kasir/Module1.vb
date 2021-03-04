Imports System.Data.Odbc
Module Module1
    Public Conn As New OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    Public Sub koneksi()
        Try
            Conn = New Odbc.OdbcConnection
            Conn.ConnectionString = "DSN=Konek_Admin"
            Conn.Open()
        Catch ex As Exception

        End Try
    End Sub

End Module
