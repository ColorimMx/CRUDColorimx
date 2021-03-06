﻿Imports System.Reflection


Public Class frmSubMenu
    Dim menus As New clsMenus
    Dim btn1 As New clsBtn1
    Dim btn2 As New clsBtn2
    Dim btn3 As New clsBtn3
    Dim btn4 As New clsBtn4
    Dim btn5 As New clsBtn5
    Dim btn6 As New clsBtn6
    Dim btn7 As New clsBtn7
    Dim btn8 As New clsBtn8
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim frm = Me.Name
        Select Case frm
            '+++++++++++++++++++++++++++++++++++SUBMENU CONTABILIDAD+++++++++++++++++++++++++++++++++++
            Case "CONTABILIDAD"
                subMCue.conf()
                'Dim mCue As New clsBtn1
                btn1.Scontabilidad()
                '+++++++++++++++++++++++++++++++++++SUBMENU CLIENTES+++++++++++++++++++++++++++++++++++
            Case "CLIENTES"
                subMClnPri.conf()
                'Dim mCli As New clsBtn1
                btn1.SClientes()
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
                '+++++++++++++++++++++++++++++++++++EXPORTAR FACTURAS+++++++++++++++++++++++++++++++++++
            Case ("FACTURAS")
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpCliFacPri
                Dim export2 As New clsExpCliFacDet
                Try
                    export.insCliFacPri()
                    export2.insCliFacDet()
                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True
            Case ("CLIENTES REPORTES")
                Dim repCli1 As New frmParCliVtsZ
                repCli1.Show()
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                '+++++++++++++++++++++++++++++++++++EXPORTAR DESPACHOS IMPRESION+++++++++++++++++++++++++++++++++++
            Case ("DESPACHOS")
                Dim expInvAlmDes As New frmInvAlmDes
                expInvAlmDes.Show()
        End Select
    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
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
                'Dim mClnRep As New clsBtn2
                btn2.SClientes()
                '+++++++++++++++++++++++++++++++++++COMISIONES AGENTE/FAMILIA +++++++++++++++++++++++++++++++++++
            Case "COMISIONES VENDEDORES"
                'Dim btncom1 As New clsBtn2
                btn2.comisiones1()
                Me.Button2.Enabled = False
        End Select
    End Sub
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim frm = Me.Name
        Select Case frm
            '+++++++++++++++++++++++++++++++++++SUBMENU REPORTES CLIENTES +++++++++++++++++++++++++++++++++++
            Case "CLIENTES"
                subMClnRep.conf()
                'Dim mClnRep As New clsBtn3
                btn3.SClientes()
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
                '+++++++++++++++++++++++++++++++++++COMISIONES AGENTE/CLIENTE +++++++++++++++++++++++++++++++++++
            Case "COMISIONES VENDEDORES"
                Dim btncom2 As New clsBtn3
                btncom2.comisiones2()
        End Select
    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Dim frm = Me.Name
        Select Case frm
            Case "PRESUPUESTO"
                btn4.presupuesto()
                '+++++++++++++++++++++++++++++++++++COMISIONES AGENTE/COBROS +++++++++++++++++++++++++++++++++++
            Case "COMISIONES VENDEDORES"
                btn4.comisiones3()
        End Select
    End Sub
    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
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
                'Dim btnpre As New clsBtn5
                btn5.presupuesto()
        End Select
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim frm = Me.Name
        Select Case frm
            Case "CLIENTES"
                subMClnFac.conf()
                'Dim mCli As New clsBtn6
                btn6.SClientes()
            Case "INVENTARIO"
                subInvAlm.conf()
                btn6.SInventario()
        End Select
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim frm = Me.Name
        Select Case frm
            '+++++++++++++++++++++++++++++++++++SUBMENU PRESUPUESTO+++++++++++++++++++++++++++++++++++
            Case "CONTABILIDAD"
                subMPre.conf()
                'Dim mPre As New clsBtn7
                btn7.Scontabilidad()
                '+++++++++++++++++++++++++++++++++++REPORTE PRESUPUESTO+++++++++++++++++++++++++++++++++++
            Case "PRESUPUESTO"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                Dim export As New clsExpPre
                Dim export2 As New clsExpPreApli
                Dim export3 As New clsExpPreAplDet
                'Dim btnpre As New clsBtn7
                Try
                    'export.insPrePri()
                    export2.insPreApli()
                    export3.insPreAplDet()
                    'expPre()
                    btn7.presupuesto()
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
            Case "ALMACENES"
                subMInvDes.conf()
                btn7.SDespachos()
        End Select
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim frm = Me.Name
        Select Case frm
            Case "CLIENTES"
                'Dim btncom As New clsBtn8
                btn8.comisiones()
        End Select
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim frm = Me.Name
        Select Case frm
            Case "CLIENTES VER/EDITAR"
                subMClnPri2.conf()
                'Dim mCli As New clsBtn1
                btn1.SClientes2()
        End Select
    End Sub
    Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        Dim frm = Me.Name
        Select Case frm
            Case "INVENTARIO"
                closeapp()
            Case "ALMACENES"
                menus.Inventario()
                mInv.conf()
            Case "DESPACHOS"
                btn6.SInventario()
                subInvAlm.conf()
            Case "CLIENTES"
                closeapp()
            Case "CONTABILIDAD"
                closeapp()
            Case "CLIENTES REPORTES"
                'Dim mClnt As New clsMenus
                menus.Clientes()
                mCln.conf()
            Case "CLIENTES BUSINESS INTELLIGENCE"
                'Dim mClnt As New clsMenus
                menus.Clientes()
                mCln.conf()
            Case "CLIENTES REPORTES"
                'Dim mClnt As New clsMenus
                menus.Clientes()
                mCln.conf()
            Case "FACTURAS"
                'Dim mClnt As New clsMenus
                menus.Clientes()
                mCln.conf()
            Case "CLIENTES VER/EDITAR"
                'Dim mClnt As New clsMenus
                menus.Clientes()
                mCln.conf()
            Case "CLIENTES VER/EDITAR 2"
                subMClnPri.conf()
                'Dim mCli As New clsBtn1
                btn1.SClientes()
            Case "COMISIONES VENDEDORES"
                'Dim mClnt As New clsMenus
                menus.Clientes()
                mCln.conf()
            Case "PRESUPUESTO"
                'Dim mCont As New clsMenus
                menus.Contabilidad()
                mCon.conf()
            Case "PLAN DE CUENTAS"
                'Dim mCont As New clsMenus
                menus.Contabilidad()
                mCon.conf()
        End Select
    End Sub
    Private Sub frmSubMenu_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
End Class