Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text

Namespace SAMP_API
    Class API

        Public Const PATH As String = "\lib\Open-SAMP-API.dll"

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function Init() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Sub SetParam(ByVal _szParamName As String, ByVal _szParamValue As String)
        End Sub

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetGTACommandLine(ByRef line As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsMenuOpen() As Boolean
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ScreenToWorld(ByVal x As Single, ByVal y As Single, <Out> ByRef worldX As Single, <Out> ByRef worldY As Single, <Out> ByRef worldZ As Single) As Boolean
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function WorldToScreen(ByVal x As Single, ByVal y As Single, ByVal z As Single, <Out> ByRef screenX As Single, <Out> ByRef screenY As Single) As Boolean
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerCPed() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerHealth() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerArmor() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerMoney() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerSkinID() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerInterior() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsPlayerInAnyVehicle() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsPlayerDriver() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsPlayerPassenger() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsPlayerInInterior() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerX(<Out> ByRef posX As Single) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerY(<Out> ByRef posY As Single) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerZ(<Out> ByRef posZ As Single) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerPosition(<Out> ByRef posX As Single, <Out> ByRef posY As Single, <Out> ByRef posZ As Single) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsPlayerInRange2D(ByVal posX As Single, ByVal posY As Single, ByVal radius As Single) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsPlayerInRange3D(ByVal posX As Single, ByVal posY As Single, ByVal posZ As Single, ByVal radius As Single) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetCityName(ByRef cityName As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetZoneName(ByRef zoneName As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextCreate(ByVal Font As String, ByVal FontSize As Integer, ByVal bBold As Boolean, ByVal bItalic As Boolean, ByVal x As Integer, ByVal y As Integer, ByVal color As Integer, ByVal text As String, ByVal bShadow As Boolean, ByVal bShow As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextDestroy(ByVal ID As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextSetShadow(ByVal id As Integer, ByVal b As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextSetShown(ByVal id As Integer, ByVal b As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextSetColor(ByVal id As Integer, ByVal color As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextSetPos(ByVal id As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextSetString(ByVal id As Integer, ByVal str As String) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function TextUpdate(ByVal id As Integer, ByVal Font As String, ByVal FontSize As Integer, ByVal bBold As Boolean, ByVal bItalic As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxCreate(ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer, ByVal dwColor As Integer, ByVal bShow As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxDestroy(ByVal id As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxSetShown(ByVal id As Integer, ByVal bShown As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxSetBorder(ByVal id As Integer, ByVal height As Integer, ByVal bShown As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxSetBorderColor(ByVal id As Integer, ByVal dwColor As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxSetColor(ByVal id As Integer, ByVal dwColor As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxSetHeight(ByVal id As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxSetPos(ByVal id As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function BoxSetWidth(ByVal id As Integer, ByVal width As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LineCreate(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal width As Integer, ByVal color As Integer, ByVal bShow As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LineDestroy(ByVal id As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LineSetShown(ByVal id As Integer, ByVal bShown As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LineSetColor(ByVal id As Integer, ByVal color As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LineSetWidth(ByVal id As Integer, ByVal width As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LineSetPos(ByVal id As Integer, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ImageCreate(ByVal path As String, ByVal x As Integer, ByVal y As Integer, ByVal rotation As Integer, ByVal align As Integer, ByVal bShow As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ImageDestroy(ByVal id As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ImageSetShown(ByVal id As Integer, ByVal bShown As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ImageSetAlign(ByVal id As Integer, ByVal align As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ImageSetPos(ByVal id As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ImageSetRotation(ByVal id As Integer, ByVal rotation As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function DestroyAllVisual() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ShowAllVisual() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function HideAllVisual() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetFrameRate() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetScreenSpecs(<Out> ByRef width As Integer, <Out> ByRef height As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function SetCalculationRatio(ByVal width As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function SetOverlayPriority(ByVal id As Integer, ByVal priority As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function SetOverlayCalculationEnabled(ByVal id As Integer, ByVal enabled As Boolean) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetServerIP(ByRef ip As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetServerPort() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function SendChat(ByVal msg As String) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ShowGameText(ByVal msg As String, ByVal time As Integer, ByVal style As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function AddChatMessage(ByVal msg As String) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function ShowDialog(ByVal id As Integer, ByVal style As Integer, ByVal caption As String, ByVal text As String, ByVal button As String, ByVal button2 As String) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerNameByID(ByVal id As Integer, ByRef playername As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerIDByName(ByVal name As String) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerName(ByRef playername As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerId() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsChatOpen() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsDialogOpen() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehiclePointer() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleSpeed(ByVal factor As Single) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleHealth() As Single
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleModelId() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleModelName(ByRef name As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleModelNameById(ByVal vehicleID As Integer, ByRef name As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleType() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleFreeSeats(<Out> ByRef seatFL As Integer, <Out> ByRef seatFR As Integer, <Out> ByRef seatRL As Integer, <Out> ByRef seatRR As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleFirstColor() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleSecondColor() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetVehicleColor(<Out> ByRef color1 As Integer, <Out> ByRef color2 As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleSeatUsed(ByVal seat As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleLocked() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleHornEnabled() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleSirenEnabled() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleAlternateSirenEnabled() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleEngineEnabled() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleLightEnabled() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleCar() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehiclePlane() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleBoat() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleTrain() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function IsVehicleBike() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function HasWeaponIDClip(ByVal weaponID As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponID() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponType() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponSlot() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponName(ByVal dwWeapSlot As Integer, ByRef _szWeapName As StringBuilder, ByVal max_len As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponClip(ByVal dwWeapSlot As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponTotalClip(ByVal dwWeapSlot As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponState() As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponAmmo(ByVal weaponType As Integer) As Integer
        End Function

        <DllImport(PATH, CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function GetPlayerWeaponAmmoInClip(ByVal weaponType As Integer) As Integer
        End Function

        Public Shared Sub SendChatEx(ByVal message As String, ParamArray args As Object())
            If message.Length <> 0 Then
                If args.Length > 0 Then message += " " & String.Join(" ", args)
                SendChat(message)
            End If
        End Sub

        Public Shared Sub AddChatMessageEx(ByVal text As String, Optional ByVal color As String = "FFFFFF")
            AddChatMessage("{" & color & "}" & text)
        End Sub

        Public Shared Sub AddChatMessageEx(ByVal text As String, ByVal color As Color)
            AddChatMessage("{" & ColorToHexRGB(color) & "}" & text)
        End Sub

        Public Shared Sub AddChatMessageEx(ByVal prefix As String, ByVal prefixColor As String, ByVal text As String, Optional ByVal color As String = "FFFFFF")
            AddChatMessage("{" & prefixColor & "}" & prefix & " {" & color & "}" & text)
        End Sub

        Public Shared Sub AddChatMessageEx(ByVal prefix As String, ByVal prefixColor As Color, ByVal text As String, ByVal color As Color)
            AddChatMessage("{" & ColorToHexRGB(prefixColor) & "}" & prefix & " {" & ColorToHexRGB(color) & "}" & text)
        End Sub

        Public Shared Function GetPlayerNameByIDEx(ByVal id As Integer) As String
            Dim builder As StringBuilder = New StringBuilder(32)
            GetPlayerNameByID(id, builder, builder.Capacity)
            Return builder.ToString()
        End Function

        Public Shared Function ColorToHexRGB(ByVal color As Color) As String
            Return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2")
        End Function

        Public Shared Function ColorToHexARGB(ByVal color As Color) As String
            Return color.A.ToString("X2") + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2")
        End Function

        Public Shared Function colorFormat(ByVal c As Color) As Integer
            Return c.ToArgb
        End Function

        Public Shared Function GetScreenSpecsOverlay() As Point
            Dim x As Integer
            Dim y As Integer
            GetScreenSpecs(x, y)
            Return New Point(x, y)
        End Function

    End Class
End Namespace
