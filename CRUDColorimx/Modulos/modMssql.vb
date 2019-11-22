Imports System.Data
Imports System.Data.SqlClient
Public Module modMssql
    Public sqluser As String = "sa"
    Public sqlpass As String = "Sql2014"
    Public sqlserver As String = Module1.mssql
    Public sqldb As String = "4D_COLORANT"


    Public conmssql As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")

    Sub conectarsql()
        Try
            conmssql.Open()
            MsgBox("Conexion exitosa a MSSQL")
        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Module
