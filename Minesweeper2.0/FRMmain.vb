Public Class FRMMain

    Public xSize As Integer
    Public ySize As Integer
    Public nBombs As Integer

    Private Sub FRMMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLnumBombs.Text = "Num. Bombs: " & TRBnumBombs.Value
        LBLx.Text = "In x direction: " & TRBx.Value
        LBLy.Text = "In y direction: " & TRBy.Value

        xSize = TRBx.Value
        ySize = TRBy.Value
        nBombs = TRBnumBombs.Value

    End Sub

    Private Sub TRBnumBombs_ValueChanged(sender As Object, e As EventArgs) Handles TRBnumBombs.ValueChanged
        LBLnumBombs.Text = "Num. Bombs: " & TRBnumBombs.Value
        nBombs = TRBnumBombs.Value
    End Sub

    Private Sub TRBx_ValueChanged(sender As Object, e As EventArgs) Handles TRBx.ValueChanged
        LBLx.Text = "In x direction: " & TRBx.Value
        xSize = TRBx.Value
    End Sub

    Private Sub TRBy_ValueChanged(sender As Object, e As EventArgs) Handles TRBy.ValueChanged
        LBLy.Text = "In y direction: " & TRBy.Value
        ySize = TRBy.Value
    End Sub

    Private Sub BTNplayGame_Click(sender As Object, e As EventArgs) Handles BTNplayGame.Click

        Me.Hide()
        FRMgameScreen.ShowDialog()
        Me.Show()

    End Sub
End Class
