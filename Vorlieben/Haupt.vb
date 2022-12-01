Imports System.IO
Imports System.Text

Public Class Haupt

    'den pfad der zu speichernden datei angeben
    Dim path As String
    Dim path1 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB1"
    Dim path2 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB2"
    Dim path3 As String = "C:\Users\" & Environ("Username") & "\Desktop\Auswertung.txt"
    Dim historyEdge As String = "C:\Users\" & Environ("Username") & "\AppData\Local\Microsoft\Edge\User Data\Default\History"
    Dim link As String
    'BrowserAbfrage welcher Browser genutzt werden soll
    Dim Browser As String = "Unbekannt"
    'Abfrage der WindowsForms beim schließen
    Dim dr As Windows.Forms.DialogResult


    'pfad der auswertung anpassen, so dass die dateien immer neben dem projekt liegen
    'Dim path1 As String = Application.StartupPath + "VorliebenDB1.txt"
    'Dim path2 As String = Application.StartupPath + "VorliebenDB2.txt"
    'Dim path3 As String = Application.StartupPath + "Auswertung.txt"

    'array erzeugen welches 1116 stellen hat, gefüll tmit allen kinks
    Dim vorlieben(116) As String


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





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'zähler alle auf 0 setzten
        Dim zaehler = 0
        Dim jaCounter1 = 0
        Dim jaCounter2 = 0


        'Browser installation prüfen und korrekten Browser einstellen
        Try
            'Prüfen ob es den Firefox mit privatem Browser gibt...
            If System.IO.File.Exists("C:\Program Files\Mozilla Firefox\private_browsing.exe") Then
                Browser = "FireFox"
            End If

        Catch ex As Exception

            'prüfen ob Edge isntalliert ist und nutzen
            If System.IO.File.Exists("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe") Then
                Browser = "Edge"
            End If


        End Try

        'für den fall, dass weder edge noch firefox da ist hat man pech und muss eben firefox installieren
        If Browser = "Unbekannt" Then

            'Begründung warum das programm nicht klappen kann
            MsgBox("Bitte FireFox oder Edge installieren! Ohne einen der beiden, geht es nicht!")

            'Das programm wird beendet, egal was man auswählt, weil kein passender browser da ist
            Me.Close()
            dr = DialogResult.OK

        Else
            'nichts machen weil alles passt und es losgehen kann!
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
        vorlieben(13) = "Begging"
        vorlieben(14) = "Bend Over"
        vorlieben(15) = "Blindfolded"
        vorlieben(16) = "Blowjob"
        vorlieben(17) = "Erotic Kissing"
        vorlieben(18) = "Bondage"
        vorlieben(19) = "Shaved"
        vorlieben(20) = "Bukkake"
        vorlieben(21) = "Butt Plug"
        vorlieben(22) = "Cameltoe"
        vorlieben(23) = "Hier könnte Ihre Werbung stehen"
        vorlieben(24) = "Tentacle"
        vorlieben(25) = "Cartoon"
        vorlieben(26) = "Chastity Belt"
        vorlieben(27) = "Clamp"
        vorlieben(28) = "Clothed Pissing"
        vorlieben(29) = "Roleplay"
        vorlieben(30) = "Creampie"
        vorlieben(31) = "Crotchless Panties"
        vorlieben(32) = "Cuckold Humiliation"
        vorlieben(33) = "Cum On Face"
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
        vorlieben(75) = "Vaginal Cumshot"
        vorlieben(76) = "Vacuum"
        vorlieben(77) = "Urethra"
        vorlieben(78) = "Leather"
        vorlieben(79) = "Lingerie"
        vorlieben(80) = "Machine Fucking"
        vorlieben(81) = "Masturbating"
        vorlieben(82) = "No Panties"
        vorlieben(83) = "Unshaved"
        vorlieben(84) = "Oiled"
        vorlieben(85) = "On Her Knees"
        vorlieben(86) = "Ball Sucking"
        vorlieben(87) = "Peehole"
        vorlieben(88) = "Pegging"
        vorlieben(89) = "Pissed On"
        vorlieben(90) = "Pissing"
        vorlieben(91) = "Prolapse"
        vorlieben(92) = "Prostate Massage"
        vorlieben(93) = "Public Anal Sex"
        vorlieben(94) = "Pussy Stretching"
        vorlieben(95) = "Pussy Eating"
        vorlieben(96) = "Underwater"
        vorlieben(97) = "Remote Toy"
        vorlieben(98) = "Toys"
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

        'prüfen ob man am ende angekommen ist
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

    Private Sub Haupt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing



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

                    End Try
                End If

            Else
                'nichts machen, weil es eh firefox im privaten ist
            End If




            'nochmals kurz warten und dann weiter
            'System.Threading.Thread.Sleep(200)


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
