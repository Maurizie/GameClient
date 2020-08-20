<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tcLoginRegister = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblPass1 = New System.Windows.Forms.Label()
        Me.lblUname2 = New System.Windows.Forms.Label()
        Me.txtrPass = New System.Windows.Forms.TextBox()
        Me.txtrUsername = New System.Windows.Forms.TextBox()
        Me.cmdRegister = New System.Windows.Forms.Button()
        Me.tsServerStatus = New System.Windows.Forms.StatusStrip()
        Me.tcLoginRegister.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcLoginRegister
        '
        Me.tcLoginRegister.Controls.Add(Me.TabPage1)
        Me.tcLoginRegister.Controls.Add(Me.TabPage2)
        Me.tcLoginRegister.Location = New System.Drawing.Point(2, 1)
        Me.tcLoginRegister.Name = "tcLoginRegister"
        Me.tcLoginRegister.SelectedIndex = 0
        Me.tcLoginRegister.Size = New System.Drawing.Size(274, 208)
        Me.tcLoginRegister.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblPass)
        Me.TabPage1.Controls.Add(Me.lblUname)
        Me.TabPage1.Controls.Add(Me.txtPassword)
        Me.TabPage1.Controls.Add(Me.txtUsername)
        Me.TabPage1.Controls.Add(Me.cmdLogin)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(266, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(6, 42)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(56, 13)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "Password:"
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Location = New System.Drawing.Point(6, 15)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(58, 13)
        Me.lblUname.TabIndex = 3
        Me.lblUname.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(70, 42)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(155, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(70, 12)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(155, 20)
        Me.txtUsername.TabIndex = 0
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(76, 68)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(86, 35)
        Me.cmdLogin.TabIndex = 2
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtConfirm)
        Me.TabPage2.Controls.Add(Me.lblConfirm)
        Me.TabPage2.Controls.Add(Me.lblPass1)
        Me.TabPage2.Controls.Add(Me.lblUname2)
        Me.TabPage2.Controls.Add(Me.txtrPass)
        Me.TabPage2.Controls.Add(Me.txtrUsername)
        Me.TabPage2.Controls.Add(Me.cmdRegister)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(266, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Register"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(88, 102)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(155, 20)
        Me.txtConfirm.TabIndex = 11
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(26, 102)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(48, 13)
        Me.lblConfirm.TabIndex = 10
        Me.lblConfirm.Text = "Confirm: "
        '
        'lblPass1
        '
        Me.lblPass1.AutoSize = True
        Me.lblPass1.Location = New System.Drawing.Point(24, 76)
        Me.lblPass1.Name = "lblPass1"
        Me.lblPass1.Size = New System.Drawing.Size(56, 13)
        Me.lblPass1.TabIndex = 9
        Me.lblPass1.Text = "Password:"
        '
        'lblUname2
        '
        Me.lblUname2.AutoSize = True
        Me.lblUname2.Location = New System.Drawing.Point(24, 49)
        Me.lblUname2.Name = "lblUname2"
        Me.lblUname2.Size = New System.Drawing.Size(58, 13)
        Me.lblUname2.TabIndex = 8
        Me.lblUname2.Text = "Username:"
        '
        'txtrPass
        '
        Me.txtrPass.Location = New System.Drawing.Point(88, 76)
        Me.txtrPass.Name = "txtrPass"
        Me.txtrPass.Size = New System.Drawing.Size(155, 20)
        Me.txtrPass.TabIndex = 7
        Me.txtrPass.UseSystemPasswordChar = True
        '
        'txtrUsername
        '
        Me.txtrUsername.Location = New System.Drawing.Point(88, 46)
        Me.txtrUsername.Name = "txtrUsername"
        Me.txtrUsername.Size = New System.Drawing.Size(155, 20)
        Me.txtrUsername.TabIndex = 6
        '
        'cmdRegister
        '
        Me.cmdRegister.Location = New System.Drawing.Point(109, 128)
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Size = New System.Drawing.Size(86, 35)
        Me.cmdRegister.TabIndex = 5
        Me.cmdRegister.Text = "Register"
        Me.cmdRegister.UseVisualStyleBackColor = True
        '
        'tsServerStatus
        '
        Me.tsServerStatus.Location = New System.Drawing.Point(0, 216)
        Me.tsServerStatus.Name = "tsServerStatus"
        Me.tsServerStatus.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.tsServerStatus.Size = New System.Drawing.Size(280, 22)
        Me.tsServerStatus.SizingGrip = False
        Me.tsServerStatus.TabIndex = 2
        Me.tsServerStatus.Text = "ServerStatus"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 238)
        Me.Controls.Add(Me.tsServerStatus)
        Me.Controls.Add(Me.tcLoginRegister)
        Me.Name = "frmMain"
        Me.Text = "Login"
        Me.tcLoginRegister.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcLoginRegister As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUname As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tsServerStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents lblPass1 As System.Windows.Forms.Label
    Friend WithEvents lblUname2 As System.Windows.Forms.Label
    Friend WithEvents txtrPass As System.Windows.Forms.TextBox
    Friend WithEvents txtrUsername As System.Windows.Forms.TextBox
    Friend WithEvents cmdRegister As System.Windows.Forms.Button

End Class
