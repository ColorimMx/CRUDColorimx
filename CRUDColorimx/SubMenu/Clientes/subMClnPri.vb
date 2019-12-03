Module subMClnPri
    Public menuSub = "CLIENTES VER/EDITAR"

    Public btnTxt1 = "Exportar Datos Clientes"
    Public btnTxt2 = "Ver Registros Clientes principal"
    Public btnTxt3 = "Exportar Datos Giros"
    Public btnTxt4 = "Ver Registros Giros"
    Public btnTxt5 = "Exportar Datos Tipo"
    Public btnTxt6 = "Ver Registros Tipo"
    Public btnTxt7 = "Exportar Datos Ciudades"
    Public btnTxt8 = "Ver Registros Ciudades"
    Public btnTxt9 = "Siguiente"
    Public btnTxt10 = "Regresar"

    Public btnimg1 = imgDbSync
    Public btnimg2 = imgView
    Public btnimg3 = imgDbSync
    Public btnimg4 = imgView
    Public btnimg5 = imgDbSync
    Public btnimg6 = imgView
    Public btnimg7 = imgDbSync
    Public btnimg8 = imgView
    Public btnimg9 = imgSiguiente
    Public btnimg10 = imgRegresar

    Public fonImg = imgFClie
    Public btnColor = "#f9aa33"

    Sub conf()

        frmMenu.titulo.Text = menuSub

        frmMenu.btnProv.Enabled = True
        frmMenu.btnInvt.Enabled = True
        frmMenu.btnBanc.Enabled = True
        frmMenu.btnClie.Enabled = False
        frmMenu.btnActF.Enabled = True
        frmMenu.btnCont.Enabled = True

        frmSubMenu.Button1.Enabled = True
        frmSubMenu.Button2.Enabled = True
        frmSubMenu.Button3.Enabled = True
        frmSubMenu.Button4.Enabled = True
        frmSubMenu.Button5.Enabled = True
        frmSubMenu.Button6.Enabled = True
        frmSubMenu.Button7.Enabled = True
        frmSubMenu.Button8.Enabled = True
        frmSubMenu.Button9.Enabled = True
        frmSubMenu.Button10.Enabled = True
    End Sub
End Module
