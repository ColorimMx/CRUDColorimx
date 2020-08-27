Imports System.Data
Imports System.Data.SqlClient
Module mInv
    Public menuSub = "INVENTARIO"

    Public btnTxt1 = "Inventario"
    Public btnTxt2 = "Inventario"
    Public btnTxt3 = "Inventario"
    Public btnTxt4 = "Producción"
    Public btnTxt5 = "Inventario"
    Public btnTxt6 = "Inventario"
    Public btnTxt7 = "Inventario"
    Public btnTxt8 = "Inventario"
    Public btnTxt9 = "Opciones"
    Public btnTxt10 = ""

    Public btnimg1 = imgInvt
    Public btnimg2 = imgInvt
    Public btnimg3 = imgInvt
    Public btnimg4 = imgInvt
    Public btnimg5 = imgInvt
    Public btnimg6 = imgInvt
    Public btnimg7 = imgInvt
    Public btnimg8 = imgInvt
    Public btnimg9 = imgOpc
    Public btnimg10 = imgSalir

    Public fonImg = imgFInvt

    Public btnColor = "#045D56"

    Sub conf()


        frmMenu.titulo.Text = menuSub
        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID_USUARIO, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_INVENTARIO.INVT_1, " +
"M_INVENTARIO.INVT_2, M_INVENTARIO.INVT_3, M_INVENTARIO.INVT_4, M_INVENTARIO.INVT_5, M_INVENTARIO.INVT_6, M_INVENTARIO.INVT_7, " +
"M_INVENTARIO.INVT_8, M_INVENTARIO.INVT_9 FROM USUARIOS INNER JOIN M_INVENTARIO ON USUARIOS.ID_USUARIO = M_INVENTARIO.ID_USUARIO " +
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
        Dim minv1 = table.Rows(0)(6).ToString()
        Dim minv2 = table.Rows(0)(7).ToString()
        Dim minv3 = table.Rows(0)(8).ToString()
        Dim minv4 = table.Rows(0)(9).ToString()
        Dim minv5 = table.Rows(0)(10).ToString()
        Dim minv6 = table.Rows(0)(11).ToString()
        Dim minv7 = table.Rows(0)(12).ToString()
        Dim minv8 = table.Rows(0)(13).ToString()
        Dim minv9 = table.Rows(0)(14).ToString()
        'Dim minv77 = table.Rows(0)(15).ToString()

        'Module1.pre_com = mcon77

        If minv1 = True Then
            frmSubMenu.Button1.Enabled = True
        Else
            frmSubMenu.Button1.Enabled = False
        End If

        If minv2 = True Then
            frmSubMenu.Button2.Enabled = True
        Else
            frmSubMenu.Button2.Enabled = False
        End If

        If minv3 = True Then
            frmSubMenu.Button3.Enabled = True
        Else
            frmSubMenu.Button3.Enabled = False
        End If

        If minv4 = True Then
            frmSubMenu.Button4.Enabled = True
        Else
            frmSubMenu.Button4.Enabled = False
        End If

        If minv5 = True Then
            frmSubMenu.Button5.Enabled = True
        Else
            frmSubMenu.Button5.Enabled = False
        End If

        If minv6 = True Then
            frmSubMenu.Button6.Enabled = True
        Else
            frmSubMenu.Button6.Enabled = False
        End If

        If minv7 = True Then
            frmSubMenu.Button7.Enabled = True
        Else
            frmSubMenu.Button7.Enabled = False
        End If

        If minv8 = True Then
            frmSubMenu.Button8.Enabled = True
        Else
            frmSubMenu.Button8.Enabled = False
        End If

        If minv9 = True Then
            frmSubMenu.Button9.Enabled = True
        Else
            frmSubMenu.Button9.Enabled = False
        End If


    End Sub
End Module
