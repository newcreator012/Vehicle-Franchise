Public Class UserControl11
    Private Sub UserControl11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        Dim query As String = "SELECT * FROM regulatoryauthority"
        Dim rowCount As Integer = modDB.LoadToDGV(query, DataGridView1)

        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.Name = "delete_button"
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Text = "Delete"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(deleteButtonColumn)

        Dim editButtonColumn As New DataGridViewButtonColumn()
        editButtonColumn.Name = "edit_button"
        editButtonColumn.HeaderText = "Edit"
        editButtonColumn.Text = "Edit"
        editButtonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(editButtonColumn)

        ' Set column headers to more user-friendly names
        DataGridView1.Columns("authority_id").HeaderText = "Authority ID"
        DataGridView1.Columns("first_name").HeaderText = "First Name"
        DataGridView1.Columns("middle_name").HeaderText = "Middle Name"
        DataGridView1.Columns("last_name").HeaderText = "Last Name"
        DataGridView1.Columns("phone_number").HeaderText = "Phone Number"
        DataGridView1.Columns("gender").HeaderText = "Gender"
        DataGridView1.Columns("date_of_birth").HeaderText = "Date of Birth"
        DataGridView1.Columns("barangay").HeaderText = "Barangay"
        DataGridView1.Columns("municipality").HeaderText = "Municipality"
        DataGridView1.Columns("city_province").HeaderText = "City/Province"
        DataGridView1.Columns("email_address").HeaderText = "Email Address"
        DataGridView1.Columns("hire_date").HeaderText = "Hire Date"
        DataGridView1.Columns("job_position").HeaderText = "Job Position"
        DataGridView1.Columns("department").HeaderText = "Department"
        DataGridView1.Columns("status").HeaderText = "Status"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is a delete button
        If e.ColumnIndex = DataGridView1.Columns("delete_button").Index AndAlso e.RowIndex >= 0 Then
            ' Get the authority_id of the row to be deleted
            Dim authority_id As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("authority_id").Value)

            ' Delete the row from the database
            Dim query As String = "DELETE FROM regulatoryauthority WHERE authority_id = " & authority_id
            modDB.readQuery(query)

            ' Remove the row from the DataGridView
            DataGridView1.Rows.RemoveAt(e.RowIndex)

            MsgBox("Row deleted.", MsgBoxStyle.Information)
        End If

        ' Check if the clicked cell is an edit button
        If e.ColumnIndex = DataGridView1.Columns("edit_button").Index AndAlso e.RowIndex >= 0 Then
            ' Get the data from the selected row
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim authority_id As Integer = Convert.ToInt32(row.Cells("authority_id").Value)
            Dim first_name As String = row.Cells("first_name").Value.ToString()
            Dim middle_name As String = row.Cells("middle_name").Value.ToString()
            Dim last_name As String = row.Cells("last_name").Value.ToString()
            Dim phone_number As String = row.Cells("phone_number").Value.ToString()
            Dim gender As String = row.Cells("gender").Value.ToString()
            Dim date_of_birth As Date = Convert.ToDateTime(row.Cells("date_of_birth").Value)
            Dim barangay As String = row.Cells("barangay").Value.ToString()
            Dim municipality As String = row.Cells("municipality").Value.ToString()
            Dim city_province As String = row.Cells("city_province").Value.ToString()
            Dim email_address As String = row.Cells("email_address").Value.ToString()
            Dim hire_date As Date = Convert.ToDateTime(row.Cells("hire_date").Value)
            Dim job_position As String = row.Cells("job_position").Value.ToString()
            Dim department As String = row.Cells("department").Value.ToString()
            Dim status As String = row.Cells("status").Value.ToString()

            ' Code to handle the edit functionality goes here
        End If
    End Sub
End Class
