Public Class pago
    Dim orden As DataTable
    Sub hacerinventario()
        For i = 0 To orden.Rows.Count - 1
            Dim tablarecetas As DataTable = RecetasPorProductoTableAdapter1.GetData(orden.Rows(i).Item("producto"))
            For j = 0 To tablarecetas.Rows.Count - 1
                Dim aux As Double = -tablarecetas.Rows(j).Item("cantidad") * orden.Rows(i).Item("cantidad")
                InventarioTableAdapter1.actualizarCantidad(aux, tablarecetas.Rows(j).Item("inventario"))
            Next
            If orden.Rows(i).Item("saboresYjaleasl") <> "" Then
                InventarioTableAdapter1.actualizarCantidad(Val(-orden.Rows(i).Item("cantidad")), ProductosnounicosTableAdapter.VersaborProducto(orden.Rows(i).Item("saboresYjaleasl")))
            End If
        Next
    End Sub
    Private Sub botonOk()
        Form1.orden += 1
        hacerinventario()
        Form1.actualizarmeta()
        My.Settings.banOrdenServida = True
        Me.Close()
    End Sub

    Private Sub pago_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            botonOk()
        End If
    End Sub

    Private Sub pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        orden = VentasporordenyfechaTableAdapter.GetData(Today, Form1.orden, Today.AddDays(1))
        DataGridView1.DataSource = orden
        Total.Text = "TOTAL: " & orden.Compute("SUM(COSTO)", "").ToString

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            Vuelto.Text = Val(TextBox1.Text) - Val(Total.Text.Substring(6))
        Else
            MsgBox("no a ingresado un numero", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        botonOk()
    End Sub
End Class