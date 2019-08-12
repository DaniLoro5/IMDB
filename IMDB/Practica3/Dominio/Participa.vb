Public Class Participa

    Private idPersona As Integer
    Private idPelicula As Integer
    Private idRol As Integer

    Public Sub New()

    End Sub

    Public Sub New(idPersona As Integer, idPelicula As Integer, idRol As Integer)
        Me.idPersona = idPersona
        Me.idPelicula = idPelicula
        Me.idRol = idRol
    End Sub

    Public Property _idPersona As Integer
        Get
            Return Me.idPersona
        End Get
        Set(value As Integer)
            Me.idPersona = value
        End Set
    End Property

    Public Property _idPelicula As Integer
        Get
            Return Me.idPelicula
        End Get
        Set(value As Integer)
            Me.idPelicula = value
        End Set
    End Property

    Public Property _idRol As Integer
        Get
            Return Me.idRol
        End Get
        Set(value As Integer)
            Me.idRol = value
        End Set
    End Property

    Public Sub eliminar(g)
        g.delete(Me)
    End Sub

    Public Sub insertar(g)
        g.insert(Me)
    End Sub

    Public Sub leerParticipa(g)
        g.read(Me)
    End Sub

    Public Sub leerTodos(g)
        g.readAll()
    End Sub

End Class
