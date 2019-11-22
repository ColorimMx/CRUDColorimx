Public Class Login

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult
        msg = "Esta seguro que desea salir?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Sair"
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

        Dim key As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value
        Module1.mssql = key

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
        Dim comboSource As New Dictionary(Of String, String)()

        comboSource.Add("100.48.0.88", "PRODUCTIVO")
        comboSource.Add("127.0.0.1", "PRUEBAS")

        ComboBox1.DataSource = New BindingSource(comboSource, Nothing)
        ComboBox1.DisplayMember = "Value"
        ComboBox1.ValueMember = "Key"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class