Imports MySql.Data.MySqlClient

Public Class Table
    Public dbdataset As New DataTable

    Private Sub Table_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Table_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = tablename
        Load_data()
    End Sub
    Public Sub Load_data()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring + ";database=" & databasename

        
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT * FROM `" & tablename & "`"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView_Tables.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class