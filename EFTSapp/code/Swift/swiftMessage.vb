Imports EFTSapp

Public Class swiftMessage
    Private _b1 As absBlock
    Private _b2 As absBlock
    Private _b3 As absBlock
    Private _b4 As absBlock
    Private _b5 As absBlock

    Public Shared Function Parse(SwiftMessage As String) As swiftMessage
        Dim matches = System.Text.RegularExpressions.Regex.Match(SwiftMessage, "({[0-5]:)")
        Dim x = matches.Length
    End Function

    Public Property Block1 As absBlock
        Get
            Return _b1
        End Get
        Set(value As absBlock)
            _b1 = value
        End Set
    End Property

    Public Property Block2 As absBlock
        Get
            Return _b2
        End Get
        Set(value As absBlock)
            _b2 = value
        End Set
    End Property

    Public Property Block3 As absBlock
        Get
            Return _b3
        End Get
        Set(value As absBlock)
            _b3 = value
        End Set
    End Property

    Public Property Block4 As absBlock
        Get
            Return _b4
        End Get
        Set(value As absBlock)
            _b4 = value
        End Set
    End Property

    Public Property Block5 As absBlock
        Get
            Return _b5
        End Get
        Set(value As absBlock)
            _b5 = value
        End Set
    End Property
End Class
