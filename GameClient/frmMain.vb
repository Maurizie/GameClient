Imports System.Text
Imports System.Security.Cryptography

Public Structure player
    Dim username As String
    Dim metal As Long
    Dim silicon As Long
    Dim tritium As Long
    Dim MetalFoundaryLevel As Integer
    Dim SiliconExtractorLevel As Integer
    Dim TritiumGeneratorLevel As Integer
    Dim RoboticsFactoryLevel As Integer
    Dim ShipyardLevel As Integer
    Dim ResearchLabLevel As Integer
    Dim Structures As Dictionary(Of String, Integer)
    Dim WeaponsTechLevel As Integer
    Dim ShieldTechLevel As Integer
    Dim ArmourTechLevel As Integer
    Dim FuelTechLevel As Integer
    Dim SolarEngineTechLevel As Integer
    Dim RocketEngineTechLevel As Integer
    Dim FusionTechLevel As Integer
    Dim ColonisationTechLevel As Integer
    Dim HyperspaceDriveTechLevel As Integer
    Dim WarpDriveTechLevel As Integer


    Sub New(ByVal Stringg As String)
        Structures = New Dictionary(Of String, Integer)
    End Sub
End Structure


Public Class frmMain
    Public WithEvents _Client As NetComm.Client
    Public Lookup As String() = {"login", "auth", "register", "tutorial", "resources", "getallstructures", "structures", "research"}
    Public ConnectType As String = ""
    Public message As String
    Public Playerstats As New player("t")
    Dim ResearchList As Dictionary(Of String, Research)
    Public Function SendMessage(ByVal LookupID As String, Optional ByVal Message As String = vbNullString)
        _Client.SendData(NetComm.Host.Convert2Ascii(Array.IndexOf(Lookup, LookupID).ToString("00") & Message), "")
        Return Nothing
    End Function
    Private Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Private Sub Connected() Handles _Client.Connected

    End Sub
    Private Sub DataReceived(ByVal Data() As Byte, ByVal ID As String) Handles _Client.DataReceived
        If ID = Nothing Then ID = "Host"
        Dim SData As String = NetComm.Host.ConvertFromAscii(Data)

        Dim LookupID As Integer = Convert.ToInt32(SData.Substring(0, 2))
        message = SData.Substring(2, SData.Length - 2)
        Select Case Lookup(LookupID)
            Case "login"
                If message = "1" Then
                    frmGame.Show()
                    MsgBox("Login success", MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Login fail")
                End If
            Case "register"
                If message = "1" Then
                    MsgBox("Register success")
                    txtrUsername.Text = vbNullString
                    txtrPass.Text = vbNullString
                    txtConfirm.Text = vbNullString
                Else
                    MsgBox("Register failed")
                    txtrPass.Text = vbNullString
                    txtConfirm.Text = vbNullString
                End If
                _Client.Disconnect()
            Case "auth"
                If ConnectType = "login" Then
                    SendMessage(ConnectType, getSHA1Hash(txtPassword.Text))
                Else
                    SendMessage(ConnectType, getSHA1Hash(txtrPass.Text))
                End If
            Case "tutorial"
                If message = "1" Then
                    frmtutorial.Show()
                    Me.Hide()
                ElseIf message = "ERROR" Then
                    MsgBox("Error with file, please contact Alex")
                End If
            Case "resources"
                'If Mid(message, 1, 1) = "m" Then
                '    PlayerStats.metal = CSng(Mid(message, 2, message.Length - 1))
                '    frmGame.lblmetal.Text = "Metal: " & PlayerStats.metal
                'ElseIf Mid(message, 1, 1) = "s" Then
                '    PlayerStats.silicon = CSng(Mid(message, 2, message.Length - 1))
                '    frmGame.lblsilicon.Text = "Silicon: " & PlayerStats.silicon
                'ElseIf Mid(message, 1, 1) = "t" Then
                '    PlayerStats.tritium = CSng(Mid(message, 2, message.Length - 1))
                '    frmGame.lbltritium.Text = "Tritium: " & PlayerStats.tritium
                'End If
                DecodeResourceMessage(message)
            Case "getallstructures"
                'If Mid(message, 1, 2) = "mf" Then
                '    Playerstats.MetalFoundaryLevel = CInt(Mid(message, 3, message.Length - 1))
                'ElseIf Mid(message, 1, 2) = "se" Then
                '    Playerstats.SiliconExtractorLevel = CInt(Mid(message, 3, message.Length - 1))
                'ElseIf Mid(message, 1, 2) = "tg" Then
                '    Playerstats.TritiumGeneratorLevel = CInt(Mid(message, 3, message.Length - 1))
                'ElseIf Mid(message, 1, 2) = "rl" Then
                '    Playerstats.ResearchLabLevel = CInt(Mid(message, 3, message.Length - 1))
                'ElseIf Mid(message, 1, 2) = "rf" Then
                '    Playerstats.RoboticsFactoryLevel = CInt(Mid(message, 3, message.Length - 1))
                'ElseIf Mid(message, 1, 2) = "sy" Then
                '    Playerstats.ShipyardLevel = CInt(Mid(message, 3, message.Length - 1))
                '    frmGame.UpdateStructures()
                'End If
                DecodeStructuresMessage(message)
                frmGame.UpdateStructures()
            Case "research"
                If Mid(message, 1, 4) = "send" Then
                    Dim ResearchLevelSend As String = Nothing
                    Dim i As Integer = 5
                    Do
                        ResearchLevelSend &= Mid(message, i, 1)
                        i += 1
                    Loop Until Mid(message, i, 1) = "@"
                    i += 1
                    Select Case ResearchLevelSend
                        Case "WeaponsTech"
                            Playerstats.WeaponsTechLevel = CInt(Mid(message, i))
                        Case "DefenceTech"
                            Playerstats.ArmourTechLevel = CInt(Mid(message, i))
                        Case "ShieldingTech"
                            Playerstats.ShieldTechLevel = CInt(Mid(message, i))
                        Case "FuelEfficiencyTechnology"
                            Playerstats.FuelTechLevel = CInt(Mid(message, i))
                        Case "RocketEngineTechnology"
                            Playerstats.RocketEngineTechLevel = CInt(Mid(message, i))
                        Case "SolarEngineTechnology"
                            Playerstats.SolarEngineTechLevel = CInt(Mid(message, i))
                        Case "NuclearFusionTechnology"
                            Playerstats.FusionTechLevel = CInt(Mid(message, i))
                        Case "ColonisationTechnology"
                            Playerstats.ColonisationTechLevel = CInt(Mid(message, i))
                        Case "HyperspaceEngineTechnology"
                            Playerstats.HyperspaceDriveTechLevel = CInt(Mid(message, i))
                        Case "WarpDriveTechnology"
                            Playerstats.WarpDriveTechLevel = CInt(Mid(message, i))
                    End Select
                End If
                If Mid(message, 1, 4) = "info" Then
                    Dim ResearchUpgrading As String = Nothing
                    Dim metalcost, siliconcost, tritiumcost As Integer
                    Dim i As Integer = 5
                    Do
                        ResearchUpgrading &= Mid(message, i, 1)
                        i += 1
                    Loop Until Mid(message, i, 1) = "@"
                    i += 1
                    Dim tempstring As String = Nothing
                    Do
                        tempstring &= Mid(message, i, 1)
                        i += 1
                    Loop Until Mid(message, i, 1) = "@"
                    metalcost = CInt(tempstring)
                    tempstring = Nothing
                    i += 1
                    Do
                        tempstring &= Mid(message, i, 1)
                        i += 1
                    Loop Until Mid(message, i, 1) = "@"
                    siliconcost = CInt(tempstring)
                    tempstring = Nothing
                    i += 1
                    tritiumcost = CInt(Mid(message, i))
                    Dim responce As MsgBoxResult
                    responce = MsgBox("The upgrade of " & ResearchUpgrading & " will cost " & metalcost & " metal    " & siliconcost & " silicon    " & tritiumcost & " tritium         are you sure you want to do it?", MsgBoxStyle.YesNo)
                    If responce = vbYes Then
                        SendMessage("research", "up" & ResearchUpgrading)
                    End If

                End If
                If message = "toolow" Then
                    MsgBox("You dont have the required resarch for that!")
                End If
                If message = "toolowres" Then
                    MsgBox("You don't have enough resources for that!")
                End If
                If message = "toolowrl" Then
                    MsgBox("You're research lab is not high enough!")
                End If
        End Select

    End Sub
    Private Sub Disconnected() Handles _Client.Disconnected
        MsgBox("You are not connected to the server!")
    End Sub
    Private Sub errHandler(ByVal ex As Exception) Handles _Client.errEncounter

    End Sub

    Private Sub cmdRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegister.Click, txtConfirm.Enter
        If Not _Client.isConnected Then
            Playerstats.username = txtrUsername.Text
            If Playerstats.username.Length < 4 Or txtrPass.MaxLength < 4 Then
                MsgBox("Username and password must be atleast 4 characters", MsgBoxStyle.Exclamation, "Error!")
                Return
            End If
            If txtrPass.Text = txtConfirm.Text Then
                Dim IP As String = InputBox("Insert the host IP address", "Host IP address")
                If IP = Nothing Then IP = "localhost"
                _Client.Connect(IP, 777, Playerstats.username)
                ConnectType = "register"
                'SendMessage("register", getSHA1Hash(txtrPass.Text))
            Else
                MsgBox("Passwords do not match!", MsgBoxStyle.Critical, "Error!")
            End If
        End If
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click, cmdLogin.Enter
        If Not _Client.isConnected Then
            Playerstats.username = txtUsername.Text
            Dim IP As String = InputBox("Insert the host IP address", "Host IP address")
            If IP = Nothing Then IP = "localhost"
            _Client.Connect(IP, 777, Playerstats.username)
            ConnectType = "login"
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        _Client.Disconnect()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Client = New NetComm.Client()
        SetUpStructureDic()
    End Sub

    Public Sub Game()

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub SetUpStructureDic()
        Playerstats.Structures.Add("Metal Foundry", 1)
        Playerstats.Structures.Add("Silicon Extractor", 1)
        Playerstats.Structures.Add("Tritium Generator", 1)
        Playerstats.Structures.Add("Research Lab", 1)
        Playerstats.Structures.Add("Shipyard", 1)
        Playerstats.Structures.Add("Robotics Factory", 1)

    End Sub

    Private Sub DecodeStructuresMessage(ByVal Message As String)
        Dim strarray As String()
        strarray = Message.Split("\")
        Playerstats.Structures("Metal Foundry") = CInt(strarray(0))
        Playerstats.Structures("Silicon Extractor") = CInt(strarray(1))
        Playerstats.Structures("Tritium Generator") = CInt(strarray(2))
        Playerstats.Structures("Research Lab") = CInt(strarray(3))
        Playerstats.Structures("Shipyard") = CInt(strarray(4))
        Playerstats.Structures("Robotics Factory") = CInt(strarray(5))
    End Sub

    Private Sub DecodeResourceMessage(ByVal Message As String)
        Dim strarray As String()
        strarray = Message.Split("\")
        Playerstats.metal = CLng(strarray(0))
        Playerstats.silicon = CLng(strarray(1))
        Playerstats.tritium = CLng(strarray(2))

        frmGame.lblmetal.Text = "Metal: " & Playerstats.metal
        frmGame.lblsilicon.Text = "Silicon: " & Playerstats.silicon
        frmGame.lbltritium.Text = "Tritium: " & Playerstats.tritium
    End Sub

    Public Sub SetUpResearches()
        Dim WeaponsTechnologyRequirements, EnergyTechnologyRequirements, DefenceTechnologyRequirements, ShieldTechnologyRequirements, ImpulseDriveRequirements, CombustionDriveRequirements, HyperspaceEngineRequirements As New Dictionary(Of String, Integer)
        Dim LaserTechRequirements, ColonisationRequirements, EspionageTechnologyRequirements, ComputerTechRequirements, HyperspaceTechRequirements, IonTechRequirements, PlasmaTechRequirements As New Dictionary(Of String, Integer)


        ImpulseDriveRequirements.Add("EnergyTech", 2)
        CombustionDriveRequirements.Add("EnergyTech", 3)
        HyperspaceTechRequirements.Add("ShieldingTech", 5) : HyperspaceEngineRequirements.Add("EnergyTech", 5)
        ShieldTechnologyRequirements.Add("EnergyTech", 3)

        ColonisationRequirements.Add("RocketEngineTech", 3) : ColonisationRequirements.Add("EspionageTech", 4)
        HyperspaceEngineRequirements.Add("EnergyTech", 5) : HyperspaceEngineRequirements.Add("ShieldingTech", 5) : HyperspaceEngineRequirements.Add("HyperspaceTech", 3)


        Dim WeaponsTechnology As New Research(800, 200, 0, "WeaponsTech", WeaponsTechnologyRequirements, 4)
        Dim DefenceTechnology As New Research(1000, 0, 0, "DefenceTech", DefenceTechnologyRequirements, 2)
        Dim ShieldTechnology As New Research(200, 600, 0, "ShieldingTech", ShieldTechnologyRequirements, 6)
        Dim EspionageTechnology As New Research(100, 1000, 200, "EspionageTech", EspionageTechnologyRequirements, 3)
        Dim EnergyTechology As New Research(0, 800, 400, "EnergyTech", EnergyTechnologyRequirements, 1)

        Dim CombustionDrive As New Research(500, 300, 200, "CombustionDrive", CombustionDriveRequirements, 2)
        Dim ImpulseDrive As New Research(1000, 2000, 1000, "ImpulseDrive", ImpulseDriveRequirements, 3)
        Dim ComputerTechnology As New Research(0, 400, 600, "ComputerTech", ComputerTechRequirements, 1)
        Dim HyperspaceTech As New Research(0, 4000, 2000, "HyperspaceTech", HyperspaceTechRequirements, 7)



        Dim ColonisationTechnology As New Research(10000, 20000, 10000, "ColonisationTech", ColonisationRequirements, 5)
        Dim HyperspaceEngineTechnology As New Research(60000, 120000, 40000, "HyperspaceEngineTech", HyperspaceEngineRequirements, 7)

        Dim LaserTechnology As New Research(1000000, 1000000, 500000, "LaserTech", LaserTechRequirements, 10)
        Dim IonTechnology As New Research(100, 100, 100, "IonTech", IonTechRequirements, 10)
        Dim PlasmaTechnology As New Research(100, 100, 100, "PlasmaTech", PlasmaTechRequirements, 10)

        ResearchList.Add("WeaponsTech", WeaponsTechnology) : ResearchList.Add("DefenceTech", DefenceTechnology) : ResearchList.Add("ShieldingTech", ShieldTechnology) : ResearchList.Add("EspionageTech", EspionageTechnology)
        ResearchList.Add("CombustionDrive", CombustionDrive) : ResearchList.Add("ImpulseDrive", ImpulseDrive) : ResearchList.Add("ComputerTech", ComputerTechnology)
        ResearchList.Add("ColonisationTech", ColonisationTechnology) : ResearchList.Add("HyperspaceEngineTech", HyperspaceEngineTechnology)
        ResearchList.Add("LaserTech", LaserTechnology) : ResearchList.Add("EnergyTech", EnergyTechology) : ResearchList.Add("IonTech", IonTechnology) : ResearchList.Add("PlasmaTech", PlasmaTechnology)
    End Sub
End Class
