﻿Module subMClnFac
    Public menuSub = "FACTURAS"

    Public btnTxt1 = "Exportar Datos Facturas"
    Public btnTxt2 = ""
    Public btnTxt3 = ""
    Public btnTxt4 = ""
    Public btnTxt5 = ""
    Public btnTxt6 = ""
    Public btnTxt7 = ""
    Public btnTxt8 = ""
    Public btnTxt9 = ""
    Public btnTxt10 = ""

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

        'frmMenu.btnProv.Enabled = True
        'frmMenu.btnInvt.Enabled = True
        'frmMenu.btnBanc.Enabled = True
        frmMenu.btnClie.Enabled = False
        'frmMenu.btnActF.Enabled = True
        'frmMenu.btnCont.Enabled = True

        frmSubMenu.Button1.Enabled = True
        frmSubMenu.Button2.Enabled = False
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
