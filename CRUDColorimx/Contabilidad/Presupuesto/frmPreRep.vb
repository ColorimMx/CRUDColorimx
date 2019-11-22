Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPreRep

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim CR1 As New cRepPres
        Dim CR2 As New CrepPresDepto

        If Module1.pre_com = True Then
            Me.CrystalReportViewer1.ReportSource = CR1
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = "sa"
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = "Sql2008"
        Else
            Me.CrystalReportViewer1.ReportSource = CR2
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = "sa"
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = "Sql2008"

            Me.CrystalReportViewer1.EnableRefresh = False
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldDefinition As ParameterFieldDefinition
            Dim crParameterValues As New ParameterValues
            Dim crParameterDiscreteValue As New ParameterDiscreteValue

            crParameterDiscreteValue.Value = dptos
            crParameterFieldDefinitions = CR2.DataDefinition.ParameterFields()
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("Departamento")
            crParameterValues = crParameterFieldDefinition.CurrentValues
            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
        End If
    End Sub
End Class