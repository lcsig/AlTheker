<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnChooseText = New AlTheker.clsButtonBlue()
        Me.GrpShowOptions = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumOpic = New System.Windows.Forms.NumericUpDown()
        Me.RadShowOption2 = New System.Windows.Forms.RadioButton()
        Me.RadShowOption1 = New System.Windows.Forms.RadioButton()
        Me.GrpTime = New System.Windows.Forms.GroupBox()
        Me.NumTimeStop = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumTimeEveryText = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpFontAndType = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnBackgroundPicture = New System.Windows.Forms.Button()
        Me.RadBackgroundPicture = New System.Windows.Forms.RadioButton()
        Me.BtnBackgroundColor = New System.Windows.Forms.Button()
        Me.RadBackgroundColor = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnFontColor = New System.Windows.Forms.Button()
        Me.RadFontColor = New System.Windows.Forms.RadioButton()
        Me.RadManyColorsFont = New System.Windows.Forms.RadioButton()
        Me.BtnFontType = New System.Windows.Forms.Button()
        Me.TxtFontSample = New System.Windows.Forms.TextBox()
        Me.TxtFileText = New System.Windows.Forms.TextBox()
        Me.ChkText = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumSoundTime = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.upMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.downMenuIteam = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChkSoundRun = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ClsNeoBuxTheme1 = New AlTheker.clsNeoBuxTheme()
        Me.btnStartup = New AlTheker.clsButtonBlue()
        Me.ClsControlMenu1 = New AlTheker.clsControlMenu()
        Me.btnSaveConf = New AlTheker.clsButtonOrange()
        Me.btnOriginalConf = New AlTheker.clsButtonGreen()
        Me.GroupBox1.SuspendLayout()
        Me.GrpShowOptions.SuspendLayout()
        CType(Me.NumOpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTime.SuspendLayout()
        CType(Me.NumTimeStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTimeEveryText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFontAndType.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumSoundTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ClsNeoBuxTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnChooseText)
        Me.GroupBox1.Controls.Add(Me.GrpShowOptions)
        Me.GroupBox1.Controls.Add(Me.GrpTime)
        Me.GroupBox1.Controls.Add(Me.GrpFontAndType)
        Me.GroupBox1.Controls.Add(Me.TxtFileText)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(7, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اظهار النصوص كل فترة"
        '
        'BtnChooseText
        '
        Me.BtnChooseText.Customization = "9fX1/6mpqf8="
        Me.BtnChooseText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChooseText.Image = Nothing
        Me.BtnChooseText.Location = New System.Drawing.Point(224, 41)
        Me.BtnChooseText.Name = "BtnChooseText"
        Me.BtnChooseText.NoRounding = False
        Me.BtnChooseText.Size = New System.Drawing.Size(168, 23)
        Me.BtnChooseText.TabIndex = 8
        Me.BtnChooseText.Text = "اختيار الملف النصي للاذكار"
        Me.BtnChooseText.Transparent = False
        '
        'GrpShowOptions
        '
        Me.GrpShowOptions.Controls.Add(Me.Label3)
        Me.GrpShowOptions.Controls.Add(Me.NumOpic)
        Me.GrpShowOptions.Controls.Add(Me.RadShowOption2)
        Me.GrpShowOptions.Controls.Add(Me.RadShowOption1)
        Me.GrpShowOptions.ForeColor = System.Drawing.Color.Blue
        Me.GrpShowOptions.Location = New System.Drawing.Point(7, 165)
        Me.GrpShowOptions.Name = "GrpShowOptions"
        Me.GrpShowOptions.Size = New System.Drawing.Size(324, 92)
        Me.GrpShowOptions.TabIndex = 1
        Me.GrpShowOptions.TabStop = False
        Me.GrpShowOptions.Text = "الحركة الخاصة بالنصوص"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(9, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "الشفافية :"
        '
        'NumOpic
        '
        Me.NumOpic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumOpic.Location = New System.Drawing.Point(9, 26)
        Me.NumOpic.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NumOpic.Name = "NumOpic"
        Me.NumOpic.Size = New System.Drawing.Size(56, 21)
        Me.NumOpic.TabIndex = 4
        Me.NumOpic.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'RadShowOption2
        '
        Me.RadShowOption2.AutoSize = True
        Me.RadShowOption2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadShowOption2.Location = New System.Drawing.Point(52, 53)
        Me.RadShowOption2.Name = "RadShowOption2"
        Me.RadShowOption2.Size = New System.Drawing.Size(262, 30)
        Me.RadShowOption2.TabIndex = 2
        Me.RadShowOption2.Text = "الحركة الثانية : اظهار النص تدريجيا " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "باستخدام الشفافية ثم التوقف للقراءة واخفائه" & _
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadShowOption2.UseVisualStyleBackColor = True
        '
        'RadShowOption1
        '
        Me.RadShowOption1.AutoSize = True
        Me.RadShowOption1.Checked = True
        Me.RadShowOption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadShowOption1.Location = New System.Drawing.Point(101, 17)
        Me.RadShowOption1.Name = "RadShowOption1"
        Me.RadShowOption1.Size = New System.Drawing.Size(213, 30)
        Me.RadShowOption1.TabIndex = 2
        Me.RadShowOption1.TabStop = True
        Me.RadShowOption1.Text = "الحركة الاولى : تحريك النص للاعلى " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ثم التوقف للقراءة ثم تحريكه للاسفل" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadShowOption1.UseVisualStyleBackColor = True
        '
        'GrpTime
        '
        Me.GrpTime.Controls.Add(Me.NumTimeStop)
        Me.GrpTime.Controls.Add(Me.Label2)
        Me.GrpTime.Controls.Add(Me.NumTimeEveryText)
        Me.GrpTime.Controls.Add(Me.Label1)
        Me.GrpTime.ForeColor = System.Drawing.Color.Blue
        Me.GrpTime.Location = New System.Drawing.Point(10, 67)
        Me.GrpTime.Name = "GrpTime"
        Me.GrpTime.Size = New System.Drawing.Size(328, 92)
        Me.GrpTime.TabIndex = 6
        Me.GrpTime.TabStop = False
        Me.GrpTime.Text = "التوقيت"
        '
        'NumTimeStop
        '
        Me.NumTimeStop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumTimeStop.Location = New System.Drawing.Point(7, 59)
        Me.NumTimeStop.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumTimeStop.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumTimeStop.Name = "NumTimeStop"
        Me.NumTimeStop.Size = New System.Drawing.Size(71, 21)
        Me.NumTimeStop.TabIndex = 3
        Me.NumTimeStop.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(80, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "وقــت التوقــف لقراءة الشريحة بالثــــــواني :"
        '
        'NumTimeEveryText
        '
        Me.NumTimeEveryText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumTimeEveryText.Location = New System.Drawing.Point(7, 19)
        Me.NumTimeEveryText.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumTimeEveryText.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumTimeEveryText.Name = "NumTimeEveryText"
        Me.NumTimeEveryText.Size = New System.Drawing.Size(71, 21)
        Me.NumTimeEveryText.TabIndex = 1
        Me.NumTimeEveryText.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الوقت بين كل ظهور واخر للنصوص بالدقائـق :"
        '
        'GrpFontAndType
        '
        Me.GrpFontAndType.Controls.Add(Me.Panel2)
        Me.GrpFontAndType.Controls.Add(Me.Panel1)
        Me.GrpFontAndType.Controls.Add(Me.BtnFontType)
        Me.GrpFontAndType.Controls.Add(Me.TxtFontSample)
        Me.GrpFontAndType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GrpFontAndType.Location = New System.Drawing.Point(338, 67)
        Me.GrpFontAndType.Name = "GrpFontAndType"
        Me.GrpFontAndType.Size = New System.Drawing.Size(247, 145)
        Me.GrpFontAndType.TabIndex = 1
        Me.GrpFontAndType.TabStop = False
        Me.GrpFontAndType.Text = "لون الخط ونوعه"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnBackgroundPicture)
        Me.Panel2.Controls.Add(Me.RadBackgroundPicture)
        Me.Panel2.Controls.Add(Me.BtnBackgroundColor)
        Me.Panel2.Controls.Add(Me.RadBackgroundColor)
        Me.Panel2.Location = New System.Drawing.Point(105, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(140, 58)
        Me.Panel2.TabIndex = 12
        '
        'BtnBackgroundPicture
        '
        Me.BtnBackgroundPicture.Enabled = False
        Me.BtnBackgroundPicture.ForeColor = System.Drawing.Color.Red
        Me.BtnBackgroundPicture.Location = New System.Drawing.Point(5, 34)
        Me.BtnBackgroundPicture.Name = "BtnBackgroundPicture"
        Me.BtnBackgroundPicture.Size = New System.Drawing.Size(36, 23)
        Me.BtnBackgroundPicture.TabIndex = 10
        Me.BtnBackgroundPicture.Text = "..."
        Me.BtnBackgroundPicture.UseVisualStyleBackColor = True
        '
        'RadBackgroundPicture
        '
        Me.RadBackgroundPicture.AutoSize = True
        Me.RadBackgroundPicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadBackgroundPicture.Location = New System.Drawing.Point(41, 37)
        Me.RadBackgroundPicture.Name = "RadBackgroundPicture"
        Me.RadBackgroundPicture.Size = New System.Drawing.Size(92, 17)
        Me.RadBackgroundPicture.TabIndex = 9
        Me.RadBackgroundPicture.TabStop = True
        Me.RadBackgroundPicture.Text = "صورة للخلفية"
        Me.RadBackgroundPicture.UseVisualStyleBackColor = True
        '
        'BtnBackgroundColor
        '
        Me.BtnBackgroundColor.ForeColor = System.Drawing.Color.Red
        Me.BtnBackgroundColor.Location = New System.Drawing.Point(5, 4)
        Me.BtnBackgroundColor.Name = "BtnBackgroundColor"
        Me.BtnBackgroundColor.Size = New System.Drawing.Size(36, 23)
        Me.BtnBackgroundColor.TabIndex = 8
        Me.BtnBackgroundColor.Text = "..."
        Me.BtnBackgroundColor.UseVisualStyleBackColor = True
        '
        'RadBackgroundColor
        '
        Me.RadBackgroundColor.AutoSize = True
        Me.RadBackgroundColor.Checked = True
        Me.RadBackgroundColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadBackgroundColor.Location = New System.Drawing.Point(49, 7)
        Me.RadBackgroundColor.Name = "RadBackgroundColor"
        Me.RadBackgroundColor.Size = New System.Drawing.Size(84, 17)
        Me.RadBackgroundColor.TabIndex = 7
        Me.RadBackgroundColor.TabStop = True
        Me.RadBackgroundColor.Text = "لون الخلفية"
        Me.RadBackgroundColor.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnFontColor)
        Me.Panel1.Controls.Add(Me.RadFontColor)
        Me.Panel1.Controls.Add(Me.RadManyColorsFont)
        Me.Panel1.Location = New System.Drawing.Point(107, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 63)
        Me.Panel1.TabIndex = 11
        '
        'BtnFontColor
        '
        Me.BtnFontColor.Enabled = False
        Me.BtnFontColor.ForeColor = System.Drawing.Color.Red
        Me.BtnFontColor.Location = New System.Drawing.Point(3, 39)
        Me.BtnFontColor.Name = "BtnFontColor"
        Me.BtnFontColor.Size = New System.Drawing.Size(36, 23)
        Me.BtnFontColor.TabIndex = 1
        Me.BtnFontColor.Text = "..."
        Me.BtnFontColor.UseVisualStyleBackColor = True
        '
        'RadFontColor
        '
        Me.RadFontColor.AutoSize = True
        Me.RadFontColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadFontColor.Location = New System.Drawing.Point(56, 39)
        Me.RadFontColor.Name = "RadFontColor"
        Me.RadFontColor.Size = New System.Drawing.Size(75, 17)
        Me.RadFontColor.TabIndex = 1
        Me.RadFontColor.Text = "لون النص"
        Me.RadFontColor.UseVisualStyleBackColor = True
        '
        'RadManyColorsFont
        '
        Me.RadManyColorsFont.AutoSize = True
        Me.RadManyColorsFont.Checked = True
        Me.RadManyColorsFont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadManyColorsFont.Location = New System.Drawing.Point(41, 3)
        Me.RadManyColorsFont.Name = "RadManyColorsFont"
        Me.RadManyColorsFont.Size = New System.Drawing.Size(90, 17)
        Me.RadManyColorsFont.TabIndex = 0
        Me.RadManyColorsFont.TabStop = True
        Me.RadManyColorsFont.Text = "الوان متعددة"
        Me.RadManyColorsFont.UseVisualStyleBackColor = True
        '
        'BtnFontType
        '
        Me.BtnFontType.ForeColor = System.Drawing.Color.Red
        Me.BtnFontType.Location = New System.Drawing.Point(7, 86)
        Me.BtnFontType.Name = "BtnFontType"
        Me.BtnFontType.Size = New System.Drawing.Size(101, 23)
        Me.BtnFontType.TabIndex = 4
        Me.BtnFontType.Text = "اختيار نوع الخط"
        Me.BtnFontType.UseVisualStyleBackColor = True
        '
        'TxtFontSample
        '
        Me.TxtFontSample.BackColor = System.Drawing.Color.SkyBlue
        Me.TxtFontSample.Location = New System.Drawing.Point(6, 18)
        Me.TxtFontSample.Multiline = True
        Me.TxtFontSample.Name = "TxtFontSample"
        Me.TxtFontSample.Size = New System.Drawing.Size(101, 64)
        Me.TxtFontSample.TabIndex = 2
        Me.TxtFontSample.Text = "عينة ، اختبار"
        Me.TxtFontSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFileText
        '
        Me.TxtFileText.BackColor = System.Drawing.Color.Black
        Me.TxtFileText.ForeColor = System.Drawing.Color.Lime
        Me.TxtFileText.Location = New System.Drawing.Point(7, 19)
        Me.TxtFileText.Name = "TxtFileText"
        Me.TxtFileText.ReadOnly = True
        Me.TxtFileText.Size = New System.Drawing.Size(574, 21)
        Me.TxtFileText.TabIndex = 2
        Me.TxtFileText.Text = "ضع النصوص في ملف txt افصل بين كل نص واخر بالرمز @@@ لكي تظهر النصوص المفصول بينها" & _
    " على التوالي"
        Me.TxtFileText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkText
        '
        Me.ChkText.AutoSize = True
        Me.ChkText.Location = New System.Drawing.Point(600, 49)
        Me.ChkText.Name = "ChkText"
        Me.ChkText.Size = New System.Drawing.Size(15, 14)
        Me.ChkText.TabIndex = 1
        Me.ChkText.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NumSoundTime)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(614, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 268)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "تشغيل أصوات الأذكار"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 202)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(266, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "ازالة الاصوات المتكررة"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(21, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "اضغط بالزر الايمن على القائمة لمزيد من الخيارات"
        '
        'NumSoundTime
        '
        Me.NumSoundTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumSoundTime.Location = New System.Drawing.Point(9, 241)
        Me.NumSoundTime.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumSoundTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumSoundTime.Name = "NumSoundTime"
        Me.NumSoundTime.Size = New System.Drawing.Size(66, 21)
        Me.NumSoundTime.TabIndex = 5
        Me.NumSoundTime.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(80, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "الوقت بين كل تشغيل واخر بالدقائـق :"
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(268, 147)
        Me.ListBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMenuItem, Me.DelMenuItem, Me.ToolStripSeparator2, Me.upMenuItem, Me.downMenuIteam})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(106, 98)
        '
        'AddMenuItem
        '
        Me.AddMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddMenuItem.Image = Global.AlTheker.My.Resources.Resources.Add
        Me.AddMenuItem.Name = "AddMenuItem"
        Me.AddMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.AddMenuItem.Text = "إضافة"
        '
        'DelMenuItem
        '
        Me.DelMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DelMenuItem.Image = Global.AlTheker.My.Resources.Resources.Del
        Me.DelMenuItem.Name = "DelMenuItem"
        Me.DelMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.DelMenuItem.Text = "حذف"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(102, 6)
        '
        'upMenuItem
        '
        Me.upMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.upMenuItem.Image = Global.AlTheker.My.Resources.Resources.Up
        Me.upMenuItem.Name = "upMenuItem"
        Me.upMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.upMenuItem.Text = "للأعلى"
        '
        'downMenuIteam
        '
        Me.downMenuIteam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.downMenuIteam.Image = Global.AlTheker.My.Resources.Resources.Dwn
        Me.downMenuIteam.Name = "downMenuIteam"
        Me.downMenuIteam.Size = New System.Drawing.Size(105, 22)
        Me.downMenuIteam.Text = "للأسفل"
        '
        'ChkSoundRun
        '
        Me.ChkSoundRun.AutoSize = True
        Me.ChkSoundRun.Location = New System.Drawing.Point(893, 49)
        Me.ChkSoundRun.Name = "ChkSoundRun"
        Me.ChkSoundRun.Size = New System.Drawing.Size(15, 14)
        Me.ChkSoundRun.TabIndex = 0
        Me.ChkSoundRun.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 750
        '
        'ClsNeoBuxTheme1
        '
        Me.ClsNeoBuxTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClsNeoBuxTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClsNeoBuxTheme1.Controls.Add(Me.btnStartup)
        Me.ClsNeoBuxTheme1.Controls.Add(Me.ClsControlMenu1)
        Me.ClsNeoBuxTheme1.Controls.Add(Me.btnSaveConf)
        Me.ClsNeoBuxTheme1.Controls.Add(Me.btnOriginalConf)
        Me.ClsNeoBuxTheme1.Customization = "AAAA/w=="
        Me.ClsNeoBuxTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClsNeoBuxTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ClsNeoBuxTheme1.Image = Nothing
        Me.ClsNeoBuxTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ClsNeoBuxTheme1.Movable = True
        Me.ClsNeoBuxTheme1.Name = "ClsNeoBuxTheme1"
        Me.ClsNeoBuxTheme1.NoRounding = False
        Me.ClsNeoBuxTheme1.Sizable = True
        Me.ClsNeoBuxTheme1.Size = New System.Drawing.Size(909, 360)
        Me.ClsNeoBuxTheme1.SmartBounds = True
        Me.ClsNeoBuxTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ClsNeoBuxTheme1.TabIndex = 9
        Me.ClsNeoBuxTheme1.Text = "ClsNeoBuxTheme1"
        Me.ClsNeoBuxTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClsNeoBuxTheme1.Transparent = False
        '
        'btnStartup
        '
        Me.btnStartup.Customization = "9fX1/6mpqf8="
        Me.btnStartup.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnStartup.Image = Nothing
        Me.btnStartup.Location = New System.Drawing.Point(594, 323)
        Me.btnStartup.Name = "btnStartup"
        Me.btnStartup.NoRounding = False
        Me.btnStartup.Size = New System.Drawing.Size(303, 28)
        Me.btnStartup.TabIndex = 11
        Me.btnStartup.Text = "وضع التشغيل التلقائي"
        Me.btnStartup.Transparent = False
        '
        'ClsControlMenu1
        '
        Me.ClsControlMenu1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsControlMenu1.Customization = "8u/v/////wD///8A"
        Me.ClsControlMenu1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ClsControlMenu1.Image = Nothing
        Me.ClsControlMenu1.Location = New System.Drawing.Point(826, 9)
        Me.ClsControlMenu1.Name = "ClsControlMenu1"
        Me.ClsControlMenu1.NoRounding = False
        Me.ClsControlMenu1.Size = New System.Drawing.Size(71, 19)
        Me.ClsControlMenu1.TabIndex = 0
        Me.ClsControlMenu1.Text = "ClsControlMenu1"
        Me.ClsControlMenu1.Transparent = False
        '
        'btnSaveConf
        '
        Me.btnSaveConf.Customization = "9fX1/6mpqf8="
        Me.btnSaveConf.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveConf.Image = Nothing
        Me.btnSaveConf.Location = New System.Drawing.Point(319, 323)
        Me.btnSaveConf.Name = "btnSaveConf"
        Me.btnSaveConf.NoRounding = False
        Me.btnSaveConf.Size = New System.Drawing.Size(269, 28)
        Me.btnSaveConf.TabIndex = 8
        Me.btnSaveConf.Text = "حفظ الاعدادات"
        Me.btnSaveConf.Transparent = False
        '
        'btnOriginalConf
        '
        Me.btnOriginalConf.Customization = "9fX1/6mpqf8="
        Me.btnOriginalConf.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.btnOriginalConf.Image = Nothing
        Me.btnOriginalConf.Location = New System.Drawing.Point(12, 323)
        Me.btnOriginalConf.Name = "btnOriginalConf"
        Me.btnOriginalConf.NoRounding = False
        Me.btnOriginalConf.Size = New System.Drawing.Size(303, 28)
        Me.btnOriginalConf.TabIndex = 10
        Me.btnOriginalConf.Text = "إعادة ضبط الاعدادات الى الوضع الاصلي"
        Me.btnOriginalConf.Transparent = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 360)
        Me.Controls.Add(Me.ChkSoundRun)
        Me.Controls.Add(Me.ChkText)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClsNeoBuxTheme1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "برنامج الذكر - الاصدار الخامس --- الرجاء تعيين هذه الاعدادات واختيارها بدقة "
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpShowOptions.ResumeLayout(False)
        Me.GrpShowOptions.PerformLayout()
        CType(Me.NumOpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTime.ResumeLayout(False)
        Me.GrpTime.PerformLayout()
        CType(Me.NumTimeStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTimeEveryText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFontAndType.ResumeLayout(False)
        Me.GrpFontAndType.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumSoundTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ClsNeoBuxTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpTime As System.Windows.Forms.GroupBox
    Friend WithEvents NumTimeStop As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumTimeEveryText As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpFontAndType As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFontType As System.Windows.Forms.Button
    Friend WithEvents BtnFontColor As System.Windows.Forms.Button
    Friend WithEvents TxtFontSample As System.Windows.Forms.TextBox
    Friend WithEvents RadFontColor As System.Windows.Forms.RadioButton
    Friend WithEvents RadManyColorsFont As System.Windows.Forms.RadioButton
    Friend WithEvents ChkText As System.Windows.Forms.CheckBox
    Friend WithEvents TxtFileText As System.Windows.Forms.TextBox
    Friend WithEvents GrpShowOptions As System.Windows.Forms.GroupBox
    Friend WithEvents RadShowOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadShowOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumOpic As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NumSoundTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkSoundRun As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents upMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents downMenuIteam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnSaveConf As AlTheker.clsButtonOrange
    Friend WithEvents ClsNeoBuxTheme1 As AlTheker.clsNeoBuxTheme
    Friend WithEvents ClsControlMenu1 As AlTheker.clsControlMenu
    Friend WithEvents BtnChooseText As AlTheker.clsButtonBlue
    Friend WithEvents btnOriginalConf As AlTheker.clsButtonGreen
    Friend WithEvents btnStartup As AlTheker.clsButtonBlue
    Friend WithEvents BtnBackgroundPicture As System.Windows.Forms.Button
    Friend WithEvents RadBackgroundPicture As System.Windows.Forms.RadioButton
    Friend WithEvents BtnBackgroundColor As System.Windows.Forms.Button
    Friend WithEvents RadBackgroundColor As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
