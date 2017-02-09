Public Class cantidad
    Dim orden As DataTable
    Public saborYjalea As String = ""
    Sub finorden()
        Dim temtotal As Double = (Val(Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item(2)) + AñadidosTableAdapter.Costo(ComboBox1.SelectedValue)) * NumericUpDown1.Value
        VentasTableAdapter.Nuevo(Now, producto.Text.Substring(0, 2), NumericUpDown1.Value, Form1.orden, temtotal, ComboBox1.SelectedValue, saborYjalea)
        My.Settings.banOrdenServida = False
        If Form1.orden = Form1.servidos Then
            Form1.PEDIDOS.Items.Add(NumericUpDown1.Value & "  " & Form1.Label1.Text.Substring(3) & "    Q" & temtotal)
            Form1.pedido = Nothing
            Form1.Label1.Text = ""
        Else
            Form1.pedido = Nothing
            Form1.Label1.Text = ""
        End If
        pago.Visible = True
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.pedido = Nothing
        Form1.Label1.Text = ""
        Me.Close()
    End Sub
    Private Sub botonOk()
        VentasTableAdapter.Nuevo(Now, producto.Text.Substring(0, 2), NumericUpDown1.Value, Form1.orden, (Val(Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item(2)) + AñadidosTableAdapter.Costo(ComboBox1.SelectedValue)) * NumericUpDown1.Value, ComboBox1.SelectedValue, saborYjalea)
        Form1.PEDIDOS.Items.Add(NumericUpDown1.Value & "  " & Form1.Label1.Text.Substring(3) & "    Q" & Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item(2) * NumericUpDown1.Value)
        Form1.pedido = Nothing
        Form1.Label1.Text = ""
        My.Settings.banOrdenServida = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        botonOk()
    End Sub

    Private Sub cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.Enter Then
            finorden()
        Else
            If e.KeyCode = Keys.Enter Then
                botonOk()
            End If

        End If
        

    End Sub
    Private Sub cantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Servicio.añadidos' Puede moverla o quitarla según sea necesario.

        Me.AñadidosTableAdapter.Fill(Me.Servicio.añadidos)
        'TODO: esta línea de código carga datos en la tabla 'Servicio.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.Servicio.ventas)
        orden = VentasporordenyfechaTableAdapter.GetData(Today, Form1.orden, Today.AddDays(1))
        DataGridView1.DataSource = orden
        Dim prueba As DataTable = Form1.productos
        precio.Text = Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item("precio")
        total.Text = 0
        For i = 0 To orden.Rows.Count - 1
            total.Text = Val(total.Text) + orden.Rows(i).Item("costo")
        Next
        subtotal.Text = total.Text
        total.Text = Val(total.Text) + Val(Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item("precio") * NumericUpDown1.Value)
        If Form1.Label1.Text.Substring(0, 2) = "65" Or Form1.Label1.Text.Substring(0, 2) = "61" Or Form1.Label1.Text.Substring(0, 2) = "62" Or Form1.Label1.Text.Substring(0, 2) = "63" Or Form1.Label1.Text.Substring(0, 2) = "74" Or Form1.Label1.Text.Substring(0, 2) = "7f" Or Form1.Label1.Text.Substring(0, 2) = "7i" Then
            galones.Visible = True
            Select Case Form1.Label1.Text.Substring(0, 2)
                Case "61"
                    galones.Text = "PINTAS"
                Case "62"
                    galones.Text = "SUNDAE LITRO"
                Case "63"
                    galones.Text = "SUNDAE LIGHT LITRO"
                Case "74"
                    galones.Text = "COPA MIA"
                Case "7f"
                    galones.Text = "VASITOS"
                Case "7i"
                    galones.Text = "GLACIAL"
            End Select
            Me.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For i = 0 To DataGridView1.SelectedRows.Count - 1
                VentasTableAdapter.borrar(orden.Rows(DataGridView1.SelectedRows(i).Index).Item("idventas"))
            Next
        End If
        orden = Nothing
        orden = VentasporordenyfechaTableAdapter.GetData(Today, Form1.orden, Today.AddDays(1))
        DataGridView1.DataSource = orden
        If orden.Rows.Count = 0 Then
            My.Settings.banOrdenServida = True
        End If
        total.Text = 0
        For i = 0 To orden.Rows.Count - 1
            total.Text = Val(total.Text) + orden.Rows(i).Item("costo") * orden.Rows(i).Item("cantidad")
        Next
        subtotal.Text = total.Text
        total.Text = Val(total.Text) + Val(Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item("precio") * NumericUpDown1.Value)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'aqui crea nueva venta pero fin de orden solo en pago cuando se da aceptar, cancelar en pago solo evita cambiar de orden
        finorden()
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If Form1.Label1.Text <> "" Then
            total.Text = Val(subtotal.Text) + (AñadidosTableAdapter.Costo(ComboBox1.SelectedValue) + Val(Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item("precio"))) * NumericUpDown1.Value
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            total.Text = Val(subtotal.Text) + (AñadidosTableAdapter.Costo(ComboBox1.SelectedValue) + Val(Form1.productos.Rows.Find(Form1.Label1.Text.Substring(0, 2)).Item("precio"))) * NumericUpDown1.Value
        End If
    End Sub
End Class