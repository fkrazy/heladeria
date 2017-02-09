Public Class recetas
    Dim tabla As DataTable
    Private Sub actualizartabla()
        tabla = RecetasPorProductoTableAdapter.GetData(producto.SelectedValue)
        DataGridView1.DataSource = tabla
    End Sub
    Private Sub actualizarcosto()
        Dim suma As Double = 0
        For i = 0 To tabla.Rows.Count - 1
            suma += InventarioTableAdapter.Precio(tabla.Rows(i).Item("inventario")) * tabla.Rows(i).Item("cantidad")
        Next
        ProductofinalTableAdapter.ActualizarCosto(suma, producto.SelectedValue)
        CostoCompra.Text = suma
    End Sub
    Private Sub eliminarProducto()
        RecetasTableAdapter.eliminar(tabla.Rows(DataGridView1.SelectedRows(0).Index).Item("idrecetas"))
        actualizartabla()
        actualizarcosto()
    End Sub
    Private Sub recetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Servicio.recetas' Puede moverla o quitarla según sea necesario.
        Me.RecetasTableAdapter.Fill(Me.Servicio.recetas)

        'TODO: esta línea de código carga datos en la tabla 'Inventarios.inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.Inventarios.inventario)
        'TODO: esta línea de código carga datos en la tabla 'Servicio.productofinal' Puede moverla o quitarla según sea necesario.
        Me.ProductofinalTableAdapter.Fill(Me.Servicio.productofinal)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles producto.SelectedIndexChanged
        actualizartabla()
        CostoCompra.Text = ProductofinalTableAdapter.CostoCompra(producto.SelectedValue)
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        RecetasTableAdapter.Insert(producto.SelectedValue, inventario.SelectedValue, Val(cantidad.Text))
        Me.RecetasTableAdapter.Fill(Me.Servicio.recetas)
        actualizartabla()
        actualizarcosto()
    End Sub

    Private Sub cantidad_TextChanged(sender As Object, e As EventArgs) Handles cantidad.TextChanged
        If Not IsNumeric(cantidad.Text) Then
            cantidad.Text = cantidad.Text.Substring(0, cantidad.Text.Count - 1)
            cantidad.SelectionStart = cantidad.Text.Count
        End If
    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eliminarProducto()
    End Sub
End Class