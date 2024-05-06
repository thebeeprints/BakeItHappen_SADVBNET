Public Class DailyAttendance
    Dim firebase As New FireBaseApp()
    Dim syncTime As String
    Dim currentDay As String = $"{Now.Month}{Now.Day}{Now.Year}"
    Dim ping As New Ping()
    Private Sub DailyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showAttendanceList()
        AttendanceGrid.ReadOnly = True
    End Sub

    Private Async Sub TimeIn_Click(sender As Object, e As EventArgs) Handles TimeIn.Click
        Dim Time As String = $"{Now.Month:00}/{Now.Day:00}/{Now.Year} {Now.Hour:00}:{Now.Minute:00}"
        syncTime = Time

        Dim attendance As New AttendanceDataModel() With {
            .EmployeeID = SignIn.getID,
            .EmployeeName = SignIn.getFullName,
            .TimeIn = syncTime
            }
        Dim response = firebase.InsertData(attendance, $"BakeITHappen/Attendance/{currentDay}/{SignIn.getID}/")
        Dim message = If(response, "Time in recorded", "Failed to record time in")
        showAttendanceList()
        MessageBox.Show(message)
        Cursor = Cursors.WaitCursor
        Await Task.Delay(500)
        Cursor = Cursors.Default
        Me.Hide()
        Cashier_Interface.Show()
    End Sub

    Private Sub TimeOut_Click(sender As Object, e As EventArgs) Handles TimeOut.Click
        If Not Ping.CheckForInternetConnection Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Time As String = $"{Now.Month:00}/{Now.Day:00}/{Now.Year} {Now.Hour:00}:{Now.Minute:00}"
        Dim getAttendance = firebase.client.Get($"BakeITHappen/Attendance/{currentDay}/{SignIn.getID}").ResultAs(Of AttendanceDataModel)()
        If getAttendance Is Nothing Then
            MessageBox.Show("Please Time In first")
            Exit Sub
        End If
        getAttendance.TimeOut = Time
        Dim updateData = firebase.client.Update($"BakeITHappen/Attendance/{currentDay}/{SignIn.getID}", getAttendance).ResultAs(Of AttendanceDataModel)()
        showAttendanceList()
        MessageBox.Show("Time out recorded")
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub showAttendanceList()
        AttendanceGrid.Columns.Clear()
        Try
            Dim attendanceData = firebase.GetData(Of AttendanceDataModel)($"BakeITHappen/Attendance/{currentDay}/")
            If attendanceData Is Nothing Then
                Exit Sub
            End If
            Dim dataList As New List(Of AttendanceDataModel)
            For Each kvp As KeyValuePair(Of String, AttendanceDataModel) In attendanceData
                dataList.Add(kvp.Value)
            Next

            AttendanceGrid.DataSource = dataList

            AttendanceGrid.Columns("EmployeeID").HeaderText = "Employee ID"
            AttendanceGrid.Columns("EmployeeName").HeaderText = "Employee Name"
            AttendanceGrid.Columns("TimeIn").HeaderText = "Time In"
            AttendanceGrid.Columns("TimeOut").HeaderText = "Time Out"

        Catch ex As Exception
            MessageBox.Show($"An error has occurred: {ex.Message}")
        End Try
    End Sub
End Class