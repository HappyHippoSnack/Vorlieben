Imports System.IO
Imports System.Text

Public Class Haupt

    'den pfad der zu speichernden datei angeben
    Dim path As String
    Dim path1 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB1.txt"
    Dim path2 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB2.txt"
    Dim path3 As String = "C:\Users\" & Environ("Username") & "\Desktop\Auswertung.txt"
    Dim link As String

    'pfad der auswertung anpassen, so dass die dateien immer neben dem projekt liegen
    'Dim path1 As String = Application.StartupPath + "VorliebenDB1.txt"
    'Dim path2 As String = Application.StartupPath + "VorliebenDB2.txt"
    'Dim path3 As String = Application.StartupPath + "Auswertung.txt"

    'array erzeugen welches 135 stellen hat
    Dim vorlieben(135) As String


    'array erzeugen welches 135 stellen hat
    Dim vorliebend1(135) As String

    'array erzeugen welches 135 stellen hat
    Dim vorliebend2(135) As String

    'einen zähler erzeugen der nur zahlen enthält
    Dim zaehler As Int32
    Dim jaCounter1 As Int32
    Dim jaCounter2 As Int32
    Dim neinCounter1 As Int32
    Dim neinCounter2 As Int32
    Dim zurucksetzten As Int32





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'zähler auf 1 setzten
        Dim zaehler = 0
        Dim jaCounter1 = 0
        Dim jaCounter2 = 0


        'checkbox von durchgang 1 haken setzten
        Durchgang1.Checked = True


        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If

        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If

        If System.IO.File.Exists(path3) Then
            Auswertung.Text = "Daten Vorhanden"
            Auswertung.ForeColor = Color.Green
        Else
            Auswertung.Text = "Fehlt"
            Auswertung.ForeColor = Color.Red
        End If


        If zaehler = 0 Then

            Ja.Text = "Start"
            Vielleicht.Text = "Start"
            Nein.Text = "Start"
        End If


        'array mit daten befüllen

        vorlieben(0) = "Vorlieben. Die App"
        vorlieben(1) = "All Holes"
        vorlieben(2) = "Anal"
        vorlieben(3) = "Anal Beads"
        vorlieben(4) = "Anal Creampie"
        vorlieben(5) = "Anal Dildo"
        vorlieben(6) = "Anal Fisting"
        vorlieben(7) = "Anal Gape"
        vorlieben(8) = "Ass To Mouth"
        vorlieben(9) = "Assfingering"
        vorlieben(10) = "Ball Licking"
        vorlieben(11) = "Balloon"
        vorlieben(12) = "BDSM"
        vorlieben(13) = "Begging"
        vorlieben(14) = "Bend Over"
        vorlieben(15) = "Blindfolded"
        vorlieben(16) = "Blowjob"
        vorlieben(17) = "Blowjob & Cum"
        vorlieben(18) = "Bondage"
        vorlieben(19) = "Bound"
        vorlieben(20) = "Bukkake"
        vorlieben(21) = "Buttplug"
        vorlieben(22) = "Cameltoe"
        vorlieben(23) = "Caning"
        vorlieben(24) = "Cum Eating Instructions"
        vorlieben(25) = "Centerfold"
        vorlieben(26) = "Chastity Belt"
        vorlieben(27) = "Clamp"
        vorlieben(28) = "Clothed Pissing"
        vorlieben(29) = "Clothed Sex"
        vorlieben(30) = "Creampie"
        vorlieben(31) = "Crotchless Panties"
        vorlieben(32) = "Cuckold Humiliation"
        vorlieben(33) = "Cum In Her Eyes"
        vorlieben(34) = "Cum In Mouth"
        vorlieben(35) = "Cum In Pussy"
        vorlieben(36) = "Cum On Ass"
        vorlieben(37) = "Double Anal Penetration"
        vorlieben(38) = "Deepthroat"
        vorlieben(39) = "Diaper"
        vorlieben(40) = "Dirty Talk"
        vorlieben(41) = "Doctor"
        vorlieben(42) = "Doggystyle"
        vorlieben(43) = "Double Toying"
        vorlieben(44) = "Electrified"
        vorlieben(45) = "Enema"
        vorlieben(46) = "Extreme Deepthroat"
        vorlieben(47) = "Face Fuck"
        vorlieben(48) = "Face Sitting"
        vorlieben(49) = "Farting"
        vorlieben(50) = "Femdom"
        vorlieben(51) = "Fingering Orgasm"
        vorlieben(52) = "Fisting"
        vorlieben(53) = "Flogger Whip"
        vorlieben(54) = "Fondling"
        vorlieben(55) = "Foot Fetish"
        vorlieben(56) = "Foursome"
        vorlieben(57) = "Fur"
        vorlieben(58) = "Gagged (Bit or Ball)"
        vorlieben(59) = "Gagging"
        vorlieben(60) = "Gangbang"
        vorlieben(61) = "Gaping Hole"
        vorlieben(62) = "Gloryhole"
        vorlieben(63) = "Gloves"
        vorlieben(64) = "Golden Shower"
        vorlieben(65) = "Group Sex"
        vorlieben(66) = "Gynecologist"
        vorlieben(67) = "Gyno Exam"
        vorlieben(68) = "Hair Pulling"
        vorlieben(69) = "Hairy"
        vorlieben(70) = "Handcuffed"
        vorlieben(71) = "Handjob"
        vorlieben(72) = "Humiliation"
        vorlieben(73) = "Inflatable"
        vorlieben(74) = "Insertion"
        vorlieben(75) = "Instructions"
        vorlieben(76) = "Jerking"
        vorlieben(77) = "Leashed"
        vorlieben(78) = "Leather"
        vorlieben(79) = "Lingerie"
        vorlieben(80) = "Machine Fucking"
        vorlieben(81) = "Masturbating"
        vorlieben(82) = "No Panties"
        vorlieben(83) = "Nurse"
        vorlieben(84) = "Oiled"
        vorlieben(85) = "On Her Knees"
        vorlieben(86) = "Open Pussy"
        vorlieben(87) = "Peehole"
        vorlieben(88) = "Pegging"
        vorlieben(89) = "Pissed On"
        vorlieben(90) = "Pissing"
        vorlieben(91) = "Prolapse"
        vorlieben(92) = "Prostate Massage"
        vorlieben(93) = "Public Anal Sex"
        vorlieben(94) = "Pussy Stretching"
        vorlieben(95) = "Pussy To Mouth"
        vorlieben(96) = "Rectal Exam"
        vorlieben(97) = "Remote"
        vorlieben(98) = "Satin"
        vorlieben(99) = "School Uniform"
        vorlieben(100) = "Self Fisting"
        vorlieben(101) = "Sex Tape"
        vorlieben(102) = "Share Wife"
        vorlieben(103) = "Slave / Master (Sub/Dom)"
        vorlieben(104) = "Slave (Passiv)"
        vorlieben(105) = "Sniffing Panties"
        vorlieben(106) = "Spanked"
        vorlieben(107) = "Speculum"
        vorlieben(108) = "Spit"
        vorlieben(109) = "Spreading"
        vorlieben(110) = "Squirt"
        vorlieben(111) = "Strap-On"
        vorlieben(112) = "Submissive"
        vorlieben(113) = "Swollen Pussy"
        vorlieben(114) = "Teacher & Student"
        vorlieben(115) = "Tentacle"
        vorlieben(116) = "Threesome"
        vorlieben(117) = "Tied Up"
        vorlieben(118) = "Tit Slap"
        vorlieben(119) = "Titjob"
        vorlieben(120) = "Toes"
        vorlieben(121) = "Human Toilet"
        vorlieben(122) = "Torture"
        vorlieben(123) = "Toys"
        vorlieben(124) = "Underwater"
        vorlieben(125) = "Unshaved"
        vorlieben(126) = "Urethra"
        vorlieben(127) = "Vacuum"
        vorlieben(128) = "Vaginal Cumshot"
        vorlieben(129) = "Vegetable"
        vorlieben(130) = "Wanking"
        vorlieben(131) = "Watersport"
        vorlieben(132) = "Wax"
        vorlieben(133) = "Wet Panties"
        vorlieben(134) = "Zoophilie"



        'definieren des starttextes
        VorliebeText.Text = vorlieben(zaehler)

    End Sub

    Private Sub Ja_Click(sender As Object, e As EventArgs) Handles Ja.Click

        'buttontext anpassen und spielbereicht machen
        Ja.Text = "Ja"
        Vielleicht.Text = "Vielleicht"
        Nein.Text = "Nein"

        'prüfen wer spielt
        If Durchgang1.Checked Then
            path = path1
        Else
            path = path2
        End If

        'Text in die Datei schreiben
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.WriteLine("OK " + VorliebeText.Text)
        file.Close()

        'prüfen ob man am ende angekommen ist
        If zaehler = 134 Then
            MsgBox("Durchgang beendet, bitte die Person wechseln...", vbOKOnly, "Erfolg")
            ProgressBar1.Value = 0
            Dim jaCounter1 = 0
            Dim jaCounter2 = 0
            VorliebeText.Text = vorlieben(0)

            Ja.Text = "Start"
            Vielleicht.Text = "Start"
            Nein.Text = "Start"
        Else
            'nächste vorliebe zeigen
            zaehler = zaehler + 1
            VorliebeText.Text = vorlieben(zaehler)
        End If



        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path3) Then
            Auswertung.Text = "Daten Vorhanden"
            Auswertung.ForeColor = Color.Green
        Else
            Auswertung.Text = "Fehlt"
            Auswertung.ForeColor = Color.Red
        End If

        'Progressbar einstellen und füllen
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = vorlieben.Length
        ProgressBar1.Value = ProgressBar1.Value + 1


    End Sub

    Private Sub Nein_Click(sender As Object, e As EventArgs) Handles Nein.Click

        'buttontext anpassen und spielbereicht machen
        Ja.Text = "Ja"
        Vielleicht.Text = "Vielleicht"
        Nein.Text = "Nein"


        'prüfen wer spielt
        If Durchgang1.Checked Then
            path = path1
        Else
            path = path2
        End If


        'Text in die Datei schreiben
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.WriteLine("NICHT " + VorliebeText.Text)
        file.Close()

        'prüfen ob man am ende angekommen ist
        If zaehler = 134 Then
            MsgBox("Durchgang beendet", vbOKOnly, "Erfolg")
            ProgressBar1.Value = 0
            Dim zaehler = 0
            Dim jaCounter1 = 0
            Dim jaCounter2 = 0
            VorliebeText.Text = vorlieben(0)
        Else
            'nächste vorliebe zeigen
            zaehler = zaehler + 1
            VorliebeText.Text = vorlieben(zaehler)
        End If


        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path3) Then
            Auswertung.Text = "Daten Vorhanden"
            Auswertung.ForeColor = Color.Green
        Else
            Auswertung.Text = "Fehlt"
            Auswertung.ForeColor = Color.Red
        End If

        'Progressbar einstellen und füllen
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = vorlieben.Length
        ProgressBar1.Value = ProgressBar1.Value + 1

    End Sub

    Private Sub Vielleicht_Click(sender As Object, e As EventArgs) Handles Vielleicht.Click

        'buttontext anpassen und spielbereicht machen
        Ja.Text = "Ja"
        Vielleicht.Text = "Vielleicht"
        Nein.Text = "Nein"


        'prüfen wer spielt
        If Durchgang1.Checked Then
            path = path1
        Else
            path = path2
        End If


        'Text in die Datei schreiben
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.WriteLine("VLLT " + VorliebeText.Text)
        file.Close()

        'prüfen ob man am ende angekommen ist
        If zaehler = 134 Then
            MsgBox("Durchgang beendet", vbOKOnly, "Erfolg")
            ProgressBar1.Value = 0
            Dim zaehler = 0
            Dim jaCounter1 = 0
            Dim jaCounter2 = 0
            VorliebeText.Text = vorlieben(0)
        Else
            'nächste vorliebe zeigen
            zaehler = zaehler + 1
            VorliebeText.Text = vorlieben(zaehler)
        End If


        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path3) Then
            Auswertung.Text = "Daten Vorhanden"
            Auswertung.ForeColor = Color.Green
        Else
            Auswertung.Text = "Fehlt"
            Auswertung.ForeColor = Color.Red
        End If

        'Progressbar einstellen und füllen
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = vorlieben.Length
        ProgressBar1.Value = ProgressBar1.Value + 1

    End Sub

    Public Sub Auswerten_Click(sender As Object, e As EventArgs) Handles Auswerten.Click

        Dim i As Integer = 0
        Dim zurucksetzten = 0
        Dim vorliebend1() As String = System.IO.File.ReadAllLines(path1)
        Dim vorliebend2() As String = System.IO.File.ReadAllLines(path2)


        'Zeilen der Textdateien werden gezählt und wenn zu wenig zur auswertung sind, wir die datei gelöscht
        Dim count1 = System.IO.File.ReadLines(path1).Count()
        Dim count2 = System.IO.File.ReadLines(path2).Count()

        'ausgabe wenn nicht alles beantwortet wurde. löschen der fehlerhaften datei und progress rückstellen
        If count1 <= 134 Then
            MsgBox("Bitte erneut Vorlieben von Partner 1 eingeben.", vbOKOnly, "!FEHLER!")
            My.Computer.FileSystem.DeleteFile(path1)
            zurucksetzten = zurucksetzten + 1
            ProgressBar1.Value = 0
            Dim zaehler = 0
            Dim jaCounter1 = 0
            Dim jaCounter2 = 0
            VorliebeText.Text = vorlieben(zaehler)
            If System.IO.File.Exists(path3) Then
                My.Computer.FileSystem.DeleteFile(path3)
            End If
            i = 135
        End If
        If count2 <= 134 Then
            MsgBox("Bitte erneut Vorlieben von Partner 2 eingeben.", vbOKOnly, "!FEHLER!")
            My.Computer.FileSystem.DeleteFile(path2)
            zurucksetzten = zurucksetzten + 1
            ProgressBar1.Value = 0
            Dim zaehler = 0
            Dim jaCounter1 = 0
            Dim jaCounter2 = 0
            VorliebeText.Text = vorlieben(zaehler)
            If System.IO.File.Exists(path3) Then
                My.Computer.FileSystem.DeleteFile(path3)
            End If
            i = 135
        End If

        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If

        'Hochzählen bis das Array durch ist
        Do While i <= 134

            'Abfrage ob in der DB1 ein OK ist
            If vorliebend1(i) Like "OK " + vorlieben(i) Then

                'einen hochzählen für nutzer1
                jaCounter1 = jaCounter1 + 1

                'Wenn auch in der DB2 ein ok ist dann
                If vorliebend2(i) Like "OK " + vorlieben(i) Then

                    'einen hochzählen für nutzer2
                    jaCounter2 = jaCounter2 + 1

                    'In die Auswertung das Ergebnis schreiben
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(path3, True)
                    file.WriteLine("JA zu: " + vorlieben(i))
                    file.Close()

                    'wenn in der DB2 ein vllt ist dann
                ElseIf vorliebend2(i) Like "VLLT " + vorlieben(i) Then

                    'einen hochzählen für nutzer2
                    jaCounter2 = jaCounter2 + 1

                    'In die Auswertung das Ergebnis schreiben
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(path3, True)
                    file.WriteLine("VIELLEICHT zu: " + vorlieben(i))
                    file.Close()

                    'wenn in der DB2 ein nein ist
                ElseIf vorliebend2(i) Like "NICHT " + vorlieben(i) Then

                    'einen hochzählen für nutzer2
                    neinCounter2 = neinCounter2 + 1
                End If

            End If

            'abfragen ob in DB1 ein vllt ist
            'Abfrage ob in der DB1 ein OK ist
            If vorliebend1(i) Like "VLLT " + vorlieben(i) Then

                'einen hochzählen für nutzer1
                jaCounter1 = jaCounter1 + 1

                'Wenn auch in der DB2 ein ok ist dann
                If vorliebend2(i) Like "OK " + vorlieben(i) Then

                    'einen hochzählen für nutzer1
                    jaCounter2 = jaCounter2 + 1

                    'In die Auswertung das Ergebnis schreiben
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(path3, True)
                    file.WriteLine("VIELLEICHT zu: " + vorlieben(i))
                    file.Close()

                    'wenn in der DB2 ein vllt ist dann
                ElseIf vorliebend2(i) Like "VLLT " + vorlieben(i) Then

                    'einen hochzählen für nutzer1
                    jaCounter2 = jaCounter2 + 1

                    'In die Auswertung das Ergebnis schreiben
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(path3, True)
                    file.WriteLine("VIELLEICHT zu: " + vorlieben(i))
                    file.Close()

                    'wenn in der DB2 ein nein ist
                ElseIf vorliebend2(i) Like "NICHT " + vorlieben(i) Then
                    'einen hochzählen für nutzer2
                    neinCounter2 = neinCounter2 + 1
                End If
            End If

            If vorliebend1(i) Like "NICHT " + vorlieben(i) Then
                neinCounter1 = neinCounter1 + 1
            End If

            i = i + 1
        Loop

        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path3) Then
            Auswertung.Text = "Daten Vorhanden"
            Auswertung.ForeColor = Color.Green
        Else
            Auswertung.Text = "Fehlt"
            Auswertung.ForeColor = Color.Red
        End If


        'array auslesen und auf spam prüfen
        If jaCounter1 > 120 Then
            MsgBox("Warnung, hier wurde von Nummer 1 JA/Vielleicht gespamt!", vbOKOnly, "Spam Detector")
        End If

        If jaCounter2 > 120 Then
            MsgBox("Warnung, hier wurde von Nummer 2 JA/Vielleicht gespamt!", vbOKOnly, "Spam Detector")
        End If

        If neinCounter1 > 134 Then
            MsgBox("Warnung, hier wurde von Nummer 1 alles mit Nein beantwortet.", vbOKOnly, "Spam Detector")
        End If

        If neinCounter2 > 134 Then
            MsgBox("Warnung, hier wurde von Nummer 2 alles mit Nein beantwortet.", vbOKOnly, "Spam Detector")
        End If

        If zurucksetzten = 1 Then
            i = 0
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim value As String
        value = VorliebeText.Text

        'abfrage ob man den titel oder das fertig zur pornoseite schicken will
        If value Like "Vorlieben. Die App" Or VorliebeText.Text Like "!FERTIG!" Then
            MsgBox("Hier kannst du den Fetisch suchen.", vbOKOnly, "Fehler")

        Else
            'Text anpassen das ein browser ihn öffnen kann durch löschen von leerzeichen und ersetzten durch unterstrich
            Dim aString As String = Replace(value, " ", "_")

            'öffnen des browsers
            Process.Start(("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"), "https://www.xnxx.com/search/" + aString)
        End If

    End Sub


    'Die checkboxen so steuern, das nur EINE aktiviert sein kann
    Private Sub Durchgang1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Durchgang1.CheckedChanged
        If Durchgang1.Checked Then
            Durchgang2.Checked = False
            zaehler = 0
        End If
    End Sub

    'Die checkboxen so steuern, das nur EINE aktiviert sein kann
    Private Sub Durchgang2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Durchgang2.CheckedChanged
        If Durchgang2.Checked Then
            Durchgang1.Checked = False
            zaehler = 0
        End If
    End Sub

    Private Sub OptionenButton_Click(sender As Object, e As EventArgs) Handles OptionenButton.Click

        Optionen.Show()
        Me.Hide()

    End Sub

    Private Sub Haupt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim dr As Windows.Forms.DialogResult

        dr = MessageBox.Show("Wollen sie wirklich beenden?", "Sind sie sicher?", MessageBoxButtons.OKCancel)
        If dr = DialogResult.OK Then
            'Programm beenden und abgegebene Stimmen löschen
            If System.IO.File.Exists(path1) Then
                My.Computer.FileSystem.DeleteFile(path1)
            End If
            If System.IO.File.Exists(path2) Then
                My.Computer.FileSystem.DeleteFile(path2)
            End If
            Global.Vorlieben.Optionen.Close()
            Global.Vorlieben.Starter.Close()

        ElseIf dr = DialogResult.Cancel Then
            Global.Vorlieben.Starter.Show()
            '  er ist unsicher -- wir gehen auf start zurück
        End If

    End Sub

    Private Sub Zuruck_Click(sender As Object, e As EventArgs) Handles Zuruck.Click
        'prüfen wer spielt
        If Durchgang1.Checked Then
            path = path1
        Else
            path = path2
        End If

        'letzter Eintrag löschen in der eigenen Asuwertung
        Dim Zeilen() As String
        Dim Count As Integer = 0

        Dim SR As IO.StreamReader = New IO.StreamReader(path)
        While SR.Peek > -1
            ReDim Preserve Zeilen(Count)
            Zeilen(Count) = SR.ReadLine
            Count += 1
        End While
        SR.Close()

        Dim LastLine As String = Zeilen(UBound(Zeilen))

        Kill(path)

        Dim SW As IO.StreamWriter = New IO.StreamWriter(path)
        For Durchlauf As Integer = 0 To UBound(Zeilen) - 1
            SW.WriteLine(Zeilen(Durchlauf))
        Next
        SW.Close()


        'Anzeige einen zurückspringen lassen
        zaehler = zaehler - 1
        VorliebeText.Text = vorlieben(zaehler)

        'Progressbar einstellen und füllen

        ProgressBar1.Value = ProgressBar1.Value - 1
    End Sub
End Class
