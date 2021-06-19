<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbTDoc = New System.Windows.Forms.ComboBox()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTDoc = New System.Windows.Forms.Label()
        Me.lblNDoc = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblCel = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblLocalidadSelec = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(93, 21)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(244, 20)
        Me.txtApellido.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(412, 21)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(244, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cmbTDoc
        '
        Me.cmbTDoc.FormattingEnabled = True
        Me.cmbTDoc.Location = New System.Drawing.Point(93, 56)
        Me.cmbTDoc.Name = "cmbTDoc"
        Me.cmbTDoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbTDoc.TabIndex = 2
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(312, 58)
        Me.txtNDoc.MaxLength = 8
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(118, 20)
        Me.txtNDoc.TabIndex = 3
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(549, 58)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(107, 20)
        Me.dtpFechaNac.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(412, 95)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(244, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(93, 135)
        Me.txtCel.MaxLength = 30
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(121, 20)
        Me.txtCel.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(412, 135)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(244, 20)
        Me.txtEmail.TabIndex = 8
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(412, 179)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 10
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(93, 177)
        Me.txtObs.MaxLength = 250
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(307, 68)
        Me.txtObs.TabIndex = 9
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(42, 27)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 11
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(362, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre"
        '
        'lblTDoc
        '
        Me.lblTDoc.AutoSize = True
        Me.lblTDoc.Location = New System.Drawing.Point(49, 64)
        Me.lblTDoc.Name = "lblTDoc"
        Me.lblTDoc.Size = New System.Drawing.Size(40, 13)
        Me.lblTDoc.TabIndex = 13
        Me.lblTDoc.Text = "TDoc.:"
        '
        'lblNDoc
        '
        Me.lblNDoc.AutoSize = True
        Me.lblNDoc.Location = New System.Drawing.Point(265, 64)
        Me.lblNDoc.Name = "lblNDoc"
        Me.lblNDoc.Size = New System.Drawing.Size(41, 13)
        Me.lblNDoc.TabIndex = 14
        Me.lblNDoc.Text = "NDoc.:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(479, 65)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(66, 13)
        Me.lblFechaNac.TabIndex = 15
        Me.lblFechaNac.Text = "Fecha Nac.:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(353, 103)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 16
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(33, 103)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(56, 13)
        Me.lblLocalidad.TabIndex = 17
        Me.lblLocalidad.Text = "Localidad:"
        '
        'lblCel
        '
        Me.lblCel.AutoSize = True
        Me.lblCel.Location = New System.Drawing.Point(59, 142)
        Me.lblCel.Name = "lblCel"
        Me.lblCel.Size = New System.Drawing.Size(28, 13)
        Me.lblCel.TabIndex = 18
        Me.lblCel.Text = "Cel.:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(371, 142)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email:"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(59, 177)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(32, 13)
        Me.lblObs.TabIndex = 20
        Me.lblObs.Text = "Obs.:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(36, 262)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(620, 23)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblLocalidadSelec
        '
        Me.lblLocalidadSelec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLocalidadSelec.Location = New System.Drawing.Point(93, 95)
        Me.lblLocalidadSelec.Name = "lblLocalidadSelec"
        Me.lblLocalidadSelec.Size = New System.Drawing.Size(222, 21)
        Me.lblLocalidadSelec.TabIndex = 21
        Me.lblLocalidadSelec.Text = "Sin Localidad"
        Me.lblLocalidadSelec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSize = True
        Me.btnBuscar.Image = Global._2021_Ejer8.My.Resources.Resources.iconfinder__8ui_2303114
        Me.btnBuscar.Location = New System.Drawing.Point(317, 90)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(30, 30)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 306)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblLocalidadSelec)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblCel)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblNDoc)
        Me.Controls.Add(Me.lblTDoc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.txtNDoc)
        Me.Controls.Add(Me.cmbTDoc)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmClientes"
        Me.Text = "Alta de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbTDoc As ComboBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCel As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTDoc As Label
    Friend WithEvents lblNDoc As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents lblCel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblObs As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblLocalidadSelec As Label
    Friend WithEvents btnBuscar As Button
End Class
