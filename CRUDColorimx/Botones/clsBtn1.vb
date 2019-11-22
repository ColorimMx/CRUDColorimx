Public Class clsBtn1
    Sub Scontabilidad()
        Dim mCont As New clsPnlFrm
        mCont.AbrirFormPanel(subMCue.menuSub, subMCue.btnTxt1, subMCue.btnTxt2,
                             subMCue.btnTxt3, subMCue.btnTxt4, subMCue.btnTxt5, subMCue.btnTxt6,
                             subMCue.btnTxt7, subMCue.btnTxt8, subMCue.btnTxt9, subMCue.btnTxt10, subMCue.btnimg1,
                             subMCue.btnimg2, subMCue.btnimg3, subMCue.btnimg4, subMCue.btnimg5,
                             subMCue.btnimg6, subMCue.btnimg7, subMCue.btnimg8, subMCue.btnimg9,
                             subMCue.btnimg10, subMCue.fonImg, subMCue.btnColor)

    End Sub
    Sub presupuesto()

        Dim FrmPres As New frmPreExp

        FrmPres.Show()

        frmMenu.pnlContenedor.Enabled = False
        frmMenu.pnlMenus.Enabled = False
    End Sub
End Class
