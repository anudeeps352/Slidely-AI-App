Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0 ' Index of current submission displayed

    Public Sub New(submissions As List(Of Submission))
        InitializeComponent()
        Me.submissions = submissions
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim currentSubmission = submissions(index)
            txtName.Text = currentSubmission.name
            txtEmail.Text = currentSubmission.email
            txtPhone.Text = currentSubmission.phone
            txtWebsite.Text = currentSubmission.website
            txtStopwatchTime.Text = currentSubmission.stopwatchTime
        End If
    End Sub
    Private Sub KeyDown_Detect(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if Ctrl+V is pressed
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Perform action when Ctrl+V is pressed (e.g., click the button)
            btnPrev.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Perform action when Ctrl+V is pressed (e.g., click the button)
            btnNext.PerformClick()
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex = (currentIndex + 1) Mod submissions.Count
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If (currentIndex > 0) Then
            btnPrev.Enabled = True
            currentIndex = (currentIndex - 1) Mod submissions.Count
            DisplaySubmission(currentIndex)
        Else
            btnPrev.Enabled = False
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
