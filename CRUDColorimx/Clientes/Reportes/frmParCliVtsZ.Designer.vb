<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParCliVtsZ
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dateIni = New System.Windows.Forms.DateTimePicker()
        Me.dateFin = New System.Windows.Forms.DateTimePicker()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dateIni
        '
        Me.dateIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateIni.Location = New System.Drawing.Point(12, 12)
        Me.dateIni.Name = "dateIni"
        Me.dateIni.Size = New System.Drawing.Size(101, 20)
        Me.dateIni.TabIndex = 1
        '
        'dateFin
        '
        Me.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFin.Location = New System.Drawing.Point(180, 12)
        Me.dateFin.Name = "dateFin"
        Me.dateFin.Size = New System.Drawing.Size(101, 20)
        Me.dateFin.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 51)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(196, 51)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmParCliVtsZ
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 111)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dateFin)
        Me.Controls.Add(Me.dateIni)
        Me.Name = "frmParCliVtsZ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros Fechas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dateIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
