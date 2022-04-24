Imports Microsoft.Win32
Module Propertys

    '// Constants Paths ...
    Public ReadOnly _TxtPath As String = Application.StartupPath + "\AlthekerText.txt"
    Public ReadOnly _SoundPath As String = Application.StartupPath + "\SoundsText.txt"
    Public ReadOnly _BackgroundPicPath As String = Application.StartupPath + "\Background"

    '// Constants Strings ...
    Public Const loc = "HKEY_CURRENT_USER\Software\AlTheker"
    Private Const VoiceTime = "VoiceTime"
    Private Const TextTime = "TextTime"
    Private Const StopTime = "StopTime"
    Private Const TextShow = "TextShow"
    Private Const FontType = "FontType"
    Private Const SoundVoice = "SoundVoice"
    Private Const ShowType = "ShowType"
    Private Const Opacity = "Opacity"
    Private Const FontColorType = "FontColorType"
    Private Const FontColor = "FontColor"
    'Private Const BackgroundPicture = "BackgroundPicture"
    Private Const BackgroundColor = "BackgroundColor"
    Private Const BackgroundType = "BackgroundType"
    '// Defaults
    Private Const defaultFont = "Tahoma|Bold|12"
    Private Const defaultFontColor = "0|0|0"
    Private Const defaultBackgroundColor = "135|206|235"
    Private Const separator = "|"
    '// Enums
    Public Enum showingType As Int32
        UP_DOWN = 1
        SHOW_HIDE = 2
    End Enum
    Public Enum FontColorShowingType As Int32
        manyColors = 1
        specificColor = 2
    End Enum
    Public Enum backgroundShowingType As Int32
        color = 1
        picture = 2
    End Enum



    '// Time For Sound Timer
    Public Property _VoiceTime() As Int32
        Get
            Return Registry.GetValue(loc, VoiceTime, 5)
        End Get
        Set(TimeValue As Int32)
            Registry.SetValue(loc, VoiceTime, TimeValue.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    '// Time For Text Appearance Timer
    Public Property _TextTime() As Int32
        Get
            Return Registry.GetValue(loc, TextTime, 3)
        End Get
        Set(TimeValue As Int32)
            Registry.SetValue(loc, TextTime, TimeValue.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    '// Time For Reading The Text While Appearance
    Public Property _StopTime() As Int32
        Get
            Return Registry.GetValue(loc, StopTime, 1)
        End Get
        Set(TimeValue As Int32)
            Registry.SetValue(loc, StopTime, TimeValue.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    '// Boolean If The User Wanna Show Text Or Not
    Public Property _TextShow() As Boolean
        Get
            Return IO.File.Exists(_TxtPath) And Registry.GetValue(loc, TextShow, 0)
        End Get
        Set(Opt As Boolean)
            Dim OptInt As Int32 = 0
            If Opt Then OptInt = 1
            Registry.SetValue(loc, TextShow, OptInt.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    '// Boolean If The User Wanna Hear Sound or Not
    Public Property _SoundVoice() As Boolean
        Get
            Return IO.File.Exists(_SoundPath) And Registry.GetValue(loc, SoundVoice, 0)
        End Get
        Set(Opt As Boolean)
            Dim OptInt As Int32 = 0
            If Opt Then OptInt = 1
            Registry.SetValue(loc, SoundVoice, OptInt.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property


    Public Property _ShowType() As showingType
        Get
            Return Registry.GetValue(loc, ShowType, 1)
        End Get
        Set(Opt As showingType)
            Registry.SetValue(loc, ShowType, Val(Opt).ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    Public Property _Opacity() As Int32
        Get
            Return Registry.GetValue(loc, Opacity, 60)
        End Get
        Set(OpacityValue As Int32)
            Registry.SetValue(loc, Opacity, Val(OpacityValue).ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property


    Public Property _FontColorType() As FontColorShowingType
        Get
            Return Registry.GetValue(loc, FontColorType, 1)
        End Get
        Set(Opt As FontColorShowingType)
            Registry.SetValue(loc, FontColorType, Val(Opt).ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property


    Public Property _BackgroundType() As backgroundShowingType
        Get
            If Registry.GetValue(loc, BackgroundType, 1) = backgroundShowingType.picture Then
                If IO.File.Exists(_BackgroundPicPath) Then Return backgroundShowingType.picture
            End If
            Return backgroundShowingType.color
        End Get

        Set(Opt As backgroundShowingType)
            Registry.SetValue(loc, BackgroundType, Val(Opt).ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    Public Property _BackgroundColor() As Color
        Get
            Dim Vals As String() = Split(Registry.GetValue(loc, BackgroundColor, defaultBackgroundColor), separator)
            Return Color.FromArgb(Vals(0), Vals(1), Vals(2))
        End Get
        Set(ColorFromStruct As Color)
            Registry.SetValue(loc, BackgroundColor, ColorFromStruct.R.ToString + separator + ColorFromStruct.G.ToString + separator + ColorFromStruct.B.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property


    Public Property _FontColor() As Color
        Get
            Dim Vals As String() = Split(Registry.GetValue(loc, FontColor, defaultFontColor), separator)
            Return Color.FromArgb(Vals(0), Vals(1), Vals(2))
        End Get
        Set(ColorFromStruct As Color)
            Registry.SetValue(loc, FontColor, ColorFromStruct.R.ToString + separator + ColorFromStruct.G.ToString + separator + ColorFromStruct.B.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    Private Function GetNumOfStyle(StyleStr As String) As Int32
        For i = 0 To 4
            If StyleStr = [Enum].GetName(GetType(FontStyle), i) Then
                Return i
            End If
        Next
        Return 0
    End Function

    Public Property _FontType() As Font
        Get
            Dim Vals As String() = Split(Registry.GetValue(loc, FontType, defaultFont), separator)
            Return New Font(Vals(0), Vals(2), GetNumOfStyle(Vals(1)), GraphicsUnit.World)
        End Get
        Set(FontVar As Font)
            Registry.SetValue(loc, FontType, FontVar.FontFamily.Name.ToString + separator + FontVar.Style.ToString + separator + FontVar.Size.ToString, Microsoft.Win32.RegistryValueKind.String)
        End Set
    End Property

    Public Sub ClearAllValues()
        Dim x As Microsoft.Win32.RegistryKey
        x = My.Computer.Registry.CurrentUser.OpenSubKey(loc.Replace("HKEY_CURRENT_USER\", ""), True)
        x.DeleteValue(VoiceTime, False)
        x.DeleteValue(TextTime, False)
        x.DeleteValue(StopTime, False)
        x.DeleteValue(TextShow, False)
        x.DeleteValue(SoundVoice, False)
        x.DeleteValue(ShowType, False)
        x.DeleteValue(Opacity, False)
        x.DeleteValue(FontColorType, False)
        x.DeleteValue(FontColor, False)
        x.DeleteValue(FontType, False)
        x.DeleteValue(BackgroundColor, False)
        x.DeleteValue(BackgroundType, False)
        x.Close()

        On Error Resume Next
        IO.File.Delete(_TxtPath)
        IO.File.Delete(_SoundPath)
        IO.File.Delete(_BackgroundPicPath)
    End Sub


End Module
