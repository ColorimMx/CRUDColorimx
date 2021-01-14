Imports System.Data
Imports System.Data.Odbc
Public Module mod4D
    Dim DSN As String = "32MBA3"
    Dim odbcuser As String = "ODBC"
    Dim odbcpass As String = "ODBC"

    Public con4d As New OdbcConnection("DSN=" & DSN +
                                       ";Uid=" & odbcuser +
                                       ";Pwd=" & odbcpass + ";")

    Public Sub conectar4d()
        Try
            con4d.Open()
            MsgBox("Conexion exitosa a MBA3")
        Catch ex As Odbc.OdbcException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Module
