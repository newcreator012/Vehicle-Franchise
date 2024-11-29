<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5Renewal
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
        LabelRenewal = New Label()
        tbrenewal_id = New TextBox()
        tbfranchise_id = New TextBox()
        tbsubmission_date = New TextBox()
        tb_status = New TextBox()
        tb_processing_date = New TextBox()
        tb_approval_date = New TextBox()
        tbfranchisee_id = New TextBox()
        tb_fee_paid = New TextBox()
        tb_expiration_date = New TextBox()
        tb_renewal_type = New TextBox()
        tb_compliance_stat = New TextBox()
        tb_renewalfee = New TextBox()
        tb_penaltyfee = New TextBox()
        tb_authority_id = New TextBox()
        tb_renewal_num = New TextBox()
        BtnAdd = New Button()
        SuspendLayout()
        ' 
        ' LabelRenewal
        ' 
        LabelRenewal.Anchor = AnchorStyles.None
        LabelRenewal.AutoSize = True
        LabelRenewal.FlatStyle = FlatStyle.Flat
        LabelRenewal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRenewal.Location = New Point(222, 10)
        LabelRenewal.Name = "LabelRenewal"
        LabelRenewal.Size = New Size(253, 28)
        LabelRenewal.TabIndex = 0
        LabelRenewal.Text = "RENEWAL INFORMATION"
        ' 
        ' tbrenewal_id
        ' 
        tbrenewal_id.Anchor = AnchorStyles.None
        tbrenewal_id.Location = New Point(29, 53)
        tbrenewal_id.Name = "tbrenewal_id"
        tbrenewal_id.PlaceholderText = "Enter Renewal ID"
        tbrenewal_id.Size = New Size(248, 27)
        tbrenewal_id.TabIndex = 1
        ' 
        ' tbfranchise_id
        ' 
        tbfranchise_id.Anchor = AnchorStyles.None
        tbfranchise_id.Location = New Point(29, 86)
        tbfranchise_id.Name = "tbfranchise_id"
        tbfranchise_id.PlaceholderText = "Franchise ID"
        tbfranchise_id.Size = New Size(248, 27)
        tbfranchise_id.TabIndex = 2
        ' 
        ' tbsubmission_date
        ' 
        tbsubmission_date.Anchor = AnchorStyles.None
        tbsubmission_date.Location = New Point(29, 119)
        tbsubmission_date.Name = "tbsubmission_date"
        tbsubmission_date.PlaceholderText = "Submission Date"
        tbsubmission_date.Size = New Size(248, 27)
        tbsubmission_date.TabIndex = 3
        ' 
        ' tb_status
        ' 
        tb_status.Anchor = AnchorStyles.None
        tb_status.Location = New Point(29, 152)
        tb_status.Name = "tb_status"
        tb_status.PlaceholderText = "Status"
        tb_status.Size = New Size(248, 27)
        tb_status.TabIndex = 4
        ' 
        ' tb_processing_date
        ' 
        tb_processing_date.Anchor = AnchorStyles.None
        tb_processing_date.Location = New Point(29, 185)
        tb_processing_date.Name = "tb_processing_date"
        tb_processing_date.PlaceholderText = "Processing Date"
        tb_processing_date.Size = New Size(248, 27)
        tb_processing_date.TabIndex = 5
        ' 
        ' tb_approval_date
        ' 
        tb_approval_date.Anchor = AnchorStyles.None
        tb_approval_date.Location = New Point(29, 218)
        tb_approval_date.Name = "tb_approval_date"
        tb_approval_date.PlaceholderText = "Approval Date"
        tb_approval_date.Size = New Size(248, 27)
        tb_approval_date.TabIndex = 6
        ' 
        ' tbfranchisee_id
        ' 
        tbfranchisee_id.Anchor = AnchorStyles.None
        tbfranchisee_id.Location = New Point(29, 251)
        tbfranchisee_id.Name = "tbfranchisee_id"
        tbfranchisee_id.PlaceholderText = "Franchisee ID"
        tbfranchisee_id.Size = New Size(248, 27)
        tbfranchisee_id.TabIndex = 7
        ' 
        ' tb_fee_paid
        ' 
        tb_fee_paid.Anchor = AnchorStyles.None
        tb_fee_paid.Location = New Point(29, 284)
        tb_fee_paid.Name = "tb_fee_paid"
        tb_fee_paid.PlaceholderText = "Fee Paid"
        tb_fee_paid.Size = New Size(248, 27)
        tb_fee_paid.TabIndex = 8
        ' 
        ' tb_expiration_date
        ' 
        tb_expiration_date.Anchor = AnchorStyles.None
        tb_expiration_date.Location = New Point(29, 317)
        tb_expiration_date.Name = "tb_expiration_date"
        tb_expiration_date.PlaceholderText = "Expiration Date"
        tb_expiration_date.Size = New Size(248, 27)
        tb_expiration_date.TabIndex = 9
        ' 
        ' tb_renewal_type
        ' 
        tb_renewal_type.Anchor = AnchorStyles.None
        tb_renewal_type.Location = New Point(390, 53)
        tb_renewal_type.Name = "tb_renewal_type"
        tb_renewal_type.PlaceholderText = "Renewal Type"
        tb_renewal_type.Size = New Size(248, 27)
        tb_renewal_type.TabIndex = 10
        ' 
        ' tb_compliance_stat
        ' 
        tb_compliance_stat.Anchor = AnchorStyles.None
        tb_compliance_stat.Location = New Point(390, 86)
        tb_compliance_stat.Name = "tb_compliance_stat"
        tb_compliance_stat.PlaceholderText = "Compliance Status"
        tb_compliance_stat.Size = New Size(248, 27)
        tb_compliance_stat.TabIndex = 11
        ' 
        ' tb_renewalfee
        ' 
        tb_renewalfee.Anchor = AnchorStyles.None
        tb_renewalfee.Location = New Point(390, 119)
        tb_renewalfee.Name = "tb_renewalfee"
        tb_renewalfee.PlaceholderText = "Renewal Fee"
        tb_renewalfee.Size = New Size(248, 27)
        tb_renewalfee.TabIndex = 12
        ' 
        ' tb_penaltyfee
        ' 
        tb_penaltyfee.Anchor = AnchorStyles.None
        tb_penaltyfee.Location = New Point(390, 152)
        tb_penaltyfee.Name = "tb_penaltyfee"
        tb_penaltyfee.PlaceholderText = "Penalty Fee"
        tb_penaltyfee.Size = New Size(248, 27)
        tb_penaltyfee.TabIndex = 13
        ' 
        ' tb_authority_id
        ' 
        tb_authority_id.Anchor = AnchorStyles.None
        tb_authority_id.Location = New Point(390, 185)
        tb_authority_id.Name = "tb_authority_id"
        tb_authority_id.PlaceholderText = "Authority ID"
        tb_authority_id.Size = New Size(248, 27)
        tb_authority_id.TabIndex = 14
        ' 
        ' tb_renewal_num
        ' 
        tb_renewal_num.Anchor = AnchorStyles.None
        tb_renewal_num.Location = New Point(390, 218)
        tb_renewal_num.Name = "tb_renewal_num"
        tb_renewal_num.PlaceholderText = "Renewal Number"
        tb_renewal_num.Size = New Size(248, 27)
        tb_renewal_num.TabIndex = 15
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Anchor = AnchorStyles.None
        BtnAdd.BackColor = Color.DarkBlue
        BtnAdd.FlatAppearance.BorderSize = 0
        BtnAdd.FlatStyle = FlatStyle.Flat
        BtnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAdd.ForeColor = Color.White
        BtnAdd.Location = New Point(458, 267)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(100, 35)
        BtnAdd.TabIndex = 16
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' Form5Renewal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Transparent
        Controls.Add(BtnAdd)
        Controls.Add(tb_renewal_num)
        Controls.Add(tb_authority_id)
        Controls.Add(tb_penaltyfee)
        Controls.Add(tb_renewalfee)
        Controls.Add(tb_compliance_stat)
        Controls.Add(tb_renewal_type)
        Controls.Add(tb_expiration_date)
        Controls.Add(tb_fee_paid)
        Controls.Add(tbfranchisee_id)
        Controls.Add(tb_approval_date)
        Controls.Add(tb_processing_date)
        Controls.Add(tb_status)
        Controls.Add(tbsubmission_date)
        Controls.Add(tbfranchise_id)
        Controls.Add(tbrenewal_id)
        Controls.Add(LabelRenewal)
        Name = "Form5Renewal"
        Size = New Size(682, 534)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelRenewal As Label
    Friend WithEvents tbrenewal_id As TextBox
    Friend WithEvents tbfranchise_id As TextBox
    Friend WithEvents tbsubmission_date As TextBox
    Friend WithEvents tb_status As TextBox
    Friend WithEvents tb_processing_date As TextBox
    Friend WithEvents tb_approval_date As TextBox
    Friend WithEvents tbfranchisee_id As TextBox
    Friend WithEvents tb_fee_paid As TextBox
    Friend WithEvents tb_expiration_date As TextBox
    Friend WithEvents tb_renewal_type As TextBox
    Friend WithEvents tb_compliance_stat As TextBox
    Friend WithEvents tb_renewalfee As TextBox
    Friend WithEvents tb_penaltyfee As TextBox
    Friend WithEvents tb_authority_id As TextBox
    Friend WithEvents tb_renewal_num As TextBox
    Friend WithEvents BtnAdd As Button

End Class
