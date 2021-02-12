Public Module subMPre

    Public menuSub = "PRESUPUESTO"

    Public btnTxt1 = "Exportar Configuracion Presupuesto"
    Public btnTxt2 = "Exportar Resumen Aplicación"
    Public btnTxt3 = "Exportar Detalle Aplicación"
    Public btnTxt4 = "Ver Registros Presupuesto"
    Public btnTxt5 = "Ver Registros Resumen Aplicación"
    Public btnTxt6 = "Ver Registros Detalle Aplicación"
    Public btnTxt7 = "Análisis Presupuesto"
    Public btnTxt8 = ""
    Public btnTxt9 = ""
    Public btnTxt10 = "Regresar"

    Public btnimg1 = imgDbSync
    Public btnimg2 = imgDbSync
    Public btnimg3 = imgDbSync
    Public btnimg4 = imgView
    Public btnimg5 = imgView
    Public btnimg6 = imgView
    Public btnimg7 = imgPreDpt
    Public btnimg8 = imgCont7
    Public btnimg9 = imgCont7
    Public btnimg10 = imgRegresar

    Public fonImg = imgFCont
    Public btnColor = "#7c2bcb"

    Sub conf()
        frmMenu.titulo.Text = menuSub
        frmMenu.btnCont.Enabled = False
    End Sub

End Module
