<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recivirPedido
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
        Me.ver = New System.Windows.Forms.ListBox()
        Me.NoVinoBoton = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.PedidodeInventarioTableAdapter1 = New programaNeveria.inventariosTableAdapters.PedidodeInventarioTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InventarioTableAdapter1 = New programaNeveria.inventariosTableAdapters.inventarioTableAdapter()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ContabilidadmovimientosTableAdapter1 = New programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter()
        Me.SuspendLayout()
        '
        'ver
        '
        Me.ver.FormattingEnabled = True
        Me.ver.Location = New System.Drawing.Point(25, 52)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(293, 316)
        Me.ver.TabIndex = 0
        '
        'NoVinoBoton
        '
        Me.NoVinoBoton.Location = New System.Drawing.Point(393, 101)
        Me.NoVinoBoton.Name = "NoVinoBoton"
        Me.NoVinoBoton.Size = New System.Drawing.Size(75, 23)
        Me.NoVinoBoton.TabIndex = 1
        Me.NoVinoBoton.Text = "No vino"
        Me.NoVinoBoton.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Location = New System.Drawing.Point(393, 292)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(75, 23)
        Me.Siguiente.TabIndex = 2
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'PedidodeInventarioTableAdapter1
        '
        Me.PedidodeInventarioTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cubetas"
        '
        'InventarioTableAdapter1
        '
        Me.InventarioTableAdapter1.ClearBeforeFill = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(409, 25)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "Total"
        '
        'ContabilidadmovimientosTableAdapter1
        '
        Me.ContabilidadmovimientosTableAdapter1.ClearBeforeFill = True
        '
        'recivirPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 431)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Siguiente)
        Me.Controls.Add(Me.NoVinoBoton)
        Me.Controls.Add(Me.ver)
        Me.Name = "recivirPedido"
        Me.Text = "recivirPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ver As System.Windows.Forms.ListBox
    Friend WithEvents NoVinoBoton As System.Windows.Forms.Button
    Friend WithEvents Siguiente As System.Windows.Forms.Button
    Friend WithEvents PedidodeInventarioTableAdapter1 As programaNeveria.inventariosTableAdapters.PedidodeInventarioTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InventarioTableAdapter1 As programaNeveria.inventariosTableAdapters.inventarioTableAdapter
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents ContabilidadmovimientosTableAdapter1 As programaNeveria.contabilidadTableAdapters.contabilidadmovimientosTableAdapter
End Class
