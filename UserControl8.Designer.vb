<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3vehicle
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
        tbcolor = New TextBox()
        tbyear_of_manufacture = New TextBox()
        tbfranchise_id = New TextBox()
        tb_net_weight = New TextBox()
        tbmileage = New TextBox()
        tb_engine_num = New TextBox()
        tb_purchase_date = New TextBox()
        tbtransmission_type = New TextBox()
        tb_official_receipt = New TextBox()
        tb_chassis_num = New TextBox()
        tbfuel_type = New TextBox()
        tbmodel = New TextBox()
        tbplate_number = New TextBox()
        tb_vehicle_id = New TextBox()
        BtnAdd = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' tbcolor
        ' 
        tbcolor.Anchor = AnchorStyles.None
        tbcolor.Location = New Point(41, 243)
        tbcolor.Name = "tbcolor"
        tbcolor.PlaceholderText = "Color"
        tbcolor.Size = New Size(278, 27)
        tbcolor.TabIndex = 30
        ' 
        ' tbyear_of_manufacture
        ' 
        tbyear_of_manufacture.Anchor = AnchorStyles.None
        tbyear_of_manufacture.Location = New Point(41, 276)
        tbyear_of_manufacture.Name = "tbyear_of_manufacture"
        tbyear_of_manufacture.PlaceholderText = "Year Manufactured"
        tbyear_of_manufacture.Size = New Size(278, 27)
        tbyear_of_manufacture.TabIndex = 29
        ' 
        ' tbfranchise_id
        ' 
        tbfranchise_id.Anchor = AnchorStyles.None
        tbfranchise_id.Location = New Point(41, 309)
        tbfranchise_id.Name = "tbfranchise_id"
        tbfranchise_id.PlaceholderText = "Franchise ID"
        tbfranchise_id.Size = New Size(278, 27)
        tbfranchise_id.TabIndex = 28
        ' 
        ' tb_net_weight
        ' 
        tb_net_weight.Anchor = AnchorStyles.None
        tb_net_weight.Location = New Point(357, 342)
        tb_net_weight.Name = "tb_net_weight"
        tb_net_weight.PlaceholderText = "Net Weight"
        tb_net_weight.Size = New Size(278, 27)
        tb_net_weight.TabIndex = 27
        ' 
        ' tbmileage
        ' 
        tbmileage.Anchor = AnchorStyles.None
        tbmileage.Location = New Point(357, 309)
        tbmileage.Name = "tbmileage"
        tbmileage.PlaceholderText = "Mileage"
        tbmileage.Size = New Size(278, 27)
        tbmileage.TabIndex = 26
        ' 
        ' tb_engine_num
        ' 
        tb_engine_num.Anchor = AnchorStyles.None
        tb_engine_num.Location = New Point(357, 210)
        tb_engine_num.Name = "tb_engine_num"
        tb_engine_num.PlaceholderText = "Engine Number"
        tb_engine_num.Size = New Size(278, 27)
        tb_engine_num.TabIndex = 25
        ' 
        ' tb_purchase_date
        ' 
        tb_purchase_date.Anchor = AnchorStyles.None
        tb_purchase_date.Location = New Point(357, 276)
        tb_purchase_date.Name = "tb_purchase_date"
        tb_purchase_date.PlaceholderText = "Purchase Date"
        tb_purchase_date.Size = New Size(278, 27)
        tb_purchase_date.TabIndex = 24
        ' 
        ' tbtransmission_type
        ' 
        tbtransmission_type.Anchor = AnchorStyles.None
        tbtransmission_type.Location = New Point(357, 144)
        tbtransmission_type.Name = "tbtransmission_type"
        tbtransmission_type.PlaceholderText = "Transmission Type"
        tbtransmission_type.Size = New Size(278, 27)
        tbtransmission_type.TabIndex = 23
        ' 
        ' tb_official_receipt
        ' 
        tb_official_receipt.Anchor = AnchorStyles.None
        tb_official_receipt.Location = New Point(357, 243)
        tb_official_receipt.Name = "tb_official_receipt"
        tb_official_receipt.PlaceholderText = "Official Receipt"
        tb_official_receipt.Size = New Size(278, 27)
        tb_official_receipt.TabIndex = 22
        ' 
        ' tb_chassis_num
        ' 
        tb_chassis_num.Anchor = AnchorStyles.None
        tb_chassis_num.Location = New Point(357, 177)
        tb_chassis_num.Name = "tb_chassis_num"
        tb_chassis_num.PlaceholderText = "Chassis Number"
        tb_chassis_num.Size = New Size(278, 27)
        tb_chassis_num.TabIndex = 21
        ' 
        ' tbfuel_type
        ' 
        tbfuel_type.Anchor = AnchorStyles.None
        tbfuel_type.Location = New Point(41, 342)
        tbfuel_type.Name = "tbfuel_type"
        tbfuel_type.PlaceholderText = "Fuel Type"
        tbfuel_type.Size = New Size(278, 27)
        tbfuel_type.TabIndex = 20
        ' 
        ' tbmodel
        ' 
        tbmodel.Anchor = AnchorStyles.None
        tbmodel.Location = New Point(41, 210)
        tbmodel.Name = "tbmodel"
        tbmodel.PlaceholderText = "Model"
        tbmodel.Size = New Size(278, 27)
        tbmodel.TabIndex = 19
        ' 
        ' tbplate_number
        ' 
        tbplate_number.Anchor = AnchorStyles.None
        tbplate_number.Location = New Point(41, 177)
        tbplate_number.Name = "tbplate_number"
        tbplate_number.PlaceholderText = "Plate Number"
        tbplate_number.Size = New Size(278, 27)
        tbplate_number.TabIndex = 18
        ' 
        ' tb_vehicle_id
        ' 
        tb_vehicle_id.Anchor = AnchorStyles.None
        tb_vehicle_id.Location = New Point(41, 144)
        tb_vehicle_id.Name = "tb_vehicle_id"
        tb_vehicle_id.PlaceholderText = "Vehicle ID"
        tb_vehicle_id.Size = New Size(278, 27)
        tb_vehicle_id.TabIndex = 17
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
        BtnAdd.TabIndex = 45
        BtnAdd.Text = "Save"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 20)
        Label1.TabIndex = 46
        Label1.Text = "VEHICLE INFORMATION"
        ' 
        ' Form3vehicle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Transparent
        Controls.Add(Label1)
        Controls.Add(BtnAdd)
        Controls.Add(tbcolor)
        Controls.Add(tbyear_of_manufacture)
        Controls.Add(tbfranchise_id)
        Controls.Add(tb_net_weight)
        Controls.Add(tbmileage)
        Controls.Add(tb_engine_num)
        Controls.Add(tb_purchase_date)
        Controls.Add(tbtransmission_type)
        Controls.Add(tb_official_receipt)
        Controls.Add(tb_chassis_num)
        Controls.Add(tbfuel_type)
        Controls.Add(tbmodel)
        Controls.Add(tbplate_number)
        Controls.Add(tb_vehicle_id)
        Name = "Form3vehicle"
        Size = New Size(686, 555)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbcolor As TextBox
    Friend WithEvents tbyear_of_manufacture As TextBox
    Friend WithEvents tbfranchise_id As TextBox
    Friend WithEvents tb_net_weight As TextBox
    Friend WithEvents tbmileage As TextBox
    Friend WithEvents tb_engine_num As TextBox
    Friend WithEvents tb_purchase_date As TextBox
    Friend WithEvents tbtransmission_type As TextBox
    Friend WithEvents tb_official_receipt As TextBox
    Friend WithEvents tb_chassis_num As TextBox
    Friend WithEvents tbfuel_type As TextBox
    Friend WithEvents tbmodel As TextBox
    Friend WithEvents tbplate_number As TextBox
    Friend WithEvents tb_vehicle_id As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label1 As Label

End Class
