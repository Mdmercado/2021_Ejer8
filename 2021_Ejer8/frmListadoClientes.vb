Public Class frmListadoClientes
    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim Tabla As DataTable

        chkTodas.Checked = True

        sql = "select * from Localidades order by Localidad asc"
        Tabla = New DataTable
        RecuperarSQL(sql, Tabla)

        cmbLocalidad.DataSource = Tabla
        cmbLocalidad.DisplayMember = "Localidad"
        cmbLocalidad.ValueMember = "IdLocalidad"
        cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLocalidad.SelectedIndex = 0


        DGVInmu.AllowUserToAddRows = False
        DGVInmu.AllowUserToDeleteRows = False
        DGVInmu.ReadOnly = True
        DGVInmu.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub CargarListado()
        Dim sql As String
        Dim Tabla As DataTable

        If chkTodas.Checked Then
            sql = "SELECT * FROM view_clientes ORDER BY Apellido, Nombre ASC"
        Else
            sql = "SELECT * FROM view_clientes where idlocalidad = " & cmbLocalidad.SelectedValue & " ORDER BY Apellido, Nombre ASC"
        End If

        Tabla = New DataTable
        RecuperarSQL(sql, Tabla)
        sqlInformes = sql
        DGVListado.DataSource = Tabla

        DGVListado.AllowUserToAddRows = False
        DGVListado.AllowUserToDeleteRows = False
        DGVListado.ReadOnly = True

        DGVListado.Columns("IdCliente").Visible = False
        DGVListado.Columns("IdTipoDoc").Visible = False
        DGVListado.Columns("IdLocalidad").Visible = False
        DGVListado.Columns("Nombre").Visible = False
        DGVListado.Columns("Apellido").Visible = False

        DGVListado.Columns("ApelNom").HeaderText = "Apellido y Nombre"

        DGVListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub chkTodas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodas.CheckedChanged
        If chkTodas.Checked Then
            cmbLocalidad.Enabled = False
        Else
            cmbLocalidad.Enabled = True
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarListado()
    End Sub

    Private Sub mnuNueva_Click(sender As Object, e As EventArgs) Handles mnuNueva.Click
        Operacion = "Alta"
        FrmClientes.ShowDialog()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        If Not DGVListado.CurrentRow Is Nothing Then

            IdClienteSelec = DGVListado.CurrentRow.Cells("IdCliente").Value
            Operacion = "Actualizacion"
            FrmClientes.ShowDialog()
        End If
    End Sub

    Private Sub frmListadoClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarListado()
    End Sub

    Private Sub DGVListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListado.CellContentClick

    End Sub

    Private Sub DGVListado_Click(sender As Object, e As EventArgs) Handles DGVListado.Click
        Dim tabla As DataTable
        Dim sql As String
        Dim IdCliente As Integer

        If Not DGVListado.CurrentRow Is Nothing Then

            IdCliente = DGVListado.CurrentRow.Cells("IdCliente").Value
            tabla = New DataTable
            sql = "select * from inmuebles where idpropietario = " & IdCliente
            RecuperarSQL(sql, tabla)
            DGVInmu.DataSource = tabla

            DGVInmu.Columns("IdInmueble").Visible = False
            DGVInmu.Columns("IdTipoInmueble").Visible = False
            DGVInmu.Columns("IdLocalidad").Visible = False
            DGVInmu.Columns("IdPropietario").Visible = False
        End If
    End Sub

    Private Sub mnuImprimir_Click(sender As Object, e As EventArgs) Handles mnuImprimir.Click
        informe = "cliente"
        frmInforme.ShowDialog()
    End Sub
End Class