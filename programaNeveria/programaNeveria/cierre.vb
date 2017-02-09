Public Class cierre
    Dim cierreTabla As DataTable
    Dim extra As DataTable
    Dim ban As Boolean = False
    Private Sub hacercuentas(fecha As Date)
        Dim aux As String = Form1.clave.Text
        If Form1.clave.Text <> "armony" And ban = False Then
            cierreTabla = CierrevariosDiasTableAdapter1.GetData(fecha.AddHours(Now.Hour - 1), fecha.AddHours(Now.Hour))
            extra = MovimientoPorFechaTableAdapter.GetData(fecha.AddHours(Now.Hour - 1), fecha.AddHours(Now.Hour))
            DataGridView1.DataSource = cierreTabla
            verExtras.DataSource = extra
            Ingreso.Text = cierreTabla.Compute("SUM(costo)", "")
        Else
            ban = True
            cierreTabla = CierrevariosDiasTableAdapter1.GetData(fecha, fecha.AddDays(1))
            extra = MovimientoPorFechaTableAdapter.GetData(fecha, fecha.AddDays(1))
            DataGridView1.DataSource = cierreTabla
            verExtras.DataSource = extra
            Ingreso.Text = cierreTabla.Compute("SUM(costo)", "")
            If extra.Rows.Count <> 0 Then
                Egresos.Text = extra.Compute("SUM(cantidad)", "")
            Else
                Egresos.Text = "0"
            End If
            Total.Text = Val(Ingreso.Text) + Val(Egresos.Text)
            Form1.clave.Text = ""

        End If
    End Sub
    Private Sub cierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Today
        hacercuentas(Today)
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        hacercuentas(DateTimePicker1.Value.Date)
    End Sub
End Class