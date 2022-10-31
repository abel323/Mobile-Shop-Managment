Public Class frmBrand
    Dim cmd As New SqlClient.SqlCommand
    Dim sql As String
    Private Sub frmBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM tblBrand ORDER BY ID"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DT)
                dgvBrandData.DataSource = DT
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "INSERT INTO tblBrand(BrandName) VALUES('" & txtBrandName.Text & "')"
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Inserted Successfully!", vbInformation)
                    txtBrandId.Clear()
                    txtBrandName.Clear()
                    sql = "SELECT * FROM tblBrand"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvBrandData.DataSource = DT
                Else
                    MsgBox("Could Not Add Data!", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub dgvBrandData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBrandData.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBrandData.Rows(e.RowIndex)
            txtBrandId.Text = row.Cells(0).Value.ToString
            txtBrandName.Text = row.Cells(1).Value.ToString
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "DELETE FROM tblBrand WHERE ID=" & Val(txtBrandId.Text)
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Deleted Successfully!", vbInformation)
                    txtBrandId.Clear()
                    txtBrandName.Clear()
                    sql = "SELECT * FROM tblBrand"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvBrandData.DataSource = DT
                Else
                    MsgBox("Unable To Delete Data!", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "UPDATE tblBrand SET BrandName='" & txtBrandName.Text & "' WHERE ID=" & Val(txtBrandId.Text)
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Updated Successfully!", vbInformation)
                    txtBrandId.Clear()
                    txtBrandName.Clear()
                    sql = "SELECT * FROM tblBrand"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvBrandData.DataSource = DT
                Else
                    MsgBox("Unable To Update Data!", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMainMenu.Show()
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