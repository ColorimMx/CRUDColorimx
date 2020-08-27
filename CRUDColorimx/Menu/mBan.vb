Imports System.Data
Imports System.Data.SqlClient
Module mBan
    Public menuSub = "BANCOS"

    Public btnTxt1 = "Bancos"
    Public btnTxt2 = "Bancos"
    Public btnTxt3 = "Bancos"
    Public btnTxt4 = "Bancos"
    Public btnTxt5 = "Bancos"
    Public btnTxt6 = "Bancos"
    Public btnTxt7 = "Bancos"
    Public btnTxt8 = "Bancos"
    Public btnTxt9 = "Opciones"
    Public btnTxt10 = ""

    Public btnimg1 = imgBanc
    Public btnimg2 = imgBanc
    Public btnimg3 = imgBanc
    Public btnimg4 = imgBanc
    Public btnimg5 = imgBanc
    Public btnimg6 = imgBanc
    Public btnimg7 = imgBanc
    Public btnimg8 = imgBanc
    Public btnimg9 = imgOpc
    Public btnimg10 = imgSalir

    Public fonImg = imgFProv

    Public btnColor = "#f73526"

    Sub conf()


        frmMenu.titulo.Text = menuSub
        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID_USUARIO, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_BANCOS.BANC_1, " +
"M_BANCOS.BANC_2, M_BANCOS.BANC_3, M_BANCOS.BANC_4, M_BANCOS.BANC_5, M_BANCOS.BANC_6, M_BANCOS.BANC_7, " +
"M_BANCOS.BANC_8, M_BANCOS.BANC_9 FROM USUARIOS INNER JOIN M_BANCOS ON USUARIOS.ID_USUARIO = M_BANCOS.ID_USUARIO " +
"WHERE USUARIO = @usuario", conexion)

        menus.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Module1.nombre


        Dim adapMenus As New SqlDataAdapter(menus)
        Dim table As New DataTable()
        adapMenus.Fill(table)

        '********************************************************************************************************

        'Asignacion Variables a tablas Menus
        Dim nombre = table.Rows(0)(1).ToString()
        Dim apellido_p = table.Rows(0)(2).ToString()
        Dim apellido_m = table.Rows(0)(3).ToString()
        Dim acceso = table.Rows(0)(5).ToString()
        Dim mban1 = table.Rows(0)(6).ToString()
        Dim mban2 = table.Rows(0)(7).ToString()
        Dim mban3 = table.Rows(0)(8).ToString()
        Dim mban4 = table.Rows(0)(9).ToString()
        Dim mban5 = table.Rows(0)(10).ToString()
        Dim mban6 = table.Rows(0)(11).ToString()
        Dim mban7 = table.Rows(0)(12).ToString()
        Dim mban8 = table.Rows(0)(13).ToString()
        Dim mban9 = table.Rows(0)(14).ToString()
        'Dim minv77 = table.Rows(0)(15).ToString()

        'Module1.pre_com = mcon77

        If mban1 = True Then
            frmSubMenu.Button1.Enabled = True
        Else
            frmSubMenu.Button1.Enabled = False
        End If

        If mban2 = True Then
            frmSubMenu.Button2.Enabled = True
        Else
            frmSubMenu.Button2.Enabled = False
        End If

        If mban3 = True Then
            frmSubMenu.Button3.Enabled = True
        Else
            frmSubMenu.Button3.Enabled = False
        End If

        If mban4 = True Then
            frmSubMenu.Button4.Enabled = True
        Else
            frmSubMenu.Button4.Enabled = False
        End If

        If mban5 = True Then
            frmSubMenu.Button5.Enabled = True
        Else
            frmSubMenu.Button5.Enabled = False
        End If

        If mban6 = True Then
            frmSubMenu.Button6.Enabled = True
        Else
            frmSubMenu.Button6.Enabled = False
        End If

        If mban7 = True Then
            frmSubMenu.Button7.Enabled = True
        Else
            frmSubMenu.Button7.Enabled = False
        End If

        If mban8 = True Then
            frmSubMenu.Button8.Enabled = True
        Else
            frmSubMenu.Button8.Enabled = False
        End If

        If mban9 = True Then
            frmSubMenu.Button9.Enabled = True
        Else
            frmSubMenu.Button9.Enabled = False
        End If
    End Sub
End Module
