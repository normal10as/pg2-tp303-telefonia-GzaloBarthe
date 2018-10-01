Public Class Equipo
    Private _serie As String
    Private _fechaVenta As Date
    Private _mod As Modelo


    Sub New(modelo As Modelo, serie As String)
        Me.Serie = serie
        Me.Modelo = modelo
    End Sub
    Public Property Modelo As Modelo
        Get
            Return _mod
        End Get
        Set(value As Modelo)
            _mod = value
        End Set
    End Property
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Me.Serie
    End Function
    Public Sub vender(hoy As Date)
        _fechaVenta = hoy
    End Sub

End Class
