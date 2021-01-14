Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmInvAlmDesImp

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim CR1 As New CRepDesImp
        Me.CrystalReportViewer1.ReportSource = CR1
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = odbcSqlUsr
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = odbcSqlPass
    End Sub
End Class