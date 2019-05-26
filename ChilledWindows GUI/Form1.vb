Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Okay!")
        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start("helper.exe", "")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Too bad!")
        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start("helper.exe", "")
        Me.Close()
    End Sub
End Class
