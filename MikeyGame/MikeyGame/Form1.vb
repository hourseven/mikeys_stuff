Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = " "

        Dim number As Integer

        Randomize()
        number = Int(Rnd() * 20) + 1

        If number = 1 Then
            Label2.Text = "It is certain."
        ElseIf number = 2 Then
            Label2.Text = "As I see it, yes."
        ElseIf number = 3 Then
            Label2.Text = "Reply hazy, try again."
        ElseIf number = 4 Then
            Label2.Text = "Don't count on it."
        ElseIf number = 5 Then
            Label2.Text = "It is decidedly so."
        ElseIf number = 6 Then
            Label2.Text = "Most likely."
        ElseIf number = 7 Then
            Label2.Text = "Ask again later."
        ElseIf number = 8 Then
            Label2.Text = "My reply is no."
        ElseIf number = 9 Then
            Label2.Text = "Without a doubt."
        ElseIf number = 10 Then
            Label2.Text = "Outlook is good."
        ElseIf number = 11 Then
            Label2.Text = "Better not tell you now..."
        ElseIf number = 12 Then
            Label2.Text = "My sources say no."
        ElseIf number = 13 Then
            Label2.Text = "Yes, definitely."
        ElseIf number = 14 Then
            Label2.Text = "Yes."
        ElseIf number = 15 Then
            Label2.Text = "Cannot predict now."
        ElseIf number = 16 Then
            Label2.Text = "Outlook is not good."
        ElseIf number = 17 Then
            Label2.Text = "You may rely on it."
        ElseIf number = 18 Then
            Label2.Text = "Signs point to yes."
        ElseIf number = 19 Then
            Label2.Text = "Concentrate and ask again."
        ElseIf number = 20 Then
            Label2.Text = "Very doubtful."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Coded by Mikey C. 2018.", MsgBoxStyle.OkOnly, "Magic 8 Ball")

    End Sub
End Class
