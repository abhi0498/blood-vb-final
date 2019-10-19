Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class Class1
    Private DBCon As New SqlConnection("Server=LAPTOP-OHD2Q4TE\DATABASE_IN;Database=Blood;User ID=sa;Password=123456")
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public RecordCount As Integer
    Public Params As New List(Of SqlParameter)

    Public Sub New()

    End Sub

    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    Public Sub ExecQuery(Query As String)
        Try
            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            Params.Clear()


            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.fill(DBDT)

        Catch ex As Exception
            Exception = ex.Message
        Finally
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam )
    End Sub
End Class
