Partial Class inventarios
    Partial Class cierrevariosDiasDataTable

        Private Sub cierrevariosDiasDataTable_cierrevariosDiasRowChanging(sender As Object, e As cierrevariosDiasRowChangeEvent) Handles Me.cierrevariosDiasRowChanging

        End Sub

    End Class

    Partial Class PedidodeinventarioDataTable

        Private Sub PedidodeinventarioDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.porpedirColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class

Namespace inventariosTableAdapters
    
    Partial Public Class inventarioTableAdapter
    End Class
End Namespace


Namespace inventariosTableAdapters

    Partial Public Class inventarioTableAdapter
    End Class
End Namespace

Namespace inventariosTableAdapters

    Partial Public Class inventarioTableAdapter
    End Class
End Namespace

Namespace inventariosTableAdapters

    Partial Public Class inventarioTableAdapter
    End Class
End Namespace

Namespace inventariosTableAdapters

    Partial Public Class cierrevariosDiasTableAdapter
    End Class
End Namespace
