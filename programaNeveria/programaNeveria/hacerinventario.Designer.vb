<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hacerinventario
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Inventarios = New programaNeveria.inventarios()
        Me.Inventariopormedida1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventariopormedida1TableAdapter = New programaNeveria.inventariosTableAdapters.inventariopormedida1TableAdapter()
        Me.Inventarios1 = New programaNeveria.inventarios()
        Me.RegistrohacverinventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrohacverinventarioTableAdapter = New programaNeveria.inventariosTableAdapters.registrohacverinventarioTableAdapter()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventariopormedida1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrohacverinventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(247, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese cantidad"
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.Location = New System.Drawing.Point(34, 54)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(128, 33)
        Me.titulo.TabIndex = 2
        Me.titulo.Text = "producto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(416, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Inventarios
        '
        Me.Inventarios.DataSetName = "inventarios"
        Me.Inventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Inventariopormedida1BindingSource
        '
        Me.Inventariopormedida1BindingSource.DataMember = "inventariopormedida1"
        Me.Inventariopormedida1BindingSource.DataSource = Me.Inventarios
        '
        'Inventariopormedida1TableAdapter
        '
        Me.Inventariopormedida1TableAdapter.ClearBeforeFill = True
        '
        'Inventarios1
        '
        Me.Inventarios1.DataSetName = "inventarios"
        Me.Inventarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrohacverinventarioBindingSource
        '
        Me.RegistrohacverinventarioBindingSource.DataMember = "registrohacverinventario"
        Me.RegistrohacverinventarioBindingSource.DataSource = Me.Inventarios1
        '
        'RegistrohacverinventarioTableAdapter
        '
        Me.RegistrohacverinventarioTableAdapter.ClearBeforeFill = True
        '
        'hacerinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 316)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "hacerinventario"
        Me.Text = "hacerinventario"
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventariopormedida1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventarios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrohacverinventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents titulo As System.Windows.Forms.Label
    Friend WithEvents Inventarios As programaNeveria.inventarios
    Friend WithEvents Inventariopormedida1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inventariopormedida1TableAdapter As programaNeveria.inventariosTableAdapters.inventariopormedida1TableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Inventarios1 As programaNeveria.inventarios
    Friend WithEvents RegistrohacverinventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrohacverinventarioTableAdapter As programaNeveria.inventariosTableAdapters.registrohacverinventarioTableAdapter
End Class
