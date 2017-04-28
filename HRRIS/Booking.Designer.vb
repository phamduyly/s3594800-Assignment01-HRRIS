<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboCusId = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRmNum = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboRoomID = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.ComboBox()
        Me.btnInvoince = New System.Windows.Forms.Button()
        Me.cboStays = New System.Windows.Forms.ComboBox()
        Me.cboGuestNum = New System.Windows.Forms.ComboBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtCheckinDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.PicCkinDt = New System.Windows.Forms.PictureBox()
        Me.PicDate = New System.Windows.Forms.PictureBox()
        Me.PicCmt = New System.Windows.Forms.PictureBox()
        Me.PicStayingDay = New System.Windows.Forms.PictureBox()
        Me.PicGuestNum = New System.Windows.Forms.PictureBox()
        Me.PicPrice = New System.Windows.Forms.PictureBox()
        Me.PicCusID = New System.Windows.Forms.PictureBox()
        Me.PicRoomID = New System.Windows.Forms.PictureBox()
        Me.PicBookID = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCmt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreakReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookingidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumguestsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRRISdbDataSet2 = New HRRIS.HRRISdbDataSet2()
        Me.BookingTableAdapter = New HRRIS.HRRISdbDataSet2TableAdapters.bookingTableAdapter()
        Me.DeleteStatus = New System.Windows.Forms.PictureBox()
        Me.UpdatetingsStatus = New System.Windows.Forms.PictureBox()
        Me.FindStatus = New System.Windows.Forms.PictureBox()
        Me.AddStatus = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Updatetings = New System.Windows.Forms.PictureBox()
        Me.Find = New System.Windows.Forms.PictureBox()
        Me.Adds1 = New System.Windows.Forms.PictureBox()
        Me.Delete = New System.Windows.Forms.PictureBox()
        Me.UpClose = New System.Windows.Forms.PictureBox()
        Me.DownStart = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicCkinDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStayingDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGuestNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRoomID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBookID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRRISdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeleteStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdatetingsStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FindStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Updatetings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Find, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Adds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DownStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(82, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 133
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cboCusId)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(74, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 50)
        Me.GroupBox2.TabIndex = 136
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input any collum - all data will appear"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(300, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(135, 20)
        Me.txtFirstName.TabIndex = 92
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(225, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "First Name"
        '
        'cboCusId
        '
        Me.cboCusId.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboCusId.FormattingEnabled = True
        Me.cboCusId.Location = New System.Drawing.Point(118, 19)
        Me.cboCusId.Name = "cboCusId"
        Me.cboCusId.Size = New System.Drawing.Size(100, 21)
        Me.cboCusId.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Customer ID "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRmNum)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboRoomID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 50)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input any collum - all data will appear"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Room ID "
        '
        'txtRmNum
        '
        Me.txtRmNum.Location = New System.Drawing.Point(376, 21)
        Me.txtRmNum.Name = "txtRmNum"
        Me.txtRmNum.Size = New System.Drawing.Size(59, 20)
        Me.txtRmNum.TabIndex = 89
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Price"
        '
        'cboRoomID
        '
        Me.cboRoomID.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboRoomID.FormattingEnabled = True
        Me.cboRoomID.Location = New System.Drawing.Point(118, 23)
        Me.cboRoomID.Name = "cboRoomID"
        Me.cboRoomID.Size = New System.Drawing.Size(44, 21)
        Me.cboRoomID.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(174, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Type"
        '
        'txtType
        '
        Me.txtType.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.txtType.FormattingEnabled = True
        Me.txtType.Items.AddRange(New Object() {"Normal", "Deluxe", "Luxury"})
        Me.txtType.Location = New System.Drawing.Point(211, 21)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(80, 21)
        Me.txtType.TabIndex = 86
        '
        'btnInvoince
        '
        Me.btnInvoince.Location = New System.Drawing.Point(594, 387)
        Me.btnInvoince.Name = "btnInvoince"
        Me.btnInvoince.Size = New System.Drawing.Size(79, 52)
        Me.btnInvoince.TabIndex = 134
        Me.btnInvoince.Text = "Generate Invoice"
        Me.btnInvoince.UseVisualStyleBackColor = True
        '
        'cboStays
        '
        Me.cboStays.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboStays.FormattingEnabled = True
        Me.cboStays.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboStays.Location = New System.Drawing.Point(193, 310)
        Me.cboStays.Name = "cboStays"
        Me.cboStays.Size = New System.Drawing.Size(317, 21)
        Me.cboStays.TabIndex = 132
        '
        'cboGuestNum
        '
        Me.cboGuestNum.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboGuestNum.FormattingEnabled = True
        Me.cboGuestNum.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboGuestNum.Location = New System.Drawing.Point(193, 344)
        Me.cboGuestNum.Name = "cboGuestNum"
        Me.cboGuestNum.Size = New System.Drawing.Size(317, 21)
        Me.cboGuestNum.TabIndex = 131
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(521, 479)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(79, 23)
        Me.btnLast.TabIndex = 129
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(389, 479)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(79, 23)
        Me.btnNext.TabIndex = 128
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(251, 479)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(79, 23)
        Me.btnPrevious.TabIndex = 127
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(114, 479)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(79, 23)
        Me.btnFirst.TabIndex = 126
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(594, 200)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 23)
        Me.btnUpdate.TabIndex = 125
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(594, 265)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(79, 23)
        Me.btnFind.TabIndex = 124
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(594, 236)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 23)
        Me.btnDelete.TabIndex = 123
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtCheckinDate
        '
        Me.txtCheckinDate.Location = New System.Drawing.Point(193, 378)
        Me.txtCheckinDate.Name = "txtCheckinDate"
        Me.txtCheckinDate.Size = New System.Drawing.Size(317, 20)
        Me.txtCheckinDate.TabIndex = 122
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(193, 145)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(317, 20)
        Me.txtDate.TabIndex = 121
        '
        'PicCkinDt
        '
        Me.PicCkinDt.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicCkinDt.Location = New System.Drawing.Point(552, 378)
        Me.PicCkinDt.Name = "PicCkinDt"
        Me.PicCkinDt.Size = New System.Drawing.Size(17, 16)
        Me.PicCkinDt.TabIndex = 120
        Me.PicCkinDt.TabStop = False
        Me.PicCkinDt.Visible = False
        '
        'PicDate
        '
        Me.PicDate.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicDate.Location = New System.Drawing.Point(551, 145)
        Me.PicDate.Name = "PicDate"
        Me.PicDate.Size = New System.Drawing.Size(17, 16)
        Me.PicDate.TabIndex = 119
        Me.PicDate.TabStop = False
        Me.PicDate.Visible = False
        '
        'PicCmt
        '
        Me.PicCmt.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicCmt.Location = New System.Drawing.Point(552, 446)
        Me.PicCmt.Name = "PicCmt"
        Me.PicCmt.Size = New System.Drawing.Size(17, 16)
        Me.PicCmt.TabIndex = 118
        Me.PicCmt.TabStop = False
        Me.PicCmt.Visible = False
        '
        'PicStayingDay
        '
        Me.PicStayingDay.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicStayingDay.Location = New System.Drawing.Point(552, 310)
        Me.PicStayingDay.Name = "PicStayingDay"
        Me.PicStayingDay.Size = New System.Drawing.Size(17, 16)
        Me.PicStayingDay.TabIndex = 117
        Me.PicStayingDay.TabStop = False
        Me.PicStayingDay.Visible = False
        '
        'PicGuestNum
        '
        Me.PicGuestNum.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicGuestNum.Location = New System.Drawing.Point(552, 344)
        Me.PicGuestNum.Name = "PicGuestNum"
        Me.PicGuestNum.Size = New System.Drawing.Size(17, 16)
        Me.PicGuestNum.TabIndex = 116
        Me.PicGuestNum.TabStop = False
        Me.PicGuestNum.Visible = False
        '
        'PicPrice
        '
        Me.PicPrice.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicPrice.Location = New System.Drawing.Point(552, 410)
        Me.PicPrice.Name = "PicPrice"
        Me.PicPrice.Size = New System.Drawing.Size(17, 16)
        Me.PicPrice.TabIndex = 115
        Me.PicPrice.TabStop = False
        Me.PicPrice.Visible = False
        '
        'PicCusID
        '
        Me.PicCusID.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicCusID.Location = New System.Drawing.Point(552, 260)
        Me.PicCusID.Name = "PicCusID"
        Me.PicCusID.Size = New System.Drawing.Size(17, 16)
        Me.PicCusID.TabIndex = 114
        Me.PicCusID.TabStop = False
        Me.PicCusID.Visible = False
        '
        'PicRoomID
        '
        Me.PicRoomID.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRoomID.Location = New System.Drawing.Point(552, 198)
        Me.PicRoomID.Name = "PicRoomID"
        Me.PicRoomID.Size = New System.Drawing.Size(17, 16)
        Me.PicRoomID.TabIndex = 113
        Me.PicRoomID.TabStop = False
        Me.PicRoomID.Visible = False
        '
        'PicBookID
        '
        Me.PicBookID.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicBookID.Location = New System.Drawing.Point(551, 104)
        Me.PicBookID.Name = "PicBookID"
        Me.PicBookID.Size = New System.Drawing.Size(17, 16)
        Me.PicBookID.TabIndex = 112
        Me.PicBookID.TabStop = False
        Me.PicBookID.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(594, 153)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 23)
        Me.btnAdd.TabIndex = 111
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCmt
        '
        Me.txtCmt.Location = New System.Drawing.Point(193, 442)
        Me.txtCmt.Name = "txtCmt"
        Me.txtCmt.Size = New System.Drawing.Size(317, 20)
        Me.txtCmt.TabIndex = 110
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 442)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Comments"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(193, 410)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(317, 20)
        Me.txtPrice.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Total Price "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Checkin Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Number of Guest"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Staying days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Date"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(192, 104)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(317, 20)
        Me.txtID.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Booking ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1002, 24)
        Me.MenuStrip1.TabIndex = 130
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem1, Me.RoomToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ToolStripMenuItem8, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 6)
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(123, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpToolStripMenuItem.Text = "Delete"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem1, Me.BreakReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.ReportToolStripMenuItem1.Text = "Report"
        '
        'BreakReportToolStripMenuItem
        '
        Me.BreakReportToolStripMenuItem.Name = "BreakReportToolStripMenuItem"
        Me.BreakReportToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.BreakReportToolStripMenuItem.Text = "Break Report"
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
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'HelpPageToolStripMenuItem
        '
        Me.HelpPageToolStripMenuItem.Name = "HelpPageToolStripMenuItem"
        Me.HelpPageToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.HelpPageToolStripMenuItem.Text = "Help Page"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingidDataGridViewTextBoxColumn, Me.BookingdateDataGridViewTextBoxColumn, Me.RoomidDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.NumdaysDataGridViewTextBoxColumn, Me.NumguestsDataGridViewTextBoxColumn, Me.CheckindateDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(82, 508)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(876, 150)
        Me.DataGridView1.TabIndex = 143
        '
        'BookingidDataGridViewTextBoxColumn
        '
        Me.BookingidDataGridViewTextBoxColumn.DataPropertyName = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.HeaderText = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.Name = "BookingidDataGridViewTextBoxColumn"
        '
        'BookingdateDataGridViewTextBoxColumn
        '
        Me.BookingdateDataGridViewTextBoxColumn.DataPropertyName = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.HeaderText = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.Name = "BookingdateDataGridViewTextBoxColumn"
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'NumdaysDataGridViewTextBoxColumn
        '
        Me.NumdaysDataGridViewTextBoxColumn.DataPropertyName = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.HeaderText = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.Name = "NumdaysDataGridViewTextBoxColumn"
        '
        'NumguestsDataGridViewTextBoxColumn
        '
        Me.NumguestsDataGridViewTextBoxColumn.DataPropertyName = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.HeaderText = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.Name = "NumguestsDataGridViewTextBoxColumn"
        '
        'CheckindateDataGridViewTextBoxColumn
        '
        Me.CheckindateDataGridViewTextBoxColumn.DataPropertyName = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.HeaderText = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.Name = "CheckindateDataGridViewTextBoxColumn"
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "booking"
        Me.BookingBindingSource.DataSource = Me.HRRISdbDataSet2
        '
        'HRRISdbDataSet2
        '
        Me.HRRISdbDataSet2.DataSetName = "HRRISdbDataSet2"
        Me.HRRISdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'DeleteStatus
        '
        Me.DeleteStatus.Image = Global.HRRIS.My.Resources.Resources._641
        Me.DeleteStatus.Location = New System.Drawing.Point(12, 40)
        Me.DeleteStatus.Name = "DeleteStatus"
        Me.DeleteStatus.Size = New System.Drawing.Size(64, 64)
        Me.DeleteStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DeleteStatus.TabIndex = 145
        Me.DeleteStatus.TabStop = False
        Me.DeleteStatus.Visible = False
        '
        'UpdatetingsStatus
        '
        Me.UpdatetingsStatus.Location = New System.Drawing.Point(12, 41)
        Me.UpdatetingsStatus.Name = "UpdatetingsStatus"
        Me.UpdatetingsStatus.Size = New System.Drawing.Size(64, 64)
        Me.UpdatetingsStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.UpdatetingsStatus.TabIndex = 146
        Me.UpdatetingsStatus.TabStop = False
        Me.UpdatetingsStatus.Visible = False
        '
        'FindStatus
        '
        Me.FindStatus.Location = New System.Drawing.Point(12, 41)
        Me.FindStatus.Name = "FindStatus"
        Me.FindStatus.Size = New System.Drawing.Size(64, 64)
        Me.FindStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FindStatus.TabIndex = 147
        Me.FindStatus.TabStop = False
        Me.FindStatus.Visible = False
        '
        'AddStatus
        '
        Me.AddStatus.Location = New System.Drawing.Point(12, 40)
        Me.AddStatus.Name = "AddStatus"
        Me.AddStatus.Size = New System.Drawing.Size(64, 64)
        Me.AddStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AddStatus.TabIndex = 148
        Me.AddStatus.TabStop = False
        Me.AddStatus.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Updatetings)
        Me.Panel2.Controls.Add(Me.Find)
        Me.Panel2.Controls.Add(Me.Adds1)
        Me.Panel2.Controls.Add(Me.Delete)
        Me.Panel2.Controls.Add(Me.UpClose)
        Me.Panel2.Controls.Add(Me.DownStart)
        Me.Panel2.Location = New System.Drawing.Point(12, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(64, 73)
        Me.Panel2.TabIndex = 144
        '
        'Updatetings
        '
        Me.Updatetings.Image = Global.HRRIS.My.Resources.Resources.Ink_Pen_2_icon
        Me.Updatetings.Location = New System.Drawing.Point(0, 214)
        Me.Updatetings.Name = "Updatetings"
        Me.Updatetings.Size = New System.Drawing.Size(64, 64)
        Me.Updatetings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Updatetings.TabIndex = 12
        Me.Updatetings.TabStop = False
        '
        'Find
        '
        Me.Find.Image = Global.HRRIS.My.Resources.Resources.Magnifier_icon
        Me.Find.Location = New System.Drawing.Point(0, 144)
        Me.Find.Name = "Find"
        Me.Find.Size = New System.Drawing.Size(64, 64)
        Me.Find.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Find.TabIndex = 7
        Me.Find.TabStop = False
        '
        'Adds1
        '
        Me.Adds1.Image = Global.HRRIS.My.Resources.Resources.Add_icon
        Me.Adds1.Location = New System.Drawing.Point(0, 73)
        Me.Adds1.Name = "Adds1"
        Me.Adds1.Size = New System.Drawing.Size(64, 64)
        Me.Adds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Adds1.TabIndex = 6
        Me.Adds1.TabStop = False
        '
        'Delete
        '
        Me.Delete.Image = Global.HRRIS.My.Resources.Resources.delete_icon
        Me.Delete.Location = New System.Drawing.Point(0, 284)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(64, 64)
        Me.Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Delete.TabIndex = 5
        Me.Delete.TabStop = False
        '
        'UpClose
        '
        Me.UpClose.Image = Global.HRRIS.My.Resources.Resources.Arrow_Right_2_icon
        Me.UpClose.Location = New System.Drawing.Point(0, 354)
        Me.UpClose.Name = "UpClose"
        Me.UpClose.Size = New System.Drawing.Size(64, 64)
        Me.UpClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.UpClose.TabIndex = 4
        Me.UpClose.TabStop = False
        '
        'DownStart
        '
        Me.DownStart.Image = Global.HRRIS.My.Resources.Resources.Arrow_Down_2_icon
        Me.DownStart.Location = New System.Drawing.Point(0, 5)
        Me.DownStart.Name = "DownStart"
        Me.DownStart.Size = New System.Drawing.Size(64, 64)
        Me.DownStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DownStart.TabIndex = 78
        Me.DownStart.TabStop = False
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 663)
        Me.Controls.Add(Me.DeleteStatus)
        Me.Controls.Add(Me.UpdatetingsStatus)
        Me.Controls.Add(Me.FindStatus)
        Me.Controls.Add(Me.AddStatus)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnInvoince)
        Me.Controls.Add(Me.cboStays)
        Me.Controls.Add(Me.cboGuestNum)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtCheckinDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.PicCkinDt)
        Me.Controls.Add(Me.PicDate)
        Me.Controls.Add(Me.PicCmt)
        Me.Controls.Add(Me.PicStayingDay)
        Me.Controls.Add(Me.PicGuestNum)
        Me.Controls.Add(Me.PicPrice)
        Me.Controls.Add(Me.PicCusID)
        Me.Controls.Add(Me.PicRoomID)
        Me.Controls.Add(Me.PicBookID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCmt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicCkinDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStayingDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGuestNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRoomID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBookID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRRISdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeleteStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdatetingsStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FindStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Updatetings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Find, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Adds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DownStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboCusId As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRmNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboRoomID As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtType As ComboBox
    Friend WithEvents btnInvoince As Button
    Friend WithEvents cboStays As ComboBox
    Friend WithEvents cboGuestNum As ComboBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtCheckinDate As DateTimePicker
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents PicCkinDt As PictureBox
    Friend WithEvents PicDate As PictureBox
    Friend WithEvents PicCmt As PictureBox
    Friend WithEvents PicStayingDay As PictureBox
    Friend WithEvents PicGuestNum As PictureBox
    Friend WithEvents PicPrice As PictureBox
    Friend WithEvents PicCusID As PictureBox
    Friend WithEvents PicRoomID As PictureBox
    Friend WithEvents PicBookID As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtCmt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HRRISdbDataSet2 As HRRISdbDataSet2
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As HRRISdbDataSet2TableAdapters.bookingTableAdapter
    Friend WithEvents BookingidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumdaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumguestsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckindateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents ReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BreakReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStatus As PictureBox
    Friend WithEvents UpdatetingsStatus As PictureBox
    Friend WithEvents FindStatus As PictureBox
    Friend WithEvents AddStatus As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Updatetings As PictureBox
    Friend WithEvents Find As PictureBox
    Friend WithEvents Adds1 As PictureBox
    Friend WithEvents Delete As PictureBox
    Friend WithEvents UpClose As PictureBox
    Friend WithEvents DownStart As PictureBox
    Friend WithEvents HelpPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
End Class
