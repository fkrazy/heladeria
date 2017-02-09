Public Class Form1
    Public productos As DataTable
    Public pedido As String
    Public orden As Integer
    Public servidos As Integer
    Dim pasar As Boolean = True
    Dim ordenTabla As DataTable
    Dim cuota As Double
    Const mensual1 As Integer = 6000
    Dim BanderaClave As Boolean = False
    Sub creacionmeta()
        Const relacion As Integer = 3 ' relacion de metas establecida 3 a 1 entre fin de semana y entre semana
        Dim fecha As Date
        Dim rango As Short
        Dim findeSemana As Short
        Dim entresemana As Short = 0
        Dim cuotaentresemana As Double
        Dim cuotafindesemana As Double
        fecha = Today.AddMonths(1).AddDays(-Today.Day)
        rango = (Int(Today.Day / 7) + 1) * 7 - Today.Day + 1 + fecha.Day - 28
        If rango >= 7 Then
            rango -= 7
            findeSemana = (4 - Int(Today.Day / 7)) * 2
        Else
            findeSemana = (3 - Int(Today.Day / 7)) * 2
        End If
        If Today.DayOfWeek = 0 Then
            findeSemana += 1
        End If
        If 6 >= Today.DayOfWeek And 6 < Today.DayOfWeek + rango Then
            findeSemana += 1
        End If
        If 7 >= Today.DayOfWeek And 7 < Today.DayOfWeek + rango Then
            findeSemana += 1
        End If
        entresemana = fecha.Day - Today.Day - findeSemana + 1
        Dim tabla As DataTable = CierrevariosDiasTableAdapter1.GetData(Today.AddDays(-Today.Day + 1), Today.AddMonths(1).AddDays(-Today.Day))
        Dim suma As Integer = tabla.Compute("SUM(costo)", "")
        cuotaentresemana = (mensual1 - suma) / (entresemana + relacion * findeSemana)
        cuotafindesemana = cuotaentresemana * relacion
        If (Today.DayOfWeek = DayOfWeek.Saturday) Or (Today.DayOfWeek = DayOfWeek.Sunday) Then
            cuota = cuotafindesemana
        Else
            cuota = cuotaentresemana
        End If
    End Sub
    Public Sub actualizarmeta()
        Dim tabla = CierrevariosDiasTableAdapter1.GetData(Today, Today.AddDays(1))
        Dim suma As Double
        If tabla.Rows.Count <> 0 Then
            suma = tabla.Compute("SUM(costo)", "")
        End If
        Select Case suma
            Case Is <= cuota
                barraMeta.CreateGraphics.FillRectangle(Brushes.Red, New Rectangle(0, barraMeta.Height - (barraMeta.Height / cuota * suma), barraMeta.Width / 2, barraMeta.Height / cuota * suma))
        End Select
        tabla = CierrevariosDiasTableAdapter1.GetData(Today.AddDays(-Today.Day + 1), Today.AddMonths(1).AddDays(-Today.Day))
        suma = tabla.Compute("SUM(costo)", "")

        Select Case suma
            Case Is < mensual1
                barraMeta.CreateGraphics.FillRectangle(Brushes.Red, New Rectangle(barraMeta.Width / 2, barraMeta.Height - (barraMeta.Height / mensual1 * suma), barraMeta.Width / 2, barraMeta.Height / mensual1 * suma))
        End Select
    End Sub
    Public Sub cambioServido()
        ordenTabla = VentasporordenyfechaTableAdapter1.GetData(Today, servidos, Today.AddDays(1))
        Label2.Text = "orden No.  " & servidos
        PEDIDOS.Items.Clear()
        For i = 0 To ordenTabla.Rows.Count - 1
            Dim ayuda As String = ordenTabla.Rows(i).Item("cantidad") & "  " & ordenTabla.Rows(i).Item("definicion") & "   Q" & ordenTabla.Rows(i).Item("costo")
            PEDIDOS.Items.Add(ayuda)
        Next

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        pasar = False
        If Not BanderaClave Then
            If e.KeyCode = ConsoleKey.Escape Then
                pedido = Nothing
                Label1.Text = ""
            ElseIf e.KeyCode = Keys.Enter Then
                cantidad.Visible = True
                cantidad.producto.Text = Label1.Text
                cantidad.NumericUpDown1.Select(0, 1)
            ElseIf e.KeyCode = Keys.Back Then
                If pedido.Length > 0 Then
                    pedido = pedido.Substring(0, pedido.Length - 1)
                    Label1.Text = pedido
                    If pedido.Length = 0 Then
                        pedido = Nothing
                        Label1.Text = ""
                    End If
                End If
            Else
                pasar = True
            End If
        End If
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, GroupBox1.KeyPress
        conosGalones.SelectionMode = SelectionMode.MultiSimple
        preparados.SelectionMode = SelectionMode.MultiSimple
        paletas.SelectionMode = SelectionMode.MultiSimple
        conosGalones.ClearSelected()
        preparados.ClearSelected()
        paletas.ClearSelected()

        If pasar Then
            If Not BanderaClave Then
                pedido = pedido & e.KeyChar
                Select Case pedido.Substring(0, 1)
                    Case "1", "2", "3", "6", "8"
                        If conosGalones.FindString(pedido) = -1 Then
                            MsgBox("no existe", MsgBoxStyle.OkOnly)
                            pedido = pedido.Substring(0, pedido.Length - 1)
                            conosGalones.SelectedIndex = conosGalones.FindString(pedido)
                        Else
                            conosGalones.SelectedIndex = conosGalones.FindString(pedido)
                            Label1.Text = conosGalones.SelectedItem
                        End If
                    Case "4", "5"
                        If preparados.FindString(pedido) = -1 Then
                            MsgBox("no existe", MsgBoxStyle.OkOnly)
                            pedido = pedido.Substring(0, pedido.Length - 1)
                            preparados.SelectedIndex = preparados.FindString(pedido)
                        Else
                            preparados.SelectedIndex = preparados.FindString(pedido)
                            Label1.Text = preparados.SelectedItem
                        End If
                    Case "7"
                        If paletas.FindString(pedido) = -1 Then
                            MsgBox("no existe", MsgBoxStyle.OkOnly)
                            pedido = pedido.Substring(0, pedido.Length - 1)
                            paletas.SelectedIndex = paletas.FindString(pedido)
                        Else
                            paletas.SelectedIndex = paletas.FindString(pedido)
                            Label1.Text = paletas.SelectedItem
                        End If
                End Select
                conosGalones.SelectionMode = SelectionMode.One
                preparados.SelectionMode = SelectionMode.One
                paletas.SelectionMode = SelectionMode.One
            End If
        End If
    End Sub

    Sub hojainventario()
        Dim cierreTablaDiario As New System.Data.DataTable
        Dim cierreTablaSemanal As System.Data.DataTable
        Dim ApExcel = New Microsoft.Office.Interop.Excel.Application
        Dim Libro = ApExcel.Workbooks.Add
        cierreTablaSemanal = InventarioDeRecetasTableAdapter.GetData(Today.AddDays(-8), Today)
        cierreTablaDiario.Columns.Add("descripcion")
        For i = 0 To cierreTablaSemanal.Rows.Count - 1
            Libro.Sheets(1).cells(2 + i, 2) = cierreTablaSemanal.Rows(i).Item("DESCRIPCION")
            cierreTablaDiario.Rows.Add(cierreTablaSemanal.Rows(i).Item("inventario"))
        Next
        For i = 0 To 7
            cierreTablaSemanal = InventarioDeRecetasTableAdapter.GetData(Today.AddDays(-8 + i), Today.AddDays(-7 + i))
            cierreTablaDiario.Columns.Add(Today.AddDays(-8 + i).DayOfWeek.ToString)
            For j = 0 To cierreTablaSemanal.Rows.Count - 1 ' buscando como encontrar el indice donde deb de pegar
                cierreTablaDiario.Rows(cierreTablaDiario.Rows.IndexOf(cierreTablaSemanal.Rows(j).Item("inventario"))).Item(j) = cierreTablaSemanal.Rows(j).Item("cantidad")
            Next
        Next
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.DefaultExt = "*.xlsx"
        SaveFileDialog1.FileName = "Inventario Molina " & Format(Today.Date, "ddmmyy")
        SaveFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
        Libro.SaveAs(SaveFileDialog1.FileName)
        Label1.Text = "El Archivo se creo y se guardo en:" & vbCrLf & Libro.FullName
        ApExcel.Quit()
        Libro = Nothing
        ApExcel = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Servicio.productofinal' Puede moverla o quitarla según sea necesario.
        Me.ProductofinalTableAdapter.Fill(Me.Servicio.productofinal)
        productos = ProductofinalTableAdapter.GetData
        If IsNothing(baseDatos.pedido) Then
            Dim pedidoaux As DataTable = InventarioporCodigoTableAdapter1.GetData("12101")
            baseDatos.pedido = pedidoaux.Clone
        End If
        For i = 0 To productos.Rows.Count - 1
            Select Case productos.Rows(i).Item(0).ToString.Substring(0, 1)
                Case 1, 2, 3, 6, 8
                    conosGalones.Items.Add(productos.Rows(i).Item(0).ToString.Substring(0, 2) & "     " & productos.Rows(i).Item(1) & "     Q" & Format(productos.Rows(i).Item("precio"), "0.00"))
                Case 4, 5
                    preparados.Items.Add(productos.Rows(i).Item(0).ToString.Substring(0, 2) & "     " & productos.Rows(i).Item(1) & "     Q" & Format(productos.Rows(i).Item("precio"), "0.00"))
                Case 7
                    paletas.Items.Add(productos.Rows(i).Item(0).ToString.Substring(0, 2) & "     " & productos.Rows(i).Item(1) & "     Q" & Format(productos.Rows(i).Item("precio"), "0.00"))
            End Select
        Next
        preparados.Visible = True
        orden = VentasTableAdapter1.ultimaOrden(Today, Today.AddDays(1)) + 1
        servidos = orden
        cambioServido()
        'creacion de la meta diaria----------------------------------------------------------------------------------------------------------------
        creacionmeta()
        'fin creacion de la meta diaria---------------------------------------------------------------------------------------------------------------
        actualizarmeta()
        'hoja inventario'--------------------------------------------------------------
        HojaInventario()
    End Sub
    Private Sub conosGalones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles conosGalones.SelectedIndexChanged
        If conosGalones.SelectedIndex <> -1 Then
            paletas.ClearSelected()
            preparados.ClearSelected()
        End If
    End Sub
    Private Sub preparados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles preparados.SelectedIndexChanged
        If preparados.SelectedIndex <> -1 Then
            conosGalones.ClearSelected()
            paletas.ClearSelected()
        End If
    End Sub
    Private Sub paletas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles paletas.SelectedIndexChanged
        If paletas.SelectedIndex <> -1 Then
            conosGalones.ClearSelected()
            preparados.ClearSelected()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If servidos <= VentasTableAdapter1.ultimaOrden(Today, Today.AddDays(1)) Then
            servidos += 1
            cambioServido()
        Else
            MsgBox("ultima orden", MsgBoxStyle.OkOnly)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If servidos > 0 Then
            servidos -= 1
            cambioServido()
        Else
            MsgBox("ultima orden", MsgBoxStyle.OkOnly)
        End If
    End Sub
    Private Sub CierreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreToolStripMenuItem.Click
        cierre.Visible = True
    End Sub
    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
        If clave.Text = "fRjapa" Then
            compras.subpedido = baseDatos.pedido.Clone
            compras.Visible = True
            clave.Text = ""
        Else
            MsgBox("clave incorrecta", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub CierreSemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreSemanalToolStripMenuItem.Click
        cierreSemanal.Visible = True
    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProductoToolStripMenuItem.Click
        agregarInventario.Visible = True
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        gastosIngresosExtra.Visible = True
    End Sub

    Private Sub NuevaRecetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaRecetaToolStripMenuItem.Click
        If clave.Text = "fRjapa" Then
            recetas.Visible = True
            clave.Text = ""
        Else
            MsgBox("clave incorrecta", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub CierreMensualYPorFechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreMensualYPorFechasToolStripMenuItem.Click
        If clave2.Text = "fRjapa" Then
            cierreMensual.Visible = True
            clave.Text = ""
            clave2.Text = ""
        Else
            MsgBox("clave incorrecta", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles clave.TextChanged
        If clave.Text = "armony" Then
            CierreSemanalToolStripMenuItem.Visible = True
            CierreMensualYPorFechasToolStripMenuItem.Visible = True
            HacerInventarioToolStripMenuItem.Visible = True
            HojaInventarioToolStripMenuItem.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CierreSemanalToolStripMenuItem.Visible = False
        CierreMensualYPorFechasToolStripMenuItem.Visible = False
        HacerInventarioToolStripMenuItem.Visible = False
        HojaInventarioToolStripMenuItem.Visible = False
        clave.Text = ""
        Timer1.Stop()
    End Sub

    Private Sub clave_Enter(sender As Object, e As EventArgs) Handles clave.Enter, clave2.Enter
        BanderaClave = True
    End Sub

    Private Sub clave_Leave(sender As Object, e As EventArgs) Handles clave.Leave, clave2.Leave
        BanderaClave = False
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If My.Settings.banOrdenServida = True Then
            Me.Close()
        Else
            MsgBox("no se a completado la ultima orden", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub CerrarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentaToolStripMenuItem.Click
        cantidad.Visible = True
    End Sub

    Private Sub RecepcionDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepcionDeProductoToolStripMenuItem.Click
        recivirPedido.Visible = True
    End Sub

    Private Sub TrasladoDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrasladoDeProductoToolStripMenuItem.Click
        compras.compraban = False
        compras.Visible = True
    End Sub

    Private Sub HacerInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HacerInventarioToolStripMenuItem.Click
        hacerinventario.Visible = True
    End Sub

 
End Class
