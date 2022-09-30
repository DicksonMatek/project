
Public Class TchFrom

    Private Sub ExtTchButton_Click(sender As Object, e As EventArgs) Handles ExtTchButton.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ClearTchButton_Click(sender As Object, e As EventArgs) Handles ClearTchButton.Click
        TxtAdd.Clear()
        TxtName.Clear()
        TxtNRIC.Clear()
        TextContact.Clear()
        TextEmail.Clear()
        TextRace.Clear()
        TextGender.Clear()
        'jjj

    End Sub

    Private Sub SubmitTchButton_Click(sender As Object, e As EventArgs) Handles SubmitTchButton.Click
        Me.Hide()
    End Sub
End Class