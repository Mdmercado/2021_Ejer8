Public Class frmLocalidad
    Private Sub frmLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim tabla As DataTable

        Me.CenterToScreen()

        If Operacion = "Actualizacion" Then
            Me.Text = "Actualizacion de Localidad"
            sql = "select * from localidades where idlocalidad = " & IdLocalidadSelec
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            If tabla.Rows.Count > 0 Then
                txtLocalidad.Text = tabla.Rows(0)("Localidad").ToString
                txtCodPostal.Text = tabla.Rows(0)("CodigoPostal").ToString
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim TodoOk As Boolean
        Dim sql As String
        Dim Tabla As DataTable

        TodoOk = False
        If txtLocalidad.Text.Trim <> String.Empty Then
            If txtCodPostal.Text.Trim <> String.Empty Then
                If Operacion = "Alta" Then
                    sql = "select * from localidades where codigopostal = " & txtCodPostal.Text.Trim
                Else
                    sql = "select * from localidades where idlocalidad <> " & IdLocalidadSelec & " and codigopostal = " & txtCodPostal.Text.Trim
                End If
                Tabla = New DataTable
                RecuperarSQL(sql, Tabla)
                If Tabla.Rows.Count = 0 Then
                    TodoOk = True
                Else
                    MessageBox.Show("El codigo postal se encuentra asignado a otra localidad.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Ingrese el codigo postal.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Ingrese la localidad.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return TodoOk
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim sql As String

        If Validar() Then
            If Operacion = "Alta" Then
                'el usuario pretende registrar una nueva localidad
                sql = "insert into Localidades (Localidad,CodigoPostal) values ('" & txtLocalidad.Text & "','" & txtCodPostal.Text & "')"
                EjecutarSQL(sql)

                txtLocalidad.Clear()
                txtCodPostal.Clear()

                MessageBox.Show("La localidad se registro correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'el usuario pretende actualizar una localidad existente
                sql = "update Localidades set Localidad = '" & txtLocalidad.Text & "', "
                sql = sql & "codigopostal = '" & txtCodPostal.Text & "' "
                sql = sql & "where idlocalidad = " & IdLocalidadSelec
                EjecutarSQL(sql)

                MessageBox.Show("La localidad se actualizo correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmLocalidad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class
