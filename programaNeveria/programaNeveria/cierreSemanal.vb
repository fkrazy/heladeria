Public Class cierreSemanal
    Public Sub actualizarTabla(fecha As Date)
        fecha = fecha.Date
        For i = 0 To 7
            If fecha.DayOfWeek <> DayOfWeek.Wednesday Then
                fecha = fecha.AddDays(-1)
            Else
                Exit For
            End If
        Next
        Dim tabla As DataTable = CierrevariosDiasTableAdapter.GetData(fecha, fecha.AddDays(7))
        Dim extra As DataTable = MovimientoPorFechaTableAdapter1.GetData(fecha, fecha.AddDays(7))
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
    Private Sub cierreSemanal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla(Today)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        actualizarTabla(DateTimePicker1.Value)
    End Sub
End Class