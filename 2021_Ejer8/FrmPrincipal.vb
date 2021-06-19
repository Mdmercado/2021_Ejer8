Public Class FrmPrincipal
    Private Sub mnuLocalidades_Click(sender As Object, e As EventArgs) Handles mnuLocalidades.Click
        frmListadoLocalidades.ShowDialog()

    End Sub

    Private Sub mnuClientes_Click(sender As Object, e As EventArgs) Handles mnuClientes.Click
        frmListadoClientes.ShowDialog()
    End Sub

    Private Sub mnuOperaciones_Click(sender As Object, e As EventArgs) Handles mnuOperaciones.Click

    End Sub

    Private Sub mnuUsuarios_Click(sender As Object, e As EventArgs) Handles mnuUsuarios.Click
        FrmListadoUsuarios.ShowDialog()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "Mi Sistema - " & UserLog & " (" & UserLogGrupo & ")"
        If UserLogGrupo = "Administrador" Then
            mnuUsuarios.Visible = True
        End If
    End Sub
End Class