Imports System.Data.OleDb

Public Class AgenteDB
    Private Shared CadConexion = “Provider=Microsoft.ACE.OLEDB.12.0; Data Source=“
    Private Shared mConexion As OleDbConnection
    Private Shared mInstancia As AgenteDB
    Private Shared rutaBD As String

    Private Sub New()
        AgenteDB.mConexion = New OleDbConnection(CadConexion & rutaBD)
        AgenteDB.mConexion.Open()
    End Sub

    Public Shared Property _rutaBD As String
        Get
            Return rutaBD
        End Get
        Set(value As String)
            rutaBD = value
        End Set
    End Property


    Public Shared Function getAgente() As AgenteDB
        If mInstancia Is Nothing Then
            mInstancia = New AgenteDB()
        End If
        Return mInstancia
    End Function


    Public Function leer(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function

    Public Function modificar(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function
End Class
