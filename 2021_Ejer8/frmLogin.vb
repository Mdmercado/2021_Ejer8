Imports System.IO
Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim sql As String
        Dim tabla As DataTable

        If Validacion() Then
            sql = "select * from view_usuarios where usuario = '" & txtUsuario.Text.Trim & "' "
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            UserLog = tabla.Rows(0)("ApelNom").ToString
            UserLogGrupo = tabla.Rows(0)("Grupo").ToString

            FrmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Function Validacion() As Boolean
        Dim TodoOk As Boolean
        Dim sql As String
        Dim tabla As DataTable
        Dim intentosfallidos As Integer
        TodoOk = False

        If txtUsuario.Text.Trim <> String.Empty Then
            If txtUsuario.Text.Trim.Length > 5 Then
                If TodosPermitidosSQL(txtUsuario.Text.Trim) Then
                    If txtPass.Text.Trim <> String.Empty Then
                        If txtPass.Text.Trim.Length > 5 Then
                            If TodosPermitidosSQL(txtPass.Text.Trim) Then
                                TodoOk = True
                            Else
                                MessageBox.Show("El Pass contiene caracteres no validos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    MessageBox.Show("El Usuario contiene caracteres no validos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUsuario.Focus()
                End If
            Else
                MessageBox.Show("El Usuario debe contener mas de 5 caracteres.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Focus()
            End If
        Else
            MessageBox.Show("Complete el Usuario.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Focus()
        End If

        If TodoOk Then
            TodoOk = False
            sql = "select * from usuarios where usuario = '" & txtUsuario.Text.Trim & "' "
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            If tabla.Rows.Count = 1 Then
                intentosfallidos = Integer.Parse(tabla.Rows(0)("IntentosFallidos").ToString())
                If intentosfallidos < 3 Then
                    If tabla.Rows(0)("Pass").ToString() = GenerarHash256(txtPass.Text) Then
                        sql = "update usuarios set intentosfallidos = 0 "
                        sql = sql & " where idusuario = " & tabla.Rows(0)("IdUsuario").ToString()
                        EjecutarSQL(sql)

                        TodoOk = True
                    Else
                        sql = "update usuarios set intentosfallidos = intentosfallidos + 1 "
                        sql = sql & " where idusuario = " & tabla.Rows(0)("IdUsuario").ToString()
                        EjecutarSQL(sql)

                        MessageBox.Show("Login incorrecto.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("El usuario se encuentra bloqueado.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Login incorrecto.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Return TodoOk
    End Function

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim archivo As FileStream
        Dim lector As StreamReader

        archivo = New FileStream("set.conf.txt", FileMode.Open)
        lector = New StreamReader(archivo)

        CadCon = lector.ReadLine
        lector.Close()
        archivo.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class