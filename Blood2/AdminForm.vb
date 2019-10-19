Public Class AdminForm
    Public SQL As SqlControl
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Form3.ExecQuery("select username,type from Users")

            dgv.DataSource = Form3.DBDT
            dgv.Columns(0).Width = 300
            dgv.Columns(1).Width = 300
            dgv.Columns(2).Width = 300
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub NewAdmin_Click(sender As Object, e As EventArgs) Handles NewAdmin.Click
        Form3.Show()

    End Sub

    Private Sub AdminFP_Click(sender As Object, e As EventArgs)
        ForgotPassword.Show()
    End Sub

    Private Sub EHospital_Click(sender As Object, e As EventArgs) Handles EHospital.Click
        DeleteUsers.Show()

    End Sub

    Private Sub EDonor_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewTables.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class