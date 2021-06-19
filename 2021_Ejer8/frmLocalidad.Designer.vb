<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidad
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
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblcodpostal = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(165, 52)
        Me.txtLocalidad.MaxLength = 50
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(264, 20)
        Me.txtLocalidad.TabIndex = 0
        '
        'txtCodPostal
        '
        Me.txtCodPostal.Location = New System.Drawing.Point(165, 96)
        Me.txtCodPostal.MaxLength = 10
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPostal.TabIndex = 1
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(106, 59)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(56, 13)
        Me.lblLocalidad.TabIndex = 2
        Me.lblLocalidad.Text = "Localidad:"
        '
        'lblcodpostal
        '
        Me.lblcodpostal.AutoSize = True
        Me.lblcodpostal.Location = New System.Drawing.Point(95, 103)
        Me.lblcodpostal.Name = "lblcodpostal"
        Me.lblcodpostal.Size = New System.Drawing.Size(64, 13)
        Me.lblcodpostal.TabIndex = 3
        Me.lblcodpostal.Text = "Cod. Postal:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(239, 137)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'frmLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 183)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblcodpostal)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.txtCodPostal)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Name = "frmLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alta de Localidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents lblcodpostal As Label
    Friend WithEvents btnRegistrar As Button
End Class
