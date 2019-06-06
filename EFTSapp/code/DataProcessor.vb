Imports System.Threading
Imports EFTSapp.code

Friend MustInherit Class AbstractProcessor

    Public Property ID As Integer
    Public Property Name As String
    Public Property SourceType As SourceType

    Protected Sub New(id As int)

    End Sub

    Public MustOverride Sub start()


End Class
