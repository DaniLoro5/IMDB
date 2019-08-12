Imports System.Data.OleDb
Imports Dominio
Public Class gestorGeneros

    Private listaGeneros As Collection = New Collection

    Public Sub New()

    End Sub

    Public Property mListaGeneros As Collection
        Get
            Return listaGeneros
        End Get
        Set(value As Collection)
            Me.listaGeneros = value
        End Set
    End Property

    Public Sub read(g As Genero)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader

            d = a.leer(“SELECT * FROM Generos WHERE idGenero=” & g._idGenero & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la lectura de una género: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub delete(g As Genero)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“DELETE FROM Generos WHERE idGenero=” & g._idGenero & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la eliminación de un género: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub insert(g As Genero)

        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer = New Integer

            d = a.modificar(“INSERT INTO Generos (DescGenero) VALUES ('” & g._descripcion & “');”)

        Catch ex As Exception
            MsgBox("Excepción en la inserción de un género: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub update(g As Genero)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“UPDATE Generos SET DescGenero='” & g._descripcion & “' WHERE idGenero=” & g._idGenero & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la actualización del género: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readAll()
        Try

            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim g As Genero
            d = a.leer("SELECT * FROM Generos ORDER BY idGenero;")
            While (d.Read())
                g = New Genero(d.GetString(1))
                g._idGenero = d.GetInt32(0)
                Me.listaGeneros.Add(g)
            End While
        Catch ex As Exception
            MsgBox("Excepción en la lectura de todos los géneros: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
