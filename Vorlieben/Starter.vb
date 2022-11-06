Public Class Starter


    Dim DBzaehler As Int32


    Public Sub Starter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Checkbox vorauswahl
        Normal.Checked = True

    End Sub


    Private Sub Starter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Haupt.Show()
    End Sub

    Public Sub Verstanden_Click(sender As Object, e As EventArgs) Handles Verstanden.Click



        If Normal.Checked Then
            'DB Normal auswählen
        ElseIf Einsteiger.Checked Then
            'DB Einsteiger auswählen
        ElseIf Extremist.Checked Then
            'DB Extremist auswählen
        Else
            'Es ist ein Fehler aufgetreten!
        End If





        Haupt.Show()
        System.Threading.Thread.Sleep(100)
        Me.Hide()


    End Sub

    Function Datenbanken(sender As Object, e As EventArgs)

        'zum laufen bringen! prio #1!!!


        Dim einsteiger(135) As String

        'array mit daten befüllen
        einsteiger(0) = "Vorlieben. Die App"
        einsteiger(1) = "All Holes"
        einsteiger(2) = "Anal"
        einsteiger(3) = "Anal Beads"
        einsteiger(4) = "Anal Creampie"
        einsteiger(5) = "Anal Dildo"
        einsteiger(6) = "Anal Fisting"
        einsteiger(7) = "Anal Gape"
        einsteiger(8) = "Ass To Mouth"
        einsteiger(9) = "Assfingering"
        einsteiger(10) = "Ball Licking"
        einsteiger(11) = "Balloon"
        einsteiger(12) = "BDSM"
        einsteiger(13) = "Begging"
        einsteiger(14) = "Bend Over"
        einsteiger(15) = "Blindfolded"
        einsteiger(16) = "Blowjob"
        einsteiger(17) = "Blowjob & Cum"
        einsteiger(18) = "Bondage"
        einsteiger(19) = "Bound"
        einsteiger(20) = "Bukkake"
        einsteiger(21) = "Buttplug"
        einsteiger(22) = "Cameltoe"
        einsteiger(23) = "Caning"
        einsteiger(24) = "Cum Eating Instructions"
        einsteiger(25) = "Centerfold"
        einsteiger(26) = "Chastity Belt"
        einsteiger(27) = "Clamp"
        einsteiger(28) = "Clothed Pissing"
        einsteiger(29) = "Clothed Sex"
        einsteiger(30) = "Creampie"
        einsteiger(31) = "Crotchless Panties"
        einsteiger(32) = "Cuckold Humiliation"
        einsteiger(33) = "Cum In Her Eyes"
        einsteiger(34) = "Cum In Mouth"
        einsteiger(35) = "Cum In Pussy"
        einsteiger(36) = "Cum On Ass"
        einsteiger(37) = "Double Anal Penetration"
        einsteiger(38) = "Deepthroat"
        einsteiger(39) = "Diaper"
        einsteiger(40) = "Dirty Talk"
        einsteiger(41) = "Doctor"
        einsteiger(42) = "Doggystyle"
        einsteiger(43) = "Double Toying"
        einsteiger(44) = "Electrified"
        einsteiger(45) = "Enema"
        einsteiger(46) = "Extreme Deepthroat"
        einsteiger(47) = "Face Fuck"
        einsteiger(48) = "Face Sitting"
        einsteiger(49) = "Farting"
        einsteiger(50) = "Femdom"
        einsteiger(51) = "Fingering Orgasm"
        einsteiger(52) = "Fisting"
        einsteiger(53) = "Flogger Whip"
        einsteiger(54) = "Fondling"
        einsteiger(55) = "Foot Fetish"
        einsteiger(56) = "Foursome"
        einsteiger(57) = "Fur"
        einsteiger(58) = "Gagged (Bit or Ball)"
        einsteiger(59) = "Gagging"
        einsteiger(60) = "Gangbang"
        einsteiger(61) = "Gaping Hole"
        einsteiger(62) = "Gloryhole"
        einsteiger(63) = "Gloves"
        einsteiger(64) = "Golden Shower"
        einsteiger(65) = "Group Sex"
        einsteiger(66) = "Gynecologist"
        einsteiger(67) = "Gyno Exam"
        einsteiger(68) = "Hair Pulling"
        einsteiger(69) = "Hairy"
        einsteiger(70) = "Handcuffed"
        einsteiger(71) = "Handjob"
        einsteiger(72) = "Humiliation"
        einsteiger(73) = "Inflatable"
        einsteiger(74) = "Insertion"
        einsteiger(75) = "Instructions"
        einsteiger(76) = "Jerking"
        einsteiger(77) = "Leashed"
        einsteiger(78) = "Leather"
        einsteiger(79) = "Lingerie"
        einsteiger(80) = "Machine Fucking"
        einsteiger(81) = "Masturbating"
        einsteiger(82) = "No Panties"
        einsteiger(83) = "Nurse"
        einsteiger(84) = "Oiled"
        einsteiger(85) = "On Her Knees"
        einsteiger(86) = "Open Pussy"
        einsteiger(87) = "Peehole"
        einsteiger(88) = "Pegging"
        einsteiger(89) = "Pissed On"
        einsteiger(90) = "Pissing"
        einsteiger(91) = "Prolapse"
        einsteiger(92) = "Prostate Massage"
        einsteiger(93) = "Public Anal Sex"
        einsteiger(94) = "Pussy Stretching"
        einsteiger(95) = "Pussy To Mouth"
        einsteiger(96) = "Rectal Exam"
        einsteiger(97) = "Remote"
        einsteiger(98) = "Satin"
        einsteiger(99) = "School Uniform"
        einsteiger(100) = "Self Fisting"
        einsteiger(101) = "Sex Tape"
        einsteiger(102) = "Share Wife"
        einsteiger(103) = "Slave (Activ)"
        einsteiger(104) = "Slave (Passiv)"
        einsteiger(105) = "Sniffing Panties"
        einsteiger(106) = "Spanked"
        einsteiger(107) = "Speculum"
        einsteiger(108) = "Spit"
        einsteiger(109) = "Spreading"
        einsteiger(110) = "Squirt"
        einsteiger(111) = "Strap-On"
        einsteiger(112) = "Submissive"
        einsteiger(113) = "Swollen Pussy"
        einsteiger(114) = "Teacher & Student"
        einsteiger(115) = "Tentacle"
        einsteiger(116) = "Threesome"
        einsteiger(117) = "Tied Up"
        einsteiger(118) = "Tit Slap"
        einsteiger(119) = "Titjob"
        einsteiger(120) = "Toes"
        einsteiger(121) = "Human Toilet"
        einsteiger(122) = "Torture"
        einsteiger(123) = "Toys"
        einsteiger(124) = "Underwater"
        einsteiger(125) = "Unshaved"
        einsteiger(126) = "Urethra"
        einsteiger(127) = "Vacuum"
        einsteiger(128) = "Vaginal Cumshot"
        einsteiger(129) = "Vegetable"
        einsteiger(130) = "Wanking"
        einsteiger(131) = "Watersport"
        einsteiger(132) = "Wax"
        einsteiger(133) = "Wet Panties"
        einsteiger(134) = "!FERTIG!"
    End Function

    Private Sub Einsteiger_CheckedChanged(sender As Object, e As EventArgs) Handles Einsteiger.CheckedChanged

    End Sub

    Private Sub Anleitung_Click(sender As Object, e As EventArgs) Handles Anleitung.Click


        Process.Start(("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"), "-inprivate")
        Anleitung_Nutzer.Show()
        Me.Hide()

    End Sub
End Class