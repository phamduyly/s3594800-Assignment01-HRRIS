<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yearerror = New System.Windows.Forms.PictureBox()
        Me.btnCusReport = New System.Windows.Forms.Button()
        Me.btnReport2 = New System.Windows.Forms.Button()
        Me.btnReport3 = New System.Windows.Forms.Button()
        Me.btnReport4 = New System.Windows.Forms.Button()
        Me.btnReport5 = New System.Windows.Forms.Button()
        Me.btnReport6 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReportYear = New System.Windows.Forms.TextBox()
        Me.cboRoomID = New System.Windows.Forms.ComboBox()
        Me.cboCusId = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboReportMonth = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboBookId = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HelpPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Yearerror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(623, 24)
        Me.MenuStrip1.TabIndex = 131
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem1, Me.RoomToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.BookingToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ToolStripMenuItem8, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.HelpPageToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'Yearerror
        '
        Me.Yearerror.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.Yearerror.Location = New System.Drawing.Point(503, 185)
        Me.Yearerror.Name = "Yearerror"
        Me.Yearerror.Size = New System.Drawing.Size(17, 16)
        Me.Yearerror.TabIndex = 143
        Me.Yearerror.TabStop = False
        Me.Yearerror.Visible = False
        '
        'btnCusReport
        '
        Me.btnCusReport.Location = New System.Drawing.Point(478, 279)
        Me.btnCusReport.Name = "btnCusReport"
        Me.btnCusReport.Size = New System.Drawing.Size(105, 23)
        Me.btnCusReport.TabIndex = 70
        Me.btnCusReport.Text = "Customer Report"
        Me.btnCusReport.UseVisualStyleBackColor = True
        '
        'btnReport2
        '
        Me.btnReport2.Location = New System.Drawing.Point(478, 308)
        Me.btnReport2.Name = "btnReport2"
        Me.btnReport2.Size = New System.Drawing.Size(105, 27)
        Me.btnReport2.TabIndex = 75
        Me.btnReport2.Text = "2nd Report"
        Me.btnReport2.UseVisualStyleBackColor = True
        '
        'btnReport3
        '
        Me.btnReport3.Location = New System.Drawing.Point(478, 348)
        Me.btnReport3.Name = "btnReport3"
        Me.btnReport3.Size = New System.Drawing.Size(105, 27)
        Me.btnReport3.TabIndex = 76
        Me.btnReport3.Text = "3rd Report"
        Me.btnReport3.UseVisualStyleBackColor = True
        '
        'btnReport4
        '
        Me.btnReport4.Location = New System.Drawing.Point(478, 381)
        Me.btnReport4.Name = "btnReport4"
        Me.btnReport4.Size = New System.Drawing.Size(105, 27)
        Me.btnReport4.TabIndex = 77
        Me.btnReport4.Text = "4th Report"
        Me.btnReport4.UseVisualStyleBackColor = True
        '
        'btnReport5
        '
        Me.btnReport5.Location = New System.Drawing.Point(478, 414)
        Me.btnReport5.Name = "btnReport5"
        Me.btnReport5.Size = New System.Drawing.Size(105, 27)
        Me.btnReport5.TabIndex = 78
        Me.btnReport5.Text = "5th Report"
        Me.btnReport5.UseVisualStyleBackColor = True
        '
        'btnReport6
        '
        Me.btnReport6.Location = New System.Drawing.Point(478, 447)
        Me.btnReport6.Name = "btnReport6"
        Me.btnReport6.Size = New System.Drawing.Size(105, 27)
        Me.btnReport6.TabIndex = 80
        Me.btnReport6.Text = "6th Report"
        Me.btnReport6.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(373, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Year"
        '
        'txtReportYear
        '
        Me.txtReportYear.Location = New System.Drawing.Point(422, 181)
        Me.txtReportYear.Name = "txtReportYear"
        Me.txtReportYear.Size = New System.Drawing.Size(75, 20)
        Me.txtReportYear.TabIndex = 82
        '
        'cboRoomID
        '
        Me.cboRoomID.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboRoomID.FormattingEnabled = True
        Me.cboRoomID.Location = New System.Drawing.Point(180, 88)
        Me.cboRoomID.Name = "cboRoomID"
        Me.cboRoomID.Size = New System.Drawing.Size(317, 21)
        Me.cboRoomID.TabIndex = 141
        '
        'cboCusId
        '
        Me.cboCusId.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboCusId.FormattingEnabled = True
        Me.cboCusId.Location = New System.Drawing.Point(180, 140)
        Me.cboCusId.Name = "cboCusId"
        Me.cboCusId.Size = New System.Drawing.Size(317, 21)
        Me.cboCusId.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Booking ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Room ID "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Customer ID "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(93, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Month"
        '
        'cboReportMonth
        '
        Me.cboReportMonth.FormattingEnabled = True
        Me.cboReportMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboReportMonth.Location = New System.Drawing.Point(180, 194)
        Me.cboReportMonth.Name = "cboReportMonth"
        Me.cboReportMonth.Size = New System.Drawing.Size(79, 21)
        Me.cboReportMonth.TabIndex = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboBookId)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 202)
        Me.GroupBox1.TabIndex = 145
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Fields"
        '
        'cboBookId
        '
        Me.cboBookId.FormattingEnabled = True
        Me.cboBookId.Location = New System.Drawing.Point(145, 12)
        Me.cboBookId.Name = "cboBookId"
        Me.cboBookId.Size = New System.Drawing.Size(317, 21)
        Me.cboBookId.TabIndex = 152
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 13)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Purpose:  Show Last booking Date and days booked by a Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(435, 13)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "Purpose: Show last time booked and rooms booked by a customer in given month and " &
    "year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 13)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Purpose: show room booked by a Customer in given period"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 13)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Purpose: Show all bookings in given month and year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 13)
        Me.Label8.TabIndex = 150
        Me.Label8.Text = "Purpose: Show Customer who are checkin due for a given period"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(297, 13)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Purpose: Show all bookings for particular room in given period"
        '
        'HelpPageToolStripMenuItem
        '
        Me.HelpPageToolStripMenuItem.Name = "HelpPageToolStripMenuItem"
        Me.HelpPageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpPageToolStripMenuItem.Text = "Help Page"
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 526)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboReportMonth)
        Me.Controls.Add(Me.Yearerror)
        Me.Controls.Add(Me.cboRoomID)
        Me.Controls.Add(Me.cboCusId)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnReport4)
        Me.Controls.Add(Me.btnReport5)
        Me.Controls.Add(Me.btnReport6)
        Me.Controls.Add(Me.txtReportYear)
        Me.Controls.Add(Me.btnReport3)
        Me.Controls.Add(Me.btnReport2)
        Me.Controls.Add(Me.btnCusReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Yearerror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents RoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Yearerror As PictureBox
    Friend WithEvents btnCusReport As Button
    Friend WithEvents btnReport2 As Button
    Friend WithEvents btnReport3 As Button
    Friend WithEvents btnReport4 As Button
    Friend WithEvents btnReport5 As Button
    Friend WithEvents btnReport6 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtReportYear As TextBox
    Friend WithEvents cboRoomID As ComboBox
    Friend WithEvents cboCusId As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboReportMonth As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboBookId As ComboBox
    Friend WithEvents HelpPageToolStripMenuItem As ToolStripMenuItem
End Class
