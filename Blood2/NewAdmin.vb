Imports System.Data.SqlClient

Public Class Form3
    Public DBCon As New SqlConnection("Server=LAPTOP-OHD2Q4TE\DATABASE_IN;Database=Blood;User ID=sa;Password=123456")
    Public SQL As SqlControl
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public RecordCount As Integer
    Public Params As New List(Of SqlParameter)
    Public DBDS As New DataSet
    Private Sub AddAdmin_Click(sender As Object, e As EventArgs) Handles AddAdmin.Click
        Try
            Dim Query = "INSERT INTO Users (UserName,Password,Type) VALUES('" & NewAdminU.Text & "','" & NewAdminP.Text & "','admin')"
            InsertQuery(Query)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


    Public Sub InsertQuery(Query As String)
        Try
            Dim command As New SqlCommand(Query, DBCon)
            DBCon.Open()

            command.ExecuteNonQuery()

            MsgBox("Insert successful")

            DBCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Public Sub RunQuery(Query As String)
        Try
            DBCon.Open()
            DBCmd = New SqlCommand(Query, DBCon)

            DBDA = New SqlDataAdapter(DBCmd)
            DBDS = New DataSet
            DBDA.Fill(DBDS)



            DBCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If

        End Try


    End Sub

    Public Sub DeleteQuery(Query As String)
        Try
            Dim command As New SqlCommand(Query, DBCon)
            DBCon.Open()

            command.ExecuteNonQuery()

            DBCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Public Sub UpdateQuery(Query As String)
        Try
            Dim command As New SqlCommand(Query, DBCon)
            DBCon.Open()

            command.ExecuteNonQuery()

            MsgBox("Update successful")

            DBCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Public Sub ExecQuery(Query As String)
        Try
            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            Params.Clear()


            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

            System.Console.Write(DBDT)
        Catch ex As Exception
            System.Console.Write(ex.Message)

        Finally
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try
    End Sub
    Private Sub NewAdminP_TextChanged(sender As Object, e As EventArgs) Handles NewAdminP.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NewAdminU_TextChanged(sender As Object, e As EventArgs) Handles NewAdminU.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class