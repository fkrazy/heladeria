Public Class agregarInventario

    Private Sub agregarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventarios.medidas' Puede moverla o quitarla según sea necesario.
        Me.MedidasTableAdapter.Fill(Me.Inventarios.medidas)
        'TODO: esta línea de código carga datos en la tabla 'Inventarios.inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.Inventarios.inventario)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InventarioTableAdapter.Nuevo(codigo.Text, descripcion.Text, Val(costo.Text) / Val(cantidad.Text), cantidad.Text, medida.SelectedValue, 5, 1, costo.Text)
        Me.Close()
    End Sub
End Class