Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Module Util

    Const _startupMsg = "هل تريد وضع البرنامج في حالة التشغيل التلقائي عند تشغيل النظام ؟"
    Sub firstRunStartupSettings()
        Dim Path As String
        Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\AlTheker\FirstStart.Txt"
        Dim FirstStart As Boolean
        FirstStart = Not My.Computer.FileSystem.FileExists(Path)
        If FirstStart Then
            If MessageBox.Show(_startupMsg, "AutoRun Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", My.Application.Info.ProductName, """" + Application.ExecutablePath + """")
            End If
            My.Computer.FileSystem.CreateDirectory(Mid(Path, 1, Path.IndexOf("\FirstStart.Txt") + 1))
            My.Computer.FileSystem.WriteAllText(Path, "Nothing", False)
        End If
    End Sub

#Region "WinAPI ..."

    Private Structure _RECT
        Dim left As Int64
        Dim top As Int64
        Dim right As Int64
        Dim bottom As Int64
    End Structure

    Private Structure PAPPBARDATA
        Dim cbSize As Int32
        Dim hWnd As IntPtr
        Dim uCallbackMessage As UInt32
        Dim uEdge As UInt32
        Dim rc As _RECT
        Dim lParam As Int32
    End Structure

    Public Enum taskbarPosition As Int32
        ABE_LEFT
        ABE_TOP
        ABE_RIGHT
        ABE_BOTTOM
    End Enum

    Const GetTaskbarPos = &H5
    <DllImport("Shell32.dll")> _
    Private Function SHAppBarMessage(dwMessage As Int32, ByRef pData As PAPPBARDATA) As UInt32
    End Function

    <DllImport("Kernel32.dll")> _
    Public Function SetProcessWorkingSetSize(hProcess As IntPtr, dwMinimumWorkingSetSize As Int32, dwMaximumWorkingSetSize As Int32) As Boolean
    End Function

    Public Function getTaskbarPosition() As UInt32
        Dim rect As New _RECT
        Dim structData As New PAPPBARDATA
        structData.rc = rect

        SHAppBarMessage(GetTaskbarPos, structData)
        Return structData.uEdge
    End Function

#End Region


End Module
