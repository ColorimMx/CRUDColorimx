Public Class frmParCliVtsZ

    Private Sub frmParCliVtsZ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Width = 320
        Me.Height = 150

        dateIni.Value = Today()
        dateFin.Value = Today()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

        modClientes.dateFacIni = dateIni.Value.ToString("yyyy/MM/dd")
        modClientes.dateFacFin = dateFin.Value.ToString("yyyy/MM/dd")

        btnAceptar.Enabled = False
        btnCancel.Enabled = False

        Dim export As New clsExpFacPriPar
        Dim export2 As New clsExpFacDetPar

        Try
            export.insFacCliPar()
            export2.insFacDetPar()

        Catch ex As Exception
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
        btnAceptar.Enabled = True
        btnCancel.Enabled = True

        Me.Close()
        frmMenu.pnlContenedor.Enabled = True
        frmMenu.pnlMenus.Enabled = True

        Dim frmFact As New frmExcCliVtsZ
        frmFact.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        frmMenu.pnlContenedor.Enabled = True
        frmMenu.pnlMenus.Enabled = True
        Me.Close()
    End Sub
End Class