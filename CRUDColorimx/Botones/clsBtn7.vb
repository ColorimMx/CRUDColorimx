Public Class clsBtn7
    Sub Scontabilidad()
        Dim mCont As New clsPnlFrm
        mCont.AbrirFormPanel(subMPre.menuSub, subMPre.btnTxt1, subMPre.btnTxt2,
                             subMPre.btnTxt3, subMPre.btnTxt4, subMPre.btnTxt5, subMPre.btnTxt6,
                             subMPre.btnTxt7, subMPre.btnTxt8, subMPre.btnTxt9, subMPre.btnTxt10, subMPre.btnimg1,
                             subMPre.btnimg2, subMPre.btnimg3, subMPre.btnimg4, subMPre.btnimg5,
                             subMPre.btnimg6, subMPre.btnimg7, subMPre.btnimg8, subMPre.btnimg9,
                             subMPre.btnimg10, subMPre.fonImg, subMPre.btnColor)

    End Sub
    Sub presupuesto()
        Dim FrmPres As New frmPreRep
        FrmPres.Show()
    End Sub
    Sub SDespachos()
        Dim mDes As New clsPnlFrm
        mDes.AbrirFormPanel(subMInvDes.menuSub, subMInvDes.btnTxt1, subMInvDes.btnTxt2,
                             subMInvDes.btnTxt3, subMInvDes.btnTxt4, subMInvDes.btnTxt5, subMInvDes.btnTxt6,
                             subMInvDes.btnTxt7, subMInvDes.btnTxt8, subMInvDes.btnTxt9, subMInvDes.btnTxt10, subMInvDes.btnimg1,
                             subMInvDes.btnimg2, subMInvDes.btnimg3, subMInvDes.btnimg4, subMInvDes.btnimg5,
                             subMInvDes.btnimg6, subMInvDes.btnimg7, subMInvDes.btnimg8, subMInvDes.btnimg9,
                             subMInvDes.btnimg10, subMInvDes.fonImg, subMInvDes.btnColor)

    End Sub
End Class
