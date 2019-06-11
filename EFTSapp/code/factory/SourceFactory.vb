Imports EFTSapp
Imports EFTSapp.code

Friend Class SourceFactory

    Friend Shared Function make(sourceID As Integer, process As APPProcessor) As AbstractProcessSource

        Dim sql As String = "select * from tbl_source where source_id=" + sourceID.ToString()
        Dim result = db.SelectData(sql)
        Dim srcTyp As SourceType

        If result.Success Then
            srcTyp = [Enum].Parse(srcTyp.GetType(), result.Data.Tables(0).Rows(0)("source_type"))

            If srcTyp = SourceType.TCP_PORT Then
                Return New TCPProcessSource(sourceID, process)
            ElseIf srcTyp = SourceType.DB Then
                Return New DBProcessSource(sourceID, process)
            End If


        End If

    End Function
End Class
