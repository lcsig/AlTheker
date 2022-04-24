Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            MessageBox.Show("The Program Is Running Already ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If MessageBox.Show("Unhandled Exception ..." + vbCrLf + vbCrLf + e.Exception.Message, "Un::Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = DialogResult.Yes Then
                End
            End If
        End Sub

    End Class

End Namespace

