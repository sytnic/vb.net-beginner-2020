<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(274, 90)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(168, 20)
        Me.txtCountry.TabIndex = 0
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(91, 93)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(138, 13)
        Me.lblCountry.TabIndex = 1
        Me.lblCountry.Text = "What country are you from?"
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(296, 170)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(126, 39)
        Me.btnHello.TabIndex = 2
        Me.btnHello.Text = "Greeting"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 345)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.txtCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCountry As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents btnHello As Button
End Class
