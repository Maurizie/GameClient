Public Class frmtutorial

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntauriinfo.Click
        frmtauriinfo.Show()
    End Sub

    Private Sub frmtutorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmGame.Close()
    End Sub

    Private Sub Btnspazzesinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnspazzesinfo.Click
        frmSpazzesinfo.Show()
    End Sub

    Private Sub Btnfinishtutorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfinishtutorial.Click
        frmGame.Show()
        Me.Close()
    End Sub

    Private Sub Btncontinuetutorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncontinuetutorial.Click

    End Sub
End Class