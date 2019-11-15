Imports System.Data
Imports System.Data.SqlClient
Public Class frmPreVer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim DtF4D As New Odbc.OdbcDataAdapter(qry4dPrePri, con4d)
        Dim tFor4D As New DataTable()
        Try
            DtF4D.Fill(tFor4D)
            Me.dgrid4dPre.DataSource = tFor4D
            Me.dgrid4dPre.AutoResizeColumns()

            con4d.Close()

            Label1.Text = dgrid4dPre.RowCount()
        Catch ex As Exception
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DtFMmsql As New SqlDataAdapter(qrySqlPrePri, conmssql)
        Dim tForMmsql As New DataTable()

        Try
            DtFMmsql.Fill(tForMmsql)
            Me.dgridSqlPre.DataSource = tForMmsql
            Me.dgridSqlPre.AutoResizeColumns()

            conmssql.Close()

            Label2.Text = dgridSqlPre.RowCount()
        Catch ex As Exception
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
        


    End Sub
End Class