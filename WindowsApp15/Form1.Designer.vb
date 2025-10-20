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
        Me.btnGo1 = New System.Windows.Forms.Button()
        Me.btnGo2 = New System.Windows.Forms.Button()
        Me.btnGo3 = New System.Windows.Forms.Button()
        Me.btnGo4 = New System.Windows.Forms.Button()
        Me.btnGo5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo1
        '
        Me.btnGo1.Location = New System.Drawing.Point(100, 67)
        Me.btnGo1.Name = "btnGo1"
        Me.btnGo1.Size = New System.Drawing.Size(115, 39)
        Me.btnGo1.TabIndex = 0
        Me.btnGo1.Text = "For"
        Me.btnGo1.UseVisualStyleBackColor = True
        '
        'btnGo2
        '
        Me.btnGo2.Location = New System.Drawing.Point(281, 67)
        Me.btnGo2.Name = "btnGo2"
        Me.btnGo2.Size = New System.Drawing.Size(115, 39)
        Me.btnGo2.TabIndex = 1
        Me.btnGo2.Text = "Do While"
        Me.btnGo2.UseVisualStyleBackColor = True
        '
        'btnGo3
        '
        Me.btnGo3.Location = New System.Drawing.Point(100, 154)
        Me.btnGo3.Name = "btnGo3"
        Me.btnGo3.Size = New System.Drawing.Size(115, 39)
        Me.btnGo3.TabIndex = 2
        Me.btnGo3.Text = "Do Until"
        Me.btnGo3.UseVisualStyleBackColor = True
        '
        'btnGo4
        '
        Me.btnGo4.Location = New System.Drawing.Point(281, 154)
        Me.btnGo4.Name = "btnGo4"
        Me.btnGo4.Size = New System.Drawing.Size(115, 39)
        Me.btnGo4.TabIndex = 3
        Me.btnGo4.Text = "Do Loop Until"
        Me.btnGo4.UseVisualStyleBackColor = True
        '
        'btnGo5
        '
        Me.btnGo5.Location = New System.Drawing.Point(464, 154)
        Me.btnGo5.Name = "btnGo5"
        Me.btnGo5.Size = New System.Drawing.Size(115, 39)
        Me.btnGo5.TabIndex = 4
        Me.btnGo5.Text = "Do Loop While"
        Me.btnGo5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 384)
        Me.Controls.Add(Me.btnGo5)
        Me.Controls.Add(Me.btnGo4)
        Me.Controls.Add(Me.btnGo3)
        Me.Controls.Add(Me.btnGo2)
        Me.Controls.Add(Me.btnGo1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGo1 As Button
    Friend WithEvents btnGo2 As Button
    Friend WithEvents btnGo3 As Button
    Friend WithEvents btnGo4 As Button
    Friend WithEvents btnGo5 As Button
End Class
