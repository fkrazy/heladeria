Public Class hacerinventario
    Dim puesto As Integer = 0
    Dim tabla As DataTable
    Dim mal As Integer = 0
    Private Sub hacerinventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventarios1.registrohacverinventario' Puede moverla o quitarla según sea necesario.
        Me.RegistrohacverinventarioTableAdapter.Fill(Me.Inventarios1.registrohacverinventario)
        'TODO: esta línea de código carga datos en la tabla 'Inventarios.inventariopormedida1' Puede moverla o quitarla según sea necesario.
        Me.Inventariopormedida1TableAdapter.Fill(Me.Inventarios.inventariopormedida1)
        tabla = Inventariopormedida1TableAdapter.GetData()
        titulo.Text = tabla.Rows(puesto).Item("descripcion")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = tabla.Rows(puesto).Item("cantidad") Then
            mal = 0
            puesto += 1
            titulo.Text = tabla.Rows(puesto).Item("descripcion")
        Else
            If mal < 3 Then
                mal += 1
                MsgBox("cantidad erronea", MsgBoxStyle.OkOnly, "intento No " & mal)
            Else
                RegistrohacverinventarioTableAdapter.Insert(Now, tabla.Rows(puesto).Item("codigo"))
                MsgBox("la cantidad era: " & tabla.Rows(puesto).Item("cantidad"), MsgBoxStyle.OkOnly)
                puesto += 1
                mal = 0
                titulo.Text = tabla.Rows(puesto).Item("descripcion")
            End If
        End If
    End Sub
End Class