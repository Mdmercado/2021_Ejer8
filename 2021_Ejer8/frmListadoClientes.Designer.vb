<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoClientes
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
        Me.DGVListado = New System.Windows.Forms.DataGridView()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuNueva = New System.Windows.Forms.ToolStripMenuItem()
        Me.Actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.chkTodas = New System.Windows.Forms.CheckBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.DGVInmu = New System.Windows.Forms.DataGridView()
        Me.cmsSubMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSubImprimir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenu.SuspendLayout()
        CType(Me.DGVInmu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVListado
        '
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.ContextMenuStrip = Me.cmsMenu
        Me.DGVListado.Location = New System.Drawing.Point(12, 47)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(776, 225)
        Me.DGVListado.TabIndex = 1
        '
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNueva, Me.Actualizar, Me.mnuImprimir})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(181, 92)
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
        'cmbLocalidad
        '
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Location = New System.Drawing.Point(146, 20)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(238, 21)
        Me.cmbLocalidad.TabIndex = 2
        '
        'chkTodas
        '
        Me.chkTodas.AutoSize = True
        Me.chkTodas.Location = New System.Drawing.Point(12, 24)
        Me.chkTodas.Name = "chkTodas"
        Me.chkTodas.Size = New System.Drawing.Size(128, 17)
        Me.chkTodas.TabIndex = 3
        Me.chkTodas.Text = "Todas las localidades"
        Me.chkTodas.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(390, 18)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'DGVInmu
        '
        Me.DGVInmu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInmu.ContextMenuStrip = Me.cmsSubMenu
        Me.DGVInmu.Location = New System.Drawing.Point(12, 278)
        Me.DGVInmu.Name = "DGVInmu"
        Me.DGVInmu.Size = New System.Drawing.Size(776, 160)
        Me.DGVInmu.TabIndex = 5
        '
        'cmsSubMenu
        '
        Me.cmsSubMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSubImprimir})
        Me.cmsSubMenu.Name = "cmsMenu"
        Me.cmsSubMenu.Size = New System.Drawing.Size(121, 26)
        '
        'mnuSubImprimir
        '
        Me.mnuSubImprimir.Name = "mnuSubImprimir"
        Me.mnuSubImprimir.Size = New System.Drawing.Size(120, 22)
        Me.mnuSubImprimir.Text = "Imprimir"
        '
        'frmListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGVInmu)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.chkTodas)
        Me.Controls.Add(Me.cmbLocalidad)
        Me.Controls.Add(Me.DGVListado)
        Me.Name = "frmListadoClientes"
        Me.Text = "Listado de Clientes"
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenu.ResumeLayout(False)
        CType(Me.DGVInmu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents cmbLocalidad As ComboBox
    Friend WithEvents chkTodas As CheckBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents cmsMenu As ContextMenuStrip
    Friend WithEvents mnuNueva As ToolStripMenuItem
    Friend WithEvents Actualizar As ToolStripMenuItem
    Friend WithEvents mnuImprimir As ToolStripMenuItem
    Friend WithEvents DGVInmu As DataGridView
    Friend WithEvents cmsSubMenu As ContextMenuStrip
    Friend WithEvents mnuSubImprimir As ToolStripMenuItem
End Class
