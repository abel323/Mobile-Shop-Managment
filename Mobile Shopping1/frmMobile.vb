Public Class frmMobile
    Dim cmd As New SqlClient.SqlCommand
    Dim sql As String
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMainMenu.Show()
        Me.Dispose()
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        frmBrand.Show()
        Me.Dispose()
    End Sub

    Private Sub Brand()
        Dim DR As SqlClient.SqlDataReader
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM tblBrand"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    cboBrand.Items.Add(DR.GetValue(1).ToString)
                End While
                DR.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub frmMobile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Brand()
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT * FROM MobileView"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DT)
                dgvMobileData.DataSource = DT
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
        Dim DR As SqlClient.SqlDataReader
        Dim Brand_ID As Integer
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT ID FROM tblBrand WHERE BrandName='" & cboBrand.Text & "'"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    Brand_ID = Val(DR.GetValue(0).ToString)
                End While
                DR.Close()
                sql = "INSERT INTO tblMobile(Mobile_Name,Brand,Production_Year,Quanitiy_In_Stock,Unit_Price) VALUES('" &
                    txtMobileName.Text & "'," & Brand_ID & ",'" & txtProductionYear.Text & "'," & Val(txtQuanitiy.Text) & "," & Val(txtPrice.Text) & ")"
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Added Successfully!", vbInformation)
                    txtMobileName.Clear()
                    txtPrice.Clear()
                    txtProductionYear.ResetText()
                    txtQuanitiy.Clear()
                    cboBrand.ResetText()
                    sql = "SELECT * FROM MobileView"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvMobileData.DataSource = DT
                Else
                    MsgBox("Unable To Add Data!", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical)
        Finally
            connect().Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "DELETE FROM tblMobile WHERE ID=" & Val(txtID.Text)
                cmd.Connection = connect()
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Deleted Successfully!", vbInformation)
                    txtMobileName.Clear()
                    txtPrice.Clear()
                    txtProductionYear.ResetText()
                    txtQuanitiy.Clear()
                    cboBrand.ResetText()
                    sql = "SELECT * FROM MobileView"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvMobileData.DataSource = DT
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


    Private Sub dgvMobileData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMobileData.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMobileData.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value.ToString
            txtMobileName.Text = row.Cells(1).Value.ToString
            cboBrand.Text = row.Cells(2).Value.ToString
            txtProductionYear.Text = row.Cells(3).Value.ToString
            txtQuanitiy.Text = row.Cells(4).Value.ToString
            txtPrice.Text = row.Cells(5).Value.ToString
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Dispose()
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSale.Show()
        Me.Dispose()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DT As New DataTable
        Dim DR As SqlClient.SqlDataReader
        Dim Brand_ID As Integer
        Try
            connect().Open()
            If connect().State = ConnectionState.Open Then
                sql = "SELECT ID FROM tblBrand WHERE BrandName='" & cboBrand.Text & "'"
                cmd.Connection = connect()
                cmd.CommandText = sql
                DR = cmd.ExecuteReader
                While DR.Read()
                    Brand_ID = Val(DR.GetValue(0).ToString)
                End While
                DR.Close()
                sql = "UPDATE tblMobile SET Mobile_Name='" & txtMobileName.Text & "', Brand=" & Brand_ID & ", Production_Year='" & txtProductionYear.Text &
                    "', Quanitiy_In_Stock=" & Val(txtQuanitiy.Text) & ", Unit_Price=" & Val(txtPrice.Text) & " WHERE ID=" & Val(txtID.Text)
                cmd.CommandText = sql
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data Updated Successfully!", vbInformation)
                    txtMobileName.Clear()
                    txtPrice.Clear()
                    txtProductionYear.ResetText()
                    txtQuanitiy.Clear()
                    cboBrand.ResetText()
                    sql = "SELECT * FROM MobileView"
                    cmd.CommandText = sql
                    DA.SelectCommand = cmd
                    DA.Fill(DT)
                    dgvMobileData.DataSource = DT
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
End Class