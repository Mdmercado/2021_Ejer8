Public Class FrmListadoUsuarios
    Private Sub FrmListadoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        chkTodos.Checked = True
    End Sub

    Private Sub CargarRegistros()
        Dim sql As String
        Dim Tabla As DataTable


        If chkTodos.Checked Then
            sql = "select * from view_usuarios order by grupo, apelnom asc"
        Else
            sql = "select * from view_usuarios "
            sql = sql & "where idgrupo = " & cmbGrupo.SelectedValue
            If rbActivos.Checked Then
                sql = sql & " and activo = 1"
            Else
                If rbInactivos.Checked Then
                    sql = sql & " and activo = 0"
                End If
            End If
            sql = sql & " order by grupo, apelnom asc"
        End If

        Tabla = New DataTable
        RecuperarSQL(sql, Tabla)

        DGVListado.DataSource = Tabla

        DGVListado.AllowUserToAddRows = False
        DGVListado.AllowUserToDeleteRows = False
        DGVListado.ReadOnly = True
        DGVListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVListado.Columns("Idusuario").Visible = False
        DGVListado.Columns("Idgrupo").Visible = False
        DGVListado.Columns("IntentosFallidos").Visible = False

    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked Then
            cmbGrupo.Enabled = False
            rbTodos.Enabled = False
            rbActivos.Enabled = False
            rbInactivos.Enabled = False
        Else
            cmbGrupo.Enabled = True
            rbTodos.Enabled = True
            rbActivos.Enabled = True
            rbInactivos.Enabled = True
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarRegistros()
    End Sub

    Private Sub mnuNueva_Click(sender As Object, e As EventArgs) Handles mnuNueva.Click
        Operacion = "Alta"
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        If Not DGVListado.CurrentRow Is Nothing Then

            IdUsuarioSelec = DGVListado.CurrentRow.Cells("IdUSuario").Value
            Operacion = "Actualizacion"
            FrmUsuario.ShowDialog()
        End If
    End Sub

    Private Sub FrmListadoUsuarios_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarRegistros()
    End Sub

    Private Sub mnuDesbloquear_Click(sender As Object, e As EventArgs) Handles mnuDesbloquear.Click
        Dim sql As String
        Dim tabla As DataTable
        Dim intentos As Integer

        If Not DGVListado.CurrentRow Is Nothing Then

            IdUsuarioSelec = DGVListado.CurrentRow.Cells("IdUSuario").Value
            sql = "select * from usuarios where idusuario = " & IdUsuarioSelec
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            intentos = Integer.Parse(tabla.Rows(0)("IntentosFallidos").ToString)
            If intentos = 3 Then
                sql = "update usuarios set intentosfallidos = 0 where idusuario = " & IdUsuarioSelec
                EjecutarSQL(sql)
                CargarRegistros()
                MessageBox.Show("El usuario ha sido desbloqueado.", "Desbloqueo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub
End Class