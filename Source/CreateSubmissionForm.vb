Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text
Imports System.Diagnostics
Imports System.Diagnostics.Metrics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Dim timer_reset As Boolean = False
    Dim seconds, minutes, hours As Integer
    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If Not stopwatch.IsRunning Then
            ' Start the stopwatch
            stopwatch.Start()
            Timer1.Enabled = True
        Else
            ' Stop the stopwatch
            stopwatch.Stop()
            Timer1.Enabled = False
        End If
    End Sub


    Private Sub KeyDown_Detect(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if Ctrl+V is pressed
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ' Perform action when Ctrl+V is pressed (e.g., click the button)
            btnToggleStopwatch.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Perform action when Ctrl+V is pressed (e.g., click the button)
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Timer1.Enabled = False
        Dim timeAsString1 As String = String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds)
        Dim newSubmission As New List(Of KeyValuePair(Of String, String)) From {
        New KeyValuePair(Of String, String)("name", txtName.Text),
        New KeyValuePair(Of String, String)("email", txtEmail.Text),
        New KeyValuePair(Of String, String)("phone", txtPhone.Text),
        New KeyValuePair(Of String, String)("website", txtWebsite.Text),
        New KeyValuePair(Of String, String)("stopwatchTime", timeAsString1)
    }
        Try
            Using client As New HttpClient()
                Dim content = New FormUrlEncodedContent(newSubmission)
                Dim response = Await client.PostAsync("http://localhost:3000/submit", content)

                response.EnsureSuccessStatusCode() ' Throw on error

                MessageBox.Show("Submission created successfully.", "Success")
                Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error creating submission: {ex.Message}", "Error")
        End Try
    End Sub


    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        textStopwatch.Text = Format(hours, "00:") & Format(minutes, "00:") & Format(seconds, "00")
        seconds = seconds + 1
        If seconds > 59 Then
            seconds = 0
            minutes = minutes + 1
        End If
        If minutes > 59 Then
            minutes = 0
            hours = hours + 1
        End If

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub
End Class
