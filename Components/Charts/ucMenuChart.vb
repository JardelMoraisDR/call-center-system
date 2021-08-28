Public Class ucMenuChart

#Region "Properties"

    Public Property MyIcon As Image
        Get
            Return pbIcon.Image
        End Get
        Set(value As Image)
            pbIcon.Image = value
        End Set
    End Property

    Public Property MyLabel As String
        Get
            Return lbLabel.Text
        End Get
        Set(value As String)
            lbLabel.Text = value
        End Set
    End Property

    Public Property MyValue As String
        Get
            Return lbValue.Text
        End Get
        Set(value As String)
            lbValue.Text = value
        End Set
    End Property

#End Region

#Region "Events"

    Private Sub ucMenuChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If DesignMode Then
            Exit Sub
        End If

        Design.MyFunctions.SetBorder(pnBackground)

    End Sub

#End Region

End Class
