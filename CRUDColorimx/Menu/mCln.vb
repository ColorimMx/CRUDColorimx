Imports System.Data
Imports System.Data.SqlClient
Module mCln
    Public menuSub = "CLIENTES"

    Public btnTxt1 = "Clientes Ver/Editar"
    Public btnTxt2 = "Business Intelligence"
    Public btnTxt3 = "Reportes"
    Public btnTxt4 = "Clientes"
    Public btnTxt5 = "Clientes"
    Public btnTxt6 = "Facturas"
    Public btnTxt7 = "Clientes"
    Public btnTxt8 = "Clientes"
    Public btnTxt9 = "Opciones"
    Public btnTxt10 = ""

    Public btnimg1 = imgClie
    Public btnimg2 = imgClnt2
    Public btnimg3 = imgClnt3
    Public btnimg4 = imgClie
    Public btnimg5 = imgClie
    Public btnimg6 = imgClnt6
    Public btnimg7 = imgClie
    Public btnimg8 = imgClie
    Public btnimg9 = imgOpc
    Public btnimg10 = imgSalir

    Public fonImg = imgFClie

    Public btnColor = "#f9aa33"

    Sub conf()


        frmMenu.titulo.Text = menuSub
        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID_USUARIO, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_CLIENTES.CLNT_1, " +
"M_CLIENTES.CLNT_2, M_CLIENTES.CLNT_3, M_CLIENTES.CLNT_4, M_CLIENTES.CLNT_5, M_CLIENTES.CLNT_6, M_CLIENTES.CLNT_7, " +
"M_CLIENTES.CLNT_8, M_CLIENTES.CLNT_9 FROM USUARIOS INNER JOIN M_CLIENTES ON USUARIOS.ID_USUARIO = M_CLIENTES.ID_USUARIO " +
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
        Dim mcln1 = table.Rows(0)(6).ToString()
        Dim mcln2 = table.Rows(0)(7).ToString()
        Dim mcln3 = table.Rows(0)(8).ToString()
        Dim mcln4 = table.Rows(0)(9).ToString()
        Dim mcln5 = table.Rows(0)(10).ToString()
        Dim mcln6 = table.Rows(0)(11).ToString()
        Dim mcln7 = table.Rows(0)(12).ToString()
        Dim mcln8 = table.Rows(0)(13).ToString()
        Dim mcln9 = table.Rows(0)(14).ToString()
        'Dim mcln77 = table.Rows(0)(15).ToString()

        'Module1.pre_com = mcon77

        If mcln1 = True Then
            frmSubMenu.Button1.Enabled = True
        Else
            frmSubMenu.Button1.Enabled = False
        End If

        If mcln2 = True Then
            frmSubMenu.Button2.Enabled = True
        Else
            frmSubMenu.Button2.Enabled = False
        End If

        If mcln3 = True Then
            frmSubMenu.Button3.Enabled = True
        Else
            frmSubMenu.Button3.Enabled = False
        End If

        If mcln4 = True Then
            frmSubMenu.Button4.Enabled = True
        Else
            frmSubMenu.Button4.Enabled = False
        End If

        If mcln5 = True Then
            frmSubMenu.Button5.Enabled = True
        Else
            frmSubMenu.Button5.Enabled = False
        End If

        If mcln6 = True Then
            frmSubMenu.Button6.Enabled = True
        Else
            frmSubMenu.Button6.Enabled = False
        End If

        If mcln7 = True Then
            frmSubMenu.Button7.Enabled = True
        Else
            frmSubMenu.Button7.Enabled = False
        End If

        If mcln8 = True Then
            frmSubMenu.Button8.Enabled = True
        Else
            frmSubMenu.Button8.Enabled = False
        End If

        If mcln9 = True Then
            frmSubMenu.Button9.Enabled = True
        Else
            frmSubMenu.Button9.Enabled = False
        End If


    End Sub
End Module
