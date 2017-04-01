<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigation
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
        Me.btnCusForm = New System.Windows.Forms.Button()
        Me.btnRoomForm = New System.Windows.Forms.Button()
        Me.btnBookingForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCusForm
        '
        Me.btnCusForm.Location = New System.Drawing.Point(67, 38)
        Me.btnCusForm.Name = "btnCusForm"
        Me.btnCusForm.Size = New System.Drawing.Size(136, 34)
        Me.btnCusForm.TabIndex = 0
        Me.btnCusForm.Text = "Customer Form"
        Me.btnCusForm.UseVisualStyleBackColor = True
        '
        'btnRoomForm
        '
        Me.btnRoomForm.Location = New System.Drawing.Point(67, 84)
        Me.btnRoomForm.Name = "btnRoomForm"
        Me.btnRoomForm.Size = New System.Drawing.Size(136, 34)
        Me.btnRoomForm.TabIndex = 1
        Me.btnRoomForm.Text = "Room Form"
        Me.btnRoomForm.UseVisualStyleBackColor = True
        '
        'btnBookingForm
        '
        Me.btnBookingForm.Location = New System.Drawing.Point(67, 127)
        Me.btnBookingForm.Name = "btnBookingForm"
        Me.btnBookingForm.Size = New System.Drawing.Size(136, 34)
        Me.btnBookingForm.TabIndex = 2
        Me.btnBookingForm.Text = "Booking Form"
        Me.btnBookingForm.UseVisualStyleBackColor = True
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnBookingForm)
        Me.Controls.Add(Me.btnRoomForm)
        Me.Controls.Add(Me.btnCusForm)
        Me.Name = "Navigation"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCusForm As System.Windows.Forms.Button
    Friend WithEvents btnRoomForm As System.Windows.Forms.Button
    Friend WithEvents btnBookingForm As System.Windows.Forms.Button
End Class
