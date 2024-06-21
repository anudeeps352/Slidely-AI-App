<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtWebsite = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        textStopwatch = New TextBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(132, 99)
        txtName.Name = "txtName"
        txtName.Size = New Size(281, 23)
        txtName.TabIndex = 0
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(132, 219)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(279, 23)
        txtPhone.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(132, 159)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(279, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtWebsite
        ' 
        txtWebsite.Location = New Point(132, 284)
        txtWebsite.Name = "txtWebsite"
        txtWebsite.Size = New Size(279, 23)
        txtWebsite.TabIndex = 3
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = SystemColors.Info
        btnToggleStopwatch.ForeColor = SystemColors.ControlText
        btnToggleStopwatch.Location = New Point(24, 366)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(151, 61)
        btnToggleStopwatch.TabIndex = 4
        btnToggleStopwatch.Text = "Toggle Stopwatch(CTRL+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.Location = New Point(40, 477)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(338, 61)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit(CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' textStopwatch
        ' 
        textStopwatch.Location = New Point(251, 386)
        textStopwatch.Name = "textStopwatch"
        textStopwatch.Size = New Size(127, 23)
        textStopwatch.TabIndex = 6
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 15)
        Label1.TabIndex = 7
        Label1.Text = "Anudeep S, Slidely Task 2 - Create Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 10
        Label4.Text = "Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 287)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 11
        Label5.Text = "Github Link "
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(423, 569)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(textStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtWebsite)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents textStopwatch As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
