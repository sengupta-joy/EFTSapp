﻿Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Xml
Imports EFTSapp



Friend Class TCPProcessSource : Inherits AbstractProcessSource


    Private _inwardQueue As Dictionary(Of Integer, TcpClient)

    Private listeningPort As System.Net.Sockets.TcpListener
    Private listenThead As Thread
    Private processThread As Thread

    Structure ProcessParam
        Dim ID As Guid
        Dim Client As TcpClient
    End Structure

    Public Sub New(sourceID As Integer, process As APPProcessor)
        MyBase.New(sourceID, process)


        Dim ip As IPAddress

        If Configurations("ip") Is Nothing Then
            ip = IPAddress.Parse("127.0.0.1")
        Else
            ip = IPAddress.Parse(Configurations("ip"))
        End If

        listeningPort = New Net.Sockets.TcpListener(ip, Configurations("port"))
        listenThead = New Thread(AddressOf startListen)

    End Sub
    Public Overrides Sub start()
        listeningPort.Start()
        listenThead.Start()
    End Sub
    Private Sub startListen()


        While True
            Dim client = listeningPort.AcceptTcpClient()
            MainProcess.LastExecutionTime = Now
            Dim procParam As New ProcessParam()
            procParam.ID = MessageProcessQueue.InsertNew()
            procParam.Client = client

            processThread = New Thread(AddressOf ProcessResponse)
            processThread.Start(procParam)
        End While
    End Sub

    Private Sub ProcessResponse(param As ProcessParam)
        Dim data = AppUtil.readStream(param.Client)

        MessageProcessQueue.addItem(param.ID, "inwardMessage", data)
        Dim doc = New XmlDocument()
        doc.LoadXml(data)


        For Each dest As AbstractProcessDestination In MainProcess.Destinatons
            If dest.isValid(param.ID) Then
                dest.go(param.ID)
            End If
        Next

        data = IO.File.ReadAllText(Application.StartupPath + "\response.xml")

        AppUtil.writeStream(param.Client, data)
        param.Client.Close()
        Thread.CurrentThread.Abort()
        'entire process


    End Sub



    Public Overrides Sub reset()

    End Sub
End Class
