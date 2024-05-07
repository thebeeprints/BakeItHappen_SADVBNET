Imports System.Net.NetworkInformation

Public Class Ping
    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New System.Net.WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
End Class