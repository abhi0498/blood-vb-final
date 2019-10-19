Public Class ViewTables
    Private Sub ViewTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Form3.ExecQuery("select * from patient;")

            Patient.DataSource = Form3.DBDT

            Form3.ExecQuery("select * from donor;")

            Donor.DataSource = Form3.DBDT

            Form3.ExecQuery("select * from Donations;")

            Donations.DataSource = Form3.DBDT

            Form3.ExecQuery("select username,type from users;")

            Accounts.DataSource = Form3.DBDT



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class