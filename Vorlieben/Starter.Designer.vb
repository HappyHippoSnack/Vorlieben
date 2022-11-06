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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Extremist = New System.Windows.Forms.RadioButton()
        Me.Normal = New System.Windows.Forms.RadioButton()
        Me.Einsteiger = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Anleitung = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label2.Location = New System.Drawing.Point(348, 119)
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
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(148, 143)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(502, 124)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Verstanden
        '
        Me.Verstanden.Location = New System.Drawing.Point(361, 400)
        Me.Verstanden.Name = "Verstanden"
        Me.Verstanden.Size = New System.Drawing.Size(75, 23)
        Me.Verstanden.TabIndex = 3
        Me.Verstanden.Text = "Verstanden"
        Me.Verstanden.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Extremist)
        Me.GroupBox1.Controls.Add(Me.Normal)
        Me.GroupBox1.Controls.Add(Me.Einsteiger)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fetischdatenbanken"
        '
        'Extremist
        '
        Me.Extremist.AutoSize = True
        Me.Extremist.Enabled = False
        Me.Extremist.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Extremist.Location = New System.Drawing.Point(18, 74)
        Me.Extremist.Name = "Extremist"
        Me.Extremist.Size = New System.Drawing.Size(109, 19)
        Me.Extremist.TabIndex = 2
        Me.Extremist.Text = "Extremist (1730)"
        Me.Extremist.UseVisualStyleBackColor = True
        '
        'Normal
        '
        Me.Normal.AutoSize = True
        Me.Normal.Checked = True
        Me.Normal.Location = New System.Drawing.Point(18, 49)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(94, 19)
        Me.Normal.TabIndex = 1
        Me.Normal.TabStop = True
        Me.Normal.Text = "Normal (130)"
        Me.Normal.UseVisualStyleBackColor = True
        '
        'Einsteiger
        '
        Me.Einsteiger.AutoSize = True
        Me.Einsteiger.Enabled = False
        Me.Einsteiger.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Einsteiger.Location = New System.Drawing.Point(18, 24)
        Me.Einsteiger.Name = "Einsteiger"
        Me.Einsteiger.Size = New System.Drawing.Size(99, 19)
        Me.Einsteiger.TabIndex = 0
        Me.Einsteiger.Text = "Einsteiger (50)"
        Me.Einsteiger.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(688, 407)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 16)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "© 0.1.7      S. Jäckel"
        '
        'Anleitung
        '
        Me.Anleitung.Location = New System.Drawing.Point(37, 400)
        Me.Anleitung.Name = "Anleitung"
        Me.Anleitung.Size = New System.Drawing.Size(126, 23)
        Me.Anleitung.TabIndex = 6
        Me.Anleitung.Text = "Anleitung / Help Me"
        Me.Anleitung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Anleitung.UseVisualStyleBackColor = True
        '
        'Starter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Anleitung)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Verstanden As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Extremist As RadioButton
    Friend WithEvents Normal As RadioButton
    Friend WithEvents Einsteiger As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Anleitung As Button
End Class
