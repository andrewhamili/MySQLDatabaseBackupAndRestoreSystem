Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Home

    Private Sub Home_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
        Me.Dispose()
        Form_Connection.Show()
    End Sub

    Private Sub Home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Show_Databases()
    End Sub

    Public Sub Show_Databases()

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Dim query As String
        Try
            MySQLConn.Open()
            query = "SHOW DATABASES"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ListBox_Databases.Items.Add(reader.GetString("Database"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Show_Tables()
        ListBox_Tables.Items.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.Dispose()
        MySQLConn.ConnectionString = connstring + ";database=" & ListBox_Databases.Text

        Dim query As String

        Try

            MySQLConn.Open()
            query = "Show tables"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ListBox_Tables.Items.Remove(reader.GetString("Tables_in_" + ListBox_Databases.Text))
                ListBox_Tables.Items.Add(reader.GetString("Tables_in_" + ListBox_Databases.Text))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btn_ShowTables_Click(sender As System.Object, e As System.EventArgs) Handles btn_ShowTables.Click
        Show_Tables()
    End Sub

    Private Sub Button_ShowTableData_Click(sender As System.Object, e As System.EventArgs) Handles Button_ShowTableData.Click

        databasename = ListBox_Databases.Text
        tablename = ListBox_Tables.Text
        If databasename = "mysql" Or databasename = "performance_schema" Or databasename = "sakila" Or databasename = "information_schema" Or databasename = "test" Then
            MsgBox("The Developer of this Application does not allow anyone to view the contents of the " & databasename & " Database. He beleieves that you are not the one who created that Database. Sorry.", MsgBoxStyle.Critical, SystemTitle)
        Else
            Table.ShowDialog()
        End If

    End Sub
    Private Sub Button_DatabaseBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DatabaseBackup.Click

        MsgBox("Click OK to start the Back-up Process. This may take several minutes depending on how many data that will be backed up or depending on the speed of your System. " & vbCrLf & "" & vbCrLf & "PLEASE BE PATIENT", MsgBoxStyle.Information, "Junior Philippine Computer Society")

        databasename = ListBox_Databases.Text
        Database_Backup()
        Dim sqlFile As New FileInfo("backup.sql")
        Dim ArchivedFile As New FileInfo(databasename + ".7z")
        If sqlFile.Length > 100 Then
            Dim run As New Process
            run.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            run.StartInfo.CreateNoWindow = True
            run.StartInfo.FileName = ("7z.exe")
            run.StartInfo.Arguments = ("a " & databasename & ".7z backup.sql -p177c1499714ca88953b5e097ebad22a19fa36c3cd9b26b32e96a8d029bcdc73267562004b17096bf75c7b23a15b4b11d924b8e1ebfb5fc5097f3714e77506fac -mhe")
            run.Start()
            run.WaitForExit()

            If Not Directory.Exists(Environment.GetEnvironmentVariable("userprofile") + "\Desktop\Database\") Then
                Directory.CreateDirectory(Environment.GetEnvironmentVariable("userprofile") + "\Desktop\Database\")
            End If

            sqlFile.Delete()
            If SaveFileDialog_DatabaseBackup.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\Desktop\Database\" & databasename & ".7z")
                ArchivedFile.MoveTo(SaveFileDialog_DatabaseBackup.FileName)
            Else
                MsgBox("You have cancelled the Backup Process!", MsgBoxStyle.Information, SystemTitle)
                ArchivedFile.Delete()
            End If
        Else
            MsgBox("The System was not able to Produce a Database Backup. Please send a report to the Developer immediately!", MsgBoxStyle.Critical, SystemTitle)


        End If



    End Sub

    Public Sub Database_Backup()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring + ";database=" & databasename
        comm = New MySqlCommand()
        comm.Connection = MySQLConn
        Dim mb As New MySqlBackup(comm)
        Try
            MySQLConn.Open()
            mb.ExportInfo.EnableEncryption = True
            mb.ExportInfo.EncryptionPassword = "177c1499714ca88953b5e097ebad22a19fa36c3cd9b26b32e96a8d029bcdc73267562004b17096bf75c7b23a15b4b11d924b8e1ebfb5fc5097f3714e77506fac"
            mb.ExportInfo.AddCreateDatabase = True
            mb.ExportToFile("backup.sql")
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, SystemTitle)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
    End Sub
End Class