Public Class Form1
    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Close()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingPic_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingPic_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingPic_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseUp
        draggable = False
    End Sub

    Private Sub Selectfile_Click(sender As Object, e As EventArgs) Handles Selectfile.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Title = "Choose Program"
            .FileName = ""
            .Filter = "All Files|*.*"

        End With
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim icon As Icon = Icon.ExtractAssociatedIcon(dlg.FileName)
            icoPic.BackgroundImage = icon.ToBitmap
            icoPic.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub Saveico_Click(sender As Object, e As EventArgs) Handles Saveico.Click
        Dim dlg As New SaveFileDialog
        With dlg
            .Title = "Save Location"
            .FileName = "icon"
            .Filter = "Ico|*.ico"
        End With
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            icoPic.BackgroundImage.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Icon)
        End If
    End Sub
End Class