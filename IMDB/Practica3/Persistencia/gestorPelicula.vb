Imports System.Data.OleDb
Imports Dominio

Public Class gestorPelicula

    Private listaPeliculas As Collection = New Collection

    Public Sub New()

    End Sub


    Public Property mListaPeliculas As Collection
        Get
            Return listaPeliculas
        End Get
        Set(value As Collection)
            Me.listaPeliculas = value
        End Set
    End Property

    Public Sub read(p As Pelicula)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader

            d = a.leer(“SELECT * FROM Peliculas WHERE idPelicula=” & p._idPelicula & “;”)


        Catch ex As Exception
            MsgBox("Excepción en la lectura de una película: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub delete(p As Pelicula)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“DELETE FROM Peliculas WHERE idPelicula=” & p._idPelicula & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la eliminación de la película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub insert(p As Pelicula)

        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer = New Integer

            d = a.modificar(“INSERT INTO Peliculas (Titulo, TituloOriginal, AñoEstreno, Duración, Sinopsis, CartelPelicula) VALUES ('” & p._titulo & “','” & p._tituloOriginal & “','” & p._añoEstreno & “','” & p._duracion & “','” & p._sinopsis & “','” & p._cartel & “');”)

        Catch ex As Exception
            MsgBox("Excepción en la inserción de la película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub update(p As Pelicula)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer
            d = a.modificar(“UPDATE Peliculas SET Titulo='” & p._titulo & “', tituloOriginal= '” & p._tituloOriginal & “', añoEstreno=” & p._añoEstreno & “, duración=” & p._duracion & “, sinopsis= '” & p._sinopsis & “', CartelPelicula= '” & p._cartel & “' WHERE idPelicula=” & p._idPelicula & “;”)
        Catch ex As Exception
            MsgBox("Excepción en la modificación de la película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readAll()
        Try

            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim p As Pelicula
            d = a.leer("SELECT * FROM Peliculas ORDER BY idPelicula;")
            While (d.Read())
                p = New Pelicula(d.GetString(1), d.GetString(2), Convert.ToInt32(d.GetValue(3)), Convert.ToInt32(d.GetValue(4)), d.GetString(5), d.GetString(6))
                p._idPelicula = d.GetInt32(0)
                Me.listaPeliculas.Add(p)
            End While
        Catch ex As Exception
            MsgBox("Error en la lectura de todas las películas: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
