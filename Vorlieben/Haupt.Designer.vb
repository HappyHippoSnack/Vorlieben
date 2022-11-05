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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Haupt))
        Me.Ja = New System.Windows.Forms.Button()
        Me.Vielleicht = New System.Windows.Forms.Button()
        Me.Nein = New System.Windows.Forms.Button()
        Me.VorliebeText = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Auswerten = New System.Windows.Forms.Button()
        Me.Durchgang1 = New System.Windows.Forms.CheckBox()
        Me.Durchgang2 = New System.Windows.Forms.CheckBox()
        Me.VorhandenPerson1 = New System.Windows.Forms.Label()
        Me.VorhandenPerson2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Auswertung = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OptionenButton = New System.Windows.Forms.Button()
        Me.Zuruck = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ja
        '
        Me.Ja.BackColor = System.Drawing.Color.Lime
        Me.Ja.Location = New System.Drawing.Point(48, 361)
        Me.Ja.Name = "Ja"
        Me.Ja.Size = New System.Drawing.Size(196, 54)
        Me.Ja.TabIndex = 0
        Me.Ja.Text = "Ja"
        Me.Ja.UseVisualStyleBackColor = False
        '
        'Vielleicht
        '
        Me.Vielleicht.BackColor = System.Drawing.Color.Yellow
        Me.Vielleicht.Location = New System.Drawing.Point(312, 361)
        Me.Vielleicht.Name = "Vielleicht"
        Me.Vielleicht.Size = New System.Drawing.Size(196, 54)
        Me.Vielleicht.TabIndex = 1
        Me.Vielleicht.Text = "Interessiert"
        Me.Vielleicht.UseVisualStyleBackColor = False
        '
        'Nein
        '
        Me.Nein.BackColor = System.Drawing.Color.Red
        Me.Nein.Location = New System.Drawing.Point(573, 361)
        Me.Nein.Name = "Nein"
        Me.Nein.Size = New System.Drawing.Size(196, 54)
        Me.Nein.TabIndex = 2
        Me.Nein.Text = "Nein"
        Me.Nein.UseVisualStyleBackColor = False
        '
        'VorliebeText
        '
        Me.VorliebeText.AutoSize = True
        Me.VorliebeText.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VorliebeText.Location = New System.Drawing.Point(210, 58)
        Me.VorliebeText.Name = "VorliebeText"
        Me.VorliebeText.Size = New System.Drawing.Size(433, 65)
        Me.VorliebeText.TabIndex = 3
        Me.VorliebeText.Text = "Vorlieben. Die App."
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Vorlieben.My.Resources.Resources.Screenshot_2021_12_06_011629
        Me.PictureBox1.InitialImage = Global.Vorlieben.My.Resources.Resources.Screenshot_2021_12_06_011629
        Me.PictureBox1.Location = New System.Drawing.Point(286, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Auswerten
        '
        Me.Auswerten.Location = New System.Drawing.Point(70, 421)
        Me.Auswerten.Name = "Auswerten"
        Me.Auswerten.Size = New System.Drawing.Size(152, 25)
        Me.Auswerten.TabIndex = 6
        Me.Auswerten.Text = "Auswerten"
        Me.Auswerten.UseVisualStyleBackColor = True
        '
        'Durchgang1
        '
        Me.Durchgang1.AutoSize = True
        Me.Durchgang1.Location = New System.Drawing.Point(12, 12)
        Me.Durchgang1.Name = "Durchgang1"
        Me.Durchgang1.Size = New System.Drawing.Size(71, 19)
        Me.Durchgang1.TabIndex = 7
        Me.Durchgang1.Text = "Person 1"
        Me.Durchgang1.UseVisualStyleBackColor = True
        '
        'Durchgang2
        '
        Me.Durchgang2.AutoSize = True
        Me.Durchgang2.Location = New System.Drawing.Point(12, 37)
        Me.Durchgang2.Name = "Durchgang2"
        Me.Durchgang2.Size = New System.Drawing.Size(71, 19)
        Me.Durchgang2.TabIndex = 8
        Me.Durchgang2.Text = "Person 2"
        Me.Durchgang2.UseVisualStyleBackColor = True
        '
        'VorhandenPerson1
        '
        Me.VorhandenPerson1.AutoSize = True
        Me.VorhandenPerson1.Location = New System.Drawing.Point(100, 13)
        Me.VorhandenPerson1.Name = "VorhandenPerson1"
        Me.VorhandenPerson1.Size = New System.Drawing.Size(98, 15)
        Me.VorhandenPerson1.TabIndex = 9
        Me.VorhandenPerson1.Text = "Daten Vorhanden"
        '
        'VorhandenPerson2
        '
        Me.VorhandenPerson2.AutoSize = True
        Me.VorhandenPerson2.Location = New System.Drawing.Point(100, 38)
        Me.VorhandenPerson2.Name = "VorhandenPerson2"
        Me.VorhandenPerson2.Size = New System.Drawing.Size(98, 15)
        Me.VorhandenPerson2.TabIndex = 10
        Me.VorhandenPerson2.Text = "Daten Vorhanden"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Auswertung"
        '
        'Auswertung
        '
        Me.Auswertung.AutoSize = True
        Me.Auswertung.Location = New System.Drawing.Point(100, 59)
        Me.Auswertung.Name = "Auswertung"
        Me.Auswertung.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Auswertung.Size = New System.Drawing.Size(98, 15)
        Me.Auswertung.TabIndex = 12
        Me.Auswertung.Text = "Daten Vorhanden"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Blue
        Me.ProgressBar1.Location = New System.Drawing.Point(312, 425)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(196, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'OptionenButton
        '
        Me.OptionenButton.Location = New System.Drawing.Point(8, 77)
        Me.OptionenButton.Name = "OptionenButton"
        Me.OptionenButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionenButton.TabIndex = 15
        Me.OptionenButton.Text = "Optionen"
        Me.OptionenButton.UseVisualStyleBackColor = True
        '
        'Zuruck
        '
        Me.Zuruck.Location = New System.Drawing.Point(637, 423)
        Me.Zuruck.Name = "Zuruck"
        Me.Zuruck.Size = New System.Drawing.Size(75, 23)
        Me.Zuruck.TabIndex = 17
        Me.Zuruck.Text = "Zurück"
        Me.Zuruck.UseVisualStyleBackColor = True
        '
        'Haupt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Zuruck)
        Me.Controls.Add(Me.OptionenButton)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Auswertung)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VorhandenPerson2)
        Me.Controls.Add(Me.VorhandenPerson1)
        Me.Controls.Add(Me.Durchgang2)
        Me.Controls.Add(Me.Durchgang1)
        Me.Controls.Add(Me.Auswerten)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.VorliebeText)
        Me.Controls.Add(Me.Nein)
        Me.Controls.Add(Me.Vielleicht)
        Me.Controls.Add(Me.Ja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Haupt"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Vorlieben"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
