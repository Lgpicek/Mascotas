Public Class Cotorra
    Inherits Loro
    Public _EdadHumana As UShort
    Sub New()
        _Nombre = " "
        _FechaNacimiento = Nothing
        _Edad = Nothing
    End Sub

    Public ReadOnly Property EdadHumana As UShort
        Get
            Return _Edad ^ 2
        End Get

    End Property
End Class
