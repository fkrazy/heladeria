<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cierre
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
        Me.Ingreso = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CierrevariosDiasTableAdapter1 = New programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Egresos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.verExtras = New System.Windows.Forms.DataGridView()
        Me.ContabilidadmovimientosTableAdapter1 = New programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter()
        Me.Contabilidad = New programaNeveria.contabilidad()
        Me.MovimientoPorFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovimientoPorFechaTableAdapter = New programaNeveria.contabilidadTableAdapters.movimientoPorFechaTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoPorFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(627, 168)
        Me.DataGridView1.TabIndex = 0
        '
        'Servicio
        '
        Me.Servicio.DataSetName = "servicio"
        Me.Servicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ingreso
        '
        Me.Ingreso.AutoSize = True
        Me.Ingreso.Location = New System.Drawing.Point(132, 243)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Size = New System.Drawing.Size(39, 13)
        Me.Ingreso.TabIndex = 1
        Me.Ingreso.Text = "Label1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(417, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'CierrevariosDiasTableAdapter1
        '
        Me.CierrevariosDiasTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingresos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Egresos:  "
        '
        'Egresos
        '
        Me.Egresos.AutoSize = True
        Me.Egresos.Location = New System.Drawing.Point(132, 402)
        Me.Egresos.Name = "Egresos"
        Me.Egresos.Size = New System.Drawing.Size(39, 13)
        Me.Egresos.TabIndex = 5
        Me.Egresos.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ingreso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(132, 447)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(39, 13)
        Me.Total.TabIndex = 8
        Me.Total.Text = "Label5"
        '
        'verExtras
        '
        Me.verExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.verExtras.Location = New System.Drawing.Point(15, 279)
        Me.verExtras.Name = "verExtras"
        Me.verExtras.Size = New System.Drawing.Size(624, 102)
        Me.verExtras.TabIndex = 9
        '
        'ContabilidadmovimientosTableAdapter1
        '
        Me.ContabilidadmovimientosTableAdapter1.ClearBeforeFill = True
        '
        'Contabilidad
        '
        Me.Contabilidad.DataSetName = "contabilidad"
        Me.Contabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovimientoPorFechaBindingSource
        '
        Me.MovimientoPorFechaBindingSource.DataMember = "movimientoPorFecha"
        Me.MovimientoPorFechaBindingSource.DataSource = Me.Contabilidad
        '
        'MovimientoPorFechaTableAdapter
        '
        Me.MovimientoPorFechaTableAdapter.ClearBeforeFill = True
        '
        'cierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 540)
        Me.Controls.Add(Me.verExtras)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Egresos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Ingreso)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "cierre"
        Me.Text = "cierre"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoPorFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Servicio As programaNeveria.servicio
    Friend WithEvents Ingreso As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CierrevariosDiasTableAdapter1 As programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Egresos As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents ContabilidadmovimientosTableAdapter1 As programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter
    Friend WithEvents Contabilidad As programaNeveria.contabilidad
    Friend WithEvents MovimientoPorFechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MovimientoPorFechaTableAdapter As programaNeveria.contabilidadTableAdapters.movimientoPorFechaTableAdapter
    Friend WithEvents verExtras As System.Windows.Forms.DataGridView
End Class
