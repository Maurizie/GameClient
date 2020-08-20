<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtutorial))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Btntauriinfo = New System.Windows.Forms.Button
        Me.Btnspazzesinfo = New System.Windows.Forms.Button
        Me.Btncontinuetutorial = New System.Windows.Forms.Button
        Me.Btnfinishtutorial = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(190, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(752, 256)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Btntauriinfo
        '
        Me.Btntauriinfo.BackColor = System.Drawing.Color.Transparent
        Me.Btntauriinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btntauriinfo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntauriinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btntauriinfo.Location = New System.Drawing.Point(286, 506)
        Me.Btntauriinfo.Name = "Btntauriinfo"
        Me.Btntauriinfo.Size = New System.Drawing.Size(282, 113)
        Me.Btntauriinfo.TabIndex = 1
        Me.Btntauriinfo.Text = "The Tau'ri"
        Me.Btntauriinfo.UseVisualStyleBackColor = False
        '
        'Btnspazzesinfo
        '
        Me.Btnspazzesinfo.BackColor = System.Drawing.Color.Transparent
        Me.Btnspazzesinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnspazzesinfo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnspazzesinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnspazzesinfo.Location = New System.Drawing.Point(631, 506)
        Me.Btnspazzesinfo.Name = "Btnspazzesinfo"
        Me.Btnspazzesinfo.Size = New System.Drawing.Size(282, 113)
        Me.Btnspazzesinfo.TabIndex = 2
        Me.Btnspazzesinfo.Text = "The Spazzes"
        Me.Btnspazzesinfo.UseVisualStyleBackColor = False
        '
        'Btncontinuetutorial
        '
        Me.Btncontinuetutorial.BackColor = System.Drawing.Color.Transparent
        Me.Btncontinuetutorial.Enabled = False
        Me.Btncontinuetutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncontinuetutorial.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncontinuetutorial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btncontinuetutorial.Location = New System.Drawing.Point(286, 608)
        Me.Btncontinuetutorial.Name = "Btncontinuetutorial"
        Me.Btncontinuetutorial.Size = New System.Drawing.Size(282, 113)
        Me.Btncontinuetutorial.TabIndex = 3
        Me.Btncontinuetutorial.Text = "Continue tutorial"
        Me.Btncontinuetutorial.UseVisualStyleBackColor = False
        Me.Btncontinuetutorial.Visible = False
        '
        'Btnfinishtutorial
        '
        Me.Btnfinishtutorial.BackColor = System.Drawing.Color.Transparent
        Me.Btnfinishtutorial.Enabled = False
        Me.Btnfinishtutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnfinishtutorial.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfinishtutorial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnfinishtutorial.Location = New System.Drawing.Point(631, 608)
        Me.Btnfinishtutorial.Name = "Btnfinishtutorial"
        Me.Btnfinishtutorial.Size = New System.Drawing.Size(282, 113)
        Me.Btnfinishtutorial.TabIndex = 4
        Me.Btnfinishtutorial.Text = "Finish tutorial"
        Me.Btnfinishtutorial.UseVisualStyleBackColor = False
        Me.Btnfinishtutorial.Visible = False
        '
        'frmtutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = Global.GameClient.My.Resources.Resources.spasmgamemockup2
        Me.ClientSize = New System.Drawing.Size(984, 762)
        Me.Controls.Add(Me.Btnfinishtutorial)
        Me.Controls.Add(Me.Btncontinuetutorial)
        Me.Controls.Add(Me.Btnspazzesinfo)
        Me.Controls.Add(Me.Btntauriinfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmtutorial"
        Me.Text = "ExtremeGame Tutorial!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btntauriinfo As System.Windows.Forms.Button
    Friend WithEvents Btnspazzesinfo As System.Windows.Forms.Button
    Friend WithEvents Btncontinuetutorial As System.Windows.Forms.Button
    Friend WithEvents Btnfinishtutorial As System.Windows.Forms.Button
End Class
