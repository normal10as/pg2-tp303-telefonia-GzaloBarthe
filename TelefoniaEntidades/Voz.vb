Public Class Voz
    Inherits Plan
    Sub New(credito As UInteger, precio As Decimal)
        MyBase.Credito = credito
        MyBase.Precio = precio
    End Sub
    Public Overrides Function ToString() As String
        Return getDisponible() & "minutos"
    End Function
End Class
