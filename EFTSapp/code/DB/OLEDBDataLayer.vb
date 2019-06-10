Imports System.Data.OleDb


Public Class OLEDBDataLayer : Implements IDataLayer

    Private _cs As String

    Public Sub New(cs As String)
        _cs = cs
    End Sub

    Public Function SelectData(sql As String, Optional parameters As List(Of SqlClient.SqlParameter) = Nothing) As SqlResult Implements IDataLayer.SelectData
        Dim conn As New OleDbConnection(_cs)
        Dim cmd As New OleDbCommand(sql, conn)
        Dim da As New OleDbDataAdapter(cmd)
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
    Public Function ExecuteSP(sp As String, Optional parameters As List(Of SqlClient.SqlParameter) = Nothing) As SqlResult Implements IDataLayer.ExecuteSP
        Dim conn As New OleDbConnection(_cs)
        Dim cmd As New OleDbCommand(sp, conn)
        Dim da As New OleDbDataAdapter(cmd)
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
