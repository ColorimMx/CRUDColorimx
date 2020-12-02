Imports System.Data
Imports System.Data.SqlClient
Module mAdm
    Public menuSub = "Administrador"

    Public btnTxt1 = "Usuarios"
    Public btnTxt2 = "Administrador"
    Public btnTxt3 = "Administrador"
    Public btnTxt4 = "Administrador"
    Public btnTxt5 = "Administrador"
    Public btnTxt6 = "Administrador"
    Public btnTxt7 = "Administrador"
    Public btnTxt8 = "Administrador"
    Public btnTxt9 = "Opciones"
    Public btnTxt10 = ""

    Public btnimg1 = imgAdmi
    Public btnimg2 = imgAdmi
    Public btnimg3 = imgAdmi
    Public btnimg4 = imgAdmi
    Public btnimg5 = imgAdmi
    Public btnimg6 = imgAdmi
    Public btnimg7 = imgAdmi
    Public btnimg8 = imgAdmi
    Public btnimg9 = imgOpc
    Public btnimg10 = imgSalir

    Public fonImg = imgFAdmi

    Public btnColor = "#f05545"

    Sub conf()


        frmMenu.titulo.Text = menuSub
        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID_USUARIO, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_ADMINISTRADOR.ADMI_1, " +
"M_ADMINISTRADOR.ADMI_2, M_ADMINISTRADOR.ADMI_3, M_ADMINISTRADOR.ADMI_4, M_ADMINISTRADOR.ADMI_5, M_ADMINISTRADOR.ADMI_6, M_ADMINISTRADOR.ADMI_7, " +
"M_ADMINISTRADOR.ADMI_8, M_ADMINISTRADOR.ADMI_9 FROM USUARIOS INNER JOIN M_ADMINISTRADOR ON USUARIOS.ID_USUARIO = M_ADMINISTRADOR.ID_USUARIO " +
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
        Dim madm1 = table.Rows(0)(6).ToString()
        Dim madm2 = table.Rows(0)(7).ToString()
        Dim madm3 = table.Rows(0)(8).ToString()
        Dim madm4 = table.Rows(0)(9).ToString()
        Dim madm5 = table.Rows(0)(10).ToString()
        Dim madm6 = table.Rows(0)(11).ToString()
        Dim madm7 = table.Rows(0)(12).ToString()
        Dim madm8 = table.Rows(0)(13).ToString()
        Dim madm9 = table.Rows(0)(14).ToString()
        'Dim minv77 = table.Rows(0)(15).ToString()

        'Module1.pre_com = mcon77

        If madm1 = True Then
            frmSubMenu.Button1.Enabled = True
        Else
            frmSubMenu.Button1.Enabled = False
        End If

        If madm2 = True Then
            frmSubMenu.Button2.Enabled = True
        Else
            frmSubMenu.Button2.Enabled = False
        End If

        If madm3 = True Then
            frmSubMenu.Button3.Enabled = True
        Else
            frmSubMenu.Button3.Enabled = False
        End If

        If madm4 = True Then
            frmSubMenu.Button4.Enabled = True
        Else
            frmSubMenu.Button4.Enabled = False
        End If

        If madm5 = True Then
            frmSubMenu.Button5.Enabled = True
        Else
            frmSubMenu.Button5.Enabled = False
        End If

        If madm6 = True Then
            frmSubMenu.Button6.Enabled = True
        Else
            frmSubMenu.Button6.Enabled = False
        End If

        If madm7 = True Then
            frmSubMenu.Button7.Enabled = True
        Else
            frmSubMenu.Button7.Enabled = False
        End If

        If madm8 = True Then
            frmSubMenu.Button8.Enabled = True
        Else
            frmSubMenu.Button8.Enabled = False
        End If

        If madm9 = True Then
            frmSubMenu.Button9.Enabled = True
        Else
            frmSubMenu.Button9.Enabled = False
        End If
    End Sub
End Module
