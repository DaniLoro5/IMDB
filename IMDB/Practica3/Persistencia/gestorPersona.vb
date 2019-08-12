Imports System.Data.OleDb
Imports Dominio

Public Class gestorPersona

    Private listaPersonas As Collection = New Collection

    Public Sub New()

    End Sub


    Public Property mListaPersonas As Collection
        Get
            Return listaPersonas
        End Get
        Set(value As Collection)
            Me.listaPersonas = value
        End Set
    End Property

    Public Sub read(p As Persona)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader

            d = a.leer(“SELECT * FROM Personas WHERE idPersona=” & p._idPersona & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la lectura de la persona: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub delete(p As Persona)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“DELETE FROM Personas WHERE idPersona=” & p._idPersona & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la eliminación de la persona: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub insert(p As Persona)

        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“INSERT INTO Personas(Nombre, Apellido, Nacionalidad, FechaNacimiento, CiudadNacimiento, PaisNacimiento, FotoPersona) VALUES ('” & p._nombre & “','” & p._apellido & “','” & p._nacionalidad & “','” & Convert.ToDateTime(p._fechaNacimiento) & “','” & p._ciudadNacimiento & “','” & p._paisNacimiento & “','” & p._fotoPersona & “');”)

        Catch ex As Exception
            MsgBox("Excepción en la inserción de la persona: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub update(p As Persona)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“UPDATE Personas SET Nombre='” & p._nombre & “', Apellido= '” & p._apellido & “', Nacionalidad='” & p._nacionalidad & “', FechaNacimiento ='” & Convert.ToDateTime(p._fechaNacimiento) & “', CiudadNacimiento= '” & p._ciudadNacimiento & “', PaisNacimiento= '” & p._paisNacimiento & “', fotoPersona= '” & p._fotoPersona & “' WHERE idPersona=” & p._idPersona & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la modificación de la persona: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readAll()

        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim p As Persona
            d = a.leer("SELECT * FROM Personas ORDER BY idPersona;")
            While (d.Read())
                p = New Persona(d.GetString(1), d.GetString(2), d.GetString(3), CType(d.GetValue(4), Date).ToShortDateString, d.GetString(5), d.GetString(6), d.GetString(7))
                p._idPersona = d.GetInt32(0)
                Me.listaPersonas.Add(p)
            End While
        Catch ex As Exception
            MsgBox("Excepción en la lectura de todas las personas: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
