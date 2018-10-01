Public Class Cliente
    Private _cuenta As UInteger
    Private _lineas As New List(Of Linea)

    Sub New(cuenta As UInteger)
        Me.Cuenta = cuenta
    End Sub
    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property
    Public Function getAllLineas() As List(Of Linea)
        Return _lineas
    End Function
    Public Sub addLinea(linea As Linea)
        _lineas.Add(linea)
    End Sub
    Public Sub removeLinea(linea As Linea)
        _lineas.Remove(linea)
    End Sub
End Class
