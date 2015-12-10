Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If Me.BackColor() = Color.Maroon Then
            Me.BackColor() = Color.HotPink
        Else
            Me.BackColor() = Color.Maroon
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
