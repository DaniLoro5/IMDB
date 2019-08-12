Public Class PeliGen

    Private idPelicula As Integer
    Private idGenero As Integer

    Public Sub New()

    End Sub

    Public Sub New(idPelicula As Integer, idGenero As Integer)
        Me.idPelicula = idPelicula
        Me.idGenero = idGenero
    End Sub

    Public Property _idPelicula As Integer
        Get
            Return Me.idPelicula
        End Get
        Set(value As Integer)
            Me.idPelicula = value
        End Set
    End Property

    Public Property _idGenero As Integer
        Get
            Return Me.idGenero
        End Get
        Set(value As Integer)
            Me.idGenero = value
        End Set
    End Property

    Public Sub eliminar(g)
        g.delete(Me)
    End Sub

    Public Sub insertar(g)
        g.insert(Me)
    End Sub

    Public Sub leerPeliGen(g)
        g.read(Me)
    End Sub

    Public Sub leerTodos(g)
        g.readAll()
    End Sub

End Class
