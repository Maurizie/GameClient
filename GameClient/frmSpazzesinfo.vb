Public Class frmSpazzesinfo

    Private Sub Btntauriinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntauriinfo.Click
        Dim result As MsgBoxResult = MsgBox("Are you 100% sure, this decision is final and permenant!", MsgBoxStyle.YesNo, "Choice")
        If result = MsgBoxResult.Yes Then
            frmMain._Client.SendData(NetComm.Host.Convert2Ascii(Array.IndexOf(frmMain.Lookup, "tutorial").ToString("00") & "0"), "")
            frmtutorial.Btnspazzesinfo.Visible = False : frmtutorial.Btnspazzesinfo.Enabled = False
            frmtutorial.Btntauriinfo.Visible = False : frmtutorial.Btntauriinfo.Enabled = False
            frmtutorial.Btncontinuetutorial.Visible = True : frmtutorial.Btnfinishtutorial.Visible = True
            frmtutorial.Btncontinuetutorial.Enabled = True : frmtutorial.Btnfinishtutorial.Enabled = True
            frmtutorial.Btncontinuetutorial.Location = New System.Drawing.Point(286, 506)
            frmtutorial.Btnfinishtutorial.Location = New System.Drawing.Point(631, 506)
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmSpazzesinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class