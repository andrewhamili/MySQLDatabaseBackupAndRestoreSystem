Public Class Form_Connection

    Private Sub btn_connect_Click(sender As System.Object, e As System.EventArgs) Handles btn_connect.Click

        Try
            MySQLConn.ConnectionString = connstring
            MySQLConn.Open()
            MySQLConn.Close()
            Home.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message + "" & vbCrLf & "" & vbCrLf & "Connection: " & connstring)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class
