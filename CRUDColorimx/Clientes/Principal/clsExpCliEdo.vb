Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpCliEdo
    Sub insCliEdo()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dCliEdo, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliEdo As New SqlCommand(delSqlCliEdo, conmssql)
            deleteCliEdo.ExecuteNonQuery()

            Dim insertCliEdo As New SqlCommand(intSqlCliEdo, conmssql)


            While reader.Read()
                insertCliEdo.Parameters.Clear()
                insertCliEdo.Parameters.AddWithValue("@ID_ESTADO", reader("ID_ESTADO"))
                insertCliEdo.Parameters.AddWithValue("@NOM_ESTADO", reader("NOM_ESTADO"))
                insertCliEdo.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliEdo.ExecuteNonQuery()
            End While

            MsgBox("Información Clientes Estados; exportada", MsgBoxStyle.Information)

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
