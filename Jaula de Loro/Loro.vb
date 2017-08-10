Public Class Loro
    Private _Memoria As Queue(Of String)
    Public _Edad As Short
    Public _FechaNacimiento As Date
    Public _Nombre As String
    Public cadena As String
    Sub New()
        _Nombre = " "
        _FechaNacimiento = Nothing
        _Memoria = New Queue(Of String)
        _edad = Nothing
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Sub Escuchar(frase As String)
        Memoria.Enqueue(frase)
    End Sub

    Public Function Hablar() As String
        If Memoria.Count > 0 Then
            cadena &= Memoria.Dequeue
            Return cadena
        Else
            Return cadena
        End If
    End Function
    Private Property Memoria As Queue(Of String)
        Get
            Return _Memoria
        End Get
        Set(value As Queue(Of String))
            _Memoria = value
        End Set
    End Property
    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
        End Set
    End Property
    Private Function CalcularEdad(FechaNacimiento As Date) As UShort
        Return DateDiff(DateInterval.Year, FechaNacimiento, Date.Now)
    End Function

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property


End Class
