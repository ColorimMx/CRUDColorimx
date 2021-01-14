Public Class frmExcCliVtsZ

    Dim dataFac As New clsListFacView
    Private Sub frmExcCliVtsZ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dataFac.listaFac(DataView)
        Me.DataView.AutoResizeColumns()
    End Sub
End Class