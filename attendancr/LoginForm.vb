Imports System.Data.SqlClient

Public Class LoginForm
    ' Database connection string
    Private connectionString As String = "Data Source=DESKTOP-3460B5T\MSSQLSERVER01;Initial Catalog=attendanceDB;Integrated Security=True"

    ' Event that triggers when the form loads
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add options to the ComboBox
        ComboBox.Items.Add("Select User Type:")
        ComboBox.Items.Add("Teacher")
        ComboBox.Items.Add("PC-User")
        ComboBox.SelectedIndex = 0 ' Default selection

        ' Disable input fields initially
        txtboxUsername.Enabled = False
        txtboxPass.Enabled = False
    End Sub

    ' Event for handling the login button click
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userType As String = ComboBox.SelectedItem?.ToString().Trim()
        Dim username As String = txtboxUsername.Text.Trim()
        Dim password As String = txtboxPass.Text.Trim()

        If ComboBox.SelectedIndex = 0 Then
            LabelError.Text = "Please select a user type."
            LabelError.Visible = True
            Return
        End If

        If userType = "Teacher" Then
            If String.IsNullOrWhiteSpace(username) Then
                LabelError.Text = "Please enter your username."
                LabelError.Visible = True
                Return
            End If

            If String.IsNullOrWhiteSpace(password) Then
                LabelError.Text = "Please enter your password."
                LabelError.Visible = True
                Return
            End If

            ' Validate login credentials from the database
            If ValidateLogin(username, password) Then
                MessageBox.Show("Login Successful as Teacher!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Proceed to the next form or dashboard for Teacher
            Else
                LabelError.Text = "Invalid Username or Password."
                LabelError.Visible = True
            End If

        ElseIf userType = "PC-User" Then
            ' For "PC-User", automatically proceed with login
            MessageBox.Show("Login Successful as PC-User!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Proceed to the next form or dashboard for PC-User
        End If
    End Sub

    ' Function to validate login for a teacher against the database
    Private Function ValidateLogin(username As String, password As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM Teachers WHERE Username = @username AND Password = @password"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return result > 0 ' Return true if a matching record is found
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error validating login: " & ex.Message)
            Return False
        End Try
    End Function

    ' Event for handling the ComboBox index change
    Private Sub ComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        ' Enable/disable fields based on the selected user type
        If ComboBox.Items.Count > 0 Then
            If ComboBox.SelectedIndex = 1 Then ' "Teacher"
                txtboxUsername.Enabled = True
                txtboxPass.Enabled = True
                txtboxUsername.Clear() ' Clear fields when enabled
                txtboxPass.Clear()
            ElseIf ComboBox.SelectedIndex = 2 Then ' "PC-User"
                txtboxUsername.Enabled = False
                txtboxPass.Enabled = False
                txtboxUsername.Clear() ' Clear fields when disabled
                txtboxPass.Clear()
            End If
        End If
    End Sub

    ' Event to handle clicking the close icon in PictureBox
    Private Sub PictureBoxClose_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click
        Me.Close()
    End Sub

    ' Event to handle clicking the minimize icon in PictureBox
    Private Sub PictureBoxMinimize_Click(sender As Object, e As EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Toggle password visibility
    Private Sub PictureBoxShow_Click(sender As Object, e As EventArgs) Handles PictureBoxShow.Click
        If txtboxPass.UseSystemPasswordChar Then
            txtboxPass.UseSystemPasswordChar = False ' Show password
            PictureBoxShow.Image = attendancr.My.Resources.Resources.hide
        Else
            txtboxPass.UseSystemPasswordChar = True ' Hide password
            PictureBoxShow.Image = attendancr.My.Resources.Resources.show1
        End If
    End Sub

    ' Event to handle Forgot Password button click
    Private Sub ButtonForgotPassword_Click(sender As Object, e As EventArgs) Handles LabelFP.Click
        Me.Hide() ' Hide the login form
        Dim forgotPasswordForm As New ForgotPasswordForm()
        forgotPasswordForm.Show() ' Show ForgotPasswordForm
    End Sub

    ' Username and Password field text changed event handlers (can be used for additional checks)
    Private Sub txtboxUsername_TextChanged(sender As Object, e As EventArgs) Handles txtboxUsername.TextChanged
    End Sub

    Private Sub txtboxPass_TextChanged(sender As Object, e As EventArgs) Handles txtboxPass.TextChanged
    End Sub
End Class
