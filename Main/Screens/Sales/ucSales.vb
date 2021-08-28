Public Class ucSales

#Region "Events"

    Private Sub ucSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgGrid.Rows.Insert(False, False, "1", "7 - José Ricardo", "5413", "01/05/2021", 150.0, 00.00, 25.0, 125.0, "Finalizada")
        dgGrid.Rows.Insert(False, False, "2", "19 - Paulo Rodrigues", "5894", "15/06/2021", 150.0, 00.00, 5.0, 145.0, "Pendente")
        dgGrid.Rows.Insert(False, False, "3", "9 - Victor Andrade", "6190", "21/07/2021", 550.0, 10.0, 5.0, 555.0, "Aprovada")
        dgGrid.Rows.Insert(False, False, "4", "7 - José Ricardo", "7893", "28/08/2021", 50.0, 00.00, 25.0, 75.0, "Finalizada")
        dgGrid.Rows.Insert(False, False, "5", "9 - Victor Andrade", "7894", "28/08/2021", 199.9, 00.00, 10.0, 189.9, "Finalizada")
        dgGrid.Rows.Insert(False, False, "6", "7 - José Ricardo", "7895", "28/08/2021", 50.0, 00.00, 00.0, 50.0, "Aprovada")
        dgGrid.Rows.Insert(False, False, "9", "7 - José Ricardo", "7896", "28/08/2021", 100.0, 00.00, 25.0, 75.0, "Finalizada")

    End Sub

#End Region

End Class
