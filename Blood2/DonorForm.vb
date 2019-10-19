Public Class DonorForm
    Public Uname As String
    Public SQL As SqlControl
    Private Sub DonorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(Form2.returnUser())

        Form3.DBCon.Open()
        Try
            Form3.RunQuery("Select * " &
             "From Donor " &
             " Where UserName='" & Uname & "'")
            DonorName.Text = Form3.DBDS.Tables(1).ToString()
        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try

        '.Rows(0).Item("Username")

        Form3.DBCon.Close()




        DonorName.Text += "Name: " & Uname & vbCrLf
        DonorName.Text += "Helo"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DonorName.Click

    End Sub
End Class