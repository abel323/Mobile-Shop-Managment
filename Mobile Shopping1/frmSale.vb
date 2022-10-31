Public Class frmSale
    Dim cmd As New SqlClient.SqlCommand
    Dim sql As String
    Dim Cust_ID As Integer
    Dim Mobile_ID As Integer
    Dim PrintString As String
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMainMenu.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMobile_Click(sender As Object, e As EventArgs) Handles btnMobile.Click
        frmMobile.Show()
        Me.Dispose()
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        frmBrand.Show()
        Me.Dispose()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Dispose()
    End Sub

    'Method To Load Customer email
    Private Sub CustomerEmail()
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT Email FROM tblCustomer"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    cboCustomerEmail.Items.Add(DR.GetValue(0).ToString)
                End While
                DR.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    'Method to load mobile data
    Private Sub MobileName()
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT Mobile_Name FROM tblMobile"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    cboMobile.Items.Add(DR.GetValue(0).ToString)
                End While
                DR.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerEmail()
        MobileName()
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM SaleView"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DT)
                DataGridView1.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub cboMobile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMobile.SelectedIndexChanged
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT ID,Unit_Price FROM tblMobile WHERE Mobile_Name='" & cboMobile.Text & "'"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    Mobile_ID = Val(DR.GetValue(0).ToString)
                    txtUnitPrice.Text = DR.GetValue(1).ToString
                End While
                DR.Close()
                If Trim(txtQuantity.Text) <> "" Then
                    Dim Total As Decimal
                    Total = Val(txtQuantity.Text) * Val(txtUnitPrice.Text)
                    txtTotal.Text = Total
                End If
                DR.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT Unit_Price FROM tblMobile WHERE Mobile_Name='" & cboMobile.Text & "'"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    txtUnitPrice.Text = DR.GetValue(0).ToString
                End While
                DR.Close()
                If cboMobile.Text <> "" Then
                    Dim Total As Decimal
                    Total = Val(txtQuantity.Text) * Val(txtUnitPrice.Text)
                    txtTotal.Text = Total
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub cboCustomerEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomerEmail.SelectedIndexChanged
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT ID FROM tblCustomer WHERE Email='" & cboCustomerEmail.Text & "'"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    Cust_ID = Val(DR.GetValue(0).ToString)
                End While
                DR.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "INSERT INTO tblSale(Customer_ID,Mobile_ID,Quantity,Unit_Price)" &
                        "VALUES(" & Cust_ID & "," & Mobile_ID & "," & Val(txtQuantity.Text) & "," &
                    Val(txtUnitPrice.Text) & ")"
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Inserted Successfully!", vbInformation)
                    sql = "UPDATE tblMobile SET Quanitiy_In_Stock=Quanitiy_In_Stock-" & Val(txtQuantity.Text) & " WHERE ID=" & Mobile_ID
                    cmd.CommandText = sql
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Mobile Data Is Updated!", vbInformation)
                    Else
                        MsgBox("Mobile Data Is Not Updated")
                    End If
                    cboCustomerEmail.ResetText()
                    cboMobile.ResetText()
                    txtQuantity.Clear()
                    txtTotal.Clear()
                    txtUnitPrice.Clear()
                    sql = "SELECT * FROM SaleView"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    DataGridView1.DataSource = DT
                Else
                    MsgBox("Unable To Insert Data", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            'PrintPreviewDialog1 = PrintDocument1.Site
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintString = "Mobile Type: " & cboMobile.Text & vbCrLf & "Customer: " & cboCustomerEmail.Text & vbCrLf & "Quantity: " & txtQuantity.Text & vbCrLf & "Unit Price: " & txtUnitPrice.Text & vbCrLf & "Total: " & txtTotal.Text
        Dim font As New Font("Times New Roman", 12, FontStyle.Bold) 'set the font to display  
        e.Graphics.DrawString(PrintString, font, Brushes.Black, 100, 100) 'The DrawString() function is used to print letters.  
    End Sub
End Class