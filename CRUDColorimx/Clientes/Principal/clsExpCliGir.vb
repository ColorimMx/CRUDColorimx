Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpCliGir
    Sub insCliGir()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dCliGir, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliGir As New SqlCommand(delSqlCliGir, conmssql)
            deleteCliGir.ExecuteNonQuery()

            Dim insertCliGir As New SqlCommand(intSqlCliGir, conmssql)


            While reader.Read()
                insertCliGir.Parameters.Clear()
                insertCliGir.Parameters.AddWithValue("@ID_GIRO", reader("ID_GIRO"))
                insertCliGir.Parameters.AddWithValue("@NOM_GIRO", reader("NOM_GIRO"))
                insertCliGir.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliGir.ExecuteNonQuery()
            End While

            MsgBox("Información Clientes Giros; exportada", MsgBoxStyle.Information)

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
