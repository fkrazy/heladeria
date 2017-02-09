<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compras
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
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.precioTotal1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBlitros = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.otrosradialbutton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.eliminarP1 = New System.Windows.Forms.Button()
        Me.CantidadporPedido1 = New System.Windows.Forms.NumericUpDown()
        Me.cubetas = New System.Windows.Forms.RadioButton()
        Me.Vasitos = New System.Windows.Forms.RadioButton()
        Me.pedirP1 = New System.Windows.Forms.Button()
        Me.Medios = New System.Windows.Forms.RadioButton()
        Me.Existencia = New System.Windows.Forms.Label()
        Me.paletas = New System.Windows.Forms.RadioButton()
        Me.Pintas = New System.Windows.Forms.RadioButton()
        Me.compra = New System.Windows.Forms.NumericUpDown()
        Me.pedido1 = New System.Windows.Forms.ListBox()
        Me.listado = New System.Windows.Forms.ListBox()
        Me.minimo = New System.Windows.Forms.NumericUpDown()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.EliminarGeneral = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Contabilidad = New programaNeveria.contabilidad()
        Me.ContabilidadmovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContabilidadmovimientosTableAdapter = New programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventarios = New programaNeveria.inventarios()
        Me.InventarioTableAdapter = New programaNeveria.inventariosTableAdapters.inventarioTableAdapter()
        Me.InventarioporCodigoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioporCodigoTableAdapter = New programaNeveria.inventariosTableAdapters.inventarioporCodigoTableAdapter()
        Me.PedidodeInventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidodeInventarioTableAdapter = New programaNeveria.inventariosTableAdapters.PedidodeinventarioTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CantidadporPedido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContabilidadmovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioporCodigoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidodeInventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(890, 464)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 8
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(39, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1077, 571)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.precioTotal1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.RBlitros)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.otrosradialbutton)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.eliminarP1)
        Me.TabPage1.Controls.Add(Me.CantidadporPedido1)
        Me.TabPage1.Controls.Add(Me.cubetas)
        Me.TabPage1.Controls.Add(Me.Vasitos)
        Me.TabPage1.Controls.Add(Me.pedirP1)
        Me.TabPage1.Controls.Add(Me.Medios)
        Me.TabPage1.Controls.Add(Me.Existencia)
        Me.TabPage1.Controls.Add(Me.paletas)
        Me.TabPage1.Controls.Add(Me.Pintas)
        Me.TabPage1.Controls.Add(Me.compra)
        Me.TabPage1.Controls.Add(Me.pedido1)
        Me.TabPage1.Controls.Add(Me.listado)
        Me.TabPage1.Controls.Add(Me.minimo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1069, 545)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "hacer pedido"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'precioTotal1
        '
        Me.precioTotal1.Location = New System.Drawing.Point(514, 410)
        Me.precioTotal1.Name = "precioTotal1"
        Me.precioTotal1.Size = New System.Drawing.Size(100, 20)
        Me.precioTotal1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(327, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cantidad por pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(395, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidad"
        '
        'RBlitros
        '
        Me.RBlitros.AutoSize = True
        Me.RBlitros.Location = New System.Drawing.Point(423, 50)
        Me.RBlitros.Name = "RBlitros"
        Me.RBlitros.Size = New System.Drawing.Size(59, 17)
        Me.RBlitros.TabIndex = 11
        Me.RBlitros.Text = "0 Litros"
        Me.RBlitros.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio total"
        '
        'otrosradialbutton
        '
        Me.otrosradialbutton.AutoSize = True
        Me.otrosradialbutton.Location = New System.Drawing.Point(588, 50)
        Me.otrosradialbutton.Name = "otrosradialbutton"
        Me.otrosradialbutton.Size = New System.Drawing.Size(57, 17)
        Me.otrosradialbutton.TabIndex = 1
        Me.otrosradialbutton.Text = "0 otros"
        Me.otrosradialbutton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Minimo"
        '
        'eliminarP1
        '
        Me.eliminarP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminarP1.Location = New System.Drawing.Point(463, 291)
        Me.eliminarP1.Name = "eliminarP1"
        Me.eliminarP1.Size = New System.Drawing.Size(151, 57)
        Me.eliminarP1.TabIndex = 4
        Me.eliminarP1.Text = "<- borrar"
        Me.eliminarP1.UseVisualStyleBackColor = True
        '
        'CantidadporPedido1
        '
        Me.CantidadporPedido1.Location = New System.Drawing.Point(559, 447)
        Me.CantidadporPedido1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.CantidadporPedido1.Name = "CantidadporPedido1"
        Me.CantidadporPedido1.Size = New System.Drawing.Size(55, 20)
        Me.CantidadporPedido1.TabIndex = 2
        '
        'cubetas
        '
        Me.cubetas.AutoSize = True
        Me.cubetas.Location = New System.Drawing.Point(20, 50)
        Me.cubetas.Name = "cubetas"
        Me.cubetas.Size = New System.Drawing.Size(76, 17)
        Me.cubetas.TabIndex = 0
        Me.cubetas.Text = " 0 Cubetas"
        Me.cubetas.UseVisualStyleBackColor = True
        '
        'Vasitos
        '
        Me.Vasitos.AutoSize = True
        Me.Vasitos.Location = New System.Drawing.Point(310, 50)
        Me.Vasitos.Name = "Vasitos"
        Me.Vasitos.Size = New System.Drawing.Size(68, 17)
        Me.Vasitos.TabIndex = 0
        Me.Vasitos.Text = "0 Vasitos"
        Me.Vasitos.UseVisualStyleBackColor = True
        '
        'pedirP1
        '
        Me.pedirP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pedirP1.Location = New System.Drawing.Point(463, 198)
        Me.pedirP1.Name = "pedirP1"
        Me.pedirP1.Size = New System.Drawing.Size(151, 57)
        Me.pedirP1.TabIndex = 4
        Me.pedirP1.Text = "pedir ->"
        Me.pedirP1.UseVisualStyleBackColor = True
        '
        'Medios
        '
        Me.Medios.AutoSize = True
        Me.Medios.Location = New System.Drawing.Point(103, 50)
        Me.Medios.Name = "Medios"
        Me.Medios.Size = New System.Drawing.Size(110, 17)
        Me.Medios.TabIndex = 0
        Me.Medios.Text = "0 Medios Galones"
        Me.Medios.UseVisualStyleBackColor = True
        '
        'Existencia
        '
        Me.Existencia.AutoSize = True
        Me.Existencia.Location = New System.Drawing.Point(395, 163)
        Me.Existencia.Name = "Existencia"
        Me.Existencia.Size = New System.Drawing.Size(55, 13)
        Me.Existencia.TabIndex = 3
        Me.Existencia.Text = "Existencia"
        '
        'paletas
        '
        Me.paletas.AutoSize = True
        Me.paletas.Location = New System.Drawing.Point(501, 50)
        Me.paletas.Name = "paletas"
        Me.paletas.Size = New System.Drawing.Size(71, 17)
        Me.paletas.TabIndex = 0
        Me.paletas.Text = "0  paletas"
        Me.paletas.UseVisualStyleBackColor = True
        '
        'Pintas
        '
        Me.Pintas.AutoSize = True
        Me.Pintas.Location = New System.Drawing.Point(225, 50)
        Me.Pintas.Name = "Pintas"
        Me.Pintas.Size = New System.Drawing.Size(63, 17)
        Me.Pintas.TabIndex = 0
        Me.Pintas.Text = "0 Pintas"
        Me.Pintas.UseVisualStyleBackColor = True
        '
        'compra
        '
        Me.compra.Location = New System.Drawing.Point(576, 101)
        Me.compra.Name = "compra"
        Me.compra.Size = New System.Drawing.Size(55, 20)
        Me.compra.TabIndex = 2
        Me.compra.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pedido1
        '
        Me.pedido1.FormattingEnabled = True
        Me.pedido1.Location = New System.Drawing.Point(721, 94)
        Me.pedido1.Name = "pedido1"
        Me.pedido1.Size = New System.Drawing.Size(271, 407)
        Me.pedido1.TabIndex = 1
        '
        'listado
        '
        Me.listado.FormattingEnabled = True
        Me.listado.Location = New System.Drawing.Point(50, 92)
        Me.listado.Name = "listado"
        Me.listado.Size = New System.Drawing.Size(271, 407)
        Me.listado.TabIndex = 1
        '
        'minimo
        '
        Me.minimo.Location = New System.Drawing.Point(559, 380)
        Me.minimo.Name = "minimo"
        Me.minimo.Size = New System.Drawing.Size(55, 20)
        Me.minimo.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Aceptar)
        Me.TabPage4.Controls.Add(Me.EliminarGeneral)
        Me.TabPage4.Controls.Add(Me.TotalLabel)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1069, 545)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Pedido Total"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'EliminarGeneral
        '
        Me.EliminarGeneral.Location = New System.Drawing.Point(765, 464)
        Me.EliminarGeneral.Name = "EliminarGeneral"
        Me.EliminarGeneral.Size = New System.Drawing.Size(75, 23)
        Me.EliminarGeneral.TabIndex = 10
        Me.EliminarGeneral.Text = "Eliminar"
        Me.EliminarGeneral.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(823, 413)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(45, 13)
        Me.TotalLabel.TabIndex = 9
        Me.TotalLabel.Text = "Label13"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 16)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(973, 373)
        Me.DataGridView1.TabIndex = 0
        '
        'Contabilidad
        '
        Me.Contabilidad.DataSetName = "contabilidad"
        Me.Contabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContabilidadmovimientosBindingSource
        '
        Me.ContabilidadmovimientosBindingSource.DataMember = "contabilidadmovimientos"
        Me.ContabilidadmovimientosBindingSource.DataSource = Me.Contabilidad
        '
        'ContabilidadmovimientosTableAdapter
        '
        Me.ContabilidadmovimientosTableAdapter.ClearBeforeFill = True
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "inventario"
        Me.InventarioBindingSource.DataSource = Me.Inventarios
        '
        'Inventarios
        '
        Me.Inventarios.DataSetName = "inventarios"
        Me.Inventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'InventarioporCodigoBindingSource
        '
        Me.InventarioporCodigoBindingSource.DataMember = "inventarioporCodigo"
        Me.InventarioporCodigoBindingSource.DataSource = Me.Inventarios
        '
        'InventarioporCodigoTableAdapter
        '
        Me.InventarioporCodigoTableAdapter.ClearBeforeFill = True
        '
        'PedidodeInventarioBindingSource
        '
        Me.PedidodeInventarioBindingSource.DataMember = "PedidodeInventario"
        Me.PedidodeInventarioBindingSource.DataSource = Me.Inventarios
        '
        'PedidodeInventarioTableAdapter
        '
        Me.PedidodeInventarioTableAdapter.ClearBeforeFill = True
        '
        'compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 643)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "compras"
        Me.Text = "compras"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CantidadporPedido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContabilidadmovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioporCodigoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidodeInventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Inventarios As programaNeveria.inventarios
    Friend WithEvents InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioTableAdapter As programaNeveria.inventariosTableAdapters.inventarioTableAdapter
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Contabilidad As programaNeveria.contabilidad
    Friend WithEvents ContabilidadmovimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContabilidadmovimientosTableAdapter As programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents eliminarP1 As System.Windows.Forms.Button
    Friend WithEvents pedirP1 As System.Windows.Forms.Button
    Friend WithEvents Existencia As System.Windows.Forms.Label
    Friend WithEvents minimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents compra As System.Windows.Forms.NumericUpDown
    Friend WithEvents pedido1 As System.Windows.Forms.ListBox
    Friend WithEvents listado As System.Windows.Forms.ListBox
    Friend WithEvents Vasitos As System.Windows.Forms.RadioButton
    Friend WithEvents Pintas As System.Windows.Forms.RadioButton
    Friend WithEvents Medios As System.Windows.Forms.RadioButton
    Friend WithEvents cubetas As System.Windows.Forms.RadioButton
    Friend WithEvents InventarioporCodigoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioporCodigoTableAdapter As programaNeveria.inventariosTableAdapters.inventarioporCodigoTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents otrosradialbutton As System.Windows.Forms.RadioButton
    Friend WithEvents paletas As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents precioTotal1 As System.Windows.Forms.TextBox
    Friend WithEvents CantidadporPedido1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents PedidodeInventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidodeInventarioTableAdapter As programaNeveria.inventariosTableAdapters.PedidodeInventarioTableAdapter
    Friend WithEvents EliminarGeneral As System.Windows.Forms.Button
    Friend WithEvents RBlitros As System.Windows.Forms.RadioButton
End Class
