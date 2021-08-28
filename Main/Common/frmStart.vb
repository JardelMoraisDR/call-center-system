Imports Components.Design

Public Class frmStart

#Region "Others"

    Public Enum ScreenMenu
        Dashboard = 0
        Connections = 1
        Sales = 2
        Reports = 3
        Settings = 4
        Alerts = 5
        Void = 0
    End Enum

#End Region

#Region "Events"

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If DesignMode Then
            Exit Sub
        End If

        MyFunctions.SetBorder(Button1)
        MyFunctions.SetBorder(Button2)
        MyFunctions.SetBorder(Button3)
        MyFunctions.SetBorder(Button4)

        ''MyFunctions.SetBorder(Panel4)
        MyFunctions.SetBorder(Panel5)

        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

        SetScreen(ScreenMenu.Dashboard)

    End Sub

#End Region

#Region "Buttons"

    Private Sub btButtons_Click(sender As Object, e As EventArgs) Handles btDashboard.Click, btConnections.Click, btSales.Click, btReports.Click, btSettings.Click

        Dim CurrentScreen As ScreenMenu = ScreenMenu.Void

        Select Case sender.Name
            Case btDashboard.Name : CurrentScreen = ScreenMenu.Dashboard
            Case btConnections.Name : CurrentScreen = ScreenMenu.Connections
            Case btSales.Name : CurrentScreen = ScreenMenu.Sales
            Case btReports.Name : CurrentScreen = ScreenMenu.Reports
            Case btSettings.Name : CurrentScreen = ScreenMenu.Settings
        End Select

        SetScreen(CurrentScreen)

    End Sub

#End Region

#Region "Functions"

    Private Sub SetScreen(ByVal Screen As ScreenMenu)

        pnScreen.Controls.Clear()

        Select Case Screen
            Case ScreenMenu.Dashboard
                lbTitle.Text = "Dashboard"
                lbRoute.Text = "Menu / Dashboard"
                pnScreen.Controls.Add(New ucDashboard() With {.Dock = DockStyle.Fill, .BackColor = Color.White})
            Case ScreenMenu.Connections
                lbTitle.Text = "Ligações"
                lbRoute.Text = "Menu / Ligações"
                pnScreen.Controls.Add(New ucConnections() With {.Dock = DockStyle.Fill, .BackColor = Color.White})
            Case ScreenMenu.Sales
                lbTitle.Text = "Vendas"
                lbRoute.Text = "Menu / Vendas"
                pnScreen.Controls.Add(New ucSales() With {.Dock = DockStyle.Fill, .BackColor = Color.White})
            Case ScreenMenu.Reports
                lbTitle.Text = "Relatórios"
                lbRoute.Text = "Menu / Relatórios"
                pnScreen.Controls.Add(New ucReports() With {.Dock = DockStyle.Fill, .BackColor = Color.White})
            Case ScreenMenu.Settings
                lbTitle.Text = "Configurações"
                lbRoute.Text = "Menu / Configurações"
                pnScreen.Controls.Add(New ucSettings() With {.Dock = DockStyle.Fill, .BackColor = Color.White})
        End Select

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim oAbout As New frmAbout
        oAbout.ShowDialog()
    End Sub

#End Region

End Class