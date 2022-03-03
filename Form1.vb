Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String
        Dim Marks As Integer

        Name = TextBox1.Text
        Marks = Val(TextBox2.Text)

        If Marks > 85 And Marks <= 100 Then
            MsgBox("Congratulations You Have Scored Grade A")
        ElseIf Marks > 65 And Marks <= 85 Then
            MsgBox("Congratulations You Have Scored Grade B")
        ElseIf Marks > 50 And Marks <= 65 Then
            MsgBox("Congratulations You Have Scored Grade C")
        ElseIf Marks > 33 And Marks <= 50 Then
            MsgBox("You Have Passed")
        Else
            MsgBox("You Have Failed")
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
