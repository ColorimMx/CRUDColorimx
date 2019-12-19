Imports System.Data
Imports System.Data.SqlClient

Public Class clsListFacView
    Dim qry As String = "SELECT * FROM View_Facturas;"

    Sub listaFac(ByVal tabla As DataGridView)
        Try
            Dim dtFac As New SqlDataAdapter(qry, conmssql)
            Dim tabFac As New DataTable()
            dtFac.Fill(tabFac)
            tabla.DataSource = tabFac
        Catch ex As Exception
            MsgBox("No se completó la consulta debiado a: " & ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
        conmssql.Close()
    End Sub
End Class
