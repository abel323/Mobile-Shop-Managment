Module Connection
    Dim conn As New SqlClient.SqlConnection("Data source=LAPTOP-EJB0JPBB; Initial catalog=MobileShop; Integrated security=True")
    Function connect() As SqlClient.SqlConnection
        Return conn
    End Function
End Module
