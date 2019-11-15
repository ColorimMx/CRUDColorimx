Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpPre
    Sub insPrePri()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dPrePri, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deletePrePri As New SqlCommand(delSqlPrePri, conmssql)
            deletePrePri.ExecuteNonQuery()

            Dim insertPrePri As New SqlCommand(intSqlPrePri, conmssql)


            While reader.Read()
                insertPrePri.Parameters.Clear()
                insertPrePri.Parameters.AddWithValue("@ID_PRESUPUESTO", reader("ID_PRESUPUESTO"))
                insertPrePri.Parameters.AddWithValue("@ID_CUENTA", reader("ID_CUENTA"))
                insertPrePri.Parameters.AddWithValue("@ID_DEPARTAMENTO", reader("ID_DEPARTAMENTO"))
                insertPrePri.Parameters.AddWithValue("@ID_EMPRESA", reader("ID_EMPRESA"))
                insertPrePri.Parameters.AddWithValue("@NOMBRE_CUENTA_CONTABLE", reader("NOMBRE_CUENTA_CONTABLE"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_ENERO", reader("PRESUPUESTO_ENERO"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_FEBRERO", reader("PRESUPUESTO_FEBRERO"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_MARZO", reader("PRESUPUESTO_MARZO"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_ABRIL", reader("PRESUPUESTO_ABRIL"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_MAYO", reader("PRESUPUESTO_MAYO"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_JUNIO", reader("PRESUPUESTO_JUNIO"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_JULIO", reader("PRESUPUESTO_JULIO"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_AGOSTO", reader("PRESUPUESTO_AGOSTO"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_SEPTIEMBRE", reader("PRESUPUESTO_SEPTIEMBRE"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_OCTUBRE", reader("PRESUPUESTO_OCTUBRE"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_NOVIEMBRE", reader("PRESUPUESTO_NOVIEMBRE"))
                insertPrePri.Parameters.AddWithValue("@PRESUPUESTO_DICIEMBRE", reader("PRESUPUESTO_DICIEMBRE"))
                insertPrePri.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertPrePri.ExecuteNonQuery()
            End While

            MsgBox("Información configuración de presupuesto; exportada", MsgBoxStyle.Information)

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub

End Class
