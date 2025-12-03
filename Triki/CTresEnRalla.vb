Public Class CTresEnRalla

    Private _matrix(2, 2) As Integer ' Matriz del juego
    Private _actualPlayer As Integer ' 0 = circulo ( o ) , 1 = equis ( x )

    Private ReadOnly _rnd As New Random()


    Public ReadOnly Property actualPlayer() As Integer
        Get
            Return Me._actualPlayer
        End Get
    End Property

    Public Sub New()
        Me._actualPlayer = 0
        InitMatrix()
    End Sub

    Private Sub InitMatrix()
        For i As Integer = 0 To _matrix.GetUpperBound(0)
            For j As Integer = 0 To _matrix.GetUpperBound(1)
                Me._matrix(i, j) = -1
            Next
        Next
    End Sub

    Public Sub ChangePlayer()
        If actualPlayer() = 0 Then
            Me._actualPlayer = 1
        Else
            Me._actualPlayer = 0
        End If
    End Sub

    Public Sub SetMove(column As Integer, row As Integer)

        If (column < 0 Or column > 2) Or (row < 0 Or row > 2) Then
            Throw New System.IndexOutOfRangeException("Posicón inexistente")
        End If

        Me._matrix(column, row) = actualPlayer()
    End Sub

    Public Sub AutoMove()

        ' Obtener todas las posiciones libres
        Dim libres As New List(Of Point)

        For col As Integer = 0 To _matrix.GetUpperBound(0)
            For row As Integer = 0 To _matrix.GetUpperBound(1)
                If _matrix(col, row) = -1 Then
                    libres.Add(New Point(col, row))
                End If
            Next
        Next

        ' Si no hay movimientos posibles, salir
        If libres.Count = 0 Then Exit Sub

        ' Elegir una posición aleatoria
        Dim elegido As Point = libres(_rnd.Next(libres.Count))

        SetMove(elegido.X, elegido.Y)

    End Sub

    Public Function GetState() As EGameStatus.GameStatusEnum

        ' ---- Horizontales ----
        For row As Integer = 0 To 2
            If _matrix(0, row) <> -1 AndAlso
               _matrix(0, row) = _matrix(1, row) AndAlso
               _matrix(1, row) = _matrix(2, row) Then

                Return If(_matrix(0, row) = 0,
                          EGameStatus.GameStatusEnum.GANA_CIRCULO,
                          EGameStatus.GameStatusEnum.GANA_EQUIS)
            End If
        Next

        ' ---- Verticales ----
        For col As Integer = 0 To 2
            If _matrix(col, 0) <> -1 AndAlso
               _matrix(col, 0) = _matrix(col, 1) AndAlso
               _matrix(col, 1) = _matrix(col, 2) Then

                Return If(_matrix(col, 0) = 0,
                          EGameStatus.GameStatusEnum.GANA_CIRCULO,
                          EGameStatus.GameStatusEnum.GANA_EQUIS)
            End If
        Next

        ' ---- Diagonal principal ----
        If _matrix(0, 0) <> -1 AndAlso
           _matrix(0, 0) = _matrix(1, 1) AndAlso
           _matrix(1, 1) = _matrix(2, 2) Then

            Return If(_matrix(0, 0) = 0,
                      EGameStatus.GameStatusEnum.GANA_CIRCULO,
                      EGameStatus.GameStatusEnum.GANA_EQUIS)
        End If

        ' ---- Diagonal secundaria ----
        If _matrix(2, 0) <> -1 AndAlso
           _matrix(2, 0) = _matrix(1, 1) AndAlso
           _matrix(1, 1) = _matrix(0, 2) Then

            Return If(_matrix(2, 0) = 0,
                      EGameStatus.GameStatusEnum.GANA_CIRCULO,
                      EGameStatus.GameStatusEnum.GANA_EQUIS)
        End If

        ' ---- ¿Quedan casillas libres? ----
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If _matrix(i, j) = -1 Then
                    Return EGameStatus.GameStatusEnum.CONTINUAR
                End If
            Next
        Next

        ' ---- Empate ----
        Return EGameStatus.GameStatusEnum.EMPATE

    End Function



End Class
