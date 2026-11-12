<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.TargetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.HitAnimTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Target = New System.Windows.Forms.PictureBox()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPlayAgain.AutoSize = True
        Me.btnPlayAgain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayAgain.Location = New System.Drawing.Point(303, 529)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(149, 58)
        Me.btnPlayAgain.TabIndex = 4
        Me.btnPlayAgain.TabStop = False
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMainMenu.AutoSize = True
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Location = New System.Drawing.Point(560, 528)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(144, 58)
        Me.btnMainMenu.TabIndex = 5
        Me.btnMainMenu.TabStop = False
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'TargetTimer
        '
        Me.TargetTimer.Interval = 800
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'btnPause
        '
        Me.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPause.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Location = New System.Drawing.Point(458, 529)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(96, 58)
        Me.btnPause.TabIndex = 8
        Me.btnPause.TabStop = False
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnGo
        '
        Me.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGo.BackColor = System.Drawing.Color.Green
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGo.Location = New System.Drawing.Point(458, 281)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(96, 58)
        Me.btnGo.TabIndex = 9
        Me.btnGo.TabStop = False
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblGameOver.Location = New System.Drawing.Point(497, 191)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(0, 56)
        Me.lblGameOver.TabIndex = 10
        Me.lblGameOver.Visible = False
        '
        'lblScore
        '
        Me.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(321, 20)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(180, 56)
        Me.lblScore.TabIndex = 11
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(511, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(180, 56)
        Me.lblTime.TabIndex = 12
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Target
        '
        Me.Target.BackColor = System.Drawing.Color.Transparent
        Me.Target.Image = Global.TARGET_GAME.My.Resources.Resources.Target_PNG__2_
        Me.Target.Location = New System.Drawing.Point(446, 250)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(120, 120)
        Me.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Target.TabIndex = 0
        Me.Target.TabStop = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(990, 596)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.Target)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GameForm"
        Me.Opacity = 0.94R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Target As PictureBox
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents TargetTimer As Timer
    Friend WithEvents GameTimer As Timer
    Friend WithEvents btnPause As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents lblGameOver As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents HitAnimTimer As Timer
End Class
