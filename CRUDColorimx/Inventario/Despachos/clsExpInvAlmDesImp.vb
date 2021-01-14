Imports System.Data
Imports System.Data.SqlClient

Public Class clsExpInvAlmDesImp



    Sub insInvAlmDesImpFecha(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Try
            con4d.Open()
            conmssql.Open()


            Dim qry4dInvAlmDesImp = " SELECT  CONCAT(CONCAT(INVT_Producto_Movimientos.ORIGIN_REF,'-'),INVT_Producto_Movimientos.Posicion) AS ID_TEMP_IMP_DESPACHO, " +
" INVT_Producto_Movimientos.ORIGIN_REF AS ID_DESPACHO, " +
" INVT_Producto_Movimientos.TRANS_DATE AS FECHA_DESPACHO, " +
" INVT_Producto_Movimientos.NUMERO_PEDIDO_MBA AS ID_PEDIDO, " +
" CLNT_Pedidos_Principal.FECHA_PEDIDO, " +
" INVT_Producto_Movimientos.COD_CLIENTE AS ID_CLIENTE, " +
" CLNT_Pedidos_Principal.Nombre_solicitante AS SOLICITANTE, " +
" SUBSTRING(CLNT_Pedidos_Principal.Cerrado_Info, 21, 16)  AS CONFIRMADO, " +
" CLNT_Pedidos_Principal.DESPACHO_DIR1 AS DIRECCION_1, " +
" CLNT_Pedidos_Principal.DESPACHO_DIR2 AS DIRECCION_2, " +
" INVT_Producto_Movimientos.Posicion AS NUM_LINEA, " +
" INVT_Producto_Movimientos.PRODUCT_ID AS ID_PRODUCTO, " +
" INVT_Producto_Movimientos.PRODUCT_NAME AS NOMBRE_PRODUCTO, " +
" INVT_Producto_Movimientos.QUANTITY AS CANTIDAD, " +
" INVT_Producto_Movimientos.UM, CLNT_Pedidos_Principal.MEMO " +
" FROM     INVT_Producto_Movimientos , " +
" CLNT_Pedidos_Principal " +
" WHERE    INVT_Producto_Movimientos.NUMERO_PEDIDO_MBA=CLNT_Pedidos_Principal.CONTRATO_ID " +
" AND      INVT_Producto_Movimientos.ADJUSTMENT_TYPE = 'RM' " +
" AND      INVT_Producto_Movimientos.TRANS_DATE BETWEEN '" & Fecha1 & "' AND '" & Fecha2 & "' " +
" AND CLNT_Pedidos_Principal.CORP = 'CIMSA' " +
" AND CLNT_Pedidos_Principal.Tipo_Doc_OC_PE_CT = 'PE' " +
" ORDER BY 2, 11 "

            Dim con1 As New Odbc.OdbcCommand(qry4dInvAlmDesImp, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteInvAlmDesImp As New SqlCommand(delSqlInvAlmDesImp, conmssql)
            deleteInvAlmDesImp.ExecuteNonQuery()

            Dim insertInvAlmDesImp As New SqlCommand(intSqlInvAlmDesImp, conmssql)

            While reader.Read()
                insertInvAlmDesImp.Parameters.Clear()
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_TEMP_IMP_DESPACHO", reader("ID_TEMP_IMP_DESPACHO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_DESPACHO", reader("ID_DESPACHO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@FECHA_DESPACHO", reader("FECHA_DESPACHO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_PEDIDO", reader("ID_PEDIDO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@FECHA_PEDIDO", reader("FECHA_PEDIDO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_CLIENTE", reader("ID_CLIENTE"))
                insertInvAlmDesImp.Parameters.AddWithValue("@SOLICITANTE", reader("SOLICITANTE"))
                insertInvAlmDesImp.Parameters.AddWithValue("@CONFIRMADO", reader("CONFIRMADO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@DIRECCION_1", reader("DIRECCION_1"))
                insertInvAlmDesImp.Parameters.AddWithValue("@DIRECCION_2", reader("DIRECCION_2"))
                insertInvAlmDesImp.Parameters.AddWithValue("@NUM_LINEA", reader("NUM_LINEA"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_PRODUCTO", reader("ID_PRODUCTO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@NOMBRE_PRODUCTO", reader("NOMBRE_PRODUCTO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@CANTIDAD", reader("CANTIDAD"))
                insertInvAlmDesImp.Parameters.AddWithValue("@UM", reader("UM"))
                insertInvAlmDesImp.Parameters.AddWithValue("@MEMO", reader("MEMO"))
                insertInvAlmDesImp.ExecuteNonQuery()
            End While

            MsgBox("Información Despachos para impresión; exportada ", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

        con4d.Close()
        conmssql.Close()
    End Sub

    Sub insInvAlmDesImp(ByVal Despacho As String)
        Try
            con4d.Open()
            conmssql.Open()


            Dim qry4dInvAlmDesImp = " SELECT  CONCAT(CONCAT(INVT_Producto_Movimientos.ORIGIN_REF,'-'),INVT_Producto_Movimientos.Posicion) AS ID_TEMP_IMP_DESPACHO, " +
 " INVT_Producto_Movimientos.ORIGIN_REF AS ID_DESPACHO, " +
 " INVT_Producto_Movimientos.TRANS_DATE AS FECHA_DESPACHO, " +
 " INVT_Producto_Movimientos.NUMERO_PEDIDO_MBA AS ID_PEDIDO, " +
 " CLNT_Pedidos_Principal.FECHA_PEDIDO, " +
 " INVT_Producto_Movimientos.COD_CLIENTE AS ID_CLIENTE, " +
 " CLNT_Pedidos_Principal.Nombre_solicitante AS SOLICITANTE, " +
 " SUBSTRING(CLNT_Pedidos_Principal.Cerrado_Info, 21, 16)  AS CONFIRMADO, " +
 " CLNT_Pedidos_Principal.DESPACHO_DIR1 AS DIRECCION_1, " +
 " CLNT_Pedidos_Principal.DESPACHO_DIR2 AS DIRECCION_2, " +
 " INVT_Producto_Movimientos.Posicion AS NUM_LINEA, " +
 " INVT_Producto_Movimientos.PRODUCT_ID AS ID_PRODUCTO, " +
 " INVT_Producto_Movimientos.PRODUCT_NAME AS NOMBRE_PRODUCTO, " +
 " INVT_Producto_Movimientos.QUANTITY AS CANTIDAD, " +
 " INVT_Producto_Movimientos.UM, CLNT_Pedidos_Principal.MEMO " +
 " FROM     INVT_Producto_Movimientos , " +
 " CLNT_Pedidos_Principal " +
 " WHERE    INVT_Producto_Movimientos.NUMERO_PEDIDO_MBA=CLNT_Pedidos_Principal.CONTRATO_ID " +
 " AND      INVT_Producto_Movimientos.ADJUSTMENT_TYPE = 'RM' " +
 " AND CLNT_Pedidos_Principal.CORP = 'CIMSA' " +
 " AND CLNT_Pedidos_Principal.Tipo_Doc_OC_PE_CT = 'PE' " +
 " AND INVT_Producto_Movimientos.ORIGIN_REF ='" & Despacho & "' ORDER BY 2, 11 "

            Dim con1 As New Odbc.OdbcCommand(qry4dInvAlmDesImp, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deleteInvAlmDesImp As New SqlCommand(delSqlInvAlmDesImp, conmssql)
            deleteInvAlmDesImp.ExecuteNonQuery()

            Dim insertInvAlmDesImp As New SqlCommand(intSqlInvAlmDesImp, conmssql)

            While reader.Read()
                insertInvAlmDesImp.Parameters.Clear()
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_TEMP_IMP_DESPACHO", reader("ID_TEMP_IMP_DESPACHO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_DESPACHO", reader("ID_DESPACHO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@FECHA_DESPACHO", reader("FECHA_DESPACHO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_PEDIDO", reader("ID_PEDIDO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@FECHA_PEDIDO", reader("FECHA_PEDIDO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_CLIENTE", reader("ID_CLIENTE"))
                insertInvAlmDesImp.Parameters.AddWithValue("@SOLICITANTE", reader("SOLICITANTE"))
                insertInvAlmDesImp.Parameters.AddWithValue("@CONFIRMADO", reader("CONFIRMADO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@DIRECCION_1", reader("DIRECCION_1"))
                insertInvAlmDesImp.Parameters.AddWithValue("@DIRECCION_2", reader("DIRECCION_2"))
                insertInvAlmDesImp.Parameters.AddWithValue("@NUM_LINEA", reader("NUM_LINEA"))
                insertInvAlmDesImp.Parameters.AddWithValue("@ID_PRODUCTO", reader("ID_PRODUCTO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@NOMBRE_PRODUCTO", reader("NOMBRE_PRODUCTO"))
                insertInvAlmDesImp.Parameters.AddWithValue("@CANTIDAD", reader("CANTIDAD"))
                insertInvAlmDesImp.Parameters.AddWithValue("@UM", reader("UM"))
                insertInvAlmDesImp.Parameters.AddWithValue("@MEMO", reader("MEMO"))
                insertInvAlmDesImp.ExecuteNonQuery()
            End While

            MsgBox("Información Despachos para impresión; exportada " & qry4dInvAlmDesImp, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
