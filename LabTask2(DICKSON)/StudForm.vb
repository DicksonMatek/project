Public Class StuFrom

    Private Sub ExtStudButton_Click(sender As Object, e As EventArgs) Handles ExtStudButton.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ClearStudButton_Click(sender As Object, e As EventArgs) Handles ClearStudButton.Click
        TBAddStud.Clear()
        TBContact.Clear()
        TBFatherStud.Clear()
        TBMotherStud.Clear()
        TBNameStud.Clear()

    End Sub

    Private Sub SubmitStudButton_Click(sender As Object, e As EventArgs) Handles SubmitStudButton.Click
        Me.Hide()
    End Sub
End Class