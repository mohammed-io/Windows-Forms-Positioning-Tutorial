<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MovingButton = New System.Windows.Forms.Button()
        Me.VerticalTrackBar = New System.Windows.Forms.TrackBar()
        Me.HorizontalTrackBar = New System.Windows.Forms.TrackBar()
        CType(Me.VerticalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovingButton
        '
        Me.MovingButton.Location = New System.Drawing.Point(12, 12)
        Me.MovingButton.Name = "MovingButton"
        Me.MovingButton.Size = New System.Drawing.Size(75, 23)
        Me.MovingButton.TabIndex = 0
        Me.MovingButton.Text = "Moving Button"
        Me.MovingButton.UseVisualStyleBackColor = True
        '
        'VerticalTrackBar
        '
        Me.VerticalTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerticalTrackBar.Location = New System.Drawing.Point(435, 12)
        Me.VerticalTrackBar.Name = "VerticalTrackBar"
        Me.VerticalTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.VerticalTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.VerticalTrackBar.Size = New System.Drawing.Size(45, 320)
        Me.VerticalTrackBar.TabIndex = 1
        Me.VerticalTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.VerticalTrackBar.Value = 4
        '
        'HorizontalTrackBar
        '
        Me.HorizontalTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HorizontalTrackBar.Location = New System.Drawing.Point(12, 338)
        Me.HorizontalTrackBar.Name = "HorizontalTrackBar"
        Me.HorizontalTrackBar.Size = New System.Drawing.Size(417, 45)
        Me.HorizontalTrackBar.TabIndex = 2
        Me.HorizontalTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 395)
        Me.Controls.Add(Me.HorizontalTrackBar)
        Me.Controls.Add(Me.VerticalTrackBar)
        Me.Controls.Add(Me.MovingButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.VerticalTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorizontalTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MovingButton As Button
    Friend WithEvents VerticalTrackBar As TrackBar
    Friend WithEvents HorizontalTrackBar As TrackBar
End Class
