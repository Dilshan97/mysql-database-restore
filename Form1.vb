
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim MysqlConn As MySqlConnection
    Dim Commads As MySqlCommand
    Dim strResSQLsentence As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=saddathissa;port=3306"

        Try
            strResSQLsentence = "RESTORE DATABASE saddathissa FROM DISK='" & TextBox1.Text & "'"
            MysqlConn.Open()
            Commads = New MySqlCommand(strResSQLsentence, MysqlConn)
            Commads.ExecuteNonQuery()
            MessageBox.Show("DataBase have been restored.")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show("Could Not be restored.")
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub
End Class
