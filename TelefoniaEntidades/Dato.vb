Public Class Dato
    Inherits Plan
    Sub New(credito As UInteger, precio As Decimal)
        MyBase.Credito = credito
        MyBase.Precio = precio
    End Sub
    Public Overrides Sub NuevoConsumo(valor As UInteger)
        Dim megas As UInteger
        megas = valor / 1024
        If getDisponible() > megas Then
            consumo += megas
        Else
            Console.WriteLine("credito insuficiente")
        End If

    End Sub
    Public Overrides Function ToString() As String
        Return getDisponible() & "Mbytes"
    End Function

End Class
