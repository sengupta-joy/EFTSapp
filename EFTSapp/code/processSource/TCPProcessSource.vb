Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports EFTSapp

Friend Class TCPProcessSource : Inherits AbstractProcessSource


    Private _inwardQueue As Dictionary(Of Integer, TcpClient)

    Private listeningPort As System.Net.Sockets.TcpListener
    Private listenThead As Thread
    Private processThread As Thread

    Public Property InwardQueue As Dictionary(Of Integer, TcpClient)
        Get
            Return _inwardQueue
        End Get
        Private Set(value As Dictionary(Of Integer, TcpClient))
            _inwardQueue = value
        End Set
    End Property

    Public Sub New(sourceID As Integer)
        MyBase.New(sourceID)

        InwardQueue = New Dictionary(Of Integer, TcpClient)()

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
            InwardQueue.Add(client.GetHashCode(), client)
            processThread = New Thread(AddressOf ProcessResponse)
            processThread.Start(client)
        End While
    End Sub

    Private Sub ProcessResponse(client As TcpClient)
        Dim data = AppUtil.readStream(client)
        Thread.Sleep(1000)
        AppUtil.writeStream(client, "hello world")
        client.Close()
        Thread.CurrentThread.Abort()
        'entire process


    End Sub



    Public Overrides Sub reset()

    End Sub
End Class
