<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gastosIngresosExtra
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ingreso = New System.Windows.Forms.RadioButton()
        Me.egreso = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ContabilidadmovimientosTableAdapter1 = New programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(120, 34)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(248, 20)
        Me.descripcion.TabIndex = 2
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(171, 104)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(197, 20)
        Me.Cantidad.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.descripcion)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(37, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 234)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'ingreso
        '
        Me.ingreso.AutoSize = True
        Me.ingreso.Location = New System.Drawing.Point(346, 33)
        Me.ingreso.Name = "ingreso"
        Me.ingreso.Size = New System.Drawing.Size(59, 17)
        Me.ingreso.TabIndex = 10
        Me.ingreso.Text = "ingreso"
        Me.ingreso.UseVisualStyleBackColor = True
        '
        'egreso
        '
        Me.egreso.AutoSize = True
        Me.egreso.Location = New System.Drawing.Point(345, 56)
        Me.egreso.Name = "egreso"
        Me.egreso.Size = New System.Drawing.Size(58, 17)
        Me.egreso.TabIndex = 9
        Me.egreso.Text = "Egreso"
        Me.egreso.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(346, 33)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "nada"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ContabilidadmovimientosTableAdapter1
        '
        Me.ContabilidadmovimientosTableAdapter1.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"banano", "futio", "pedido externo", "otro"})
        Me.ComboBox1.Location = New System.Drawing.Point(37, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(209, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'gastosIngresosExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 356)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.egreso)
        Me.Controls.Add(Me.ingreso)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Name = "gastosIngresosExtra"
        Me.Text = "gastosIngresosExtra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ingreso As System.Windows.Forms.RadioButton
    Friend WithEvents egreso As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents ContabilidadmovimientosTableAdapter1 As programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
