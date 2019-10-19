Public Class NewAccount
    Private Sub AddAdmin_Click(sender As Object, e As EventArgs) Handles AddAdmin.Click
        Try
            Dim Query = "INSERT INTO Users (UserName,Password,Type) VALUES('" & user.Text & "','" & Pass.Text & "','" & Type.Text.ToLower() & "')"
            Form3.InsertQuery(Query)
            If Type.Text = "Donor" Then
                Query = "INSERT INTO Donor (UserName,blood_group) VALUES('" & user.Text & "',' ')"
                Form3.InsertQuery(Query)
                Me.Close()
                Form2.Show()
            End If

        Catch ex As Exception
            MsgBox("Username already exists")

        End Try


        Form3.DBCon.Close()
    End Sub

    Private Sub NewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class