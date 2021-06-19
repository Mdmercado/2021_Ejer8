Public Class frmListadoLocalidades
    Private Sub frmListadoLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
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
        sqlInformes = sql
        DGVListado.DataSource = Tabla

        DGVListado.AllowUserToAddRows = False
        DGVListado.AllowUserToDeleteRows = False
        DGVListado.ReadOnly = True
        DGVListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVListado.Columns("IdLocalidad").Visible = False

        DGVListado.Columns("CodigoPostal").HeaderText = "Cod. Postal"
        DGVListado.Columns("CodigoPostal").Width = "70"


    End Sub

    Private Sub mnuNueva_Click(sender As Object, e As EventArgs) Handles mnuNueva.Click
        Operacion = "Alta"
        frmLocalidad.ShowDialog()
    End Sub

    Private Sub frmListadoLocalidades_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarRegistros()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        If Not DGVListado.CurrentRow Is Nothing Then

            IdLocalidadSelec = DGVListado.CurrentRow.Cells("IdLocalidad").Value
            Operacion = "Actualizacion"
            frmLocalidad.ShowDialog()
        End If
    End Sub

    Private Sub frmListadoLocalidades_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub mnuImprimir_Click(sender As Object, e As EventArgs) Handles mnuImprimir.Click
        informe = "localidades"
        frmInforme.ShowDialog()
    End Sub
End Class