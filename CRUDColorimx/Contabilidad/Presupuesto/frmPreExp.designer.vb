<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreExp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreExp))
        Me.btnExpPrePri = New System.Windows.Forms.Button()
        Me.btnExpPreApli = New System.Windows.Forms.Button()
        Me.btnExpPreReg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExpPrePri
        '
        Me.btnExpPrePri.Location = New System.Drawing.Point(26, 12)
        Me.btnExpPrePri.Name = "btnExpPrePri"
        Me.btnExpPrePri.Size = New System.Drawing.Size(225, 60)
        Me.btnExpPrePri.TabIndex = 0
        Me.btnExpPrePri.Text = "Principal"
        Me.btnExpPrePri.UseVisualStyleBackColor = True
        '
        'btnExpPreApli
        '
        Me.btnExpPreApli.Location = New System.Drawing.Point(26, 94)
        Me.btnExpPreApli.Name = "btnExpPreApli"
        Me.btnExpPreApli.Size = New System.Drawing.Size(225, 60)
        Me.btnExpPreApli.TabIndex = 1
        Me.btnExpPreApli.Text = "Aplicado"
        Me.btnExpPreApli.UseVisualStyleBackColor = True
        '
        'btnExpPreReg
        '
        Me.btnExpPreReg.Location = New System.Drawing.Point(26, 173)
        Me.btnExpPreReg.Name = "btnExpPreReg"
        Me.btnExpPreReg.Size = New System.Drawing.Size(225, 60)
        Me.btnExpPreReg.TabIndex = 2
        Me.btnExpPreReg.Text = "Regresar"
        Me.btnExpPreReg.UseVisualStyleBackColor = True
        '
        'frmPreExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExpPreReg)
        Me.Controls.Add(Me.btnExpPreApli)
        Me.Controls.Add(Me.btnExpPrePri)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreExp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Presupuesto"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExpPrePri As System.Windows.Forms.Button
    Friend WithEvents btnExpPreApli As System.Windows.Forms.Button
    Friend WithEvents btnExpPreReg As System.Windows.Forms.Button
End Class
