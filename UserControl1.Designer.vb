<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2franchise
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        tb_franchise_duration = New TextBox()
        tb_license_number = New TextBox()
        tb_route = New TextBox()
        tbstatus = New TextBox()
        tbdate_issued = New TextBox()
        tb_expiration = New TextBox()
        tbtotal_violations = New TextBox()
        tblast_renewal_date = New TextBox()
        tbfee_paid = New TextBox()
        tb_area = New TextBox()
        tb_association = New TextBox()
        Label3 = New Label()
        tbvehicle_id = New TextBox()
        tbfranchise_type = New TextBox()
        tbfranchise_id = New TextBox()
        BtnAdd = New Button()
        SuspendLayout()
        ' 
        ' tb_franchise_duration
        ' 
        tb_franchise_duration.Anchor = AnchorStyles.None
        tb_franchise_duration.Location = New Point(188, 490)
        tb_franchise_duration.Name = "tb_franchise_duration"
        tb_franchise_duration.PlaceholderText = "Franchise Duration"
        tb_franchise_duration.ReadOnly = True
        tb_franchise_duration.Size = New Size(306, 27)
        tb_franchise_duration.TabIndex = 43
        ' 
        ' tb_license_number
        ' 
        tb_license_number.Anchor = AnchorStyles.None
        tb_license_number.Location = New Point(188, 457)
        tb_license_number.Name = "tb_license_number"
        tb_license_number.PlaceholderText = "License Number"
        tb_license_number.ReadOnly = True
        tb_license_number.Size = New Size(306, 27)
        tb_license_number.TabIndex = 42
        ' 
        ' tb_route
        ' 
        tb_route.Anchor = AnchorStyles.None
        tb_route.Location = New Point(188, 424)
        tb_route.Name = "tb_route"
        tb_route.PlaceholderText = "Route"
        tb_route.ReadOnly = True
        tb_route.Size = New Size(306, 27)
        tb_route.TabIndex = 41
        ' 
        ' tbstatus
        ' 
        tbstatus.Anchor = AnchorStyles.None
        tbstatus.Location = New Point(188, 159)
        tbstatus.Name = "tbstatus"
        tbstatus.PlaceholderText = "Status"
        tbstatus.ReadOnly = True
        tbstatus.Size = New Size(306, 27)
        tbstatus.TabIndex = 40
        ' 
        ' tbdate_issued
        ' 
        tbdate_issued.Anchor = AnchorStyles.None
        tbdate_issued.Location = New Point(188, 192)
        tbdate_issued.Name = "tbdate_issued"
        tbdate_issued.PlaceholderText = "Date Issued"
        tbdate_issued.ReadOnly = True
        tbdate_issued.Size = New Size(306, 27)
        tbdate_issued.TabIndex = 39
        ' 
        ' tb_expiration
        ' 
        tb_expiration.Anchor = AnchorStyles.None
        tb_expiration.Location = New Point(188, 225)
        tb_expiration.Name = "tb_expiration"
        tb_expiration.PlaceholderText = "Date of Expiration"
        tb_expiration.ReadOnly = True
        tb_expiration.Size = New Size(306, 27)
        tb_expiration.TabIndex = 38
        ' 
        ' tbtotal_violations
        ' 
        tbtotal_violations.Anchor = AnchorStyles.None
        tbtotal_violations.Location = New Point(188, 258)
        tbtotal_violations.Name = "tbtotal_violations"
        tbtotal_violations.PlaceholderText = "Total Violations"
        tbtotal_violations.ReadOnly = True
        tbtotal_violations.Size = New Size(306, 27)
        tbtotal_violations.TabIndex = 37
        ' 
        ' tblast_renewal_date
        ' 
        tblast_renewal_date.Anchor = AnchorStyles.None
        tblast_renewal_date.Location = New Point(188, 292)
        tblast_renewal_date.Name = "tblast_renewal_date"
        tblast_renewal_date.PlaceholderText = "Last Renewal Date"
        tblast_renewal_date.ReadOnly = True
        tblast_renewal_date.Size = New Size(306, 27)
        tblast_renewal_date.TabIndex = 36
        ' 
        ' tbfee_paid
        ' 
        tbfee_paid.Anchor = AnchorStyles.None
        tbfee_paid.Location = New Point(188, 325)
        tbfee_paid.Name = "tbfee_paid"
        tbfee_paid.PlaceholderText = "Fee Paid"
        tbfee_paid.ReadOnly = True
        tbfee_paid.Size = New Size(306, 27)
        tbfee_paid.TabIndex = 35
        ' 
        ' tb_area
        ' 
        tb_area.Anchor = AnchorStyles.None
        tb_area.Location = New Point(188, 358)
        tb_area.Name = "tb_area"
        tb_area.PlaceholderText = "Area"
        tb_area.ReadOnly = True
        tb_area.Size = New Size(306, 27)
        tb_area.TabIndex = 34
        ' 
        ' tb_association
        ' 
        tb_association.Anchor = AnchorStyles.None
        tb_association.Location = New Point(188, 391)
        tb_association.Name = "tb_association"
        tb_association.PlaceholderText = "Association"
        tb_association.ReadOnly = True
        tb_association.Size = New Size(306, 27)
        tb_association.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(188, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 20)
        Label3.TabIndex = 32
        Label3.Text = "FRANCHISE INFORMATION"
        ' 
        ' tbvehicle_id
        ' 
        tbvehicle_id.Anchor = AnchorStyles.None
        tbvehicle_id.Location = New Point(188, 126)
        tbvehicle_id.Name = "tbvehicle_id"
        tbvehicle_id.PlaceholderText = "Vehicle ID"
        tbvehicle_id.ReadOnly = True
        tbvehicle_id.Size = New Size(306, 27)
        tbvehicle_id.TabIndex = 31
        ' 
        ' tbfranchise_type
        ' 
        tbfranchise_type.Anchor = AnchorStyles.None
        tbfranchise_type.Location = New Point(188, 93)
        tbfranchise_type.Name = "tbfranchise_type"
        tbfranchise_type.PlaceholderText = "Franchise Type"
        tbfranchise_type.ReadOnly = True
        tbfranchise_type.Size = New Size(306, 27)
        tbfranchise_type.TabIndex = 30
        ' 
        ' tbfranchise_id
        ' 
        tbfranchise_id.Anchor = AnchorStyles.None
        tbfranchise_id.Location = New Point(188, 60)
        tbfranchise_id.Name = "tbfranchise_id"
        tbfranchise_id.PlaceholderText = "Franchise Id No."
        tbfranchise_id.ReadOnly = True
        tbfranchise_id.Size = New Size(306, 27)
        tbfranchise_id.TabIndex = 29
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Anchor = AnchorStyles.None
        BtnAdd.BackColor = Color.CornflowerBlue
        BtnAdd.FlatAppearance.BorderSize = 0
        BtnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        BtnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        BtnAdd.FlatStyle = FlatStyle.Flat
        BtnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAdd.ForeColor = Color.White
        BtnAdd.Location = New Point(515, 502)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(143, 38)
        BtnAdd.TabIndex = 44
        BtnAdd.Text = "Save"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' Form2franchise
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(BtnAdd)
        Controls.Add(tb_franchise_duration)
        Controls.Add(tb_license_number)
        Controls.Add(tb_route)
        Controls.Add(tbstatus)
        Controls.Add(tbdate_issued)
        Controls.Add(tb_expiration)
        Controls.Add(tbtotal_violations)
        Controls.Add(tblast_renewal_date)
        Controls.Add(tbfee_paid)
        Controls.Add(tb_area)
        Controls.Add(tb_association)
        Controls.Add(Label3)
        Controls.Add(tbvehicle_id)
        Controls.Add(tbfranchise_type)
        Controls.Add(tbfranchise_id)
        Name = "Form2franchise"
        Size = New Size(682, 555)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tb_franchise_duration As TextBox
    Friend WithEvents tb_license_number As TextBox
    Friend WithEvents tb_route As TextBox
    Friend WithEvents tbstatus As TextBox
    Friend WithEvents tbdate_issued As TextBox
    Friend WithEvents tb_expiration As TextBox
    Friend WithEvents tbtotal_violations As TextBox
    Friend WithEvents tblast_renewal_date As TextBox
    Friend WithEvents tbfee_paid As TextBox
    Friend WithEvents tb_area As TextBox
    Friend WithEvents tb_association As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbvehicle_id As TextBox
    Friend WithEvents tbfranchise_type As TextBox
    Friend WithEvents tbfranchise_id As TextBox
    Friend WithEvents BtnAdd As Button

End Class
