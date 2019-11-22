Public Class clsMenus

    Sub Inventario()
        Dim mInvt As New clsPnlFrm
        mInvt.AbrirFormPanel(mInv.menuSub, mInv.btnTxt1, mInv.btnTxt2,
                             mInv.btnTxt3, mInv.btnTxt4, mInv.btnTxt5, mInv.btnTxt6,
                             mInv.btnTxt7, mInv.btnTxt8, mInv.btnTxt9, mInv.btnTxt10, mInv.btnimg1,
                             mInv.btnimg2, mInv.btnimg3, mInv.btnimg4, mInv.btnimg5,
                             mInv.btnimg6, mInv.btnimg7, mInv.btnimg8, mInv.btnimg9,
                             mInv.btnimg10, mInv.fonImg, mInv.btnColor)
    End Sub


    Sub Contabilidad()

        Dim mCont As New clsPnlFrm
        mCont.AbrirFormPanel(mCon.menuSub, mCon.btnTxt1, mCon.btnTxt2,
                             mCon.btnTxt3, mCon.btnTxt4, mCon.btnTxt5, mCon.btnTxt6,
                             mCon.btnTxt7, mCon.btnTxt8, mCon.btnTxt9, mCon.btnTxt10, mCon.btnimg1,
                             mCon.btnimg2, mCon.btnimg3, mCon.btnimg4, mCon.btnimg5,
                             mCon.btnimg6, mCon.btnimg7, mCon.btnimg8, mCon.btnimg9,
                             mCon.btnimg10, mCon.fonImg, mCon.btnColor)
    End Sub
End Class
