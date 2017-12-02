Public Class recivirPedido
    Dim hoja As Integer = -1
    Dim pedidoTotal As DataTable
    Dim subpedido As DataTable
    Sub visualizar_datos(descripcion As String, cantidad As Double, denominador As Integer)
        Dim strCant As String
        If cantidad Mod 1 > 0 Then
            strCant = Int(cantidad) & "  " & Math.Round((cantidad Mod 1) * denominador)
        Else
            ver.Items.Add(descripcion & "    " & cantidad)
        End If
    End Sub
    Sub siguienteparte()
        subpedido.Rows.Clear()
        ver.Items.Clear()
        Select Case hoja
            Case 0 ' cubetas
                For i = 0 To pedidoTotal.Rows.Count - 1
                    If pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 2) = "15" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "149" Then
                        subpedido.Rows.Add(pedidoTotal.Rows(i).ItemArray)
                        visualizar_datos(pedidoTotal.Rows(i).Item("descripcion"), pedidoTotal.Rows(i).Item("porpedir"), pedidoTotal.Rows(i).Item("cantporunidad"))
                    End If
                Next
            Case 1
                Label1.Text = "MEDIOS GALONES"
                For i = 0 To pedidoTotal.Rows.Count - 1
                    If pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "130" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "129" Then
                        subpedido.Rows.Add(pedidoTotal.Rows(i).ItemArray)
                        visualizar_datos(pedidoTotal.Rows(i).Item("descripcion"), pedidoTotal.Rows(i).Item("porpedir"), pedidoTotal.Rows(i).Item("cantporunidad"))
                    End If
                Next
            Case 2
                Label1.Text = "LITROS Y PINTAS"
                For i = 0 To pedidoTotal.Rows.Count - 1
                    If pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "140" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "138" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "128" Then
                        subpedido.Rows.Add(pedidoTotal.Rows(i).ItemArray)
                        visualizar_datos(pedidoTotal.Rows(i).Item("descripcion"), pedidoTotal.Rows(i).Item("porpedir"), pedidoTotal.Rows(i).Item("cantporunidad"))
                    End If
                Next
            Case 3
                Label1.Text = "PREEMPACADOS"
                For i = 0 To pedidoTotal.Rows.Count - 1
                    If pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 2) = "18" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 2) = "19" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "121" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "160" Then
                        subpedido.Rows.Add(pedidoTotal.Rows(i).ItemArray)
                        visualizar_datos(pedidoTotal.Rows(i).Item("descripcion"), pedidoTotal.Rows(i).Item("porpedir"), pedidoTotal.Rows(i).Item("cantporunidad"))
                    End If
                Next
            Case 4
                Label1.Text = "PRODUCTO SECO"
                For i = 0 To pedidoTotal.Rows.Count - 1
                    If pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 3) = "KIT" Or pedidoTotal.Rows(i).Item("codigo").ToString.Substring(0, 2) = "61" Then
                        subpedido.Rows.Add(pedidoTotal.Rows(i).ItemArray)
                        visualizar_datos(pedidoTotal.Rows(i).Item("descripcion"), pedidoTotal.Rows(i).Item("porpedir"), pedidoTotal.Rows(i).Item("cantporunidad"))
                    End If
                Next
                Siguiente.Text = "fin"
            Case 5
                Siguiente.Enabled = False
                Exit Sub
        End Select
        hoja += 1
        If subpedido.Rows.Count = 0 Then
            siguienteparte()
        End If
    End Sub
    Private Sub recivirPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pedidoTotal = PedidodeInventarioTableAdapter1.GetData()
        pedidoTotal.Columns.Add("total", System.Type.GetType("System.Decimal"), "porpedir * precioPorPedido")
        TotalLabel.Text = "total:  Q" & pedidoTotal.Compute("sum(total)", "")
        subpedido = pedidoTotal.Clone
        siguienteparte()
    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        For i = 0 To ver.Items.Count - 1
            Dim aux As Double = Math.Round(subpedido.Rows(i).Item("porpedir") * subpedido.Rows(i).Item("cantporunidad"))○
            InventarioTableAdapter1.actualizarCantidad(aux, subpedido.Rows(i).Item("codigo"))
            ContabilidadmovimientosTableAdapter1.Nuevo(subpedido.Rows(i).Item("codigo") & "  " & subpedido.Rows(i).Item("descripcion"), subpedido.Rows(i).Item("total"), Now, 2)
            InventarioTableAdapter1.Pedir(0, subpedido.Rows(i).Item("codigo"))
        Next
        siguienteparte()
    End Sub

    Private Sub NoVinoBoton_Click(sender As Object, e As EventArgs) Handles NoVinoBoton.Click
        TotalLabel.Text = "total:  Q" & Val(TotalLabel.Text.Substring(9)) - pedidoTotal.Rows.Find(subpedido.Rows(ver.SelectedIndex).Item("codigo")).Item("total")
        pedidoTotal.Rows.Find(subpedido.Rows(ver.SelectedIndex).Item("codigo")).Delete()
        subpedido.Rows(ver.SelectedIndex).Delete()
        ver.Items.RemoveAt(ver.SelectedIndex)
    End Sub
End Class