<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PanelDashboard = New Panel()
        ReportsSubpanel = New Panel()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        Button12 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        BtnLogout = New Button()
        BtnReports = New Button()
        Submenupanel = New Panel()
        Button17 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        ButtonMenu = New Button()
        BtnDashboard = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        IconDropDownButton1 = New FontAwesome.Sharp.IconDropDownButton()
        IconDropDownButton2 = New FontAwesome.Sharp.IconDropDownButton()
        Panel3 = New Panel()
        BtnFullScreen = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        PanelDashboard.SuspendLayout()
        ReportsSubpanel.SuspendLayout()
        Submenupanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.AutoScroll = True
        PanelDashboard.BackColor = Color.Firebrick
        PanelDashboard.Controls.Add(ReportsSubpanel)
        PanelDashboard.Controls.Add(BtnLogout)
        PanelDashboard.Controls.Add(BtnReports)
        PanelDashboard.Controls.Add(Submenupanel)
        PanelDashboard.Controls.Add(ButtonMenu)
        PanelDashboard.Controls.Add(BtnDashboard)
        PanelDashboard.Controls.Add(Panel1)
        PanelDashboard.Dock = DockStyle.Left
        PanelDashboard.Location = New Point(0, 0)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(282, 982)
        PanelDashboard.TabIndex = 0
        ' 
        ' ReportsSubpanel
        ' 
        ReportsSubpanel.AutoScroll = True
        ReportsSubpanel.BackColor = Color.Thistle
        ReportsSubpanel.Controls.Add(Button16)
        ReportsSubpanel.Controls.Add(Button15)
        ReportsSubpanel.Controls.Add(Button14)
        ReportsSubpanel.Controls.Add(Button13)
        ReportsSubpanel.Controls.Add(Button12)
        ReportsSubpanel.Controls.Add(Button7)
        ReportsSubpanel.Controls.Add(Button8)
        ReportsSubpanel.Controls.Add(Button9)
        ReportsSubpanel.Controls.Add(Button10)
        ReportsSubpanel.Controls.Add(Button11)
        ReportsSubpanel.Dock = DockStyle.Top
        ReportsSubpanel.Location = New Point(0, 573)
        ReportsSubpanel.Name = "ReportsSubpanel"
        ReportsSubpanel.Size = New Size(282, 316)
        ReportsSubpanel.TabIndex = 11
        ReportsSubpanel.Visible = False
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.RosyBrown
        Button16.Dock = DockStyle.Top
        Button16.FlatAppearance.BorderSize = 0
        Button16.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button16.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button16.FlatStyle = FlatStyle.Flat
        Button16.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.ForeColor = SystemColors.ButtonHighlight
        Button16.Location = New Point(0, 283)
        Button16.Name = "Button16"
        Button16.Padding = New Padding(35, 0, 0, 0)
        Button16.Size = New Size(282, 31)
        Button16.TabIndex = 9
        Button16.Text = "Franchise Tracking"
        Button16.TextAlign = ContentAlignment.MiddleLeft
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.RosyBrown
        Button15.Dock = DockStyle.Top
        Button15.FlatAppearance.BorderSize = 0
        Button15.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button15.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button15.FlatStyle = FlatStyle.Flat
        Button15.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button15.ForeColor = SystemColors.ButtonHighlight
        Button15.Location = New Point(0, 252)
        Button15.Name = "Button15"
        Button15.Padding = New Padding(35, 0, 0, 0)
        Button15.Size = New Size(282, 31)
        Button15.TabIndex = 8
        Button15.Text = "Incident Report"
        Button15.TextAlign = ContentAlignment.MiddleLeft
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.RosyBrown
        Button14.Dock = DockStyle.Top
        Button14.FlatAppearance.BorderSize = 0
        Button14.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button14.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button14.FlatStyle = FlatStyle.Flat
        Button14.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button14.ForeColor = SystemColors.ButtonHighlight
        Button14.Location = New Point(0, 221)
        Button14.Name = "Button14"
        Button14.Padding = New Padding(35, 0, 0, 0)
        Button14.Size = New Size(282, 31)
        Button14.TabIndex = 7
        Button14.Text = "Franchise Performance"
        Button14.TextAlign = ContentAlignment.MiddleLeft
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.RosyBrown
        Button13.Dock = DockStyle.Top
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button13.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = SystemColors.ButtonHighlight
        Button13.Location = New Point(0, 190)
        Button13.Name = "Button13"
        Button13.Padding = New Padding(35, 0, 0, 0)
        Button13.Size = New Size(282, 31)
        Button13.TabIndex = 6
        Button13.Text = "Franchise Revenue"
        Button13.TextAlign = ContentAlignment.MiddleLeft
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.RosyBrown
        Button12.Dock = DockStyle.Top
        Button12.FlatAppearance.BorderSize = 0
        Button12.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button12.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button12.FlatStyle = FlatStyle.Flat
        Button12.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.ButtonHighlight
        Button12.Location = New Point(0, 159)
        Button12.Name = "Button12"
        Button12.Padding = New Padding(35, 0, 0, 0)
        Button12.Size = New Size(282, 31)
        Button12.TabIndex = 5
        Button12.Text = "Identification Issuance"
        Button12.TextAlign = ContentAlignment.MiddleLeft
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.RosyBrown
        Button7.Dock = DockStyle.Top
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button7.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = SystemColors.ButtonHighlight
        Button7.Location = New Point(0, 128)
        Button7.Name = "Button7"
        Button7.Padding = New Padding(35, 0, 0, 0)
        Button7.Size = New Size(282, 31)
        Button7.TabIndex = 4
        Button7.Text = "Vehicle Ownership Report"
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.RosyBrown
        Button8.Dock = DockStyle.Top
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button8.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = SystemColors.ButtonHighlight
        Button8.Location = New Point(0, 99)
        Button8.Name = "Button8"
        Button8.Padding = New Padding(35, 0, 0, 0)
        Button8.Size = New Size(282, 29)
        Button8.TabIndex = 3
        Button8.Text = "Regulatory Compliance Report"
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.RosyBrown
        Button9.Dock = DockStyle.Top
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button9.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = SystemColors.ButtonHighlight
        Button9.Location = New Point(0, 70)
        Button9.Name = "Button9"
        Button9.Padding = New Padding(35, 0, 0, 0)
        Button9.Size = New Size(282, 29)
        Button9.TabIndex = 2
        Button9.Text = "Renewal Status Report"
        Button9.TextAlign = ContentAlignment.MiddleLeft
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.RosyBrown
        Button10.Dock = DockStyle.Top
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button10.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = SystemColors.ButtonHighlight
        Button10.Location = New Point(0, 41)
        Button10.Name = "Button10"
        Button10.Padding = New Padding(35, 0, 0, 0)
        Button10.Size = New Size(282, 29)
        Button10.TabIndex = 1
        Button10.Text = "Active Franchise Report"
        Button10.TextAlign = ContentAlignment.MiddleLeft
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.RosyBrown
        Button11.Dock = DockStyle.Top
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button11.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = SystemColors.ButtonHighlight
        Button11.Location = New Point(0, 0)
        Button11.Name = "Button11"
        Button11.Padding = New Padding(35, 0, 0, 0)
        Button11.Size = New Size(282, 41)
        Button11.TabIndex = 0
        Button11.Text = "New Franchisee Report"
        Button11.TextAlign = ContentAlignment.MiddleLeft
        Button11.UseVisualStyleBackColor = False
        ' 
        ' BtnLogout
        ' 
        BtnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnLogout.BackColor = Color.LightCoral
        BtnLogout.Dock = DockStyle.Bottom
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatAppearance.MouseDownBackColor = Color.DimGray
        BtnLogout.FlatAppearance.MouseOverBackColor = Color.DimGray
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogout.ForeColor = SystemColors.ButtonHighlight
        BtnLogout.Image = My.Resources.Resources.Log_Out__1_
        BtnLogout.ImageAlign = ContentAlignment.MiddleLeft
        BtnLogout.Location = New Point(0, 920)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Padding = New Padding(10, 0, 0, 0)
        BtnLogout.Size = New Size(282, 62)
        BtnLogout.TabIndex = 10
        BtnLogout.Text = "Log-out"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnReports
        ' 
        BtnReports.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnReports.BackColor = Color.LightCoral
        BtnReports.Dock = DockStyle.Top
        BtnReports.FlatAppearance.BorderSize = 0
        BtnReports.FlatAppearance.MouseDownBackColor = Color.DimGray
        BtnReports.FlatAppearance.MouseOverBackColor = Color.DimGray
        BtnReports.FlatStyle = FlatStyle.Flat
        BtnReports.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnReports.ForeColor = SystemColors.ButtonHighlight
        BtnReports.Image = My.Resources.Resources.Reports__1_
        BtnReports.ImageAlign = ContentAlignment.MiddleLeft
        BtnReports.Location = New Point(0, 499)
        BtnReports.Name = "BtnReports"
        BtnReports.Padding = New Padding(10, 0, 0, 0)
        BtnReports.Size = New Size(282, 74)
        BtnReports.TabIndex = 9
        BtnReports.Text = "Reports"
        BtnReports.UseVisualStyleBackColor = False
        ' 
        ' Submenupanel
        ' 
        Submenupanel.AutoScroll = True
        Submenupanel.BackColor = Color.Firebrick
        Submenupanel.Controls.Add(Button17)
        Submenupanel.Controls.Add(Button6)
        Submenupanel.Controls.Add(Button5)
        Submenupanel.Controls.Add(Button4)
        Submenupanel.Controls.Add(Button3)
        Submenupanel.Controls.Add(Button2)
        Submenupanel.Dock = DockStyle.Top
        Submenupanel.Location = New Point(0, 318)
        Submenupanel.Name = "Submenupanel"
        Submenupanel.Size = New Size(282, 181)
        Submenupanel.TabIndex = 8
        Submenupanel.Visible = False
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.RosyBrown
        Button17.Dock = DockStyle.Top
        Button17.FlatAppearance.BorderSize = 0
        Button17.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button17.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button17.FlatStyle = FlatStyle.Flat
        Button17.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button17.ForeColor = SystemColors.ButtonHighlight
        Button17.Location = New Point(0, 148)
        Button17.Name = "Button17"
        Button17.Padding = New Padding(35, 0, 0, 0)
        Button17.Size = New Size(282, 31)
        Button17.TabIndex = 5
        Button17.Text = "List of Franchisee"
        Button17.TextAlign = ContentAlignment.MiddleLeft
        Button17.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.RosyBrown
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button6.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ButtonHighlight
        Button6.Location = New Point(0, 117)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(35, 0, 0, 0)
        Button6.Size = New Size(282, 31)
        Button6.TabIndex = 4
        Button6.Text = "Franchise Renewal"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.RosyBrown
        Button5.Dock = DockStyle.Top
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button5.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Location = New Point(0, 88)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(35, 0, 0, 0)
        Button5.Size = New Size(282, 29)
        Button5.TabIndex = 3
        Button5.Text = "Regulatory Authority"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.RosyBrown
        Button4.Dock = DockStyle.Top
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button4.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(0, 59)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(35, 0, 0, 0)
        Button4.Size = New Size(282, 29)
        Button4.TabIndex = 2
        Button4.Text = "Vehicle"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RosyBrown
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button3.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(0, 30)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(35, 0, 0, 0)
        Button3.Size = New Size(282, 29)
        Button3.TabIndex = 1
        Button3.Text = "List of Franchise"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RosyBrown
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.DimGray
        Button2.FlatAppearance.MouseOverBackColor = Color.DimGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(0, 0)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(35, 0, 0, 0)
        Button2.Size = New Size(282, 30)
        Button2.TabIndex = 0
        Button2.Text = "New Entry Form"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ButtonMenu
        ' 
        ButtonMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ButtonMenu.BackColor = Color.LightCoral
        ButtonMenu.Dock = DockStyle.Top
        ButtonMenu.FlatAppearance.BorderSize = 0
        ButtonMenu.FlatAppearance.MouseDownBackColor = Color.Gray
        ButtonMenu.FlatAppearance.MouseOverBackColor = Color.Gray
        ButtonMenu.FlatStyle = FlatStyle.Flat
        ButtonMenu.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonMenu.ForeColor = SystemColors.ButtonHighlight
        ButtonMenu.Image = CType(resources.GetObject("ButtonMenu.Image"), Image)
        ButtonMenu.ImageAlign = ContentAlignment.MiddleLeft
        ButtonMenu.Location = New Point(0, 257)
        ButtonMenu.Name = "ButtonMenu"
        ButtonMenu.Padding = New Padding(10, 0, 0, 0)
        ButtonMenu.Size = New Size(282, 61)
        ButtonMenu.TabIndex = 7
        ButtonMenu.Text = "Menu"
        ButtonMenu.UseVisualStyleBackColor = False
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnDashboard.BackColor = Color.LightCoral
        BtnDashboard.Dock = DockStyle.Top
        BtnDashboard.FlatAppearance.BorderSize = 0
        BtnDashboard.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnDashboard.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnDashboard.FlatStyle = FlatStyle.Flat
        BtnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDashboard.ForeColor = SystemColors.ButtonHighlight
        BtnDashboard.Image = My.Resources.Resources.Vector
        BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        BtnDashboard.Location = New Point(0, 189)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Padding = New Padding(10, 0, 0, 0)
        BtnDashboard.Size = New Size(282, 68)
        BtnDashboard.TabIndex = 5
        BtnDashboard.Text = "Dashboard"
        BtnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Violet
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(282, 189)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCoral
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(282, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' IconDropDownButton1
        ' 
        IconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconDropDownButton1.IconColor = Color.Black
        IconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconDropDownButton1.Name = "IconDropDownButton1"
        IconDropDownButton1.Size = New Size(23, 23)
        IconDropDownButton1.Text = "IconDropDownButton1"
        ' 
        ' IconDropDownButton2
        ' 
        IconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconDropDownButton2.IconColor = Color.Black
        IconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconDropDownButton2.Name = "IconDropDownButton2"
        IconDropDownButton2.Size = New Size(23, 23)
        IconDropDownButton2.Text = "IconDropDownButton2"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightCoral
        Panel3.Controls.Add(BtnFullScreen)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(282, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(650, 38)
        Panel3.TabIndex = 2
        ' 
        ' BtnFullScreen
        ' 
        BtnFullScreen.BackColor = SystemColors.ActiveCaptionText
        BtnFullScreen.Dock = DockStyle.Right
        BtnFullScreen.FlatStyle = FlatStyle.Flat
        BtnFullScreen.ForeColor = SystemColors.ActiveCaptionText
        BtnFullScreen.Image = My.Resources.Resources.Full_Screen
        BtnFullScreen.Location = New Point(377, 0)
        BtnFullScreen.Name = "BtnFullScreen"
        BtnFullScreen.Size = New Size(53, 38)
        BtnFullScreen.TabIndex = 1
        BtnFullScreen.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Dock = DockStyle.Right
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(430, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 38)
        Button1.TabIndex = 0
        Button1.Text = "Admin Harley"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(282, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(650, 944)
        Panel2.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources._22c4b23f_2706_4e11_bf6e_07bc0e18684b_removebg_preview
        PictureBox2.Location = New Point(102, 273)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(446, 398)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(932, 982)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(PanelDashboard)
        MinimumSize = New Size(950, 600)
        Name = "Form1"
        Text = "Form 1-Home"
        PanelDashboard.ResumeLayout(False)
        ReportsSubpanel.ResumeLayout(False)
        Submenupanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents Submenupanel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnReports As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconDropDownButton1 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents IconDropDownButton2 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ReportsSubpanel As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnFullScreen As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents PictureBox2 As PictureBox

End Class
