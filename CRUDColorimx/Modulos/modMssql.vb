Imports System.Data
Imports System.Data.SqlClient
Public Module modMssql
    Public sqluser As String = "sa"
    Public sqlpass As String = "Sql2008"
    Public sqlserver As String = "100.48.0.88"
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
