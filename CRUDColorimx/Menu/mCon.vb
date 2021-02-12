Imports System.Data
Imports System.Data.SqlClient
Public Module mCon

    Public menuSub = "CONTABILIDAD"

    Public btnTxt1 = "Plan de Cuentas"
    Public btnTxt2 = "Diario Asientos"
    Public btnTxt3 = "Reportes"
    Public btnTxt4 = "Estados Financieros"
    Public btnTxt5 = "Fiscal"
    Public btnTxt6 = "Consultas Avanzadas"
    Public btnTxt7 = "Presupuesto Contable"
    Public btnTxt8 = "Analisis Cuenta"
    Public btnTxt9 = "Opciones"
    Public btnTxt10 = ""

    Public btnimg1 = imgCont1
    Public btnimg2 = imgCont2
    Public btnimg3 = imgCont3
    Public btnimg4 = imgCont4
    Public btnimg5 = imgCont5
    Public btnimg6 = imgCont6
    Public btnimg7 = imgCont7
    Public btnimg8 = imgCont8
    Public btnimg9 = imgOpc
    Public btnimg10 = imgSalir

    Public fonImg = imgFCont

    Public btnColor = "#7c2bcb"

    Sub conf()


        frmMenu.titulo.Text = menuSub
        Dim conexion As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")
        Dim menus As New SqlCommand("SELECT USUARIOS.ID_USUARIO, USUARIOS.NOMBRE, USUARIOS.APELLIDO_P, USUARIOS.APELLIDO_M, USUARIOS.USUARIO, USUARIOS.ACCESO, M_CONTABILIDAD.CONT_1, " +
"M_CONTABILIDAD.CONT_2, M_CONTABILIDAD.CONT_3, M_CONTABILIDAD.CONT_4, M_CONTABILIDAD.CONT_5, M_CONTABILIDAD.CONT_6, M_CONTABILIDAD.CONT_7, " +
"M_CONTABILIDAD.CONT_8, M_CONTABILIDAD.CONT_9,M_CONTABILIDAD.CONT_7_7 FROM USUARIOS INNER JOIN M_CONTABILIDAD ON USUARIOS.ID_USUARIO = M_CONTABILIDAD.ID_USUARIO " +
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
        Dim mcon1 = table.Rows(0)(6).ToString()
        Dim mcon2 = table.Rows(0)(7).ToString()
        Dim mcon3 = table.Rows(0)(8).ToString()
        Dim mcon4 = table.Rows(0)(9).ToString()
        Dim mcon5 = table.Rows(0)(10).ToString()
        Dim mcon6 = table.Rows(0)(11).ToString()
        Dim mcon7 = table.Rows(0)(12).ToString()
        Dim mcon8 = table.Rows(0)(13).ToString()
        Dim mcon9 = table.Rows(0)(14).ToString()
        Dim mcon77 = table.Rows(0)(15).ToString()

        Module1.pre_com = mcon77

        If mcon1 = True Then
            frmSubMenu.Button1.Enabled = True
        Else
            frmSubMenu.Button1.Enabled = False
        End If

        If mcon2 = True Then
            frmSubMenu.Button2.Enabled = True
        Else
            frmSubMenu.Button2.Enabled = False
        End If

        If mcon3 = True Then
            frmSubMenu.Button3.Enabled = True
        Else
            frmSubMenu.Button3.Enabled = False
        End If

        If mcon4 = True Then
            frmSubMenu.Button4.Enabled = True
        Else
            frmSubMenu.Button4.Enabled = False
        End If

        If mcon5 = True Then
            frmSubMenu.Button5.Enabled = True
        Else
            frmSubMenu.Button5.Enabled = False
        End If

        If mcon6 = True Then
            frmSubMenu.Button6.Enabled = True
        Else
            frmSubMenu.Button6.Enabled = False
        End If

        If mcon7 = True Then
            frmSubMenu.Button7.Enabled = True
        Else
            frmSubMenu.Button7.Enabled = False
        End If

        If mcon8 = True Then
            frmSubMenu.Button8.Enabled = True
        Else
            frmSubMenu.Button8.Enabled = False
        End If

        If mcon9 = True Then
            frmSubMenu.Button9.Enabled = True
        Else
            frmSubMenu.Button9.Enabled = False
        End If


    End Sub

End Module
