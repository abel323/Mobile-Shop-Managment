Public Class frmMainMenu
    Dim cmd As New SqlClient.SqlCommand
    Dim sql As String
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Dispose()
    End Sub
    Private Sub TotalBrand()
        Dim counter As Integer
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Close()
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM tblBrand"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    counter += 1
                End While
                DR.Close()
                lblBrand.Text = lblBrand.Text & counter
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub
    Private Sub TotalCustomer()
        Dim counter As Integer
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM tblCustomer"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    counter += 1
                End While
                DR.Close()
                lblCustomer.Text = lblCustomer.Text & counter
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub ItemsCount()
        Dim counter As Integer = 0
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM tblMobile"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    counter = counter + 1
                End While
                DR.Close()
                lblTotalItems.Text = lblTotalItems.Text & counter
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub TotalSales()
        Dim DR As SqlClient.SqlDataReader
        Dim TotalSales As Decimal = 0
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT Total FROM tblSale"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    TotalSales = TotalSales + Val(DR.GetValue(0).ToString)
                End While
                DR.Close()
                lblTotalSales.Text = lblTotalSales.Text & TotalSales
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalBrand()
        TotalCustomer()
        ItemsCount()
        TotalSales()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBrand.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMobile_Click(sender As Object, e As EventArgs) Handles btnMobile.Click
        frmMobile.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Dispose()
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSale.Show()
        Me.Dispose()
    End Sub
End Class