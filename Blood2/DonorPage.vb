Public Class DonorPage
    Public Uname As String
    Public SQL As New SqlControl


    Private Sub DonorDetails_Enter(sender As Object, e As EventArgs) Handles DonorDetails.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DonorPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label10.Text = Uname
        Me.TopMost = True
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()

        End If
        Try
            SQL.RunQuery("Select *" &
"From donor " &
" Where name='" & Uname & "'")
            fname.Text = SQL.DBDS.Tables(0).Rows(0).Item("fname")
            lname.Text = SQL.DBDS.Tables(0).Rows(0).Item("lname")
            city.Text = SQL.DBDS.Tables(0).Rows(0).Item("city")
            phno.Text = SQL.DBDS.Tables(0).Rows(0).Item("phone")
            loc.Text = SQL.DBDS.Tables(0).Rows(0).Item("locality")
            bgroup.Text = SQL.DBDS.Tables(0).Rows(0).Item("blood_group")

            SQL.DBCon.Close()

        Catch ex As Exception
            MsgBox("Please enter your details!")

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Query As String
        Query = "update Donor
set Donor.fname='" & fname.Text.Trim() & "'
        ,Donor.lname='" & lname.Text.Trim &
        "',Donor.blood_group='" & bgroup.Text.Trim() &
        "',Donor.city='" & city.Text.Trim() &
        "',Donor.locality='" & loc.Text.Trim() &
        "',Donor.phone='" & phno.Text.Trim() & "'
        where Donor.name='" & Uname & "';"


        Form3.UpdateQuery(Query)

    End Sub

    Private Sub Sout_Click(sender As Object, e As EventArgs) Handles sout.Click
        MsgBox(fname.Text & " Signing off...")

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("Sure?", "Delete Account", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim Query As String
            Query = "delete from Users
        where Users.Username='" & Uname & "';
delete from Donor
        where donor.name='" & Uname & "';"

            Form3.DeleteQuery(Query)

            MsgBox("Miss you " & fname.Text)

            Me.Close()

        End If
    End Sub
End Class