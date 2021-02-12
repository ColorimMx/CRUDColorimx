Imports System.Data
Imports System.Data.SqlClient
Module mPrv
    Public menuSub = "PROVEEDORES"

    Public btnTxt1 = "Proveedores"
    Public btnTxt2 = "Proveedores"
    Public btnTxt3 = "Proveedores"
    Public btnTxt4 = "Proveedores"
    Public btnTxt5 = "Proveedores"
    Public btnTxt6 = "Proveedores"
    Public btnTxt7 = "Proveedores"
    Public btnTxt8 = "Proveedores"
    Public btnTxt9 = "Opciones"
    Public btnTxt10 = ""

    Public btnimg1 = imgProv
    Public btnimg2 = imgProv
    Public btnimg3 = imgProv
    Public btnimg4 = imgProv
    Public btnimg5 = imgProv
    Public btnimg6 = imgProv
    Public btnimg7 = imgProv
    Public btnimg8 = imgProv
    Public btnimg9 = imgOpc
    Public btnimg10 = imgSalir

    Public fonImg = imgFProv

    Public btnColor = "#1EB980"

    Sub conf()


        frmMenu.titulo.Text = menuSub
        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID_USUARIO, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_PROVEEDORES.PROV_1, " +
"M_PROVEEDORES.PROV_2, M_PROVEEDORES.PROV_3, M_PROVEEDORES.PROV_4, M_PROVEEDORES.PROV_5, M_PROVEEDORES.PROV_6, M_PROVEEDORES.PROV_7, " +
"M_PROVEEDORES.PROV_8, M_PROVEEDORES.PROV_9 FROM USUARIOS INNER JOIN M_PROVEEDORES ON USUARIOS.ID_USUARIO = M_PROVEEDORES.ID_USUARIO " +
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
        Dim mprv1 = table.Rows(0)(6).ToString()
        Dim mprv2 = table.Rows(0)(7).ToString()
        Dim mprv3 = table.Rows(0)(8).ToString()
        Dim mprv4 = table.Rows(0)(9).ToString()
        Dim mprv5 = table.Rows(0)(10).ToString()
        Dim mprv6 = table.Rows(0)(11).ToString()
        Dim mprv7 = table.Rows(0)(12).ToString()
        Dim mprv8 = table.Rows(0)(13).ToString()
        Dim mprv9 = table.Rows(0)(14).ToString()
        'Dim minv77 = table.Rows(0)(15).ToString()

        'Module1.pre_com = mcon77

        If mprv1 = True Then
            frmSubMenu.Button1.Enabled = True
        Else
            frmSubMenu.Button1.Enabled = False
        End If

        If mprv2 = True Then
            frmSubMenu.Button2.Enabled = True
        Else
            frmSubMenu.Button2.Enabled = False
        End If

        If mprv3 = True Then
            frmSubMenu.Button3.Enabled = True
        Else
            frmSubMenu.Button3.Enabled = False
        End If

        If mprv4 = True Then
            frmSubMenu.Button4.Enabled = True
        Else
            frmSubMenu.Button4.Enabled = False
        End If

        If mprv5 = True Then
            frmSubMenu.Button5.Enabled = True
        Else
            frmSubMenu.Button5.Enabled = False
        End If

        If mprv6 = True Then
            frmSubMenu.Button6.Enabled = True
        Else
            frmSubMenu.Button6.Enabled = False
        End If

        If mprv7 = True Then
            frmSubMenu.Button7.Enabled = True
        Else
            frmSubMenu.Button7.Enabled = False
        End If

        If mprv8 = True Then
            frmSubMenu.Button8.Enabled = True
        Else
            frmSubMenu.Button8.Enabled = False
        End If

        If mprv9 = True Then
            frmSubMenu.Button9.Enabled = True
        Else
            frmSubMenu.Button9.Enabled = False
        End If
    End Sub

End Module
