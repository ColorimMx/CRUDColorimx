Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpFacDetPar
    Sub insFacDetPar()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dFacDetPar, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliFacDet As New SqlCommand(delSqlCliFacDet, conmssql)
            deleteCliFacDet.ExecuteNonQuery()

            Dim insertCliFacDet As New SqlCommand(intSqlCliFacDet, conmssql)

            While reader.Read()
                insertCliFacDet.Parameters.Clear()
                insertCliFacDet.Parameters.AddWithValue("@ID_FACTURA", reader("ID_FACTURA"))
                insertCliFacDet.Parameters.AddWithValue("@ORIGEN", reader("ORIGEN"))
                insertCliFacDet.Parameters.AddWithValue("@LINEA", reader("LINEA"))
                insertCliFacDet.Parameters.AddWithValue("@ID_PRODUCTO", reader("ID_PRODUCTO"))
                insertCliFacDet.Parameters.AddWithValue("@CANTIDAD", reader("CANTIDAD"))
                insertCliFacDet.Parameters.AddWithValue("@PRECIO_FINAL", reader("PRECIO_FINAL"))
                insertCliFacDet.Parameters.AddWithValue("@SUBTOTAL", reader("SUBTOTAL"))
                insertCliFacDet.Parameters.AddWithValue("@TIPO_CAMBIO", reader("TIPO_CAMBIO"))
                insertCliFacDet.Parameters.AddWithValue("@SUBTOTAL_CONVERT", reader("SUBTOTAL_CONVERT"))
                insertCliFacDet.Parameters.AddWithValue("@IVA_CONVERT", reader("IVA_CONVERT"))
                insertCliFacDet.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliFacDet.ExecuteNonQuery()
            End While

            MsgBox("Información Facturas Detalle; exportada", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
