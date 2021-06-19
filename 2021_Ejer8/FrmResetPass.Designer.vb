<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResetPass
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblConfPass = New System.Windows.Forms.Label()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblUsuarioSel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(4, 137)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(429, 23)
        Me.btnRegistrar.TabIndex = 33
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(79, 46)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 32
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Location = New System.Drawing.Point(65, 98)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(61, 13)
        Me.lblConfPass.TabIndex = 30
        Me.lblConfPass.Text = "Conf. Pass:"
        '
        'txtConfPass
        '
        Me.txtConfPass.Location = New System.Drawing.Point(132, 91)
        Me.txtConfPass.MaxLength = 100
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(244, 20)
        Me.txtConfPass.TabIndex = 29
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(93, 72)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(33, 13)
        Me.lblPass.TabIndex = 28
        Me.lblPass.Text = "Pass:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(132, 65)
        Me.txtPass.MaxLength = 100
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(244, 20)
        Me.txtPass.TabIndex = 27
        '
        'lblUsuarioSel
        '
        Me.lblUsuarioSel.AutoSize = True
        Me.lblUsuarioSel.Location = New System.Drawing.Point(131, 46)
        Me.lblUsuarioSel.Name = "lblUsuarioSel"
        Me.lblUsuarioSel.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuarioSel.TabIndex = 34
        Me.lblUsuarioSel.Text = "Usuario:"
        '
        'FrmResetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 188)
        Me.Controls.Add(Me.lblUsuarioSel)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblConfPass)
        Me.Controls.Add(Me.txtConfPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtPass)
        Me.Name = "FrmResetPass"
        Me.Text = "Reset Pass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblConfPass As Label
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblUsuarioSel As Label
End Class
