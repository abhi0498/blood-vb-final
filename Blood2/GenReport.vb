
Imports System.IO
Imports System.Text
Public Class GenReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Query As String
        Query = "insert into Donations
values('" & donor.Text.Trim() & "'
        ,'" & patient.Text.Trim &
        "','" & bgroup.Text.Trim() &
        "','" & dt.Text.Trim() &
        "','" & quantity.Text.Trim() & "');"


        Form3.UpdateQuery(Query)
        Try
            Form3.ExecQuery("select * from patient")

            'DataGridView1.DataSource = Form3.DBDT

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Form3.ExecQuery("select * from Donations;")

            dgv.DataSource = Form3.DBDT

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgv.Rows(index)
        donor.Text = selectedRow.Cells(0).Value.ToString()
        patient.Text = selectedRow.Cells(1).Value.ToString()
        bgroup.Text = selectedRow.Cells(2).Value.ToString()
        dt.Text = selectedRow.Cells(3).Value.ToString()
        quantity.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If donor.Text = "" Then
            MsgBox("Please select a value from table")
        Else
            Dim path As String = "C:\temp\mytest.txt"
            Dim fs As FileStream = File.Create(path)


            Dim txt As String = "                     Blood Report                       " & donor.Text & vbCrLf
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(txt)
            fs.Write(info, 0, info.Length)

            txt = "----------------------------------------------------------------------------------" & donor.Text & vbCrLf
            info = New UTF8Encoding(True).GetBytes(txt)
            fs.Write(info, 0, info.Length)


            txt = "     Donor Name:" & donor.Text & vbCrLf
            info = New UTF8Encoding(True).GetBytes(txt)
            fs.Write(info, 0, info.Length)

            txt = "     Patient Name:" & patient.Text & vbCrLf
            info = New UTF8Encoding(True).GetBytes(txt)
            fs.Write(info, 0, info.Length)

            txt = "     Blood Group:" & bgroup.Text & vbCrLf
            info = New UTF8Encoding(True).GetBytes(txt)
            fs.Write(info, 0, info.Length)

            txt = "     Date:" & dt.Text & vbCrLf
            info = New UTF8Encoding(True).GetBytes(txt)
            fs.Write(info, 0, info.Length)

            txt = "     Quantity:" & quantity.Text & vbCrLf
            info = New UTF8Encoding(True).GetBytes(txt)
            fs.Write(info, 0, info.Length)


            Dim mon As New Process()
            mon.StartInfo.FileName = path
            mon.StartInfo.Verb = "Print"
            mon.StartInfo.CreateNoWindow = True
            mon.Start()

            fs.Close()
        End If


    End Sub
End Class