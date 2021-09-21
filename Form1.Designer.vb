<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentForm))
        Me.Movement = New System.Windows.Forms.Timer(Me.components)
        Me.ExplosionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.scoreboardTimer = New System.Windows.Forms.Timer(Me.components)
        Me.healthBarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.missileSpeedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.powerupTextTimer = New System.Windows.Forms.Timer(Me.components)
        Me.countdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TwoSecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OneSecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ThreeSecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeElapsedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu = New System.Windows.Forms.Panel()
        Me.sound_off_button = New System.Windows.Forms.PictureBox()
        Me.sound_on_button = New System.Windows.Forms.PictureBox()
        Me.GameMain = New System.Windows.Forms.Panel()
        Me.scoreboardPanel = New System.Windows.Forms.Panel()
        Me.TimeSurvived = New System.Windows.Forms.GroupBox()
        Me.colon = New System.Windows.Forms.Label()
        Me.secondsLabel = New System.Windows.Forms.Label()
        Me.minutesLabel = New System.Windows.Forms.Label()
        Me.badScore = New System.Windows.Forms.Label()
        Me.gamerScore8_score = New System.Windows.Forms.Label()
        Me.gamerScore7_score = New System.Windows.Forms.Label()
        Me.gamerScore6_score = New System.Windows.Forms.Label()
        Me.gamerScore5_score = New System.Windows.Forms.Label()
        Me.gamerScore4_score = New System.Windows.Forms.Label()
        Me.gamerScore3_score = New System.Windows.Forms.Label()
        Me.gamerScore2_score = New System.Windows.Forms.Label()
        Me.gamerScore1_score = New System.Windows.Forms.Label()
        Me.gamerScore8 = New System.Windows.Forms.Label()
        Me.gamerScore7 = New System.Windows.Forms.Label()
        Me.gamerScore6 = New System.Windows.Forms.Label()
        Me.gamerScore5 = New System.Windows.Forms.Label()
        Me.gamerScore4 = New System.Windows.Forms.Label()
        Me.gamerScore3 = New System.Windows.Forms.Label()
        Me.gamerScore2 = New System.Windows.Forms.Label()
        Me.gamerScore1 = New System.Windows.Forms.Label()
        Me.nameEntry = New System.Windows.Forms.TextBox()
        Me.scoreboardPlayerNameLabel = New System.Windows.Forms.Label()
        Me.scorebaordText = New System.Windows.Forms.Label()
        Me.countdownLabel = New System.Windows.Forms.Label()
        Me.healthup_text = New System.Windows.Forms.PictureBox()
        Me.missileup_text = New System.Windows.Forms.PictureBox()
        Me.missileup2 = New System.Windows.Forms.PictureBox()
        Me.missileup1 = New System.Windows.Forms.PictureBox()
        Me.healthup3 = New System.Windows.Forms.PictureBox()
        Me.healthup2 = New System.Windows.Forms.PictureBox()
        Me.healthup1 = New System.Windows.Forms.PictureBox()
        Me.HealthBar = New System.Windows.Forms.ProgressBar()
        Me.levelwonlabel = New System.Windows.Forms.Label()
        Me.retryButton = New System.Windows.Forms.Button()
        Me.game_over_text = New System.Windows.Forms.Label()
        Me.laser16 = New System.Windows.Forms.PictureBox()
        Me.laser17 = New System.Windows.Forms.PictureBox()
        Me.laser18 = New System.Windows.Forms.PictureBox()
        Me.laser19 = New System.Windows.Forms.PictureBox()
        Me.laser20 = New System.Windows.Forms.PictureBox()
        Me.laser21 = New System.Windows.Forms.PictureBox()
        Me.laser9 = New System.Windows.Forms.PictureBox()
        Me.laser10 = New System.Windows.Forms.PictureBox()
        Me.laser11 = New System.Windows.Forms.PictureBox()
        Me.laser12 = New System.Windows.Forms.PictureBox()
        Me.laser13 = New System.Windows.Forms.PictureBox()
        Me.laser14 = New System.Windows.Forms.PictureBox()
        Me.laser15 = New System.Windows.Forms.PictureBox()
        Me.laser3 = New System.Windows.Forms.PictureBox()
        Me.laser5 = New System.Windows.Forms.PictureBox()
        Me.laser1 = New System.Windows.Forms.PictureBox()
        Me.levellabel = New System.Windows.Forms.Label()
        Me.laser8 = New System.Windows.Forms.PictureBox()
        Me.Alien_100_1 = New System.Windows.Forms.PictureBox()
        Me.laser6 = New System.Windows.Forms.PictureBox()
        Me.laser7 = New System.Windows.Forms.PictureBox()
        Me.laser4 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_1 = New System.Windows.Forms.PictureBox()
        Me.laser2 = New System.Windows.Forms.PictureBox()
        Me.restart_shot = New System.Windows.Forms.PictureBox()
        Me.Missile = New System.Windows.Forms.PictureBox()
        Me.Alien_100_7 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_8 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_3 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_4 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_5 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_6 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_7 = New System.Windows.Forms.PictureBox()
        Me.Alien_300_2 = New System.Windows.Forms.PictureBox()
        Me.Alien_500_6 = New System.Windows.Forms.PictureBox()
        Me.Alien_500_4 = New System.Windows.Forms.PictureBox()
        Me.Alien_500_2 = New System.Windows.Forms.PictureBox()
        Me.Alien_100_6 = New System.Windows.Forms.PictureBox()
        Me.Alien_100_2 = New System.Windows.Forms.PictureBox()
        Me.Alien_100_3 = New System.Windows.Forms.PictureBox()
        Me.Alien_100_4 = New System.Windows.Forms.PictureBox()
        Me.Alien_100_5 = New System.Windows.Forms.PictureBox()
        Me.Alien_500_5 = New System.Windows.Forms.PictureBox()
        Me.Alien_500_3 = New System.Windows.Forms.PictureBox()
        Me.Alien_500_1 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.versionLabel = New System.Windows.Forms.LinkLabel()
        Me.endlessText = New System.Windows.Forms.Label()
        Me.standardText = New System.Windows.Forms.Label()
        Me.endlessButton = New System.Windows.Forms.Button()
        Me.standardButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.HelpPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ThirdAlien = New System.Windows.Forms.PictureBox()
        Me.SecondAlien = New System.Windows.Forms.PictureBox()
        Me.FirstAlien = New System.Windows.Forms.PictureBox()
        Me.BackToMainMenu = New System.Windows.Forms.Button()
        Me.Instructions = New System.Windows.Forms.Label()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.MainMenu.SuspendLayout()
        CType(Me.sound_off_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sound_on_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameMain.SuspendLayout()
        Me.scoreboardPanel.SuspendLayout()
        Me.TimeSurvived.SuspendLayout()
        CType(Me.healthup_text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missileup_text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missileup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missileup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.healthup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.healthup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.healthup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_100_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restart_shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Missile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_100_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_300_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_500_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_500_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_500_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_100_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_100_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_100_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_100_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_100_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_500_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_500_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien_500_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HelpPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThirdAlien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondAlien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstAlien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movement
        '
        Me.Movement.Interval = 10
        '
        'ExplosionTimer
        '
        '
        'scoreboardTimer
        '
        Me.scoreboardTimer.Interval = 2500
        '
        'healthBarTimer
        '
        Me.healthBarTimer.Interval = 300
        '
        'missileSpeedTimer
        '
        Me.missileSpeedTimer.Interval = 5000
        '
        'powerupTextTimer
        '
        Me.powerupTextTimer.Interval = 1100
        '
        'countdownTimer
        '
        Me.countdownTimer.Interval = 3100
        '
        'TwoSecTimer
        '
        Me.TwoSecTimer.Interval = 2000
        '
        'OneSecTimer
        '
        Me.OneSecTimer.Interval = 1000
        '
        'ThreeSecTimer
        '
        Me.ThreeSecTimer.Interval = 3000
        '
        'TimeElapsedTimer
        '
        Me.TimeElapsedTimer.Interval = 1000
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.Transparent
        Me.MainMenu.BackgroundImage = CType(resources.GetObject("MainMenu.BackgroundImage"), System.Drawing.Image)
        Me.MainMenu.Controls.Add(Me.sound_off_button)
        Me.MainMenu.Controls.Add(Me.sound_on_button)
        Me.MainMenu.Controls.Add(Me.GameMain)
        Me.MainMenu.Controls.Add(Me.versionLabel)
        Me.MainMenu.Controls.Add(Me.endlessText)
        Me.MainMenu.Controls.Add(Me.standardText)
        Me.MainMenu.Controls.Add(Me.endlessButton)
        Me.MainMenu.Controls.Add(Me.standardButton)
        Me.MainMenu.Controls.Add(Me.QuitButton)
        Me.MainMenu.Controls.Add(Me.HelpPanel)
        Me.MainMenu.Controls.Add(Me.HelpButton)
        Me.MainMenu.Controls.Add(Me.PlayButton)
        Me.MainMenu.Controls.Add(Me.Title)
        Me.MainMenu.Location = New System.Drawing.Point(1, 1)
        Me.MainMenu.MaximumSize = New System.Drawing.Size(1373, 814)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1373, 814)
        Me.MainMenu.TabIndex = 0
        '
        'sound_off_button
        '
        Me.sound_off_button.Image = Global.Deep_Space_Debacle.My.Resources.Resources.sound_off
        Me.sound_off_button.Location = New System.Drawing.Point(1257, 672)
        Me.sound_off_button.Name = "sound_off_button"
        Me.sound_off_button.Size = New System.Drawing.Size(100, 100)
        Me.sound_off_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sound_off_button.TabIndex = 12
        Me.sound_off_button.TabStop = False
        Me.sound_off_button.Visible = False
        '
        'sound_on_button
        '
        Me.sound_on_button.Image = Global.Deep_Space_Debacle.My.Resources.Resources.sound_on
        Me.sound_on_button.Location = New System.Drawing.Point(1257, 674)
        Me.sound_on_button.Name = "sound_on_button"
        Me.sound_on_button.Size = New System.Drawing.Size(100, 100)
        Me.sound_on_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sound_on_button.TabIndex = 11
        Me.sound_on_button.TabStop = False
        '
        'GameMain
        '
        Me.GameMain.BackColor = System.Drawing.Color.Black
        Me.GameMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameMain.Controls.Add(Me.scoreboardPanel)
        Me.GameMain.Controls.Add(Me.countdownLabel)
        Me.GameMain.Controls.Add(Me.healthup_text)
        Me.GameMain.Controls.Add(Me.missileup_text)
        Me.GameMain.Controls.Add(Me.missileup2)
        Me.GameMain.Controls.Add(Me.missileup1)
        Me.GameMain.Controls.Add(Me.healthup3)
        Me.GameMain.Controls.Add(Me.healthup2)
        Me.GameMain.Controls.Add(Me.healthup1)
        Me.GameMain.Controls.Add(Me.HealthBar)
        Me.GameMain.Controls.Add(Me.levelwonlabel)
        Me.GameMain.Controls.Add(Me.retryButton)
        Me.GameMain.Controls.Add(Me.game_over_text)
        Me.GameMain.Controls.Add(Me.laser16)
        Me.GameMain.Controls.Add(Me.laser17)
        Me.GameMain.Controls.Add(Me.laser18)
        Me.GameMain.Controls.Add(Me.laser19)
        Me.GameMain.Controls.Add(Me.laser20)
        Me.GameMain.Controls.Add(Me.laser21)
        Me.GameMain.Controls.Add(Me.laser9)
        Me.GameMain.Controls.Add(Me.laser10)
        Me.GameMain.Controls.Add(Me.laser11)
        Me.GameMain.Controls.Add(Me.laser12)
        Me.GameMain.Controls.Add(Me.laser13)
        Me.GameMain.Controls.Add(Me.laser14)
        Me.GameMain.Controls.Add(Me.laser15)
        Me.GameMain.Controls.Add(Me.laser3)
        Me.GameMain.Controls.Add(Me.laser5)
        Me.GameMain.Controls.Add(Me.laser1)
        Me.GameMain.Controls.Add(Me.levellabel)
        Me.GameMain.Controls.Add(Me.laser8)
        Me.GameMain.Controls.Add(Me.Alien_100_1)
        Me.GameMain.Controls.Add(Me.laser6)
        Me.GameMain.Controls.Add(Me.laser7)
        Me.GameMain.Controls.Add(Me.laser4)
        Me.GameMain.Controls.Add(Me.Alien_300_1)
        Me.GameMain.Controls.Add(Me.laser2)
        Me.GameMain.Controls.Add(Me.restart_shot)
        Me.GameMain.Controls.Add(Me.Missile)
        Me.GameMain.Controls.Add(Me.Alien_100_7)
        Me.GameMain.Controls.Add(Me.Alien_300_8)
        Me.GameMain.Controls.Add(Me.Alien_300_3)
        Me.GameMain.Controls.Add(Me.Alien_300_4)
        Me.GameMain.Controls.Add(Me.Alien_300_5)
        Me.GameMain.Controls.Add(Me.Alien_300_6)
        Me.GameMain.Controls.Add(Me.Alien_300_7)
        Me.GameMain.Controls.Add(Me.Alien_300_2)
        Me.GameMain.Controls.Add(Me.Alien_500_6)
        Me.GameMain.Controls.Add(Me.Alien_500_4)
        Me.GameMain.Controls.Add(Me.Alien_500_2)
        Me.GameMain.Controls.Add(Me.Alien_100_6)
        Me.GameMain.Controls.Add(Me.Alien_100_2)
        Me.GameMain.Controls.Add(Me.Alien_100_3)
        Me.GameMain.Controls.Add(Me.Alien_100_4)
        Me.GameMain.Controls.Add(Me.Alien_100_5)
        Me.GameMain.Controls.Add(Me.Alien_500_5)
        Me.GameMain.Controls.Add(Me.Alien_500_3)
        Me.GameMain.Controls.Add(Me.Alien_500_1)
        Me.GameMain.Controls.Add(Me.Player)
        Me.GameMain.Location = New System.Drawing.Point(0, 0)
        Me.GameMain.Name = "GameMain"
        Me.GameMain.Size = New System.Drawing.Size(1367, 775)
        Me.GameMain.TabIndex = 1
        Me.GameMain.Visible = False
        '
        'scoreboardPanel
        '
        Me.scoreboardPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.scoreboardPanel.Controls.Add(Me.TimeSurvived)
        Me.scoreboardPanel.Controls.Add(Me.badScore)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore8_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore7_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore6_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore5_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore4_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore3_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore2_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore1_score)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore8)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore7)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore6)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore5)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore4)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore3)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore2)
        Me.scoreboardPanel.Controls.Add(Me.gamerScore1)
        Me.scoreboardPanel.Controls.Add(Me.nameEntry)
        Me.scoreboardPanel.Controls.Add(Me.scoreboardPlayerNameLabel)
        Me.scoreboardPanel.Controls.Add(Me.scorebaordText)
        Me.scoreboardPanel.Location = New System.Drawing.Point(8, 8)
        Me.scoreboardPanel.Name = "scoreboardPanel"
        Me.scoreboardPanel.Size = New System.Drawing.Size(324, 751)
        Me.scoreboardPanel.TabIndex = 59
        Me.scoreboardPanel.Visible = False
        '
        'TimeSurvived
        '
        Me.TimeSurvived.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TimeSurvived.Controls.Add(Me.colon)
        Me.TimeSurvived.Controls.Add(Me.secondsLabel)
        Me.TimeSurvived.Controls.Add(Me.minutesLabel)
        Me.TimeSurvived.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeSurvived.ForeColor = System.Drawing.SystemColors.Control
        Me.TimeSurvived.Location = New System.Drawing.Point(11, 707)
        Me.TimeSurvived.Name = "TimeSurvived"
        Me.TimeSurvived.Size = New System.Drawing.Size(167, 41)
        Me.TimeSurvived.TabIndex = 72
        Me.TimeSurvived.TabStop = False
        Me.TimeSurvived.Text = "Time Survived"
        '
        'colon
        '
        Me.colon.AutoSize = True
        Me.colon.Location = New System.Drawing.Point(39, 18)
        Me.colon.Name = "colon"
        Me.colon.Size = New System.Drawing.Size(18, 17)
        Me.colon.TabIndex = 2
        Me.colon.Text = ":"
        '
        'secondsLabel
        '
        Me.secondsLabel.AutoSize = True
        Me.secondsLabel.Location = New System.Drawing.Point(52, 18)
        Me.secondsLabel.Name = "secondsLabel"
        Me.secondsLabel.Size = New System.Drawing.Size(28, 17)
        Me.secondsLabel.TabIndex = 1
        Me.secondsLabel.Text = "00"
        '
        'minutesLabel
        '
        Me.minutesLabel.AutoSize = True
        Me.minutesLabel.Location = New System.Drawing.Point(17, 18)
        Me.minutesLabel.Name = "minutesLabel"
        Me.minutesLabel.Size = New System.Drawing.Size(28, 17)
        Me.minutesLabel.TabIndex = 0
        Me.minutesLabel.Text = "00"
        '
        'badScore
        '
        Me.badScore.AutoSize = True
        Me.badScore.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badScore.ForeColor = System.Drawing.SystemColors.Control
        Me.badScore.Location = New System.Drawing.Point(1, 580)
        Me.badScore.Name = "badScore"
        Me.badScore.Size = New System.Drawing.Size(296, 46)
        Me.badScore.TabIndex = 71
        Me.badScore.Text = "You got less than 2. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thats pretty pathetic "
        Me.badScore.Visible = False
        '
        'gamerScore8_score
        '
        Me.gamerScore8_score.AutoSize = True
        Me.gamerScore8_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore8_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore8_score.Location = New System.Drawing.Point(275, 536)
        Me.gamerScore8_score.Name = "gamerScore8_score"
        Me.gamerScore8_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore8_score.TabIndex = 70
        Me.gamerScore8_score.Text = "0"
        '
        'gamerScore7_score
        '
        Me.gamerScore7_score.AutoSize = True
        Me.gamerScore7_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore7_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore7_score.Location = New System.Drawing.Point(275, 473)
        Me.gamerScore7_score.Name = "gamerScore7_score"
        Me.gamerScore7_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore7_score.TabIndex = 69
        Me.gamerScore7_score.Text = "0"
        '
        'gamerScore6_score
        '
        Me.gamerScore6_score.AutoSize = True
        Me.gamerScore6_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore6_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore6_score.Location = New System.Drawing.Point(275, 411)
        Me.gamerScore6_score.Name = "gamerScore6_score"
        Me.gamerScore6_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore6_score.TabIndex = 68
        Me.gamerScore6_score.Text = "0"
        '
        'gamerScore5_score
        '
        Me.gamerScore5_score.AutoSize = True
        Me.gamerScore5_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore5_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore5_score.Location = New System.Drawing.Point(275, 348)
        Me.gamerScore5_score.Name = "gamerScore5_score"
        Me.gamerScore5_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore5_score.TabIndex = 67
        Me.gamerScore5_score.Text = "0"
        '
        'gamerScore4_score
        '
        Me.gamerScore4_score.AutoSize = True
        Me.gamerScore4_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore4_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore4_score.Location = New System.Drawing.Point(275, 288)
        Me.gamerScore4_score.Name = "gamerScore4_score"
        Me.gamerScore4_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore4_score.TabIndex = 66
        Me.gamerScore4_score.Text = "0"
        '
        'gamerScore3_score
        '
        Me.gamerScore3_score.AutoSize = True
        Me.gamerScore3_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore3_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore3_score.Location = New System.Drawing.Point(275, 225)
        Me.gamerScore3_score.Name = "gamerScore3_score"
        Me.gamerScore3_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore3_score.TabIndex = 65
        Me.gamerScore3_score.Text = "0"
        '
        'gamerScore2_score
        '
        Me.gamerScore2_score.AutoSize = True
        Me.gamerScore2_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore2_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore2_score.Location = New System.Drawing.Point(275, 163)
        Me.gamerScore2_score.Name = "gamerScore2_score"
        Me.gamerScore2_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore2_score.TabIndex = 64
        Me.gamerScore2_score.Text = "0"
        '
        'gamerScore1_score
        '
        Me.gamerScore1_score.AutoSize = True
        Me.gamerScore1_score.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore1_score.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gamerScore1_score.Location = New System.Drawing.Point(275, 100)
        Me.gamerScore1_score.Name = "gamerScore1_score"
        Me.gamerScore1_score.Size = New System.Drawing.Size(23, 23)
        Me.gamerScore1_score.TabIndex = 63
        Me.gamerScore1_score.Text = "0"
        '
        'gamerScore8
        '
        Me.gamerScore8.AutoSize = True
        Me.gamerScore8.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore8.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore8.Location = New System.Drawing.Point(3, 531)
        Me.gamerScore8.Name = "gamerScore8"
        Me.gamerScore8.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore8.TabIndex = 62
        Me.gamerScore8.Text = "Player 8 Score"
        '
        'gamerScore7
        '
        Me.gamerScore7.AutoSize = True
        Me.gamerScore7.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore7.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore7.Location = New System.Drawing.Point(6, 468)
        Me.gamerScore7.Name = "gamerScore7"
        Me.gamerScore7.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore7.TabIndex = 61
        Me.gamerScore7.Text = "Player 7 Score"
        '
        'gamerScore6
        '
        Me.gamerScore6.AutoSize = True
        Me.gamerScore6.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore6.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore6.Location = New System.Drawing.Point(3, 406)
        Me.gamerScore6.Name = "gamerScore6"
        Me.gamerScore6.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore6.TabIndex = 60
        Me.gamerScore6.Text = "Player 6 Score"
        '
        'gamerScore5
        '
        Me.gamerScore5.AutoSize = True
        Me.gamerScore5.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore5.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore5.Location = New System.Drawing.Point(6, 343)
        Me.gamerScore5.Name = "gamerScore5"
        Me.gamerScore5.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore5.TabIndex = 59
        Me.gamerScore5.Text = "Player 5 Score"
        '
        'gamerScore4
        '
        Me.gamerScore4.AutoSize = True
        Me.gamerScore4.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore4.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore4.Location = New System.Drawing.Point(3, 283)
        Me.gamerScore4.Name = "gamerScore4"
        Me.gamerScore4.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore4.TabIndex = 58
        Me.gamerScore4.Text = "Player 4 Score"
        '
        'gamerScore3
        '
        Me.gamerScore3.AutoSize = True
        Me.gamerScore3.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore3.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore3.Location = New System.Drawing.Point(6, 220)
        Me.gamerScore3.Name = "gamerScore3"
        Me.gamerScore3.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore3.TabIndex = 57
        Me.gamerScore3.Text = "Player 3 Score"
        '
        'gamerScore2
        '
        Me.gamerScore2.AutoSize = True
        Me.gamerScore2.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore2.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore2.Location = New System.Drawing.Point(3, 158)
        Me.gamerScore2.Name = "gamerScore2"
        Me.gamerScore2.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore2.TabIndex = 56
        Me.gamerScore2.Text = "Player 2 Score"
        '
        'gamerScore1
        '
        Me.gamerScore1.AutoSize = True
        Me.gamerScore1.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamerScore1.ForeColor = System.Drawing.SystemColors.Control
        Me.gamerScore1.Location = New System.Drawing.Point(6, 95)
        Me.gamerScore1.Name = "gamerScore1"
        Me.gamerScore1.Size = New System.Drawing.Size(237, 29)
        Me.gamerScore1.TabIndex = 55
        Me.gamerScore1.Text = "Player 1 Score"
        '
        'nameEntry
        '
        Me.nameEntry.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameEntry.ForeColor = System.Drawing.SystemColors.InfoText
        Me.nameEntry.Location = New System.Drawing.Point(8, 674)
        Me.nameEntry.Name = "nameEntry"
        Me.nameEntry.Size = New System.Drawing.Size(257, 27)
        Me.nameEntry.TabIndex = 54
        '
        'scoreboardPlayerNameLabel
        '
        Me.scoreboardPlayerNameLabel.AutoSize = True
        Me.scoreboardPlayerNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.scoreboardPlayerNameLabel.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreboardPlayerNameLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.scoreboardPlayerNameLabel.Location = New System.Drawing.Point(6, 641)
        Me.scoreboardPlayerNameLabel.Name = "scoreboardPlayerNameLabel"
        Me.scoreboardPlayerNameLabel.Size = New System.Drawing.Size(211, 30)
        Me.scoreboardPlayerNameLabel.TabIndex = 53
        Me.scoreboardPlayerNameLabel.Text = "Enter name:"
        '
        'scorebaordText
        '
        Me.scorebaordText.AutoSize = True
        Me.scorebaordText.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scorebaordText.ForeColor = System.Drawing.SystemColors.Control
        Me.scorebaordText.Location = New System.Drawing.Point(1, 3)
        Me.scorebaordText.Name = "scorebaordText"
        Me.scorebaordText.Size = New System.Drawing.Size(237, 39)
        Me.scorebaordText.TabIndex = 52
        Me.scorebaordText.Text = "Scoreboard"
        '
        'countdownLabel
        '
        Me.countdownLabel.AutoSize = True
        Me.countdownLabel.BackColor = System.Drawing.Color.Transparent
        Me.countdownLabel.Font = New System.Drawing.Font("OCR A Extended", 90.0!)
        Me.countdownLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.countdownLabel.Location = New System.Drawing.Point(612, 364)
        Me.countdownLabel.Name = "countdownLabel"
        Me.countdownLabel.Size = New System.Drawing.Size(124, 123)
        Me.countdownLabel.TabIndex = 1
        Me.countdownLabel.Text = "3"
        '
        'healthup_text
        '
        Me.healthup_text.BackColor = System.Drawing.Color.Transparent
        Me.healthup_text.Image = Global.Deep_Space_Debacle.My.Resources.Resources.health_text_2
        Me.healthup_text.Location = New System.Drawing.Point(344, 436)
        Me.healthup_text.Name = "healthup_text"
        Me.healthup_text.Size = New System.Drawing.Size(192, 208)
        Me.healthup_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.healthup_text.TabIndex = 69
        Me.healthup_text.TabStop = False
        Me.healthup_text.Visible = False
        '
        'missileup_text
        '
        Me.missileup_text.BackColor = System.Drawing.Color.Transparent
        Me.missileup_text.Image = Global.Deep_Space_Debacle.My.Resources.Resources.missile_text_2
        Me.missileup_text.Location = New System.Drawing.Point(881, 436)
        Me.missileup_text.Name = "missileup_text"
        Me.missileup_text.Size = New System.Drawing.Size(192, 208)
        Me.missileup_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.missileup_text.TabIndex = 68
        Me.missileup_text.TabStop = False
        Me.missileup_text.Visible = False
        '
        'missileup2
        '
        Me.missileup2.BackColor = System.Drawing.Color.Transparent
        Me.missileup2.Image = Global.Deep_Space_Debacle.My.Resources.Resources.missile_up
        Me.missileup2.Location = New System.Drawing.Point(828, 17)
        Me.missileup2.Name = "missileup2"
        Me.missileup2.Size = New System.Drawing.Size(86, 69)
        Me.missileup2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.missileup2.TabIndex = 67
        Me.missileup2.TabStop = False
        Me.missileup2.Visible = False
        '
        'missileup1
        '
        Me.missileup1.BackColor = System.Drawing.Color.Transparent
        Me.missileup1.Image = Global.Deep_Space_Debacle.My.Resources.Resources.missile_up
        Me.missileup1.Location = New System.Drawing.Point(344, 14)
        Me.missileup1.Name = "missileup1"
        Me.missileup1.Size = New System.Drawing.Size(86, 69)
        Me.missileup1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.missileup1.TabIndex = 66
        Me.missileup1.TabStop = False
        Me.missileup1.Visible = False
        '
        'healthup3
        '
        Me.healthup3.BackColor = System.Drawing.Color.Transparent
        Me.healthup3.Image = CType(resources.GetObject("healthup3.Image"), System.Drawing.Image)
        Me.healthup3.Location = New System.Drawing.Point(106, 14)
        Me.healthup3.Name = "healthup3"
        Me.healthup3.Size = New System.Drawing.Size(80, 69)
        Me.healthup3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.healthup3.TabIndex = 65
        Me.healthup3.TabStop = False
        Me.healthup3.Visible = False
        '
        'healthup2
        '
        Me.healthup2.BackColor = System.Drawing.Color.Transparent
        Me.healthup2.Image = CType(resources.GetObject("healthup2.Image"), System.Drawing.Image)
        Me.healthup2.Location = New System.Drawing.Point(642, 14)
        Me.healthup2.Name = "healthup2"
        Me.healthup2.Size = New System.Drawing.Size(80, 69)
        Me.healthup2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.healthup2.TabIndex = 64
        Me.healthup2.TabStop = False
        Me.healthup2.Visible = False
        '
        'healthup1
        '
        Me.healthup1.BackColor = System.Drawing.Color.Transparent
        Me.healthup1.Image = CType(resources.GetObject("healthup1.Image"), System.Drawing.Image)
        Me.healthup1.Location = New System.Drawing.Point(1090, 14)
        Me.healthup1.Name = "healthup1"
        Me.healthup1.Size = New System.Drawing.Size(80, 69)
        Me.healthup1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.healthup1.TabIndex = 63
        Me.healthup1.TabStop = False
        Me.healthup1.Visible = False
        '
        'HealthBar
        '
        Me.HealthBar.Location = New System.Drawing.Point(0, 747)
        Me.HealthBar.Maximum = 40
        Me.HealthBar.Name = "HealthBar"
        Me.HealthBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HealthBar.Size = New System.Drawing.Size(228, 27)
        Me.HealthBar.TabIndex = 62
        Me.HealthBar.Value = 40
        '
        'levelwonlabel
        '
        Me.levelwonlabel.AutoSize = True
        Me.levelwonlabel.BackColor = System.Drawing.Color.Transparent
        Me.levelwonlabel.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelwonlabel.ForeColor = System.Drawing.SystemColors.Control
        Me.levelwonlabel.Location = New System.Drawing.Point(479, 148)
        Me.levelwonlabel.Name = "levelwonlabel"
        Me.levelwonlabel.Size = New System.Drawing.Size(404, 76)
        Me.levelwonlabel.TabIndex = 61
        Me.levelwonlabel.Text = "Well Done!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.levelwonlabel.Visible = False
        '
        'retryButton
        '
        Me.retryButton.BackColor = System.Drawing.Color.Transparent
        Me.retryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.retryButton.FlatAppearance.BorderSize = 0
        Me.retryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retryButton.Image = Global.Deep_Space_Debacle.My.Resources.Resources.retry_button
        Me.retryButton.Location = New System.Drawing.Point(1150, 541)
        Me.retryButton.Margin = New System.Windows.Forms.Padding(0)
        Me.retryButton.Name = "retryButton"
        Me.retryButton.Size = New System.Drawing.Size(209, 103)
        Me.retryButton.TabIndex = 60
        Me.retryButton.UseVisualStyleBackColor = False
        Me.retryButton.Visible = False
        '
        'game_over_text
        '
        Me.game_over_text.AutoSize = True
        Me.game_over_text.BackColor = System.Drawing.Color.Transparent
        Me.game_over_text.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.game_over_text.ForeColor = System.Drawing.SystemColors.Control
        Me.game_over_text.Location = New System.Drawing.Point(479, 224)
        Me.game_over_text.Name = "game_over_text"
        Me.game_over_text.Size = New System.Drawing.Size(412, 76)
        Me.game_over_text.TabIndex = 34
        Me.game_over_text.Text = "GAME OVER!"
        Me.game_over_text.Visible = False
        '
        'laser16
        '
        Me.laser16.BackColor = System.Drawing.Color.Transparent
        Me.laser16.Image = CType(resources.GetObject("laser16.Image"), System.Drawing.Image)
        Me.laser16.Location = New System.Drawing.Point(285, 167)
        Me.laser16.Name = "laser16"
        Me.laser16.Size = New System.Drawing.Size(40, 79)
        Me.laser16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser16.TabIndex = 57
        Me.laser16.TabStop = False
        Me.laser16.Visible = False
        '
        'laser17
        '
        Me.laser17.BackColor = System.Drawing.Color.Transparent
        Me.laser17.Image = CType(resources.GetObject("laser17.Image"), System.Drawing.Image)
        Me.laser17.Location = New System.Drawing.Point(433, 167)
        Me.laser17.Name = "laser17"
        Me.laser17.Size = New System.Drawing.Size(40, 79)
        Me.laser17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser17.TabIndex = 56
        Me.laser17.TabStop = False
        Me.laser17.Visible = False
        '
        'laser18
        '
        Me.laser18.BackColor = System.Drawing.Color.Transparent
        Me.laser18.Image = CType(resources.GetObject("laser18.Image"), System.Drawing.Image)
        Me.laser18.Location = New System.Drawing.Point(590, 167)
        Me.laser18.Name = "laser18"
        Me.laser18.Size = New System.Drawing.Size(40, 79)
        Me.laser18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser18.TabIndex = 55
        Me.laser18.TabStop = False
        Me.laser18.Visible = False
        '
        'laser19
        '
        Me.laser19.BackColor = System.Drawing.Color.Transparent
        Me.laser19.Image = CType(resources.GetObject("laser19.Image"), System.Drawing.Image)
        Me.laser19.Location = New System.Drawing.Point(740, 167)
        Me.laser19.Name = "laser19"
        Me.laser19.Size = New System.Drawing.Size(40, 79)
        Me.laser19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser19.TabIndex = 54
        Me.laser19.TabStop = False
        Me.laser19.Visible = False
        '
        'laser20
        '
        Me.laser20.BackColor = System.Drawing.Color.Transparent
        Me.laser20.Image = CType(resources.GetObject("laser20.Image"), System.Drawing.Image)
        Me.laser20.Location = New System.Drawing.Point(873, 167)
        Me.laser20.Name = "laser20"
        Me.laser20.Size = New System.Drawing.Size(40, 79)
        Me.laser20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser20.TabIndex = 53
        Me.laser20.TabStop = False
        Me.laser20.Visible = False
        '
        'laser21
        '
        Me.laser21.BackColor = System.Drawing.Color.Transparent
        Me.laser21.Image = CType(resources.GetObject("laser21.Image"), System.Drawing.Image)
        Me.laser21.Location = New System.Drawing.Point(1017, 167)
        Me.laser21.Name = "laser21"
        Me.laser21.Size = New System.Drawing.Size(40, 79)
        Me.laser21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser21.TabIndex = 52
        Me.laser21.TabStop = False
        Me.laser21.Visible = False
        '
        'laser9
        '
        Me.laser9.BackColor = System.Drawing.Color.Transparent
        Me.laser9.Image = CType(resources.GetObject("laser9.Image"), System.Drawing.Image)
        Me.laser9.Location = New System.Drawing.Point(285, 261)
        Me.laser9.Name = "laser9"
        Me.laser9.Size = New System.Drawing.Size(40, 79)
        Me.laser9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser9.TabIndex = 50
        Me.laser9.TabStop = False
        Me.laser9.Visible = False
        '
        'laser10
        '
        Me.laser10.BackColor = System.Drawing.Color.Transparent
        Me.laser10.Image = CType(resources.GetObject("laser10.Image"), System.Drawing.Image)
        Me.laser10.Location = New System.Drawing.Point(421, 261)
        Me.laser10.Name = "laser10"
        Me.laser10.Size = New System.Drawing.Size(40, 79)
        Me.laser10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser10.TabIndex = 49
        Me.laser10.TabStop = False
        Me.laser10.Visible = False
        '
        'laser11
        '
        Me.laser11.BackColor = System.Drawing.Color.Transparent
        Me.laser11.Image = CType(resources.GetObject("laser11.Image"), System.Drawing.Image)
        Me.laser11.Location = New System.Drawing.Point(570, 261)
        Me.laser11.Name = "laser11"
        Me.laser11.Size = New System.Drawing.Size(40, 79)
        Me.laser11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser11.TabIndex = 48
        Me.laser11.TabStop = False
        Me.laser11.Visible = False
        '
        'laser12
        '
        Me.laser12.BackColor = System.Drawing.Color.Transparent
        Me.laser12.Image = CType(resources.GetObject("laser12.Image"), System.Drawing.Image)
        Me.laser12.Location = New System.Drawing.Point(716, 261)
        Me.laser12.Name = "laser12"
        Me.laser12.Size = New System.Drawing.Size(40, 79)
        Me.laser12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser12.TabIndex = 47
        Me.laser12.TabStop = False
        Me.laser12.Visible = False
        '
        'laser13
        '
        Me.laser13.BackColor = System.Drawing.Color.Transparent
        Me.laser13.Image = CType(resources.GetObject("laser13.Image"), System.Drawing.Image)
        Me.laser13.Location = New System.Drawing.Point(873, 261)
        Me.laser13.Name = "laser13"
        Me.laser13.Size = New System.Drawing.Size(40, 79)
        Me.laser13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser13.TabIndex = 46
        Me.laser13.TabStop = False
        Me.laser13.Visible = False
        '
        'laser14
        '
        Me.laser14.BackColor = System.Drawing.Color.Transparent
        Me.laser14.Image = CType(resources.GetObject("laser14.Image"), System.Drawing.Image)
        Me.laser14.Location = New System.Drawing.Point(1008, 261)
        Me.laser14.Name = "laser14"
        Me.laser14.Size = New System.Drawing.Size(40, 79)
        Me.laser14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser14.TabIndex = 45
        Me.laser14.TabStop = False
        Me.laser14.Visible = False
        '
        'laser15
        '
        Me.laser15.BackColor = System.Drawing.Color.Transparent
        Me.laser15.Image = CType(resources.GetObject("laser15.Image"), System.Drawing.Image)
        Me.laser15.Location = New System.Drawing.Point(1150, 261)
        Me.laser15.Name = "laser15"
        Me.laser15.Size = New System.Drawing.Size(40, 79)
        Me.laser15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser15.TabIndex = 44
        Me.laser15.TabStop = False
        Me.laser15.Visible = False
        '
        'laser3
        '
        Me.laser3.BackColor = System.Drawing.Color.Transparent
        Me.laser3.Image = CType(resources.GetObject("laser3.Image"), System.Drawing.Image)
        Me.laser3.Location = New System.Drawing.Point(479, 354)
        Me.laser3.Name = "laser3"
        Me.laser3.Size = New System.Drawing.Size(40, 79)
        Me.laser3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser3.TabIndex = 43
        Me.laser3.TabStop = False
        Me.laser3.Visible = False
        '
        'laser5
        '
        Me.laser5.BackColor = System.Drawing.Color.Transparent
        Me.laser5.Image = CType(resources.GetObject("laser5.Image"), System.Drawing.Image)
        Me.laser5.Location = New System.Drawing.Point(774, 354)
        Me.laser5.Name = "laser5"
        Me.laser5.Size = New System.Drawing.Size(40, 79)
        Me.laser5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser5.TabIndex = 42
        Me.laser5.TabStop = False
        Me.laser5.Visible = False
        '
        'laser1
        '
        Me.laser1.BackColor = System.Drawing.Color.Transparent
        Me.laser1.Image = CType(resources.GetObject("laser1.Image"), System.Drawing.Image)
        Me.laser1.Location = New System.Drawing.Point(188, 354)
        Me.laser1.Name = "laser1"
        Me.laser1.Size = New System.Drawing.Size(40, 79)
        Me.laser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser1.TabIndex = 37
        Me.laser1.TabStop = False
        Me.laser1.Visible = False
        '
        'levellabel
        '
        Me.levellabel.BackColor = System.Drawing.Color.Transparent
        Me.levellabel.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levellabel.ForeColor = System.Drawing.SystemColors.Control
        Me.levellabel.Location = New System.Drawing.Point(1220, 1)
        Me.levellabel.Name = "levellabel"
        Me.levellabel.Size = New System.Drawing.Size(139, 32)
        Me.levellabel.TabIndex = 36
        Me.levellabel.Text = "level 1"
        '
        'laser8
        '
        Me.laser8.BackColor = System.Drawing.Color.Transparent
        Me.laser8.Image = CType(resources.GetObject("laser8.Image"), System.Drawing.Image)
        Me.laser8.Location = New System.Drawing.Point(146, 251)
        Me.laser8.Name = "laser8"
        Me.laser8.Size = New System.Drawing.Size(40, 79)
        Me.laser8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser8.TabIndex = 51
        Me.laser8.TabStop = False
        Me.laser8.Visible = False
        '
        'Alien_100_1
        '
        Me.Alien_100_1.BackColor = System.Drawing.Color.Transparent
        Me.Alien_100_1.Image = CType(resources.GetObject("Alien_100_1.Image"), System.Drawing.Image)
        Me.Alien_100_1.Location = New System.Drawing.Point(162, 278)
        Me.Alien_100_1.Name = "Alien_100_1"
        Me.Alien_100_1.Size = New System.Drawing.Size(90, 70)
        Me.Alien_100_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_100_1.TabIndex = 11
        Me.Alien_100_1.TabStop = False
        '
        'laser6
        '
        Me.laser6.BackColor = System.Drawing.Color.Transparent
        Me.laser6.Image = CType(resources.GetObject("laser6.Image"), System.Drawing.Image)
        Me.laser6.Location = New System.Drawing.Point(930, 354)
        Me.laser6.Name = "laser6"
        Me.laser6.Size = New System.Drawing.Size(40, 79)
        Me.laser6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser6.TabIndex = 41
        Me.laser6.TabStop = False
        Me.laser6.Visible = False
        '
        'laser7
        '
        Me.laser7.BackColor = System.Drawing.Color.Transparent
        Me.laser7.Image = CType(resources.GetObject("laser7.Image"), System.Drawing.Image)
        Me.laser7.Location = New System.Drawing.Point(1079, 354)
        Me.laser7.Name = "laser7"
        Me.laser7.Size = New System.Drawing.Size(40, 79)
        Me.laser7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser7.TabIndex = 40
        Me.laser7.TabStop = False
        Me.laser7.Visible = False
        '
        'laser4
        '
        Me.laser4.BackColor = System.Drawing.Color.Transparent
        Me.laser4.Image = CType(resources.GetObject("laser4.Image"), System.Drawing.Image)
        Me.laser4.Location = New System.Drawing.Point(624, 354)
        Me.laser4.Name = "laser4"
        Me.laser4.Size = New System.Drawing.Size(40, 79)
        Me.laser4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser4.TabIndex = 39
        Me.laser4.TabStop = False
        Me.laser4.Visible = False
        '
        'Alien_300_1
        '
        Me.Alien_300_1.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_1.Image = CType(resources.GetObject("Alien_300_1.Image"), System.Drawing.Image)
        Me.Alien_300_1.Location = New System.Drawing.Point(123, 184)
        Me.Alien_300_1.Name = "Alien_300_1"
        Me.Alien_300_1.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_1.TabIndex = 6
        Me.Alien_300_1.TabStop = False
        '
        'laser2
        '
        Me.laser2.BackColor = System.Drawing.Color.Transparent
        Me.laser2.Image = CType(resources.GetObject("laser2.Image"), System.Drawing.Image)
        Me.laser2.Location = New System.Drawing.Point(330, 354)
        Me.laser2.Name = "laser2"
        Me.laser2.Size = New System.Drawing.Size(40, 79)
        Me.laser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser2.TabIndex = 38
        Me.laser2.TabStop = False
        Me.laser2.Visible = False
        '
        'restart_shot
        '
        Me.restart_shot.BackColor = System.Drawing.Color.Transparent
        Me.restart_shot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.restart_shot.Image = Global.Deep_Space_Debacle.My.Resources.Resources.missile
        Me.restart_shot.Location = New System.Drawing.Point(652, 569)
        Me.restart_shot.Name = "restart_shot"
        Me.restart_shot.Size = New System.Drawing.Size(32, 67)
        Me.restart_shot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.restart_shot.TabIndex = 32
        Me.restart_shot.TabStop = False
        Me.restart_shot.Visible = False
        '
        'Missile
        '
        Me.Missile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Missile.Image = Global.Deep_Space_Debacle.My.Resources.Resources.missile
        Me.Missile.Location = New System.Drawing.Point(652, 569)
        Me.Missile.Name = "Missile"
        Me.Missile.Size = New System.Drawing.Size(32, 67)
        Me.Missile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Missile.TabIndex = 31
        Me.Missile.TabStop = False
        Me.Missile.Visible = False
        '
        'Alien_100_7
        '
        Me.Alien_100_7.BackColor = System.Drawing.Color.Transparent
        Me.Alien_100_7.Image = CType(resources.GetObject("Alien_100_7.Image"), System.Drawing.Image)
        Me.Alien_100_7.Location = New System.Drawing.Point(1054, 278)
        Me.Alien_100_7.Name = "Alien_100_7"
        Me.Alien_100_7.Size = New System.Drawing.Size(90, 70)
        Me.Alien_100_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_100_7.TabIndex = 30
        Me.Alien_100_7.TabStop = False
        '
        'Alien_300_8
        '
        Me.Alien_300_8.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_8.Image = CType(resources.GetObject("Alien_300_8.Image"), System.Drawing.Image)
        Me.Alien_300_8.Location = New System.Drawing.Point(1128, 184)
        Me.Alien_300_8.Name = "Alien_300_8"
        Me.Alien_300_8.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_8.TabIndex = 27
        Me.Alien_300_8.TabStop = False
        '
        'Alien_300_3
        '
        Me.Alien_300_3.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_3.Image = CType(resources.GetObject("Alien_300_3.Image"), System.Drawing.Image)
        Me.Alien_300_3.Location = New System.Drawing.Point(403, 184)
        Me.Alien_300_3.Name = "Alien_300_3"
        Me.Alien_300_3.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_3.TabIndex = 26
        Me.Alien_300_3.TabStop = False
        '
        'Alien_300_4
        '
        Me.Alien_300_4.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_4.Image = CType(resources.GetObject("Alien_300_4.Image"), System.Drawing.Image)
        Me.Alien_300_4.Location = New System.Drawing.Point(547, 184)
        Me.Alien_300_4.Name = "Alien_300_4"
        Me.Alien_300_4.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_4.TabIndex = 25
        Me.Alien_300_4.TabStop = False
        '
        'Alien_300_5
        '
        Me.Alien_300_5.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_5.Image = CType(resources.GetObject("Alien_300_5.Image"), System.Drawing.Image)
        Me.Alien_300_5.Location = New System.Drawing.Point(697, 184)
        Me.Alien_300_5.Name = "Alien_300_5"
        Me.Alien_300_5.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_5.TabIndex = 24
        Me.Alien_300_5.TabStop = False
        '
        'Alien_300_6
        '
        Me.Alien_300_6.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_6.Image = CType(resources.GetObject("Alien_300_6.Image"), System.Drawing.Image)
        Me.Alien_300_6.Location = New System.Drawing.Point(848, 184)
        Me.Alien_300_6.Name = "Alien_300_6"
        Me.Alien_300_6.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_6.TabIndex = 23
        Me.Alien_300_6.TabStop = False
        '
        'Alien_300_7
        '
        Me.Alien_300_7.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_7.Image = CType(resources.GetObject("Alien_300_7.Image"), System.Drawing.Image)
        Me.Alien_300_7.Location = New System.Drawing.Point(990, 184)
        Me.Alien_300_7.Name = "Alien_300_7"
        Me.Alien_300_7.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_7.TabIndex = 22
        Me.Alien_300_7.TabStop = False
        '
        'Alien_300_2
        '
        Me.Alien_300_2.BackColor = System.Drawing.Color.Transparent
        Me.Alien_300_2.Image = CType(resources.GetObject("Alien_300_2.Image"), System.Drawing.Image)
        Me.Alien_300_2.Location = New System.Drawing.Point(260, 184)
        Me.Alien_300_2.Name = "Alien_300_2"
        Me.Alien_300_2.Size = New System.Drawing.Size(83, 71)
        Me.Alien_300_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_300_2.TabIndex = 21
        Me.Alien_300_2.TabStop = False
        '
        'Alien_500_6
        '
        Me.Alien_500_6.BackColor = System.Drawing.Color.Transparent
        Me.Alien_500_6.Image = CType(resources.GetObject("Alien_500_6.Image"), System.Drawing.Image)
        Me.Alien_500_6.Location = New System.Drawing.Point(1000, 82)
        Me.Alien_500_6.Name = "Alien_500_6"
        Me.Alien_500_6.Size = New System.Drawing.Size(73, 79)
        Me.Alien_500_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_500_6.TabIndex = 19
        Me.Alien_500_6.TabStop = False
        '
        'Alien_500_4
        '
        Me.Alien_500_4.BackColor = System.Drawing.Color.Transparent
        Me.Alien_500_4.Image = CType(resources.GetObject("Alien_500_4.Image"), System.Drawing.Image)
        Me.Alien_500_4.Location = New System.Drawing.Point(716, 82)
        Me.Alien_500_4.Name = "Alien_500_4"
        Me.Alien_500_4.Size = New System.Drawing.Size(73, 79)
        Me.Alien_500_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_500_4.TabIndex = 18
        Me.Alien_500_4.TabStop = False
        '
        'Alien_500_2
        '
        Me.Alien_500_2.BackColor = System.Drawing.Color.Transparent
        Me.Alien_500_2.Image = CType(resources.GetObject("Alien_500_2.Image"), System.Drawing.Image)
        Me.Alien_500_2.Location = New System.Drawing.Point(421, 82)
        Me.Alien_500_2.Name = "Alien_500_2"
        Me.Alien_500_2.Size = New System.Drawing.Size(73, 79)
        Me.Alien_500_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_500_2.TabIndex = 17
        Me.Alien_500_2.TabStop = False
        '
        'Alien_100_6
        '
        Me.Alien_100_6.BackColor = System.Drawing.Color.Transparent
        Me.Alien_100_6.Image = CType(resources.GetObject("Alien_100_6.Image"), System.Drawing.Image)
        Me.Alien_100_6.Location = New System.Drawing.Point(905, 278)
        Me.Alien_100_6.Name = "Alien_100_6"
        Me.Alien_100_6.Size = New System.Drawing.Size(90, 70)
        Me.Alien_100_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_100_6.TabIndex = 16
        Me.Alien_100_6.TabStop = False
        '
        'Alien_100_2
        '
        Me.Alien_100_2.BackColor = System.Drawing.Color.Transparent
        Me.Alien_100_2.Image = CType(resources.GetObject("Alien_100_2.Image"), System.Drawing.Image)
        Me.Alien_100_2.Location = New System.Drawing.Point(306, 278)
        Me.Alien_100_2.Name = "Alien_100_2"
        Me.Alien_100_2.Size = New System.Drawing.Size(90, 70)
        Me.Alien_100_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_100_2.TabIndex = 15
        Me.Alien_100_2.TabStop = False
        '
        'Alien_100_3
        '
        Me.Alien_100_3.BackColor = System.Drawing.Color.Transparent
        Me.Alien_100_3.Image = CType(resources.GetObject("Alien_100_3.Image"), System.Drawing.Image)
        Me.Alien_100_3.Location = New System.Drawing.Point(455, 278)
        Me.Alien_100_3.Name = "Alien_100_3"
        Me.Alien_100_3.Size = New System.Drawing.Size(90, 70)
        Me.Alien_100_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_100_3.TabIndex = 14
        Me.Alien_100_3.TabStop = False
        '
        'Alien_100_4
        '
        Me.Alien_100_4.BackColor = System.Drawing.Color.Transparent
        Me.Alien_100_4.Image = CType(resources.GetObject("Alien_100_4.Image"), System.Drawing.Image)
        Me.Alien_100_4.Location = New System.Drawing.Point(601, 278)
        Me.Alien_100_4.Name = "Alien_100_4"
        Me.Alien_100_4.Size = New System.Drawing.Size(90, 70)
        Me.Alien_100_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_100_4.TabIndex = 13
        Me.Alien_100_4.TabStop = False
        '
        'Alien_100_5
        '
        Me.Alien_100_5.BackColor = System.Drawing.Color.Transparent
        Me.Alien_100_5.Image = CType(resources.GetObject("Alien_100_5.Image"), System.Drawing.Image)
        Me.Alien_100_5.Location = New System.Drawing.Point(749, 278)
        Me.Alien_100_5.Name = "Alien_100_5"
        Me.Alien_100_5.Size = New System.Drawing.Size(90, 70)
        Me.Alien_100_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_100_5.TabIndex = 12
        Me.Alien_100_5.TabStop = False
        '
        'Alien_500_5
        '
        Me.Alien_500_5.BackColor = System.Drawing.Color.Transparent
        Me.Alien_500_5.Image = CType(resources.GetObject("Alien_500_5.Image"), System.Drawing.Image)
        Me.Alien_500_5.Location = New System.Drawing.Point(857, 82)
        Me.Alien_500_5.Name = "Alien_500_5"
        Me.Alien_500_5.Size = New System.Drawing.Size(73, 79)
        Me.Alien_500_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_500_5.TabIndex = 4
        Me.Alien_500_5.TabStop = False
        '
        'Alien_500_3
        '
        Me.Alien_500_3.BackColor = System.Drawing.Color.Transparent
        Me.Alien_500_3.Image = CType(resources.GetObject("Alien_500_3.Image"), System.Drawing.Image)
        Me.Alien_500_3.Location = New System.Drawing.Point(570, 82)
        Me.Alien_500_3.Name = "Alien_500_3"
        Me.Alien_500_3.Size = New System.Drawing.Size(73, 79)
        Me.Alien_500_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_500_3.TabIndex = 3
        Me.Alien_500_3.TabStop = False
        '
        'Alien_500_1
        '
        Me.Alien_500_1.BackColor = System.Drawing.Color.Transparent
        Me.Alien_500_1.Image = CType(resources.GetObject("Alien_500_1.Image"), System.Drawing.Image)
        Me.Alien_500_1.Location = New System.Drawing.Point(276, 82)
        Me.Alien_500_1.Name = "Alien_500_1"
        Me.Alien_500_1.Size = New System.Drawing.Size(73, 79)
        Me.Alien_500_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien_500_1.TabIndex = 2
        Me.Alien_500_1.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Image = Global.Deep_Space_Debacle.My.Resources.Resources.Player
        Me.Player.Location = New System.Drawing.Point(614, 642)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(108, 130)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 1
        Me.Player.TabStop = False
        '
        'versionLabel
        '
        Me.versionLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.versionLabel.AutoSize = True
        Me.versionLabel.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.versionLabel.LinkColor = System.Drawing.Color.White
        Me.versionLabel.Location = New System.Drawing.Point(3, 753)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(288, 17)
        Me.versionLabel.TabIndex = 10
        Me.versionLabel.TabStop = True
        Me.versionLabel.Text = "Version 1.06 | Ozzysnake.com"
        Me.versionLabel.VisitedLinkColor = System.Drawing.Color.White
        '
        'endlessText
        '
        Me.endlessText.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endlessText.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.endlessText.Location = New System.Drawing.Point(858, 306)
        Me.endlessText.Name = "endlessText"
        Me.endlessText.Size = New System.Drawing.Size(419, 141)
        Me.endlessText.TabIndex = 8
        Me.endlessText.Text = "Endless mode doesn't have a level limit and the only goal is to get the highest s" &
    "core. Aliens stay at the same speed throughout."
        Me.endlessText.Visible = False
        '
        'standardText
        '
        Me.standardText.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.standardText.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.standardText.Location = New System.Drawing.Point(74, 308)
        Me.standardText.Name = "standardText"
        Me.standardText.Size = New System.Drawing.Size(419, 141)
        Me.standardText.TabIndex = 7
        Me.standardText.Text = "The default gamemode were you need to get to, and complete, level 3." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The aliens " &
    "will get faster each level."
        Me.standardText.Visible = False
        '
        'endlessButton
        '
        Me.endlessButton.BackgroundImage = Global.Deep_Space_Debacle.My.Resources.Resources.endless
        Me.endlessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.endlessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.endlessButton.Location = New System.Drawing.Point(858, 175)
        Me.endlessButton.Name = "endlessButton"
        Me.endlessButton.Size = New System.Drawing.Size(419, 128)
        Me.endlessButton.TabIndex = 6
        Me.endlessButton.UseVisualStyleBackColor = True
        Me.endlessButton.Visible = False
        '
        'standardButton
        '
        Me.standardButton.BackgroundImage = Global.Deep_Space_Debacle.My.Resources.Resources.standard
        Me.standardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.standardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.standardButton.Location = New System.Drawing.Point(74, 175)
        Me.standardButton.Name = "standardButton"
        Me.standardButton.Size = New System.Drawing.Size(419, 128)
        Me.standardButton.TabIndex = 5
        Me.standardButton.UseVisualStyleBackColor = True
        Me.standardButton.Visible = False
        '
        'QuitButton
        '
        Me.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.QuitButton.FlatAppearance.BorderSize = 0
        Me.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Image = CType(resources.GetObject("QuitButton.Image"), System.Drawing.Image)
        Me.QuitButton.Location = New System.Drawing.Point(479, 596)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(379, 145)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'HelpPanel
        '
        Me.HelpPanel.Controls.Add(Me.Label3)
        Me.HelpPanel.Controls.Add(Me.Label2)
        Me.HelpPanel.Controls.Add(Me.PictureBox3)
        Me.HelpPanel.Controls.Add(Me.PictureBox2)
        Me.HelpPanel.Controls.Add(Me.Label1)
        Me.HelpPanel.Controls.Add(Me.Label5)
        Me.HelpPanel.Controls.Add(Me.PictureBox1)
        Me.HelpPanel.Controls.Add(Me.ThirdAlien)
        Me.HelpPanel.Controls.Add(Me.SecondAlien)
        Me.HelpPanel.Controls.Add(Me.FirstAlien)
        Me.HelpPanel.Controls.Add(Me.BackToMainMenu)
        Me.HelpPanel.Controls.Add(Me.Instructions)
        Me.HelpPanel.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpPanel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HelpPanel.Location = New System.Drawing.Point(1, 0)
        Me.HelpPanel.Name = "HelpPanel"
        Me.HelpPanel.Size = New System.Drawing.Size(1359, 775)
        Me.HelpPanel.TabIndex = 4
        Me.HelpPanel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(802, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Missile speed up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(630, 632)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ship repair"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Deep_Space_Debacle.My.Resources.Resources.missile_up
        Me.PictureBox3.Location = New System.Drawing.Point(849, 465)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 159)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Deep_Space_Debacle.My.Resources.Resources.wrench
        Me.PictureBox2.Location = New System.Drawing.Point(628, 465)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 159)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "The Invading aliens!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(1070, 640)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Player's Ship"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1086, 447)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'ThirdAlien
        '
        Me.ThirdAlien.Image = CType(resources.GetObject("ThirdAlien.Image"), System.Drawing.Image)
        Me.ThirdAlien.Location = New System.Drawing.Point(356, 493)
        Me.ThirdAlien.Name = "ThirdAlien"
        Me.ThirdAlien.Size = New System.Drawing.Size(134, 145)
        Me.ThirdAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ThirdAlien.TabIndex = 5
        Me.ThirdAlien.TabStop = False
        '
        'SecondAlien
        '
        Me.SecondAlien.Image = CType(resources.GetObject("SecondAlien.Image"), System.Drawing.Image)
        Me.SecondAlien.Location = New System.Drawing.Point(180, 493)
        Me.SecondAlien.Name = "SecondAlien"
        Me.SecondAlien.Size = New System.Drawing.Size(144, 145)
        Me.SecondAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SecondAlien.TabIndex = 4
        Me.SecondAlien.TabStop = False
        '
        'FirstAlien
        '
        Me.FirstAlien.Image = CType(resources.GetObject("FirstAlien.Image"), System.Drawing.Image)
        Me.FirstAlien.Location = New System.Drawing.Point(10, 493)
        Me.FirstAlien.Name = "FirstAlien"
        Me.FirstAlien.Size = New System.Drawing.Size(137, 145)
        Me.FirstAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FirstAlien.TabIndex = 3
        Me.FirstAlien.TabStop = False
        '
        'BackToMainMenu
        '
        Me.BackToMainMenu.AutoSize = True
        Me.BackToMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackToMainMenu.BackgroundImage = CType(resources.GetObject("BackToMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.BackToMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackToMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BackToMainMenu.FlatAppearance.BorderSize = 0
        Me.BackToMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BackToMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackToMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToMainMenu.Image = CType(resources.GetObject("BackToMainMenu.Image"), System.Drawing.Image)
        Me.BackToMainMenu.Location = New System.Drawing.Point(3, 682)
        Me.BackToMainMenu.Name = "BackToMainMenu"
        Me.BackToMainMenu.Size = New System.Drawing.Size(257, 88)
        Me.BackToMainMenu.TabIndex = 2
        Me.BackToMainMenu.TabStop = False
        Me.BackToMainMenu.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.Instructions.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructions.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Instructions.Location = New System.Drawing.Point(9, 0)
        Me.Instructions.Name = "Instructions"
        Me.Instructions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Instructions.Size = New System.Drawing.Size(1347, 465)
        Me.Instructions.TabIndex = 0
        Me.Instructions.Text = resources.GetString("Instructions.Text")
        '
        'HelpButton
        '
        Me.HelpButton.BackColor = System.Drawing.Color.Transparent
        Me.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpButton.Image = CType(resources.GetObject("HelpButton.Image"), System.Drawing.Image)
        Me.HelpButton.Location = New System.Drawing.Point(480, 384)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(378, 145)
        Me.HelpButton.TabIndex = 2
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Image = CType(resources.GetObject("PlayButton.Image"), System.Drawing.Image)
        Me.PlayButton.Location = New System.Drawing.Point(479, 167)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(379, 145)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Image = CType(resources.GetObject("Title.Image"), System.Drawing.Image)
        Me.Title.Location = New System.Drawing.Point(74, 28)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(1203, 90)
        Me.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Title.TabIndex = 0
        Me.Title.TabStop = False
        '
        'ParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 775)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1373, 814)
        Me.Name = "ParentForm"
        Me.Text = "Deep Space Debacle"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        CType(Me.sound_off_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sound_on_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameMain.ResumeLayout(False)
        Me.GameMain.PerformLayout()
        Me.scoreboardPanel.ResumeLayout(False)
        Me.scoreboardPanel.PerformLayout()
        Me.TimeSurvived.ResumeLayout(False)
        Me.TimeSurvived.PerformLayout()
        CType(Me.healthup_text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missileup_text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missileup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missileup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.healthup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.healthup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.healthup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_100_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restart_shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Missile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_100_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_300_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_500_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_500_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_500_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_100_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_100_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_100_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_100_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_100_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_500_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_500_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien_500_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HelpPanel.ResumeLayout(False)
        Me.HelpPanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThirdAlien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondAlien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstAlien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenu As Panel
    Friend WithEvents Title As PictureBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents Movement As Timer
    Friend WithEvents ExplosionTimer As Timer
    Friend WithEvents levelwontext As PictureBox
    Friend WithEvents scoreboardTimer As Timer
    Friend WithEvents HelpPanel As Panel
    Friend WithEvents GameMain As Panel
    Friend WithEvents levelwonlabel As Label
    Friend WithEvents retryButton As Button
    Friend WithEvents scoreboardPanel As Panel
    Friend WithEvents badScore As Label
    Friend WithEvents gamerScore8_score As Label
    Friend WithEvents gamerScore7_score As Label
    Friend WithEvents gamerScore6_score As Label
    Friend WithEvents gamerScore5_score As Label
    Friend WithEvents gamerScore4_score As Label
    Friend WithEvents gamerScore3_score As Label
    Friend WithEvents gamerScore2_score As Label
    Friend WithEvents gamerScore1_score As Label
    Friend WithEvents gamerScore8 As Label
    Friend WithEvents gamerScore7 As Label
    Friend WithEvents gamerScore6 As Label
    Friend WithEvents gamerScore5 As Label
    Friend WithEvents gamerScore4 As Label
    Friend WithEvents gamerScore3 As Label
    Friend WithEvents gamerScore2 As Label
    Friend WithEvents gamerScore1 As Label
    Friend WithEvents nameEntry As TextBox
    Friend WithEvents scoreboardPlayerNameLabel As Label
    Friend WithEvents scorebaordText As Label
    Friend WithEvents game_over_text As Label
    Friend WithEvents laser16 As PictureBox
    Friend WithEvents laser17 As PictureBox
    Friend WithEvents laser18 As PictureBox
    Friend WithEvents laser19 As PictureBox
    Friend WithEvents laser20 As PictureBox
    Friend WithEvents laser21 As PictureBox
    Friend WithEvents laser9 As PictureBox
    Friend WithEvents laser10 As PictureBox
    Friend WithEvents laser11 As PictureBox
    Friend WithEvents laser12 As PictureBox
    Friend WithEvents laser13 As PictureBox
    Friend WithEvents laser14 As PictureBox
    Friend WithEvents laser15 As PictureBox
    Friend WithEvents laser3 As PictureBox
    Friend WithEvents laser5 As PictureBox
    Friend WithEvents laser1 As PictureBox
    Friend WithEvents laser8 As PictureBox
    Friend WithEvents Alien_100_1 As PictureBox
    Friend WithEvents laser6 As PictureBox
    Friend WithEvents laser7 As PictureBox
    Friend WithEvents laser4 As PictureBox
    Friend WithEvents Alien_300_1 As PictureBox
    Friend WithEvents laser2 As PictureBox
    Friend WithEvents levellabel As Label
    Friend WithEvents restart_shot As PictureBox
    Friend WithEvents Missile As PictureBox
    Friend WithEvents Alien_100_7 As PictureBox
    Friend WithEvents Alien_300_8 As PictureBox
    Friend WithEvents Alien_300_3 As PictureBox
    Friend WithEvents Alien_300_4 As PictureBox
    Friend WithEvents Alien_300_5 As PictureBox
    Friend WithEvents Alien_300_6 As PictureBox
    Friend WithEvents Alien_300_7 As PictureBox
    Friend WithEvents Alien_300_2 As PictureBox
    Friend WithEvents Alien_500_6 As PictureBox
    Friend WithEvents Alien_500_4 As PictureBox
    Friend WithEvents Alien_500_2 As PictureBox
    Friend WithEvents Alien_100_6 As PictureBox
    Friend WithEvents Alien_100_2 As PictureBox
    Friend WithEvents Alien_100_3 As PictureBox
    Friend WithEvents Alien_100_4 As PictureBox
    Friend WithEvents Alien_100_5 As PictureBox
    Friend WithEvents Alien_500_5 As PictureBox
    Friend WithEvents Alien_500_3 As PictureBox
    Friend WithEvents Alien_500_1 As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ThirdAlien As PictureBox
    Friend WithEvents SecondAlien As PictureBox
    Friend WithEvents FirstAlien As PictureBox
    Friend WithEvents BackToMainMenu As Button
    Friend WithEvents Instructions As Label
    Friend WithEvents endlessButton As Button
    Friend WithEvents standardButton As Button
    Friend WithEvents standardText As Label
    Friend WithEvents endlessText As Label
    Friend WithEvents HealthBar As ProgressBar
    Friend WithEvents healthBarTimer As Timer
    Friend WithEvents healthup3 As PictureBox
    Friend WithEvents healthup2 As PictureBox
    Friend WithEvents healthup1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents missileup2 As PictureBox
    Friend WithEvents missileup1 As PictureBox
    Friend WithEvents missileSpeedTimer As Timer
    Friend WithEvents missileup_text As PictureBox
    Friend WithEvents healthup_text As PictureBox
    Friend WithEvents powerupTextTimer As Timer
    Friend WithEvents countdownTimer As Timer
    Friend WithEvents countdownLabel As Label
    Friend WithEvents TwoSecTimer As Timer
    Friend WithEvents OneSecTimer As Timer
    Friend WithEvents ThreeSecTimer As Timer
    Friend WithEvents versionLabel As LinkLabel
    Friend WithEvents TimeElapsedTimer As Timer
    Friend WithEvents TimeSurvived As GroupBox
    Friend WithEvents colon As Label
    Friend WithEvents secondsLabel As Label
    Friend WithEvents minutesLabel As Label
    Friend WithEvents sound_on_button As PictureBox
    Friend WithEvents sound_off_button As PictureBox
End Class
