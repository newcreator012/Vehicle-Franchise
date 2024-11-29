<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardContent
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
        dashboardpanel1 = New Panel()
        SuspendLayout()
        ' 
        ' dashboardpanel1
        ' 
        dashboardpanel1.Dock = DockStyle.Top
        dashboardpanel1.Location = New Point(0, 0)
        dashboardpanel1.Name = "dashboardpanel1"
        dashboardpanel1.Size = New Size(682, 125)
        dashboardpanel1.TabIndex = 0
        ' 
        ' DashboardContent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(dashboardpanel1)
        Name = "DashboardContent"
        Size = New Size(682, 753)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dashboardpanel1 As Panel

End Class
