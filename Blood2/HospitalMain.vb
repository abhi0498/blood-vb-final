Public Class HospitalMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DonorSearch.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddPatient.Show()
    End Sub

    Private Sub HospitalMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Form3.ExecQuery("select * from patient")

            DataGridView1.DataSource = Form3.DBDT

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GenReport.Show()
    End Sub
End Class