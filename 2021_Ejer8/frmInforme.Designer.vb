<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInforme
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
        Me.rpview1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rpview1
        '
        Me.rpview1.Location = New System.Drawing.Point(8, 12)
        Me.rpview1.Name = "rpview1"
        Me.rpview1.ServerReport.BearerToken = Nothing
        Me.rpview1.Size = New System.Drawing.Size(1086, 532)
        Me.rpview1.TabIndex = 0
        '
        'frmInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 550)
        Me.Controls.Add(Me.rpview1)
        Me.Name = "frmInforme"
        Me.Text = "frmInforme"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpview1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
