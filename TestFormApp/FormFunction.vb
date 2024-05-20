Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports TestFormApp.Form1

Public Class FormFunction

    Public Shared Function addProducts(prod_id, prod_name, prod_design, prod_color, prod_warranty, prod_launch)

        connection.Open()
        Dim command As New SqlCommand("Insert into tbl_Products values ('" & prod_id & "', '" & prod_name & "', '" & prod_design & "', '" & prod_color & "', '" & prod_warranty & "', '" & prod_launch & "')", connection)
        command.ExecuteNonQuery()
        connection.Close()

    End Function

    Public Shared Function deleteProduct(prod_id)

        connection.Open()
        Dim command As New SqlCommand("Delete tbl_Products where Product_ID = '" & prod_id & "'", connection)
        command.ExecuteNonQuery()
        connection.Close()

    End Function

    Public Shared Function updateProduct(prod_id, prod_name, prod_design, prod_color, prod_warranty, prod_launch)

        connection.Open()
        Dim command As New SqlCommand("Update tbl_Products set Product_Name = '" & prod_name & "', Product_Design = '" & prod_design & "', Product_Color = '" & prod_color & "', Product_Warranty = '" & prod_warranty & "', CreatedAt = '" & prod_launch & "' where Product_ID = '" & prod_id & "'", connection)
        command.ExecuteNonQuery()
        connection.Close()

    End Function

End Class
