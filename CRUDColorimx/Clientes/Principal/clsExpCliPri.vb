Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpCliPri
    Sub insCliPri()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dCliPri, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliPri As New SqlCommand(delSqlCliPri, conmssql)
            deleteCliPri.ExecuteNonQuery()

            Dim insertCliPr As New SqlCommand(intSqlCliPri, conmssql)


            While reader.Read()
                insertCliPr.Parameters.Clear()
                insertCliPr.Parameters.AddWithValue("@ID_CLIENTE", reader("ID_CLIENTE"))
                insertCliPr.Parameters.AddWithValue("@NOM_CLIENTE", reader("NOM_CLIENTE"))
                insertCliPr.Parameters.AddWithValue("@RFC", reader("RFC"))
                insertCliPr.Parameters.AddWithValue("@RAZON_SOCIAL", reader("RAZON_SOCIAL"))
                insertCliPr.Parameters.AddWithValue("@INACTIVO", reader("INACTIVO"))
                insertCliPr.Parameters.AddWithValue("@FECHA_INGRESO", reader("FECHA_INGRESO"))
                insertCliPr.Parameters.AddWithValue("@DIRECCION_PRINCIPAL_1", reader("DIRECCION_PRINCIPAL_1"))
                insertCliPr.Parameters.AddWithValue("@DIRECCION_PRINCIPAL_2", reader("DIRECCION_PRINCIPAL_2"))
                insertCliPr.Parameters.AddWithValue("@DIRECCION_PRINCIPAL_3", reader("DIRECCION_PRINCIPAL_3"))
                insertCliPr.Parameters.AddWithValue("@NUM_EXTERIOR", reader("NUM_EXTERIOR"))
                insertCliPr.Parameters.AddWithValue("@NUM_INTERIOR", reader("NUM_INTERIOR"))
                insertCliPr.Parameters.AddWithValue("@COLONIA", reader("COLONIA"))
                insertCliPr.Parameters.AddWithValue("@MUNICIPIO", reader("MUNICIPIO"))
                insertCliPr.Parameters.AddWithValue("@LOCALIDAD", reader("LOCALIDAD"))
                insertCliPr.Parameters.AddWithValue("@ID_CIUDAD", reader("ID_CIUDAD"))
                insertCliPr.Parameters.AddWithValue("@ID_ESTADO", reader("ID_ESTADO"))
                insertCliPr.Parameters.AddWithValue("@ID_PAIS", reader("ID_PAIS"))
                insertCliPr.Parameters.AddWithValue("@ID_ZONA", reader("ID_ZONA"))
                insertCliPr.Parameters.AddWithValue("@CP", reader("CP"))
                insertCliPr.Parameters.AddWithValue("@TELEFONO", reader("TELEFONO"))
                insertCliPr.Parameters.AddWithValue("@TELEFONO_2", reader("TELEFONO_2"))
                insertCliPr.Parameters.AddWithValue("@FAX", reader("FAX"))
                insertCliPr.Parameters.AddWithValue("@EMAIL_FISCAL", reader("EMAIL_FISCAL"))
                insertCliPr.Parameters.AddWithValue("@E_MAIL", reader("E_MAIL"))
                insertCliPr.Parameters.AddWithValue("@ID_CUENTA", reader("ID_CUENTA"))
                insertCliPr.Parameters.AddWithValue("@ID_MONEDA", reader("ID_MONEDA"))
                insertCliPr.Parameters.AddWithValue("@DIAS_CREDITO", reader("DIAS_CREDITO"))
                insertCliPr.Parameters.AddWithValue("@TERMINO_CREDITO", reader("TERMINO_CREDITO"))
                insertCliPr.Parameters.AddWithValue("@LIMITE_CREDITO", reader("LIMITE_CREDITO"))
                insertCliPr.Parameters.AddWithValue("@SALDO", reader("SALDO"))
                insertCliPr.Parameters.AddWithValue("@RESERVA", reader("RESERVA"))
                insertCliPr.Parameters.AddWithValue("@ID_TIPO", reader("ID_TIPO"))
                insertCliPr.Parameters.AddWithValue("@ID_GIRO", reader("ID_GIRO"))
                insertCliPr.Parameters.AddWithValue("@ID_CATEGORIA", reader("ID_CATEGORIA"))
                insertCliPr.Parameters.AddWithValue("@ID_SECTOR", reader("ID_SECTOR"))
                insertCliPr.Parameters.AddWithValue("@ID_LOCALIZACION", reader("ID_LOCALIZACION"))
                insertCliPr.Parameters.AddWithValue("@ID_VENDEDOR", reader("ID_VENDEDOR"))
                insertCliPr.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliPr.ExecuteNonQuery()
            End While

            MsgBox("Información configuración de Clientes; exportada", MsgBoxStyle.Information)

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
