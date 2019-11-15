Imports System.Data
Imports System.Data.SqlClient
Public Class frmPreExp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExpPrePri.Click
        Dim export As New clsExpPre
        Try
            export.insPrePri()

        Catch ex As Exception
            MsgBox("Attention!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

        Me.Close()

        frmMenu.pnlContenedor.Enabled = True
        frmMenu.pnlMenus.Enabled = True

    End Sub

    Private Sub frmPreExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.btnExpPrePri.Image = imgDbSync
        Me.btnExpPrePri.ImageAlign = ContentAlignment.MiddleLeft

        Me.btnExpPreApli.Image = imgDbSync
        Me.btnExpPreApli.ImageAlign = ContentAlignment.MiddleLeft

        Me.btnExpPreReg.Image = imgRegresar
        Me.btnExpPreReg.ImageAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub btnExpPreReg_Click(sender As Object, e As EventArgs) Handles btnExpPreReg.Click

        Me.Close()

        frmMenu.pnlContenedor.Enabled = True
        frmMenu.pnlMenus.Enabled = True
    End Sub
End Class