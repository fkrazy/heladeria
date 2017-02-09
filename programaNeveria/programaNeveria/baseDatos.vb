Module baseDatos
    Public pedido As DataTable
    Public Function solonumeros(texto As String) As String
        If Not IsNumeric(texto) Then
            If cantidad.Text.Count > 2 Then
                texto = texto.Substring(0, texto.Count - 2)
            Else
                texto = ""
            End If
        End If
        Return texto
    End Function
End Module
