<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvAlmDes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvAlmDes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDespacho = New System.Windows.Forms.TextBox()
        Me.btnExpDespacho = New System.Windows.Forms.Button()
        Me.btwnIni = New System.Windows.Forms.DateTimePicker()
        Me.btwnFin = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el número de despacho"
        '
        'txtDespacho
        '
        Me.txtDespacho.Location = New System.Drawing.Point(93, 71)
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.Size = New System.Drawing.Size(100, 20)
        Me.txtDespacho.TabIndex = 1
        '
        'btnExpDespacho
        '
        Me.btnExpDespacho.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExpDespacho.Location = New System.Drawing.Point(93, 227)
        Me.btnExpDespacho.Name = "btnExpDespacho"
        Me.btnExpDespacho.Size = New System.Drawing.Size(100, 23)
        Me.btnExpDespacho.TabIndex = 2
        Me.btnExpDespacho.Text = "Aceptar"
        Me.btnExpDespacho.UseVisualStyleBackColor = True
        '
        'btwnIni
        '
        Me.btwnIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.btwnIni.Location = New System.Drawing.Point(44, 158)
        Me.btwnIni.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.btwnIni.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.btwnIni.Name = "btwnIni"
        Me.btwnIni.Size = New System.Drawing.Size(200, 20)
        Me.btwnIni.TabIndex = 3
        Me.btwnIni.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'btwnFin
        '
        Me.btwnFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.btwnFin.Location = New System.Drawing.Point(44, 191)
        Me.btwnFin.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.btwnFin.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.btwnFin.Name = "btwnFin"
        Me.btwnFin.Size = New System.Drawing.Size(200, 20)
        Me.btwnFin.TabIndex = 4
        Me.btwnFin.Value = New Date(2021, 1, 31, 0, 0, 0, 0)
        '
        'frmInvAlmDes
        '
        Me.AcceptButton = Me.btnExpDespacho
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 271)
        Me.Controls.Add(Me.btwnFin)
        Me.Controls.Add(Me.btwnIni)
        Me.Controls.Add(Me.btnExpDespacho)
        Me.Controls.Add(Me.txtDespacho)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmInvAlmDes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Despacho"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents btnExpDespacho As System.Windows.Forms.Button
    Friend WithEvents btwnIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents btwnFin As System.Windows.Forms.DateTimePicker
End Class
