Public Class Modelo
    Private _nombre As String
    Private _marca As Marca
    Sub New(nombre As String, marca As Marca)
        Me.Nombre = nombre
        Me.Marca = marca
    End Sub
    Public Property Marca As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
