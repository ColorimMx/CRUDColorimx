Public Class frmInvAlmDes

    Sub Exportar()

        Dim fechaIni As Date = btwnIni.Value
        Dim fechaFin As Date = btwnFin.Value
        Dim numDespacho As String = txtDespacho.Text
        Dim export As New clsExpInvAlmDesImp
        Dim FrmDesImp As New frmInvAlmDesImp

        If fechaIni > fechaFin Then

            MsgBox("Atención la fecha inicial no puede ser mayor a la fecha final!!! ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)


        ElseIf txtDespacho.Text = String.Empty Then
            frmMenu.pnlContenedor.Enabled = False
            frmMenu.pnlMenus.Enabled = False


            Try
                export.insInvAlmDesImpFecha(fechaIni, fechaFin)
            Catch ex As Exception
                MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

            frmMenu.pnlContenedor.Enabled = True
            frmMenu.pnlMenus.Enabled = True
            Me.Close()
            FrmDesImp.Show()
        Else
            frmMenu.pnlContenedor.Enabled = False
            frmMenu.pnlMenus.Enabled = False

            Try
                export.insInvAlmDesImp(numDespacho)
            Catch ex As Exception
                MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

            frmMenu.pnlContenedor.Enabled = True
            frmMenu.pnlMenus.Enabled = True
            Me.Close()
            FrmDesImp.Show()
        End If
    End Sub

    Public Sub btnExpDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpDespacho.Click

        Exportar()


    End Sub
    Private Sub frmInvAlmDes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle

        Dim thisDate As Date
        thisDate = Today
        Me.btwnIni.Value = Format(Now, "dd/MM/yyyy")
        Me.btwnFin.Value = Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub frmInvAlmDes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub btwnIni_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btwnIni.ValueChanged
        txtDespacho.Clear()
    End Sub

    Private Sub btwnFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btwnFin.ValueChanged
        txtDespacho.Clear()
    End Sub
End Class