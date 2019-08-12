Imports System.Data.OleDb
Imports Dominio

Public Class gestorParticipa

    Private listaParticipa As Collection
    Private listaPeliculasP As Collection
    Private listaRolP As Collection

    Public Sub New()

    End Sub

    Public Property mlistaParticipa As Collection
        Get
            Return Me.listaParticipa
        End Get
        Set(value As Collection)
            Me.listaParticipa = value
        End Set
    End Property

    Public Property mListaPeliculasP As Collection
        Get
            Return Me.listaPeliculasP
        End Get
        Set(value As Collection)
            Me.listaPeliculasP = value
        End Set
    End Property

    Public Property mListaRolP As Collection
        Get
            Return Me.listaRolP
        End Get
        Set(value As Collection)
            Me.listaRolP = value
        End Set
    End Property


    Public Sub read(participa As Participa)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim pelicula As Pelicula
            Dim rol As Rol

            d = a.leer(“SELECT Peliculas.titulo, Peliculas.AñoEstreno, Peliculas.Sinopsis, Peliculas.cartelPelicula FROM Participa, Peliculas WHERE Participa.Persona=" & participa._idPersona & " AND Participa.Pelicula = Peliculas.idPelicula;”)

            While d.Read()
                pelicula = New Pelicula(d.GetString(0), Nothing, Convert.ToInt32(d.GetValue(1)), Nothing, d.GetString(2), d.GetString(3))
                Me.listaPeliculasP.Add(pelicula)
            End While

            d = a.leer(“SELECT Roles.descRol FROM Participa, Roles WHERE Participa.Persona=" & participa._idPersona & " AND Participa.Rol = Roles.idRol;”)

            While d.Read()
                rol = New Rol(d.GetString(0))
                Me.listaRolP.Add(rol)
            End While

        Catch ex As Exception
            MsgBox("Excepción en la lectura en la tabla Participa: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub delete(p As Participa)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“DELETE FROM Participa WHERE Persona=” & p._idPersona & “ AND Pelicula=” & p._idPelicula & “ AND Rol=” & p._idRol & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la eliminación del participante: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub insert(p As Participa)

        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer = New Integer

            d = a.modificar(“INSERT INTO Participa (Persona, Pelicula, Rol) VALUES (” & p._idPersona & “,” & p._idPelicula & “,” & p._idRol & “);”)

        Catch ex As Exception
            MsgBox("Excepción en la inserción del participante en la película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readAll()
        Try

            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim p As Participa


            d = a.leer("SELECT * FROM Participa ORDER BY Persona;")
            While (d.Read())
                p = New Participa(d.GetInt32(0), d.GetInt32(1), d.GetInt32(2))
                Me.listaParticipa.Add(p)
            End While

        Catch ex As Exception
            MsgBox("Excepción en la lectura de la tabla Participa: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
