Imports MySql.Data.MySqlClient
Module GlobaslVariableModule
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=" & Form_Connection.txt_host.Text & ";port=" & Form_Connection.txt_port.Text & ";username=" & Form_Connection.txt_username.Text & ";password=" & Form_Connection.txt_password.Text & ""
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader
    Public SystemTitle As String = "MySQL Database Backup and Restore"

    Public databasename As String
    Public tablename As String
End Module
