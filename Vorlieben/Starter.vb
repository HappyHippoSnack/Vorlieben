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
End Class