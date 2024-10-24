<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.PictureBoxLock = New System.Windows.Forms.PictureBox()
        Me.txtboxEnter = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmitFP = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBoxLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(23, 182)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(287, 16)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter your registered email or username:"
        '
        'PictureBoxLock
        '
        Me.PictureBoxLock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxLock.Image = Global.attendancr.My.Resources.Resources.lock
        Me.PictureBoxLock.Location = New System.Drawing.Point(103, 27)
        Me.PictureBoxLock.Name = "PictureBoxLock"
        Me.PictureBoxLock.Size = New System.Drawing.Size(118, 138)
        Me.PictureBoxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLock.TabIndex = 1
        Me.PictureBoxLock.TabStop = False
        '
        'txtboxEnter
        '
        Me.txtboxEnter.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxEnter.Location = New System.Drawing.Point(26, 221)
        Me.txtboxEnter.Name = "txtboxEnter"
        Me.txtboxEnter.Size = New System.Drawing.Size(252, 20)
        Me.txtboxEnter.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCancel.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(62, 285)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmitFP
        '
        Me.btnSubmitFP.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSubmitFP.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitFP.Location = New System.Drawing.Point(203, 285)
        Me.btnSubmitFP.Name = "btnSubmitFP"
        Me.btnSubmitFP.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitFP.TabIndex = 4
        Me.btnSubmitFP.Text = "Submit"
        Me.btnSubmitFP.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBoxLock)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSubmitFP)
        Me.Panel1.Controls.Add(Me.lblEnter)
        Me.Panel1.Controls.Add(Me.txtboxEnter)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 334)
        Me.Panel1.TabIndex = 5
        '
        'ForgotPasswordForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(330, 332)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ForgotPasswordForm"
        CType(Me.PictureBoxLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelFP As Label
    Friend WithEvents PictureBoxFP As PictureBox
    Friend WithEvents TextBoxFP As TextBox
    Friend WithEvents ButtonCancelFP As Button
    Friend WithEvents ButtonSubmitFP As Button
    Friend WithEvents lblEnter As Label
    Friend WithEvents PictureBoxLock As PictureBox
    Friend WithEvents txtboxEnter As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmitFP As Button
    Friend WithEvents Panel1 As Panel
End Class
