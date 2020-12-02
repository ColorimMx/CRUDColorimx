Module subMClnCom
    Public menuSub = "COMISIONES VENDEDORES"

    Public btnTxt1 = "Tabla de Comisiones"
    Public btnTxt2 = "Comisiones Agente/Familia"
    Public btnTxt3 = "Comisiones Agente/Cliente"
    Public btnTxt4 = "Comisiones Agente/Tipo Cobro"
    Public btnTxt5 = ""
    Public btnTxt6 = ""
    Public btnTxt7 = ""
    Public btnTxt8 = ""
    Public btnTxt9 = "Siguiente"
    Public btnTxt10 = "Regresar"

    Public btnimg1 = imgClnt8
    Public btnimg2 = imgClnt8
    Public btnimg3 = imgClnt8
    Public btnimg4 = imgClnt8
    Public btnimg5 = imgClnt8
    Public btnimg6 = imgClnt8
    Public btnimg7 = imgClnt8
    Public btnimg8 = imgClnt8
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
