<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Converter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Input = New System.Windows.Forms.TextBox()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.InputBase = New System.Windows.Forms.ComboBox()
        Me.OutputBase = New System.Windows.Forms.ComboBox()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Input.Location = New System.Drawing.Point(237, 12)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(177, 20)
        Me.Input.TabIndex = 0
        '
        'Output
        '
        Me.Output.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Output.Location = New System.Drawing.Point(237, 38)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(177, 20)
        Me.Output.TabIndex = 1
        '
        'InputBase
        '
        Me.InputBase.FormattingEnabled = True
        Me.InputBase.Location = New System.Drawing.Point(49, 12)
        Me.InputBase.Name = "InputBase"
        Me.InputBase.Size = New System.Drawing.Size(182, 21)
        Me.InputBase.TabIndex = 2
        '
        'OutputBase
        '
        Me.OutputBase.FormattingEnabled = True
        Me.OutputBase.Location = New System.Drawing.Point(48, 38)
        Me.OutputBase.Name = "OutputBase"
        Me.OutputBase.Size = New System.Drawing.Size(183, 21)
        Me.OutputBase.TabIndex = 3
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = True
        Me.InputLabel.Location = New System.Drawing.Point(12, 15)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(31, 13)
        Me.InputLabel.TabIndex = 4
        Me.InputLabel.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Output"
        '
        'Converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 73)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputLabel)
        Me.Controls.Add(Me.OutputBase)
        Me.Controls.Add(Me.InputBase)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Input)
        Me.MaximizeBox = False
        Me.Name = "Converter"
        Me.Text = "Base Converter#"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input As TextBox
    Friend WithEvents Output As TextBox
    Friend WithEvents InputBase As ComboBox
    Friend WithEvents OutputBase As ComboBox
    Friend WithEvents InputLabel As Label
    Friend WithEvents Label1 As Label
End Class
