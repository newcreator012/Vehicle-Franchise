Public Class Form1
    Private isFullScreen As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the sub-panels as hidden
        Submenupanel.Visible = False
        ReportsSubpanel.Visible = False

        ' Set button sizes to match ButtonMenu size
        Button2.Size = ButtonMenu.Size
        Button3.Size = ButtonMenu.Size
        Button4.Size = ButtonMenu.Size
        Button5.Size = ButtonMenu.Size
        Button6.Size = ButtonMenu.Size
        Button17.Size = ButtonMenu.Size

        ' Reposition buttons within the sub-panel
        Button2.Location = New Point(0, 0)
        Button3.Location = New Point(0, Button2.Bottom)
        Button4.Location = New Point(0, Button17.Bottom)
        Button5.Location = New Point(0, Button4.Bottom)
        Button6.Location = New Point(0, Button5.Bottom)
        Button17.Location = New Point(0, Button3.Bottom)

        ' Resize the sub-panel to fit all buttons
        Submenupanel.Size = New Size(ButtonMenu.Width, Button6.Bottom)

        ' Set button sizes to match BtnReports size
        Button7.Size = BtnReports.Size
        Button8.Size = BtnReports.Size
        Button9.Size = BtnReports.Size
        Button10.Size = BtnReports.Size
        Button11.Size = BtnReports.Size
        Button12.Size = BtnReports.Size
        Button13.Size = BtnReports.Size
        Button14.Size = BtnReports.Size
        Button15.Size = BtnReports.Size
        Button16.Size = BtnReports.Size

        ' Reposition buttons within the ReportsSubpanel
        Button7.Location = New Point(0, 0)
        Button8.Location = New Point(0, Button7.Bottom)
        Button9.Location = New Point(0, Button8.Bottom)
        Button10.Location = New Point(0, Button9.Bottom)
        Button11.Location = New Point(0, Button10.Bottom)
        Button12.Location = New Point(0, Button11.Bottom)
        Button13.Location = New Point(0, Button12.Bottom)
        Button14.Location = New Point(0, Button13.Bottom)
        Button15.Location = New Point(0, Button14.Bottom)
        Button16.Location = New Point(0, Button15.Bottom)

        ' Resize the ReportsSubpanel to fit all buttons
        ReportsSubpanel.Size = New Size(BtnReports.Width, Button16.Bottom)
    End Sub

    Private Sub ToggleSubPanels(excludePanel As Panel)
        ' Hide all sub-panels except the one passed as a parameter
        Submenupanel.Visible = (excludePanel Is Submenupanel)
        ReportsSubpanel.Visible = (excludePanel Is ReportsSubpanel)
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        ' Toggle visibility of the sub-panel and hide others
        If Submenupanel.Visible Then
            Submenupanel.Visible = False
        Else
            ToggleSubPanels(Submenupanel)
            Submenupanel.Visible = True
            Submenupanel.Location = New Point(ButtonMenu.Left, ButtonMenu.Bottom)
        End If
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        ' Toggle visibility of the Reports sub-panel and hide others
        If ReportsSubpanel.Visible Then
            ReportsSubpanel.Visible = False
        Else
            ToggleSubPanels(ReportsSubpanel)
            ReportsSubpanel.Visible = True
            ReportsSubpanel.Location = New Point(BtnReports.Left, BtnReports.Bottom)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Show EntryForms within Panel2
        Panel2.Controls.Clear()
        Dim entryforms As New EntryForms()
        entryforms.Dock = DockStyle.Fill ' Use Dock instead of Anchor
        Panel2.Controls.Add(entryforms)
        entryforms.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Controls.Clear()
        Dim franchiselist As New UserControl9()
        franchiselist.Dock = DockStyle.Fill ' Use Dock instead of Anchor
        Panel2.Controls.Add(franchiselist)
        franchiselist.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel2.Controls.Clear()
        Dim regulatoryauthority As New UserControl11()
        regulatoryauthority.Dock = DockStyle.Fill ' Use Dock instead of Anchor
        Panel2.Controls.Add(regulatoryauthority)
        regulatoryauthority.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("Button6 clicked")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MessageBox.Show("Button7 clicked")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Button8 clicked")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("Button9 clicked")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Button10 clicked")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MessageBox.Show("Button11 clicked")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MessageBox.Show("Button12 clicked")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MessageBox.Show("Button13 clicked")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MessageBox.Show("Button14 clicked")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MessageBox.Show("Button15 clicked")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        MessageBox.Show("Button16 clicked")
    End Sub

    Private Sub BtnFullScreen_Click(sender As Object, e As EventArgs) Handles BtnFullScreen.Click
        ' Toggle full screen mode
        If isFullScreen Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
        isFullScreen = Not isFullScreen
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        ' Create an instance of dashboardContent
        Dim dashboardContent As New DashboardContent()

        ' Add dashboardContent to Panel2
        Panel2.Controls.Clear()
        Panel2.Controls.Add(dashboardContent)

        ' Show dashboardContent
        dashboardContent.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PanelDashboard_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Panel2.Controls.Clear()
        Dim franchiseelist As New UserControl10()
        franchiseelist.Dock = DockStyle.Fill
        Panel2.Controls.Add(franchiseelist)
        franchiseelist.Show()
    End Sub



End Class
