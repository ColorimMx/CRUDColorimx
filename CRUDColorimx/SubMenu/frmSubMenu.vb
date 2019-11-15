Imports System.Reflection


Public Class frmSubMenu



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        

        Dim frm = Me.Name

        Select Case frm
            Case "CONTABILIDAD"
                subMCue.conf()
                Dim mCue As New clsBtn1
                mCue.Scontabilidad()
            Case "PRESUPUESTO"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                'Dim btnpre As New clsBtn1
                'btnpre.presupuesto()
                Dim export As New clsExpPre
                Try
                    export.insPrePri()

                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                'Me.Close()

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
                'Dim btnpre As New clsBtn2
                'btnpre.presupuesto()

                Dim export As New clsExpPreApli
                Try
                    export.insPreApli()

                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                'Me.Close()

                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

        End Select
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm = Me.Name

        Select Case frm
            Case "PRESUPUESTO"
                frmMenu.pnlContenedor.Enabled = False
                frmMenu.pnlMenus.Enabled = False
                'Dim btnpre As New clsBtn2
                'btnpre.presupuesto()

                Dim export As New clsExpPreAplDet
                Try
                    export.insPreAplDet()

                Catch ex As Exception
                    MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try

                'Me.Close()

                frmMenu.pnlContenedor.Enabled = True
                frmMenu.pnlMenus.Enabled = True

        End Select
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim frm = Me.Name

        Select Case frm
            Case "CONTABILIDAD"

                subMPre.conf()
                Dim mPre As New clsBtn7
                mPre.Scontabilidad()
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



        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frm = Me.Name
        Select Case frm
            Case "CONTABILIDAD"
                closeapp()
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
            Case "PRESUPUESTO"
                Dim btnpre As New clsBtn5
                btnpre.presupuesto()
        End Select
    End Sub
End Class