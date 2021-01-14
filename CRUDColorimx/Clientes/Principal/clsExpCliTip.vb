Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpCliTip
    Sub insCliTip()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dCliTip, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliTip As New SqlCommand(delSqlCliTip, conmssql)
            deleteCliTip.ExecuteNonQuery()

            Dim insertCliTip As New SqlCommand(intSqlCliTip, conmssql)


            While reader.Read()
                insertCliTip.Parameters.Clear()
                insertCliTip.Parameters.AddWithValue("@ID_TIPO_CLN", reader("ID_TIPO_CLN"))
                insertCliTip.Parameters.AddWithValue("@NOM_TIPO_CLN", reader("NOM_TIPO_CLN"))
                insertCliTip.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliTip.ExecuteNonQuery()
            End While

            MsgBox("Información Clientes Tipos; exportada", MsgBoxStyle.Information)

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub

End Class
