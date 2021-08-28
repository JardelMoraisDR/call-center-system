Imports Components.Design

Public Class ucConnections

    Private Sub ucConnections_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MyFunctions.SetBorder(pnChart)

        dgGrid.Rows.Insert(False, False, "0", "7 - José Ricardo", "1290", "28/08/2021", "00:02:31", "48 - Sydney pereira", "Recarga", "Ver")
        dgGrid.Rows.Insert(False, False, "1", "19 - Paulo Rodrigues", "1290", "28/08/2021", "00:00:31", "05 - João da Cunha", "Recarga", "Ver")
        dgGrid.Rows.Insert(False, False, "2", "9 - Victor Andrade", "1290", "28/08/2021", "00:01:02", "54 - Mariana da Silva", "Pré-Pago", "Ver")
        dgGrid.Rows.Insert(False, False, "3", "32 - Matheus Pascoal", "1290", "28/08/2021", "00:00:15", "55 - Ricardo Lopes", "Recarga", "Ver")
        dgGrid.Rows.Insert(False, False, "4", "19 - Carla da Cunha", "1290", "28/08/2021", "00:01:40", "41 - Saulo Caldeiras", "Pré-Pago", "Ver")
        dgGrid.Rows.Insert(False, False, "5", "21 - Rogerio do Nascimento", "1290", "28/08/2021", "00:00:25", "65 - Wagner Bruno", "Recarga", "Ver")
        dgGrid.Rows.Insert(False, False, "6", "23 - Mariana Peixoto", "1290", "28/08/2021", "00:00:01", "59 - Flavio pereira", "Pré-Pago", "Ver")
        dgGrid.Rows.Insert(False, False, "7", "6 - Carlos de Andrade", "1290", "28/08/2021", "00:02:01", "84 - Janaina da Silva", "Migração", "Ver")

    End Sub

End Class
