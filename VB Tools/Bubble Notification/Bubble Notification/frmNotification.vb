Public Class frmNotification

    Private Sub btnNotify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotify.Click
        NotifyIcon.ShowBalloonTip(15)
    End Sub
End Class
