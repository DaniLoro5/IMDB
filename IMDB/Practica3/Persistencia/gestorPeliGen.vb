Imports System.Data.OleDb
Imports Dominio

Public Class gestorPeliGen

    Private listaPeliGen As Collection
    Private listaGenerosPG As Collection
    Private listaPersonasPG As Collection

    Public Sub New()

    End Sub

    Public Property mlistaPeliGen As Collection
        Get
            Return Me.listaPeliGen
        End Get
        Set(value As Collection)
            Me.listaPeliGen = value
        End Set
    End Property


    Public Property mListaGenerosPG As Collection
        Get
            Return Me.listaGenerosPG
        End Get
        Set(value As Collection)
            Me.listaGenerosPG = value
        End Set
    End Property

    Public Property mListaPersonasPG As Collection
        Get
            Return Me.listaPersonasPG
        End Get
        Set(value As Collection)
            Me.listaPersonasPG = value
        End Set
    End Property


    Public Function read(PeliGen As PeliGen)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim persona As Persona
            Dim genero As Genero

            d = a.leer(“SELECT Generos.idGenero, Generos.descGenero FROM PeliGen, Generos WHERE PeliGen.Pelicula =" & PeliGen._idPelicula & " AND PeliGen.Genero = Generos.idGenero ;”)

            While d.Read()
                genero = New Genero(d.GetString(1))
                genero._idGenero = d.GetInt32(0)
                Me.listaGenerosPG.Add(genero)
            End While

            d = a.leer("SELECT Personas.idPersona, Personas.nombre FROM Participa, Personas WHERE Participa.Pelicula =" & PeliGen._idPelicula & " AND Participa.Persona = Personas.idPersona;")

            While d.Read()
                persona = New Persona(d.GetString(1), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                persona._idPersona = d.GetInt32(0)
                Me.listaPersonasPG.Add(persona)
            End While

        Catch ex As Exception
            MsgBox("Excepción en readPG: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    Public Sub delete(pg As PeliGen)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“DELETE FROM PeliGen WHERE Pelicula=” & pg._idPelicula & “ AND Genero=” & pg._idGenero & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la eliminación en la tabla PeliGen: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub insert(pg As PeliGen)

        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer = New Integer

            d = a.modificar(“INSERT INTO PeliGen (Pelicula, Genero) VALUES (” & pg._idPelicula & “,” & pg._idGenero & “);”)

        Catch ex As Exception
            MsgBox("Excepción en la inserción en la tabla PeliGen: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readAll()
        Try

            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim pg As PeliGen
            d = a.leer("SELECT * FROM PeliGen ORDER BY Pelicula;")
            While (d.Read())
                pg = New PeliGen(d.GetInt32(0), d.GetInt32(1))
                Me.listaPeliGen.Add(pg)
            End While
        Catch ex As Exception
            MsgBox("Excepción en la lectura de la tabla PeliGen" & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
