Public Class plexusbase

    Dim drag As Boolean

    Dim mousex As Integer

    Dim mousey As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        drag = True

        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If drag Then

            Me.Top = Windows.Forms.Cursor.Position.Y - mousey

            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        drag = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        My.Computer.FileSystem.WriteAllText("C:\PLEXUS\libs\install.bat", My.Computer.FileSystem.ReadAllText("C:\PLEXUS\libs\install.txt").Replace("Unnamed", TextBox1.Text), False)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        System.Diagnostics.Process.Start("C:\PLEXUS\libs\gen.bat") ' hides files
        System.Diagnostics.Process.Start("C:\PLEXUS\libs\install.bat") ' installs files
        System.Diagnostics.Process.Start("C:\PLEXUS\Loader.exe") ' runs the hack for the first time

    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click

        Me.Close()

    End Sub

    Private Sub minibtn_Click(sender As Object, e As EventArgs) Handles minibtn.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class
