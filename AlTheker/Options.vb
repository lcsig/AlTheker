Imports Microsoft.Win32
Public Class Options

    Private AlthkerStr As String = String.Empty
    Private BackgroundImg As String = String.Empty
    Private Lst As New List(Of String)
    Public Const splitSymbol = "@@@"

#Region "Strings ..."

    '// MessageBoxes SaveBtn
    Const _addSomeSounds = "قم باضافة اصوات لتشغيلها"
    Const _chooseTextFileAgain = "قم باختيار ملف النصوص مرة اخرى"
    Const _backgroundImgNotExist = "صورة الخلفية غير موجودة"
    Const _pleaseChooseAnOption = "الرجاء تعيين احد من الخيارات على الاقل"
    Const _sureToSaveNewConf = "هل انت متاكد من انك تريد حفظ الاعدادات الجديد ؟"
    Const _oldTextIsOk = "سوف يتم اعتماد الملف النصي القديم"
    Const _doneSuccessfully = "تم حفظ الاعدادات بنجاح" + vbCrLf + vbCrLf + "ملاحظة : يمكنك حذف الملف النصي الان ويمكنك حذف صورة الخلفية في حالة اختيارها والرجاء عدم حذف الملفات الصوتية لتشغيلها بنجاح"
    Const _errorDuringSaving = "حدثت مشكلة اثناء حفظ الاعدادات الرجاء اعادة حفظها مرة اخرى"
    Const _confReset = "تم اعادة الضبط ، جاري إعادة تشغيل البرنامج"
    '// Events
    Const _note = "ملاحظة"
    Const _error = "خطأ"
    Const _warning = "تحذير"
    Const _isThisYourText = "هل هذا هو النص الخاص بك ؟"
    Const _noSelectNewOne = "لا داعي لاختيار الملف النصي القديم اذا كنت قد اخترته في الاعدادات السابقة"
    Const _tryWithUTF8 = "الرجاء إعادة المحاولة مع ملف نصي آخر" + vbCrLf + vbCrLf + "حاول حفظ الملف بتشفير UTF-8"
    Const _isThisPathTrue = "هل هذا هو مسار الصورة الخاصة بك ؟"
    Const _pleaseTryAgain = "الرجاء إعادة المحاولة"
    Const _areYouSure = "هل انت متاكد ؟"
    '// Dialogs
    Const _chooseTextFileTitle = "اختر ملف الاذكار"
    Const _chooseTextFileFilter = "فقط ملفات النصوص بامتداد txt|*.txt"
    Const _chooseImgFileTitle = "اختر ملف الصورة "
    Const _chooseImgFileFilter = "ملفات الصور بالامتدادات التالية(jpg-png-bmp)|*.jpg;*.jpeg;*.png;*.bmp"
    Const _chooseSoundFileTitle = "اختر ملفات الصوت، قم باستخدام التظليل المتعدد"
    Const _chooseSoundFileFilter = "ملفات الصوت ذات الامتدادات (mp3-wav)|*.mp3;*.wav"
    '// Startup
    Const _notInStartup = "هذه البرنامج بالتاكيد ليس  في حالة البدء التلقائي."
    Const _inStartup = "هذه البرنامج في حالة البدء التلقائي."
    Const _changeStartupOpt = "هل تود تغيير هذه الحالة ?"

#End Region

#Region "Form_Load And Timer Code ..."

    Private Sub Options_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '// Set Up Theme Options And Properties 
        Me.MaximizeBox = False
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        ClsNeoBuxTheme1.MaximumSize = Me.Size
        ClsNeoBuxTheme1.MinimumSize = Me.Size
        Me.ShowInTaskbar = True

        If _TextShow = False And _SoundVoice = False Then
            Form1.Hide()
            Form1.Visible = False
        End If

        '// Enable And Disable Option And Get Sound Files Name
        ChkText.Checked = _TextShow
        If _SoundVoice Then
            ChkSoundRun.Checked = True
            Dim lstest As String() = Split(IO.File.ReadAllText(_SoundPath), vbCrLf)
            For i = 0 To lstest.Length - 1
                ListBox1.Items.Add(IO.Path.GetFileName(lstest(i)))
                Lst.Add(lstest(i))
            Next
        End If
        '// Import Settings For Text Options, GroupBox1
        If _FontColorType = FontColorShowingType.manyColors Then RadManyColorsFont.Checked = True Else RadFontColor.Checked = True
        TxtFontSample.Font = _FontType
        TxtFontSample.ForeColor = _FontColor
        '//
        If _BackgroundType = backgroundShowingType.color Then RadBackgroundColor.Checked = True Else RadBackgroundPicture.Checked = True
        TxtFontSample.BackColor = _BackgroundColor
        '//
        NumTimeEveryText.Value = _TextTime
        NumTimeStop.Value = _StopTime
        '//
        If _ShowType = showingType.UP_DOWN Then RadShowOption1.Checked = True Else RadShowOption2.Checked = True
        NumOpic.Value = _Opacity



        '// Import Settings For Sound , GroupBox2 
        NumSoundTime.Value = _VoiceTime
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If RadFontColor.Checked Then Exit Sub
        If TxtFontSample.ForeColor = Color.Red Then
            TxtFontSample.ForeColor = Color.Orange
        ElseIf TxtFontSample.ForeColor = Color.Orange Then
            TxtFontSample.ForeColor = Color.Yellow
        ElseIf TxtFontSample.ForeColor = Color.Yellow Then
            TxtFontSample.ForeColor = Color.YellowGreen
        ElseIf TxtFontSample.ForeColor = Color.YellowGreen Then
            TxtFontSample.ForeColor = Color.Blue
        ElseIf TxtFontSample.ForeColor = Color.Blue Then
            TxtFontSample.ForeColor = Color.Purple
            'ElseIf TxtFontSample.ForeColor = Color.Purple Then
            '    TxtFontSample.ForeColor = Color.Red
        Else
            TxtFontSample.ForeColor = Color.Red
        End If
    End Sub

#End Region

#Region "GroupBoxes Enabling And Disabling Code ..."

    Private Sub ChkText_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkText.CheckedChanged
        If ChkText.Checked Then
            GroupBox1.Enabled = True
            '###################
            Timer1.Start()
            TxtFontSample.BackColor = _BackgroundColor
        Else
            GroupBox1.Enabled = False
            '###################
            Timer1.Stop()
            TxtFontSample.ForeColor = Color.Black
            TxtFontSample.BackColor = Color.SkyBlue
        End If
    End Sub

    Private Sub ChkSoundRun_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkSoundRun.CheckedChanged
        GroupBox2.Enabled = ChkSoundRun.Checked
    End Sub

#End Region

#Region "Buttons And RadioBtns Events ( GroupBox1, Texts Options ) ..."

    Private Sub BtnChooseText_Click(sender As System.Object, e As System.EventArgs) Handles BtnChooseText.Click
        MessageBox.Show(_noSelectNewOne, _note, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        TxtFileText.TextAlign = HorizontalAlignment.Left

        Dim x As New OpenFileDialog
        x.Title = _chooseTextFileTitle
        x.Filter = _chooseTextFileFilter
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then
            If IO.File.Exists(x.FileName) Then
                TxtFileText.Text = x.FileName
                AlthkerStr = My.Computer.FileSystem.ReadAllText(x.FileName, System.Text.Encoding.UTF8)

                '// Yes Or Not !!!
                If MessageBox.Show(Mid(AlthkerStr, 1, 350) + " ...", _isThisYourText, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show(_tryWithUTF8, _error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    AlthkerStr = String.Empty
                    TxtFileText.Text = String.Empty
                End If

            End If
        End If
        x.Dispose()
    End Sub

    Private Sub RadManyColorsFont_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadManyColorsFont.CheckedChanged
        BtnFontColor.Enabled = Not RadManyColorsFont.Checked
    End Sub

    Private Sub RadFontColor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadFontColor.CheckedChanged
        BtnFontColor.Enabled = Not RadManyColorsFont.Checked
    End Sub

    Private Sub BtnFontType_Click(sender As System.Object, e As System.EventArgs) Handles BtnFontType.Click
        Dim x As New FontDialog
        x.ShowEffects = False
        x.Font = TxtFontSample.Font
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then TxtFontSample.Font = x.Font
        x.Dispose()
    End Sub

    Private Sub BtnFontColor_Click(sender As System.Object, e As System.EventArgs) Handles BtnFontColor.Click
        Dim x As New ColorDialog
        x.Color = TxtFontSample.ForeColor
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then TxtFontSample.ForeColor = x.Color
        x.Dispose()
    End Sub

    Private Sub RadBackgroundColor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadBackgroundColor.CheckedChanged
        BtnBackgroundColor.Enabled = RadBackgroundColor.Checked
        BtnBackgroundPicture.Enabled = Not RadBackgroundColor.Checked
    End Sub

    Private Sub RadBackgroundPicture_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadBackgroundPicture.CheckedChanged
        BtnBackgroundColor.Enabled = RadBackgroundColor.Checked
        BtnBackgroundPicture.Enabled = Not RadBackgroundColor.Checked
    End Sub

    Private Sub BtnBackgroundColor_Click(sender As System.Object, e As System.EventArgs) Handles BtnBackgroundColor.Click
        Dim x As New ColorDialog
        x.Color = TxtFontSample.BackColor
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then TxtFontSample.BackColor = x.Color
        x.Dispose()
    End Sub

    Private Sub BtnBackgroundPicture_Click(sender As System.Object, e As System.EventArgs) Handles BtnBackgroundPicture.Click
        Dim x As New OpenFileDialog
        x.Title = _chooseImgFileTitle
        x.Filter = _chooseImgFileFilter
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then
            If IO.File.Exists(x.FileName) Then BackgroundImg = x.FileName

            If MessageBox.Show(BackgroundImg, _isThisPathTrue, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.No Then
                MessageBox.Show(_pleaseTryAgain, _error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                BackgroundImg = String.Empty
            End If
        End If
        x.Dispose()
    End Sub

    Private Sub RadShowOption1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadShowOption1.CheckedChanged
        NumOpic.Enabled = RadShowOption1.Checked
    End Sub

    Private Sub RadShowOption2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadShowOption2.CheckedChanged
        NumOpic.Enabled = Not RadShowOption2.Checked
    End Sub

#End Region

#Region "Lisbox And Menustrip Events ( GroupBox2, Sounds Options ) ..."

    Private Sub AddMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddMenuItem.Click
        Dim x As New OpenFileDialog
        x.Title = _chooseSoundFileTitle
        x.Filter = _chooseSoundFileFilter
        x.Multiselect = True
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then
            Lst.AddRange(x.FileNames)
            ListBox1.Items.AddRange(x.SafeFileNames)
            x.Dispose()
        End If
    End Sub

    Private Sub DelMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DelMenuItem.Click
        Lst.RemoveAt(ListBox1.SelectedIndex)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub upMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles upMenuItem.Click
        Dim i As Int32 = ListBox1.SelectedIndex
        ListBox1.Items.Insert(i - 1, ListBox1.SelectedItem)
        Lst.Insert(i - 1, ListBox1.SelectedItem)
        ListBox1.Items.RemoveAt(i + 1)
        Lst.RemoveAt(i + 1)
    End Sub

    Private Sub downMenuIteam_Click(sender As System.Object, e As System.EventArgs) Handles downMenuIteam.Click
        Dim i As Int32 = ListBox1.SelectedIndex
        ListBox1.Items.Insert(i + 2, ListBox1.SelectedItem)
        Lst.Insert(i + 2, ListBox1.SelectedItem)
        ListBox1.Items.RemoveAt(i)
        Lst.RemoveAt(i)
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBox1.SelectedIndex = 0 Then
            upMenuItem.Enabled = False
            downMenuIteam.Enabled = True
        ElseIf ListBox1.SelectedIndex + 1 = ListBox1.Items.Count Then
            upMenuItem.Enabled = True
            downMenuIteam.Enabled = False
        Else
            upMenuItem.Enabled = True
            downMenuIteam.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show(_areYouSure, _warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes Then
            For i = Lst.Count - 1 To 0 Step -1
                For n = Lst.Count - 1 To 0 Step -1
                    If Lst(n) = Lst(i) And n <> i Then
                        Lst.RemoveAt(n)
                        ListBox1.Items.RemoveAt(n)
                        Exit For
                    End If
                    Application.DoEvents()
                Next
            Next
        End If
    End Sub

#End Region

#Region "The Main Three Buttons Code ..."

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveConf.Click
        Try

            '// Check For Anything illegal ...
            If MessageBox.Show(_sureToSaveNewConf, _warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.No Then Exit Sub
            If ChkText.Checked = False And ChkSoundRun.Checked = False Then
                MessageBox.Show(_pleaseChooseAnOption, _error, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            ElseIf RadBackgroundPicture.Checked AndAlso IO.File.Exists(BackgroundImg) = False AndAlso IO.File.Exists(_BackgroundPicPath) = False Then
                MessageBox.Show(_backgroundImgNotExist, _error, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            ElseIf AlthkerStr.Trim = String.Empty AndAlso IO.File.Exists(_TxtPath) = False Then
                MessageBox.Show(_chooseTextFileAgain, _error, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            ElseIf ChkSoundRun.Checked AndAlso ListBox1.Items.Count = 0 Then
                MessageBox.Show(_addSomeSounds, _error, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If

            '// Enable And Disable ...
            _TextShow = ChkText.Checked
            _SoundVoice = ChkSoundRun.Checked

            '// Save Texts Data ...
            If ChkText.Checked Then
                If AlthkerStr.Trim = String.Empty Then
                    MessageBox.Show(_oldTextIsOk, _note, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                End If

                '// Save The Img
                If RadBackgroundPicture.Checked And IO.File.Exists(BackgroundImg) Then
                    IO.File.Copy(BackgroundImg, _BackgroundPicPath, True)
                End If

                '// Get Texts
                If AlthkerStr.Trim <> String.Empty Then
                    Dim lins As String() = Split(AlthkerStr, splitSymbol)
                    Dim FinalStr As String = String.Empty
                    For Each X As String In lins
                        If X.Trim <> String.Empty Then
                            FinalStr += X.Trim + splitSymbol
                        End If
                    Next
                    My.Computer.FileSystem.WriteAllText(_TxtPath, Mid(FinalStr, 1, FinalStr.Length - 3), False)
                End If

                If RadManyColorsFont.Checked Then _FontColorType = FontColorShowingType.manyColors Else _FontColorType = FontColorShowingType.specificColor
                _FontType = TxtFontSample.Font
                _FontColor = TxtFontSample.ForeColor

                If RadBackgroundColor.Checked Then
                    _BackgroundType = backgroundShowingType.color
                    Try
                        IO.File.Delete(_BackgroundPicPath)
                    Catch
                    End Try
                Else
                    _BackgroundType = backgroundShowingType.picture
                End If
                _BackgroundColor = TxtFontSample.BackColor

                _TextTime = NumTimeEveryText.Value
                _StopTime = NumTimeStop.Value

                If RadShowOption1.Checked Then _ShowType = showingType.UP_DOWN Else _ShowType = showingType.SHOW_HIDE
                _Opacity = NumOpic.Value
            Else
                Try
                    IO.File.Delete(_TxtPath)
                    IO.File.Delete(_BackgroundPicPath)
                Catch
                End Try
            End If


            '// Save Sounds Data ...
            If ChkSoundRun.Checked Then
                'Save Sound Files Locations 
                My.Computer.FileSystem.WriteAllText(_SoundPath, Join(Lst.ToArray, vbCrLf), False)
                _VoiceTime = NumSoundTime.Value
            Else
                Try
                    IO.File.Delete(_SoundPath)
                Catch
                End Try
            End If

            MessageBox.Show(_doneSuccessfully, _note, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Call Form1.SetUpThings()
            Me.Close()
        Catch
            MessageBox.Show(_errorDuringSaving, _error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOriginalConf_Click(sender As System.Object, e As System.EventArgs) Handles btnOriginalConf.Click
        Try
            ClearAllValues()
            MessageBox.Show(_confReset, _note, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Form1.NotifyIcon1.Visible = False
            Form1.NotifyIcon1.Dispose()
            Application.Restart()
        Catch
            MessageBox.Show(_errorDuringSaving, _error, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub btnStartup_Click(sender As Object, e As EventArgs) Handles btnStartup.Click
        Dim Exist As String
        Dim x As Microsoft.Win32.RegistryKey
        x = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        If x.GetValue(My.Application.Info.ProductName, "NotExist") <> ("""" + Application.ExecutablePath + """") Then
            Exist = _notInStartup
        Else
            Exist = _inStartup
        End If
        If MessageBox.Show(Exist + vbCrLf + vbCrLf + _changeStartupOpt, "Startup", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            If Exist = _notInStartup Then
                Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", My.Application.Info.ProductName, """" + Application.ExecutablePath + """")
            Else
                x.DeleteValue(My.Application.Info.ProductName, False)
            End If
        End If
        x.Close()
    End Sub

#End Region


End Class