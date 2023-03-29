<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNplayGame = New System.Windows.Forms.Button()
        Me.LBLtitle = New System.Windows.Forms.Label()
        Me.GRPplayGame = New System.Windows.Forms.GroupBox()
        Me.GRPnumBombs = New System.Windows.Forms.GroupBox()
        Me.LBLnumBombs = New System.Windows.Forms.Label()
        Me.TRBnumBombs = New System.Windows.Forms.TrackBar()
        Me.GRPxy = New System.Windows.Forms.GroupBox()
        Me.LBLy = New System.Windows.Forms.Label()
        Me.LBLx = New System.Windows.Forms.Label()
        Me.TRBy = New System.Windows.Forms.TrackBar()
        Me.TRBx = New System.Windows.Forms.TrackBar()
        Me.GRPplayGame.SuspendLayout()
        Me.GRPnumBombs.SuspendLayout()
        CType(Me.TRBnumBombs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRPxy.SuspendLayout()
        CType(Me.TRBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNplayGame
        '
        Me.BTNplayGame.Location = New System.Drawing.Point(6, 30)
        Me.BTNplayGame.Name = "BTNplayGame"
        Me.BTNplayGame.Size = New System.Drawing.Size(131, 63)
        Me.BTNplayGame.TabIndex = 0
        Me.BTNplayGame.Text = "Play"
        Me.BTNplayGame.UseVisualStyleBackColor = True
        '
        'LBLtitle
        '
        Me.LBLtitle.AutoSize = True
        Me.LBLtitle.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtitle.Location = New System.Drawing.Point(265, 45)
        Me.LBLtitle.Name = "LBLtitle"
        Me.LBLtitle.Size = New System.Drawing.Size(362, 40)
        Me.LBLtitle.TabIndex = 2
        Me.LBLtitle.Text = "Welcome to Minesweeper"
        '
        'GRPplayGame
        '
        Me.GRPplayGame.BackColor = System.Drawing.Color.Red
        Me.GRPplayGame.Controls.Add(Me.BTNplayGame)
        Me.GRPplayGame.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.GRPplayGame.Location = New System.Drawing.Point(366, 136)
        Me.GRPplayGame.Name = "GRPplayGame"
        Me.GRPplayGame.Size = New System.Drawing.Size(143, 100)
        Me.GRPplayGame.TabIndex = 3
        Me.GRPplayGame.TabStop = False
        Me.GRPplayGame.Text = "Click to play"
        '
        'GRPnumBombs
        '
        Me.GRPnumBombs.BackColor = System.Drawing.Color.Red
        Me.GRPnumBombs.Controls.Add(Me.LBLnumBombs)
        Me.GRPnumBombs.Controls.Add(Me.TRBnumBombs)
        Me.GRPnumBombs.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.GRPnumBombs.Location = New System.Drawing.Point(12, 256)
        Me.GRPnumBombs.Name = "GRPnumBombs"
        Me.GRPnumBombs.Size = New System.Drawing.Size(291, 123)
        Me.GRPnumBombs.TabIndex = 4
        Me.GRPnumBombs.TabStop = False
        Me.GRPnumBombs.Text = "Select bomb quantity"
        '
        'LBLnumBombs
        '
        Me.LBLnumBombs.AutoSize = True
        Me.LBLnumBombs.Location = New System.Drawing.Point(7, 31)
        Me.LBLnumBombs.Name = "LBLnumBombs"
        Me.LBLnumBombs.Size = New System.Drawing.Size(112, 24)
        Me.LBLnumBombs.TabIndex = 1
        Me.LBLnumBombs.Text = "Num. Bombs:"
        '
        'TRBnumBombs
        '
        Me.TRBnumBombs.Location = New System.Drawing.Point(6, 64)
        Me.TRBnumBombs.Maximum = 40
        Me.TRBnumBombs.Minimum = 3
        Me.TRBnumBombs.Name = "TRBnumBombs"
        Me.TRBnumBombs.Size = New System.Drawing.Size(279, 56)
        Me.TRBnumBombs.TabIndex = 0
        Me.TRBnumBombs.Value = 3
        '
        'GRPxy
        '
        Me.GRPxy.BackColor = System.Drawing.Color.Red
        Me.GRPxy.Controls.Add(Me.LBLy)
        Me.GRPxy.Controls.Add(Me.LBLx)
        Me.GRPxy.Controls.Add(Me.TRBy)
        Me.GRPxy.Controls.Add(Me.TRBx)
        Me.GRPxy.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.GRPxy.Location = New System.Drawing.Point(579, 256)
        Me.GRPxy.Name = "GRPxy"
        Me.GRPxy.Size = New System.Drawing.Size(291, 235)
        Me.GRPxy.TabIndex = 5
        Me.GRPxy.TabStop = False
        Me.GRPxy.Text = "Select the grid size"
        '
        'LBLy
        '
        Me.LBLy.AutoSize = True
        Me.LBLy.Location = New System.Drawing.Point(6, 146)
        Me.LBLy.Name = "LBLy"
        Me.LBLy.Size = New System.Drawing.Size(119, 24)
        Me.LBLy.TabIndex = 3
        Me.LBLy.Text = "In y direction"
        '
        'LBLx
        '
        Me.LBLx.AutoSize = True
        Me.LBLx.Location = New System.Drawing.Point(6, 34)
        Me.LBLx.Name = "LBLx"
        Me.LBLx.Size = New System.Drawing.Size(125, 24)
        Me.LBLx.TabIndex = 2
        Me.LBLx.Text = "In x direction:"
        '
        'TRBy
        '
        Me.TRBy.Location = New System.Drawing.Point(6, 173)
        Me.TRBy.Maximum = 100
        Me.TRBy.Minimum = 5
        Me.TRBy.Name = "TRBy"
        Me.TRBy.Size = New System.Drawing.Size(279, 56)
        Me.TRBy.TabIndex = 1
        Me.TRBy.Value = 5
        '
        'TRBx
        '
        Me.TRBx.Location = New System.Drawing.Point(0, 67)
        Me.TRBx.Maximum = 100
        Me.TRBx.Minimum = 5
        Me.TRBx.Name = "TRBx"
        Me.TRBx.Size = New System.Drawing.Size(279, 56)
        Me.TRBx.TabIndex = 0
        Me.TRBx.Value = 5
        '
        'FRMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 503)
        Me.Controls.Add(Me.GRPxy)
        Me.Controls.Add(Me.GRPnumBombs)
        Me.Controls.Add(Me.GRPplayGame)
        Me.Controls.Add(Me.LBLtitle)
        Me.Name = "FRMMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper"
        Me.GRPplayGame.ResumeLayout(False)
        Me.GRPnumBombs.ResumeLayout(False)
        Me.GRPnumBombs.PerformLayout()
        CType(Me.TRBnumBombs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRPxy.ResumeLayout(False)
        Me.GRPxy.PerformLayout()
        CType(Me.TRBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNplayGame As Button
    Friend WithEvents LBLtitle As Label
    Friend WithEvents GRPplayGame As GroupBox
    Friend WithEvents GRPnumBombs As GroupBox
    Friend WithEvents LBLnumBombs As Label
    Friend WithEvents TRBnumBombs As TrackBar
    Friend WithEvents GRPxy As GroupBox
    Friend WithEvents LBLy As Label
    Friend WithEvents LBLx As Label
    Friend WithEvents TRBy As TrackBar
    Friend WithEvents TRBx As TrackBar
End Class
