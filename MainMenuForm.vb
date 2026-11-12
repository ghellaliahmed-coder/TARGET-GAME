Public Class MainMenuForm

    ' =====================
    ' تحميل الفورم
    ' =====================
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' اختيار المستوى السهل افتراضيًا
        rbEasy.Checked = True
    End Sub


    ' =====================
    ' زر بدء اللعبة
    ' =====================
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click

        ' تحديد مستوى الصعوبة
        Dim difficulty As Integer = 1 ' Easy افتراضيًا

        If rbHard.Checked Then
            difficulty = 2 ' Hard
        End If

        ' إنشاء فورم اللعبة مع تمرير الصعوبة
        Dim gameForm As New GameForm(difficulty)

        ' إخفاء القائمة الرئيسية
        Me.Hide()

        ' عرض اللعبة والانتظار حتى يتم إغلاقها
        gameForm.Show()

    End Sub


    ' =====================
    ' زر الخروج
    ' =====================
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class

