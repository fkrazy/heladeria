<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.conosGalones = New System.Windows.Forms.ListBox()
        Me.preparados = New System.Windows.Forms.ListBox()
        Me.paletas = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.barraMeta = New System.Windows.Forms.PictureBox()
        Me.PEDIDOS = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreSemanalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreMensualYPorFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HacerInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecepcionDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrasladoDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaRecetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Servicio = New programaNeveria.servicio()
        Me.ProductofinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductofinalTableAdapter = New programaNeveria.servicioTableAdapters.productofinalTableAdapter()
        Me.VentasporordenyfechaTableAdapter1 = New programaNeveria.servicioTableAdapters.ventasporordenyfechaTableAdapter()
        Me.VentasTableAdapter1 = New programaNeveria.servicioTableAdapters.ventasTableAdapter()
        Me.clave = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.clave2 = New System.Windows.Forms.TextBox()
        Me.Inventarios = New programaNeveria.inventarios()
        Me.CierrevariosDiasTableAdapter1 = New programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter()
        Me.InventarioporCodigoTableAdapter1 = New programaNeveria.inventariosTableAdapters.inventarioporCodigoTableAdapter()
        Me.InventarioDeRecetasTableAdapter = New programaNeveria.inventariosTableAdapters.inventarioDeRecetasTableAdapter()
        Me.Inventarios1 = New programaNeveria.inventarios()
        Me.InventarioDeRecetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovimientoPorFechaTableAdapter1 = New programaNeveria.contabilidadTableAdapters.movimientoPorFechaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.barraMeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductofinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDeRecetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'conosGalones
        '
        Me.conosGalones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conosGalones.FormattingEnabled = True
        Me.conosGalones.ItemHeight = 20
        Me.conosGalones.Location = New System.Drawing.Point(16, 19)
        Me.conosGalones.Name = "conosGalones"
        Me.conosGalones.Size = New System.Drawing.Size(299, 544)
        Me.conosGalones.TabIndex = 1
        '
        'preparados
        '
        Me.preparados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preparados.FormattingEnabled = True
        Me.preparados.ItemHeight = 20
        Me.preparados.Location = New System.Drawing.Point(345, 19)
        Me.preparados.Name = "preparados"
        Me.preparados.Size = New System.Drawing.Size(286, 544)
        Me.preparados.TabIndex = 1
        '
        'paletas
        '
        Me.paletas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paletas.FormattingEnabled = True
        Me.paletas.ItemHeight = 20
        Me.paletas.Location = New System.Drawing.Point(649, 19)
        Me.paletas.Name = "paletas"
        Me.paletas.Size = New System.Drawing.Size(265, 544)
        Me.paletas.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.barraMeta)
        Me.GroupBox1.Controls.Add(Me.conosGalones)
        Me.GroupBox1.Controls.Add(Me.paletas)
        Me.GroupBox1.Controls.Add(Me.preparados)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 618)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'barraMeta
        '
        Me.barraMeta.Location = New System.Drawing.Point(315, 18)
        Me.barraMeta.Name = "barraMeta"
        Me.barraMeta.Size = New System.Drawing.Size(28, 544)
        Me.barraMeta.TabIndex = 2
        Me.barraMeta.TabStop = False
        '
        'PEDIDOS
        '
        Me.PEDIDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PEDIDOS.FormattingEnabled = True
        Me.PEDIDOS.ItemHeight = 20
        Me.PEDIDOS.Location = New System.Drawing.Point(988, 146)
        Me.PEDIDOS.Name = "PEDIDOS"
        Me.PEDIDOS.Size = New System.Drawing.Size(257, 324)
        Me.PEDIDOS.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(985, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Orden No: 1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1115, 492)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "orden &servida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1144, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "orden anterior"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramaToolStripMenuItem, Me.ContabilidadToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramaToolStripMenuItem
        '
        Me.ProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.CerrarVentaToolStripMenuItem})
        Me.ProgramaToolStripMenuItem.Name = "ProgramaToolStripMenuItem"
        Me.ProgramaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ProgramaToolStripMenuItem.Text = "programa"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SalirToolStripMenuItem.Text = "salir"
        '
        'CerrarVentaToolStripMenuItem
        '
        Me.CerrarVentaToolStripMenuItem.Name = "CerrarVentaToolStripMenuItem"
        Me.CerrarVentaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CerrarVentaToolStripMenuItem.Text = "cerrar venta"
        '
        'ContabilidadToolStripMenuItem
        '
        Me.ContabilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GastosToolStripMenuItem, Me.CierreToolStripMenuItem, Me.CierreSemanalToolStripMenuItem, Me.CierreMensualYPorFechasToolStripMenuItem})
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ContabilidadToolStripMenuItem.Text = "contabilidad"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.GastosToolStripMenuItem.Text = "gastos/ingresos Extra"
        '
        'CierreToolStripMenuItem
        '
        Me.CierreToolStripMenuItem.Name = "CierreToolStripMenuItem"
        Me.CierreToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CierreToolStripMenuItem.Text = "cierre diario"
        '
        'CierreSemanalToolStripMenuItem
        '
        Me.CierreSemanalToolStripMenuItem.Name = "CierreSemanalToolStripMenuItem"
        Me.CierreSemanalToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CierreSemanalToolStripMenuItem.Text = "cierre semanal"
        Me.CierreSemanalToolStripMenuItem.Visible = False
        '
        'CierreMensualYPorFechasToolStripMenuItem
        '
        Me.CierreMensualYPorFechasToolStripMenuItem.Name = "CierreMensualYPorFechasToolStripMenuItem"
        Me.CierreMensualYPorFechasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CierreMensualYPorFechasToolStripMenuItem.Text = "cierre mensual y por fechas"
        Me.CierreMensualYPorFechasToolStripMenuItem.Visible = False
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HacerInventarioToolStripMenuItem, Me.CompraToolStripMenuItem, Me.NuevoProductoToolStripMenuItem, Me.RecepcionDeProductoToolStripMenuItem, Me.TrasladoDeProductoToolStripMenuItem, Me.HojaInventarioToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "inventario"
        '
        'HacerInventarioToolStripMenuItem
        '
        Me.HacerInventarioToolStripMenuItem.Name = "HacerInventarioToolStripMenuItem"
        Me.HacerInventarioToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.HacerInventarioToolStripMenuItem.Text = "hacer inventario"
        Me.HacerInventarioToolStripMenuItem.Visible = False
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CompraToolStripMenuItem.Text = "compra"
        '
        'NuevoProductoToolStripMenuItem
        '
        Me.NuevoProductoToolStripMenuItem.Name = "NuevoProductoToolStripMenuItem"
        Me.NuevoProductoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.NuevoProductoToolStripMenuItem.Text = "nuevo producto"
        '
        'RecepcionDeProductoToolStripMenuItem
        '
        Me.RecepcionDeProductoToolStripMenuItem.Name = "RecepcionDeProductoToolStripMenuItem"
        Me.RecepcionDeProductoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RecepcionDeProductoToolStripMenuItem.Text = "recepcion de producto"
        '
        'TrasladoDeProductoToolStripMenuItem
        '
        Me.TrasladoDeProductoToolStripMenuItem.Name = "TrasladoDeProductoToolStripMenuItem"
        Me.TrasladoDeProductoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TrasladoDeProductoToolStripMenuItem.Text = "traslado de producto"
        '
        'HojaInventarioToolStripMenuItem
        '
        Me.HojaInventarioToolStripMenuItem.Name = "HojaInventarioToolStripMenuItem"
        Me.HojaInventarioToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.HojaInventarioToolStripMenuItem.Text = "Hoja Inventario"
        Me.HojaInventarioToolStripMenuItem.Visible = False
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaRecetaToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "productos"
        '
        'NuevaRecetaToolStripMenuItem
        '
        Me.NuevaRecetaToolStripMenuItem.Name = "NuevaRecetaToolStripMenuItem"
        Me.NuevaRecetaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.NuevaRecetaToolStripMenuItem.Text = "nueva receta"
        '
        'Servicio
        '
        Me.Servicio.DataSetName = "servicio"
        Me.Servicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductofinalBindingSource
        '
        Me.ProductofinalBindingSource.DataMember = "productofinal"
        Me.ProductofinalBindingSource.DataSource = Me.Servicio
        '
        'ProductofinalTableAdapter
        '
        Me.ProductofinalTableAdapter.ClearBeforeFill = True
        '
        'VentasporordenyfechaTableAdapter1
        '
        Me.VentasporordenyfechaTableAdapter1.ClearBeforeFill = True
        '
        'VentasTableAdapter1
        '
        Me.VentasTableAdapter1.ClearBeforeFill = True
        '
        'clave
        '
        Me.clave.Location = New System.Drawing.Point(258, 27)
        Me.clave.Name = "clave"
        Me.clave.Size = New System.Drawing.Size(176, 20)
        Me.clave.TabIndex = 8
        Me.clave.UseSystemPasswordChar = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'clave2
        '
        Me.clave2.Location = New System.Drawing.Point(460, 27)
        Me.clave2.Name = "clave2"
        Me.clave2.Size = New System.Drawing.Size(188, 20)
        Me.clave2.TabIndex = 9
        Me.clave2.UseSystemPasswordChar = True
        '
        'Inventarios
        '
        Me.Inventarios.DataSetName = "inventarios"
        Me.Inventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CierrevariosDiasTableAdapter1
        '
        Me.CierrevariosDiasTableAdapter1.ClearBeforeFill = True
        '
        'InventarioporCodigoTableAdapter1
        '
        Me.InventarioporCodigoTableAdapter1.ClearBeforeFill = True
        '
        'InventarioDeRecetasTableAdapter
        '
        Me.InventarioDeRecetasTableAdapter.ClearBeforeFill = True
        '
        'Inventarios1
        '
        Me.Inventarios1.DataSetName = "inventarios"
        Me.Inventarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventarioDeRecetasBindingSource
        '
        Me.InventarioDeRecetasBindingSource.DataMember = "inventarioDeRecetas"
        Me.InventarioDeRecetasBindingSource.DataSource = Me.Inventarios1
        '
        'MovimientoPorFechaTableAdapter1
        '
        Me.MovimientoPorFechaTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1276, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.clave2)
        Me.Controls.Add(Me.clave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PEDIDOS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "n"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.barraMeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductofinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventarios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDeRecetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents preparados As System.Windows.Forms.ListBox
    Friend WithEvents paletas As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PEDIDOS As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Servicio As programaNeveria.servicio
    Friend WithEvents ProductofinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductofinalTableAdapter As programaNeveria.servicioTableAdapters.productofinalTableAdapter
    Friend WithEvents conosGalones As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VentasporordenyfechaTableAdapter1 As programaNeveria.servicioTableAdapters.ventasporordenyfechaTableAdapter
    Friend WithEvents VentasTableAdapter1 As programaNeveria.servicioTableAdapters.ventasTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ContabilidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreSemanalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaRecetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreMensualYPorFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clave As System.Windows.Forms.TextBox
    Friend WithEvents barraMeta As System.Windows.Forms.PictureBox
    Friend WithEvents CierrevariosDiasTableAdapter1 As programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents clave2 As System.Windows.Forms.TextBox
    Friend WithEvents ProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioporCodigoTableAdapter1 As programaNeveria.inventariosTableAdapters.inventarioporCodigoTableAdapter
    Friend WithEvents RecepcionDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrasladoDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HacerInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojaInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Inventarios As programaNeveria.inventarios
    Friend WithEvents InventarioDeRecetasTableAdapter As programaNeveria.inventariosTableAdapters.inventarioDeRecetasTableAdapter
    Friend WithEvents Inventarios1 As programaNeveria.inventarios
    Friend WithEvents InventarioDeRecetasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MovimientoPorFechaTableAdapter1 As contabilidadTableAdapters.movimientoPorFechaTableAdapter
End Class
