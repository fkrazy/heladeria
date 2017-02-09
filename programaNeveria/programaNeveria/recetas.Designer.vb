<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recetas
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
        Me.producto = New System.Windows.Forms.ComboBox()
        Me.ProductofinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servicio = New programaNeveria.servicio()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductofinalTableAdapter = New programaNeveria.servicioTableAdapters.productofinalTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inventario = New System.Windows.Forms.ComboBox()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventarios = New programaNeveria.inventarios()
        Me.InventarioTableAdapter = New programaNeveria.inventariosTableAdapters.inventarioTableAdapter()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New programaNeveria.contabilidadTableAdapters.TableAdapterManager()
        Me.RecetasPorProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecetasPorProductoTableAdapter = New programaNeveria.servicioTableAdapters.recetasPorProductoTableAdapter()
        Me.RecetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecetasTableAdapter = New programaNeveria.servicioTableAdapters.recetasTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.CostoCompra = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ProductofinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetasPorProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'producto
        '
        Me.producto.DataSource = Me.ProductofinalBindingSource
        Me.producto.DisplayMember = "definicion"
        Me.producto.FormattingEnabled = True
        Me.producto.Location = New System.Drawing.Point(198, 67)
        Me.producto.Name = "producto"
        Me.producto.Size = New System.Drawing.Size(251, 21)
        Me.producto.TabIndex = 2
        Me.producto.ValueMember = "idprodF"
        '
        'ProductofinalBindingSource
        '
        Me.ProductofinalBindingSource.DataMember = "productofinal"
        Me.ProductofinalBindingSource.DataSource = Me.Servicio
        '
        'Servicio
        '
        Me.Servicio.DataSetName = "servicio"
        Me.Servicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'ProductofinalTableAdapter
        '
        Me.ProductofinalTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 118)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(786, 175)
        Me.DataGridView1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Inventario"
        '
        'inventario
        '
        Me.inventario.DataSource = Me.InventarioBindingSource
        Me.inventario.DisplayMember = "DESCRIPCION"
        Me.inventario.FormattingEnabled = True
        Me.inventario.Location = New System.Drawing.Point(219, 306)
        Me.inventario.Name = "inventario"
        Me.inventario.Size = New System.Drawing.Size(369, 21)
        Me.inventario.TabIndex = 6
        Me.inventario.ValueMember = "codigo"
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
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(479, 370)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 7
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.contabilidadmovimientosTableAdapter = Nothing
        Me.TableAdapterManager1.gastosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = programaNeveria.contabilidadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecetasPorProductoBindingSource
        '
        Me.RecetasPorProductoBindingSource.DataMember = "recetasPorProducto"
        Me.RecetasPorProductoBindingSource.DataSource = Me.Servicio
        '
        'RecetasPorProductoTableAdapter
        '
        Me.RecetasPorProductoTableAdapter.ClearBeforeFill = True
        '
        'RecetasBindingSource
        '
        Me.RecetasBindingSource.DataMember = "recetas"
        Me.RecetasBindingSource.DataSource = Me.Servicio
        '
        'RecetasTableAdapter
        '
        Me.RecetasTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cantidad"
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(219, 348)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(175, 20)
        Me.cantidad.TabIndex = 9
        '
        'CostoCompra
        '
        Me.CostoCompra.AutoSize = True
        Me.CostoCompra.Location = New System.Drawing.Point(784, 314)
        Me.CostoCompra.Name = "CostoCompra"
        Me.CostoCompra.Size = New System.Drawing.Size(39, 13)
        Me.CostoCompra.TabIndex = 10
        Me.CostoCompra.Text = "Label5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Eliminar Ingrediente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'recetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 442)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CostoCompra)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.inventario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.producto)
        Me.Name = "recetas"
        Me.Text = "recetas"
        CType(Me.ProductofinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetasPorProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Servicio As programaNeveria.servicio
    Friend WithEvents ProductofinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductofinalTableAdapter As programaNeveria.servicioTableAdapters.productofinalTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents inventario As System.Windows.Forms.ComboBox
    Friend WithEvents Inventarios As programaNeveria.inventarios
    Friend WithEvents InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioTableAdapter As programaNeveria.inventariosTableAdapters.inventarioTableAdapter
    Friend WithEvents Agregar As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager1 As programaNeveria.contabilidadTableAdapters.TableAdapterManager
    Friend WithEvents RecetasPorProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecetasPorProductoTableAdapter As programaNeveria.servicioTableAdapters.recetasPorProductoTableAdapter
    Friend WithEvents RecetasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecetasTableAdapter As programaNeveria.servicioTableAdapters.recetasTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cantidad As System.Windows.Forms.TextBox
    Friend WithEvents CostoCompra As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
