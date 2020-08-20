Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class frmGame
    'Public Sub New()

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    Me.NativeTabControl1 = New NativeTabControl
    '    Me.NativeTabControl2 = New NativeTabControl
    '    Me.NativeTabControl1.AssignHandle(Me.TabControl1.Handle)
    'End Sub

    'Private NativeTabControl1, NativeTabControl2 As NativeTabControl

    'Private Class NativeTabControl
    '    Inherits NativeWindow

    '    Protected Overrides Sub WndProc(ByRef m As Message)
    '        If (m.Msg = TCM_ADJUSTRECT) Then
    '            Dim rc As RECT = DirectCast(m.GetLParam(GetType(RECT)), RECT)
    '            'Adjust these values to suit, dependant upon Appearance
    '            rc.Left -= 3
    '            rc.Right += 3
    '            rc.Top -= 3
    '            rc.Bottom += 3
    '            Marshal.StructureToPtr(rc, m.LParam, True)
    '        End If
    '        MyBase.WndProc(m)
    '    End Sub

    '    Private Const TCM_FIRST As Int32 = &H1300
    '    Private Const TCM_ADJUSTRECT As Int32 = (TCM_FIRST + 40)
    '    Private Structure RECT
    '        Public Left, Top, Right, Bottom As Int32
    '    End Structure

    'End Class
    Public username As String = frmMain.Playerstats.username
    Dim foundarylevel, extractorlevel, tritiumgenerator As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.Hide()
        Me.MaximizeBox = False
        Me.Text = username & " -- Extreme Game"
        frmMain.SendMessage("resources", "getresources")
        frmMain.SendMessage("getallstructures", "")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl.SelectTab(0)
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RefreshBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.SendMessage("resources", "getresources")
    End Sub

    Private Sub btnoverview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoverview.Click
        TabControl.SelectTab(0)
    End Sub

    Private Sub btnstructures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstructures.Click
        TabControl.SelectTab(1)
        UpdateStructures()

    End Sub
    Public Function CalculateMetal(ByVal Level As Integer, ByVal resource As String) As Integer
        If resource = "m" Then
            Return (60 * 1.5 ^ (Level - 1))
        ElseIf resource = "s" Then
            Return (15 * 1.5 ^ (Level - 1))
        End If
    End Function
    Public Function CalculateSilicon(ByVal level As Integer, ByVal resource As String) As Integer
        If resource = "m" Then
            Return (48 * 1.5 ^ (level - 1))
        ElseIf resource = "s" Then
            Return (24 * 1.5 ^ (level - 1))
        End If
    End Function
    Public Function CalculateTritium(ByVal level As Integer, ByVal resource As String) As Integer
        If resource = "m" Then
            Return (225 * 1.5 ^ (level - 1))
        ElseIf resource = "s" Then
            Return (75 * 1.5 ^ (level - 1))
        End If
    End Function
    Public Function CalculateShipyard(ByVal level As Integer, ByVal resource As String) As Integer
        If resource = "m" Then
            Return (100 * 1.5 ^ (level - 1))
        ElseIf resource = "s" Then
            Return (50 * 1.5 ^ (level - 1))
        ElseIf resource = "t" Then
            Return (20 * 1.5 ^ (level - 1))
        End If
    End Function
    Public Function CalculateResearchLab(ByVal level As Integer, ByVal resource As String) As Integer
        If resource = "m" Then
            Return (150 * 1.5 ^ (level - 1))
        ElseIf resource = "s" Then
            Return (100 * 1.5 ^ (level - 1))
        ElseIf resource = "t" Then
            Return (60 * 1.5 ^ (level - 1))
        End If
    End Function
    Public Function CalculateRoboticsFactory(ByVal level As Integer, ByVal resource As String) As Integer
        If resource = "m" Then
            Return (250 * (2 ^ (level - 1)))
        ElseIf resource = "s" Then
            Return (125 * (2 ^ (level - 1)))
        ElseIf resource = "t" Then
            Return (75 * (2 ^ (level - 1)))

        End If
    End Function


    Private Sub btnmetalmineupgrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmetalmineupgrade.Click
        ' frmMain.SendMessage("resources", "getresources") probably not needed
        If frmMain.Playerstats.metal < CalculateMetal(frmMain.Playerstats.MetalFoundaryLevel, "m") Then
            MsgBox("You do not have enough metal!")
            Return
        ElseIf frmMain.Playerstats.silicon < CalculateMetal(frmMain.Playerstats.MetalFoundaryLevel, "s") Then
            MsgBox("You do not have enough silicon!")
            Return
        End If
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to upgrade Metal Foundary?", MsgBoxStyle.YesNo, "Sure?")
        If result = MsgBoxResult.Yes Then
            frmMain.SendMessage("structures", "MetalFoundry")
        End If
    End Sub

    Private Sub TabOverview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabOverview.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxRefresh.Click
        frmMain.SendMessage("resources", "getresources")
    End Sub

    Private Sub btnsiliconextractorupgrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiliconextractorupgrade.Click
        If frmMain.Playerstats.metal < CalculateSilicon(frmMain.Playerstats.SiliconExtractorLevel, "m") Then
            MsgBox("You do not have enough metal!")
            Return
        ElseIf frmMain.Playerstats.silicon < CalculateSilicon(frmMain.Playerstats.SiliconExtractorLevel, "s") Then
            MsgBox("You do not have enough silicon!")
            Return
        End If
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to upgrade Silicon Extractor?", MsgBoxStyle.YesNo, "Sure?")
        If result = MsgBoxResult.Yes Then
            frmMain.SendMessage("structures", "SiliconExtractor")
        End If
    End Sub

    Private Sub btntritiumgeneratorupgrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntritiumgeneratorupgrade.Click
        If frmMain.Playerstats.metal < CalculateTritium(frmMain.Playerstats.TritiumGeneratorLevel, "m") Then
            MsgBox("You do not have enough metal!")
            Return
        ElseIf frmMain.Playerstats.silicon < CalculateTritium(frmMain.Playerstats.TritiumGeneratorLevel, "s") Then
            MsgBox("You do not have enough silicon!")
            Return
        End If
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to upgrade Tritium Generator?", MsgBoxStyle.YesNo, "Sure?")
        If result = MsgBoxResult.Yes Then
            frmMain.SendMessage("structures", "TritiumGenerator")
        End If
    End Sub

    Private Sub BtnUpgradeShipyard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpgradeShipyard.Click
        If frmMain.Playerstats.metal < CalculateShipyard(frmMain.Playerstats.ShipyardLevel, "m") Then
            MsgBox("You do not have enough metal!")
            Return
        ElseIf frmMain.Playerstats.silicon < CalculateShipyard(frmMain.Playerstats.ShipyardLevel, "s") Then
            MsgBox("You do not have enough silicon!")
            Return
        ElseIf frmMain.Playerstats.tritium < CalculateShipyard(frmMain.Playerstats.ShipyardLevel, "t") Then
            MsgBox("You do not have enough tritium!")
            Return
        End If
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to upgrade Shipyard?", MsgBoxStyle.YesNo, "Sure?")
        If result = MsgBoxResult.Yes Then
            frmMain.SendMessage("structures", "Shipyard")
        End If
    End Sub

    Private Sub BtnUpgradeResearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpgradeResearch.Click
        If frmMain.Playerstats.metal < CalculateResearchLab(frmMain.Playerstats.ResearchLabLevel, "m") Then
            MsgBox("You do not have enough metal!")
            Return
        ElseIf frmMain.Playerstats.silicon < CalculateResearchLab(frmMain.Playerstats.ResearchLabLevel, "s") Then
            MsgBox("You do not have enough silicon!")
            Return
        ElseIf frmMain.Playerstats.tritium < CalculateResearchLab(frmMain.Playerstats.ResearchLabLevel, "t") Then
            MsgBox("You do not have enough tritium!")
            Return
        End If
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to upgrade Research Lab?", MsgBoxStyle.YesNo, "Sure?")
        If result = MsgBoxResult.Yes Then
            frmMain.SendMessage("structures", "ResearchLab")
        End If
    End Sub


    Private Sub BtnUpgradeRF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpgradeRF.Click
        If frmMain.Playerstats.metal < CalculateRoboticsFactory(frmMain.Playerstats.RoboticsFactoryLevel, "m") Then
            MsgBox("You do not have enough metal!")
            Return
        ElseIf frmMain.Playerstats.silicon < CalculateRoboticsFactory(frmMain.Playerstats.RoboticsFactoryLevel, "s") Then
            MsgBox("You do not have enough silicon!")
            Return
        ElseIf frmMain.Playerstats.tritium < CalculateRoboticsFactory(frmMain.Playerstats.RoboticsFactoryLevel, "t") Then
            MsgBox("You do not have enough tritium!")
            Return
        End If
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to upgrade Robotics Factory?", MsgBoxStyle.YesNo, "Sure?")
        If result = MsgBoxResult.Yes Then
            frmMain.SendMessage("structures", "RoboticsFactory")
        End If
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblroboticsfactorylevel.Click

    End Sub

    Private Sub Btnresearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnresearch.Click
        TabControl.SelectTab(2)

    End Sub

    Private Sub PictureBoxWeaponsTech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.SendMessage("research", "checkWeaponsTech")
    End Sub

    Private Sub PictureBoxShieldTech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.SendMessage("research", "checkShieldingTech")
    End Sub

    Private Sub PictureBoxFuelTech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.SendMessage("research", "checkFuelEfficiencyTech")
    End Sub

    Private Sub PictureBoxArmourTech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.SendMessage("research", "checkDefenceTech")
    End Sub

    Private Sub PictureBoxSolarEngine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxSolarEngine.Click
        frmMain.SendMessage("research", "checkSolarEngineTech")
    End Sub

    Private Sub PictureBoxRocketEngine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.SendMessage("research", "checkRocketEngineTech")
    End Sub

    Private Sub PictureBoxNuclearFusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxNuclearFusion.Click
        frmMain.SendMessage("research", "checkNuclearFusionTech")
    End Sub

    Private Sub PictureBoxHyperspaceEngine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxHyperspaceEngine.Click
        frmMain.SendMessage("research", "checkHyperspaceEngineTech")
    End Sub

    Private Sub PictureBoxColonisation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxColonisation.Click
        frmMain.SendMessage("research", "checkColonisationTech")
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub PictureBoxWarpDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxWarpDrive.Click
        frmMain.SendMessage("research", "checkWarpDriveTech")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub TabPage13_Click(sender As Object, e As EventArgs) Handles TabResearch2.Click

    End Sub

    Private Sub frmGame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Close()
    End Sub

    Public Sub UpdateStructures()
        lblmetalfoundarylevel.Text = "(Level " & frmMain.Playerstats.Structures("Metal Foundry") & ")"
        lblmetalupgradecost.Text = "Upgrade cost -- Metal: " & CalculateMetal(frmMain.Playerstats.Structures("Metal Foundry"), "m") & "  Silicon: " & CalculateMetal(frmMain.Playerstats.Structures("Metal Foundry"), "s")
        lblsiliconextractorlevel.Text = "(Level " & frmMain.Playerstats.Structures("Silicon Extractor") & ")"
        lblsiliconextractorcost.Text = "Upgrade cost -- Metal: " & CalculateSilicon(frmMain.Playerstats.Structures("Silicon Extractor"), "m") & "  Silicon: " & CalculateSilicon(frmMain.Playerstats.Structures("Silicon Extractor"), "s")
        lbltritiumgeneratorlevel.Text = "(Level " & frmMain.Playerstats.Structures("Tritium Generator") & ")"
        lbltritiumgeneratorcost.Text = "Upgrade cost -- Metal: " & CalculateTritium(frmMain.Playerstats.Structures("Tritium Generator"), "m") & "  Silicon: " & CalculateTritium(frmMain.Playerstats.Structures("Tritium Generator"), "s")
        lblshipyardlevel.Text = "(level " & frmMain.Playerstats.Structures("Shipyard") & ")"
        lblshipyardrequirements.Text = "Upgrade cost -- Metal: " & CalculateShipyard(frmMain.Playerstats.Structures("Shipyard"), "m") & "  Silicon: " & CalculateShipyard(frmMain.Playerstats.Structures("Shipyard"), "s") & "  Tritium: " & CalculateShipyard(frmMain.Playerstats.Structures("Shipyard"), "t")
        lblresearchlablevel.Text = "(level " & frmMain.Playerstats.Structures("Research Lab") & ")"
        lblresearchlabrequirements.Text = "Upgrade cost -- Metal: " & CalculateResearchLab(frmMain.Playerstats.Structures("Research Lab"), "m") & "  Silicon: " & CalculateResearchLab(frmMain.Playerstats.Structures("Research Lab"), "s") & "  Tritium: " & CalculateResearchLab(frmMain.Playerstats.Structures("Research Lab"), "t")
        lblroboticsfactorylevel.Text = "(level " & frmMain.Playerstats.Structures("Robotics Factory") & ")"
        lblroboticsfactoryrequirements.Text = "Upgrade cost -- Metal: " & CalculateRoboticsFactory(frmMain.Playerstats.Structures("Robotics Factory"), "m") & "  Silicon: " & CalculateRoboticsFactory(frmMain.Playerstats.Structures("Robotics Factory"), "s") & "  Tritium: " & CalculateRoboticsFactory(frmMain.Playerstats.Structures("Robotics Factory"), "t")

    End Sub


End Class