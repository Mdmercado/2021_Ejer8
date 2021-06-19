<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoLocalidades
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
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVListado
        '
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.ContextMenuStrip = Me.cmsMenu
        Me.DGVListado.Location = New System.Drawing.Point(12, 46)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(484, 392)
        Me.DGVListado.TabIndex = 0
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
        Me.mnuNueva.Text = "Nueva"
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
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(13, 13)
        Me.txtLocalidad.MaxLength = 50
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(300, 20)
        Me.txtLocalidad.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(319, 11)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'frmListadoLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 450)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.DGVListado)
        Me.Name = "frmListadoLocalidades"
        Me.Text = "Listado de Localidades"
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents cmsMenu As ContextMenuStrip
    Friend WithEvents mnuNueva As ToolStripMenuItem
    Friend WithEvents Actualizar As ToolStripMenuItem
    Friend WithEvents mnuImprimir As ToolStripMenuItem
End Class
