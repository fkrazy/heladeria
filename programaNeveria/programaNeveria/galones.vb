Public Class galones
    Dim tabla As DataTable
    Sub ok()
        cantidad.saborYjalea = tabla.Rows(DataGridView1.SelectedRows(0).Index).Item("idproductosNoUnicos")
        cantidad.Enabled = True
        Me.Close()
    End Sub
    Private Sub galones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla = ProductosnounicosTableAdapter.GetData(Form1.Label1.Text.Substring(0, 2))
        DataGridView1.DataSource = tabla
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ok()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cantidad.Close()
        Form1.pedido = Nothing
        Form1.Label1.Text = ""
        Me.Close()
    End Sub
End Class