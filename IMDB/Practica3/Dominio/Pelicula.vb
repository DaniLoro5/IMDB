
Public Class Pelicula

    Private idPelicula As Integer
    Private titulo As String
    Private tituloOriginal As String
    Private añoEstreno As Integer
    Private duracion As Integer
    Private sinopsis As String
    Private cartelPelicula As String

    Public Sub New()

    End Sub

    Public Sub New(titulo As String, tituloOriginal As String, añoEstreno As Integer, duracion As Integer, sinopsis As String, cartel As String)
        Me.titulo = titulo
        Me.tituloOriginal = tituloOriginal
        Me.añoEstreno = añoEstreno
        Me.duracion = duracion
        Me.sinopsis = sinopsis
        Me.cartelPelicula = cartel

    End Sub

    Public Property _idPelicula As Integer
        Get
            Return Me.idPelicula
        End Get
        Set(value As Integer)
            Me.idPelicula = value
        End Set
    End Property

    Public Property _titulo As String
        Get
            Return Me.titulo
        End Get
        Set(value As String)
            Me.titulo = value
        End Set
    End Property

    Public Property _tituloOriginal As String
        Get
            Return Me.tituloOriginal
        End Get
        Set(value As String)
            Me.tituloOriginal = value
        End Set
    End Property

    Public Property _añoEstreno As Integer
        Get
            Return Me.añoEstreno
        End Get
        Set(value As Integer)
            Me.añoEstreno = value
        End Set
    End Property

    Public Property _duracion As Integer
        Get
            Return Me.duracion
        End Get
        Set(value As Integer)
            Me.duracion = value
        End Set
    End Property

    Public Property _sinopsis As String
        Get
            Return Me.sinopsis
        End Get
        Set(value As String)
            Me.sinopsis = sinopsis
        End Set
    End Property

    Public Property _cartel As String
        Get
            Return Me.cartelPelicula
        End Get
        Set(value As String)
            Me.cartelPelicula = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return titulo
    End Function

    Public Sub eliminar(g)
        g.delete(Me)
    End Sub

    Public Sub insertar(g)
        g.insert(Me)
    End Sub

    Public Sub leerPelicula(ByVal titulo, g)
        g.read(Me)
    End Sub

    Public Sub leerTodos(g)
        g.readAll()
    End Sub

    Public Sub modificar(g)
        g.update(Me)
    End Sub
End Class
