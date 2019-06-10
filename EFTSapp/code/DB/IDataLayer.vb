Public Interface IDataLayer
    Function SelectData(sql As String, Optional parameters As List(Of SqlClient.SqlParameter) = Nothing) As SqlResult
    Function ExecuteSP(sp As String, Optional parameters As List(Of SqlClient.SqlParameter) = Nothing) As SqlResult
End Interface
