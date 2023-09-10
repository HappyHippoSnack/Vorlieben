<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Haupt
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Haupt))
        Ja = New Button()
        Vielleicht = New Button()
        Nein = New Button()
        VorliebeText = New Label()
        PictureBox1 = New PictureBox()
        Auswerten = New Button()
        Durchgang1 = New CheckBox()
        Durchgang2 = New CheckBox()
        VorhandenPerson1 = New Label()
        VorhandenPerson2 = New Label()
        Label1 = New Label()
        Auswertung = New Label()
        ProgressBar1 = New ProgressBar()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        OptionenButton = New Button()
        Zuruck = New Button()
        Translation = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Ja
        ' 
        Ja.BackColor = Color.Lime
        Ja.Location = New Point(48, 361)
        Ja.Name = "Ja"
        Ja.Size = New Size(196, 54)
        Ja.TabIndex = 0
        Ja.Text = "Ja"
        Ja.UseVisualStyleBackColor = False
        ' 
        ' Vielleicht
        ' 
        Vielleicht.BackColor = Color.Yellow
        Vielleicht.Location = New Point(312, 361)
        Vielleicht.Name = "Vielleicht"
        Vielleicht.Size = New Size(196, 54)
        Vielleicht.TabIndex = 1
        Vielleicht.Text = "Interessiert"
        Vielleicht.UseVisualStyleBackColor = False
        ' 
        ' Nein
        ' 
        Nein.BackColor = Color.Red
        Nein.Location = New Point(573, 361)
        Nein.Name = "Nein"
        Nein.Size = New Size(196, 54)
        Nein.TabIndex = 2
        Nein.Text = "Nein"
        Nein.UseVisualStyleBackColor = False
        ' 
        ' VorliebeText
        ' 
        VorliebeText.AutoSize = True
        VorliebeText.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        VorliebeText.Location = New Point(210, 58)
        VorliebeText.Name = "VorliebeText"
        VorliebeText.Size = New Size(433, 65)
        VorliebeText.TabIndex = 3
        VorliebeText.Text = "Vorlieben. Die App."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.Screenshot_2021_12_06_011629
        PictureBox1.InitialImage = My.Resources.Resources.Screenshot_2021_12_06_011629
        PictureBox1.Location = New Point(286, 165)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(255, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Auswerten
        ' 
        Auswerten.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Auswerten.Location = New Point(312, 290)
        Auswerten.Name = "Auswerten"
        Auswerten.Size = New Size(196, 65)
        Auswerten.TabIndex = 6
        Auswerten.Text = "Auswerten"
        Auswerten.UseVisualStyleBackColor = True
        Auswerten.Visible = False
        ' 
        ' Durchgang1
        ' 
        Durchgang1.AutoSize = True
        Durchgang1.Location = New Point(12, 12)
        Durchgang1.Name = "Durchgang1"
        Durchgang1.Size = New Size(71, 19)
        Durchgang1.TabIndex = 7
        Durchgang1.Text = "Person 1"
        Durchgang1.UseVisualStyleBackColor = True
        ' 
        ' Durchgang2
        ' 
        Durchgang2.AutoSize = True
        Durchgang2.Location = New Point(12, 37)
        Durchgang2.Name = "Durchgang2"
        Durchgang2.Size = New Size(71, 19)
        Durchgang2.TabIndex = 8
        Durchgang2.Text = "Person 2"
        Durchgang2.UseVisualStyleBackColor = True
        ' 
        ' VorhandenPerson1
        ' 
        VorhandenPerson1.AutoSize = True
        VorhandenPerson1.Location = New Point(100, 13)
        VorhandenPerson1.Name = "VorhandenPerson1"
        VorhandenPerson1.Size = New Size(98, 15)
        VorhandenPerson1.TabIndex = 9
        VorhandenPerson1.Text = "Daten Vorhanden"
        ' 
        ' VorhandenPerson2
        ' 
        VorhandenPerson2.AutoSize = True
        VorhandenPerson2.Location = New Point(100, 38)
        VorhandenPerson2.Name = "VorhandenPerson2"
        VorhandenPerson2.Size = New Size(98, 15)
        VorhandenPerson2.TabIndex = 10
        VorhandenPerson2.Text = "Daten Vorhanden"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 11
        Label1.Text = "Auswertung"
        ' 
        ' Auswertung
        ' 
        Auswertung.AutoSize = True
        Auswertung.Location = New Point(100, 59)
        Auswertung.Name = "Auswertung"
        Auswertung.RightToLeft = RightToLeft.No
        Auswertung.Size = New Size(98, 15)
        Auswertung.TabIndex = 12
        Auswertung.Text = "Daten Vorhanden"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.Blue
        ProgressBar1.Location = New Point(312, 425)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(196, 23)
        ProgressBar1.TabIndex = 14
        ' 
        ' OptionenButton
        ' 
        OptionenButton.Location = New Point(8, 77)
        OptionenButton.Name = "OptionenButton"
        OptionenButton.Size = New Size(75, 23)
        OptionenButton.TabIndex = 15
        OptionenButton.Text = "Optionen"
        OptionenButton.UseVisualStyleBackColor = True
        ' 
        ' Zuruck
        ' 
        Zuruck.Location = New Point(637, 423)
        Zuruck.Name = "Zuruck"
        Zuruck.Size = New Size(75, 23)
        Zuruck.TabIndex = 17
        Zuruck.Text = "Zurück"
        Zuruck.UseVisualStyleBackColor = True
        ' 
        ' Translation
        ' 
        Translation.BackColor = Color.Beige
        Translation.Cursor = Cursors.Help
        Translation.Location = New Point(573, 200)
        Translation.Name = "Translation"
        Translation.Size = New Size(150, 37)
        Translation.TabIndex = 18
        Translation.Text = "Übersetzung / Erklärung"
        Translation.UseVisualStyleBackColor = False
        ' 
        ' Haupt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Translation)
        Controls.Add(Zuruck)
        Controls.Add(OptionenButton)
        Controls.Add(ProgressBar1)
        Controls.Add(Auswertung)
        Controls.Add(Label1)
        Controls.Add(VorhandenPerson2)
        Controls.Add(VorhandenPerson1)
        Controls.Add(Durchgang2)
        Controls.Add(Durchgang1)
        Controls.Add(Auswerten)
        Controls.Add(PictureBox1)
        Controls.Add(VorliebeText)
        Controls.Add(Nein)
        Controls.Add(Vielleicht)
        Controls.Add(Ja)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Haupt"
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Vorlieben"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ja As Button
    Friend WithEvents Vielleicht As Button
    Friend WithEvents Nein As Button
    Friend WithEvents VorliebeText As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Auswerten As Button
    Friend WithEvents Durchgang1 As CheckBox
    Friend WithEvents Durchgang2 As CheckBox
    Friend WithEvents VorhandenPerson1 As Label
    Friend WithEvents VorhandenPerson2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Auswertung As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OptionenButton As Button
    Friend WithEvents Zuruck As Button
    Friend WithEvents Translation As Button
End Class
