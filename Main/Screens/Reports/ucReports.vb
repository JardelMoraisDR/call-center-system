Imports Components.Design

Public Class ucReports

#Region "Dimensions"

    Private _DesignFunctions As New MyFunctions

#End Region

#Region "Events"

    Private Sub ucReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgGrid.Rows.Insert(False, False, "1", "7 - José Ricardo", "5413", "01/05/2021", 125.0)
        dgGrid.Rows.Insert(False, False, "2", "19 - Paulo Rodrigues", "5894", "15/06/2021", 145.0)
        dgGrid.Rows.Insert(False, False, "3", "9 - Victor Andrade", "6190", "21/07/2021", 555.0)
        dgGrid.Rows.Insert(False, False, "4", "7 - José Ricardo", "7893", "28/08/2021", 75.0)
        dgGrid.Rows.Insert(False, False, "5", "9 - Victor Andrade", "7894", "28/08/2021", 189.9)
        dgGrid.Rows.Insert(False, False, "6", "7 - José Ricardo", "7895", "28/08/2021", 50.0)
        dgGrid.Rows.Insert(False, False, "9", "7 - José Ricardo", "7896", "28/08/2021", 75.0)

    End Sub

#End Region

#Region "Buttons"

    Private Sub btButton_MouseClick(sender As Object, e As MouseEventArgs) Handles btVendas.MouseClick, btRepresentantes.MouseClick,
                                                                                   btTempo.MouseClick, btCampanha.MouseClick

        _DesignFunctions.SetButtonColor(sender, {btVendas, btRepresentantes, btTempo, btCampanha})

    End Sub

#End Region

End Class
