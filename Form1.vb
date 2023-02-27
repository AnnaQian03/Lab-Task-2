Public Class Form1
    Private Sub BTNAboutThisApplication_Click(sender As Object, e As EventArgs) Handles BTNAboutThisApplication.Click
        AboutThisApplication.Show(
            )
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dialog1.Show()

    End Sub

    Private Sub BTNSignIn_Click(sender As Object, e As EventArgs) Handles BTNSignIn.Click
        Dialog1.Show()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Latest_Promotion.Show()

    End Sub
End Class
