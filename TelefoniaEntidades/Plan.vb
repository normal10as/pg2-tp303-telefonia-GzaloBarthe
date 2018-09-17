Public MustInherit Class Plan
    Private _credito As UInteger
    Private _precio As Decimal
    Friend consumo As UInteger
    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property
    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property
    Public Function getDisponible() As UInteger
        Return Credito - consumo
    End Function
    Public Overridable Sub NuevoConsumo(valor As UInteger)
        If getDisponible() > valor Then
            consumo += valor
        Else
            Console.WriteLine("credito insuficiente")
        End If

    End Sub

End Class
