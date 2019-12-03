Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpCliZon
    Sub insCliPri()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dCliZon, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliPri As New SqlCommand(delSqlCliZon, conmssql)
            deleteCliPri.ExecuteNonQuery()

            Dim insertCliPri As New SqlCommand(intSqlCliZon, conmssql)


            While reader.Read()
                insertCliPri.Parameters.Clear()
                insertCliPri.Parameters.AddWithValue("@ID_ZONA", reader("ID_ZONA"))
                insertCliPri.Parameters.AddWithValue("@NOM_ZONA", reader("NOM_ZONA"))
                insertCliPri.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliPri.ExecuteNonQuery()
            End While

            MsgBox("Información Clientes Zonas; exportada", MsgBoxStyle.Information)

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
