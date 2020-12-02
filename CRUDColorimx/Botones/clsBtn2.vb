Public Class clsBtn2
    Sub presupuesto()
        Dim FrmPres As New frmPreVer
        FrmPres.Show()
    End Sub

    Sub SClientes()
        Dim mClnt As New clsPnlFrm
        mClnt.AbrirFormPanel(subMClnBI.menuSub, subMClnBI.btnTxt1, subMClnBI.btnTxt2,
                             subMClnBI.btnTxt3, subMClnBI.btnTxt4, subMClnBI.btnTxt5, subMClnBI.btnTxt6,
                             subMClnBI.btnTxt7, subMClnBI.btnTxt8, subMClnBI.btnTxt9, subMClnBI.btnTxt10, subMClnBI.btnimg1,
                             subMClnBI.btnimg2, subMClnBI.btnimg3, subMClnBI.btnimg4, subMClnBI.btnimg5,
                             subMClnBI.btnimg6, subMClnBI.btnimg7, subMClnBI.btnimg8, subMClnBI.btnimg9,
                             subMClnBI.btnimg10, subMClnBI.fonImg, subMClnBI.btnColor)

    End Sub
    Sub comisiones1()
        Dim FrmComi1 As New frmClnComFam
        FrmComi1.Show()
    End Sub
End Class
