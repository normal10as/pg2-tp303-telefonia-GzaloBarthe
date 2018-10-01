Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String
    Sub New(codigoArea As UShort, numero As UInteger)
        Me.Numero = comprobarNro(numero, 1000000, 9999999)
        Me.CodigoArea = comprobarNro(codigoArea, 100, 9999)
        reactivar()
    End Sub

    Public Property Numero As UInteger
        Get
            Return _numero

        End Get
        Set(value As UInteger)
            _numero = comprobarNro(value, 1000000, 9999999)
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
        _estado = "activa"
    End Sub
    Private Function comprobarNro(nro As UInteger, minimo As UInteger, maximo) As UInteger
        If nro > minimo And nro < maximo Then
            Return nro
        End If
    End Function
    Public Overrides Function ToString() As String
        Return CodigoArea & "-" & Numero & Estado
    End Function

End Class
