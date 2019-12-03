Module subMCue
    Public menuSub = "PLAN DE CUENTAS"

    Public btnTxt1 = "Exportar Configuracion Cuentas"
    Public btnTxt2 = "Ver Registros Cuentas"
    Public btnTxt3 = ""
    Public btnTxt4 = ""
    Public btnTxt5 = ""
    Public btnTxt6 = ""
    Public btnTxt7 = ""
    Public btnTxt8 = ""
    Public btnTxt9 = ""
    Public btnTxt10 = "Regresar"

    Public btnimg1 = imgDbSync
    Public btnimg2 = imgView
    Public btnimg3 = imgCont1
    Public btnimg4 = imgCont1
    Public btnimg5 = imgCont1
    Public btnimg6 = imgCont1
    Public btnimg7 = imgCont1
    Public btnimg8 = imgCont1
    Public btnimg9 = imgCont1
    Public btnimg10 = imgRegresar

    Public fonImg = imgFCont
    Public btnColor = "#b15dfF"

    Sub conf()

        frmMenu.titulo.Text = menuSub

        frmMenu.btnProv.Enabled = True
        frmMenu.btnInvt.Enabled = True
        frmMenu.btnBanc.Enabled = True
        frmMenu.btnClie.Enabled = True
        frmMenu.btnActF.Enabled = True
        frmMenu.btnCont.Enabled = False

        frmSubMenu.Button1.Enabled = True
        frmSubMenu.Button2.Enabled = True
        frmSubMenu.Button3.Enabled = False
        frmSubMenu.Button4.Enabled = False
        frmSubMenu.Button5.Enabled = False
        frmSubMenu.Button6.Enabled = False
        frmSubMenu.Button7.Enabled = False
        frmSubMenu.Button8.Enabled = False
        frmSubMenu.Button9.Enabled = False
        frmSubMenu.Button10.Enabled = True
    End Sub
End Module
