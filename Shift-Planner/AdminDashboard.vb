﻿Public Class AdminDashboard
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginRegister.Show()
        Me.Close()
    End Sub
End Class