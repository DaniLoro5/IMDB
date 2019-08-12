Imports System.Data.OleDb
Imports Dominio
Public Class gestorRoles

    Private listaRol As Collection = New Collection

    Public Sub New()

    End Sub


    Public Property mListaRol As Collection
        Get
            Return listaRol
        End Get
        Set(value As Collection)
            Me.listaRol = value
        End Set
    End Property

    Public Sub read(r As Rol)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader

            d = a.leer(“SELECT * FROM Roles WHERE idRol=” & r._idRol & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la lectura de un rol: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub delete(r As Rol)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“DELETE FROM Roles WHERE idRol=” & r._idRol & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la eliminación de un rol: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub insert(r As Rol)

        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“INSERT INTO Roles (DescRol) VALUES ('” & r._descripcion & “');”)

        Catch ex As Exception
            MsgBox("Excepción en la inserción de un rol: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub update(r As Rol)
        Try
            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As Integer

            d = a.modificar(“UPDATE Roles SET descRol='” & r._descripcion & “' WHERE idRol=” & r._idRol & “;”)

        Catch ex As Exception
            MsgBox("Excepción en la modificación de un rol: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readAll()
        Try

            Dim a As AgenteDB = AgenteDB.getAgente()
            Dim d As OleDbDataReader
            Dim r As Rol
            d = a.leer("SELECT * FROM Roles ORDER BY idRol;")
            While (d.Read())
                r = New Rol(d.GetString(1))
                r._idRol = d.GetInt32(0)
                Me.listaRol.Add(r)
            End While
        Catch ex As Exception
            MsgBox("Excepción en la lectura de todos los roles: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
