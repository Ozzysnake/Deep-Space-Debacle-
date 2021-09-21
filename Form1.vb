
Public Class ParentForm
#Region "Variables"
    Dim lef As Boolean
    Dim rig As Boolean
    Dim aliens(20) As PictureBox
    Dim alienrow1(5) As PictureBox
    Dim alienrow2(7) As PictureBox
    Dim alienrow3(6) As PictureBox
    Dim healthup(2) As PictureBox
    Dim healthup_drop(2) As Boolean
    Dim missileup(1) As PictureBox
    Dim missileup_drop(1) As Boolean
    Dim alien_movement As Double = 4.5
    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim missileSpeed As Double = 10
    Dim WhichAlienHit As Integer
    Dim NumberOfAliensShot As Integer = 0
    Dim aliens_reset_location(20) As System.Drawing.Point
    Dim level As Integer = 1
    Dim level_cap As Integer
    Dim startTime As Date = Date.Now
    Dim laser(20) As PictureBox
    Dim laser_fire(20) As Boolean
    Dim Health As Integer
    Dim start_movement As Boolean
    Dim standard_bool As Boolean
    Dim randomNumber As Integer
    Dim randomNumberHealthup As Integer
    Dim randomNumberMissileup As Integer
    Dim player_score As Integer
    Dim score_for_player_1 As Integer = 8
    Dim score_for_player_2 As Integer = 7
    Dim score_for_player_3 As Integer = 6
    Dim score_for_player_4 As Integer = 5
    Dim score_for_player_5 As Integer = 4
    Dim score_for_player_6 As Integer = 3
    Dim score_for_player_7 As Integer = 2
    Dim score_for_player_8 As Integer = 1
    Dim player_name_1 As String = "CPU 1"
    Dim player_name_2 As String = "CPU 2"
    Dim player_name_3 As String = "CPU 3"
    Dim player_name_4 As String = "CPU 4"
    Dim player_name_5 As String = "CPU 5"
    Dim player_name_6 As String = "CPU 6"
    Dim player_name_7 As String = "CPU 7"
    Dim player_name_8 As String = "CPU 8"
    Dim current_time As String
    Dim previous_time As String
    Dim current_score As Integer = 0
    Dim monitorWidth As Integer = My.Computer.Screen.WorkingArea.Size.Width
    Dim monitorHeight As Integer = My.Computer.Screen.WorkingArea.Size.Height
    Dim sound_on As Boolean = True



#End Region

#Region "Load"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Width = monitorWidth / 2
        Me.Height = monitorHeight / 2
        MainMenu.Show()
        create_Aliens_Array()
        create_laser_array()
        create_healthup_array()
        create_missileup_array()


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub startgame()
        HelpPanel.Hide()
        GameMain.Show()
        Movement.Enabled = True
        Movement.Start()
        NumberOfAliensShot = 0
        endlessButton.Hide()
        standardButton.Hide()
        sound_on_button.Hide()
        sound_off_button.Hide()
        If sound_on = True Then
            My.Computer.Audio.Play("C:\Users\Ozzysnake\Desktop\Games\Deep Space Decable\Deep Space Debacle\sound effects\background_music.wav",
                           AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    'Private Sub make_images_transparent()
    '    'powerups
    '    'Alien_500_3.Controls.Add(missileup1)
    '    'missileup1.Location = New Point(0, 0)
    '    'missileup1.BackColor = Color.Transparent

    '    'Alien_500_3.Controls.Add(healthup2)
    '    'healthup2.Location = New Point(0, 0)
    '    'healthup2.BackColor = Color.Transparent

    '    'Alien_500_5.Controls.Add(missileup2)
    '    'missileup2.Location = New Point(0, 0)
    '    'missileup2.BackColor = Color.Transparent

    '    'Alien_500_6.Controls.Add(healthup1)
    '    'healthup1.Location = New Point(0, 0)
    '    'healthup1.BackColor = Color.Transparent
    '    'missileup1.BackColor = Color.Transparent
    '    'missileup1.Parent = GameMain
    'End Sub

#End Region
#Region "PlayerCharacter"
    Private Sub checkshot()
        fire = False
        If fire1 = False Then
            fire1 = True
            Missile.Show()
            Exit Sub
        End If

    End Sub
    Private Sub moveshot()
        If fire1 = True Then
            'My.Computer.Audio.Play("C:\Users\Ozzysnake\Desktop\Games\Deep Space Decable\Deep Space Debacle\sound effects\missile.wav")
            Missile.Top = Missile.Top - missileSpeed
            For i = 0 To 20
                If Missile.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    WhichAlienHit = i
                    shothit()
                End If
            Next
            If Missile.Top < 0 Then
                Missile.Hide()
                fire1 = False
                Missile.Location = restart_shot.Location
            End If
        End If

    End Sub

    Private Sub playerdies()
        Movement.Stop()
        HealthBar.Value = 0

        Player.Image = My.Resources.Player_destroyed
        Player.SizeMode = PictureBoxSizeMode.StretchImage
        Player.Size = New Size(108, 130)
        levellabel.Hide()
        game_over_text.Show()
        Movement.Stop()
        For i = 0 To 10
            laser(i).Hide()
        Next
        TimeElapsedTimer.Stop()
        scoreboardTimer.Enabled = True
        scoreboardTimer.Start()
        current_time = minutesLabel.Text + secondsLabel.Text
        My.Computer.Audio.Stop()
        'My.Computer.Audio.Play("C:\Users\Ozzysnake\Desktop\Games\Deep Space Decable\Deep Space Debacle\sound effects\death.wav",
        '                       AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("C:\Users\Ozzysnake\Desktop\Games\Deep Space Decable\Deep Space Debacle\sound effects\game_over.wav")
    End Sub
    Private Sub shothit()
        fire1 = False
        Missile.Hide()
        Missile.Location = restart_shot.Location
        aliens(WhichAlienHit).Image = My.Resources.explosion
        aliens(WhichAlienHit).SizeMode = PictureBoxSizeMode.StretchImage
        aliens(WhichAlienHit).Size = New Size(83, 71)
        ExplosionTimer.Start()
        NumberOfAliensShot = NumberOfAliensShot + 1
        If NumberOfAliensShot > 19 Then
            levelwon()
        End If
        player_score = player_score + 1
    End Sub

    Private Sub levelwon()
        NumberOfAliensShot = 0
        level = level + 1
        levellabel.Text = "Level " & level
        If standard_bool = True Then
            alien_movement = 2.5 * level
        End If
        For i = 0 To 20
            aliens(i).Location = aliens_reset_location(i)
        Next
        For i = 0 To 5
            alienrow1(i).Image = Deep_Space_Debacle.My.Resources.Resources._500
            alienrow1(i).SizeMode = PictureBoxSizeMode.StretchImage
            alienrow1(i).Size = New Size(73, 79)
        Next
        For i = 0 To 7
            alienrow2(i).Image = Deep_Space_Debacle.My.Resources.Resources._300
            alienrow2(i).SizeMode = PictureBoxSizeMode.StretchImage
            alienrow2(i).Size = New Size(83, 71)
        Next
        For i = 0 To 6
            alienrow3(i).Image = Deep_Space_Debacle.My.Resources.Resources._100
            alienrow3(i).SizeMode = PictureBoxSizeMode.StretchImage
            alienrow3(i).Size = New Size(90, 70)
        Next
        If level = level_cap Then
            gamewon()
        End If

    End Sub
    Private Sub gamewon()
        For i = 0 To 20
            aliens(i).Hide()
        Next
        Movement.Stop()
        levellabel.Hide()
        levelwonlabel.Show()
        scoreboardTimer.Enabled = True
        scoreboardTimer.Start()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("C:\Users\Ozzysnake\Desktop\Games\Deep Space Decable\Deep Space Debacle\sound effects\you_win.wav")

    End Sub
#End Region
#Region "NPCs"
    Private Sub create_Aliens_Array()
        aliens(0) = Alien_100_1
        aliens(1) = Alien_100_2
        aliens(2) = Alien_100_3
        aliens(3) = Alien_100_4
        aliens(4) = Alien_100_5
        aliens(5) = Alien_100_6
        aliens(6) = Alien_100_7
        aliens(7) = Alien_300_1
        aliens(8) = Alien_300_2
        aliens(9) = Alien_300_3
        aliens(10) = Alien_300_4
        aliens(11) = Alien_300_5
        aliens(12) = Alien_300_6
        aliens(13) = Alien_300_7
        aliens(14) = Alien_300_8
        aliens(15) = Alien_500_1
        aliens(16) = Alien_500_2
        aliens(17) = Alien_500_3
        aliens(18) = Alien_500_4
        aliens(19) = Alien_500_5
        aliens(20) = Alien_500_6
        For i = 0 To 20
            aliens_reset_location(i) = aliens(i).Location
        Next
        alienrow1(0) = Alien_500_1
        alienrow1(1) = Alien_500_2
        alienrow1(2) = Alien_500_3
        alienrow1(3) = Alien_500_4
        alienrow1(4) = Alien_500_5
        alienrow1(5) = Alien_500_6
        alienrow2(0) = Alien_300_1
        alienrow2(1) = Alien_300_2
        alienrow2(2) = Alien_300_3
        alienrow2(3) = Alien_300_4
        alienrow2(4) = Alien_300_5
        alienrow2(5) = Alien_300_6
        alienrow2(6) = Alien_300_7
        alienrow2(7) = Alien_300_8
        alienrow3(0) = Alien_100_1
        alienrow3(1) = Alien_100_2
        alienrow3(2) = Alien_100_3
        alienrow3(3) = Alien_100_4
        alienrow3(4) = Alien_100_5
        alienrow3(5) = Alien_100_6
        alienrow3(6) = Alien_100_7



    End Sub

    Private Sub create_laser_array()
        laser(0) = laser1
        laser(1) = laser2
        laser(2) = laser3
        laser(3) = laser4
        laser(4) = laser5
        laser(5) = laser6
        laser(6) = laser7
        laser(7) = laser8
        laser(8) = laser9
        laser(9) = laser10
        laser(10) = laser11
        laser(11) = laser12
        laser(12) = laser13
        laser(13) = laser14
        laser(14) = laser15
        laser(15) = laser16
        laser(16) = laser17
        laser(17) = laser18
        laser(18) = laser19
        laser(19) = laser20
        laser(20) = laser21



    End Sub
    Private Sub move_aliens()

        For i = 0 To 20
            aliens(i).Left = aliens(i).Left + alien_movement
            If aliens(i).Bounds.IntersectsWith(Player.Bounds) Then
                playerdies()
            End If


        Next
        If Alien_300_8.Left > Me.Width - Alien_300_8.Width Then
            alien_movement = alien_movement * -1
            For i = 0 To 20
                aliens(i).Top = aliens(i).Top + 25
            Next
        End If
        If Alien_300_1.Left < 0 Then
            alien_movement = alien_movement * -1
            For i = 0 To 20
                aliens(i).Top = aliens(i).Top + 25
            Next
        End If
        For i = 0 To 20
            If aliens(i).Top > Me.Height Then
                playerdies()
            End If
        Next
    End Sub

    Private Sub lasermovement()
        For i = 0 To 20
            If laser_fire(i) = False Then
                randomNumber = CInt(Int((1000 * Rnd() + 1)))
                If randomNumber = 1000 Then
                    laser_fire(i) = True
                    laser(i).Show()
                End If
                If aliens(i).Top < -10000 Then
                    laser_fire(i) = False
                    laser(i).Hide()
                End If
            End If
        Next
        For i = 0 To 20
            If laser_fire(i) = True Then
                laser(i).Top = laser(i).Top + 5
            End If
            If laser(i).Bounds.IntersectsWith(Player.Bounds) Then
                laser(i).Hide()
                healthBarTimer.Enabled = True
                healthBarTimer.Start()
            End If

        Next
        For i = 0 To 20
            If laser(i).Top > Me.Height Then
                laser_fire(i) = False
                laser(i).Hide()
                laser(i).Location = aliens(i).Location
            End If
        Next
    End Sub
#End Region
#Region "Buttons"
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        HelpPanel.Show()
        QuitButton.Hide()
        versionLabel.Hide()
        sound_on_button.Hide()
        sound_off_button.Hide()

    End Sub

    Private Sub BackToMainMenu_Click(sender As Object, e As EventArgs) Handles BackToMainMenu.Click
        HelpPanel.Hide()
        MainMenu.Show()
        QuitButton.Show()
        versionLabel.Show()
        sound_on_button.Show()
        sound_off_button.Show()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        endlessButton.Show()
        standardButton.Show()
        PlayButton.Hide()
        HelpButton.Hide()
        QuitButton.Hide()
        versionLabel.Hide()
        sound_on_button.Hide()
        sound_off_button.Hide()
    End Sub
    Private Sub standardButton_Click(sender As Object, e As EventArgs) Handles standardButton.Click
        startgame()
        HealthBar.Value = 40
        standard_bool = True
        level_cap = 4
        countdownTimer.Enabled = True
        countdownTimer.Start()
        countdownTimer.Enabled = True
        countdownTimer.Start()
        OneSecTimer.Enabled = True
        OneSecTimer.Start()
        TwoSecTimer.Enabled = True
        TwoSecTimer.Start()
        ThreeSecTimer.Enabled = True
        ThreeSecTimer.Start()


    End Sub
    Private Sub endlessButton_Click(sender As Object, e As EventArgs) Handles endlessButton.Click
        startgame()
        levellabel.Show()
        level_cap = 100000
        HealthBar.Value = 40
        alien_movement = 4.5
        countdownTimer.Enabled = True
        countdownTimer.Start()
        OneSecTimer.Enabled = True
        OneSecTimer.Start()
        TwoSecTimer.Enabled = True
        TwoSecTimer.Start()
        ThreeSecTimer.Enabled = True
        ThreeSecTimer.Start()
        current_time = "0"
        TimeElapsedTimer.Enabled = True
        TimeElapsedTimer.Start()


    End Sub
    Private Sub standardButton_MouseHover(sender As Object, e As EventArgs) Handles standardButton.MouseHover
        standardText.Show()
    End Sub
    Private Sub standardButton_MouseLeave(sender As Object, e As EventArgs) Handles standardButton.MouseLeave
        standardText.Hide()
    End Sub


    Private Sub endlessButton_MouseHover(sender As Object, e As EventArgs) Handles endlessButton.MouseHover
        endlessText.Show()
        'TopScoreBox.Show()
    End Sub

    Private Sub endlessButton_MouseLeave(sender As Object, e As EventArgs) Handles endlessButton.MouseLeave
        endlessText.Hide()
        'TopScoreBox.Hide()
    End Sub

    Private Sub retryButton_Click(sender As Object, e As EventArgs) Handles retryButton.Click
        scoreboardPanel.Hide()
        GameMain.Hide()
        MainMenu.Show()
        reset_game()
        'check_score()
        'write_achievements()
        'read_achievements()

    End Sub
    Private Sub Sound_on_button_Click(sender As Object, e As EventArgs) Handles sound_on_button.Click
        sound_on = False
        sound_on_button.Hide()
        sound_off_button.Show()
    End Sub

    Private Sub Sound_off_button_Click(sender As Object, e As EventArgs) Handles sound_off_button.Click
        sound_on = True
        sound_off_button.Hide()
        sound_on_button.Show()
    End Sub

#End Region
#Region "Actions"
    Private Sub GameActions(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Then
            lef = True

        End If
        If e.KeyCode = Keys.D Then
            rig = True

        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            MsgBox("Bruh")

        End If
        If e.KeyCode = Keys.P Then
            fire = True
        End If
        If e.KeyCode = Keys.M Then
            playerdies()
        End If
    End Sub
    Private Sub GameActionFinished(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.A Then
            lef = False
        End If
        If e.KeyCode = Keys.D Then
            rig = False
        End If
        If e.KeyCode = Keys.P Then
            fire = False
        End If
    End Sub
#End Region
#Region "Timers"
    Private Sub MoveCharacterTick(sender As Object, e As EventArgs) Handles Movement.Tick
        If lef = True Then ' If player presses left key
            Player.Left = Player.Left - 10 'move player left
            restart_shot.Left = restart_shot.Left - 10 ' Move the restart shot to the left
            If fire1 = False Then ' If player hasn't fired yet
                Missile.Left = Missile.Left - 10 ' Push the unfired missle to the left
            End If
            If Player.Left < 0 Then ' If player goes off left hand side of screen
                Player.Left = Player.Left + 40 ' push player to the right
                restart_shot.Left = restart_shot.Left + 40 ' push restart shot to right
                If fire1 = False Then ' If player hasn't fired yet
                    Missile.Left = Missile.Left + 40 ' Push the unfired missle to the right
                End If
            End If

        End If
        If rig = True Then ' If player presses right key
            Player.Left = Player.Left + 10 ' move player right
            restart_shot.Left = restart_shot.Left + 10 ' move restart position right
            If fire1 = False Then ' If player hasn't fired yet
                Missile.Left = Missile.Left + 10 ' Push the unfired missle to the left
            End If
            If Player.Left > Me.Width - Player.Width Then ' If player moves
                ' over right hand edge of screen
                Player.Left = Player.Left - 40 ' move player to the left
                restart_shot.Left = restart_shot.Left - 40 ' move restart shot to left
                If fire1 = False Then ' If the missle hasn't been fired yet
                    Missile.Left = Missile.Left - 40 ' Move it to the left as well. 
                End If
            End If
            'restart_shot.Left = restart_shot.Left + 10 'move the restart shot to the right
            'Missile.Left = Missile.Left + 10 ' move the unfired missle to the right
        End If

        If fire = True Then
            checkshot()
        End If
        If start_movement = True Then
            move_aliens()
            lasermovement()
            moveshot()
            healthup_movement()
            missileup_movement()
        End If



    End Sub

    Private Sub Explos(sender As Object, e As EventArgs) Handles ExplosionTimer.Tick
        ExplosionTimer.Stop()
        aliens(WhichAlienHit).Top = aliens(WhichAlienHit).Top - 100000
    End Sub
    Private Sub missileSpeedTimer_Tick(sender As Object, e As EventArgs) Handles missileSpeedTimer.Tick
        missileSpeedTimer.Stop()
        missileSpeed = 10
    End Sub
    Private Sub healthBarTimer_Tick(sender As Object, e As EventArgs) Handles healthBarTimer.Tick
        healthBarTimer.Stop()
        'If HealthBar.Value < 0 Then
        'HealthBar.Value = 30
        'End If
        HealthBar.Value = HealthBar.Value - 10
        If HealthBar.Value = 20 Then
            Exit Sub
        End If
        If HealthBar.Value = 10 Then
            Exit Sub
        End If
        If HealthBar.Value = 0 Then
            playerdies()
        End If
    End Sub

    Private Sub PowerupTextTimer_Tick(sender As Object, e As EventArgs) Handles powerupTextTimer.Tick
        powerupTextTimer.Stop()
        healthup_text.Hide()
        missileup_text.Hide()
    End Sub
    Private Sub CountdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        countdownTimer.Stop()
        start_movement = True
    End Sub

    Private Sub OneSecTimer_Tick(sender As Object, e As EventArgs) Handles OneSecTimer.Tick
        countdownLabel.Text = "2"
        OneSecTimer.Stop()
    End Sub

    Private Sub TwoSecTimer_Tick(sender As Object, e As EventArgs) Handles TwoSecTimer.Tick
        countdownLabel.Text = "1"
        TwoSecTimer.Stop()
    End Sub
    Private Sub ThreeSecTimer_Tick(sender As Object, e As EventArgs) Handles ThreeSecTimer.Tick
        countdownLabel.Hide()
        ThreeSecTimer.Stop()
    End Sub
    Private Sub TimeElapsedTimer_Tick(sender As Object, e As EventArgs) Handles TimeElapsedTimer.Tick
        secondsLabel.Text += 1
        If secondsLabel.Text = 60 Then
            minutesLabel.Text += 1
            secondsLabel.Text = 0
        End If

    End Sub

#End Region
#Region "power-ups"
    Private Sub create_healthup_array()
        healthup(0) = healthup1
        healthup(1) = healthup2
        healthup(2) = healthup3
    End Sub
    Private Sub create_missileup_array()
        missileup(0) = missileup1
        missileup(1) = missileup2
    End Sub
    Private Sub healthup_movement()
        For i = 0 To 2
            If healthup_drop(i) = False Then
                randomNumberHealthup = CInt(Int((1000 * Rnd() + 1)))
                If randomNumberHealthup = 500 Then
                    healthup_drop(i) = True
                    healthup(i).Show()
                End If
            End If
        Next
        For i = 0 To 2
            If healthup_drop(i) = True Then
                healthup(i).Top = healthup(i).Top + 5
            End If
            If healthup(i).Bounds.IntersectsWith(Player.Bounds) Then
                healthup(i).Hide()
                HealthBar.Value = 40
                healthup_text.Show()
                'Player.Controls.Add(healthup_text)
                healthup_text.Location = New Point(Player.Location.X, Player.Location.Y - 200)
                'healthup_text.BackColor = Color.Transparent
                'healthup_text.BringToFront()
                powerupTextTimer.Enabled = True
                powerupTextTimer.Start()


            End If

        Next
        For i = 0 To 2
            If healthup(i).Top > Me.Height Then
                healthup_drop(i) = False
                healthup(i).Hide()
                healthup(i).Location = aliens(i).Location
            End If
        Next
    End Sub
    Private Sub missileup_movement()
        For i = 0 To 1
            If missileup_drop(i) = False Then
                randomNumberMissileup = CInt(Int((1000 * Rnd() + 1)))
                If randomNumberMissileup = 500 Then
                    missileup_drop(i) = True
                    missileup(i).Show()
                End If
            End If
        Next
        For i = 0 To 1
            If missileup_drop(i) = True Then
                missileup(i).Top = missileup(i).Top + 5
            End If
            If missileup(i).Bounds.IntersectsWith(Player.Bounds) Then
                missileup(i).Hide()
                missileSpeed = 50
                missileSpeedTimer.Enabled = True
                missileSpeedTimer.Start()
                missileup_text.Location = New Point(Player.Location.X, Player.Location.Y - 200)
                missileup_text.Show()
                powerupTextTimer.Enabled = True
                powerupTextTimer.Start()

            End If

        Next
        For i = 0 To 1
            If missileup(i).Top > Me.Height Then
                missileup_drop(i) = False
                missileup(i).Hide()
                missileup(i).Location = aliens(i).Location
            End If
        Next
    End Sub
#End Region
#Region "Scoreboard"



    Private Sub nameEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles nameEntry.KeyDown
        If e.KeyCode = Keys.Enter Then
            scoreboard()
            gamerScore1.Show()
            gamerScore2.Show()
            gamerScore3.Show()
            gamerScore4.Show()
            gamerScore5.Show()
            gamerScore6.Show()
            gamerScore7.Show()
            gamerScore8.Show()
            gamerScore1_score.Show()
            gamerScore2_score.Show()
            gamerScore3_score.Show()
            gamerScore4_score.Show()
            gamerScore5_score.Show()
            gamerScore6_score.Show()
            gamerScore7_score.Show()
            gamerScore8_score.Show()
        End If
    End Sub

    Private Sub scoreboardTimer_Tick(sender As Object, e As EventArgs) Handles scoreboardTimer.Tick
        scoreboardTimer.Stop()
        scoreboardPanel.Show()
        retryButton.Show()
    End Sub
    Private Sub scoreboard()
        If player_score > score_for_player_1 Then
            score_for_player_8 = score_for_player_7
            score_for_player_7 = score_for_player_6
            score_for_player_6 = score_for_player_5
            score_for_player_5 = score_for_player_4
            score_for_player_4 = score_for_player_3
            score_for_player_3 = score_for_player_2
            score_for_player_2 = score_for_player_1
            score_for_player_1 = player_score
            player_name_8 = player_name_7
            player_name_7 = player_name_6
            player_name_6 = player_name_5
            player_name_5 = player_name_4
            player_name_4 = player_name_3
            player_name_3 = player_name_2
            player_name_2 = player_name_1
            player_name_1 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score > score_for_player_2 Then
            score_for_player_8 = score_for_player_7
            score_for_player_7 = score_for_player_6
            score_for_player_6 = score_for_player_5
            score_for_player_5 = score_for_player_4
            score_for_player_4 = score_for_player_3
            score_for_player_3 = score_for_player_2
            score_for_player_2 = player_score
            player_name_8 = player_name_7
            player_name_7 = player_name_6
            player_name_6 = player_name_5
            player_name_5 = player_name_4
            player_name_4 = player_name_3
            player_name_3 = player_name_2
            player_name_2 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score > score_for_player_3 Then
            score_for_player_8 = score_for_player_7
            score_for_player_7 = score_for_player_6
            score_for_player_6 = score_for_player_5
            score_for_player_5 = score_for_player_4
            score_for_player_4 = score_for_player_3
            score_for_player_3 = player_score
            player_name_8 = player_name_7
            player_name_7 = player_name_6
            player_name_6 = player_name_5
            player_name_5 = player_name_4
            player_name_4 = player_name_3
            player_name_3 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score > score_for_player_4 Then
            score_for_player_8 = score_for_player_7
            score_for_player_7 = score_for_player_6
            score_for_player_6 = score_for_player_5
            score_for_player_5 = score_for_player_4
            score_for_player_4 = player_score
            player_name_8 = player_name_7
            player_name_7 = player_name_6
            player_name_6 = player_name_5
            player_name_5 = player_name_4
            player_name_4 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score > score_for_player_5 Then
            score_for_player_8 = score_for_player_7
            score_for_player_7 = score_for_player_6
            score_for_player_6 = score_for_player_5
            score_for_player_5 = player_score
            player_name_8 = player_name_7
            player_name_7 = player_name_6
            player_name_6 = player_name_5
            player_name_5 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score > score_for_player_6 Then
            score_for_player_8 = score_for_player_7
            score_for_player_7 = score_for_player_6
            score_for_player_6 = player_score
            player_name_8 = player_name_7
            player_name_7 = player_name_6
            player_name_6 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score > score_for_player_7 Then
            score_for_player_8 = score_for_player_7
            score_for_player_7 = player_score
            player_name_8 = player_name_7
            player_name_7 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score > score_for_player_8 Then
            score_for_player_8 = player_score
            player_name_8 = nameEntry.Text
            drawscoreboard()
            Exit Sub
        End If
        If player_score < score_for_player_8 Then
            badScore.Text = "You ONLY got " & player_score & "."
            badScore.Show()
            drawscoreboard()
        End If
    End Sub

    Private Sub drawscoreboard()
        gamerScore1.Text = player_name_1
        gamerScore2.Text = player_name_2
        gamerScore3.Text = player_name_3
        gamerScore4.Text = player_name_4
        gamerScore5.Text = player_name_5
        gamerScore6.Text = player_name_6
        gamerScore7.Text = player_name_7
        gamerScore8.Text = player_name_8
        gamerScore1_score.Text = score_for_player_1
        gamerScore2_score.Text = score_for_player_2
        gamerScore3_score.Text = score_for_player_3
        gamerScore4_score.Text = score_for_player_4
        gamerScore5_score.Text = score_for_player_5
        gamerScore6_score.Text = score_for_player_6
        gamerScore7_score.Text = score_for_player_7
        gamerScore8_score.Text = score_for_player_8

    End Sub

    Private Sub hidescoreboard()
        badScore.Hide()
        gamerScore1.Hide()
        gamerScore2.Hide()
        gamerScore3.Hide()
        gamerScore4.Hide()
        gamerScore5.Hide()
        gamerScore6.Hide()
        gamerScore7.Hide()
        gamerScore8.Hide()
        gamerScore1_score.Hide()
        gamerScore2_score.Hide()
        gamerScore3_score.Hide()
        gamerScore4_score.Hide()
        gamerScore5_score.Hide()
        gamerScore6_score.Hide()
        gamerScore7_score.Hide()
        gamerScore8_score.Hide()


    End Sub



#End Region
#Region "Reset game"
    Private Sub reset_game()
        Player.Image = My.Resources.Player
        Player.SizeMode = PictureBoxSizeMode.StretchImage
        Player.Size = New Size(108, 130)
        player_score = 0
        NumberOfAliensShot = 0
        level = 1
        fire = False
        fire1 = False
        HealthBar.Value = 40
        Missile.Location = restart_shot.Location
        Missile.Hide()
        levellabel.Text = "Level " & level
        countdownTimer.Enabled = False
        start_movement = False
        countdownLabel.Show()
        countdownLabel.Text = "3"
        versionLabel.Show()
        TimeElapsedTimer.Enabled = False
        secondsLabel.Text = 0
        minutesLabel.Text = 0
        previous_time = current_time
        For i = 0 To 2
            healthup_drop(i) = False
            healthup(i).Hide()
            healthup(i).Top = healthup(i).Top + 56
            healthup(i).Left = healthup(i).Left + 37
        Next
        For i = 0 To 1
            missileup_drop(i) = False
            missileup(i).Hide()
            missileup(i).Top = missileup(i).Top + 56
            missileup(i).Left = missileup(i).Left + 37
        Next
        For i = 0 To 20
            aliens(i).Location = aliens_reset_location(i)
            laser(i).Location = aliens(i).Location
            aliens(i).Show()
            laser_fire(i) = False
            laser(i).Hide()
            laser(i).Top = laser(i).Top + 56
            laser(i).Left = laser(i).Left + 37
        Next
        For i = 0 To 5
            alienrow1(i).Image = My.Resources._500
            alienrow1(i).SizeMode = PictureBoxSizeMode.StretchImage
            alienrow1(i).Size = New Size(73, 79)
        Next
        For i = 0 To 7
            alienrow2(i).Image = My.Resources._300
            alienrow2(i).SizeMode = PictureBoxSizeMode.StretchImage
            alienrow2(i).Size = New Size(83, 71)
        Next
        For i = 0 To 6
            alienrow3(i).Image = My.Resources._100
            alienrow3(i).SizeMode = PictureBoxSizeMode.StretchImage
            alienrow3(i).Size = New Size(90, 70)
        Next
        HelpPanel.Hide()
        PlayButton.Show()
        HelpButton.Show()
        QuitButton.Show()
        sound_on_button.Show()
        sound_off_button.Show()
        game_over_text.Hide()
        levellabel.Hide()
        levelwonlabel.Hide()
        nameEntry.ResetText()
        hidescoreboard()
        retryButton.Hide()
    End Sub
#End Region
    '#Region "Achievements"
    '    Private Sub create_achievements_file()
    '        FileOpen(1, "achievements.json", OpenMode.Output)
    '        FileClose(1)

    '    End Sub
    '    Private Sub write_achievements()
    '        FileOpen(1, "achievements.json", OpenMode.Append)
    '        PrintLine(1, "Top Score:")
    '        PrintLine(1, score_for_player_1)
    '        PrintLine(1, "Longest Time Surivied")
    '        PrintLine(1, current_time)
    '        FileClose(1)



    '    End Sub
    '    Private Sub check_score()

    '    End Sub
    '    Private Sub read_achievements()
    '        highestScoreLabel.Text = My.Computer.FileSystem.ReadAllText("achievements.json")(12)
    '        'FileClose(1)

    '    End Sub
    '#End Region
#Region "Links"
    Private Sub VersionLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles versionLabel.LinkClicked
        Process.Start("http://ozzysnake.com/")
    End Sub
#End Region
End Class