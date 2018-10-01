Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String
    Private _equipo As Equipo
    Private _cliente As Cliente
    Sub New(codigoArea As UShort, numero As UInteger, equipo As Equipo, cliente As Cliente)
        Me.Numero = comprobarNro(numero, 100000, 9999999)
        Me.CodigoArea = comprobarNro(codigoArea, 100, 9999)
        Me.Equipo = equipo
        Me.Cliente = cliente
        reactivar()
    End Sub
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property
    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Set(value As Equipo)
            _equipo = value
        End Set
    End Property
    Public Property Numero As UInteger
        Get
            Return _numero

        End Get
        Set(value As UInteger)
            _numero = comprobarNro(value, 100000, 9999999)
        End Set
    End Property
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = comprobarNro(value, 100, 9999)
        End Set
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property
    Public Sub suspender()
        _estado = " suspendida"
    End Sub
    Public Sub reactivar()
        _estado = " activa"
    End Sub
    Private Function comprobarNro(nro As UInteger, minimo As UInteger, maximo As UInteger) As UInteger
        If nro > minimo And nro < maximo Then
            Return nro
        End If
    End Function
    Public Overrides Function ToString() As String
        Return CodigoArea & "-" & Numero & Estado
    End Function

End Class
