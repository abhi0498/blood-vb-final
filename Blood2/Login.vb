Public Class Form2
    Public SQL As New SqlControl
    Public Username As String
    Public Uname As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HospitalBtn_Click(sender As Object, e As EventArgs) Handles HospitalBtn.Click
        If ValidateUser(User.Text, Password.Text, "hospital") Then

            Form2.ActiveForm.Close()
            HospitalMain.Show()
            MsgBox("Login Successful")
        Else
            MessageBox.Show("Wrong Username or Password")

        End If

    End Sub

    Private Sub DonorBtn_Click(sender As Object, e As EventArgs) Handles DonorBtn.Click

        If ValidateUser(User.Text, Password.Text, "donor") Then
            DonorPage.Uname = User.Text

            Form.ActiveForm.Close()
            DonorPage.Show()
            Home.TopMost = False



        Else
            MessageBox.Show("Wrong Username or Password")

        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub SetControlZOrder(ctrl As Control, z As Integer)

        ctrl.Parent.Controls.SetChildIndex(ctrl, z)
    End Sub

    Private Sub Label9_Click_1(sender As Object, e As EventArgs)

    End Sub

    Public Function ValidateUser(username As String, password As String, type As String)
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()

        End If
        Try
            SQL.RunQuery("Select Count(UserName) As UserCount " &
             "From Users " &
             " Where UserName='" & username & "' and Password='" & password & "' and type='" & type & "'")
            If SQL.DBDS.Tables(0).Rows(0).Item("UserCount") = 1 Then
                SQL.DBCon.Close()
                Return True

            Else
                SQL.DBCon.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox("Username or password incorrect")
            SQL.DBCon.Close()
        End Try






    End Function

    Private Sub AdminBtn_Click(sender As Object, e As EventArgs) Handles AdminBtn.Click
        If ValidateUser(User.Text, Password.Text, "admin") Then
            Form2.ActiveForm.Close()
            AdminForm.Show()
            MsgBox("Login Successful")

        Else
            SQL.DBCon.Open()
            'MessageBox.Show(SQL.DBDA.SelectCommand.ExecuteScalar("Select * from Users where Users=" & User.Text & " and Password=" & Password.Text & " and Type=admin"))

        End If

    End Sub

    Private Sub AdminFP_Click(sender As Object, e As EventArgs) Handles AdminFP.Click
        ForgotPassword.Show()
    End Sub

    Public Function returnUser()
        Return Me.Username
    End Function
End Class