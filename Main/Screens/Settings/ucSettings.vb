Imports Components.Design

Public Class ucSettings

#Region "Dimensions"

    Private _DesignFunctions As New MyFunctions

#End Region

#Region "Events"

    Private Sub ucSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgGrid.Rows.Insert(False, False, "7", My.Resources.icons8_photo_64, "José Ricardo", "1290", "Vendas", "Editar")
        dgGrid.Rows.Insert(False, False, "21", My.Resources.icons8_photo_64, "Paulo Rodrigues", "6570", "SAC", "Editar")
        dgGrid.Rows.Insert(False, False, "9", My.Resources.icons8_photo_64, "Victor Andrade", "1290", "Vendas", "Editar")
        dgGrid.Rows.Insert(False, False, "10", My.Resources.icons8_photo_64, "Paula Oliveira", "1290", "Vendas", "Editar")
        dgGrid.Rows.Insert(False, False, "12", My.Resources.icons8_photo_64, "Mariana Cardoso", "6570", "SAC", "Editar")
        dgGrid.Rows.Insert(False, False, "18", My.Resources.icons8_photo_64, "Rogério Silvia", "1484", "Cobrança", "Editar")
        dgGrid.Rows.Insert(False, False, "5", My.Resources.icons8_photo_64, "Marcos André", "1290", "Vendas", "Editar")

    End Sub

#End Region

#Region "Buttons"

    Private Sub btButton_MouseClick(sender As Object, e As MouseEventArgs) Handles btClientes.MouseClick, btCampanhas.MouseClick,
                                                                                   btSistema.MouseClick, btOperadores.MouseClick, btUsuarios.MouseClick

        _DesignFunctions.SetButtonColor(sender, {btClientes, btCampanhas, btSistema, btOperadores, btUsuarios})

    End Sub

#End Region

End Class
