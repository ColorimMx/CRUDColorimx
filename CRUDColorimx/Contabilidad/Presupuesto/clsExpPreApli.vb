Imports System.Data
Imports System.Data.SqlClient
Public Class clsExpPreApli
    Sub insPreApli()
        Try
            con4d.Open()
            conmssql.Open()

            Dim con1 As New Odbc.OdbcCommand(qry4dPreApli, con4d)
            Dim reader As Odbc.OdbcDataReader = con1.ExecuteReader

            Dim deletePrePri As New SqlCommand(delSqlPreApli, conmssql)
            deletePrePri.ExecuteNonQuery()

            Dim insertPrePri As New SqlCommand(intSqlPreApli, conmssql)


            While reader.Read()
                insertPrePri.Parameters.Clear()
                insertPrePri.Parameters.AddWithValue("@ID_PRESUPUESTO", reader("ID_PRESUPUESTO"))
                insertPrePri.Parameters.AddWithValue("@ID_CUENTA", reader("ID_CUENTA"))
                insertPrePri.Parameters.AddWithValue("@ID_DEPARTAMENTO", reader("ID_DEPARTAMENTO"))
                insertPrePri.Parameters.AddWithValue("@ID_EMPRESA", reader("ID_EMPRESA"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_ENERO", reader("APLICACION_ENERO"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_FEBRERO", reader("APLICACION_FEBRERO"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_MARZO", reader("APLICACION_MARZO"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_ABRIL", reader("APLICACION_ABRIL"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_MAYO", reader("APLICACION_MAYO"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_JUNIO", reader("APLICACION_JUNIO"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_JULIO", reader("APLICACION_JULIO"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_AGOSTO", reader("APLICACION_AGOSTO"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_SEPTIEMBRE", reader("APLICACION_SEPTIEMBRE"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_OCTUBRE", reader("APLICACION_OCTUBRE"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_NOVIEMBRE", reader("APLICACION_NOVIEMBRE"))
                insertPrePri.Parameters.AddWithValue("@APLICACION_DICIEMBRE", reader("APLICACION_DICIEMBRE"))
                insertPrePri.Parameters.AddWithValue("@FECHA_MOD", reader("FECHA_MOD"))
                insertPrePri.ExecuteNonQuery()
            End While

            MsgBox("Información resumen de presupuesto; exportada", MsgBoxStyle.Information)
            frmPreExp.Close()

        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        End Try

        con4d.Close()
        conmssql.Close()
    End Sub
End Class
