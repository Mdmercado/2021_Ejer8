Public Class frmBusquedas
    Private Sub frmBusquedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRegistros()
    End Sub
    Private Sub CargarRegistros()
        Dim sql As String
        Dim Tabla As DataTable


        If txtLocalidad.Text.Trim <> String.Empty And TodosPermitidosSQL(txtLocalidad.Text.Trim) Then
            sql = "SELECT * FROM Localidades where localidad like '" & txtLocalidad.Text.Trim & "%' ORDER BY Localidad ASC"
        Else
            sql = "SELECT * FROM Localidades ORDER BY Localidad ASC"
        End If


        Tabla = New DataTable
        RecuperarSQL(sql, Tabla)

        DGVListado.DataSource = Tabla

        DGVListado.AllowUserToAddRows = False
        DGVListado.AllowUserToDeleteRows = False
        DGVListado.ReadOnly = True
        DGVListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVListado.Columns("IdLocalidad").Visible = False

        DGVListado.Columns("CodigoPostal").HeaderText = "Cod. Postal"
        DGVListado.Columns("CodigoPostal").Width = "70"


    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarRegistros()

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If DGVListado.CurrentRow Is Nothing Then
            MessageBox.Show("Aun no ha seleccionado una localidad.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            IdLocalidadBus = DGVListado.CurrentRow.Cells("IdLocalidad").Value
            LocalidadBus = DGVListado.CurrentRow.Cells("Localidad").Value
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        IdLocalidadBus = 0
        LocalidadBus = String.Empty
        Me.Close()
    End Sub

    Private Sub frmBusquedas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class