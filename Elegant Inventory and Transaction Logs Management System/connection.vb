Imports MySql.Data.MySqlClient
Module connection
    'declarations
    Public connection As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdReader As MySqlDataReader
    Private connectionString As String = "server=localhost;uid=root;password=;database=elegant_dbms"

    'opening mysql connection
    Public Sub readQuery(ByVal sql As String)
        Try
            With connection
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connectionString
                .Open()
            End With
            With cmd
                .Connection = connection
                .CommandText = sql
                cmdReader = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
