<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cierreMensual
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
        Me.verExtras = New System.Windows.Forms.DataGridView()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Egresos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ingreso = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inicio = New System.Windows.Forms.DateTimePicker()
        Me.fin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CierrevariosDiasTableAdapter1 = New programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter()
        Me.MovimientoPorFechaTableAdapter1 = New programaNeveria.contabilidadTableAdapters.movimientoPorFechaTableAdapter()
        CType(Me.verExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'verExtras
        '
        Me.verExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.verExtras.Location = New System.Drawing.Point(54, 349)
        Me.verExtras.Name = "verExtras"
        Me.verExtras.Size = New System.Drawing.Size(624, 102)
        Me.verExtras.TabIndex = 24
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(171, 517)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(39, 13)
        Me.Total.TabIndex = 23
        Me.Total.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 517)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Ingreso total"
        '
        'Egresos
        '
        Me.Egresos.AutoSize = True
        Me.Egresos.Location = New System.Drawing.Point(171, 472)
        Me.Egresos.Name = "Egresos"
        Me.Egresos.Size = New System.Drawing.Size(39, 13)
        Me.Egresos.TabIndex = 20
        Me.Egresos.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Egresos:  "
        '
        'Ingreso
        '
        Me.Ingreso.AutoSize = True
        Me.Ingreso.Location = New System.Drawing.Point(171, 313)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Size = New System.Drawing.Size(39, 13)
        Me.Ingreso.TabIndex = 18
        Me.Ingreso.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(54, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(627, 189)
        Me.DataGridView1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Ingresos"
        '
        'inicio
        '
        Me.inicio.Location = New System.Drawing.Point(478, 12)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(200, 20)
        Me.inicio.TabIndex = 25
        '
        'fin
        '
        Me.fin.Location = New System.Drawing.Point(478, 52)
        Me.fin.Name = "fin"
        Me.fin.Size = New System.Drawing.Size(200, 20)
        Me.fin.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Fecha Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(394, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Fecha final"
        '
        'CierrevariosDiasTableAdapter1
        '
        Me.CierrevariosDiasTableAdapter1.ClearBeforeFill = True
        '
        'MovimientoPorFechaTableAdapter1
        '
        Me.MovimientoPorFechaTableAdapter1.ClearBeforeFill = True
        '
        'cierreMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 572)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inicio)
        Me.Controls.Add(Me.verExtras)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Egresos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ingreso)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "cierreMensual"
        Me.Text = "cierreMensual"
        CType(Me.verExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents verExtras As System.Windows.Forms.DataGridView
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Egresos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ingreso As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CierrevariosDiasTableAdapter1 As programaNeveria.inventariosTableAdapters.cierrevariosDiasTableAdapter
    Friend WithEvents MovimientoPorFechaTableAdapter1 As programaNeveria.contabilidadTableAdapters.movimientoPorFechaTableAdapter
End Class
