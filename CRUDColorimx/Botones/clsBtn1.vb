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
    Sub SClientes()
        Dim mClnt As New clsPnlFrm
        mClnt.AbrirFormPanel(subMClnPri.menuSub, subMClnPri.btnTxt1, subMClnPri.btnTxt2,
                             subMClnPri.btnTxt3, subMClnPri.btnTxt4, subMClnPri.btnTxt5, subMClnPri.btnTxt6,
                             subMClnPri.btnTxt7, subMClnPri.btnTxt8, subMClnPri.btnTxt9, subMClnPri.btnTxt10, subMClnPri.btnimg1,
                             subMClnPri.btnimg2, subMClnPri.btnimg3, subMClnPri.btnimg4, subMClnPri.btnimg5,
                             subMClnPri.btnimg6, subMClnPri.btnimg7, subMClnPri.btnimg8, subMClnPri.btnimg9,
                             subMClnPri.btnimg10, subMClnPri.fonImg, subMClnPri.btnColor)

    End Sub
    Sub SClientes2()
        Dim mClnt As New clsPnlFrm
        mClnt.AbrirFormPanel(subMClnPri2.menuSub, subMClnPri2.btnTxt1, subMClnPri2.btnTxt2,
                             subMClnPri2.btnTxt3, subMClnPri2.btnTxt4, subMClnPri2.btnTxt5, subMClnPri2.btnTxt6,
                             subMClnPri2.btnTxt7, subMClnPri2.btnTxt8, subMClnPri2.btnTxt9, subMClnPri2.btnTxt10, subMClnPri2.btnimg1,
                             subMClnPri2.btnimg2, subMClnPri2.btnimg3, subMClnPri2.btnimg4, subMClnPri2.btnimg5,
                             subMClnPri2.btnimg6, subMClnPri2.btnimg7, subMClnPri2.btnimg8, subMClnPri2.btnimg9,
                             subMClnPri2.btnimg10, subMClnPri2.fonImg, subMClnPri2.btnColor)

    End Sub
    Sub presupuesto()

        Dim FrmPres As New frmPreExp

        FrmPres.Show()

        frmMenu.pnlContenedor.Enabled = False
        frmMenu.pnlMenus.Enabled = False
    End Sub
End Class
