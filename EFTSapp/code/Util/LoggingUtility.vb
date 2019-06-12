Imports System.Text

Public Class LoggingUtility

    Private Shared path As String
    Public Sub New()
    End Sub

    Shared Sub New()
        path = Application.StartupPath

        Try
            If IO.Directory.Exists(path + "\LOG") Then
                FileIO.FileSystem.RenameDirectory(path + "\LOG", "LOG-" + Now.ToShortDateString().Replace("/", "_") + "-" + Now.ToString("hh_mm_ss"))
            End If

            IO.Directory.CreateDirectory(path + "\LOG")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub write(message As String)
        Dim sb As StringBuilder
        Dim fileName = "\log\app.log"

        renameIfLarge(fileName)
        message = Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt") + " - " + message
        sb = New StringBuilder(message)
        sb.Append(vbCrLf + "-------------------------------------------------")
        sb.Append(vbCrLf + "-------------------------------------------------")
        sb.Append(vbCrLf)

        IO.File.AppendAllText(path + fileName, sb.ToString())
    End Sub
    Public Sub write(messageID As Guid, message As String)

    End Sub

    Private Sub renameIfLarge(filename As String)
        Dim fl As IO.FileInfo

        If Not IO.File.Exists(path + filename) Then
            Return
        End If

        fl = New IO.FileInfo(path + filename)
        If fl.Length >= 1024 * 1024 Then

            Dim filepath = fl.FullName.Replace(fl.Extension, "") + "." + Now.ToShortDateString().Replace("/", "_") + "-" + Now.ToString("hh_mm_ss") + ".log"
            Try
                fl.MoveTo(filepath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        fl = Nothing
    End Sub

    Public Shared Function getLogConfig() As Dictionary(Of String, String)
        Dim sql As String = "select * from tbl_log_config"
        Dim resp = db.SelectData(sql)
        Dim result As New Dictionary(Of String, String)

        If resp.Success Then
            For Each row In resp.Data.Tables(0).Rows
                result.Add(row("param_key"), row("param_value"))
            Next
        End If

        Return result
    End Function

    Public Shared Function saveLogConfig(data As Dictionary(Of String, String)) As Boolean

    End Function

End Class
