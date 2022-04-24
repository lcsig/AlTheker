Public Class player

    Dim first As Boolean = True
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Me.Visible = False
        SetProcessWorkingSetSize(-1, -1, -1)
        If first Then
            Timer1.Interval = 60000
            first = False
        End If
    End Sub

    Private Sub player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(0, 0)
        Me.ShowInTaskbar = False
        Timer1.Enabled = True
    End Sub
End Class