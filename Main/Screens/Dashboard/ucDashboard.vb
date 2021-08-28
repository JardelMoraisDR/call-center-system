Public Class ucDashboard

#Region "Properties"

    Public Property MyGrid As DataGridView
        Get
            Return dgGrid
        End Get
        Set(value As DataGridView)
            dgGrid = value
        End Set
    End Property

#End Region

#Region "Events"

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim imgAtendimento As Image = My.Resources.stsAtendimento,
            imgTabulacao As Image = My.Resources.stsTabulacao,
            imgNegociacao As Image = My.Resources.stsNegociacao,
            imgPausa As Image = My.Resources.stsPausa

        dgGrid.Rows.Insert(False, False, "0", "7 - José Ricardo", "1290", imgTabulacao, "00:02:31", "48 - Sydney pereira")
        dgGrid.Rows.Insert(False, False, "1", "19 - Paulo Rodrigues", "1290", imgAtendimento, "00:00:31", "05 - João da Cunha")
        dgGrid.Rows.Insert(False, False, "2", "9 - Victor Andrade", "1290", imgNegociacao, "00:01:02", "54 - Mariana da Silva")
        dgGrid.Rows.Insert(False, False, "3", "32 - Matheus Pascoal", "1290", imgPausa, "00:00:15", "55 - Ricardo Lopes")
        dgGrid.Rows.Insert(False, False, "4", "19 - Carla da Cunha", "1290", imgAtendimento, "00:01:40", "41 - Saulo Caldeiras")
        dgGrid.Rows.Insert(False, False, "5", "21 - Rogerio do Nascimento", "1290", imgPausa, "00:00:25", "65 - Wagner Bruno")
        dgGrid.Rows.Insert(False, False, "6", "23 - Mariana Peixoto", "1290", imgTabulacao, "00:00:01", "59 - Flavio pereira")
        dgGrid.Rows.Insert(False, False, "7", "6 - Carlos de Andrade", "1290", imgAtendimento, "00:02:01", "84 - Janaina da Silva")

    End Sub

#End Region

End Class
