Imports System.Data
Imports System.Data.SqlClient
Module mAcf
    Public menuSub = "Activo Fijo"

    Public btnTxt1 = "Activo Fijo"
    Public btnTxt2 = "Activo Fijo"
    Public btnTxt3 = "Activo Fijo"
    Public btnTxt4 = "Activo Fijo"
    Public btnTxt5 = "Activo Fijo"
    Public btnTxt6 = "Activo Fijo"
    Public btnTxt7 = "Activo Fijo"
    Public btnTxt8 = "Activo Fijo"
    Public btnTxt9 = "Opciones"
    Public btnTxt10 = ""

    Public btnimg1 = imgActi
    Public btnimg2 = imgActi
    Public btnimg3 = imgActi
    Public btnimg4 = imgActi
    Public btnimg5 = imgActi
    Public btnimg6 = imgActi
    Public btnimg7 = imgActi
    Public btnimg8 = imgActi
    Public btnimg9 = imgOpc
    Public btnimg10 = imgSalir

    Public fonImg = imgFActi

    Public btnColor = "#7c2bcb"

    Sub conf()


        frmMenu.titulo.Text = menuSub
        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID_USUARIO, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_ACTFIJO.ACTF_1, " +
"M_ACTFIJO.ACTF_2, M_ACTFIJO.ACTF_3, M_ACTFIJO.ACTF_4, M_ACTFIJO.ACTF_5, M_ACTFIJO.ACTF_6, M_ACTFIJO.ACTF_7, " +
"M_ACTFIJO.ACTF_8, M_ACTFIJO.ACTF_9 FROM USUARIOS INNER JOIN M_ACTFIJO ON USUARIOS.ID_USUARIO = M_ACTFIJO.ID_USUARIO " +
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
        Dim macf1 = table.Rows(0)(6).ToString()
        Dim macf2 = table.Rows(0)(7).ToString()
        Dim macf3 = table.Rows(0)(8).ToString()
        Dim macf4 = table.Rows(0)(9).ToString()
        Dim macf5 = table.Rows(0)(10).ToString()
        Dim macf6 = table.Rows(0)(11).ToString()
        Dim macf7 = table.Rows(0)(12).ToString()
        Dim macf8 = table.Rows(0)(13).ToString()
        Dim macf9 = table.Rows(0)(14).ToString()
        'Dim minv77 = table.Rows(0)(15).ToString()

        'Module1.pre_com = mcon77

        If macf1 = True Then
            frmSubMenu.Button1.Enabled = True
        Else
            frmSubMenu.Button1.Enabled = False
        End If

        If macf2 = True Then
            frmSubMenu.Button2.Enabled = True
        Else
            frmSubMenu.Button2.Enabled = False
        End If

        If macf3 = True Then
            frmSubMenu.Button3.Enabled = True
        Else
            frmSubMenu.Button3.Enabled = False
        End If

        If macf4 = True Then
            frmSubMenu.Button4.Enabled = True
        Else
            frmSubMenu.Button4.Enabled = False
        End If

        If macf5 = True Then
            frmSubMenu.Button5.Enabled = True
        Else
            frmSubMenu.Button5.Enabled = False
        End If

        If macf6 = True Then
            frmSubMenu.Button6.Enabled = True
        Else
            frmSubMenu.Button6.Enabled = False
        End If

        If macf7 = True Then
            frmSubMenu.Button7.Enabled = True
        Else
            frmSubMenu.Button7.Enabled = False
        End If

        If macf8 = True Then
            frmSubMenu.Button8.Enabled = True
        Else
            frmSubMenu.Button8.Enabled = False
        End If

        If macf9 = True Then
            frmSubMenu.Button9.Enabled = True
        Else
            frmSubMenu.Button9.Enabled = False
        End If
    End Sub
End Module
