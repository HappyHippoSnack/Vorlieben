Public Class Optionen

    'den pfad der zu speichernden datei angeben
    Dim path As String
    Dim path1 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB1.txt"
    Dim path2 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB2.txt"
    Dim path3 As String = "C:\Users\" & Environ("Username") & "\Desktop\Auswertung.txt"

    'Antwortenzähler erstellen
    Dim count1
    Dim count2
    Dim count3


    Private Sub Optionen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'version korrekt anzeigen
        Version.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString)

        'Zeilen der Textdateien werden gezählt 
        If System.IO.File.Exists(path1) Then
            count1 = System.IO.File.ReadLines(path1).Count()
        End If
        If System.IO.File.Exists(path2) Then
            count2 = System.IO.File.ReadLines(path2).Count()
        End If
        If System.IO.File.Exists(path3) Then
            count3 = System.IO.File.ReadLines(path3).Count()
        End If

        'Anzeigen der bisher vorhandenen Antworten
        If System.IO.File.Exists(path1) Then
            Antworten1.Text = count1
        End If
        If System.IO.File.Exists(path2) Then
            Antworten2.Text = count2
        End If

        'prüfen ob eine auswertung vorhanden ist und die anzahl stimmt
        If System.IO.File.Exists(path3) Then
            If count3 >= 116 Then
                Auswertung.Text = "Auswertung vorhanden"
                Me.Auswertung.ForeColor = Color.Green
            ElseIf count3 <= 116 Then
                Auswertung.Text = "!Auswertung Fehlerhaft!"
                Me.Auswertung.ForeColor = Color.Red

            End If
        Else
            'setzten der richtigen farbe wenn die auswertung weg ist, dazu anpassen des textes
            Auswertung.Text = "Fehlt"
            Me.Auswertung.ForeColor = Color.Red
        End If


    End Sub

    Private Sub Optionen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Haupt.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        'prüfen ob schon auswertungen da sind von user 1
        If System.IO.File.Exists(path1) Then
            Haupt.VorhandenPerson1.Text = "Daten Vorhanden"
            Haupt.VorhandenPerson1.ForeColor = Color.Green
        Else
            Haupt.VorhandenPerson1.Text = "Fehlt"
            Haupt.VorhandenPerson1.ForeColor = Color.Red
        End If

        'prüfen ob schon auswertungen da sind von user 2
        If System.IO.File.Exists(path2) Then
            Haupt.VorhandenPerson2.Text = "Daten Vorhanden"
            Haupt.VorhandenPerson2.ForeColor = Color.Green
        Else
            Haupt.VorhandenPerson2.Text = "Fehlt"
            Haupt.VorhandenPerson2.ForeColor = Color.Red
        End If

        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path3) Then
            Haupt.Auswertung.Text = "Daten Vorhanden"
            Haupt.Auswertung.ForeColor = Color.Green
        Else
            Haupt.Auswertung.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        End If

        'optionen schließen und die korrekte Form anzeigen
        Haupt.Show()
        Me.Close()
    End Sub

    Private Sub Person1loeschen_Click(sender As Object, e As EventArgs) Handles Person1loeschen.Click

        'Abfrage ob es eine abstimmung von user 1 gibt welche gelöscht werden kann, wenn ja, dann löschen
        If System.IO.File.Exists(path1) Then
            My.Computer.FileSystem.DeleteFile(path1)
            Antworten1.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        Else
            MsgBox("!!Die Auswertung von User 1 konnte nicht gelöscht werden!!")
        End If

        'setzten der richtigen zahl wenn die auswertung weg ist
        count1 = 0
        Antworten1.Text = count1

    End Sub

    Private Sub Person2loeschen_Click(sender As Object, e As EventArgs) Handles Person2loeschen.Click

        'Abfrage ob es eine abstimmung von user 2 gibt welche gelöscht werden kann, wenn ja, dann löschen
        If System.IO.File.Exists(path2) Then
            My.Computer.FileSystem.DeleteFile(path2)
            Antworten2.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        Else
            MsgBox("!!Die Auswertung von User 2 konnte nicht gelöscht werden!!")
        End If

        'setzten der richtigen zahl wenn die auswertung weg ist
        count2 = 0
        Antworten2.Text = count2

    End Sub

    Private Sub Auswertungloeschen_Click(sender As Object, e As EventArgs) Handles Auswertungloeschen.Click

        'abfrage ob eine auswertung vorhanden ist und dann löschen
        If System.IO.File.Exists(path3) Then
            My.Computer.FileSystem.DeleteFile(path3)
        End If

        'Abfragen ob die auswertung wirklich gelöscht wurde, wenn nicht warnen
        If System.IO.File.Exists(path3) Then
            Auswertung.Text = "!!Die Auswertung konnte nicht gelöscht werden!!"
        Else
            'setzten der richtigen farbe wenn die auswertung weg ist, dazu anpassen des textes
            Auswertung.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        End If


    End Sub


End Class