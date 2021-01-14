Module subMClnPri2
    Public menuSub = "CLIENTES VER/EDITAR 2"

    Public btnTxt1 = "Exportar Datos Estados"
    Public btnTxt2 = "Ver Registros Estados"
    Public btnTxt3 = "Exportar Datos Zonas"
    Public btnTxt4 = "Ver Registros Zonas"
    Public btnTxt5 = ""
    Public btnTxt6 = ""
    Public btnTxt7 = ""
    Public btnTxt8 = ""
    Public btnTxt9 = ""
    Public btnTxt10 = "Regresar"

    Public btnimg1 = imgDbSync
    Public btnimg2 = imgView
    Public btnimg3 = imgDbSync
    Public btnimg4 = imgView
    Public btnimg5 = imgClie
    Public btnimg6 = imgClie
    Public btnimg7 = imgClie
    Public btnimg8 = imgClie
    Public btnimg9 = imgClie
    Public btnimg10 = imgRegresar

    Public fonImg = imgFClie
    Public btnColor = "#f9aa33"

    Sub conf()

        frmMenu.titulo.Text = menuSub

        'frmMenu.btnProv.Enabled = True
        'frmMenu.btnInvt.Enabled = True
        'frmMenu.btnBanc.Enabled = True
        frmMenu.btnClie.Enabled = False
        'frmMenu.btnActF.Enabled = True
        'frmMenu.btnCont.Enabled = True

        frmSubMenu.Button1.Enabled = True
        frmSubMenu.Button2.Enabled = True
        frmSubMenu.Button3.Enabled = True
        frmSubMenu.Button4.Enabled = True
        frmSubMenu.Button5.Enabled = False
        frmSubMenu.Button6.Enabled = False
        frmSubMenu.Button7.Enabled = False
        frmSubMenu.Button8.Enabled = False
        frmSubMenu.Button9.Enabled = False
        frmSubMenu.Button10.Enabled = True
    End Sub
End Module
