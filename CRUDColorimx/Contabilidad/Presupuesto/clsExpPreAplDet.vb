Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpPreAplDet
    Sub insPreAplDet()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dPreAplDet, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deletePrePri As New SqlCommand(delSqlPreApliDet, conmssql)
            deletePrePri.ExecuteNonQuery()

            Dim insertPrePri As New SqlCommand(intSqlPreAplDet, conmssql)


            While reader.Read()
                insertPrePri.Parameters.Clear()
                insertPrePri.Parameters.AddWithValue("@ID_PRESUPUESTO", reader("ID_PRESUPUESTO"))
                insertPrePri.Parameters.AddWithValue("@ID_ASIENTO", reader("ID_ASIENTO"))
                insertPrePri.Parameters.AddWithValue("@NUM_ASIENTO", reader("NUM_ASIENTO"))
                insertPrePri.Parameters.AddWithValue("@FECHA_ASIENTO", reader("FECHA_ASIENTO"))
                insertPrePri.Parameters.AddWithValue("@ID_CUENTA", reader("ID_CUENTA"))
                insertPrePri.Parameters.AddWithValue("@DEBIT_AMOUNT", reader("DEBIT_AMOUNT"))
                insertPrePri.Parameters.AddWithValue("@CREDIT_AMOUNT", reader("CREDIT_AMOUNT"))
                insertPrePri.Parameters.AddWithValue("@TIPO", reader("TIPO"))
                insertPrePri.Parameters.AddWithValue("@ID_EMPRESA", reader("ID_EMPRESA"))
                insertPrePri.Parameters.AddWithValue("@MEMO", reader("MEMO"))
                insertPrePri.Parameters.AddWithValue("@MEMO_2", reader("MEMO_2"))
                insertPrePri.Parameters.AddWithValue("@ID_DEPARTAMENTO", reader("ID_DEPARTAMENTO"))
                insertPrePri.Parameters.AddWithValue("@ID_MONEDA", reader("ID_MONEDA"))
                insertPrePri.Parameters.AddWithValue("@ANIO", reader("ANIO"))
                insertPrePri.Parameters.AddWithValue("@MES", reader("MES"))
                insertPrePri.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertPrePri.ExecuteNonQuery()
            End While

            MsgBox("Información detalle de presupuesto; exportada", MsgBoxStyle.Information)
            frmPreExp.Close()

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
