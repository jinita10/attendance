Imports System.Data.SqlClient

Public Class ForgotPasswordForm
    Private connectionString As String = "Data Source=DESKTOP-3460B5T\MSSQLSERVER01;Initial Catalog=attendanceDB;Integrated Security=True"

    ' When "Cancel" is clicked, return to the login form
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    ' When "Submit" is clicked, show the old password or show an error if user is not found
    Private Sub ButtonSubmitFP_Click(sender As Object, e As EventArgs) Handles ButtonSubmitFP.Click
        Dim emailOrUsername As String = txtboxEnter.Text.Trim()

        If String.IsNullOrWhiteSpace(emailOrUsername) Then
            MessageBox.Show("Please enter your registered email or username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Retrieve the old password from the database
        Dim oldPassword As String = GetOldPassword(emailOrUsername)
        If oldPassword Is Nothing Then
            ' If user is not found, show error
            MessageBox.Show("Username or email does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' If user is found, show the old password and ask if the user wants to change it
            Dim result As DialogResult = MessageBox.Show("Your old password is: " & oldPassword & vbCrLf & "Do you want to change it?", "Old Password", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim changePassForm As New ChangePass(emailOrUsername)
                changePassForm.Show()
                Me.Close()
            End If
        End If
    End Sub

    ' Function to retrieve the old password from the database
    Private Function GetOldPassword(emailOrUsername As String) As String
        Dim password As String = Nothing
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT Password FROM Users WHERE Username = @EmailOrUsername OR Email = @EmailOrUsername"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@EmailOrUsername", emailOrUsername)

            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    password = reader("Password").ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Return Nothing if no password was found
        Return password
    End Function
End Class
