Public Class AddPatient
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewTable()
    End Sub

    Public Sub viewTable()
        Try
            Form3.ExecQuery("select * from patient")

            DataGridView1.DataSource = Form3.DBDT

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Query As String
        Query = "insert into Patient
values('" & name.Text.Trim() & "'
        ,'" & age.Text.Trim &
        "','" & phone.Text.Trim() &
        "','" & loc.Text.Trim() &
        "','" & bgroup.Text.Trim() & "');"


        Form3.UpdateQuery(Query)
        viewTable()


    End Sub

    Private Sub bgroup_TextChanged(sender As Object, e As EventArgs) Handles bgroup.TextChanged

    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged

    End Sub

    Private Sub loc_TextChanged(sender As Object, e As EventArgs) Handles loc.TextChanged

    End Sub

    Private Sub phone_TextChanged(sender As Object, e As EventArgs) Handles phone.TextChanged

    End Sub

    Private Sub name_TextChanged(sender As Object, e As EventArgs) Handles name.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(i)
        name.Text = selectedRow.Cells(0).Value.ToString()
        age.Text = selectedRow.Cells(1).Value.ToString()
        phone.Text = selectedRow.Cells(2).Value.ToString()
        bgroup.Text = selectedRow.Cells(3).Value.ToString()
        loc.Text = selectedRow.Cells(4).Value.ToString()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "delete from patient where patient_name='" & name.Text & "';"
        Form3.DeleteQuery(query)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "update patient 
set patient.age='" & age.Text.Trim() & "'
        ,patient.locality='" & loc.Text.Trim &
        "',patient.blood_group='" & bgroup.Text.Trim() &
        "',patient.phone='" & phone.Text.Trim() & "'

        where patient.patient_name='" & name.Text & "'"
        Form3.UpdateQuery(query)
        viewTable()
    End Sub
End Class