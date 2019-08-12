

Public Class Persona

    Private idPersona As Integer
    Private nombre As String
    Private apellido As String
    Private nacionalidad As String
    Private fechaNacimiento As String
    Private ciudadNacimiento As String
    Private paisNacimiento As String
    Private fotoPersona As String

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, apellido As String, nacionalidad As String, fechaNacimiento As String, ciudadNacimiento As String, paisNacimiento As String, fotoPersona As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.nacionalidad = nacionalidad
        Me.fechaNacimiento = fechaNacimiento
        Me.ciudadNacimiento = ciudadNacimiento
        Me.paisNacimiento = paisNacimiento
        Me.fotoPersona = fotoPersona
    End Sub

    Public Property _idPersona As Integer
        Get
            Return Me.idPersona
        End Get
        Set(value As Integer)
            Me.idPersona = value
        End Set
    End Property

    Public Property _nombre As String
        Get
            Return Me.nombre
        End Get
        Set(value As String)
            Me.nombre = value
        End Set
    End Property

    Public Property _apellido As String
        Get
            Return Me.apellido
        End Get
        Set(value As String)
            Me.apellido = value
        End Set
    End Property

    Public Property _nacionalidad As String
        Get
            Return Me.nacionalidad
        End Get
        Set(value As String)
            Me.nacionalidad = value
        End Set
    End Property

    Public Property _fechaNacimiento As String
        Get
            Return Me.fechaNacimiento
        End Get
        Set(value As String)
            Me.fechaNacimiento = value
        End Set
    End Property

    Public Property _ciudadNacimiento As String
        Get
            Return Me.ciudadNacimiento
        End Get
        Set(value As String)
            Me.ciudadNacimiento = value
        End Set
    End Property

    Public Property _paisNacimiento As String
        Get
            Return Me.paisNacimiento
        End Get
        Set(value As String)
            Me.paisNacimiento = value
        End Set
    End Property

    Public Property _fotoPersona As String
        Get
            Return Me.fotoPersona
        End Get
        Set(value As String)
            Me.fotoPersona = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return nombre & " " & apellido
    End Function

    Public Sub eliminar(g)
        g.delete(Me)
    End Sub

    Public Sub insertar(g)
        g.insert(Me)
    End Sub

    Public Sub leerPersona(ByVal _idPersona, g)
        g.read(Me)
    End Sub

    Public Sub leerTodos(g)
        g.readAll()
    End Sub

    Public Sub modificar(g)
        g.update(Me)
    End Sub

End Class
