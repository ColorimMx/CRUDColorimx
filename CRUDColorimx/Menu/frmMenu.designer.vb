<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.pnlTxt = New System.Windows.Forms.Panel()
        Me.titulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlMenus = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.btnCont = New System.Windows.Forms.Button()
        Me.btnActF = New System.Windows.Forms.Button()
        Me.btnClie = New System.Windows.Forms.Button()
        Me.btnBanc = New System.Windows.Forms.Button()
        Me.btnInvt = New System.Windows.Forms.Button()
        Me.btnProv = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlTxt.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTxt
        '
        Me.pnlTxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlTxt.Controls.Add(Me.titulo)
        Me.pnlTxt.Controls.Add(Me.PictureBox1)
        Me.pnlTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTxt.Location = New System.Drawing.Point(0, 0)
        Me.pnlTxt.Name = "pnlTxt"
        Me.pnlTxt.Size = New System.Drawing.Size(1198, 98)
        Me.pnlTxt.TabIndex = 0
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold)
        Me.titulo.Location = New System.Drawing.Point(224, 47)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(742, 39)
        Me.titulo.TabIndex = 2
        Me.titulo.Text = "Análisis, corrección de datos e información. "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CRUDColorimx.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlMenus
        '
        Me.pnlMenus.Controls.Add(Me.btnSalir)
        Me.pnlMenus.Controls.Add(Me.btnAdm)
        Me.pnlMenus.Controls.Add(Me.btnCont)
        Me.pnlMenus.Controls.Add(Me.btnActF)
        Me.pnlMenus.Controls.Add(Me.btnClie)
        Me.pnlMenus.Controls.Add(Me.btnBanc)
        Me.pnlMenus.Controls.Add(Me.btnInvt)
        Me.pnlMenus.Controls.Add(Me.btnProv)
        Me.pnlMenus.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenus.Location = New System.Drawing.Point(0, 98)
        Me.pnlMenus.Name = "pnlMenus"
        Me.pnlMenus.Size = New System.Drawing.Size(218, 585)
        Me.pnlMenus.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Location = New System.Drawing.Point(21, 496)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(165, 64)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAdm
        '
        Me.btnAdm.BackColor = System.Drawing.Color.Transparent
        Me.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdm.ForeColor = System.Drawing.Color.White
        Me.btnAdm.Location = New System.Drawing.Point(21, 426)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(165, 64)
        Me.btnAdm.TabIndex = 8
        Me.btnAdm.Text = "Administrador"
        Me.btnAdm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdm.UseVisualStyleBackColor = False
        '
        'btnCont
        '
        Me.btnCont.BackColor = System.Drawing.Color.Transparent
        Me.btnCont.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCont.ForeColor = System.Drawing.Color.White
        Me.btnCont.Location = New System.Drawing.Point(21, 356)
        Me.btnCont.Name = "btnCont"
        Me.btnCont.Size = New System.Drawing.Size(165, 64)
        Me.btnCont.TabIndex = 7
        Me.btnCont.Text = "Contabilidad"
        Me.btnCont.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCont.UseVisualStyleBackColor = False
        '
        'btnActF
        '
        Me.btnActF.BackColor = System.Drawing.Color.Transparent
        Me.btnActF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnActF.ForeColor = System.Drawing.Color.White
        Me.btnActF.Location = New System.Drawing.Point(21, 286)
        Me.btnActF.Name = "btnActF"
        Me.btnActF.Size = New System.Drawing.Size(165, 64)
        Me.btnActF.TabIndex = 6
        Me.btnActF.Text = "Activo Fijo"
        Me.btnActF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActF.UseVisualStyleBackColor = False
        '
        'btnClie
        '
        Me.btnClie.BackColor = System.Drawing.Color.Transparent
        Me.btnClie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClie.ForeColor = System.Drawing.Color.White
        Me.btnClie.Location = New System.Drawing.Point(21, 216)
        Me.btnClie.Name = "btnClie"
        Me.btnClie.Size = New System.Drawing.Size(165, 64)
        Me.btnClie.TabIndex = 5
        Me.btnClie.Text = "Clientes"
        Me.btnClie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClie.UseVisualStyleBackColor = False
        '
        'btnBanc
        '
        Me.btnBanc.BackColor = System.Drawing.Color.Transparent
        Me.btnBanc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBanc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBanc.ForeColor = System.Drawing.Color.White
        Me.btnBanc.Location = New System.Drawing.Point(21, 146)
        Me.btnBanc.Name = "btnBanc"
        Me.btnBanc.Size = New System.Drawing.Size(165, 64)
        Me.btnBanc.TabIndex = 4
        Me.btnBanc.Text = "Bancos"
        Me.btnBanc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBanc.UseVisualStyleBackColor = False
        '
        'btnInvt
        '
        Me.btnInvt.BackColor = System.Drawing.Color.Transparent
        Me.btnInvt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInvt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvt.ForeColor = System.Drawing.Color.White
        Me.btnInvt.Location = New System.Drawing.Point(21, 76)
        Me.btnInvt.Name = "btnInvt"
        Me.btnInvt.Size = New System.Drawing.Size(165, 64)
        Me.btnInvt.TabIndex = 3
        Me.btnInvt.Text = "Inventario"
        Me.btnInvt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInvt.UseVisualStyleBackColor = False
        '
        'btnProv
        '
        Me.btnProv.BackColor = System.Drawing.Color.Transparent
        Me.btnProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProv.ForeColor = System.Drawing.Color.White
        Me.btnProv.Location = New System.Drawing.Point(21, 6)
        Me.btnProv.Name = "btnProv"
        Me.btnProv.Size = New System.Drawing.Size(165, 64)
        Me.btnProv.TabIndex = 2
        Me.btnProv.Text = "Proveedores"
        Me.btnProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProv.UseVisualStyleBackColor = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(218, 98)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(980, 585)
        Me.pnlContenedor.TabIndex = 2
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlMenus)
        Me.Controls.Add(Me.pnlTxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.Text = "ACDI COLORIM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTxt.ResumeLayout(False)
        Me.pnlTxt.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTxt As System.Windows.Forms.Panel
    Friend WithEvents pnlMenus As System.Windows.Forms.Panel
    Friend WithEvents pnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnProv As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAdm As System.Windows.Forms.Button
    Friend WithEvents btnCont As System.Windows.Forms.Button
    Friend WithEvents btnActF As System.Windows.Forms.Button
    Friend WithEvents btnClie As System.Windows.Forms.Button
    Friend WithEvents btnBanc As System.Windows.Forms.Button
    Friend WithEvents btnInvt As System.Windows.Forms.Button
    Friend WithEvents titulo As System.Windows.Forms.Label
End Class
