Imports System.Net.Http
Imports Newtonsoft.Json

Public Class MainForm
    Private submissions As List(Of Submission) = New List(Of Submission)()

    Private Async Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync("http://localhost:3000/read")
                response.EnsureSuccessStatusCode() ' Throw on error

                Dim json = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)

                If submissions.Count > 0 Then
                    ' Open ViewSubmissionsForm with all submissions
                    Dim viewForm As New ViewSubmissionsForm(submissions)
                    viewForm.ShowDialog()
                Else
                    MessageBox.Show("No submissions found.", "Information")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving submissions: {ex.Message}", "Error")
        End Try
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub
    Private Sub KeyDown_Detect(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if Ctrl+V is pressed
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Perform action when Ctrl+V is pressed (e.g., click the button)
            btnViewSubmissions.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Perform action when Ctrl+V is pressed (e.g., click the button)
            btnCreateSubmission.PerformClick()
        End If
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
