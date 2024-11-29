<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1franchisee
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
        tbfranchiseeid = New TextBox()
        Label1 = New Label()
        tbfirstname = New TextBox()
        tbmidname = New TextBox()
        tblastname = New TextBox()
        tbphonenum = New TextBox()
        tbgender = New TextBox()
        tbbirthdate = New TextBox()
        tbbrgy = New TextBox()
        tbmunicipality = New TextBox()
        tbcity = New TextBox()
        tbzipcode = New TextBox()
        tbowner_id = New TextBox()
        Label2 = New Label()
        BtnAdd = New Button()
        SuspendLayout()
        ' 
        ' tbfranchiseeid
        ' 
        tbfranchiseeid.Anchor = AnchorStyles.None
        tbfranchiseeid.Location = New Point(171, 56)
        tbfranchiseeid.Name = "tbfranchiseeid"
        tbfranchiseeid.PlaceholderText = "Franchisee ID"
        tbfranchiseeid.ReadOnly = True
        tbfranchiseeid.Size = New Size(306, 27)
        tbfranchiseeid.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(171, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 20)
        Label1.TabIndex = 1
        Label1.Text = "FRANCHISEE PERSONAL INFORMATION"
        ' 
        ' tbfirstname
        ' 
        tbfirstname.Anchor = AnchorStyles.None
        tbfirstname.Location = New Point(171, 89)
        tbfirstname.Name = "tbfirstname"
        tbfirstname.PlaceholderText = "First Name"
        tbfirstname.ReadOnly = True
        tbfirstname.Size = New Size(306, 27)
        tbfirstname.TabIndex = 2
        ' 
        ' tbmidname
        ' 
        tbmidname.Anchor = AnchorStyles.None
        tbmidname.Location = New Point(171, 122)
        tbmidname.Name = "tbmidname"
        tbmidname.PlaceholderText = "Middle Name (Optional)"
        tbmidname.ReadOnly = True
        tbmidname.Size = New Size(306, 27)
        tbmidname.TabIndex = 3
        ' 
        ' tblastname
        ' 
        tblastname.Anchor = AnchorStyles.None
        tblastname.Location = New Point(171, 155)
        tblastname.Name = "tblastname"
        tblastname.PlaceholderText = "Last Name"
        tblastname.ReadOnly = True
        tblastname.Size = New Size(306, 27)
        tblastname.TabIndex = 4
        ' 
        ' tbphonenum
        ' 
        tbphonenum.Anchor = AnchorStyles.None
        tbphonenum.Location = New Point(171, 184)
        tbphonenum.Name = "tbphonenum"
        tbphonenum.PlaceholderText = "Phone Number"
        tbphonenum.ReadOnly = True
        tbphonenum.Size = New Size(306, 27)
        tbphonenum.TabIndex = 5
        ' 
        ' tbgender
        ' 
        tbgender.Anchor = AnchorStyles.None
        tbgender.Location = New Point(171, 217)
        tbgender.Name = "tbgender"
        tbgender.PlaceholderText = "Gender"
        tbgender.ReadOnly = True
        tbgender.Size = New Size(306, 27)
        tbgender.TabIndex = 6
        ' 
        ' tbbirthdate
        ' 
        tbbirthdate.Anchor = AnchorStyles.None
        tbbirthdate.Location = New Point(171, 250)
        tbbirthdate.Name = "tbbirthdate"
        tbbirthdate.PlaceholderText = "Birth Date (MM/DD/YY)"
        tbbirthdate.ReadOnly = True
        tbbirthdate.Size = New Size(306, 27)
        tbbirthdate.TabIndex = 7
        ' 
        ' tbbrgy
        ' 
        tbbrgy.Anchor = AnchorStyles.None
        tbbrgy.Location = New Point(171, 303)
        tbbrgy.Name = "tbbrgy"
        tbbrgy.PlaceholderText = "Baranggay"
        tbbrgy.ReadOnly = True
        tbbrgy.Size = New Size(306, 27)
        tbbrgy.TabIndex = 8
        ' 
        ' tbmunicipality
        ' 
        tbmunicipality.Anchor = AnchorStyles.None
        tbmunicipality.Location = New Point(171, 336)
        tbmunicipality.Name = "tbmunicipality"
        tbmunicipality.PlaceholderText = "Municipality"
        tbmunicipality.ReadOnly = True
        tbmunicipality.Size = New Size(306, 27)
        tbmunicipality.TabIndex = 9
        ' 
        ' tbcity
        ' 
        tbcity.Anchor = AnchorStyles.None
        tbcity.Location = New Point(171, 369)
        tbcity.Name = "tbcity"
        tbcity.PlaceholderText = "City/Province"
        tbcity.ReadOnly = True
        tbcity.Size = New Size(306, 27)
        tbcity.TabIndex = 10
        ' 
        ' tbzipcode
        ' 
        tbzipcode.Anchor = AnchorStyles.None
        tbzipcode.Location = New Point(171, 402)
        tbzipcode.Name = "tbzipcode"
        tbzipcode.PlaceholderText = "Zip Code"
        tbzipcode.ReadOnly = True
        tbzipcode.Size = New Size(306, 27)
        tbzipcode.TabIndex = 11
        ' 
        ' tbowner_id
        ' 
        tbowner_id.Anchor = AnchorStyles.None
        tbowner_id.Location = New Point(171, 435)
        tbowner_id.Name = "tbowner_id"
        tbowner_id.PlaceholderText = "Owner ID"
        tbowner_id.ReadOnly = True
        tbowner_id.Size = New Size(306, 27)
        tbowner_id.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(171, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 16
        Label2.Text = "ADDRESS"
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
        BtnAdd.Location = New Point(514, 496)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(143, 38)
        BtnAdd.TabIndex = 29
        BtnAdd.Text = "Save"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' Form1franchisee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Transparent
        Controls.Add(BtnAdd)
        Controls.Add(Label2)
        Controls.Add(tbowner_id)
        Controls.Add(tbzipcode)
        Controls.Add(tbcity)
        Controls.Add(tbmunicipality)
        Controls.Add(tbbrgy)
        Controls.Add(tbbirthdate)
        Controls.Add(tbgender)
        Controls.Add(tbphonenum)
        Controls.Add(tblastname)
        Controls.Add(tbmidname)
        Controls.Add(tbfirstname)
        Controls.Add(Label1)
        Controls.Add(tbfranchiseeid)
        DoubleBuffered = True
        Name = "Form1franchisee"
        Size = New Size(682, 555)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbfranchiseeid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbfirstname As TextBox
    Friend WithEvents tbmidname As TextBox
    Friend WithEvents tblastname As TextBox
    Friend WithEvents tbphonenum As TextBox
    Friend WithEvents tbgender As TextBox
    Friend WithEvents tbbirthdate As TextBox
    Friend WithEvents tbbrgy As TextBox
    Friend WithEvents tbmunicipality As TextBox
    Friend WithEvents tbcity As TextBox
    Friend WithEvents tbzipcode As TextBox
    Friend WithEvents tbowner_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdd As Button

End Class
