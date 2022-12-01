Public Class Starter


    Dim DBzaehler As Int32


    Public Sub Starter_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'version korrekt anzeigen
        Version.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString)

    End Sub


    Private Sub Starter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Haupt.Show()
    End Sub

    Public Sub Verstanden_Click(sender As Object, e As EventArgs) Handles Verstanden.Click


        Haupt.Show()
        System.Threading.Thread.Sleep(100)
        Me.Hide()


    End Sub


    Private Sub Anleitung_Click(sender As Object, e As EventArgs) Handles Anleitung.Click

        Anleitung_Nutzer.Show()
        Me.Hide()

    End Sub

    Private Sub BrowserCheck_Click(sender As Object, e As EventArgs) Handles BrowserCheck.Click

        Dim value As String
        value = "Ich bin ein Test"
        Dim aString As String = Replace(value, " ", "_")

        'Process.Start(("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"), "https://www.test.de/"+ aString)
        Process.Start(("C:\Program Files\Mozilla Firefox\private_browsing.exe"), "https://www.test.de/" + aString)


    End Sub
End Class