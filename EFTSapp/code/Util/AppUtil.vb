Imports System.Net.Sockets
Imports System.Text

Public Class AppUtil


    Public Shared Function readStream(clnt As TcpClient) As String
        Dim buffer(1024) As Byte
        Dim numberOfBytesRead As Integer
        Dim myCompleteMessage As New StringBuilder(String.Empty)
        Dim ns As NetworkStream = clnt.GetStream()

        Do
            numberOfBytesRead = ns.Read(buffer, 0, buffer.Length)
            myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(buffer, 0, numberOfBytesRead))
        Loop While ns.DataAvailable

        Return myCompleteMessage.ToString()
    End Function

    Public Shared Function writeStream(clnt As TcpClient, data As String) As Boolean
        Dim ns As NetworkStream = clnt.GetStream()

        Try
            Dim myBytes() As Byte = Encoding.ASCII.GetBytes(data)
            ns.Write(myBytes, 0, myBytes.Length)
        Catch ex As Exception
            logWriterObj.write(ex.Message)
        End Try


        Return True
    End Function

End Class
