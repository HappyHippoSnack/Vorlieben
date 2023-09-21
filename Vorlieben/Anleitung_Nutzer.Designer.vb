<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anleitung_Nutzer
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Anleitung_Nutzer))
        schliessen = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' schliessen
        ' 
        schliessen.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        schliessen.Location = New Point(361, 352)
        schliessen.Name = "schliessen"
        schliessen.Size = New Size(85, 31)
        schliessen.TabIndex = 0
        schliessen.Text = "Schließen"
        schliessen.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(12, 113)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(776, 207)
        TextBox1.TabIndex = 3
        TextBox1.Text = resources.GetString("TextBox1.Text")
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Anleitung_Nutzer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(TextBox1)
        Controls.Add(schliessen)
        MaximizeBox = False
        Name = "Anleitung_Nutzer"
        Text = "Anleitung"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents schliessen As Button
    Friend WithEvents TextBox1 As TextBox
End Class
