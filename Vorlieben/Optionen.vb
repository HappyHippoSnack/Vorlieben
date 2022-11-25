Public Class Optionen

    'den pfad der zu speichernden datei angeben
    Dim path As String
    Dim path1 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB1.txt"
    Dim path2 As String = "C:\Users\" & Environ("Username") & "\Desktop\VorliebenDB2.txt"
    Dim path3 As String = "C:\Users\" & Environ("Username") & "\Desktop\Auswertung.txt"

    'Antwortenzähler erstellen
    Dim count1
    Dim count2


    Private Sub Optionen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Zeilen der Textdateien werden gezählt 
        If System.IO.File.Exists(path1) Then
            count1 = System.IO.File.ReadLines(path1).Count()
        End If
        If System.IO.File.Exists(path2) Then
            count2 = System.IO.File.ReadLines(path2).Count()
        End If

        'Anzeigen der vorhandenen Antworten
        If System.IO.File.Exists(path1) Then
            Antworten1.Text = count1
        End If
        If System.IO.File.Exists(path2) Then
            Antworten2.Text = count2
        End If



    End Sub

    Private Sub Optionen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Haupt.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        'prüfen ob schon auswertungen da sind
        If System.IO.File.Exists(path1) Then
            Haupt.VorhandenPerson1.Text = "Daten Vorhanden"
            Haupt.VorhandenPerson1.ForeColor = Color.Green
        Else
            Haupt.VorhandenPerson1.Text = "Fehlt"
            Haupt.VorhandenPerson1.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path2) Then
            Haupt.VorhandenPerson2.Text = "Daten Vorhanden"
            Haupt.VorhandenPerson2.ForeColor = Color.Green
        Else
            Haupt.VorhandenPerson2.Text = "Fehlt"
            Haupt.VorhandenPerson2.ForeColor = Color.Red
        End If


        If System.IO.File.Exists(path3) Then
            Haupt.Auswertung.Text = "Daten Vorhanden"
            Haupt.Auswertung.ForeColor = Color.Green
        Else
            Haupt.Auswertung.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        End If

        Haupt.Show()
        Me.Close()
    End Sub

    Private Sub Person1loeschen_Click(sender As Object, e As EventArgs) Handles Person1loeschen.Click
        If System.IO.File.Exists(path1) Then
            My.Computer.FileSystem.DeleteFile(path1)
        Else
            Antworten1.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        End If
        count1 = 0
        'Anzeigen der vorhandenen Antworten
        Antworten1.Text = count1
    End Sub

    Private Sub Person2loeschen_Click(sender As Object, e As EventArgs) Handles Person2loeschen.Click
        If System.IO.File.Exists(path2) Then
            My.Computer.FileSystem.DeleteFile(path2)
        Else
            Antworten2.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        End If
        count2 = 0
        'Anzeigen der vorhandenen Antworten
        Antworten2.Text = count2
    End Sub

    Private Sub Auswertungloeschen_Click(sender As Object, e As EventArgs) Handles Auswertungloeschen.Click

        If System.IO.File.Exists(path3) Then
            My.Computer.FileSystem.DeleteFile(path3)
        End If

        If System.IO.File.Exists(path3) Then
            Auswertung.Text = "Vorhanden"
        Else
            Auswertung.Text = "Fehlt"
            Haupt.Auswertung.ForeColor = Color.Red
        End If
        'Anzeigen der vorhandenen Antworten

    End Sub
End Class