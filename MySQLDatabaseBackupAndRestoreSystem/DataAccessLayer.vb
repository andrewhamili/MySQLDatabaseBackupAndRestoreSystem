Imports MySql.Data.MySqlClient
Public Class DataAccessLayer
    Protected MySQLConn As New MySqlConnection
    Protected db As String = ""
    Protected server As String = ""
    Protected uname As String = ""
    Protected pwd As String = ""
    Public Sub New(Host As String, Database As String, Username As String, Password As String)
        server = Host
        db = Database
        uname = Username
        pwd = Password
    End Sub
    Protected Sub ConnectDB()
        With MySQLConn
            .ConnectionString = String.Format("server={0};username={1};password={2};database={3}", server, uname, pwd, db)
            .Open()
        End With
    End Sub
    Protected Sub CloseDB()
        With MySQLConn
            .Close()
        End With
    End Sub
    Public Function ExecQuery(ByVal query As String) As DataTable
        Return ExecCommand(query)
    End Function
    Public Function ExecStoredProc(ByVal storedProc As String, Optional ByVal param As List(Of MySqlParameter) = Nothing) As DataTable
        Return ExecCommand(storedProc, True, param)
    End Function
    Private Function ExecCommand(ByVal query As String, Optional ByVal useStoredProc As Boolean = False, Optional ByVal param As List(Of MySqlParameter) = Nothing) As DataTable
        ConnectDB()
        Dim adapter As New MySqlDataAdapter
        Dim comm As New MySqlCommand
        Dim dbdataset As New DataTable

        With comm

            If Not userStoredProc Then
                .CommandType = CommandType.Text
            Else
                .CommandType = CommandType.StoredProcedure
                If Not IsNothing(param) Then
                    .Parameters.Clear()
                    For Each sqlParam As MySqlParameter In param
                        .Parameters.Add(sqlParam)
                    Next
                End If
            End If
        End With
        With adapter
            .SelectCommand = comm
            .Fill(dbdataset)
            .Dispose()
        End With
        CloseDB()
        Return dbdataset
    End Function
    Public Function ExecScalar(ByVal query As String) As Object
        Dim result As Object
        ConnectDB()
        Dim comm As New MySqlCommand
        With comm
            .Connection = MySQLConn
            .CommandText = query
            .CommandType = CommandType.Text

            result = .ExecuteScalar
        End With

        CloseDB()
        Return result
    End Function
End Class
