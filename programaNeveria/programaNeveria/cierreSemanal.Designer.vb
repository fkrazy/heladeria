<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cierreSemanal
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Inventarios = New programaNeveria.inventarios()
        Me.CierrevariosDiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CierrevariosDiasTableAdapter = New programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.verExtras = New System.Windows.Forms.DataGridView()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Egresos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ingreso = New System.Windows.Forms.Label()
        Me.MovimientoPorFechaTableAdapter1 = New programaNeveria.contabilidadTableAdapters.movimientoPorFechaTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CierrevariosDiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(442, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(627, 189)
        Me.DataGridView1.TabIndex = 3
        '
        'Inventarios
        '
        Me.Inventarios.DataSetName = "inventarios"
        Me.Inventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CierrevariosDiasBindingSource
        '
        Me.CierrevariosDiasBindingSource.DataMember = "cierrevariosDias"
        Me.CierrevariosDiasBindingSource.DataSource = Me.Inventarios
        '
        'CierrevariosDiasTableAdapter
        '
        Me.CierrevariosDiasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ingresos"
        '
        'verExtras
        '
        Me.verExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.verExtras.Location = New System.Drawing.Point(37, 303)
        Me.verExtras.Name = "verExtras"
        Me.verExtras.Size = New System.Drawing.Size(624, 102)
        Me.verExtras.TabIndex = 16
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(154, 471)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(39, 13)
        Me.Total.TabIndex = 15
        Me.Total.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 471)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Ingreso total"
        '
        'Egresos
        '
        Me.Egresos.AutoSize = True
        Me.Egresos.Location = New System.Drawing.Point(154, 426)
        Me.Egresos.Name = "Egresos"
        Me.Egresos.Size = New System.Drawing.Size(39, 13)
        Me.Egresos.TabIndex = 12
        Me.Egresos.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Egresos:  "
        '
        'Ingreso
        '
        Me.Ingreso.AutoSize = True
        Me.Ingreso.Location = New System.Drawing.Point(154, 267)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Size = New System.Drawing.Size(39, 13)
        Me.Ingreso.TabIndex = 10
        Me.Ingreso.Text = "Label1"
        '
        'MovimientoPorFechaTableAdapter1
        '
        Me.MovimientoPorFechaTableAdapter1.ClearBeforeFill = True
        '
        'cierreSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 585)
        Me.Controls.Add(Me.verExtras)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Egresos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ingreso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "cierreSemanal"
        Me.Text = "cierreSemanal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CierrevariosDiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verExtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Inventarios As programaNeveria.inventarios
    Friend WithEvents CierrevariosDiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CierrevariosDiasTableAdapter As programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents verExtras As System.Windows.Forms.DataGridView
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Egresos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ingreso As System.Windows.Forms.Label
    Friend WithEvents MovimientoPorFechaTableAdapter1 As programaNeveria.contabilidadTableAdapters.movimientoPorFechaTableAdapter
End Class
