Namespace Design

    Public Class MyFunctions

        Private Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer

        Public Shared Sub SetBorder(ByVal sender As Object, Optional ByVal borderRadius As Short = 5)
            Dim _RegionHandle As IntPtr = New IntPtr(CreateRoundRectRgn(0, 0, sender.Width, sender.Height, borderRadius, borderRadius))
            sender.Region = Region.FromHrgn(_RegionHandle)
            sender.Region.ReleaseHrgn(_RegionHandle)
        End Sub

        Public Sub SetButtonColor(sender As Button, ByRef aButtons As Button())

            Dim oPrimaryColor As Color = Color.FromArgb(115, 46, 252),
                oSecondaryColor As Color = Color.FromArgb(147, 96, 252)

            For Each oBtn As Button In aButtons

                If sender.Name = oBtn.Name Then
                    oBtn.BackColor = oPrimaryColor
                Else
                    oBtn.BackColor = oSecondaryColor
                End If

            Next

        End Sub

    End Class

End Namespace
