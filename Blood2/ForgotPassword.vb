Public Class ForgotPassword
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddAdmin_Click(sender As Object, e As EventArgs) Handles AddAdmin.Click


        If Form2.ValidateUser(user.Text, oldPass.Text, "admin") Then
            Dim Query As String = "UPDATE Users SET Password ='" & newPass.Text & "' WHERE UserNAme='" & user.Text & "' and type='" & Type.Text.ToLower() & "'"
            Form3.InsertQuery(Query)
        Else
            MsgBox("Wrong Username or Password")
        End If


    End Sub
End Class