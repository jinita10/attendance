Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class ChangePass
    Private connectionString As String = "Data Source=DESKTOP-3460B5T\MSSQLSERVER01;Initial Catalog=attendanceDB;Integrated Security=True"
    Private userEmailOrUsername As String

    Public Sub New(emailOrUsername As String)
        InitializeComponent()
        Me.userEmailOrUsername = emailOrUsername
    End Sub

    ' When "Submit" is clicked, validate and change the password
    Private Sub ButtonSubmitChangePass_Click(sender As Object, e As EventArgs) Handles btnSubmitChange.Click
        Dim newPassword As String = txtboxNew.Text.Trim()
        Dim confirmPassword As String = txtboxConfirm.Text.Trim()

        ' Validate password
        If Not IsValidPassword(newPassword) Then
            MessageBox.Show("Password must start with a capital letter and contain at least one number or special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if passwords match
        If Not newPassword.Equals(confirmPassword) Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update password in the database
        If UpdatePassword(newPassword) Then
            MessageBox.Show("Password successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Failed to change password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Function to check if the password is valid
    Private Function IsValidPassword(password As String) As Boolean
        Dim regex As New Regex("^[A-Z].*[0-9!@#$%^&*()_+]")
        Return regex.IsMatch(password)
    End Function

    ' Function to update the password in the database
    Private Function UpdatePassword(newPassword As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Users SET Password = @NewPassword WHERE Username = @EmailOrUsername OR Email = @EmailOrUsername"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NewPassword", newPassword)
            command.Parameters.AddWithValue("@EmailOrUsername", userEmailOrUsername)

            connection.Open()
            Dim result As Integer = command.ExecuteNonQuery()
            Return result > 0
        End Using
    End Function

    ' When "Cancel" is clicked, return to the login form
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles btnCancelCP.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub
End Class
