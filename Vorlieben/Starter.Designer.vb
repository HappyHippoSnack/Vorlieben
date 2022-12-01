<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Starter
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Starter))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Verstanden = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Version = New System.Windows.Forms.TextBox()
        Me.Anleitung = New System.Windows.Forms.Button()
        Me.BrowserCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(202, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vorlieben. Die App."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(349, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Regeln:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(26, 141)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(738, 116)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Kein Ja oder Nein Spamen!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Erster Gedanke ist IMMER Richtig!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keine Angst, nur we" &
    "nn beide Ja/ vielleicht sagen, wird es angezeigt." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Habt Spaß!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Verstanden
        '
        Me.Verstanden.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Verstanden.Location = New System.Drawing.Point(349, 391)
        Me.Verstanden.Name = "Verstanden"
        Me.Verstanden.Size = New System.Drawing.Size(104, 32)
        Me.Verstanden.TabIndex = 3
        Me.Verstanden.Text = "Verstanden"
        Me.Verstanden.UseVisualStyleBackColor = True
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.SystemColors.Control
        Me.Version.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Version.Enabled = False
        Me.Version.Location = New System.Drawing.Point(688, 407)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(100, 16)
        Me.Version.TabIndex = 5
        Me.Version.Text = "Version"
        '
        'Anleitung
        '
        Me.Anleitung.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Anleitung.Location = New System.Drawing.Point(302, 303)
        Me.Anleitung.Name = "Anleitung"
        Me.Anleitung.Size = New System.Drawing.Size(200, 32)
        Me.Anleitung.TabIndex = 6
        Me.Anleitung.Text = "Anleitung / Help Me"
        Me.Anleitung.UseVisualStyleBackColor = True
        '
        'BrowserCheck
        '
        Me.BrowserCheck.Location = New System.Drawing.Point(68, 332)
        Me.BrowserCheck.Name = "BrowserCheck"
        Me.BrowserCheck.Size = New System.Drawing.Size(142, 48)
        Me.BrowserCheck.TabIndex = 7
        Me.BrowserCheck.Text = "BrowserCheck"
        Me.BrowserCheck.UseVisualStyleBackColor = True
        '
        'Starter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BrowserCheck)
        Me.Controls.Add(Me.Anleitung)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Verstanden)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Starter"
        Me.Text = "Starter"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Verstanden As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Version As TextBox
    Friend WithEvents Anleitung As Button
    Friend WithEvents BrowserCheck As Button
End Class
