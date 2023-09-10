<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Starter
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Starter))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Verstanden = New Button()
        Timer1 = New Timer(components)
        Version = New TextBox()
        Anleitung = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(202, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 50)
        Label1.TabIndex = 0
        Label1.Text = "Vorlieben. Die App."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.Location = New Point(349, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 21)
        Label2.TabIndex = 1
        Label2.Text = "Regeln:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.CausesValidation = False
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(26, 141)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(738, 116)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Kein Ja oder Nein Spamen!" & vbCrLf & "Der erste Gedanke ist IMMER Richtig!" & vbCrLf & "Keine Angst, nur wenn beide Ja / Vielleicht sagen, wird es angezeigt." & vbCrLf & "Spaß haben!" & vbCrLf & vbCrLf
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Verstanden
        ' 
        Verstanden.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Verstanden.Location = New Point(349, 391)
        Verstanden.Name = "Verstanden"
        Verstanden.Size = New Size(104, 32)
        Verstanden.TabIndex = 3
        Verstanden.Text = "Verstanden"
        Verstanden.UseVisualStyleBackColor = True
        ' 
        ' Version
        ' 
        Version.BackColor = SystemColors.Control
        Version.BorderStyle = BorderStyle.None
        Version.Enabled = False
        Version.Location = New Point(688, 407)
        Version.Name = "Version"
        Version.Size = New Size(100, 16)
        Version.TabIndex = 5
        Version.Text = "Version"
        ' 
        ' Anleitung
        ' 
        Anleitung.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Anleitung.Location = New Point(302, 303)
        Anleitung.Name = "Anleitung"
        Anleitung.Size = New Size(200, 32)
        Anleitung.TabIndex = 6
        Anleitung.Text = "Anleitung / Help Me"
        Anleitung.UseVisualStyleBackColor = True
        ' 
        ' Starter
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Anleitung)
        Controls.Add(Version)
        Controls.Add(Verstanden)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Starter"
        Text = "Starter"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Verstanden As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Version As TextBox
    Friend WithEvents Anleitung As Button
End Class
