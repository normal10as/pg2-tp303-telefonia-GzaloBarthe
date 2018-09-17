Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String
    Sub New(codigoArea As UShort, numero As UInteger)
        Me.Numero = numero
        Me.CodigoArea = codigoArea
        reactivar()
    End Sub

    Public Property Numero As UInteger
        Get
            Return _numero

        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
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
        _estado = ""
    End Sub
    Public Overrides Function ToString() As String
        Return CodigoArea & "-" & Numero & Estado
    End Function

End Class
