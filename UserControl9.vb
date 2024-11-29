Public Class UserControl9

    Private Sub UserControl9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        Dim query As String = "SELECT * FROM franchise"
        Dim rowCount As Integer = modDB.LoadToDGV(query, DataGridView1) ' Use the module name to call the function

        ' Add delete button column
        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.Name = "delete_button"
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Text = "Delete"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(deleteButtonColumn)

        ' Add edit button column
        Dim editButtonColumn As New DataGridViewButtonColumn()
        editButtonColumn.Name = "edit_button"
        editButtonColumn.HeaderText = "Edit"
        editButtonColumn.Text = "Edit"
        editButtonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(editButtonColumn)

        ' Set column headers to more user-friendly names
        DataGridView1.Columns("franchise_id").HeaderText = "Franchise ID"
        DataGridView1.Columns("franchise_type").HeaderText = "Franchise Type"
        DataGridView1.Columns("franchisee_id").HeaderText = "Franchisee ID"
        DataGridView1.Columns("vehicle_id").HeaderText = "Vehicle ID"
        DataGridView1.Columns("status").HeaderText = "Status"
        DataGridView1.Columns("issue_date").HeaderText = "Issue Date"
        DataGridView1.Columns("expiration_date").HeaderText = "Expiration Date"
        DataGridView1.Columns("total_violations").HeaderText = "Total Violations"
        DataGridView1.Columns("last_renewal_date").HeaderText = "Last Renewal Date"
        DataGridView1.Columns("fee_paid").HeaderText = "Fee Paid"
        DataGridView1.Columns("area").HeaderText = "Area"
        DataGridView1.Columns("association").HeaderText = "Association"
        DataGridView1.Columns("route").HeaderText = "Route"
        DataGridView1.Columns("license_number").HeaderText = "License Number"
        DataGridView1.Columns("franchise_duration").HeaderText = "Franchise Duration"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is a delete button
        If e.ColumnIndex = DataGridView1.Columns("delete_button").Index AndAlso e.RowIndex >= 0 Then
            ' Get the franchise_id of the row to be deleted
            Dim franchise_id As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("franchise_id").Value)

            ' Delete the row from the database
            Dim query As String = "DELETE FROM franchise WHERE franchise_id = " & franchise_id
            modDB.readQuery(query)

            ' Remove the row from the DataGridView
            DataGridView1.Rows.RemoveAt(e.RowIndex)

            MsgBox("Row deleted.", MsgBoxStyle.Information)
        End If

        ' Check if the clicked cell is an edit button
        If e.ColumnIndex = DataGridView1.Columns("edit_button").Index AndAlso e.RowIndex >= 0 Then
            ' Get the franchise_id of the row to be edited
            Dim franchise_id As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("franchise_id").Value)

            ' Get the data from the selected row
            Dim franchise_type As String = DataGridView1.Rows(e.RowIndex).Cells("franchise_type").Value.ToString()
            Dim franchisee_id As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("franchisee_id").Value)
            Dim vehicle_id As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("vehicle_id").Value)
            Dim status As String = DataGridView1.Rows(e.RowIndex).Cells("status").Value.ToString()
            Dim issue_date As Date = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells("issue_date").Value)
            Dim expiration_date As Date = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells("expiration_date").Value)
            Dim total_violations As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("total_violations").Value)
            Dim last_renewal_date As Date = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells("last_renewal_date").Value)
            Dim fee_paid As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("fee_paid").Value)
            Dim area As String = DataGridView1.Rows(e.RowIndex).Cells("area").Value.ToString()
            Dim association As String = DataGridView1.Rows(e.RowIndex).Cells("association").Value.ToString()
            Dim route As String = DataGridView1.Rows(e.RowIndex).Cells("route").Value.ToString()
            Dim license_number As String = DataGridView1.Rows(e.RowIndex).Cells("license_number").Value.ToString()
            Dim franchise_duration As String = DataGridView1.Rows(e.RowIndex).Cells("franchise_duration").Value.ToString()

            ' Update the database with the new data
            Dim query As String = "UPDATE franchise SET franchise_type = '" & franchise_type & "', franchisee_id = " & franchisee_id & ", vehicle_id = " & vehicle_id & ", status = '" & status & "', issue_date = '" & issue_date.ToString("yyyy-MM-dd") & "', expiration_date = '" & expiration_date.ToString("yyyy-MM-dd") & "', total_violations = " & total_violations & ", last_renewal_date = '" & last_renewal_date.ToString("yyyy-MM-dd") & "', fee_paid = " & fee_paid & ", area = '" & area & "', association = '" & association & "', route = '" & route & "', license_number = '" & license_number & "', franchise_duration = '" & franchise_duration & "' WHERE franchise_id = " & franchise_id
            modDB.readQuery(query)

            MsgBox("Row updated.", MsgBoxStyle.Information)
        End If
    End Sub

End Class
