Imports System.Drawing
Imports FPSCounter.SAMP_API.API


Namespace Udrakoloader

    Public Class Plugin

        Private Shared processGame As Process = Process.GetCurrentProcess()
        Private Shared processName As String = processGame.ProcessName & ".exe"

#Region " Structure "

        Public Structure GameSize
            Shared X As Integer = 5
            Shared Y As Integer = 5
            Shared InfoNumber As Integer = 0
        End Structure

        Public Structure LabelZoneText
            Shared Text As String = ""
            Shared X As Integer = 50
            Shared Y As Integer = 50
            Shared FontColor As Color = Color.DodgerBlue
            Shared TextSize As Integer = 10
            Shared TextStyle As String = "Arial"
            Shared InfoNumber As Integer = -1
            Shared bBold As Boolean = False
        End Structure

#End Region

        Public Shared Function EntryPoint(ByVal pwzArgument As String) As Integer
            Dim tskThread As New Task(ScriptAsyc, TaskCreationOptions.LongRunning)
            tskThread.Start()
            Return 0
        End Function

        Private Shared CzoneText As String = String.Empty


        Private Shared ScriptAsyc As New Action(
        Sub()



            ' Do While True ' Normal Bucle
            '  Hack
            ' Loop
            If processName = "gta_sa.exe" Then
                For x As Integer = 0 To 2
                    Dim Cped As Boolean = CBool(GetPlayerCPed())
                    If Cped = True Then
                        Exit For
                    End If
                    x -= 1
                Next
            End If

            If processName = "gta_sa.exe" Then
                SetParam("process", processName)
            Else
                DX9OverlayAPI.DX9Overlay.SetParam("process", processName)
            End If


            If processName = "gta_sa.exe" Then
                For FixDraw As Integer = 0 To 10
                    LabelZoneText.InfoNumber = TextCreate(LabelZoneText.TextStyle, LabelZoneText.TextSize, LabelZoneText.bBold, False, LabelZoneText.X, LabelZoneText.Y, colorFormat(LabelZoneText.FontColor), LabelZoneText.Text, False, True)
                    TextDestroy(LabelZoneText.InfoNumber)
                Next
            End If


            If processName = "gta_sa.exe" Then
                LabelZoneText.InfoNumber = TextCreate(LabelZoneText.TextStyle, LabelZoneText.TextSize, LabelZoneText.bBold, False, LabelZoneText.X, LabelZoneText.Y, colorFormat(LabelZoneText.FontColor), LabelZoneText.Text, True, True)
                SetOverlayCalculationEnabled(LabelZoneText.InfoNumber, False)
            Else
                LabelZoneText.InfoNumber = DX9OverlayAPI.DX9Overlay.TextCreate(LabelZoneText.TextStyle, LabelZoneText.TextSize, LabelZoneText.bBold, False, LabelZoneText.X, LabelZoneText.Y, colorFormat(LabelZoneText.FontColor), LabelZoneText.Text, False, True)
            End If

            For i As Integer = 0 To 2 ' My Bucle XD
                Try

                    If processName = "gta_sa.exe" Then
                        CzoneText = "FPS: " & GetFrameRate()
                    Else
                        CzoneText = "FPS: " & DX9OverlayAPI.DX9Overlay.GetFrameRate()
                    End If

                    Dim GameResolutionScreen As New Point

                    If processName = "gta_sa.exe" Then
                        GameResolutionScreen = GetScreenSpecsOverlay()
                    Else
                        GameResolutionScreen = DX9OverlayAPI.DX9Overlay.GetScreenSpecsOverlay()
                    End If



                    GameSize.X = GameResolutionScreen.X
                    GameSize.Y = GameResolutionScreen.Y

                    LabelZoneText.X = Val((GameSize.X / 2) - (10))
                    LabelZoneText.Y = Val(10) 'Val((GameSize.Y - 30)) 'GameSize.Y  '


                    If Not CzoneText = LabelZoneText.Text Then
                        If processName = "gta_sa.exe" Then
                            TextSetString(LabelZoneText.InfoNumber, CzoneText)
                            TextSetPos(LabelZoneText.InfoNumber, LabelZoneText.X, LabelZoneText.Y)
                        Else
                            DX9OverlayAPI.DX9Overlay.TextSetString(LabelZoneText.InfoNumber, CzoneText)
                            DX9OverlayAPI.DX9Overlay.TextSetPos(LabelZoneText.InfoNumber, LabelZoneText.X, LabelZoneText.Y)
                        End If

                        LabelZoneText.Text = CzoneText
                    End If

                Catch ex As Exception

                End Try
                i -= 1
            Next
        End Sub)

    End Class

End Namespace



