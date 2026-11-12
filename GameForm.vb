Public Class GameForm

    ' =====================
    ' متغيرات اللعبة
    ' =====================
    Dim gameRunning As Boolean = False
    Dim isPaused As Boolean = False
    Dim closingToMenu As Boolean = False

    Dim score As Integer = 0
    Dim timeLeft As Integer = 30

    Dim difficultyLevel As Integer
    Dim rnd As New Random()

    Private hitSound As System.Media.SoundPlayer


    ' =====================
    ' Constructor (استقبال الصعوبة)
    ' =====================
    Public Sub New(ByVal difficulty As Integer)
        InitializeComponent()
        difficultyLevel = difficulty
    End Sub


    ' =====================
    ' تحميل الفورم
    ' =====================
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hitSound = New System.Media.SoundPlayer(My.Resources.mixkit_space_coin_win_notification_271)
        hitSound.Load()

        Target.Hide()
        btnPause.Hide()
        btnPlayAgain.Hide()
        btnMainMenu.Hide()
        lblGameOver.Hide()

        score = 0
        timeLeft = 30

        lblScore.Text = "Score: 0"
        lblTime.Text = "Time: 30"

        CenterTarget()
    End Sub


    ' =====================
    ' زر بدء اللعبة
    ' =====================
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        btnGo.Hide()
        Target.Show()
        btnPause.Show()

        score = 0
        timeLeft = 30

        lblScore.Text = "Score: 0"
        lblTime.Text = "Time: 30"

        gameRunning = True

        Select Case difficultyLevel
            Case 1 ' Easy
                TargetTimer.Interval = 500
            Case 2 ' Hard
                TargetTimer.Interval = 300
            Case Else
                TargetTimer.Interval = 500
        End Select

        TargetTimer.Start()
        GameTimer.Start()
    End Sub


    ' =====================
    ' مؤقت الوقت
    ' =====================
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        timeLeft -= 1
        lblTime.Text = "Time: " & timeLeft

        ' تحذير عند اقتراب النهاية
        If timeLeft <= 10 Then
            lblTime.ForeColor = Color.Red
        Else
            lblTime.ForeColor = Color.Black
        End If

        ' انتهاء الوقت
        If timeLeft <= 0 Then

            lblTime.ForeColor = Color.Black

            TargetTimer.Stop()
            GameTimer.Stop()

            Target.Hide()
            btnPause.Hide()

            gameRunning = False
            isPaused = False
            btnPause.Text = "Pause"

            btnPlayAgain.Show()
            btnMainMenu.Show()

            lblGameOver.Text = "GAME OVER!" & vbCrLf & "Final Score: " & score
            lblGameOver.Show()
            CenterGameOverLabel()
        End If
    End Sub


    ' =====================
    ' تحريك الهدف
    ' =====================
    Private Sub TargetTimer_Tick(sender As Object, e As EventArgs) Handles TargetTimer.Tick

        Dim padding As Integer = 20

        Dim maxX As Integer = Me.ClientSize.Width - Target.Width - padding
        Dim maxY As Integer = Me.ClientSize.Height - Target.Height - padding
        Dim minY As Integer = lblTime.Bottom + padding

        Target.Left = rnd.Next(0, maxX + 1)
        Target.Top = rnd.Next(minY, maxY + 1)
    End Sub


    ' =====================
    ' إصابة الهدف
    ' =====================
    Private Sub Target_MouseDown(sender As Object, e As MouseEventArgs) Handles Target.MouseDown

        If Not gameRunning OrElse isPaused Then Exit Sub

        hitSound.Play()

        score += 1
        lblScore.Text = "Score: " & score
    End Sub


    ' =====================
    ' زر الإيقاف المؤقت
    ' =====================
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click

        If Not gameRunning Then Exit Sub

        If Not isPaused Then
            ' PAUSE
            TargetTimer.Stop()
            GameTimer.Stop()

            isPaused = True
            btnPause.Text = "Resume"

            Target.Hide()
            btnPlayAgain.Show()
            btnMainMenu.Show()
            lblGameOver.Hide()
        Else
            ' RESUME
            TargetTimer.Start()
            GameTimer.Start()

            isPaused = False
            btnPause.Text = "Pause"

            btnPlayAgain.Hide()
            btnMainMenu.Hide()
            lblGameOver.Hide()
            Target.Show()
        End If
    End Sub


    ' =====================
    ' زر اللعب مرة أخرى
    ' =====================
    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click

        TargetTimer.Stop()
        GameTimer.Stop()

        isPaused = False
        gameRunning = False

        btnPause.Hide()
        btnPlayAgain.Hide()
        btnMainMenu.Hide()
        lblGameOver.Hide()

        score = 0
        timeLeft = 30

        lblScore.Text = "Score: 0"
        lblTime.Text = "Time: 30"

        Target.Hide()
        CenterTarget()

        btnGo.Show()
    End Sub


    ' =====================
    ' زر القائمة الرئيسية
    ' =====================
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        closingToMenu = True
        Me.Close()
        MainMenuForm.Show()
    End Sub


    ' =====================
    ' توسيط الهدف
    ' =====================
    Private Sub CenterTarget()
        Target.Left = (Me.ClientSize.Width - Target.Width) \ 2
        Target.Top = (Me.ClientSize.Height - Target.Height) \ 2
    End Sub


    ' =====================
    ' توسيط رسالة النهاية
    ' =====================
    Private Sub CenterGameOverLabel()
        lblGameOver.Left = (Me.ClientSize.Width - lblGameOver.Width) \ 2
        lblGameOver.Top = (Me.ClientSize.Height - lblGameOver.Height) \ 2
    End Sub


    ' =====================
    ' إغلاق التطبيق
    ' =====================
    Private Sub GameForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closingToMenu Then
            Application.Exit()
        End If
    End Sub

End Class
