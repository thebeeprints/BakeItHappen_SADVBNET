Imports FirebaseAdmin
Imports FirebaseAdmin.Auth
Imports Google.Apis.Auth.OAuth2

Public Class AuthenticationHelper
    Public Sub New()
        Dim app = FirebaseAdmin.FirebaseApp.Create()
    End Sub

    Public Async Sub FetchUserDataAsync(uid As String)
        Try
            Dim userRecord = Await FirebaseAuth.DefaultInstance.GetUserAsync(uid)
            Console.WriteLine("Successfully fetched user data: " & userRecord.Uid)
        Catch ex As Exception
            Console.WriteLine("Error fetching user data: " & ex.Message)
        End Try
    End Sub

    Public Async Sub CreateUserAsync(uid As String, email As String, phoneNumber As String)
        Try
            Dim args As New UserRecordArgs() With {
                .Uid = uid,
                .Email = email,
                .PhoneNumber = phoneNumber
            }
            Dim userRecord = Await FirebaseAuth.DefaultInstance.CreateUserAsync(args)
            ' See the UserRecord reference doc for the contents of userRecord.
            Console.WriteLine($"Successfully created new user: {userRecord.Uid}")
        Catch ex As Exception
            ' Handle error
            Console.WriteLine($"Error creating new user: {ex.Message}")
        End Try
    End Sub
End Class
