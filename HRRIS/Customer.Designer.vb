<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
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
        Me.components = New System.ComponentModel.Container()
        Me.txtCusTitl = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtCusDOB = New System.Windows.Forms.DateTimePicker()
        Me.PicEmal = New System.Windows.Forms.PictureBox()
        Me.PicAddr = New System.Windows.Forms.PictureBox()
        Me.PicLName = New System.Windows.Forms.PictureBox()
        Me.PicFName = New System.Windows.Forms.PictureBox()
        Me.PicGender = New System.Windows.Forms.PictureBox()
        Me.PicTitle = New System.Windows.Forms.PictureBox()
        Me.PicPhone = New System.Windows.Forms.PictureBox()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.PicDOB = New System.Windows.Forms.PictureBox()
        Me.PicCusID = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCusEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCusAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCusPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCusLasName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCusFirName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreakReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRRISdbDataSet1 = New HRRIS.HRRISdbDataSet1()
        Me.CustomerTableAdapter = New HRRIS.HRRISdbDataSet1TableAdapters.customerTableAdapter()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PicEmal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAddr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRRISdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCusTitl
        '
        Me.txtCusTitl.FormattingEnabled = True
        Me.txtCusTitl.Items.AddRange(New Object() {"Mr", "Mrs", "Miss"})
        Me.txtCusTitl.Location = New System.Drawing.Point(157, 99)
        Me.txtCusTitl.Name = "txtCusTitl"
        Me.txtCusTitl.Size = New System.Drawing.Size(330, 21)
        Me.txtCusTitl.TabIndex = 122
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(295, 404)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(93, 23)
        Me.btnNext.TabIndex = 121
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(185, 404)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(93, 23)
        Me.btnPrevious.TabIndex = 120
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(72, 404)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(93, 23)
        Me.btnFirst.TabIndex = 119
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(394, 404)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(93, 23)
        Me.btnLast.TabIndex = 118
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(593, 330)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 23)
        Me.btnUpdate.TabIndex = 117
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(593, 301)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(93, 23)
        Me.btnFind.TabIndex = 116
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        Me.btnFind.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(593, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 23)
        Me.btnDelete.TabIndex = 115
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'txtCusDOB
        '
        Me.txtCusDOB.Location = New System.Drawing.Point(157, 358)
        Me.txtCusDOB.Name = "txtCusDOB"
        Me.txtCusDOB.Size = New System.Drawing.Size(330, 20)
        Me.txtCusDOB.TabIndex = 113
        '
        'PicEmal
        '
        Me.PicEmal.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicEmal.Location = New System.Drawing.Point(521, 326)
        Me.PicEmal.Name = "PicEmal"
        Me.PicEmal.Size = New System.Drawing.Size(20, 16)
        Me.PicEmal.TabIndex = 111
        Me.PicEmal.TabStop = False
        Me.PicEmal.Visible = False
        '
        'PicAddr
        '
        Me.PicAddr.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicAddr.Location = New System.Drawing.Point(521, 294)
        Me.PicAddr.Name = "PicAddr"
        Me.PicAddr.Size = New System.Drawing.Size(20, 16)
        Me.PicAddr.TabIndex = 110
        Me.PicAddr.TabStop = False
        Me.PicAddr.Visible = False
        '
        'PicLName
        '
        Me.PicLName.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicLName.Location = New System.Drawing.Point(521, 222)
        Me.PicLName.Name = "PicLName"
        Me.PicLName.Size = New System.Drawing.Size(20, 16)
        Me.PicLName.TabIndex = 109
        Me.PicLName.TabStop = False
        Me.PicLName.Visible = False
        '
        'PicFName
        '
        Me.PicFName.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicFName.Location = New System.Drawing.Point(521, 181)
        Me.PicFName.Name = "PicFName"
        Me.PicFName.Size = New System.Drawing.Size(20, 16)
        Me.PicFName.TabIndex = 108
        Me.PicFName.TabStop = False
        Me.PicFName.Visible = False
        '
        'PicGender
        '
        Me.PicGender.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicGender.Location = New System.Drawing.Point(521, 141)
        Me.PicGender.Name = "PicGender"
        Me.PicGender.Size = New System.Drawing.Size(20, 16)
        Me.PicGender.TabIndex = 107
        Me.PicGender.TabStop = False
        Me.PicGender.Visible = False
        '
        'PicTitle
        '
        Me.PicTitle.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicTitle.Location = New System.Drawing.Point(521, 110)
        Me.PicTitle.Name = "PicTitle"
        Me.PicTitle.Size = New System.Drawing.Size(20, 16)
        Me.PicTitle.TabIndex = 106
        Me.PicTitle.TabStop = False
        Me.PicTitle.Visible = False
        '
        'PicPhone
        '
        Me.PicPhone.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicPhone.Location = New System.Drawing.Point(521, 264)
        Me.PicPhone.Name = "PicPhone"
        Me.PicPhone.Size = New System.Drawing.Size(20, 16)
        Me.PicPhone.TabIndex = 105
        Me.PicPhone.TabStop = False
        Me.PicPhone.Visible = False
        '
        'txtGender
        '
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Location = New System.Drawing.Point(157, 135)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(330, 21)
        Me.txtGender.TabIndex = 104
        '
        'PicDOB
        '
        Me.PicDOB.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicDOB.Location = New System.Drawing.Point(521, 358)
        Me.PicDOB.Name = "PicDOB"
        Me.PicDOB.Size = New System.Drawing.Size(20, 24)
        Me.PicDOB.TabIndex = 103
        Me.PicDOB.TabStop = False
        Me.PicDOB.Visible = False
        '
        'PicCusID
        '
        Me.PicCusID.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicCusID.Location = New System.Drawing.Point(521, 64)
        Me.PicCusID.Name = "PicCusID"
        Me.PicCusID.Size = New System.Drawing.Size(20, 16)
        Me.PicCusID.TabIndex = 102
        Me.PicCusID.TabStop = False
        Me.PicCusID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Date Of Birth"
        '
        'txtCusEmail
        '
        Me.txtCusEmail.Location = New System.Drawing.Point(157, 326)
        Me.txtCusEmail.Name = "txtCusEmail"
        Me.txtCusEmail.Size = New System.Drawing.Size(330, 20)
        Me.txtCusEmail.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Email "
        '
        'txtCusAdd
        '
        Me.txtCusAdd.Location = New System.Drawing.Point(157, 291)
        Me.txtCusAdd.Name = "txtCusAdd"
        Me.txtCusAdd.Size = New System.Drawing.Size(330, 20)
        Me.txtCusAdd.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Address"
        '
        'txtCusPhone
        '
        Me.txtCusPhone.Location = New System.Drawing.Point(157, 260)
        Me.txtCusPhone.Name = "txtCusPhone"
        Me.txtCusPhone.Size = New System.Drawing.Size(330, 20)
        Me.txtCusPhone.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Phone "
        '
        'txtCusLasName
        '
        Me.txtCusLasName.Location = New System.Drawing.Point(157, 222)
        Me.txtCusLasName.Name = "txtCusLasName"
        Me.txtCusLasName.Size = New System.Drawing.Size(330, 20)
        Me.txtCusLasName.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Last Name "
        '
        'txtCusFirName
        '
        Me.txtCusFirName.Location = New System.Drawing.Point(157, 181)
        Me.txtCusFirName.Name = "txtCusFirName"
        Me.txtCusFirName.Size = New System.Drawing.Size(330, 20)
        Me.txtCusFirName.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "First Name "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Title"
        '
        'txtCusID
        '
        Me.txtCusID.Location = New System.Drawing.Point(157, 61)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(330, 20)
        Me.txtCusID.TabIndex = 88
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(593, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(897, 24)
        Me.MenuStrip1.TabIndex = 114
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.ToolStripMenuItem1, Me.RoomToolStripMenuItem, Me.BookingToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CustomerToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(115, 6)
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(115, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem1, Me.BreakReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ReportToolStripMenuItem.Text = "Report "
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ReportToolStripMenuItem1.Text = "Report"
        '
        'BreakReportToolStripMenuItem
        '
        Me.BreakReportToolStripMenuItem.Name = "BreakReportToolStripMenuItem"
        Me.BreakReportToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BreakReportToolStripMenuItem.Text = "Break Report "
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpPageToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpPageToolStripMenuItem
        '
        Me.HelpPageToolStripMenuItem.Name = "HelpPageToolStripMenuItem"
        Me.HelpPageToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.HelpPageToolStripMenuItem.Text = "Help page"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomeridDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(38, 433)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(779, 150)
        Me.DataGridView1.TabIndex = 128
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.HRRISdbDataSet1
        '
        'HRRISdbDataSet1
        '
        Me.HRRISdbDataSet1.DataSetName = "HRRISdbDataSet1"
        Me.HRRISdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Location = New System.Drawing.Point(575, 67)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(291, 199)
        Me.lstBox.TabIndex = 134
        Me.lstBox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Customer ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(572, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Find Feature Improve"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 623)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCusTitl)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtCusDOB)
        Me.Controls.Add(Me.PicEmal)
        Me.Controls.Add(Me.PicAddr)
        Me.Controls.Add(Me.PicLName)
        Me.Controls.Add(Me.PicFName)
        Me.Controls.Add(Me.PicGender)
        Me.Controls.Add(Me.PicTitle)
        Me.Controls.Add(Me.PicPhone)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.PicDOB)
        Me.Controls.Add(Me.PicCusID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCusEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCusAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCusPhone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCusLasName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCusFirName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCusID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer "
        CType(Me.PicEmal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAddr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRRISdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCusTitl As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtCusDOB As DateTimePicker
    Friend WithEvents PicEmal As PictureBox
    Friend WithEvents PicAddr As PictureBox
    Friend WithEvents PicLName As PictureBox
    Friend WithEvents PicFName As PictureBox
    Friend WithEvents PicGender As PictureBox
    Friend WithEvents PicTitle As PictureBox
    Friend WithEvents PicPhone As PictureBox
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents PicDOB As PictureBox
    Friend WithEvents PicCusID As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCusEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCusAdd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCusPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCusLasName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCusFirName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCusID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HRRISdbDataSet1 As HRRISdbDataSet1
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As HRRISdbDataSet1TableAdapters.customerTableAdapter
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstBox As ListBox
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BreakReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
End Class
