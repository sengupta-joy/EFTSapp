Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports EFTSapp

Public Class ODBCDatalayer : Implements IDataLayer


    Private _cs As String

    Public Sub New(cs As String)
        _cs = cs
    End Sub


    Public Function SelectData(sql As String, Optional parameters As List(Of SqlParameter) = Nothing) As SqlResult Implements IDataLayer.SelectData
        Dim conn As New OdbcConnection(_cs)
        Dim cmd As New OdbcCommand(sql, conn)
        Dim da As New OdbcDataAdapter(cmd)
        Dim result As New SqlResult()

        Try
            conn.Open()

            If Not parameters Is Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If


            da.Fill(result.Data)
            result.Success = True
            conn.Close()
        Catch ex As Exception
            result.Success = False
            result.Message = ex.Message
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        Return result
    End Function

    Public Function ExecuteSP(sp As String, Optional parameters As List(Of SqlParameter) = Nothing) As SqlResult Implements IDataLayer.ExecuteSP
        Dim conn As New OdbcConnection(_cs)
        Dim cmd As New OdbcCommand(sp, conn)
        Dim da As New OdbcDataAdapter(cmd)
        Dim result As New SqlResult()

        Try
            conn.Open()

            If Not parameters Is Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If


            da.Fill(result.Data)
            result.Success = True
            conn.Close()
        Catch ex As Exception
            result.Success = False
            result.Message = ex.Message
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        Return result
    End Function
End Class
