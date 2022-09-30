Public Class Form1


    Private Sub SRButton_Click(sender As Object, e As EventArgs) Handles SRButton.Click
        StuFrom.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub TRButton_Click(sender As Object, e As EventArgs) Handles TRButton.Click
        TchFrom.Show()
    End Sub

End Class
