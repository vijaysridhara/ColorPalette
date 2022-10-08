<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorWheel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRGB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.butSysColors = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "RGB"
        '
        'txtRGB
        '
        Me.txtRGB.Location = New System.Drawing.Point(167, 262)
        Me.txtRGB.Name = "txtRGB"
        Me.txtRGB.Size = New System.Drawing.Size(140, 20)
        Me.txtRGB.TabIndex = 220
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Alpha"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(368, 255)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(191, 45)
        Me.TrackBar1.TabIndex = 221
        Me.TrackBar1.TickFrequency = 5
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar1.Value = 255
        '
        'butSysColors
        '
        Me.butSysColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butSysColors.Location = New System.Drawing.Point(99, 262)
        Me.butSysColors.Name = "butSysColors"
        Me.butSysColors.Size = New System.Drawing.Size(26, 23)
        Me.butSysColors.TabIndex = 222
        Me.butSysColors.Text = "V"
        Me.butSysColors.UseVisualStyleBackColor = True
        '
        'ColorWheel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(568, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.butSysColors)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.txtRGB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "ColorWheel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRGB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents butSysColors As System.Windows.Forms.Button
End Class
