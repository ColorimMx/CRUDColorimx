Imports System.Reflection


Public Class frmSubMenu



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frm = Me.Name

        Select Case frm

            '+++++++++++++++++++++++++++++++++++SUBMENU CONTABILIDAD+++++++++++++++++++++++++++++++++++
            Case "CONTABILIDAD"
                subMCue.conf()
                Dim mCue As New clsBtn1
                mCue.Scontabilidad()

                '+++++++++++++++++++++++++++++++++++SUBMENU CLIENTES+++++++++++++++++++++++++++++++++++
            Case "CLIENTES"
                subMClnPri.conf()
                Dim mCli As New clsBtn1
                mCli.SClientes()

                '+++++++++++++++++++++++++++++++++++EXPORTAR CLIENTES+++++++++++++++++++++++++++++++++++
            Case "CLIENTES VER/EDITAR"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpCliPri
                Try
                    export.insCliPri()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

                '+++++++++++++++++++++++++++++++++++EXPORTAR CLIENTES ESTADOS+++++++++++++++++++++++++++++++++++
            Case "CLIENTES VER/EDITAR 2"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpCliEdo
                Try
                    export.insCliEdo()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

                '+++++++++++++++++++++++++++++++++++EXPORTAR PRESUPUESTO PRINCIPAL+++++++++++++++++++++++++++++++++++
            Case ("PRESUPUESTO")
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpPre
                Try
                    export.insPrePri()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True
        End Select
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim frm = Me.Name

        Select Case frm
            Case "PRESUPUESTO"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpPreApli
                Try
                    export.insPreApli()

                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

                '+++++++++++++++++++++++++++++++++++SUBMENU BUSINESS INTELIGENT CLIENTES +++++++++++++++++++++++++++++++++++
            Case "CLIENTES"
                subMClnBI.conf()
                Dim mClnRep As New clsBtn2
                mClnRep.SClientes()
        End Select
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm = Me.Name

        Select Case frm
            '+++++++++++++++++++++++++++++++++++SUBMENU REPORTES CLIENTES +++++++++++++++++++++++++++++++++++
            Case "CLIENTES"
                subMClnRep.conf()
                Dim mClnRep As New clsBtn3
                mClnRep.SClientes()

                '+++++++++++++++++++++++++++++++++++EXPORTAR APLICACION PRESUPUESTO+++++++++++++++++++++++++++++++++++
            Case "PRESUPUESTO"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpPreAplDet
                Try
                    export.insPreAplDet()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

                '+++++++++++++++++++++++++++++++++++EXPORTAR CLIENTES GIROS+++++++++++++++++++++++++++++++++++
            Case "CLIENTES VER/EDITAR"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpCliGir
                Try
                    export.insCliGir()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

                '+++++++++++++++++++++++++++++++++++EXPORTAR CLIENTES ZONAS+++++++++++++++++++++++++++++++++++
            Case "CLIENTES VER/EDITAR 2"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpCliZon
                Try
                    export.insCliPri()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

        End Select
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim frm = Me.Name

        Select Case frm
            '+++++++++++++++++++++++++++++++++++SUBMENU PRESUPUESTO+++++++++++++++++++++++++++++++++++
            Case "CONTABILIDAD"
                subMPre.conf()
                Dim mPre As New clsBtn7
                mPre.Scontabilidad()

                '+++++++++++++++++++++++++++++++++++REPORTE PRESUPUESTO+++++++++++++++++++++++++++++++++++
            Case "PRESUPUESTO"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpPre
                Dim export2 As New clsExpPreApli
                Dim export3 As New clsExpPreAplDet
                Dim btnpre As New clsBtn7
                Try
                    'export.insPrePri()
                    'export2.insPreApli()
                    'export3.insPreAplDet()
                    'expPre()
                    btnpre.presupuesto()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

                '+++++++++++++++++++++++++++++++++++EXPORTAR CLIENTES CIUDADES+++++++++++++++++++++++++++++++++++
            Case "CLIENTES VER/EDITAR"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpCliCiu
                Try
                    export.insCliCiu()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True


        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frm = Me.Name
        Select Case frm
            Case "INVENTARIO"
                closeapp()
            Case "CLIENTES"
                closeapp()
            Case "CONTABILIDAD"
                closeapp()
            Case "CLIENTES REPORTES"
                Dim mClnt As New clsMenus
                mClnt.Clientes()
                mCln.conf()
            Case "CLIENTES BUSINESS INTELLIGENCE"
                Dim mClnt As New clsMenus
                mClnt.Clientes()
                mCln.conf()
            Case "CLIENTES REPORTES"
                Dim mClnt As New clsMenus
                mClnt.Clientes()
                mCln.conf()
            Case "FACTURAS"
                Dim mClnt As New clsMenus
                mClnt.Clientes()
                mCln.conf()
            Case "CLIENTES VER/EDITAR"
                Dim mClnt As New clsMenus
                mClnt.Clientes()
                mCln.conf()
            Case "CLIENTES VER/EDITAR 2"
                subMClnPri.conf()
                Dim mCli As New clsBtn1
                mCli.SClientes()
            Case "PRESUPUESTO"
                Dim mCont As New clsMenus
                mCont.Contabilidad()
                mCon.conf()
            Case "PLAN DE CUENTAS"
                Dim mCont As New clsMenus
                mCont.Contabilidad()
                mCon.conf()
        End Select
    End Sub

    Private Sub frmSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = ColorTranslator.FromHtml("#c8f4ff")

        Me.Button1.Region = New Region(New Rectangle(3, 3, Button1.Width - 6, Button1.Height - 6))
        'Me.Button1.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button2.Region = New Region(New Rectangle(3, 3, Button2.Width - 6, Button2.Height - 6))
        'Me.Button2.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button3.Region = New Region(New Rectangle(3, 3, Button3.Width - 6, Button3.Height - 6))
        'Me.Button3.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button4.Region = New Region(New Rectangle(3, 3, Button4.Width - 6, Button4.Height - 6))
        'Me.Button4.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button5.Region = New Region(New Rectangle(3, 3, Button5.Width - 6, Button5.Height - 6))
        'Me.Button5.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button6.Region = New Region(New Rectangle(3, 3, Button6.Width - 6, Button6.Height - 6))
        'Me.Button6.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button7.Region = New Region(New Rectangle(3, 3, Button7.Width - 6, Button7.Height - 6))
        'Me.Button7.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button8.Region = New Region(New Rectangle(3, 3, Button8.Width - 6, Button8.Height - 6))
        'Me.Button8.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button9.Region = New Region(New Rectangle(3, 3, Button9.Width - 6, Button9.Height - 6))
        'Me.Button9.BackColor = ColorTranslator.FromHtml("#008853")


        Me.Button10.Region = New Region(New Rectangle(3, 3, Button10.Width - 6, Button10.Height - 6))
        'Me.Button10.BackColor = ColorTranslator.FromHtml("#B71C1C")


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm = Me.Name

        Select Case frm
            Case "PRESUPUESTO"
                Dim btnpre As New clsBtn4
                btnpre.presupuesto()
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm = Me.Name

        Select Case frm
            '+++++++++++++++++++++++++++++++++++EXPORTAR CLIENTES TIPOS+++++++++++++++++++++++++++++++++++
            Case "CLIENTES VER/EDITAR"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpCliTip
                Try
                    export.insCliTip()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True
            Case "PRESUPUESTO"
                Dim btnpre As New clsBtn5
                btnpre.presupuesto()
        End Select
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim frm = Me.Name

        Select Case frm
            Case "CLIENTES VER/EDITAR"
                subMClnPri2.conf()
                Dim mCli As New clsBtn1
                mCli.SClientes2()
        End Select
    End Sub

    
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim frm = Me.Name

        Select Case frm
            Case "CLIENTES"
                subMClnFac.conf()
                Dim mCli As New clsBtn6
                mCli.SClientes()
        End Select
    End Sub
End Class