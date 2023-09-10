Imports System.IO
Imports System.Text

Public Class Haupt

    'den pfad der geändert wird, je nach nutzer der an der reihe ist
    Dim path As String

    'Pfad für die datenbank von user1
    Dim path1 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB1"

    'pfad für die datenbank von user2
    Dim path2 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB2"

    'pfad auf dem die auswertungen gespeichert werden soll
    Dim path3 As String = "C:\Users\" & Environ("Username") & "\Desktop\Auswertung.txt"

    'offensichtlich unbenutze sachen die weg können
    'Dim historyEdge As String = "C:\Users\" & Environ("Username") & "\AppData\Local\Microsoft\Edge\User Data\Default\History"

    'BrowserAbfrage welcher Browser genutzt werden soll
    Dim Browser As String = "Unbekannt"

    'Abfrage der WindowsForms beim schließen
    Dim dr As Windows.Forms.DialogResult


    'pfad der auswertung anpassen, so dass die dateien immer neben dem projekt liegen
    'Dim path1 As String = Application.StartupPath + "VorliebenDB1.txt"
    'Dim path2 As String = Application.StartupPath + "VorliebenDB2.txt"
    'Dim path3 As String = Application.StartupPath + "Auswertung.txt"

    'array erzeugen welches 116 stellen hat, gefüllt mit allen kinks
    Dim vorlieben(116) As String

    'array erzeugen, welches die erklärungen der Fetische in sich hat
    Dim vorlieben_erklaerung(116) As String


    'array erzeugen welches 1116 stellen hat für person 1 und den durchgang
    Dim vorliebend1(116) As String

    'array erzeugen welches 1116 stellen hat für person 2 und den durchgang
    Dim vorliebend2(116) As String

    'einen zähler erzeugen der die kinks durchzählt und anhand der nummer weiß was gerade abgefragt wird
    Dim zaehler As Int32
    'Zähler erzeugen, welcher die abgegebenen JA stimmen zählt für Person 1
    Dim jaCounter1 As Int32
    'Zähler erzeugen, welcher die abgegebenen JA stimmen zählt für Person 2
    Dim jaCounter2 As Int32
    'Zähler erzeugen, welcher die abgegebenen NEIN stimmen zählt für Person 1
    Dim neinCounter1 As Int32
    'Zähler erzeugen, welcher die abgegebenen NEIN stimmen zählt für Person 2
    Dim neinCounter2 As Int32
    'Zurücksetzten löst aus, dass wenn eine 1 gesetzt ist, der vorgang gelöscht wird und man bei 0 anfangen muss (fehler sicherheit)
    Dim zurucksetzten As Int32

    'Anzahl an Abfragen/Kinks mit JA /VLLT Wertung schlimm, hier anpassen wenn verändert. IMMER EINS TIEFER ALS ARRAY GROESSE!
    Dim ZahlenCheck = 115

    'zaehler erzeugen die zählen ob man alle fragen beantwortet hat für user 1+2
    Dim count1 As Integer
    Dim count2 As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'zähler alle auf 0 setzten
        Dim zaehler = 0
        Dim jaCounter1 = 0
        Dim jaCounter2 = 0

        If System.IO.File.Exists("C:\Program Files\Mozilla Firefox\private_browsing.exe") Then
            Browser = "FireFox"

        ElseIf System.IO.File.Exists("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe") Then
            Browser = "Edge"

        ElseIf System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\Chrome") Then
            Browser = "Unbekannt"
            MsgBox("Bitte FireFox oder Edge installieren! Mit Chrome, geht es leider nicht!")
            Me.Close()
            dr = DialogResult.OK
        End If


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
        vorlieben(8) = "Ass Eating"
        vorlieben(9) = "Assfingering"
        vorlieben(10) = "Ball Licking"
        vorlieben(11) = "Balloon"
        vorlieben(12) = "BDSM"
        vorlieben(13) = "Betteln"
        vorlieben(14) = "Bend Over"
        vorlieben(15) = "Blindfolded"
        vorlieben(16) = "Blowjob"
        vorlieben(17) = "Erotic Kissing"
        vorlieben(18) = "Bondage"
        vorlieben(19) = "Shaved"
        vorlieben(20) = "Bukkake"
        vorlieben(21) = "Butt Plug"
        vorlieben(22) = "Cameltoe"
        vorlieben(23) = "!Ihre Werbung hier!"
        vorlieben(24) = "Tentacle"
        vorlieben(25) = "Cartoon"
        vorlieben(26) = "Chastity Belt"
        vorlieben(27) = "Clamp"
        vorlieben(28) = "Clothed Pissing"
        vorlieben(29) = "Roleplay"
        vorlieben(30) = "Creampie"
        vorlieben(31) = "Crotchless Panties"
        vorlieben(32) = "Cuckold Humiliation"
        vorlieben(33) = "Cum On Boobs"
        vorlieben(34) = "Cum In Mouth"
        vorlieben(35) = "Cum In Pussy"
        vorlieben(36) = "Cum On Ass"
        vorlieben(37) = "Double Anal Penetration"
        vorlieben(38) = "Deepthroat"
        vorlieben(39) = "Diaper"
        vorlieben(40) = "Dirty Talk"
        vorlieben(41) = "Doctor / Nurse"
        vorlieben(42) = "Doggystyle"
        vorlieben(43) = "Double Toying"
        vorlieben(44) = "Electrified"
        vorlieben(45) = "Enema"
        vorlieben(46) = "Office Sex"
        vorlieben(47) = "Face Fuck"
        vorlieben(48) = "Face Sitting"
        vorlieben(49) = "Farting"
        vorlieben(50) = "Femdom"
        vorlieben(51) = "Fingering Orgasm"
        vorlieben(52) = "Fisting"
        vorlieben(53) = "Flogger Whip"
        vorlieben(54) = "Feeding"
        vorlieben(55) = "Footjob"
        vorlieben(56) = "Foursome"
        vorlieben(57) = "Furry"
        vorlieben(58) = "Wax"
        vorlieben(59) = "Gagging"
        vorlieben(60) = "Gangbang"
        vorlieben(61) = "Gaping Hole"
        vorlieben(62) = "Gloryhole"
        vorlieben(63) = "Gloves"
        vorlieben(64) = "Romantic Sex"
        vorlieben(65) = "Biting"
        vorlieben(66) = "Gynecologist"
        vorlieben(67) = "Missionary"
        vorlieben(68) = "Hair Pulling"
        vorlieben(69) = "Vegetable"
        vorlieben(70) = "Handcuffed"
        vorlieben(71) = "Handjob"
        vorlieben(72) = "Humiliation"
        vorlieben(73) = "Inflatable Dildo"
        vorlieben(74) = "Insertion"
        vorlieben(75) = "Dogging"
        vorlieben(76) = "Laktophilie"
        vorlieben(77) = "Tease and Denial"
        vorlieben(78) = "Leather"
        vorlieben(79) = "Lingerie"
        vorlieben(80) = "Machine Fucking"
        vorlieben(81) = "Masturbating"
        vorlieben(82) = "No Panties"
        vorlieben(83) = "Unshaved"
        vorlieben(84) = "Oiled"
        vorlieben(85) = "On Her Knees"
        vorlieben(86) = "Latex"
        vorlieben(87) = "Peehole"
        vorlieben(88) = "High Heels"
        vorlieben(89) = "Pissed On"
        vorlieben(90) = "Full Bladder"
        vorlieben(91) = "Pissing"
        vorlieben(92) = "Prostate Massage"
        vorlieben(93) = "Cabling"
        vorlieben(94) = "Pussy Stretching"
        vorlieben(95) = "Pussy Eating"
        vorlieben(96) = "Underwater"
        vorlieben(97) = "Remote Toy"
        vorlieben(98) = "Mirror"
        vorlieben(99) = "Shower Sex"
        vorlieben(100) = "Self Fisting"
        vorlieben(101) = "Sex Tape"
        vorlieben(102) = "Share Wife"
        vorlieben(103) = "Slave / Master (Sub/Dom)"
        vorlieben(104) = "Forbidden Orgasm"
        vorlieben(105) = "Sniffing Panties"
        vorlieben(106) = "Human Toilet"
        vorlieben(107) = "Speculum"
        vorlieben(108) = "Spit"
        vorlieben(109) = "Public Sex"
        vorlieben(110) = "Squirt"
        vorlieben(111) = "Strap-On"
        vorlieben(112) = "Titjob"
        vorlieben(113) = "Threesome"
        vorlieben(114) = "Tit Slap"
        vorlieben(115) = "Zoophilie"




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

        'prüfen ob man am ende der abstimmung angekommen ist
        If zaehler = ZahlenCheck Then
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



        'prüfen ob schon auswertungen da sind für user 1
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If

        'prüfen ob schon auswertungen da sind für user 2
        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If

        'prüfen ob schon auswertungen da sind allgemein
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


        'Abfrage wer dran ist und zählen ob die person schon fertig ist
        If System.IO.File.Exists(path1) And Durchgang1.Checked = True Then
            count1 = System.IO.File.ReadLines(path1).Count()
            If count1 > ZahlenCheck Then

                'Sagen das der durchgang fertig ist und den nächsten einschalten
                MsgBox("Durchgang beendet, bitte die nächste Person...", vbOKOnly, "Erfolg")
                If Durchgang1.Checked Then
                    Durchgang2.Checked = True
                End If

                If System.IO.File.Exists(path2) Then
                    count2 = System.IO.File.ReadLines(path2).Count()
                    If count2 > ZahlenCheck Then
                        Auswerten.Show()
                    End If
                End If

            End If

        ElseIf System.IO.File.Exists(path2) And Durchgang2.Checked = True Then
            count2 = System.IO.File.ReadLines(path2).Count()
            If count2 > ZahlenCheck Then

                'Sagen das der durchgang fertig ist und den nächsten einschalten
                MsgBox("Durchgang beendet, bitte die nächste Person...", vbOKOnly, "Erfolg")
                If Durchgang2.Checked Then
                    Durchgang1.Checked = True
                End If

                If System.IO.File.Exists(path1) Then
                    count1 = System.IO.File.ReadLines(path1).Count()
                    If count1 > ZahlenCheck Then
                        Auswerten.Show()
                    End If
                End If

            End If
        End If


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
        If zaehler = ZahlenCheck Then
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


        'prüfen ob schon auswertungen da sind für user 1
        If System.IO.File.Exists(path1) Then
            VorhandenPerson1.Text = "Daten Vorhanden"
            VorhandenPerson1.ForeColor = Color.Green
        Else
            VorhandenPerson1.Text = "Fehlt"
            VorhandenPerson1.ForeColor = Color.Red
        End If

        'prüfen ob schon auswertungen da sind für user 2
        If System.IO.File.Exists(path2) Then
            VorhandenPerson2.Text = "Daten Vorhanden"
            VorhandenPerson2.ForeColor = Color.Green
        Else
            VorhandenPerson2.Text = "Fehlt"
            VorhandenPerson2.ForeColor = Color.Red
        End If

        'prüfen ob schon auswertungen da sind
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

        'auswerten anzeigen wenn die kinks alle beantwortet wurden
        Dim count1 As Integer
        Dim count2 As Integer

        If System.IO.File.Exists(path1) And Durchgang1.Checked = True Then
            count1 = System.IO.File.ReadLines(path1).Count()
            If count1 > ZahlenCheck Then

                'Sagen das der durchgang fertig ist und den nächsten einschalten
                MsgBox("Durchgang beendet, bitte die nächste Person...", vbOKOnly, "Erfolg")
                If Durchgang1.Checked Then
                    Durchgang2.Checked = True
                End If

                If System.IO.File.Exists(path2) Then
                    count2 = System.IO.File.ReadLines(path2).Count()
                    If count2 > ZahlenCheck Then
                        Auswerten.Show()
                    End If
                End If

            End If
        ElseIf System.IO.File.Exists(path2) And Durchgang2.Checked = True Then
            count2 = System.IO.File.ReadLines(path2).Count()
            If count2 > ZahlenCheck Then

                'Sagen das der durchgang fertig ist und den nächsten einschalten
                MsgBox("Durchgang beendet, bitte die nächste Person...", vbOKOnly, "Erfolg")
                If Durchgang2.Checked Then
                    Durchgang1.Checked = True
                End If

                If System.IO.File.Exists(path1) Then
                    count1 = System.IO.File.ReadLines(path1).Count()
                    If count1 > ZahlenCheck Then
                        Auswerten.Show()
                    End If
                End If

            End If
        End If


    End Sub

    Private Sub Vielleicht_Click(sender As Object, e As EventArgs) Handles Vielleicht.Click

        'buttontext anpassen und spielbereit machen
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
        If zaehler = ZahlenCheck Then
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

        'auswerten anzeigen
        Dim count1 As Integer
        Dim count2 As Integer

        If System.IO.File.Exists(path1) And Durchgang1.Checked = True Then
            count1 = System.IO.File.ReadLines(path1).Count()
            If count1 > ZahlenCheck Then

                'Sagen das der durchgang fertig ist und den nächsten einschalten
                MsgBox("Durchgang beendet, bitte die nächste Person...", vbOKOnly, "Erfolg")
                If Durchgang1.Checked Then
                    Durchgang2.Checked = True
                End If

                If System.IO.File.Exists(path2) Then
                    count2 = System.IO.File.ReadLines(path2).Count()
                    If count2 > ZahlenCheck Then
                        Auswerten.Show()
                    End If
                End If

            End If
        ElseIf System.IO.File.Exists(path2) And Durchgang2.Checked = True Then
            count2 = System.IO.File.ReadLines(path2).Count()
            If count2 > ZahlenCheck Then

                'Sagen das der durchgang fertig ist und den nächsten einschalten
                MsgBox("Durchgang beendet, bitte die nächste Person...", vbOKOnly, "Erfolg")
                If Durchgang2.Checked Then
                    Durchgang1.Checked = True
                End If

                If System.IO.File.Exists(path1) Then
                    count1 = System.IO.File.ReadLines(path1).Count()
                    If count1 > ZahlenCheck Then
                        Auswerten.Show()
                    End If
                End If

            End If


        End If



    End Sub
    Private Sub Translation_Click(sender As Object, e As EventArgs) Handles Translation.Click


        If zaehler = "115" Then

            MsgBox("Durchgang beendet...", vbOKOnly, "Ende")

        ElseIf (zaehler = "0") Then

        Else

            MsgBox(vorlieben_erklaerung(zaehler), vbOKOnly, "Erklärung")

        End If


        vorlieben_erklaerung(0) = "Vorlieben. Die App - So heißt dei App bzw. das Programm was du gerade ausführst."
        vorlieben_erklaerung(1) = "All Holes - Bedeutet interaktion, mit allen [Öffnungen] also zum Beispiel Mund, Vagina, Arsch."
        vorlieben_erklaerung(2) = "Anal - Anal ist der Geschlechtsverkehr mit dem Arsch."
        vorlieben_erklaerung(3) = "Anal Beads - Meistens Kugeln an einem Band, welche in den Po eingeführt werden."
        vorlieben_erklaerung(4) = "Anal Creampie - Das abspritzen in den Po, mit gewolltem tropfen aus dem Po."
        vorlieben_erklaerung(5) = "Anal Dildo - Die stimmulierung des po mit hilfe eines Dildos."
        vorlieben_erklaerung(6) = "Anal Fisting - Das stimmulieren des Po mit der gesamten Hand."
        vorlieben_erklaerung(7) = "Anal Gape - Durch dehnung und training des Po, dafür sorgen, dass der Po quasi offen bleibt für einen Moment."
        vorlieben_erklaerung(8) = "Ass Eating - Das Orale stimmulieren des Po vom Partner."
        vorlieben_erklaerung(9) = "Assfingering - Das stimmulieren des Po durch finger."
        vorlieben_erklaerung(10) = "Ball Licking - Lecken der Hoden durch den Partner."
        vorlieben_erklaerung(11) = "Balloon - Die integration von aufblasbaren Balloons in das Liebesleben"
        vorlieben_erklaerung(12) = "BDSM - Bondage Sadomaso, also Fesseln und das Spiel mit schmerzen bzw. einschränkung des anderen."
        vorlieben_erklaerung(13) = "Beggin - Den Partner um dinge betteln lassen, also die erlaubnis zu kommen oder andere Ziele welche gewünscht sind"
        vorlieben_erklaerung(14) = "Bend Over - Den Partner über Gegenstände beugen und in dieser haltung Geschlechtsverkehr haben."
        vorlieben_erklaerung(15) = "Blindfolded - Verbundene Augen, also dem Partner durch verbinden der Augen die Sicht nehmen."
        vorlieben_erklaerung(16) = "Blowjob - Blasen, also klassischer Oral bei dem männlichen Partner. "
        vorlieben_erklaerung(17) = "Erotic Kissing - Intesives Küssen, meist als Vorspiel und anregung des Partners."
        vorlieben_erklaerung(18) = "Bondage - Fesseln, also alles was unter die Kategorie fesseln fällt."
        vorlieben_erklaerung(19) = "Shaved - Rasiert, das Gegenstück zu [unshaved] also unrasiert. Hier ist der Haarfreie Intimbereich gemeint."
        vorlieben_erklaerung(20) = "Bukkake - Wenn der Männliche Partner dem anderen auf das Gesicht spritzt."
        vorlieben_erklaerung(21) = "Butt Plug - Ein Sexspielzeug, welches in den Po eingeführt wird und wie ein [Stöpsel] getragen werden kann"
        vorlieben_erklaerung(22) = "Cameltoe - Wenn man die Form der Vulva durch ein Kleidungstück erkennen kann, zum Beispiel Leggins, Höschen, Hosen,..."
        vorlieben_erklaerung(23) = "!Ihre Werbung hier! - Mann muss ja auch mal Spaß haben dürfen!"
        vorlieben_erklaerung(24) = "Tentacle - Die integration von Oktopden in das Sexspiel. Ein fetisch welcher in Japan entstanden ist."
        vorlieben_erklaerung(25) = "Cartoon - Allgemeines interesse an gezeichnetem Sexuellen Dingen, auch Hentai zählt dazu."
        vorlieben_erklaerung(26) = "Chastity Belt - Enthaltsamkeitsgürtel, dieser verhindert die Berührung von dem Intimbereich und fällt dadurch in den Bereich BDSM."
        vorlieben_erklaerung(27) = "Clamp - Klammern, diese können an verschiedenen Körperstellen eingesetzt werden. Klassich wären Nippel, Klitoris, empfindliche Bereiche."
        vorlieben_erklaerung(28) = "Clothed Pissing - Das befeuchten von Anziehsachen, die Art und Menge ist dabei offen. Auch durch Squirten kann dabei die Kleidung [Nass] werden."
        vorlieben_erklaerung(29) = "Roleplay - Rollenspiel, sei es der Polizist, die Schülerin oder sonstiges. Alles wo Rollen eingenommen werden."
        vorlieben_erklaerung(30) = "Creampie - Das Abpritzen des Mannes in Körperöffnungen der Partnerin."
        vorlieben_erklaerung(31) = "Crotchless Panties - Höschen, welche an der Vagina eine Öffnung haben und so beim Liebesspiel nicht extra ausgezogen werden müssen."
        vorlieben_erklaerung(32) = "Cuckold Humiliation - Der Partner muss zusehen, während der andere mit einer dritten Person Geschlechtsverkehr hat."
        vorlieben_erklaerung(33) = "Cum On Boobs - Das Abspritzen des Mannes auf die Brüste der Partnerin."
        vorlieben_erklaerung(34) = "Cum In Mouth - Das Abspritzen des Mannes in den Mund der Partnerin."
        vorlieben_erklaerung(35) = "Cum In Pussy - Das Abspritzen des Mannes in die Vagina der Partnerin."
        vorlieben_erklaerung(36) = "Cum On Ass - Das Abspritzen des Mannes auf den po der Partnerin."
        vorlieben_erklaerung(37) = "Double Anal Penetration - Die Stimmulation durch 2 Objekte in den Po. Zum Beispiel: Penis und Dildo, Plug und Penis,..."
        vorlieben_erklaerung(38) = "Deepthroat - Durch das tiefe einführen des Penis in den Mund, eine besondere Stimmulation beim BlowJob erreichen. Oft in BDSM Situationen, da so auch eine gewisse Dominaz gezeigt werden kann."
        vorlieben_erklaerung(39) = "Diaper - Windeln beim Liebesspiel, oft in kombination mit Pinkelvorlieben."
        vorlieben_erklaerung(40) = "Dirty Talk - Meist via Chat, das schreiben von sexuellen Nachrichten."
        vorlieben_erklaerung(41) = "Doctor / Nurse - Krankenschwestern, ähnlich wie beim rolePlaying, nur mit der genauen Art als Krankenschwester."
        vorlieben_erklaerung(42) = "Doggystyle - Sexuelle Position. Aähnlich der, eines Hundes."
        vorlieben_erklaerung(43) = "Double Toying - Das Stimmulieren mit 2 Spielzeugen."
        vorlieben_erklaerung(44) = "Electrified - Einbinden von elktrezität in das Liebesspiel."
        vorlieben_erklaerung(45) = "Enema - Englisch für Einlauf, das Sexuelle einbinden von flüssigkeiten, welche häufig Anal eingeführt werden. Oft auch eine vorbereitung für Analverkehr."
        vorlieben_erklaerung(46) = "Office Sex - Sex im Büro, also im echten oder im Büro zuhause."
        vorlieben_erklaerung(47) = "Face Fuck - Ähnlichkeiten zum BlowJob, jedoch mit mehr dominanz und um hauptsächlich den Mann glücklich zu machen."
        vorlieben_erklaerung(48) = "Face Sitting - Die Dame setzt sich auf das Gesicht des Herren, welcher auf dem Rücken liegt und somit die Dame Oral stimmulieren kann."
        vorlieben_erklaerung(49) = "Farting - Pupsen, auch das kann ein fetisch sein."
        vorlieben_erklaerung(50) = "Femdom - Weibliche dominanz, sie übernimmt die führung und bestimmt, was passieren soll."
        vorlieben_erklaerung(51) = "Fingering Orgasm - Der Orgasmus wird durch das stimmulieren mit den fingern herbeigeführt."
        vorlieben_erklaerung(52) = "Fisting - Das stimmuliren der Vagina mit der gesamten faust."
        vorlieben_erklaerung(53) = "Flogger Whip - Das einbinden von Peitschen, welche mehrere enden haben. Somit also stärker wirken können."
        vorlieben_erklaerung(54) = "Feeding - Fütter, wenn ein partner den anderen füttert. In verschiedenen arten ausgelebt, alles nach absprache."
        vorlieben_erklaerung(55) = "Footjob - Das einbinden von füßen in das Sexleben, oft in Form von Masturbation und Stiummulation durch die Füße des Partners."
        vorlieben_erklaerung(56) = "Foursome - geschlechtsverkehr mit 4 Personen."
        vorlieben_erklaerung(57) = "Furry - Das verkleiden als Tier oder ähnliches in einem Ganzkörperkostüm."
        vorlieben_erklaerung(58) = "Wax - einbinden von heißem Wachs in das Liebesspiel."
        vorlieben_erklaerung(59) = "Gagging - Das Orale stimmulieren bis zum würgereiz des Partners, der Reiz kann durch das tiefe eindringen in den Mund erzeugt werden."
        vorlieben_erklaerung(60) = "Gangbang - Das Liebesspiel mit mehr als 4 Personen, wo jeder mit jedem interagieren kann."
        vorlieben_erklaerung(61) = "Gaping Hole - Durch training und dehnung die Körperöffnungen so weiten, das sie einen Moment geöffnet bleiben."
        vorlieben_erklaerung(62) = "Gloryhole - Ein Loch in einer Wand, durch das das Männliche Glied gesteckt wird, auch der anderen Seite kann die Dame dann Oral die Person befriedigen ohne sie direkt zu sehen."
        vorlieben_erklaerung(63) = "Gloves - Das einbinden von Handschuhen beim Sex."
        vorlieben_erklaerung(64) = "Romantic Sex - Romantischer Sex, mit Kerzen, Rosen und weiterem romantischen Dingen."
        vorlieben_erklaerung(65) = "Biting - Beißen un Knabbern am Partner beim Sex."
        vorlieben_erklaerung(66) = "Gynecologist - Frauenarzt bzw. Arzt allgemein. Der Fetisch, welche Spielzeuge einschließt, wie sie bei Ärzten genutzt werden."
        vorlieben_erklaerung(67) = "Missionary - Missionarsstellung, sie liegt breitbeinig auf dem Rücken, er auf ihr."
        vorlieben_erklaerung(68) = "Hair Pulling - haare ziehen beim Sex, dadurch kann Dominanz gezeigt werden, mit macht und schmerzen gespielt werden."
        vorlieben_erklaerung(69) = "Vegetable - Das einbinden von Gemüse und Früchten beim Sex, durch einführen oder ähnliches."
        vorlieben_erklaerung(70) = "Handcuffed - Handfesseln, der kalssiker beim BDSM Sex, die Handschellen."
        vorlieben_erklaerung(71) = "Handjob - Die Partnerin holt dem mann einen runter bzw. stimmuliert ihn mit der Hand."
        vorlieben_erklaerung(72) = "Humiliation - Ernidrigen der Partnerin, also durch verbieten von handlungen oder ähnliches, den Partner degradieren."
        vorlieben_erklaerung(73) = "Inflatable Dildo - Aufblasbarer Dildo, mit Luft befüllbar und dadurch in Größe veränderbare Spielzeuge."
        vorlieben_erklaerung(74) = "Insertion - Einführen von verschiedenen undefinierten Dingen zur stimmulatiuon des Partners."
        vorlieben_erklaerung(75) = "Dogging - Das zusehen wenn ein andere pärchen miteinander schläft, fällt in die kategorie Voyorismus,"
        vorlieben_erklaerung(76) = "Laktophilie - Die Brüste der Partnerin so berühren und daran saugen, um die Milchproduktion vom Körper zu erzeugen und zu fördern."
        vorlieben_erklaerung(77) = "Tease and Denial - Den Partner immer wieder bis knapp vor den Orgasmus bringen um ihn dann nicht zum höhepunkt kommen zu lassen."
        vorlieben_erklaerung(78) = "Leather - Leder als Kelidung oder als Peitsche beim Liebesspiel."
        vorlieben_erklaerung(79) = "Lingerie - Allgemein Unterwäsche, also Sexy und Erregend oder auch beim Sex benutzt."
        vorlieben_erklaerung(80) = "Machine Fucking - Das nutzen von  Maschinen beim Liebesspiel, also wie ein Dildo, welcher durch eine Maschine vor und zurück bewegt wird."
        vorlieben_erklaerung(81) = "Masturbating - Der fetisch, dem partner bei der masturbation zuzusehen."
        vorlieben_erklaerung(82) = "No Panties - Kein Höschen, also der Partner der keine Unterwäsche trägt."
        vorlieben_erklaerung(83) = "Unshaved - Unrasiert, der Konterpart zu Shaved. Also keine rasur im Intimbereich."
        vorlieben_erklaerung(84) = "Oiled - Das Einbinden von ÖL im Liebesspiel, gut für massagen oder als Gleitmittel."
        vorlieben_erklaerung(85) = "On Her Knees - Auf den Knien, ein spiel mit Dominanz und Unterwürfigkeit."
        vorlieben_erklaerung(86) = "Latex - Einbinden von Latexdessous und Latex Kleidung in das Liebesspiel."
        vorlieben_erklaerung(87) = "Peehole - Das Stimmulieren von dem Harnkanal, welches ein besonderes Sexuelles vergnügen erzeugen kann."
        vorlieben_erklaerung(88) = "High Heels - Das tragen von High Heels allgemein als Sexueller anreiz."
        vorlieben_erklaerung(89) = "Pissed On - Das Urinieren auf den Partner oder Kleidung etc."
        vorlieben_erklaerung(90) = "Full Bladder - Das Spielen mit der vollen Blase und dem drang auf die toilette zu gehen, fällt in die Kategorie der Dominanz."
        vorlieben_erklaerung(91) = "Pissing - Das beobachten bei Pinkeln oder auch die beeinflussung des Partners beim wasserlassen. Hier kann dominanz ohne berührungen gezeigt werden."
        vorlieben_erklaerung(92) = "Prostate Massage - Das massieren der Prostata beim Mann."
        vorlieben_erklaerung(93) = "Cabling - Kabbeln und leichtes kämpfen im Bett."
        vorlieben_erklaerung(94) = "Pussy Stretching - Das dehnen der vagina mit Spielzeugen und den Fingern."
        vorlieben_erklaerung(95) = "Pussy Eating - Das Orale befriedigen der partnerin mit dem Mund und der Zunge."
        vorlieben_erklaerung(96) = "Underwater"
        vorlieben_erklaerung(97) = "Remote Toy"
        vorlieben_erklaerung(98) = "Mirror"
        vorlieben_erklaerung(99) = "Shower Sex"
        vorlieben_erklaerung(100) = "Self Fisting"
        vorlieben_erklaerung(101) = "Sex Tape"
        vorlieben_erklaerung(102) = "Share Wife"
        vorlieben_erklaerung(103) = "Slave / Master (Sub/Dom)"
        vorlieben_erklaerung(104) = "Forbidden Orgasm"
        vorlieben_erklaerung(105) = "Sniffing Panties"
        vorlieben_erklaerung(106) = "Human Toilet"
        vorlieben_erklaerung(107) = "Speculum"
        vorlieben_erklaerung(108) = "Spit"
        vorlieben_erklaerung(109) = "Public Sex"
        vorlieben_erklaerung(110) = "Squirt"
        vorlieben_erklaerung(111) = "Strap-On"
        vorlieben_erklaerung(112) = "Titjob"
        vorlieben_erklaerung(113) = "Threesome"
        vorlieben_erklaerung(114) = "Tit Slap"
        vorlieben_erklaerung(115) = "Zoophilie - Die integration von Tieren in das Liebesspiel."




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
        If count1 <= ZahlenCheck Then
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
        If count2 <= ZahlenCheck Then
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
            i = ZahlenCheck + 1
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
        Do While i <= ZahlenCheck

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
        If jaCounter1 > ZahlenCheck Then
            MsgBox("Warnung, hier wurde von Nummer 1 JA/Vielleicht gespamt!", vbOKOnly, "Spam Detector")
        End If

        If jaCounter2 > ZahlenCheck Then
            MsgBox("Warnung, hier wurde von Nummer 2 JA/Vielleicht gespamt!", vbOKOnly, "Spam Detector")
        End If

        If neinCounter1 > ZahlenCheck Then
            MsgBox("Warnung, hier wurde von Nummer 1 alles mit Nein beantwortet.", vbOKOnly, "Spam Detector")
        End If

        If neinCounter2 > ZahlenCheck Then
            MsgBox("Warnung, hier wurde von Nummer 2 alles mit Nein beantwortet.", vbOKOnly, "Spam Detector")
        End If

        If zurucksetzten = 1 Then
            i = 0
        End If


        If System.IO.File.Exists(path3) Then

            'Auswertung direkt öffnen und dem nutzer anzeigen

            Process.Start(("notepad.exe"), path3)

        Else

        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim value As String
        value = VorliebeText.Text

        'abfrage ob man den titel oder das fertig zur pornoseite schicken will
        If value Like "Vorlieben. Die App" Or VorliebeText.Text Like "!FERTIG!" Then
            MsgBox("Hier kannst du den Fetisch auf einer Pornoseite suchen.", vbOKOnly, "Fehler")

        Else
            'Text anpassen das ein browser ihn öffnen kann durch löschen von leerzeichen und ersetzten durch unterstrich
            Dim aString As String = Replace(value, " ", "_")

            'öffnen des browsers
            If Browser = "FireFox" Then
                Process.Start(("C:\Program Files\Mozilla Firefox\private_browsing.exe"), "https://www.xnxx.com/search/" + aString)
            ElseIf Browser = "Edge" Then
                Process.Start(("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"), "https://www.xnxx.com/search/" + aString)
            ElseIf Browser = "Unbekannt" Then
                MsgBox("Es wurde kein passender Browser gefunden. Bitte FireFox oder Edge installieren.", vbOKOnly, "Fehler")
                Me.Close()
                dr = DialogResult.OK
            End If


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

    Private Sub Haupt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing



        dr = MessageBox.Show("Wollen sie wirklich beenden?", "Sind sie sicher?", MessageBoxButtons.OKCancel)
        If dr = DialogResult.OK Then

            'Programm beenden und abgegebene Stimmen löschen
            If System.IO.File.Exists(path1) Then
                My.Computer.FileSystem.DeleteFile(path1)
            End If
            If System.IO.File.Exists(path2) Then
                My.Computer.FileSystem.DeleteFile(path2)
            End If


            '#########################################################verlauf history löschen#################################################################################

            'Abfrage welcher browser läuft und löschen der History
            If Browser = "Edge" Then

                'den edgebrowser task beenden der vllt gestartet wurde
                Dim TskKill_Edge As New ProcessStartInfo("Taskkill.exe")
                TskKill_Edge.Arguments = "/F /IM MSEdge.exe /T"
                Process.Start(TskKill_Edge)

                'das system einen moment warten lasen
                System.Threading.Thread.Sleep(200)

                'prüfen ob es eine history gibt und wenn ja löschen
                If System.IO.File.Exists("C:\Users\" & Environ("Username") & "\AppData\Local\Microsoft\Edge\User Data\Default\History") Then

                    Try
                        System.IO.File.Delete("C:\Users\" & Environ("Username") & "\AppData\Local\Microsoft\Edge\User Data\Default\History")
                    Catch

                        MsgBox("Es konnte der Browserverlauf nicht gelöscht werden. Bitte die Datei History selbst löschen!", vbOKOnly, "Vorsicht! Browserverlauf!")

                        'Process.Start("explorer.exe", String.Format("/n, /e, {0}", "C:\Users\" & Environ("Username") & "\AppData\Local\Microsoft\Edge\User Data\Default"))

                        System.Diagnostics.Process.Start("explorer.exe", "/select," & "C:\Users\" & Environ("Username") & "\AppData\Local\Microsoft\Edge\User Data\Default\History")

                        'nochmals kurz warten und dann programm beenden
                        System.Threading.Thread.Sleep(100)

                    End Try
                End If

            Else
                'nichts machen, weil es eh firefox im privaten ist
            End If

            'wenn man bei der sicherheitsfrage nein sagt, startet das programm den notfallplan
        ElseIf dr = DialogResult.Cancel Then

            Global.Vorlieben.Starter.Show()
            '  er ist unsicher -- wir gehen auf start zurück
        End If

        'alles schließen was noch da ist oder vllt im hintergrund offen
        Global.Vorlieben.Optionen.Close()
        Global.Vorlieben.Starter.Close()


    End Sub

    Private Sub Zuruck_Click(sender As Object, e As EventArgs) Handles Zuruck.Click

        'letzter Eintrag löschen in der eigenen Asuwertung
        Dim Zeilen() As String
        Dim Count As Integer = 0


        'prüfen wer spielt
        If Durchgang1.Checked Then
            path = path1
        Else
            path = path2
        End If

        'prüfen ob eine Datei da ist, in der man einen zurückspringen kann
        If System.IO.File.Exists(path) Then

            Dim SR As IO.StreamReader = New IO.StreamReader(path)
            While SR.Peek > -1
                ReDim Preserve Zeilen(Count)
                Zeilen(Count) = SR.ReadLine
                Count += 1
            End While
            SR.Close()
        Else
            'wenn die datei fehlt, soll nichts passieren
        End If

        If zaehler <= 0 Then

            'nichts soll passieren wenn man am "start" ist

        ElseIf zaehler >= 0 Then

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

        End If

    End Sub


End Class
