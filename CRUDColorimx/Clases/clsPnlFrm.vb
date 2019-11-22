Public Class clsPnlFrm
    'Sub AbrirFormPanel(Formhijo As Object)
    Sub AbrirFormPanel(menusub As String, btn1 As String, btn2 As String,
                       btn3 As String, btn4 As String,
                       btn5 As String, btn6 As String,
                       btn7 As String, btn8 As String,
                       btn9 As String, btn10 As String,
                       imgbtn1 As Object, imgbtn2 As Object,
                       imgbtn3 As Object, imgbtn4 As Object,
                       imgbtn5 As Object, imgbtn6 As Object,
                       imgbtn7 As Object, imgbtn8 As Object,
                       imgbtn9 As Object, imgbtn10 As Object, imgFondo As Object, bColor As String)
        If frmMenu.pnlContenedor.Controls.Count > 0 Then
            frmMenu.pnlContenedor.Controls.RemoveAt(0)
        End If
        frmMenu.pnlContenedor.Controls.Clear()

        Dim fh As Form = frmSubMenu
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        frmMenu.pnlContenedor.Controls.Add(fh)
        frmMenu.pnlContenedor.Tag = fh
        fh.Show()
        fh.Width = True


        frmSubMenu.Button1.Text = btn1
        frmSubMenu.Button1.Image = imgbtn1
        frmSubMenu.Button1.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button2.Text = btn2
        frmSubMenu.Button2.Image = imgbtn2
        frmSubMenu.Button2.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button3.Text = btn3
        frmSubMenu.Button3.Image = imgbtn3
        frmSubMenu.Button3.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button4.Text = btn4
        frmSubMenu.Button4.Image = imgbtn4
        frmSubMenu.Button4.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button5.Text = btn5
        frmSubMenu.Button5.Image = imgbtn5
        frmSubMenu.Button5.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button6.Text = btn6
        frmSubMenu.Button6.Image = imgbtn6
        frmSubMenu.Button6.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button7.Text = btn7
        frmSubMenu.Button7.Image = imgbtn7
        frmSubMenu.Button7.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button8.Text = btn8
        frmSubMenu.Button8.Image = imgbtn8
        frmSubMenu.Button8.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button9.Text = btn9
        frmSubMenu.Button9.Image = imgbtn9
        frmSubMenu.Button9.ImageAlign = ContentAlignment.TopCenter
        frmSubMenu.Button10.Text = btn10
        frmSubMenu.Button10.Image = imgbtn10
        frmSubMenu.Button10.ImageAlign = ContentAlignment.MiddleCenter

        frmSubMenu.Name = menusub

        frmSubMenu.Button1.Name = btn1
        frmSubMenu.Button2.Name = btn2
        frmSubMenu.Button3.Name = btn3
        frmSubMenu.Button4.Name = btn4
        frmSubMenu.Button5.Name = btn5
        frmSubMenu.Button6.Name = btn6
        frmSubMenu.Button7.Name = btn7
        frmSubMenu.Button8.Name = btn8
        frmSubMenu.Button9.Name = btn9
        frmSubMenu.Button10.Name = btn10


        frmSubMenu.Button1.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button2.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button3.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button4.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button5.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button6.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button7.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button8.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button9.BackColor = ColorTranslator.FromHtml(bColor)
        frmSubMenu.Button10.BackColor = ColorTranslator.FromHtml(bColor)

        frmSubMenu.BackgroundImage = imgFondo

        'frmSubMenu.Button7.Region = New Region(New Rectangle(3, 3, frmSubMenu.Button7.Width - 6, frmSubMenu.Button7.Height - 6))
        'frmSubMenu.Button7.BackColor = ColorTranslator.FromHtml("#00796B")


    End Sub
End Class
