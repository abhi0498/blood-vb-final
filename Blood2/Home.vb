
Public Class Home
    Public SQL As New SqlControl

    Public Sub LoadGrid()
        '  SQL.ExecQuery("SELECT * FROM LOGIN")
        'DBData.DataSource = SQL.DBDT
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoadGrid()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()

    End Sub

    'z-index
    Public Sub SetControlZOrder(ctrl As Control, z As Integer)

        ctrl.Parent.Controls.SetChildIndex(ctrl, z)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles NewHospital.Click
        NewAccount.Show()

        'NewAccount.Show()
    End Sub

    Private Sub NewDonor_Click(sender As Object, e As EventArgs)

    End Sub
End Class
