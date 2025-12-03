Public Class Form1

    Dim juego As CTresEnRalla

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) _
    Handles box00.Click, box01.Click, box02.Click,
            box10.Click, box11.Click, box12.Click,
            box20.Click, box21.Click, box22.Click

        If juego.Equals(Nothing) Then
            Exit Sub
        End If

        Dim pb As PictureBox = CType(sender, PictureBox) ' Recuperar el picture 

        Dim partes() As String = pb.Tag.ToString().Split(","c) ' Opener la posición correspondiente

        Dim col As Integer = Integer.Parse(partes(0))
        Dim row As Integer = Integer.Parse(partes(1))

        juego.SetMove(col, row)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub

    Private Sub checkOnePlayer_CheckedChanged(sender As Object, e As EventArgs) Handles checkOnePlayer.CheckedChanged
        If checkOnePlayer.Checked Then
            checkBeSecond.Enabled = True
        Else
            checkBeSecond.Enabled = False
            checkBeSecond.Checked = False
        End If
    End Sub
End Class
