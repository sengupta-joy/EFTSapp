Imports System.Text.RegularExpressions
Imports EFTSapp

Public Class swiftMessage
    Private _b1 As absBlock
    Private _b2 As absBlock
    Private _b3 As absBlock
    Private _b4 As absBlock
    Private _b5 As absBlock

    Public Shared Function Parse(SwiftMessage As String) As swiftMessage
        Dim reg As New Regex("{[1-5]:")
        Dim matches As Match = reg.Match(SwiftMessage)
        Dim match = matches
        Dim tab As New DataTable("swift")
        Dim index As Integer = 0
        tab.Columns.Add("name")
        tab.Columns.Add("Stating")
        tab.Columns.Add("Ending")
        tab.Columns.Add("Data")


        While (Not match.Value.Equals(String.Empty))
            tab.Rows.Add(match.Value, match.Index, "", "")

            match = match.NextMatch()
            index = index + 1
        End While

        For i = 0 To index - 1
            If i = 0 Then
                tab.Rows(0)("Ending") = tab.Rows(i + 1)("Stating")
            ElseIf i = index - 1 Then
                tab.Rows(i)("Ending") = Len(SwiftMessage)
            Else
                tab.Rows(i)("Ending") = tab.Rows(i + 1)("Stating")
            End If
            tab.Rows(i)("data") = Mid(SwiftMessage, tab.Rows(i)("Stating") + 4, (tab.Rows(i)("Ending") - (tab.Rows(i)("Stating") + 4)))
        Next




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
