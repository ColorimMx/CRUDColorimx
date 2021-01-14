Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpCliCiu
    Sub insCliCiu()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dCliCiu, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliCiu As New SqlCommand(delSqlCliCiu, conmssql)
            deleteCliCiu.ExecuteNonQuery()

            Dim insertCliCiu As New SqlCommand(intSqlCliCiu, conmssql)


            While reader.Read()
                insertCliCiu.Parameters.Clear()
                insertCliCiu.Parameters.AddWithValue("@ID_CIUDAD", reader("ID_CIUDAD"))
                insertCliCiu.Parameters.AddWithValue("@NOM_CIUDAD", reader("NOM_CIUDAD"))
                insertCliCiu.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliCiu.ExecuteNonQuery()
            End While

            MsgBox("Información Clientes Ciudades; exportada", MsgBoxStyle.Information)

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
