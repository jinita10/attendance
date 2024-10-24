<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtboxNew = New System.Windows.Forms.TextBox()
        Me.txtboxConfirm = New System.Windows.Forms.TextBox()
        Me.btnSubmitChange = New System.Windows.Forms.Button()
        Me.PictureBoxconfirm = New System.Windows.Forms.PictureBox()
        Me.PictureBoxNew = New System.Windows.Forms.PictureBox()
        Me.btnCancelCP = New System.Windows.Forms.Button()
        CType(Me.PictureBoxconfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.Location = New System.Drawing.Point(21, 27)
        Me.lblNewPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(98, 14)
        Me.lblNewPass.TabIndex = 0
        Me.lblNewPass.Text = "New Password:"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(21, 108)
        Me.lblConfirm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(126, 14)
        Me.lblConfirm.TabIndex = 1
        Me.lblConfirm.Text = "Confirm Password:"
        '
        'txtboxNew
        '
        Me.txtboxNew.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxNew.Location = New System.Drawing.Point(24, 51)
        Me.txtboxNew.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxNew.Name = "txtboxNew"
        Me.txtboxNew.Size = New System.Drawing.Size(180, 20)
        Me.txtboxNew.TabIndex = 2
        '
        'txtboxConfirm
        '
        Me.txtboxConfirm.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxConfirm.Location = New System.Drawing.Point(24, 135)
        Me.txtboxConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxConfirm.Name = "txtboxConfirm"
        Me.txtboxConfirm.Size = New System.Drawing.Size(180, 20)
        Me.txtboxConfirm.TabIndex = 3
        '
        'btnSubmitChange
        '
        Me.btnSubmitChange.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmitChange.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitChange.Location = New System.Drawing.Point(147, 178)
        Me.btnSubmitChange.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmitChange.Name = "btnSubmitChange"
        Me.btnSubmitChange.Size = New System.Drawing.Size(67, 28)
        Me.btnSubmitChange.TabIndex = 4
        Me.btnSubmitChange.Text = "Submit"
        Me.btnSubmitChange.UseVisualStyleBackColor = False
        '
        'PictureBoxconfirm
        '
        Me.PictureBoxconfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxconfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxconfirm.Image = Global.attendancr.My.Resources.Resources.error_change
        Me.PictureBoxconfirm.Location = New System.Drawing.Point(207, 135)
        Me.PictureBoxconfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxconfirm.Name = "PictureBoxconfirm"
        Me.PictureBoxconfirm.Size = New System.Drawing.Size(23, 18)
        Me.PictureBoxconfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxconfirm.TabIndex = 6
        Me.PictureBoxconfirm.TabStop = False
        '
        'PictureBoxNew
        '
        Me.PictureBoxNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxNew.Image = Global.attendancr.My.Resources.Resources.error_change
        Me.PictureBoxNew.Location = New System.Drawing.Point(207, 51)
        Me.PictureBoxNew.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxNew.Name = "PictureBoxNew"
        Me.PictureBoxNew.Size = New System.Drawing.Size(23, 17)
        Me.PictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxNew.TabIndex = 5
        Me.PictureBoxNew.TabStop = False
        '
        'btnCancelCP
        '
        Me.btnCancelCP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancelCP.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCP.Location = New System.Drawing.Point(40, 180)
        Me.btnCancelCP.Name = "btnCancelCP"
        Me.btnCancelCP.Size = New System.Drawing.Size(62, 26)
        Me.btnCancelCP.TabIndex = 7
        Me.btnCancelCP.Text = "Cancel"
        Me.btnCancelCP.UseVisualStyleBackColor = False
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 217)
        Me.Controls.Add(Me.btnCancelCP)
        Me.Controls.Add(Me.PictureBoxconfirm)
        Me.Controls.Add(Me.PictureBoxNew)
        Me.Controls.Add(Me.btnSubmitChange)
        Me.Controls.Add(Me.txtboxConfirm)
        Me.Controls.Add(Me.txtboxNew)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblNewPass)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChangePass"
        Me.Text = "ChangeP"
        CType(Me.PictureBoxconfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblConfirm As Label
    Friend WithEvents txtboxNew As TextBox
    Friend WithEvents txtboxConfirm As TextBox
    Friend WithEvents btnSubmitChange As Button
    Friend WithEvents PictureBoxNew As PictureBox
    Friend WithEvents PictureBoxconfirm As PictureBox
    Friend WithEvents btnCancelCP As Button
End Class
