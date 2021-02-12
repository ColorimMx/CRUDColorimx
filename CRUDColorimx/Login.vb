Public Class Login

    Sub Validar()
        If txtDataBase.Text = String.Empty Then
            btnAccesar.Enabled = False
        Else
            btnAccesar.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult
        msg = "Esta seguro que desea salir?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Salir"
        Response = MsgBox(msg, style, title)
        If Response = MsgBoxResult.Yes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub btnAccesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccesar.Click
        Module1.nombre = txtUser.Text
        Dim ac As New Acceso
        Dim usuario As String = txtUser.Text
        Dim contraseña As String = txtPassword.Text

        Dim dataBase = txtDataBase.Text
        Dim objIniFile As New clsIni(Module1.fSettings)

        Module1.mssqlsrv = objIniFile.GetString(dataBase, "SERVER", "")
        Module1.mssqldb = objIniFile.GetString(dataBase, "DB", "")
        Module1.mssqlusr = objIniFile.GetString(dataBase, "USER", "")
        Module1.mssqlpas = objIniFile.GetString(dataBase, "PASS", "")


        Dim acceso As String = ac.logear(usuario, contraseña)
        Select acceso
            Case "admin"
                acceso = "admin"
                frmMenu.Show()
                Me.Dispose(False)
            Case "user"
                acceso = "user"
                frmMenu.Show()
                Me.Dispose(False)
            Case Else
                txtUser.Clear()
                txtPassword.Clear()
                txtUser.Focus()
        End Select
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Width = 370
        Me.Height = 160

        If System.IO.File.Exists(Module1.fSettings) = True Then
            btnAccesar.Enabled = False
        Else
            MsgBox("No existe el archivo en la ruta: " & Module1.fSettings)
            Application.ExitThread()
        End If

    End Sub

    Private Sub txtDataBase_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDataBase.TextChanged
        Validar()
    End Sub
End Class