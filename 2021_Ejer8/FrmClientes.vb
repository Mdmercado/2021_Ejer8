Imports System.Text.RegularExpressions

Public Class FrmClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim tabla As DataTable

        Me.CenterToScreen()

        sql = "select * from TiposDocs order by TipoDoc asc"
        tabla = New DataTable
        RecuperarSQL(sql, tabla)

        cmbTDoc.DataSource = tabla
        cmbTDoc.DisplayMember = "TipoDoc"
        cmbTDoc.ValueMember = "IdTipoDoc"
        cmbTDoc.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTDoc.SelectedIndex = 0

        sql = "select * from Localidades order by Localidad asc"
        tabla = New DataTable
        RecuperarSQL(sql, tabla)

        dtpFechaNac.MaxDate = DateTime.Today

        If Operacion = "Actualizacion" Then
            Me.Text = "Actualizacion de cliente"
            sql = "select clientes.*, localidad from clientes inner join localidades on clientes.idlocalidad = localidades.idlocalidad where idcliente = " & IdClienteSelec
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            If tabla.Rows.Count > 0 Then
                txtApellido.Text = tabla.Rows(0)("Apellido").ToString
                txtNombre.Text = tabla.Rows(0)("Nombre").ToString
                cmbTDoc.SelectedValue = Integer.Parse(tabla.Rows(0)("IdTipoDoc").ToString)
                txtNDoc.Text = tabla.Rows(0)("NDoc").ToString
                dtpFechaNac.Value = DateTime.Parse(tabla.Rows(0)("FechaNac").ToString)
                lblLocalidadSelec.Tag = Integer.Parse(tabla.Rows(0)("IdLocalidad").ToString)
                lblLocalidadSelec.Text = tabla.Rows(0)("Localidad").ToString
                txtDireccion.Text = tabla.Rows(0)("Direccion").ToString
                txtCel.Text = tabla.Rows(0)("Cel").ToString
                txtEmail.Text = tabla.Rows(0)("Email").ToString
                chkActivo.Checked = tabla.Rows(0)("Activo").ToString
                txtObs.Text = tabla.Rows(0)("Observaciones").ToString
            End If
        End If
    End Sub

    Private Function Validacion() As Boolean
        Dim TodoOk As Boolean
        Dim NDoc As Integer
        Dim FormatoEmail As Regex
        Dim sql As String
        Dim idloc As Integer
        Dim tabla As DataTable
        TodoOk = False

        If txtApellido.Text.Trim <> String.Empty Then
            If txtNombre.Text.Trim <> String.Empty Then
                If Integer.TryParse(txtNDoc.Text.Trim, NDoc) Then
                    If NDoc > 0 Then
                        If txtDireccion.Text.Trim <> String.Empty Then
                            If txtCel.Text.Trim <> String.Empty Then
                                If Integer.TryParse(lblLocalidadSelec.Tag, idloc) Then
                                    If idloc > 0 Then
                                        If txtEmail.Text.Trim = String.Empty Then
                                            TodoOk = True
                                        Else
                                            FormatoEmail = New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                                            If FormatoEmail.IsMatch(txtEmail.Text.Trim) Then
                                                TodoOk = True
                                            Else
                                                MessageBox.Show("El email no es valido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txtEmail.Focus()
                                            End If
                                        End If
                                    Else
                                        MessageBox.Show("Seleccione una Localidad.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Else
                                    MessageBox.Show("Seleccione una Localidad.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Else
                                MessageBox.Show("Complete el Cel.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtCel.Focus()
                            End If
                        Else
                            MessageBox.Show("Complete la direccion.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtDireccion.Focus()
                        End If
                    Else
                        MessageBox.Show("El NDoc no es valido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtNDoc.Focus()
                    End If
                Else
                    MessageBox.Show("El NDoc no es valido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNDoc.Focus()
                End If
            Else
                MessageBox.Show("Complete el Nombre.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombre.Focus()
            End If
        Else
            MessageBox.Show("Complete el Apellido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtApellido.Focus()
        End If

        If TodoOk Then
            TodoOk = False
            If Operacion = "Alta" Then
                sql = "select * from clientes where idtipodoc = " & cmbTDoc.SelectedValue & " and ndoc = " & txtNDoc.Text
            Else
                sql = "select * from clientes where idcliente <> " & IdClienteSelec & " and idtipodoc = " & cmbTDoc.SelectedValue & " and ndoc = " & txtNDoc.Text
            End If
            Tabla = New DataTable
            RecuperarSQL(Sql, Tabla)
            If Tabla.Rows.Count = 0 Then
                TodoOk = True
            Else
                MessageBox.Show("El tipo y nro de doc se encuentran asignados a otro cliente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Return TodoOk
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim sql As String

        If Validacion() Then
            If Operacion = "Alta" Then
                sql = "INSERT INTO Clientes (Apellido,Nombre,IdTipoDoc,NDoc,FechaNac,Direccion,IdLocalidad,Cel,Email,Activo,Observaciones) "
                sql = sql & " VALUES ('" & txtApellido.Text & "','" & txtNombre.Text & "',"
                sql = sql & cmbTDoc.SelectedValue & "," & txtNDoc.Text & ","
                sql = sql & "'" & dtpFechaNac.Value.ToShortDateString() & "','" & txtDireccion.Text & "',"
                sql = sql & lblLocalidadSelec.Tag & ",'" & txtCel.Text & "',"
                If txtEmail.Text.Trim() = String.Empty Then
                    sql = sql & "NULL,"
                Else
                    sql = sql & "'" & txtEmail.Text & "',"
                End If
                If chkActivo.Checked Then
                    sql = sql & "1,"
                Else
                    sql = sql & "0,"
                End If
                If txtObs.Text.Trim() = String.Empty Then
                    sql = sql & "NULL)"
                Else
                    sql = sql & "'" & txtObs.Text & "')"
                End If

                EjecutarSQL(sql)

                MessageBox.Show("Registrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'el usuario pretende actualizar un cliente existente
                sql = "update clientes set Apellido = '" & txtApellido.Text & "', "
                sql = sql & "nombre = '" & txtNombre.Text & "', "
                sql = sql & "idtipodoc = " & cmbTDoc.SelectedValue & ", "
                sql = sql & "NDoc = " & txtNDoc.Text & ", "
                sql = sql & "idlocalidad = " & lblLocalidadSelec.Tag & ", "
                sql = sql & "direccion = '" & txtDireccion.Text & "', "
                sql = sql & "cel = '" & txtCel.Text & "', "
                If txtEmail.Text.Trim() = String.Empty Then
                    sql = sql & "email = NULL,"
                Else
                    sql = sql & "Email = '" & txtEmail.Text & "', "
                End If
                If chkActivo.Checked Then
                    sql = sql & "Activo = 1,"
                Else
                    sql = sql & "Activo = 0,"
                End If
                If txtObs.Text.Trim() = String.Empty Then
                    sql = sql & "Observaciones = NULL "
                Else
                    sql = sql & "Observaciones = '" & txtObs.Text & "' "
                End If
                sql = sql & "where idcliente = " & IdClienteSelec
                EjecutarSQL(sql)

                MessageBox.Show("El cliente se actualizo correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FrmClientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBusquedas.ShowDialog()
    End Sub

    Private Sub FrmClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim sql As String
        Dim tabla As DataTable
        If IdLocalidadBus = 0 Then
            If Operacion = "Actualizacion" Then
                Sql = "select clientes.*, localidad from clientes inner join localidades on clientes.idlocalidad = localidades.idlocalidad where idcliente = " & IdClienteSelec
                tabla = New DataTable
                RecuperarSQL(Sql, tabla)
                If tabla.Rows.Count > 0 Then
                    lblLocalidadSelec.Tag = Integer.Parse(tabla.Rows(0)("IdLocalidad").ToString)
                    lblLocalidadSelec.Text = tabla.Rows(0)("Localidad").ToString
                End If
            Else
                lblLocalidadSelec.Text = "Sin Localidad"
                lblLocalidadSelec.Tag = 0
            End If
        Else
            lblLocalidadSelec.Text = LocalidadBus
            lblLocalidadSelec.Tag = IdLocalidadBus
        End If
    End Sub

    Private Sub FrmClientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class