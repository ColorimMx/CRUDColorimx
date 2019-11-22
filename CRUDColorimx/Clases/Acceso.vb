Imports System.Data
Imports System.Data.SqlClient
Public Class Acceso
    Public Function logear(ByVal USUARIO As String, ByVal PASS As String) As String
        Dim adapter As SqlDataAdapter
        Dim acceso As String = ""
        Dim ds As New DataSet
        Dim sql As String
        sql = "SELECT ACCESO FROM USUARIOS WHERE USUARIO ='" & USUARIO & "' AND CONTRASENA ='" & PASS & "' AND HABILITADO = 1"
        Try
            conmssql.Open()
            adapter = New SqlDataAdapter(sql, conmssql.ConnectionString)
            adapter.Fill(ds)
            acceso = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            MsgBox(" Usuario/Contraseña Invalidos ", vbCritical)
        Finally
            conmssql.Close()
        End Try
        Return acceso
    End Function
End Class
