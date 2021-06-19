<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.DGVListado = New System.Windows.Forms.DataGridView()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuNueva = New System.Windows.Forms.ToolStripMenuItem()
        Me.Actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.rbActivos = New System.Windows.Forms.RadioButton()
        Me.rbInactivos = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.mnuDesbloquear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetPass = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(631, 25)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'DGVListado
        '
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.ContextMenuStrip = Me.cmsMenu
        Me.DGVListado.Location = New System.Drawing.Point(12, 64)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(694, 374)
        Me.DGVListado.TabIndex = 3
        '
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNueva, Me.Actualizar, Me.mnuImprimir, Me.mnuDesbloquear, Me.mnuResetPass})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(181, 136)
        '
        'mnuNueva
        '
        Me.mnuNueva.Name = "mnuNueva"
        Me.mnuNueva.Size = New System.Drawing.Size(180, 22)
        Me.mnuNueva.Text = "Nuevo"
        '
        'Actualizar
        '
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(180, 22)
        Me.Actualizar.Text = "Actualizar"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Name = "mnuImprimir"
        Me.mnuImprimir.Size = New System.Drawing.Size(180, 22)
        Me.mnuImprimir.Text = "Imprimir"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(12, 37)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(121, 21)
        Me.cmbGrupo.TabIndex = 5
        '
        'rbActivos
        '
        Me.rbActivos.AutoSize = True
        Me.rbActivos.Location = New System.Drawing.Point(221, 40)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(60, 17)
        Me.rbActivos.TabIndex = 6
        Me.rbActivos.Text = "Activos"
        Me.rbActivos.UseVisualStyleBackColor = True
        '
        'rbInactivos
        '
        Me.rbInactivos.AutoSize = True
        Me.rbInactivos.Location = New System.Drawing.Point(297, 41)
        Me.rbInactivos.Name = "rbInactivos"
        Me.rbInactivos.Size = New System.Drawing.Size(68, 17)
        Me.rbInactivos.TabIndex = 7
        Me.rbInactivos.Text = "Inactivos"
        Me.rbInactivos.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(160, 40)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 8
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(12, 12)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(109, 17)
        Me.chkTodos.TabIndex = 9
        Me.chkTodos.Text = "Todos los Grupos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'mnuDesbloquear
        '
        Me.mnuDesbloquear.Name = "mnuDesbloquear"
        Me.mnuDesbloquear.Size = New System.Drawing.Size(180, 22)
        Me.mnuDesbloquear.Text = "Desbloquear"
        '
        'mnuResetPass
        '
        Me.mnuResetPass.Name = "mnuResetPass"
        Me.mnuResetPass.Size = New System.Drawing.Size(180, 22)
        Me.mnuResetPass.Text = "Reset Pass"
        '
        'FrmListadoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 450)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.rbInactivos)
        Me.Controls.Add(Me.rbActivos)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.DGVListado)
        Me.Name = "FrmListadoUsuarios"
        Me.Text = "Listado de Usuarios"
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFiltrar As Button
    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents cmbGrupo As ComboBox
    Friend WithEvents rbActivos As RadioButton
    Friend WithEvents rbInactivos As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents cmsMenu As ContextMenuStrip
    Friend WithEvents mnuNueva As ToolStripMenuItem
    Friend WithEvents Actualizar As ToolStripMenuItem
    Friend WithEvents mnuImprimir As ToolStripMenuItem
    Friend WithEvents mnuDesbloquear As ToolStripMenuItem
    Friend WithEvents mnuResetPass As ToolStripMenuItem
End Class
