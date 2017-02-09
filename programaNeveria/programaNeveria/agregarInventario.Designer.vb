<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarInventario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.costo = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.medida = New System.Windows.Forms.ComboBox()
        Me.MedidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventarios = New programaNeveria.inventarios()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioTableAdapter = New programaNeveria.inventariosTableAdapters.inventarioTableAdapter()
        Me.MedidasTableAdapter = New programaNeveria.inventariosTableAdapters.medidasTableAdapter()
        CType(Me.MedidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "costo unitario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "medida"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(329, 19)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(81, 20)
        Me.codigo.TabIndex = 5
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(179, 49)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(231, 20)
        Me.descripcion.TabIndex = 2
        '
        'costo
        '
        Me.costo.Location = New System.Drawing.Point(179, 80)
        Me.costo.Name = "costo"
        Me.costo.Size = New System.Drawing.Size(231, 20)
        Me.costo.TabIndex = 3
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(179, 106)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(231, 20)
        Me.cantidad.TabIndex = 4
        '
        'medida
        '
        Me.medida.DataSource = Me.MedidasBindingSource
        Me.medida.DisplayMember = "identificador"
        Me.medida.FormattingEnabled = True
        Me.medida.Location = New System.Drawing.Point(179, 138)
        Me.medida.Name = "medida"
        Me.medida.Size = New System.Drawing.Size(231, 21)
        Me.medida.TabIndex = 6
        Me.medida.ValueMember = "idmedidas"
        '
        'MedidasBindingSource
        '
        Me.MedidasBindingSource.DataMember = "medidas"
        Me.MedidasBindingSource.DataSource = Me.Inventarios
        '
        'Inventarios
        '
        Me.Inventarios.DataSetName = "inventarios"
        Me.Inventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "inventario"
        Me.InventarioBindingSource.DataSource = Me.Inventarios
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'MedidasTableAdapter
        '
        Me.MedidasTableAdapter.ClearBeforeFill = True
        '
        'agregarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 231)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.medida)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.costo)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "agregarInventario"
        Me.Text = "agregarInventario"
        CType(Me.MedidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents costo As System.Windows.Forms.TextBox
    Friend WithEvents cantidad As System.Windows.Forms.TextBox
    Friend WithEvents medida As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Inventarios As programaNeveria.inventarios
    Friend WithEvents InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioTableAdapter As programaNeveria.inventariosTableAdapters.inventarioTableAdapter
    Friend WithEvents MedidasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasTableAdapter As programaNeveria.inventariosTableAdapters.medidasTableAdapter
End Class
