Module modExpPre
    Public Sub expPre()

        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult

        Dim export As New clsExpPre
        Dim export2 As New clsExpPreApli
        Dim export3 As New clsExpPreAplDet
        Dim btnpre As New clsBtn7

        msg = "Deseas actulizar los datos a la fecha actual?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Exportar presupuesto"
        Response = MsgBox(msg, style, title)
        If Response = MsgBoxResult.Yes Then
            Try
                'export.insPrePri()
                export2.insPreApli()
                export3.insPreAplDet()
                'btnpre.presupuesto()
            Catch ex As Exception
                MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub
End Module
