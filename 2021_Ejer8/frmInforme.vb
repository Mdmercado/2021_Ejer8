Public Class frmInforme
    Private Sub frmInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        RecuperarSQL(sqlInformes, tabla)

        rpview1.LocalReport.DataSources.Clear()

        If informe = "cliente" Then
            rpview1.LocalReport.ReportPath = Application.StartupPath & "\ReportClientes.rdlc"
            rpview1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Clientes", tabla))
        Else
            rpview1.LocalReport.ReportPath = Application.StartupPath & "\Report1.rdlc"
            rpview1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Minforme", tabla))
        End If

        Me.rpview1.RefreshReport()
    End Sub
End Class