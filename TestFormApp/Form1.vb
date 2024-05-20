Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports TestFormApp.FormFunction
Imports System.Globalization

Public Class Form1

    Public Shared connection As New SqlConnection("Data Source=LAPTOP-BI86SNOA\SQLARKRAY;Initial Catalog=TestMvcDB;Integrated Security=True")

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim prod_id As Integer = txtb_product_id.Text
        Dim prod_name As String = txtb_product_name.Text
        Dim prod_design As String = txtb_product_design.Text
        Dim prod_color As String = cmb_product_color.SelectedItem
        Dim prod_warranty As String = ""

        Dim prod_launch As DateTime = dtp_product_launch.Text
        Dim formattedDate As String = prod_launch.ToString("yyyy-MM-dd HH:mm:ss.fff")

        If rb_allowed.Checked = True Then
            prod_warranty = "Allowed"
        ElseIf rb_notallowed.Checked = True Then
            prod_warranty = "Not Allowed"
        End If

        addProducts(prod_id, prod_name, prod_design, prod_color, prod_warranty, formattedDate)

        LoadDataInView()
        MessageBox.Show("Successfully Added Product")

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim prod_id As Integer = txtb_product_id.Text
        Dim prod_name As String = txtb_product_name.Text
        Dim prod_design As String = txtb_product_design.Text
        Dim prod_color As String = cmb_product_color.SelectedItem
        Dim prod_warranty As String = ""

        Dim prod_launch As DateTime = dtp_product_launch.Text
        Dim formattedDate As String = prod_launch.ToString("yyyy-MM-dd HH:mm:ss.fff")

        If rb_allowed.Checked = True Then
            prod_warranty = "Allowed"
        ElseIf rb_notallowed.Checked = True Then
            prod_warranty = "Not Allowed"
        End If

        updateProduct(prod_id, prod_name, prod_design, prod_color, prod_warranty, formattedDate)

        LoadDataInView()
        MessageBox.Show("Successfully Updated the Product")

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If MessageBox.Show("Are you sure you want to delete this item?", "Delete Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim prod_id As Integer = txtb_product_id.Text
            deleteProduct(prod_id)
            LoadDataInView()
            MessageBox.Show("Successfully deleted product")

        End If

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        Dim search_Name As String = txtb_search.Text

        Dim command As New SqlCommand("Select * from tbl_Products where Product_Name = '" & search_Name & "'", connection)
        Dim SDA As New SqlDataAdapter(command)
        Dim dt As New DataTable
        SDA.Fill(dt)

        dgv_data.DataSource = dt

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LoadDataInView()
    End Sub

    Private Sub LoadDataInView()

        Dim command As New SqlCommand("Select * from tbl_Products", connection)
        Dim SDA As New SqlDataAdapter(command)
        Dim dt As New DataTable
        SDA.Fill(dt)

        dgv_data.DataSource = dt

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataInView()
    End Sub

End Class
