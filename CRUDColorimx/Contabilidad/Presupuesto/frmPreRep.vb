﻿Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPreRep

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim CR1 As New cRepPres
        Dim CR2 As New CrepPresDepto

        If Module1.pre_com = True Then
            Me.CrystalReportViewer1.ReportSource = CR1
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = Module1.mssqlusr
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = Module1.mssqlpas
        Else
            Me.CrystalReportViewer1.ReportSource = CR2
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = Module1.mssqlusr
            Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = Module1.mssqlpas

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

    Private Sub frmPreRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class