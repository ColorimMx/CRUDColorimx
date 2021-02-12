Module subInvAlm
    Public menuSub = "ALMACENES"

    Public btnTxt1 = "Recepción de Mercadería"
    Public btnTxt2 = "Egresos"
    Public btnTxt3 = "Remisiones"
    Public btnTxt4 = "Guías de Transporte"
    Public btnTxt5 = "Conteo Físico"
    Public btnTxt6 = "Transferencias de Almacenes"
    Public btnTxt7 = "Despachos"
    Public btnTxt8 = "Pedidos Internos"
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

    Public fonImg = imgFInvt
    Public btnColor = "#045D56"

    Sub conf()

        frmMenu.titulo.Text = menuSub

        'frmMenu.btnProv.Enabled = True
        frmMenu.btnInvt.Enabled = False
        'frmMenu.btnBanc.Enabled = True
        'frmMenu.btnClie.Enabled = True
        'frmMenu.btnActF.Enabled = True
        'frmMenu.btnCont.Enabled = True

        frmSubMenu.Button1.Enabled = False
        frmSubMenu.Button2.Enabled = False
        frmSubMenu.Button3.Enabled = False
        frmSubMenu.Button4.Enabled = False
        frmSubMenu.Button5.Enabled = False
        frmSubMenu.Button6.Enabled = False
        frmSubMenu.Button7.Enabled = True
        frmSubMenu.Button8.Enabled = False
        frmSubMenu.Button9.Enabled = False
        frmSubMenu.Button10.Enabled = True
    End Sub
End Module
