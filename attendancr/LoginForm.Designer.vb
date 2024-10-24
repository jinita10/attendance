<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PanellForm = New System.Windows.Forms.Panel()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.GroupBoxForm = New System.Windows.Forms.GroupBox()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBoxShow = New System.Windows.Forms.PictureBox()
        Me.PictureBoxHide = New System.Windows.Forms.PictureBox()
        Me.LabelFP = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.txtboxPass = New System.Windows.Forms.TextBox()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PanellForm.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxForm.SuspendLayout()
        CType(Me.PictureBoxShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanellForm
        '
        Me.PanellForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanellForm.Controls.Add(Me.PictureBox)
        Me.PanellForm.Controls.Add(Me.Label)
        Me.PanellForm.Controls.Add(Me.Panel)
        Me.PanellForm.Controls.Add(Me.GroupBoxForm)
        Me.PanellForm.Controls.Add(Me.PictureBoxMinimize)
        Me.PanellForm.Controls.Add(Me.PictureBoxClose)
        Me.PanellForm.Location = New System.Drawing.Point(52, 86)
        Me.PanellForm.Name = "PanellForm"
        Me.PanellForm.Size = New System.Drawing.Size(1061, 578)
        Me.PanellForm.TabIndex = 0
        '
        'PictureBox
        '
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox.Image = Global.attendancr.My.Resources.Resources.student
        Me.PictureBox.Location = New System.Drawing.Point(688, 117)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(262, 265)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 5
        Me.PictureBox.TabStop = False
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(710, 422)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(208, 22)
        Me.Label.TabIndex = 4
        Me.Label.Text = "STUDENT MANAGEMENT"
        '
        'Panel
        '
        Me.Panel.Location = New System.Drawing.Point(588, 41)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(5, 530)
        Me.Panel.TabIndex = 3
        '
        'GroupBoxForm
        '
        Me.GroupBoxForm.Controls.Add(Me.ComboBox)
        Me.GroupBoxForm.Controls.Add(Me.PictureBoxShow)
        Me.GroupBoxForm.Controls.Add(Me.PictureBoxHide)
        Me.GroupBoxForm.Controls.Add(Me.LabelFP)
        Me.GroupBoxForm.Controls.Add(Me.btnLogin)
        Me.GroupBoxForm.Controls.Add(Me.LabelError)
        Me.GroupBoxForm.Controls.Add(Me.txtboxPass)
        Me.GroupBoxForm.Controls.Add(Me.txtboxUsername)
        Me.GroupBoxForm.Controls.Add(Me.LabelPass)
        Me.GroupBoxForm.Controls.Add(Me.LabelUsername)
        Me.GroupBoxForm.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxForm.Location = New System.Drawing.Point(95, 41)
        Me.GroupBoxForm.Name = "GroupBoxForm"
        Me.GroupBoxForm.Size = New System.Drawing.Size(476, 503)
        Me.GroupBoxForm.TabIndex = 2
        Me.GroupBoxForm.TabStop = False
        Me.GroupBoxForm.Text = "Please Login First"
        '
        'ComboBox
        '
        Me.ComboBox.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(100, 76)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(265, 24)
        Me.ComboBox.TabIndex = 12
        Me.ComboBox.Text = "User Type:"
        '
        'PictureBoxShow
        '
        Me.PictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxShow.Image = Global.attendancr.My.Resources.Resources.show1
        Me.PictureBoxShow.Location = New System.Drawing.Point(339, 297)
        Me.PictureBoxShow.Name = "PictureBoxShow"
        Me.PictureBoxShow.Size = New System.Drawing.Size(28, 26)
        Me.PictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxShow.TabIndex = 11
        Me.PictureBoxShow.TabStop = False
        '
        'PictureBoxHide
        '
        Me.PictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxHide.Image = Global.attendancr.My.Resources.Resources.hide
        Me.PictureBoxHide.Location = New System.Drawing.Point(339, 297)
        Me.PictureBoxHide.Name = "PictureBoxHide"
        Me.PictureBoxHide.Size = New System.Drawing.Size(28, 26)
        Me.PictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxHide.TabIndex = 10
        Me.PictureBoxHide.TabStop = False
        '
        'LabelFP
        '
        Me.LabelFP.AutoSize = True
        Me.LabelFP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelFP.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFP.Location = New System.Drawing.Point(173, 404)
        Me.LabelFP.Name = "LabelFP"
        Me.LabelFP.Size = New System.Drawing.Size(119, 16)
        Me.LabelFP.TabIndex = 9
        Me.LabelFP.Text = "Forgot Password?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(174, 444)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(118, 41)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(129, 359)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(203, 14)
        Me.LabelError.TabIndex = 4
        Me.LabelError.Text = "Invalid Username or Password"
        Me.LabelError.Visible = False
        '
        'txtboxPass
        '
        Me.txtboxPass.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxPass.Location = New System.Drawing.Point(100, 297)
        Me.txtboxPass.Name = "txtboxPass"
        Me.txtboxPass.Size = New System.Drawing.Size(267, 26)
        Me.txtboxPass.TabIndex = 3
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxUsername.Location = New System.Drawing.Point(100, 194)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(267, 23)
        Me.txtboxUsername.TabIndex = 2
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPass.Location = New System.Drawing.Point(97, 259)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(79, 16)
        Me.LabelPass.TabIndex = 1
        Me.LabelPass.Text = "Password:"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelUsername.Location = New System.Drawing.Point(97, 153)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(79, 16)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username:"
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMinimize.Image = Global.attendancr.My.Resources.Resources.minimize
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(983, -1)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(29, 33)
        Me.PictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMinimize.TabIndex = 1
        Me.PictureBoxMinimize.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClose.Image = Global.attendancr.My.Resources.Resources.closelogo
        Me.PictureBoxClose.Location = New System.Drawing.Point(1018, -1)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(31, 33)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxClose.TabIndex = 0
        Me.PictureBoxClose.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 701)
        Me.Controls.Add(Me.PanellForm)
        Me.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PanellForm.ResumeLayout(False)
        Me.PanellForm.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxForm.ResumeLayout(False)
        Me.GroupBoxForm.PerformLayout()
        CType(Me.PictureBoxShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanellForm As Panel
    Friend WithEvents PictureBoxMinimize As PictureBox
    Friend WithEvents PictureBoxClose As PictureBox
    Friend WithEvents GroupBoxForm As GroupBox
    Friend WithEvents txtboxPass As TextBox
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents LabelError As Label
    Friend WithEvents LabelFP As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Label As Label
    Friend WithEvents PictureBoxShow As PictureBox
    Friend WithEvents PictureBoxHide As PictureBox
    Friend WithEvents ComboBox As ComboBox

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
