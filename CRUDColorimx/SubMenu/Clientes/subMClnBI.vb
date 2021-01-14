Module subMClnBI
    Public menuSub = "CLIENTES BUSINESS INTELLIGENCE"


    Public btnTxt1 = "Ventas"
    Public btnTxt2 = ""
    Public btnTxt3 = ""
    Public btnTxt4 = ""
    Public btnTxt5 = ""
    Public btnTxt6 = ""
    Public btnTxt7 = ""
    Public btnTxt8 = ""
    Public btnTxt9 = ""
    Public btnTxt10 = "Regresar"

    Public btnimg1 = imgClnt2
    Public btnimg2 = imgClnt2
    Public btnimg3 = imgClnt2
    Public btnimg4 = imgClnt2
    Public btnimg5 = imgClnt2
    Public btnimg6 = imgClnt2
    Public btnimg7 = imgClnt2
    Public btnimg8 = imgClnt2
    Public btnimg9 = imgClnt2
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
