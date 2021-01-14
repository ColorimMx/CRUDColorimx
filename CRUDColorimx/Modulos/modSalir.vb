Module modSalir
    Public Sub closeapp()
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult
        msg = "Esta seguro que desea salir?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Salir"
        Response = MsgBox(msg, style, title)
        If Response = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
End Module
