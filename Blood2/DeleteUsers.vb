Public Class DeleteUsers
    Private Sub AddAdmin_Click(sender As Object, e As EventArgs) Handles AddAdmin.Click

        Dim Query As String = "DELETE FROM Users WHERE username='" & user.Text & "'and type='" & Type.Text & "'"
        Form3.DeleteQuery(Query)
    End Sub
End Class