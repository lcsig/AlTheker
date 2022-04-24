<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5Sound = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6TextColors = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunningStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ايقافلمدةمعينةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stop5Min = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stop10Min = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stop15Min = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stop30Min = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stop60Min = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RestartProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'Timer3
        '
        '
        'Timer4
        '
        Me.Timer4.Interval = 30
        '
        'Timer5Sound
        '
        '
        'Timer6TextColors
        '
        Me.Timer6TextColors.Interval = 750
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "تم تشغيل برنامج الذكر"
        Me.NotifyIcon1.BalloonTipTitle = "أذكر الله يذكرك"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "برنامج الذكر"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunningStatusToolStripMenuItem, Me.ProgramSettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.RestartProgramToolStripMenuItem, Me.ExitProgramToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 98)
        '
        'RunningStatusToolStripMenuItem
        '
        Me.RunningStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunProgramToolStripMenuItem, Me.StopProgramToolStripMenuItem, Me.ايقافلمدةمعينةToolStripMenuItem})
        Me.RunningStatusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RunningStatusToolStripMenuItem.Image = Global.AlTheker.My.Resources.Resources.Run
        Me.RunningStatusToolStripMenuItem.Name = "RunningStatusToolStripMenuItem"
        Me.RunningStatusToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RunningStatusToolStripMenuItem.Text = "وضع التشغيل"
        '
        'RunProgramToolStripMenuItem
        '
        Me.RunProgramToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.RunProgramToolStripMenuItem.Image = Global.AlTheker.My.Resources.Resources.Play
        Me.RunProgramToolStripMenuItem.Name = "RunProgramToolStripMenuItem"
        Me.RunProgramToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RunProgramToolStripMenuItem.Text = "تشغيل البرنامج"
        '
        'StopProgramToolStripMenuItem
        '
        Me.StopProgramToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.StopProgramToolStripMenuItem.Image = Global.AlTheker.My.Resources.Resources._Stop
        Me.StopProgramToolStripMenuItem.Name = "StopProgramToolStripMenuItem"
        Me.StopProgramToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.StopProgramToolStripMenuItem.Text = "ايقاف البرنامج"
        '
        'ايقافلمدةمعينةToolStripMenuItem
        '
        Me.ايقافلمدةمعينةToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ايقافلمدةمعينةToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Stop5Min, Me.Stop10Min, Me.Stop15Min, Me.Stop30Min, Me.Stop60Min})
        Me.ايقافلمدةمعينةToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.ايقافلمدةمعينةToolStripMenuItem.Image = Global.AlTheker.My.Resources.Resources.Time
        Me.ايقافلمدةمعينةToolStripMenuItem.Name = "ايقافلمدةمعينةToolStripMenuItem"
        Me.ايقافلمدةمعينةToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ايقافلمدةمعينةToolStripMenuItem.Text = "ايقاف لمدة معينة"
        '
        'Stop5Min
        '
        Me.Stop5Min.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stop5Min.Name = "Stop5Min"
        Me.Stop5Min.Size = New System.Drawing.Size(128, 22)
        Me.Stop5Min.Text = "5 دقائق"
        '
        'Stop10Min
        '
        Me.Stop10Min.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stop10Min.Name = "Stop10Min"
        Me.Stop10Min.Size = New System.Drawing.Size(128, 22)
        Me.Stop10Min.Text = "10 دقائق"
        '
        'Stop15Min
        '
        Me.Stop15Min.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Stop15Min.Name = "Stop15Min"
        Me.Stop15Min.Size = New System.Drawing.Size(128, 22)
        Me.Stop15Min.Text = "15 دقيقة"
        '
        'Stop30Min
        '
        Me.Stop30Min.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Stop30Min.Name = "Stop30Min"
        Me.Stop30Min.Size = New System.Drawing.Size(128, 22)
        Me.Stop30Min.Text = "نصف ساعة"
        '
        'Stop60Min
        '
        Me.Stop60Min.ForeColor = System.Drawing.Color.Red
        Me.Stop60Min.Name = "Stop60Min"
        Me.Stop60Min.Size = New System.Drawing.Size(128, 22)
        Me.Stop60Min.Text = "ساعة واحدة"
        '
        'ProgramSettingsToolStripMenuItem
        '
        Me.ProgramSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ProgramSettingsToolStripMenuItem.Image = Global.AlTheker.My.Resources.Resources.Setting
        Me.ProgramSettingsToolStripMenuItem.Name = "ProgramSettingsToolStripMenuItem"
        Me.ProgramSettingsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ProgramSettingsToolStripMenuItem.Text = "الإعدادات"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'RestartProgramToolStripMenuItem
        '
        Me.RestartProgramToolStripMenuItem.ForeColor = System.Drawing.Color.Fuchsia
        Me.RestartProgramToolStripMenuItem.Image = Global.AlTheker.My.Resources.Resources.Restart
        Me.RestartProgramToolStripMenuItem.Name = "RestartProgramToolStripMenuItem"
        Me.RestartProgramToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RestartProgramToolStripMenuItem.Text = "إعادة تشغيل البرنامج"
        '
        'ExitProgramToolStripMenuItem
        '
        Me.ExitProgramToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitProgramToolStripMenuItem.Image = Global.AlTheker.My.Resources.Resources._Exit
        Me.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem"
        Me.ExitProgramToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExitProgramToolStripMenuItem.Text = "الخروج من البرنامج"
        '
        'StopTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 304)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5Sound As System.Windows.Forms.Timer
    Friend WithEvents Timer6TextColors As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunningStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ايقافلمدةمعينةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Stop5Min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Stop10Min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Stop15Min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Stop30Min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Stop60Min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StopTimer As System.Windows.Forms.Timer

End Class
