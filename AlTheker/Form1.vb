Imports Microsoft.Win32
Public Class Form1


    '//////////////////////////////////////////////////////////
    Private ShowType As Int32
    Private ScrWidth As Int32, ScrHeight As Int32
    Private ScrWidthOrg As Int32, ScrHeightOrg As Int32
    '//
    Private Strs As String()
    Private Lst As New List(Of String)
    '//
    Private StopStatus As Boolean
    '//
    Private i As Int32 = 0
    Private iLst As Int32 = 0
    Private ReqHieght, ReqWedith As Int32
    '//////////////////////////////////////////////////////////

    ''' <summary>
    ''' StartUpTimer Timer : To Start All Process From Beginning ...
    ''' Timer 1 : Set Form Location And Change The Text 
    ''' Timer 2 : Move The Form Or Change The Opacity Depends On The Showing Type 
    ''' Timer 3 : To Stop The Form For A While So The User Can Read The Contents 
    ''' Timer 4 : Hide And Reset The Form Style And Location 
    ''' Timer 5 : Playing Sounds
    ''' </summary>

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Me.Hide() '// Hide Window On Double Click
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '// Set Form Options
        Me.Hide()
        Me.Visible = False
        Me.Size = New Size(0, 0)
        Me.TopLevel = True
        Me.TopMost = True
        Me.ShowInTaskbar = False

        '// Set Program To Run At Startup
        Call firstRunStartupSettings()

        '// Create The Main Key 
        Registry.SetValue(loc, "AlTheker", "test")

        '// Do Stuff ...
        player.Show()
        If _TextShow = False And _SoundVoice = False Then
            Options.Show()
            Options.Refresh()
        End If
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(1000)
        Call SetUpThings()
    End Sub

#Region "Timers And SetUpThings Fun ..."

    Sub SetUpThings()
        Me.Hide()
        Me.Visible = False

        '// Stop All, Just In Case The User Has Changed All Settings Within Runtime !
        Timer1.Stop() : Timer2.Stop() : Timer3.Stop() : Timer4.Stop() : Timer5Sound.Stop()
        Timer6TextColors.Stop() : StopTimer.Stop()

        '// Set Up The Time For Text Appearance Timer 
        If _TextShow Then
            '// Get Screen And Taskbar Info ...
            ScrWidthOrg = My.Computer.Screen.Bounds.Width
            ScrHeightOrg = My.Computer.Screen.Bounds.Height
            Select Case getTaskbarPosition()
                Case taskbarPosition.ABE_RIGHT, taskbarPosition.ABE_BOTTOM
                    ScrWidth = My.Computer.Screen.WorkingArea.Width
                    ScrHeight = My.Computer.Screen.WorkingArea.Height
                Case Else '// ABE_TOP, ABE_LEFT, AutoHide ...
                    ScrWidth = ScrWidthOrg
                    ScrHeight = ScrHeightOrg
            End Select

            Timer1.Interval = _TextTime * 1000 * 60
            Timer3.Interval = _StopTime * 1000
            Strs = Split(My.Computer.FileSystem.ReadAllText(_TxtPath), Options.splitSymbol)
        End If

        '// Set Up The Time For Sound Maker Timer
        If _SoundVoice Then
            iLst = 0
            Timer5Sound.Interval = _VoiceTime * 1000 * 60
            Lst.AddRange(Split(My.Computer.FileSystem.ReadAllText(_SoundPath), vbCrLf))
            Timer5Sound.Start()
        End If

        '// Do Some Stuff ...
        ShowType = _ShowType
        If ShowType = showingType.UP_DOWN Then
            Me.Opacity = _Opacity * 0.01 '// Get The Percent Of Opacity
        ElseIf ShowType = showingType.SHOW_HIDE Then
            Me.Opacity = 1
        End If

        '//Background Options
        If _BackgroundType = backgroundShowingType.color Then
            Me.BackgroundImage = Nothing
            Me.BackColor = _BackgroundColor
        ElseIf _BackgroundType = backgroundShowingType.picture Then
            Me.BackgroundImage = Image.FromStream(New IO.MemoryStream(IO.File.ReadAllBytes(_BackgroundPicPath)))
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Application.DoEvents()
        End If

        '//Fonts Options
        If _FontColorType = FontColorShowingType.manyColors Then
            Label1.ForeColor = Color.Red
            Timer6TextColors.Start()
        ElseIf _FontColorType = FontColorShowingType.specificColor Then
            Timer6TextColors.Stop()
            Label1.ForeColor = _FontColor
        End If
        Label1.Font = _FontType

        '//Finally SetText Up Timers (i, iLst) And Start The Show ...
        If _TextShow Then
            i = 0
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '// If The user Want To Stop The Show For A While Don't Show Aything 
        If StopStatus Then Exit Sub

        '// Set Up Label Text Style And Form 
        Label1.Text = Strs(i)
        Label1.Location = New Point(0, 0)
        Me.Size = Label1.Size
        If i <> Strs.Length - 1 Then i += 1 Else i = 0

        '// Set Up Form Location
        ReqWedith = ScrWidth - Me.Width
        ReqHieght = ScrHeight - Me.Height
        If ShowType = showingType.UP_DOWN Then
            Me.Location = New Point(ReqWedith, ScrHeightOrg)
        ElseIf ShowType = showingType.SHOW_HIDE Then
            Me.Location = New Point(ReqWedith, ReqHieght)
            Me.Opacity = 0
        End If

        '// Show And Start Timer2
        Me.Show()
        Me.Visible = True
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If ShowType = showingType.UP_DOWN Then
            Me.Location = New Point(ReqWedith, Me.Location.Y - 1)
            Me.Refresh()
            If Me.Location = New Point(ReqWedith, ReqHieght) Then
                Timer3.Start()
                Timer2.Stop()
                Exit Sub
            End If
        ElseIf ShowType = showingType.SHOW_HIDE Then
            Me.Opacity += 0.01
            Me.Refresh()
            If Me.Opacity = 1 Then
                Timer3.Start()
                Timer2.Stop()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        If ShowType = showingType.UP_DOWN Then
            Me.Location = New Point(ReqWedith, Me.Location.Y + 1)
            Me.Refresh()
            If Me.Location = New Point(ReqWedith, ScrHeightOrg) Then
                Me.Hide()
                Me.Visible = False
                Timer1.Start()
                Timer4.Stop()
                Exit Sub
            End If
        ElseIf ShowType = showingType.SHOW_HIDE Then
            Me.Opacity -= 0.01
            Me.Refresh()
            If Me.Opacity = 0 Then
                Me.Hide()
                Me.Visible = False
                Timer1.Start()
                Timer4.Stop()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Timer5Sound_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5Sound.Tick
        '// If The user Want To Pause The Program For A While Don't Show Aything 
        If StopStatus Then Exit Sub

        Dim SoundPath As String = Lst(iLst)
        If IO.File.Exists(SoundPath) Then
            player.AxWindowsMediaPlayer1.URL = Lst(iLst)
        End If
        iLst += 1
        If iLst > Lst.Count - 1 Then iLst = 0
    End Sub

    Private Sub Timer6TextColors_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6TextColors.Tick
        If Label1.ForeColor = Color.Red Then
            Label1.ForeColor = Color.Orange
        ElseIf Label1.ForeColor = Color.Orange Then
            Label1.ForeColor = Color.Yellow
        ElseIf Label1.ForeColor = Color.Yellow Then
            Label1.ForeColor = Color.YellowGreen
        ElseIf Label1.ForeColor = Color.YellowGreen Then
            Label1.ForeColor = Color.Blue
        ElseIf Label1.ForeColor = Color.Blue Then
            Label1.ForeColor = Color.Purple
        ElseIf Label1.ForeColor = Color.Purple Then
            Label1.ForeColor = Color.Red
        End If
        Label1.Refresh()
    End Sub

#End Region

#Region "Menu Strip Tool"

    Private Sub ExitProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitProgramToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
        End
    End Sub

    Private Sub RestartProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestartProgramToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
        Application.Restart()
    End Sub

    Private Sub ProgramSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProgramSettingsToolStripMenuItem.Click
        Options.Show()
    End Sub

    Private Sub RunProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunProgramToolStripMenuItem.Click
        StopStatus = False
    End Sub

    Private Sub StopProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StopProgramToolStripMenuItem.Click
        StopStatus = True
    End Sub

    Private Sub Stop5Min_Click(sender As System.Object, e As System.EventArgs) Handles Stop5Min.Click
        Call SetUpStop(5 * 60 * 1000)
    End Sub

    Private Sub Stop10Min_Click(sender As System.Object, e As System.EventArgs) Handles Stop10Min.Click
        Call SetUpStop(10 * 60 * 1000)
    End Sub

    Private Sub Stop15Min_Click(sender As System.Object, e As System.EventArgs) Handles Stop15Min.Click
        Call SetUpStop(15 * 60 * 1000)
    End Sub

    Private Sub Stop30Min_Click(sender As System.Object, e As System.EventArgs) Handles Stop30Min.Click
        Call SetUpStop(30 * 60 * 1000)
    End Sub

    Private Sub Stop60Min_Click(sender As System.Object, e As System.EventArgs) Handles Stop60Min.Click
        Call SetUpStop(60 * 60 * 1000)
    End Sub

    Sub SetUpStop(TimerTime As Int32)
        StopTimer.Stop()
        StopTimer.Interval = TimerTime
        StopStatus = True
        StopTimer.Start()
    End Sub

    Private Sub StopTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StopTimer.Tick
        StopStatus = False
        StopTimer.Stop()
    End Sub
#End Region

 

End Class
