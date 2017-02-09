<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pago
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Servicio = New programaNeveria.servicio()
        Me.VentasporordenyfechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasporordenyfechaTableAdapter = New programaNeveria.servicioTableAdapters.ventasporordenyfechaTableAdapter()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Vuelto = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RecetasPorProductoTableAdapter1 = New programaNeveria.servicioTableAdapters.recetasPorProductoTableAdapter()
        Me.InventarioTableAdapter1 = New programaNeveria.inventariosTableAdapters.inventarioTableAdapter()
        Me.ProductosnounicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosnounicosTableAdapter = New programaNeveria.servicioTableAdapters.productosnounicosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasporordenyfechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosnounicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(78, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(633, 222)
        Me.DataGridView1.TabIndex = 0
        '
        'Servicio
        '
        Me.Servicio.DataSetName = "servicio"
        Me.Servicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasporordenyfechaBindingSource
        '
        Me.VentasporordenyfechaBindingSource.DataMember = "ventasporordenyfecha"
        Me.VentasporordenyfechaBindingSource.DataSource = Me.Servicio
        '
        'VentasporordenyfechaTableAdapter
        '
        Me.VentasporordenyfechaTableAdapter.ClearBeforeFill = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(348, 266)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(60, 25)
        Me.Total.TabIndex = 1
        Me.Total.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pago"
        '
        'Vuelto
        '
        Me.Vuelto.AutoSize = True
        Me.Vuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vuelto.Location = New System.Drawing.Point(348, 301)
        Me.Vuelto.Name = "Vuelto"
        Me.Vuelto.Size = New System.Drawing.Size(73, 25)
        Me.Vuelto.TabIndex = 4
        Me.Vuelto.Text = "Vuelto"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 266)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(684, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RecetasPorProductoTableAdapter1
        '
        Me.RecetasPorProductoTableAdapter1.ClearBeforeFill = True
        '
        'InventarioTableAdapter1
        '
        Me.InventarioTableAdapter1.ClearBeforeFill = True
        '
        'ProductosnounicosBindingSource
        '
        Me.ProductosnounicosBindingSource.DataMember = "productosnounicos"
        Me.ProductosnounicosBindingSource.DataSource = Me.Servicio
        '
        'ProductosnounicosTableAdapter
        '
        Me.ProductosnounicosTableAdapter.ClearBeforeFill = True
        '
        'pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Vuelto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "pago"
        Me.Text = "pago"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasporordenyfechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosnounicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VentasporordenyfechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Servicio As programaNeveria.servicio
    Friend WithEvents VentasporordenyfechaTableAdapter As programaNeveria.servicioTableAdapters.ventasporordenyfechaTableAdapter
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Vuelto As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RecetasPorProductoTableAdapter1 As programaNeveria.servicioTableAdapters.recetasPorProductoTableAdapter
    Friend WithEvents InventarioTableAdapter1 As programaNeveria.inventariosTableAdapters.inventarioTableAdapter
    Friend WithEvents ProductosnounicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosnounicosTableAdapter As programaNeveria.servicioTableAdapters.productosnounicosTableAdapter
End Class
