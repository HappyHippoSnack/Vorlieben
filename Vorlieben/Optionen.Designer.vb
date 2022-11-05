<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Optionen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Optionen))
        Me.Person1loeschen = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Antworten1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Antworten2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Person2loeschen = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Sparsam = New System.Windows.Forms.RadioButton()
        Me.Normal = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Gedultsprobe = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Auswertung = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Person1loeschen
        '
        Me.Person1loeschen.Location = New System.Drawing.Point(6, 71)
        Me.Person1loeschen.Name = "Person1loeschen"
        Me.Person1loeschen.Size = New System.Drawing.Size(163, 23)
        Me.Person1loeschen.TabIndex = 1
        Me.Person1loeschen.Text = "Daten von Person 1 löschen"
        Me.Person1loeschen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Antworten1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Person1loeschen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Person 1"
        '
        'Antworten1
        '
        Me.Antworten1.AutoSize = True
        Me.Antworten1.Location = New System.Drawing.Point(138, 40)
        Me.Antworten1.Name = "Antworten1"
        Me.Antworten1.Size = New System.Drawing.Size(65, 15)
        Me.Antworten1.TabIndex = 3
        Me.Antworten1.Text = "Unbekannt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Beantwortete Fetische:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Antworten2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Person2loeschen)
        Me.GroupBox2.Location = New System.Drawing.Point(266, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Person 2"
        '
        'Antworten2
        '
        Me.Antworten2.AutoSize = True
        Me.Antworten2.Location = New System.Drawing.Point(138, 40)
        Me.Antworten2.Name = "Antworten2"
        Me.Antworten2.Size = New System.Drawing.Size(65, 15)
        Me.Antworten2.TabIndex = 3
        Me.Antworten2.Text = "Unbekannt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Beantwortete Fetische:"
        '
        'Person2loeschen
        '
        Me.Person2loeschen.Location = New System.Drawing.Point(6, 71)
        Me.Person2loeschen.Name = "Person2loeschen"
        Me.Person2loeschen.Size = New System.Drawing.Size(163, 23)
        Me.Person2loeschen.TabIndex = 1
        Me.Person2loeschen.Text = "Daten von Person 1 löschen"
        Me.Person2loeschen.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(30, 400)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 8
        Me.Back.Text = "Zurück"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Sparsam
        '
        Me.Sparsam.AutoSize = True
        Me.Sparsam.Enabled = False
        Me.Sparsam.Location = New System.Drawing.Point(6, 22)
        Me.Sparsam.Name = "Sparsam"
        Me.Sparsam.Size = New System.Drawing.Size(99, 19)
        Me.Sparsam.TabIndex = 9
        Me.Sparsam.Text = "Einsteiger (50)"
        Me.Sparsam.UseVisualStyleBackColor = True
        '
        'Normal
        '
        Me.Normal.AutoSize = True
        Me.Normal.Enabled = False
        Me.Normal.Location = New System.Drawing.Point(6, 47)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(94, 19)
        Me.Normal.TabIndex = 10
        Me.Normal.Text = "Normal (130)"
        Me.Normal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Gedultsprobe)
        Me.GroupBox3.Controls.Add(Me.Sparsam)
        Me.GroupBox3.Controls.Add(Me.Normal)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 201)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Benutzte Datenbank"
        '
        'Gedultsprobe
        '
        Me.Gedultsprobe.AutoSize = True
        Me.Gedultsprobe.Enabled = False
        Me.Gedultsprobe.Location = New System.Drawing.Point(6, 72)
        Me.Gedultsprobe.Name = "Gedultsprobe"
        Me.Gedultsprobe.Size = New System.Drawing.Size(109, 19)
        Me.Gedultsprobe.TabIndex = 11
        Me.Gedultsprobe.Text = "Extremist (1703)"
        Me.Gedultsprobe.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(688, 422)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 16)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "© 0.1.7      S. Jäckel"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Auswertung)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(519, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(220, 100)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Auswertung"
        '
        'Auswertung
        '
        Me.Auswertung.AutoSize = True
        Me.Auswertung.Location = New System.Drawing.Point(138, 40)
        Me.Auswertung.Name = "Auswertung"
        Me.Auswertung.Size = New System.Drawing.Size(65, 15)
        Me.Auswertung.TabIndex = 3
        Me.Auswertung.Text = "Unbekannt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Auswertung vorhanden:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Auswertung löschen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Optionen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vorlieben.My.Resources.Resources.zahnrad
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.Back
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Optionen"
        Me.Text = "Optionen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Person1loeschen As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Antworten1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Antworten2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Person2loeschen As Button
    Friend WithEvents Back As Button
    Friend WithEvents Sparsam As RadioButton
    Friend WithEvents Normal As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Gedultsprobe As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Auswertung As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
