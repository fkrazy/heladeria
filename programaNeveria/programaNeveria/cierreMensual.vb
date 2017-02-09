Public Class cierreMensual
    Sub actualizarTablas()
        
        Dim tabla As DataTable = CierrevariosDiasTableAdapter1.GetData(inicio.Value, fin.Value)
        Dim extra As DataTable = MovimientoPorFechaTableAdapter1.GetData(inicio.Value, fin.Value)
        DataGridView1.DataSource = tabla
        verExtras.DataSource = extra
        Ingreso.Text = tabla.Compute("SUM(costo)", "")
        If extra.Rows.Count <> 0 Then
            Egresos.Text = extra.Compute("SUM(cantidad)", "")
        Else
            Egresos.Text = "0"
        End If
        Total.Text = Val(Ingreso.Text) + Val(Egresos.Text)
    End Sub
    Private Sub cierreMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicio.Value = Today.AddDays(-Today.Day + 1)
        fin.Value = inicio.Value.AddMonths(1).AddDays(-1)
        actualizarTablas()
    End Sub

    Private Sub inicio_ValueChanged(sender As Object, e As EventArgs) Handles inicio.ValueChanged
        fin.Value = inicio.Value.AddMonths(1).AddDays(-1)
        actualizarTablas()
    End Sub

    Private Sub fin_ValueChanged(sender As Object, e As EventArgs) Handles fin.ValueChanged
        actualizarTablas()
    End Sub
End Class