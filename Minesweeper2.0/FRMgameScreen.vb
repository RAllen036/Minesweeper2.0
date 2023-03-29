Public Class FRMgameScreen
    Dim xTot As Integer
    Dim yTot As Integer
    Dim clicks As Integer
    Public boxSize As Size = New Size(40, 40)
    Public boxLoc As Point = New Point(10, 10)
    Public nBombs As Integer
    Dim obList(,) As item
    Dim board(,) As Integer
    Public backC As Color = Color.Blue

    Structure item
        Dim panel As Panel
        Dim label As Label
    End Structure

    Private Sub FRMgameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        xTot = FRMMain.xSize - 1
        yTot = FRMMain.ySize - 1
        nBombs = FRMMain.nBombs

        clicks = 0

        board = createRanBoard()

        innitObjects()

    End Sub

    Public Function getRand(ByVal min, ByVal max)
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(min, max)
    End Function

    Function createRanBoard()

        Dim randX As Integer
        Dim randY As Integer
        Dim tempist(xTot, yTot) As Integer
        Dim counter As Integer = nBombs
        Dim tempX As Integer
        Dim tempY As Integer

        'Puts the bombs in place and puts the numbers in the corerct spot

        Do
            randX = getRand(0, xTot)
            randY = getRand(0, yTot)


            If (tempist(randX, randY) <> 9) Then
                tempist(randX, randY) = 9

                For x = -1 To 1
                    tempX = randX + x
                    For y = -1 To 1
                        tempY = randY + y
                        Try
                            If (tempist(tempX, tempY) <> 9) Then
                                tempist(tempX, tempY) += 1
                            End If
                        Catch ex As Exception
                            Console.Write("Backboard " & tempX & " " & tempY & "doesn't exist")
                        End Try
                    Next
                Next

                counter -= 1
            End If

        Loop Until (counter <= 0)

        Return tempist

    End Function

    Sub innitObjects()
        Dim tempList(xTot, yTot) As item

        For x = 0 To xTot
            For y = 0 To yTot

                Dim ob As Panel = New Panel
                ob.Size = boxSize
                ob.Location = New Point(10 + boxLoc.X + x * boxSize.Width, 10 + boxLoc.Y + y * boxSize.Height)
                ob.BackColor = backC
                ob.BorderStyle = BorderStyle.Fixed3D
                ob.Tag = Str(x + y * (xTot + 1)) + 1

                Dim text As Label = New Label
                text.Text = board(x, y).ToString()
                text.Size = New Size(boxSize.Width * 0.5, boxSize.Height * 0.5)
                text.Location = New Point(ob.Location.X + boxSize.Width * 0.25, ob.Location.Y + boxSize.Height * 0.25)
                text.BackColor = backC
                text.TextAlign = ContentAlignment.MiddleCenter
                text.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                text.Tag = Str(x + y * (xTot + 1)) + 1
                text.Visible = False

                Me.Controls.Add(text)

                AddHandler ob.MouseClick, AddressOf Me.boxClick
                Me.Controls.Add(ob)

                tempList(x, y) = New item With {.panel = ob, .label = text}

            Next
        Next

        obList = tempList

    End Sub

    Sub isGreen(ByVal value As Point)

        For x = -1 To 1
            For y = -1 To 1

                Try
                    If (board(value.X + x, value.Y + y) = 0) And obList(value.X + x, value.Y + y).panel.BackColor = backC Then

                        obList(value.X + x, value.Y + y).label.BackColor = Color.LightGreen
                        obList(value.X + x, value.Y + y).panel.BackColor = Color.LightGreen
                        obList(value.X + x, value.Y + y).label.Visible = True

                        isGreen(New Point(value.X + x, value.Y + y))

                    End If
                Catch ex As Exception

                End Try

            Next
        Next

    End Sub

    Sub boxClick(sender As Object, e As MouseEventArgs)

        Dim leftClick As Boolean

        Dim tagX As Integer
        Dim tagY As Integer

        Dim tag As Integer = sender.tag - 1
        tagX = tag Mod (xTot + 1)
        tagY = tag \ (xTot + 1)

        If MouseButtons.Left = e.Button Then

            obList(tagX, tagY).label.Text = board(tagX, tagY).ToString()

            obList(tagX, tagY).label.Visible = True
            obList(tagX, tagY).label.BringToFront()

            ' Need to make it so that it changes all the 0 around that 0 to visible

            If (board(tagX, tagY) = 0) Then
                isGreen(New Point(tagX, tagY))
            ElseIf (board(tagX, tagY) > 0 And board(tagX, tagY) < 9) Then
                obList(tagX, tagY).label.BackColor = Color.LightBlue
                obList(tagX, tagY).panel.BackColor = Color.LightBlue
            ElseIf (board(tagX, tagY) = 9) Then
                obList(tagX, tagY).label.BackColor = Color.Pink
                obList(tagX, tagY).panel.BackColor = Color.Pink
            End If

            leftClick = True

        Else

            If obList(tagX, tagY).panel.BackColor = Color.Blue Then
                obList(tagX, tagY).panel.BackColor = Color.Yellow
                obList(tagX, tagY).label.BackColor = Color.Yellow
            Else
                obList(tagX, tagY).panel.BackColor = Color.Blue
                obList(tagX, tagY).label.BackColor = Color.Yellow
            End If

            leftClick = False

        End If

        checkPos(tagX, tagY, leftClick)

    End Sub

    Sub checkPos(ByVal x As Integer, ByVal y As Integer, leftClick As Boolean)

        Dim bombsFoundCorrectly As Integer
        Dim winnable As Boolean = True

        For tx = 0 To xTot
            For ty = 0 To yTot
                If obList(tx, ty).panel.BackColor = Color.Yellow And board(tx, ty) = 9 Then
                    bombsFoundCorrectly += 1
                End If
                If obList(tx, ty).panel.BackColor = Color.Blue Then
                    winnable = False
                End If
            Next
        Next


        If (board(x, y) = 9) And (leftClick) Then

            MsgBox("You Lose")
            Me.Dispose()

        ElseIf (bombsFoundCorrectly = nBombs) And (winnable) Then

            MsgBox("You Win")
            Me.Dispose()

        End If

    End Sub

End Class