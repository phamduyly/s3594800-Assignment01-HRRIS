<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtRmFl = New System.Windows.Forms.ComboBox()
        Me.txtRmAva = New System.Windows.Forms.ComboBox()
        Me.txtRmType = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtRmBedNum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtRmDes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRmPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRmNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRmID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreakReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HRRISdbDataSet = New HRRIS.HRRISdbDataSet()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTableAdapter = New HRRIS.HRRISdbDataSetTableAdapters.roomTableAdapter()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumbedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PicRmDes = New System.Windows.Forms.PictureBox()
        Me.PicRmAva = New System.Windows.Forms.PictureBox()
        Me.PicRmType = New System.Windows.Forms.PictureBox()
        Me.PicRmFl = New System.Windows.Forms.PictureBox()
        Me.PicRmBedNum = New System.Windows.Forms.PictureBox()
        Me.PicRmPrice = New System.Windows.Forms.PictureBox()
        Me.PicRmNum = New System.Windows.Forms.PictureBox()
        Me.PicRmID = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.HRRISdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmDes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmAva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmFl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmBedNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRmFl
        '
        Me.txtRmFl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRmFl.FormattingEnabled = True
        Me.txtRmFl.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.txtRmFl.Location = New System.Drawing.Point(158, 274)
        Me.txtRmFl.Name = "txtRmFl"
        Me.txtRmFl.Size = New System.Drawing.Size(343, 21)
        Me.txtRmFl.TabIndex = 123
        '
        'txtRmAva
        '
        Me.txtRmAva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRmAva.FormattingEnabled = True
        Me.txtRmAva.Items.AddRange(New Object() {"Yes", "No"})
        Me.txtRmAva.Location = New System.Drawing.Point(158, 238)
        Me.txtRmAva.Name = "txtRmAva"
        Me.txtRmAva.Size = New System.Drawing.Size(343, 21)
        Me.txtRmAva.TabIndex = 122
        '
        'txtRmType
        '
        Me.txtRmType.FormattingEnabled = True
        Me.txtRmType.Items.AddRange(New Object() {"Normal ", "Economy", "Deluxe ", "Luxury", "Diamond"})
        Me.txtRmType.Location = New System.Drawing.Point(158, 126)
        Me.txtRmType.Name = "txtRmType"
        Me.txtRmType.Size = New System.Drawing.Size(343, 21)
        Me.txtRmType.TabIndex = 121
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnUpdate.Location = New System.Drawing.Point(589, 238)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 23)
        Me.btnUpdate.TabIndex = 119
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnFind
        '
        Me.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnFind.Location = New System.Drawing.Point(589, 272)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(91, 23)
        Me.btnFind.TabIndex = 118
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        Me.btnFind.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnDelete.Location = New System.Drawing.Point(589, 308)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 23)
        Me.btnDelete.TabIndex = 117
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(410, 351)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(91, 23)
        Me.btnLast.TabIndex = 116
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(169, 351)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(91, 23)
        Me.btnPrevious.TabIndex = 115
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(295, 351)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 23)
        Me.btnNext.TabIndex = 114
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(52, 351)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(91, 23)
        Me.btnFirst.TabIndex = 113
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtRmBedNum
        '
        Me.txtRmBedNum.Location = New System.Drawing.Point(158, 204)
        Me.txtRmBedNum.Name = "txtRmBedNum"
        Me.txtRmBedNum.Size = New System.Drawing.Size(343, 20)
        Me.txtRmBedNum.TabIndex = 107
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.Location = New System.Drawing.Point(589, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtRmDes
        '
        Me.txtRmDes.Location = New System.Drawing.Point(158, 305)
        Me.txtRmDes.Name = "txtRmDes"
        Me.txtRmDes.Size = New System.Drawing.Size(343, 20)
        Me.txtRmDes.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Floor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Availability"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Number of Beds"
        '
        'txtRmPrice
        '
        Me.txtRmPrice.Location = New System.Drawing.Point(158, 166)
        Me.txtRmPrice.Name = "txtRmPrice"
        Me.txtRmPrice.Size = New System.Drawing.Size(343, 20)
        Me.txtRmPrice.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Type"
        '
        'txtRmNum
        '
        Me.txtRmNum.Location = New System.Drawing.Point(158, 89)
        Me.txtRmNum.Name = "txtRmNum"
        Me.txtRmNum.Size = New System.Drawing.Size(343, 20)
        Me.txtRmNum.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Room Number"
        '
        'txtRmID
        '
        Me.txtRmID.AllowDrop = True
        Me.txtRmID.Location = New System.Drawing.Point(158, 51)
        Me.txtRmID.Name = "txtRmID"
        Me.txtRmID.Size = New System.Drawing.Size(343, 20)
        Me.txtRmID.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Room ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(793, 24)
        Me.MenuStrip1.TabIndex = 120
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomToolStripMenuItem, Me.ToolStripMenuItem2, Me.CustomerToolStripMenuItem, Me.BookingToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(123, 6)
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ExitToolStripMenuItem.Text = "Exit "
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
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ReportToolStripMenuItem1.Text = "Report"
        '
        'BreakReportToolStripMenuItem
        '
        Me.BreakReportToolStripMenuItem.Name = "BreakReportToolStripMenuItem"
        Me.BreakReportToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BreakReportToolStripMenuItem.Text = "BreakReport"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.HelpPageToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
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
        Me.HelpPageToolStripMenuItem.Text = "Help page"
        '
        'HRRISdbDataSet
        '
        Me.HRRISdbDataSet.DataSetName = "HRRISdbDataSet"
        Me.HRRISdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me.HRRISdbDataSet
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'FloorDataGridViewTextBoxColumn
        '
        Me.FloorDataGridViewTextBoxColumn.DataPropertyName = "floor"
        Me.FloorDataGridViewTextBoxColumn.HeaderText = "floor"
        Me.FloorDataGridViewTextBoxColumn.Name = "FloorDataGridViewTextBoxColumn"
        '
        'AvailabilityDataGridViewTextBoxColumn
        '
        Me.AvailabilityDataGridViewTextBoxColumn.DataPropertyName = "availability"
        Me.AvailabilityDataGridViewTextBoxColumn.HeaderText = "availability"
        Me.AvailabilityDataGridViewTextBoxColumn.Name = "AvailabilityDataGridViewTextBoxColumn"
        '
        'NumbedsDataGridViewTextBoxColumn
        '
        Me.NumbedsDataGridViewTextBoxColumn.DataPropertyName = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.HeaderText = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.Name = "NumbedsDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomidDataGridViewTextBoxColumn, Me.RoomnumberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.NumbedsDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn, Me.FloorDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.Location = New System.Drawing.Point(48, 380)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.Size = New System.Drawing.Size(699, 150)
        Me.DataGridView1.TabIndex = 129
        '
        'PicRmDes
        '
        Me.PicRmDes.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmDes.Location = New System.Drawing.Point(539, 309)
        Me.PicRmDes.Name = "PicRmDes"
        Me.PicRmDes.Size = New System.Drawing.Size(20, 16)
        Me.PicRmDes.TabIndex = 111
        Me.PicRmDes.TabStop = False
        Me.PicRmDes.Visible = False
        '
        'PicRmAva
        '
        Me.PicRmAva.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmAva.Location = New System.Drawing.Point(539, 243)
        Me.PicRmAva.Name = "PicRmAva"
        Me.PicRmAva.Size = New System.Drawing.Size(20, 16)
        Me.PicRmAva.TabIndex = 110
        Me.PicRmAva.TabStop = False
        Me.PicRmAva.Visible = False
        '
        'PicRmType
        '
        Me.PicRmType.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmType.Location = New System.Drawing.Point(539, 130)
        Me.PicRmType.Name = "PicRmType"
        Me.PicRmType.Size = New System.Drawing.Size(20, 16)
        Me.PicRmType.TabIndex = 109
        Me.PicRmType.TabStop = False
        Me.PicRmType.Visible = False
        '
        'PicRmFl
        '
        Me.PicRmFl.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmFl.Location = New System.Drawing.Point(539, 274)
        Me.PicRmFl.Name = "PicRmFl"
        Me.PicRmFl.Size = New System.Drawing.Size(20, 16)
        Me.PicRmFl.TabIndex = 108
        Me.PicRmFl.TabStop = False
        Me.PicRmFl.Visible = False
        '
        'PicRmBedNum
        '
        Me.PicRmBedNum.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmBedNum.Location = New System.Drawing.Point(539, 208)
        Me.PicRmBedNum.Name = "PicRmBedNum"
        Me.PicRmBedNum.Size = New System.Drawing.Size(20, 16)
        Me.PicRmBedNum.TabIndex = 106
        Me.PicRmBedNum.TabStop = False
        Me.PicRmBedNum.Visible = False
        '
        'PicRmPrice
        '
        Me.PicRmPrice.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmPrice.Location = New System.Drawing.Point(539, 170)
        Me.PicRmPrice.Name = "PicRmPrice"
        Me.PicRmPrice.Size = New System.Drawing.Size(20, 16)
        Me.PicRmPrice.TabIndex = 105
        Me.PicRmPrice.TabStop = False
        Me.PicRmPrice.Visible = False
        '
        'PicRmNum
        '
        Me.PicRmNum.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmNum.Location = New System.Drawing.Point(539, 93)
        Me.PicRmNum.Name = "PicRmNum"
        Me.PicRmNum.Size = New System.Drawing.Size(20, 16)
        Me.PicRmNum.TabIndex = 104
        Me.PicRmNum.TabStop = False
        Me.PicRmNum.Visible = False
        '
        'PicRmID
        '
        Me.PicRmID.Image = Global.HRRIS.My.Resources.Resources.Button_Close_icon
        Me.PicRmID.Location = New System.Drawing.Point(539, 55)
        Me.PicRmID.Name = "PicRmID"
        Me.PicRmID.Size = New System.Drawing.Size(20, 16)
        Me.PicRmID.TabIndex = 103
        Me.PicRmID.TabStop = False
        Me.PicRmID.Visible = False
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 557)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtRmFl)
        Me.Controls.Add(Me.txtRmAva)
        Me.Controls.Add(Me.txtRmType)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.PicRmDes)
        Me.Controls.Add(Me.PicRmAva)
        Me.Controls.Add(Me.PicRmType)
        Me.Controls.Add(Me.PicRmFl)
        Me.Controls.Add(Me.txtRmBedNum)
        Me.Controls.Add(Me.PicRmBedNum)
        Me.Controls.Add(Me.PicRmPrice)
        Me.Controls.Add(Me.PicRmNum)
        Me.Controls.Add(Me.PicRmID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRmDes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRmPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRmNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRmID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Room"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "room"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.HRRISdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmDes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmAva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmFl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmBedNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRmFl As ComboBox
    Friend WithEvents txtRmAva As ComboBox
    Friend WithEvents txtRmType As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents PicRmDes As PictureBox
    Friend WithEvents PicRmAva As PictureBox
    Friend WithEvents PicRmType As PictureBox
    Friend WithEvents PicRmFl As PictureBox
    Friend WithEvents txtRmBedNum As TextBox
    Friend WithEvents PicRmBedNum As PictureBox
    Friend WithEvents PicRmPrice As PictureBox
    Friend WithEvents PicRmNum As PictureBox
    Friend WithEvents PicRmID As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtRmDes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRmPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRmNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRmID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HRRISdbDataSet As HRRISdbDataSet
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As HRRISdbDataSetTableAdapters.roomTableAdapter
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FloorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumbedsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BreakReportToolStripMenuItem As ToolStripMenuItem
End Class
