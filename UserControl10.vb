Public Class UserControl10

    Private Sub UserControl10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        Dim query As String = "SELECT * from franchisee"
        Dim rowCount As Integer = modDB.LoadToDGV(query, DataGridView2)

        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.Name = "delete_button"
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Text = "Delete"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        DataGridView2.Columns.Add(deleteButtonColumn)

        Dim editButtonColumn As New DataGridViewButtonColumn()
        editButtonColumn.Name = "edit_button"
        editButtonColumn.HeaderText = "Edit"
        editButtonColumn.Text = "Edit"
        editButtonColumn.UseColumnTextForButtonValue = True
        DataGridView2.Columns.Add(editButtonColumn)


        ' Set column headers to more user-friendly names
        DataGridView2.Columns("franchisee_id").HeaderText = "Franchisee ID"
        DataGridView2.Columns("first_name").HeaderText = "First Name"
        DataGridView2.Columns("middle_name").HeaderText = "Middle Name"
        DataGridView2.Columns("last_name").HeaderText = "Last Name"
        DataGridView2.Columns("phone_number").HeaderText = "Phone Number"
        DataGridView2.Columns("gender").HeaderText = "Gender"
        DataGridView2.Columns("date_of_birth").HeaderText = "Date of Birth"
        DataGridView2.Columns("barangay").HeaderText = "Barangay"
        DataGridView2.Columns("municipality").HeaderText = "Municipality"
        DataGridView2.Columns("city_province").HeaderText = "City/Province"
        DataGridView2.Columns("zip_code").HeaderText = "ZIP Code"
        DataGridView2.Columns("owner_id").HeaderText = "Owner ID"
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        ' Check if the clicked cell is a delete button
        If e.ColumnIndex = DataGridView2.Columns("delete_button").Index AndAlso e.RowIndex >= 0 Then
            ' Get the franchisee_id of the row to be deleted
            Dim franchisee_id As Integer = Convert.ToInt32(DataGridView2.Rows(e.RowIndex).Cells("franchisee_id").Value)

            ' Delete the row from the database
            Dim query As String = "DELETE FROM franchisee WHERE franchisee_id = " & franchisee_id
            modDB.readQuery(query)

            ' Remove the row from the DataGridView
            DataGridView2.Rows.RemoveAt(e.RowIndex)

            MsgBox("Row deleted.", MsgBoxStyle.Information)
        End If

        ' Check if the clicked cell is an edit button
        If e.ColumnIndex = DataGridView2.Columns("edit_button").Index AndAlso e.RowIndex >= 0 Then


            ' Get the data from the selected row
            Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            Dim franchisee_id As Integer = Convert.ToInt32(row.Cells("franchisee_id").Value)
            Dim first_name As String = row.Cells("first_name").Value.ToString()
            Dim middle_name As String = row.Cells("middle_name").Value.ToString()
            Dim last_name As String = row.Cells("last_name").Value.ToString()
            Dim phone_number As String = row.Cells("phone_number").Value.ToString()
            Dim gender As String = row.Cells("gender").Value.ToString()
            Dim date_of_birth As Date = Convert.ToDateTime(row.Cells("date_of_birth").Value)
            Dim barangay As String = row.Cells("barangay").Value.ToString()
            Dim municipality As String = row.Cells("municipality").Value.ToString()
            Dim city_province As String = row.Cells("city_province").Value.ToString()
            Dim zip_code As String = row.Cells("zip_code").Value.ToString()
            Dim owner_id As Integer = Convert.ToInt32(row.Cells("owner_id").Value)
        End If


    End Sub
End Class
