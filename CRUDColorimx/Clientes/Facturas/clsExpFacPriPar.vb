Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpFacPriPar
    Sub insFacCliPar()
        Try
            con4d.Open()
            conmssql.Open()


            Dim con1 As New Odbc.OdbcCommand(qry4dFacPriPar, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteCliFacPri As New SqlCommand(delSqlCliFacPri, conmssql)
            deleteCliFacPri.ExecuteNonQuery()

            Dim insertCliFacPri As New SqlCommand(intSqlCliFacPri, conmssql)

            While reader.Read()
                insertCliFacPri.Parameters.Clear()
                insertCliFacPri.Parameters.AddWithValue("@ID_FACTURA", reader("ID_FACTURA"))
                insertCliFacPri.Parameters.AddWithValue("@NUMERO_FACTURA", reader("NUMERO_FACTURA"))
                insertCliFacPri.Parameters.AddWithValue("@SERIE", reader("SERIE"))
                insertCliFacPri.Parameters.AddWithValue("@PREFIJO", reader("PREFIJO"))
                insertCliFacPri.Parameters.AddWithValue("@FOLIO", reader("FOLIO"))
                insertCliFacPri.Parameters.AddWithValue("@TIPO", reader("TIPO"))
                insertCliFacPri.Parameters.AddWithValue("@ID_CLIENTE", reader("ID_CLIENTE"))
                insertCliFacPri.Parameters.AddWithValue("@FECHA_FACTURA", reader("FECHA_FACTURA"))
                insertCliFacPri.Parameters.AddWithValue("@FECHA_VENCIMIENTO", reader("FECHA_VENCIMIENTO"))
                insertCliFacPri.Parameters.AddWithValue("@VALOR_FACTURA", reader("VALOR_FACTURA"))
                insertCliFacPri.Parameters.AddWithValue("@SUBTOTAL", reader("SUBTOTAL"))
                insertCliFacPri.Parameters.AddWithValue("@IMPUESTO", reader("IMPUESTO"))
                insertCliFacPri.Parameters.AddWithValue("@DESCUENTO", reader("DESCUENTO"))
                insertCliFacPri.Parameters.AddWithValue("@PAGO", reader("PAGO"))
                insertCliFacPri.Parameters.AddWithValue("@SALDO", reader("SALDO"))
                insertCliFacPri.Parameters.AddWithValue("@DIA", reader("DIA"))
                insertCliFacPri.Parameters.AddWithValue("@MES", reader("MES"))
                insertCliFacPri.Parameters.AddWithValue("@ANIO", reader("ANIO"))
                insertCliFacPri.Parameters.AddWithValue("@ID_MONEDA", reader("ID_MONEDA"))
                insertCliFacPri.Parameters.AddWithValue("@INFO_CREACION", reader("INFO_CREACION"))
                insertCliFacPri.Parameters.AddWithValue("@INFO_CONFIRMADO", reader("INFO_CONFIRMADO"))
                insertCliFacPri.Parameters.AddWithValue("@INFO_ANULADO", reader("INFO_ANULADO"))
                insertCliFacPri.Parameters.AddWithValue("@ID_PEDIDO", reader("ID_PEDIDO"))
                insertCliFacPri.Parameters.AddWithValue("@ID_SUCURSAL", reader("ID_SUCURSAL"))
                insertCliFacPri.Parameters.AddWithValue("@CONFIRMADO", reader("CONFIRMADO"))
                insertCliFacPri.Parameters.AddWithValue("@ANULADO", reader("ANULADO"))
                insertCliFacPri.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertCliFacPri.ExecuteNonQuery()
            End While

            MsgBox("Información Facturas Principal; exportada", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
        con4d.Close()
        conmssql.Close()
    End Sub
End Class
