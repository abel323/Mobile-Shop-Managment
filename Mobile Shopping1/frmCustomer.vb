Public Class frmCustomer
    Dim cmd As New SqlClient.SqlCommand
    Dim sql As String
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM tblCustomer"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DT)
                dgvCustomer.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        frmBrand.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMobile_Click(sender As Object, e As EventArgs) Handles btnMobile.Click
        frmMobile.Show()
        Me.Dispose()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMainMenu.Show()
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "INSERT INTO tblCustomer(FName,LName,MName,DOR,Phone,Email,Customer_Address) VALUES('" & txtFName.Text &
                    "','" & txtLName.Text & "','" & txtMName.Text & "','" & txtDOR.Text & "','" & txtPNumber.Text & "','" & txtEmail.Text & "','" &
                    txtAddress.Text & "')"
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Inserted Successfully!", vbInformation)
                    txtFName.Clear()
                    txtLName.Clear()
                    txtMName.Clear()
                    txtDOR.ResetText()
                    txtAddress.Clear()
                    txtPNumber.Clear()
                    txtEmail.Clear()
                    sql = "SELECT * FROM tblCustomer"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvCustomer.DataSource = DT
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

    Private Sub dgvCustomer_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomer.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCustomer.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value.ToString
            txtFName.Text = row.Cells(1).Value.ToString
            txtLName.Text = row.Cells(2).Value.ToString
            txtMName.Text = row.Cells(3).Value.ToString
            txtDOR.Text = row.Cells(4).Value.ToString
            txtPNumber.Text = row.Cells(5).Value.ToString
            txtEmail.Text = row.Cells(6).Value.ToString
            txtAddress.Text = row.Cells(7).Value.ToString
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "DELETE FROM tblCustomer WHERE ID=" & Val(txtID.Text)
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Deleted Successfully!", vbInformation)
                    txtFName.Clear()
                    txtLName.Clear()
                    txtMName.Clear()
                    txtDOR.ResetText()
                    txtAddress.Clear()
                    txtPNumber.Clear()
                    txtEmail.Clear()
                    sql = "SELECT * FROM tblCustomer"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvCustomer.DataSource = DT
                Else
                    MsgBox("Unable To Delete Data", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "UPDATE tblCustomer SET FName='" & txtFName.Text & "', LName='" & txtLName.Text & "', " &
                    "MName='" & txtMName.Text & "', DOR='" & txtDOR.Text & "', Phone='" & txtPNumber.Text & "', Email='" &
                    txtEmail.Text & "', Customer_Address='" & txtAddress.Text & "' WHERE ID=" & Val(txtID.Text)
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Updated Successfully!", vbInformation)
                    txtFName.Clear()
                    txtLName.Clear()
                    txtMName.Clear()
                    txtDOR.ResetText()
                    txtAddress.Clear()
                    txtPNumber.Clear()
                    txtEmail.Clear()
                    sql = "SELECT * FROM tblCustomer"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvCustomer.DataSource = DT
                Else
                    MsgBox("Unable To Update Data", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSale.Show()
        Me.Dispose()
    End Sub
End Class