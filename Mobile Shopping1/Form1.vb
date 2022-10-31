Public Class frmLogin
    Dim cmd As New SqlClient.SqlCommand
    Dim sql As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim DR As SqlClient.SqlDataReader
        Dim counter As Integer = 0
        Dim UserName As String = ""
        Dim UserPassword As String = ""
        If Trim(txtUserName.Text) = "" Or Trim(txtPassword.Text) = "" Then
            MsgBox("User Name And Password Are Required", vbCritical)
        Else
            Try
                connect().Open()
                If connect().State = ConnectionState.Open Then
                    sql = "SELECT * FROM tblAdmin WHERE UserName='" & txtUserName.Text & "' AND UserPassword='" & txtPassword.Text & "'"
                    cmd.Connection = connect()
                    cmd.CommandText = sql
                    DR = cmd.ExecuteReader
                    If DR.HasRows = 0 Then
                        DR.Close()
                        MsgBox("Invalid User Name And Password", vbCritical)
                    Else
                        DR.Close()
                        txtUserName.Clear()
                        txtPassword.Clear()
                        MsgBox("Logged In Successfully", vbInformation)
                        frmMainMenu.Show()
                        Me.Hide()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message(), vbCritical)
            Finally
                connect().Close()
            End Try
        End If
    End Sub
End Class
