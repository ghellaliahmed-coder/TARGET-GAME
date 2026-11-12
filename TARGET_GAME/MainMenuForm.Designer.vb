<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
        Me.rbEasy = New System.Windows.Forms.RadioButton()
        Me.rbHard = New System.Windows.Forms.RadioButton()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbEasy
        '
        Me.rbEasy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbEasy.AutoSize = True
        Me.rbEasy.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rbEasy.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEasy.ForeColor = System.Drawing.Color.White
        Me.rbEasy.Location = New System.Drawing.Point(223, 265)
        Me.rbEasy.Name = "rbEasy"
        Me.rbEasy.Size = New System.Drawing.Size(87, 30)
        Me.rbEasy.TabIndex = 1
        Me.rbEasy.TabStop = True
        Me.rbEasy.Text = "Easy"
        Me.rbEasy.UseVisualStyleBackColor = False
        '
        'rbHard
        '
        Me.rbHard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbHard.AutoSize = True
        Me.rbHard.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rbHard.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHard.ForeColor = System.Drawing.Color.White
        Me.rbHard.Location = New System.Drawing.Point(316, 265)
        Me.rbHard.Name = "rbHard"
        Me.rbHard.Size = New System.Drawing.Size(86, 30)
        Me.rbHard.TabIndex = 2
        Me.rbHard.TabStop = True
        Me.rbHard.Text = "Hard"
        Me.rbHard.UseVisualStyleBackColor = False
        '
        'btnStartGame
        '
        Me.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStartGame.AutoSize = True
        Me.btnStartGame.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnStartGame.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStartGame.Location = New System.Drawing.Point(223, 302)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(179, 46)
        Me.btnStartGame.TabIndex = 4
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(223, 354)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 46)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit Game"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 423)
        Me.Controls.Add(Me.rbEasy)
        Me.Controls.Add(Me.rbHard)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStartGame)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbEasy As RadioButton
    Friend WithEvents rbHard As RadioButton
    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnExit As Button
End Class
