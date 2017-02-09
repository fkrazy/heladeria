Public Class compras
   
    Dim tabla As DataTable
    Public subpedido As DataTable
    Public compraban As Boolean = True
    Structure subSemiCodigo
        Dim nombre As String
        Dim producto As Queue
    End Structure
    Dim semiCodigo As New Queue(Of subSemiCodigo)

    Sub crearSemiCodigos()
        Dim tem As subSemiCodigo
        tem.nombre = "cubeta"
        Dim prod As New Queue
        prod.Enqueue("15%")
        prod.Enqueue("149%")
        tem.producto = prod
        semiCodigo.Enqueue(tem)

        tem.nombre = "medios"
        prod = New Queue
        prod.Enqueue("130%")
        tem.producto = prod
        semiCodigo.Enqueue(tem)

        tem.nombre = "Pintas"
        prod = New Queue
        prod.Enqueue("140%")
        tem.producto = prod
        semiCodigo.Enqueue(tem)

        tem.nombre = "Vasitos"
        prod = New Queue
        prod.Enqueue("16%")
        tem.producto = prod
        semiCodigo.Enqueue(tem)

        tem.nombre = "paletas"
        prod = New Queue
        prod.Enqueue("18%")
        prod.Enqueue("19%")
        tem.producto = prod
        semiCodigo.Enqueue(tem)

        tem.nombre = "otros"
        prod = New Queue
        prod.Enqueue("61%")
        prod.Enqueue("KIT%")
        prod.Enqueue("121%")
        tem.producto = prod
        semiCodigo.Enqueue(tem)

        tem.nombre = "Litros"
        prod = New Queue
        prod.Enqueue("128%")
        prod.Enqueue("138%")
        tem.producto = prod
        semiCodigo.Enqueue(tem)
    End Sub
    Sub actualizarlistado()
        listado.Items.Clear()
        For i = 0 To tabla.Rows.Count - 1
            listado.Items.Add(tabla.Rows(i).Item("DESCRIPCION"))
        Next
        Existencia.Text = "existencia"
        pedido1.Items.Clear()
    End Sub
    Sub actualizartabla(grupo As Integer)
        tabla = InventarioporCodigoTableAdapter.GetData(semiCodigo(grupo).producto(0))
        tabla.Columns.Add("total", System.Type.GetType("System.Decimal"), "porpedir * precioPorPedido")
        Dim tem As DataTable
        For i = 1 To semiCodigo(grupo).producto.Count - 1
            tem = InventarioporCodigoTableAdapter.GetData(semiCodigo(grupo).producto(i))
            tem.Columns.Add("total", System.Type.GetType("System.Decimal"), "porpedir * precioPorPedido")
            For j = 0 To tem.Rows.Count - 1
                tabla.Rows.Add(tem.Rows(j).ItemArray)
            Next
        Next
    End Sub
    Sub actualizarPedidoMas()
        pedido1.Items.Add(tabla.Rows(listado.SelectedIndex).Item("DESCRIPCION") & "   " & compra.Value)
        subpedido.Rows.Add(tabla.Rows(listado.SelectedIndex).ItemArray)
        subpedido.Rows(subpedido.Rows.Count - 1).SetField("porpedir", compra.Value)
        baseDatos.pedido.Rows.Add(tabla.Rows(listado.SelectedIndex).ItemArray)
        baseDatos.pedido.Rows(baseDatos.pedido.Rows.Count - 1).SetField("porpedir", compra.Value)
    End Sub
    Sub actualizarradialbutons()
        If cubetas.Checked Then
            cubetas.Text = pedido1.Items.Count & " Cubetas"
        End If
        If Medios.Checked Then
            Medios.Text = pedido1.Items.Count & " Medios"
        End If
        If Pintas.Checked Then
            Pintas.Text = pedido1.Items.Count & " Pintas"
        End If
        If Vasitos.Checked Then
            Vasitos.Text = pedido1.Items.Count & " Vasitos"
        End If
        If RBlitros.Checked Then
            RBlitros.Text = pedido1.Items.Count & " Litros"
        End If
        If paletas.Checked Then
            paletas.Text = pedido1.Items.Count & " Paletas"
        End If
        If otrosradialbutton.Checked Then
            otrosradialbutton.Text = pedido1.Items.Count & " Otros"
        End If
    End Sub

    Function encontrarNumeroAlInicio(texto As String) As Integer
        For k = 1 To cubetas.Text.Length - 1
            If Not IsNumeric(cubetas.Text.Substring(0, k)) Then
                Return Val(texto.Substring(0, k))
                Exit For
            End If
        Next
        Return 0
    End Function
    Sub DescontarDeRadialButton(codigo As String)
        Dim Valor As Integer
        For i = 0 To semiCodigo.Count - 1
            For j = 0 To semiCodigo(i).producto.Count - 1
                If codigo.Substring(0, semiCodigo(i).producto(j).ToString.Length - 1) = semiCodigo(i).producto(j).ToString.Substring(0, semiCodigo(i).producto(j).ToString.Length - 1) Then

                    Select Case i
                        Case 0
                            Valor = encontrarNumeroAlInicio(cubetas.Text)
                            cubetas.Text = Valor - 1 & " cubetas"
                            cubetas.Checked = False
                        Case 1
                            Valor = encontrarNumeroAlInicio(Medios.Text)
                            Medios.Text = Valor - 1 & " medios"
                            Medios.Checked = False
                        Case 2
                            Valor = encontrarNumeroAlInicio(Pintas.Text)
                            Pintas.Text = Valor - 1 & " Pintas"
                            Pintas.Checked = False
                        Case 3
                            Valor = encontrarNumeroAlInicio(Vasitos.Text)
                            Vasitos.Text = Valor - 1 & " Vasitos"
                            Vasitos.Checked = False
                        Case 4
                            Valor = encontrarNumeroAlInicio(paletas.Text)
                            paletas.Text = Valor - 1 & " Paletas"
                            paletas.Checked = False
                        Case 5
                            Valor = encontrarNumeroAlInicio(otrosradialbutton.Text)
                            otrosradialbutton.Text = Valor - 1 & " Otros"
                            otrosradialbutton.Checked = False
                        Case 6
                            Valor = encontrarNumeroAlInicio(RBlitros.Text)
                            RBlitros.Text = Valor - 1 & " Litros"
                            RBlitros.Checked = False
                    End Select
                End If
            Next
        Next
    End Sub


    Private Sub compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventarios.PedidodeInventario' Puede moverla o quitarla según sea necesario.
        Me.PedidodeInventarioTableAdapter.Fill(Me.Inventarios.PedidodeInventario)
        'TODO: esta línea de código carga datos en la tabla 'Contabilidad.contabilidadmovimientos' Puede moverla o quitarla según sea necesario.
        Me.ContabilidadmovimientosTableAdapter.Fill(Me.Contabilidad.contabilidadmovimientos)
        'TODO: esta línea de código carga datos en la tabla 'Inventarios.inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.Inventarios.inventario)
        crearSemiCodigos()
        If compraban Then
            baseDatos.pedido = PedidodeInventarioTableAdapter.GetData()
            baseDatos.pedido.Columns.Add("total", System.Type.GetType("System.Decimal"), "porpedir * precioPorPedido")
            If baseDatos.pedido.Rows.Count <> 0 Then
                TotalLabel.Text = baseDatos.pedido.Compute("sum(total)", "")
            End If
            DataGridView1.DataSource = baseDatos.pedido
            subpedido = baseDatos.pedido.Clone
        Else
            Me.Text = "traslado"
            Aceptar.Text = "trasladar"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles cubetas.CheckedChanged
        If cubetas.Checked Then
            Const galon = 0
            actualizartabla(galon)
            actualizarlistado()
            If Not IsNothing(subpedido) Then
                subpedido.Rows.Clear()
                For i = 0 To baseDatos.pedido.Rows.Count - 1
                    If baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 2) = semiCodigo(0).producto(0) Or baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 3) = semiCodigo(0).producto(1) Then
                        subpedido.Rows.Add(baseDatos.pedido.Rows(i).ItemArray)
                        pedido1.Items.Add(baseDatos.pedido.Rows(i).Item("DESCRIPCION") & "   " & baseDatos.pedido.Rows(i).Item("porpedir"))
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub Medios_CheckedChanged(sender As Object, e As EventArgs) Handles Medios.CheckedChanged
        If Medios.Checked Then
            Const medios = 1
            actualizartabla(medios)
            actualizarlistado()
            If Not IsNothing(subpedido) Then
                subpedido.Rows.Clear()
                For i = 0 To baseDatos.pedido.Rows.Count - 1
                    If baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 3) = semiCodigo(medios).producto(0) Then
                        subpedido.Rows.Add(baseDatos.pedido.Rows(i).ItemArray)
                        pedido1.Items.Add(baseDatos.pedido.Rows(i).Item("DESCRIPCION") & "   " & baseDatos.pedido.Rows(i).Item("porpedir"))
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub Pintas_CheckedChanged(sender As Object, e As EventArgs) Handles Pintas.CheckedChanged
        If Pintas.Checked Then
            Const pintas = 2
            actualizartabla(pintas)
            actualizarlistado()
            If Not IsNothing(subpedido) Then
                subpedido.Rows.Clear()
                For i = 0 To baseDatos.pedido.Rows.Count - 1
                    If baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 3) = semiCodigo(pintas).producto(0) Then
                        subpedido.Rows.Add(baseDatos.pedido.Rows(i).ItemArray)
                        pedido1.Items.Add(baseDatos.pedido.Rows(i).Item("DESCRIPCION") & "   " & baseDatos.pedido.Rows(i).Item("porpedir"))
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub Vasitos_CheckedChanged(sender As Object, e As EventArgs) Handles Vasitos.CheckedChanged
        If Vasitos.Checked Then
            Const vasito = 3
            actualizartabla(Vasito)
            actualizarlistado()
            If Not IsNothing(subpedido) Then
                subpedido.Rows.Clear()
                For i = 0 To baseDatos.pedido.Rows.Count - 1
                    If baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 2) = semiCodigo(vasito).producto(0) Then
                        subpedido.Rows.Add(baseDatos.pedido.Rows(i).ItemArray)
                        pedido1.Items.Add(baseDatos.pedido.Rows(i).Item("DESCRIPCION") & "   " & baseDatos.pedido.Rows(i).Item("porpedir"))
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub paletas_CheckedChanged(sender As Object, e As EventArgs) Handles paletas.CheckedChanged
        If paletas.Checked Then
            Const paleta = 4
            actualizartabla(paleta)
            actualizarlistado()
            If Not IsNothing(subpedido) Then
                subpedido.Rows.Clear()
                For i = 0 To baseDatos.pedido.Rows.Count - 1
                    If baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 2) = semiCodigo(paleta).producto(0) Or baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 2) = semiCodigo(paleta).producto(1) Then
                        subpedido.Rows.Add(baseDatos.pedido.Rows(i).ItemArray)
                        pedido1.Items.Add(baseDatos.pedido.Rows(i).Item("DESCRIPCION") & "   " & baseDatos.pedido.Rows(i).Item("porpedir"))
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub otrosradialbutton_CheckedChanged(sender As Object, e As EventArgs) Handles otrosradialbutton.CheckedChanged
        If otrosradialbutton.Checked Then
            Const otro = 5
            actualizartabla(otro)
            actualizarlistado()
            If Not IsNothing(subpedido) Then
                subpedido.Rows.Clear()
                For i = 0 To baseDatos.pedido.Rows.Count - 1
                    If baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 2) = semiCodigo(otro).producto(0) Or baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 3) = semiCodigo(otro).producto(1) Or baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 3) = semiCodigo(otro).producto(2) Then
                        subpedido.Rows.Add(baseDatos.pedido.Rows(i).ItemArray)
                        pedido1.Items.Add(baseDatos.pedido.Rows(i).Item("DESCRIPCION") & "   " & baseDatos.pedido.Rows(i).Item("porpedir"))
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub RBlitros_CheckedChanged(sender As Object, e As EventArgs) Handles RBlitros.CheckedChanged
        If RBlitros.Checked = True Then
            Const litro = 6
            actualizartabla(litro)
            actualizarlistado()
            If Not IsNothing(subpedido) Then
                subpedido.Rows.Clear()
                For i = 0 To baseDatos.pedido.Rows.Count - 1
                    If baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 2) = semiCodigo(litro).producto(0) Or baseDatos.pedido.Rows(i).Item("codigo").ToString.Substring(0, 2) = semiCodigo(litro).producto(1) Then
                        subpedido.Rows.Add(baseDatos.pedido.Rows(i).ItemArray)
                        pedido1.Items.Add(baseDatos.pedido.Rows(i).Item("DESCRIPCION") & "   " & baseDatos.pedido.Rows(i).Item("porpedir"))
                    End If
                Next
            End If
        End If
    End Sub


    Private Sub listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listado.SelectedIndexChanged
        Existencia.Text = "existencia: " & tabla.Rows(listado.SelectedIndex).Item("cantidad")
        minimo.Value = tabla.Rows(listado.SelectedIndex).Item("minimo")
        precioTotal1.Text = tabla.Rows(listado.SelectedIndex).Item("precioPorPedido")
        CantidadporPedido1.Value = tabla.Rows(listado.SelectedIndex).Item("cantporunidad")
    End Sub
    Private Sub pedirP1_Click(sender As Object, e As EventArgs) Handles pedirP1.Click
        If subpedido.Rows.Contains(tabla.Rows(listado.SelectedIndex).Item("codigo")) Then
            MsgBox(" YA INGRESO ESTE PRODUCTO", MsgBoxStyle.OkOnly)
        Else
            actualizarPedidoMas()
            actualizarradialbutons()
        End If
    End Sub
    Private Sub eliminarP1_Click(sender As Object, e As EventArgs) Handles eliminarP1.Click
        baseDatos.pedido.Rows.Find(subpedido.Rows(pedido1.SelectedIndex).Item("codigo")).Delete()
        subpedido.Rows(pedido1.SelectedIndex).Delete()
        pedido1.Items.RemoveAt(pedido1.SelectedIndex)
        actualizarradialbutons()
    End Sub

    Dim bancambio = False
    Private Sub minimo_Leave(sender As Object, e As EventArgs) Handles minimo.Leave
        If bancambio = True Then
            If MsgBox("¿desea cambiar el minimo?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                InventarioTableAdapter.Actualizarminimo(Val(minimo.Value), tabla.Rows(listado.SelectedIndex).Item("codigo"))
            End If
            bancambio = False
        End If
    End Sub
    Private Sub minimo_ValueChanged(sender As Object, e As EventArgs) Handles minimo.ValueChanged
        bancambio = True
    End Sub
    Private Sub precioTotal1_Leave(sender As Object, e As EventArgs) Handles precioTotal1.Leave
        If bancambio = True Then
            If MsgBox("¿desea cambiar el precio?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                InventarioTableAdapter.ActualizarPrecioPedido(precioTotal1.Text, tabla.Rows(listado.SelectedIndex).Item("codigo"))
                InventarioTableAdapter.ActualizarPrecio(Val(precioTotal1.Text) / CantidadporPedido1.Value, tabla.Rows(listado.SelectedIndex).Item("codigo"))
            End If
            bancambio = False
        End If
    End Sub
    Private Sub precioTotal1_TextChanged(sender As Object, e As EventArgs) Handles precioTotal1.TextChanged
        precioTotal1.Text = baseDatos.solonumeros(precioTotal1.Text)
        bancambio = True
    End Sub
    Private Sub CantidadporPedido1_Leave(sender As Object, e As EventArgs) Handles CantidadporPedido1.Leave
        If bancambio = True Then
            If MsgBox("¿desea cambiar la cantidad?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                InventarioTableAdapter.actualizarCantPorUnidad(CantidadporPedido1.Value, tabla.Rows(listado.SelectedIndex).Item("codigo"))
                InventarioTableAdapter.ActualizarPrecio(Val(precioTotal1.Text) / CantidadporPedido1.Value, tabla.Rows(listado.SelectedIndex).Item("codigo"))
            End If
            bancambio = False
        End If
    End Sub
    Private Sub CantidadporPedido1_ValueChanged(sender As Object, e As EventArgs) Handles CantidadporPedido1.ValueChanged
        bancambio = True
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If compraban Then 'cuando se hace compra
            For i = 0 To baseDatos.pedido.Rows.Count - 1
                InventarioTableAdapter.Pedir(baseDatos.pedido.Rows(i).Item("porpedir"), baseDatos.pedido.Rows(i).Item("codigo"))
            Next
        Else 'cuando se va a sacar inventario para llevarlo a otro lado
            For i = 0 To baseDatos.pedido.Rows.Count - 1
                InventarioTableAdapter.actualizarCantidad(-baseDatos.pedido.Rows(i).Item("cantporunidad"), baseDatos.pedido.Rows(i).Item("codigo"))
                ContabilidadmovimientosTableAdapter.Nuevo(baseDatos.pedido.Rows(i).Item("codigo") & "  " & baseDatos.pedido.Rows(i).Item("DESCRIPCION"), -baseDatos.pedido.Rows(i).Item("porpedir") * baseDatos.pedido.Rows(i).Item("precioporpedido"), Now, 4)
            Next
        End If
        Me.Close()
    End Sub
    Private Sub EliminarGeneral_Click(sender As Object, e As EventArgs) Handles EliminarGeneral.Click
        InventarioTableAdapter.Pedir(0, DataGridView1.SelectedRows(0).Cells("codigo").Value)
        DescontarDeRadialButton(DataGridView1.SelectedRows(0).Cells("codigo").Value)
        baseDatos.pedido.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        listado.Items.Clear()
        pedido1.Items.Clear()
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        TotalLabel.Text = "total:  " & baseDatos.pedido.Compute("SUM(total)", "")
    End Sub
    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved

        TotalLabel.Text = "total:  " & baseDatos.pedido.Compute("SUM(total)", "")
    End Sub

End Class