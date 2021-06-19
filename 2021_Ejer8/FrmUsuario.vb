Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim tabla As DataTable

        tabla = New DataTable
        sql = "select * from grupos order by grupo asc"
        RecuperarSQL(sql, tabla)

        cmbGrupo.DataSource = tabla
        cmbGrupo.ValueMember = "Idgrupo"
        cmbGrupo.DisplayMember = "Grupo"
        cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrupo.SelectedIndex = 0

        If Operacion = "Actualizacion" Then
            lblPass.Visible = False
            txtPass.Visible = False
            lblConfPass.Visible = False
            txtConfPass.Visible = False
            Me.Text = "Actualizacion de Usuario"
            sql = "select * from usuarios where idusuario = " & IdUsuarioSelec
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            If tabla.Rows.Count > 0 Then
                txtApellido.Text = tabla.Rows(0)("Apellido").ToString
                txtNombre.Text = tabla.Rows(0)("Nombre").ToString
                txtUsuario.Text = tabla.Rows(0)("usuario").ToString
                cmbGrupo.SelectedValue = Integer.Parse(tabla.Rows(0)("Idgrupo").ToString)
                chkActivo.Checked = tabla.Rows(0)("Activo").ToString
            End If
        End If

    End Sub

    Private Function Validacion() As Boolean
        Dim TodoOk As Boolean
        Dim sql As String
        Dim tabla As DataTable
        TodoOk = False

        If txtApellido.Text.Trim <> String.Empty Then
            If txtNombre.Text.Trim <> String.Empty Then
                If txtUsuario.Text.Trim <> String.Empty Then
                    If txtUsuario.Text.Trim.Length > 5 Then
                        If Operacion = "Alta" Then
                            If txtPass.Text.Trim <> String.Empty Then
                                If txtPass.Text.Trim.Length > 5 Then
                                    If txtPass.Text.Trim = txtConfPass.Text.Trim Then
                                        TodoOk = True
                                    Else
                                        MessageBox.Show("El Pass y su confirmacion no coinciden.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtPass.Focus()
                                    End If
                                Else
                                    MessageBox.Show("El Pass debe contener mas de 5 caracteres.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtPass.Focus()
                                End If
                            Else
                                MessageBox.Show("Complete el Pass.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtPass.Focus()
                            End If
                        Else
                            TodoOk = True
                        End If
                    Else
                        MessageBox.Show("El Usuario debe contener mas de 5 caracteres.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsuario.Focus()
                    End If
                Else
                    MessageBox.Show("Complete el Usuario.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUsuario.Focus()
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
                sql = "select * from usuarios where usuario = '" & txtUsuario.Text.Trim & "'"
            Else
                sql = "select * from usuarios where idusuario <> " & IdUsuarioSelec & " and usuario = '" & txtUsuario.Text.Trim & "'"
            End If
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            If tabla.Rows.Count = 0 Then
                TodoOk = True
            Else
                MessageBox.Show("El Usuario se encuentra asignado a otro usuario.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Return TodoOk
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim sql As String

        If Validacion() Then
            If Operacion = "Alta" Then
                sql = "INSERT INTO Usuarios (Apellido,Nombre,usuario,pass,idgrupo,activo) "
                sql = Sql & " VALUES ('" & txtApellido.Text & "','" & txtNombre.Text & "',"
                sql = sql & "'" & txtUsuario.Text & "','" & GenerarHash256(txtPass.Text) & "',"
                sql = sql & cmbGrupo.SelectedValue & ","
                If chkActivo.Checked Then
                    sql = sql & "1)"
                Else
                    sql = sql & "0)"
                End If

                EjecutarSQL(Sql)

                MessageBox.Show("Registrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                sql = "update usuarios set Apellido = '" & txtApellido.Text & "', "
                sql = sql & "nombre = '" & txtNombre.Text & "', "
                sql = sql & "idgrupo = " & cmbGrupo.SelectedValue & ", "
                sql = sql & "usuario = '" & txtUsuario.Text & "', "
                If chkActivo.Checked Then
                    sql = sql & "Activo = 1 "
                Else
                    sql = sql & "Activo = 0 "
                End If
                sql = sql & "where idusuario = " & IdUsuarioSelec
                EjecutarSQL(Sql)

                MessageBox.Show("El usuario se actualizo correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FrmUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class