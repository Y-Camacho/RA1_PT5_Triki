Public Class Form1

    ' Solo puede haber una instancia del juego
    ' Por lo que cuando no se está jugando es null
    Dim juego As CTresEnRalla

    Dim contraMaquina As Boolean
    Dim turnoMaquina As Boolean

    Dim winCount_O As Integer = 0
    Dim winCount_X As Integer = 0

    Private Sub checkOnePlayer_CheckedChanged(sender As Object, e As EventArgs) Handles checkOnePlayer.CheckedChanged
        If checkOnePlayer.Checked Then      ' Si el "1 jugador" esta seleccionado
            contraMaquina = True            ' Habilita el juego contra la maquina

            checkBeSecond.Enabled = True    ' Habilita la opción de comenzar segundo
        Else
            contraMaquina = False

            checkBeSecond.Enabled = False
            checkBeSecond.Checked = False
        End If
    End Sub

    Private Sub checkBeSecond_CheckedChanged(sender As Object, e As EventArgs) Handles checkBeSecond.CheckedChanged
        If checkBeSecond.Checked Then
            turnoMaquina = True
        Else
            turnoMaquina = False
        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        checkOnePlayer.Enabled = False      ' Cuando inicia el juego se deabilitan los checkbox
        checkBeSecond.Enabled = False

        juego = New CTresEnRalla            ' Se inicializa el juego
        PaintTurn()                         ' Pinta el jugador que tiene el primer turno

        If contraMaquina AndAlso turnoMaquina Then
            MachineMove()                   ' Se hace un primer movimiento automático si se juega contra la máquina
        End If                              ' y esta tiene el primer turno

    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) _
    Handles box00.Click, box01.Click, box02.Click,      ' Un mismo handle para todas las casillas
            box10.Click, box11.Click, box12.Click,
            box20.Click, box21.Click, box22.Click

        If juego Is Nothing Then    ' Si el juego no está inicializado termina la función y no hace nada
            Exit Sub
        End If

        Dim pb As PictureBox = CType(sender, PictureBox) ' Recuperar el picture 

        Dim partes() As String = pb.Tag.ToString().Split(","c) ' Optener la posición correspondiente

        Dim col As Integer = Integer.Parse(partes(0))
        Dim row As Integer = Integer.Parse(partes(1))
        Dim player As Integer = juego.actualPlayer()

        Try                         ' Evita hacer un movimiento en una casilla ya ocupada
            juego.SetMove(col, row)
        Catch ex As Exception
            Exit Sub
        End Try

        PaintPicture(player, pb)    ' Pone la imagen segun el jugador
        juego.ChangePlayer()        ' Cambia el jugador
        PaintTurn()                 ' Pinta el turno del jugador

        DeterminateState()

        If contraMaquina AndAlso juego IsNot Nothing Then
            MachineMove()           ' Solo se ejecuta cuando el check de "1 jugador" esta seleccionado
        End If

    End Sub

    Private Sub DeterminateState()

        Dim state = juego.GetState()

        If state = EGameStatus.GameStatusEnum.EMPATE Then
            MessageBox.Show("Empate")
            FinishGame()
        ElseIf state = EGameStatus.GameStatusEnum.GANA_CIRCULO Then
            MessageBox.Show("Gana circulo")
            winCount_O = winCount_O + 1
            FinishGame()
        ElseIf state = EGameStatus.GameStatusEnum.GANA_EQUIS Then
            MessageBox.Show("Gana equis")
            winCount_X = winCount_X + 1
            FinishGame()
        End If

    End Sub

    Private Sub PrintWinCounts()
        lblCount_o.Text = winCount_O
        lblCount_x.Text = winCount_X
    End Sub

    Private Sub FinishGame()
        checkOnePlayer.Enabled = True       ' Vuelve a habilitar el check "1 jugador"
        If checkOnePlayer.Checked Then      ' El el "1 jugador" está selecionado
            checkBeSecond.Enabled = True    ' - Habilia también el check "comenzar 2do"
        End If

        juego = Nothing                     ' Elimina la instancia actual del juego

        box00.Image = Nothing               ' Vacía todas las imágenes
        box01.Image = Nothing
        box02.Image = Nothing
        box10.Image = Nothing
        box11.Image = Nothing
        box12.Image = Nothing
        box20.Image = Nothing
        box21.Image = Nothing
        box22.Image = Nothing

        lblTurn.Text = ""                   ' Elimina el contenmido del label que indica el turno

        PrintWinCounts()                    ' Imprime los resultados hasta el momento. 

    End Sub

    Private Sub PaintPicture(player As Integer, box As PictureBox)

        If player = 0 Then                  ' Según el jugador pinta la imagen
            box.Image = My.Resources.o_sin_fondo
        Else
            box.Image = My.Resources.x_sin_fondo
        End If

    End Sub

    Private Sub PaintTurn()
        Dim player = juego.actualPlayer()
        If player = 0 Then
            lblTurn.Text = "O"
        Else
            lblTurn.Text = "X"
        End If

    End Sub

    Private Sub MachineMove()

        If juego Is Nothing Then Exit Sub

        ' Guardar el estado antes
        Dim before(2, 2) As Integer
        Array.Copy(juego.Matrix, before, juego.Matrix.Length)

        ' Juega la máquina
        juego.AutoMove()

        ' Detectar qué casilla cambió
        For col As Integer = 0 To 2
            For row As Integer = 0 To 2
                If before(col, row) <> juego.Matrix(col, row) Then
                    Dim pb As PictureBox = GetPictureBox(col, row)
                    If pb IsNot Nothing Then
                        PaintPicture(juego.actualPlayer(), pb)
                    End If
                End If
            Next
        Next

        juego.ChangePlayer()
        PaintTurn()
        DeterminateState()

    End Sub

    ' Función que segun la posición pasada, recorre todos los controles
    ' busca que control contiene una tag con las posiciones correspondiente
    ' y retorna el picturebox.
    Private Function GetPictureBox(col As Integer, row As Integer) As PictureBox
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag IsNot Nothing Then
                Dim partes() As String = ctrl.Tag.ToString().Split(","c)
                If Integer.Parse(partes(0)) = col AndAlso Integer.Parse(partes(1)) = row Then
                    Return CType(ctrl, PictureBox)
                End If
            End If
        Next
        Return Nothing
    End Function

End Class
