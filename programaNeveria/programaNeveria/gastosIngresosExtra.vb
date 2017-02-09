Public Class gastosIngresosExtra

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Cantidad.TextChanged
        If Not IsNumeric(Cantidad.Text) Then
            If Cantidad.Text.Count > 2 Then
                Cantidad.Text = Cantidad.Text.Substring(0, Cantidad.Text.Count - 2)
            Else
                Cantidad.Text = ""
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles ingreso.CheckedChanged, egreso.CheckedChanged
        If ingreso.Checked Xor egreso.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub gastosIngresosExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ingreso.Checked Then
            ContabilidadmovimientosTableAdapter1.Nuevo(descripcion.Text, Val(Cantidad.Text), Now, 1)
        Else
            ContabilidadmovimientosTableAdapter1.Nuevo(descripcion.Text, -Val(Cantidad.Text), Now, 1)
        End If
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0, 1
                GroupBox1.Enabled = True
                descripcion.Text = ComboBox1.Text
                descripcion.Enabled = False
            Case 2
                GroupBox1.Enabled = True
                descripcion.Text = ComboBox1.Text & ";"
                descripcion.Enabled = False
            Case 3
                GroupBox1.Enabled = True
                descripcion.Enabled = True

        End Select
    End Sub
End Class