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
        Me.txtCmt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGuesNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicCmt = New System.Windows.Forms.PictureBox()
        Me.PicStayingDay = New System.Windows.Forms.PictureBox()
        Me.PicGuestNum = New System.Windows.Forms.PictureBox()
        Me.PicPrice = New System.Windows.Forms.PictureBox()
        Me.PicCusID = New System.Windows.Forms.PictureBox()
        Me.PicRoomID = New System.Windows.Forms.PictureBox()
        Me.PicBookID = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboRoomID = New System.Windows.Forms.ComboBox()
        Me.PicDate = New System.Windows.Forms.PictureBox()
        Me.PicCkinDt = New System.Windows.Forms.PictureBox()
        Me.btnNav = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCheckinDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRRISdbDataSet1 = New WindowsApplication1.HRRISdbDataSet1()
        Me.BookingTableAdapter = New WindowsApplication1.HRRISdbDataSet1TableAdapters.bookingTableAdapter()
        Me.cboCusId = New System.Windows.Forms.ComboBox()
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
        Me.BookingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRRISdbDataSet3 = New WindowsApplication1.HRRISdbDataSet3()
        Me.BookingTableAdapter1 = New WindowsApplication1.HRRISdbDataSet3TableAdapters.bookingTableAdapter()
        Me.btnfinall = New System.Windows.Forms.Button()
        CType(Me.PicCmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStayingDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGuestNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRoomID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBookID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCkinDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRRISdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRRISdbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCmt
        '
        Me.txtCmt.Location = New System.Drawing.Point(142, 320)
        Me.txtCmt.Name = "txtCmt"
        Me.txtCmt.Size = New System.Drawing.Size(343, 20)
        Me.txtCmt.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Comments"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(142, 288)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(343, 20)
        Me.txtPrice.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Total Price "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Checkin Date"
        '
        'txtGuesNum
        '
        Me.txtGuesNum.Location = New System.Drawing.Point(142, 222)
        Me.txtGuesNum.Name = "txtGuesNum"
        Me.txtGuesNum.Size = New System.Drawing.Size(343, 20)
        Me.txtGuesNum.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Number of Guest"
        '
        'txtStay
        '
        Me.txtStay.Location = New System.Drawing.Point(143, 184)
        Me.txtStay.Name = "txtStay"
        Me.txtStay.Size = New System.Drawing.Size(343, 20)
        Me.txtStay.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Staying days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Customer ID "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Room ID "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(142, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(343, 20)
        Me.txtID.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Booking ID"
        '
        'PicCmt
        '
        Me.PicCmt.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicCmt.Location = New System.Drawing.Point(501, 324)
        Me.PicCmt.Name = "PicCmt"
        Me.PicCmt.Size = New System.Drawing.Size(20, 16)
        Me.PicCmt.TabIndex = 47
        Me.PicCmt.TabStop = False
        Me.PicCmt.Visible = False
        '
        'PicStayingDay
        '
        Me.PicStayingDay.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicStayingDay.Location = New System.Drawing.Point(501, 188)
        Me.PicStayingDay.Name = "PicStayingDay"
        Me.PicStayingDay.Size = New System.Drawing.Size(20, 16)
        Me.PicStayingDay.TabIndex = 46
        Me.PicStayingDay.TabStop = False
        Me.PicStayingDay.Visible = False
        '
        'PicGuestNum
        '
        Me.PicGuestNum.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicGuestNum.Location = New System.Drawing.Point(501, 222)
        Me.PicGuestNum.Name = "PicGuestNum"
        Me.PicGuestNum.Size = New System.Drawing.Size(20, 16)
        Me.PicGuestNum.TabIndex = 45
        Me.PicGuestNum.TabStop = False
        Me.PicGuestNum.Visible = False
        '
        'PicPrice
        '
        Me.PicPrice.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicPrice.Location = New System.Drawing.Point(501, 288)
        Me.PicPrice.Name = "PicPrice"
        Me.PicPrice.Size = New System.Drawing.Size(20, 16)
        Me.PicPrice.TabIndex = 43
        Me.PicPrice.TabStop = False
        Me.PicPrice.Visible = False
        '
        'PicCusID
        '
        Me.PicCusID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicCusID.Location = New System.Drawing.Point(501, 147)
        Me.PicCusID.Name = "PicCusID"
        Me.PicCusID.Size = New System.Drawing.Size(20, 16)
        Me.PicCusID.TabIndex = 42
        Me.PicCusID.TabStop = False
        Me.PicCusID.Visible = False
        '
        'PicRoomID
        '
        Me.PicRoomID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRoomID.Location = New System.Drawing.Point(501, 107)
        Me.PicRoomID.Name = "PicRoomID"
        Me.PicRoomID.Size = New System.Drawing.Size(20, 16)
        Me.PicRoomID.TabIndex = 41
        Me.PicRoomID.TabStop = False
        Me.PicRoomID.Visible = False
        '
        'PicBookID
        '
        Me.PicBookID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicBookID.Location = New System.Drawing.Point(501, 23)
        Me.PicBookID.Name = "PicBookID"
        Me.PicBookID.Size = New System.Drawing.Size(20, 16)
        Me.PicBookID.TabIndex = 39
        Me.PicBookID.TabStop = False
        Me.PicBookID.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(544, 61)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 23)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboRoomID
        '
        Me.cboRoomID.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboRoomID.FormattingEnabled = True
        Me.cboRoomID.Location = New System.Drawing.Point(142, 105)
        Me.cboRoomID.Name = "cboRoomID"
        Me.cboRoomID.Size = New System.Drawing.Size(343, 21)
        Me.cboRoomID.TabIndex = 53
        '
        'PicDate
        '
        Me.PicDate.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicDate.Location = New System.Drawing.Point(501, 64)
        Me.PicDate.Name = "PicDate"
        Me.PicDate.Size = New System.Drawing.Size(20, 16)
        Me.PicDate.TabIndex = 54
        Me.PicDate.TabStop = False
        Me.PicDate.Visible = False
        '
        'PicCkinDt
        '
        Me.PicCkinDt.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicCkinDt.Location = New System.Drawing.Point(501, 256)
        Me.PicCkinDt.Name = "PicCkinDt"
        Me.PicCkinDt.Size = New System.Drawing.Size(20, 16)
        Me.PicCkinDt.TabIndex = 55
        Me.PicCkinDt.TabStop = False
        Me.PicCkinDt.Visible = False
        '
        'btnNav
        '
        Me.btnNav.Location = New System.Drawing.Point(544, 23)
        Me.btnNav.Name = "btnNav"
        Me.btnNav.Size = New System.Drawing.Size(105, 23)
        Me.btnNav.TabIndex = 56
        Me.btnNav.Text = "Home"
        Me.btnNav.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(143, 64)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(343, 20)
        Me.txtDate.TabIndex = 57
        '
        'txtCheckinDate
        '
        Me.txtCheckinDate.Location = New System.Drawing.Point(142, 256)
        Me.txtCheckinDate.Name = "txtCheckinDate"
        Me.txtCheckinDate.Size = New System.Drawing.Size(343, 20)
        Me.txtCheckinDate.TabIndex = 58
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(544, 96)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 23)
        Me.btnDelete.TabIndex = 59
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(544, 125)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(105, 23)
        Me.btnFind.TabIndex = 60
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(544, 154)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 23)
        Me.btnUpdate.TabIndex = 61
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(63, 357)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(105, 23)
        Me.btnFirst.TabIndex = 62
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(200, 357)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(105, 23)
        Me.btnPrevious.TabIndex = 63
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(338, 357)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(105, 23)
        Me.btnNext.TabIndex = 64
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(470, 357)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(105, 23)
        Me.btnLast.TabIndex = 65
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(987, 24)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.RoomToolStripMenuItem, Me.BookingToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BookingToolStripMenuItem.Text = "New Booking"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "booking"
        Me.BookingBindingSource.DataSource = Me.HRRISdbDataSet1
        '
        'HRRISdbDataSet1
        '
        Me.HRRISdbDataSet1.DataSetName = "HRRISdbDataSet1"
        Me.HRRISdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'cboCusId
        '
        Me.cboCusId.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.cboCusId.FormattingEnabled = True
        Me.cboCusId.Location = New System.Drawing.Point(142, 146)
        Me.cboCusId.Name = "cboCusId"
        Me.cboCusId.Size = New System.Drawing.Size(343, 21)
        Me.cboCusId.TabIndex = 68
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingidDataGridViewTextBoxColumn, Me.BookingdateDataGridViewTextBoxColumn, Me.RoomidDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.NumdaysDataGridViewTextBoxColumn, Me.NumguestsDataGridViewTextBoxColumn, Me.CheckindateDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(35, 406)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(940, 150)
        Me.DataGridView1.TabIndex = 69
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
        'BookingBindingSource1
        '
        Me.BookingBindingSource1.DataMember = "booking"
        Me.BookingBindingSource1.DataSource = Me.HRRISdbDataSet3
        '
        'HRRISdbDataSet3
        '
        Me.HRRISdbDataSet3.DataSetName = "HRRISdbDataSet3"
        Me.HRRISdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'btnfinall
        '
        Me.btnfinall.Location = New System.Drawing.Point(544, 201)
        Me.btnfinall.Name = "btnfinall"
        Me.btnfinall.Size = New System.Drawing.Size(105, 23)
        Me.btnfinall.TabIndex = 70
        Me.btnfinall.Text = "finall"
        Me.btnfinall.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 544)
        Me.Controls.Add(Me.btnfinall)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cboCusId)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtCheckinDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnNav)
        Me.Controls.Add(Me.PicCkinDt)
        Me.Controls.Add(Me.PicDate)
        Me.Controls.Add(Me.cboRoomID)
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
        Me.Controls.Add(Me.txtGuesNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Booking"
        Me.Text = "Booking "
        CType(Me.PicCmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStayingDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGuestNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRoomID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBookID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCkinDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRRISdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRRISdbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCmt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGuesNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicCmt As System.Windows.Forms.PictureBox
    Friend WithEvents PicStayingDay As System.Windows.Forms.PictureBox
    Friend WithEvents PicGuestNum As System.Windows.Forms.PictureBox
    Friend WithEvents PicPrice As System.Windows.Forms.PictureBox
    Friend WithEvents PicCusID As System.Windows.Forms.PictureBox
    Friend WithEvents PicRoomID As System.Windows.Forms.PictureBox
    Friend WithEvents PicBookID As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cboRoomID As System.Windows.Forms.ComboBox
    Friend WithEvents PicDate As System.Windows.Forms.PictureBox
    Friend WithEvents PicCkinDt As System.Windows.Forms.PictureBox
    Friend WithEvents btnNav As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCheckinDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HRRISdbDataSet1 As WindowsApplication1.HRRISdbDataSet1
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As WindowsApplication1.HRRISdbDataSet1TableAdapters.bookingTableAdapter
    Friend WithEvents cboCusId As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HRRISdbDataSet3 As WindowsApplication1.HRRISdbDataSet3
    Friend WithEvents BookingBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter1 As WindowsApplication1.HRRISdbDataSet3TableAdapters.bookingTableAdapter
    Friend WithEvents BookingidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumdaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumguestsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckindateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnfinall As Button
End Class
