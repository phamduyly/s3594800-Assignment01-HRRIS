<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PicRmBedNum = New System.Windows.Forms.PictureBox()
        Me.PicRmPrice = New System.Windows.Forms.PictureBox()
        Me.PicRmNum = New System.Windows.Forms.PictureBox()
        Me.PicRmID = New System.Windows.Forms.PictureBox()
        Me.txtRmBedNum = New System.Windows.Forms.TextBox()
        Me.PicRmFl = New System.Windows.Forms.PictureBox()
        Me.PicRmType = New System.Windows.Forms.PictureBox()
        Me.PicRmAva = New System.Windows.Forms.PictureBox()
        Me.PicRmDes = New System.Windows.Forms.PictureBox()
        Me.btnNav = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumbedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRRISdbDataSet = New WindowsApplication1.HRRISdbDataSet()
        Me.RoomTableAdapter = New WindowsApplication1.HRRISdbDataSetTableAdapters.roomTableAdapter()
        Me.txtRmType = New System.Windows.Forms.ComboBox()
        Me.txtRmAva = New System.Windows.Forms.ComboBox()
        Me.txtRmFl = New System.Windows.Forms.ComboBox()
        CType(Me.PicRmBedNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmFl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmAva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRmDes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRRISdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRmDes
        '
        Me.txtRmDes.Location = New System.Drawing.Point(134, 284)
        Me.txtRmDes.Name = "txtRmDes"
        Me.txtRmDes.Size = New System.Drawing.Size(343, 20)
        Me.txtRmDes.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Floor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Availability"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Number of Beds"
        '
        'txtRmPrice
        '
        Me.txtRmPrice.Location = New System.Drawing.Point(134, 145)
        Me.txtRmPrice.Name = "txtRmPrice"
        Me.txtRmPrice.Size = New System.Drawing.Size(343, 20)
        Me.txtRmPrice.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Type"
        '
        'txtRmNum
        '
        Me.txtRmNum.Location = New System.Drawing.Point(134, 68)
        Me.txtRmNum.Name = "txtRmNum"
        Me.txtRmNum.Size = New System.Drawing.Size(343, 20)
        Me.txtRmNum.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Room Number"
        '
        'txtRmID
        '
        Me.txtRmID.AllowDrop = True
        Me.txtRmID.Location = New System.Drawing.Point(134, 30)
        Me.txtRmID.Name = "txtRmID"
        Me.txtRmID.Size = New System.Drawing.Size(343, 20)
        Me.txtRmID.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Room ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(565, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PicRmBedNum
        '
        Me.PicRmBedNum.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmBedNum.Location = New System.Drawing.Point(515, 187)
        Me.PicRmBedNum.Name = "PicRmBedNum"
        Me.PicRmBedNum.Size = New System.Drawing.Size(20, 16)
        Me.PicRmBedNum.TabIndex = 42
        Me.PicRmBedNum.TabStop = False
        Me.PicRmBedNum.Visible = False
        '
        'PicRmPrice
        '
        Me.PicRmPrice.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmPrice.Location = New System.Drawing.Point(515, 149)
        Me.PicRmPrice.Name = "PicRmPrice"
        Me.PicRmPrice.Size = New System.Drawing.Size(20, 16)
        Me.PicRmPrice.TabIndex = 38
        Me.PicRmPrice.TabStop = False
        Me.PicRmPrice.Visible = False
        '
        'PicRmNum
        '
        Me.PicRmNum.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmNum.Location = New System.Drawing.Point(515, 72)
        Me.PicRmNum.Name = "PicRmNum"
        Me.PicRmNum.Size = New System.Drawing.Size(20, 16)
        Me.PicRmNum.TabIndex = 36
        Me.PicRmNum.TabStop = False
        Me.PicRmNum.Visible = False
        '
        'PicRmID
        '
        Me.PicRmID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmID.Location = New System.Drawing.Point(515, 34)
        Me.PicRmID.Name = "PicRmID"
        Me.PicRmID.Size = New System.Drawing.Size(20, 16)
        Me.PicRmID.TabIndex = 35
        Me.PicRmID.TabStop = False
        Me.PicRmID.Visible = False
        '
        'txtRmBedNum
        '
        Me.txtRmBedNum.Location = New System.Drawing.Point(134, 183)
        Me.txtRmBedNum.Name = "txtRmBedNum"
        Me.txtRmBedNum.Size = New System.Drawing.Size(343, 20)
        Me.txtRmBedNum.TabIndex = 55
        '
        'PicRmFl
        '
        Me.PicRmFl.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmFl.Location = New System.Drawing.Point(515, 253)
        Me.PicRmFl.Name = "PicRmFl"
        Me.PicRmFl.Size = New System.Drawing.Size(20, 16)
        Me.PicRmFl.TabIndex = 58
        Me.PicRmFl.TabStop = False
        Me.PicRmFl.Visible = False
        '
        'PicRmType
        '
        Me.PicRmType.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmType.Location = New System.Drawing.Point(515, 109)
        Me.PicRmType.Name = "PicRmType"
        Me.PicRmType.Size = New System.Drawing.Size(20, 16)
        Me.PicRmType.TabIndex = 59
        Me.PicRmType.TabStop = False
        Me.PicRmType.Visible = False
        '
        'PicRmAva
        '
        Me.PicRmAva.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmAva.Location = New System.Drawing.Point(515, 222)
        Me.PicRmAva.Name = "PicRmAva"
        Me.PicRmAva.Size = New System.Drawing.Size(20, 16)
        Me.PicRmAva.TabIndex = 60
        Me.PicRmAva.TabStop = False
        Me.PicRmAva.Visible = False
        '
        'PicRmDes
        '
        Me.PicRmDes.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRmDes.Location = New System.Drawing.Point(515, 288)
        Me.PicRmDes.Name = "PicRmDes"
        Me.PicRmDes.Size = New System.Drawing.Size(20, 16)
        Me.PicRmDes.TabIndex = 61
        Me.PicRmDes.TabStop = False
        Me.PicRmDes.Visible = False
        '
        'btnNav
        '
        Me.btnNav.Location = New System.Drawing.Point(565, 28)
        Me.btnNav.Name = "btnNav"
        Me.btnNav.Size = New System.Drawing.Size(91, 23)
        Me.btnNav.TabIndex = 62
        Me.btnNav.Text = "Home"
        Me.btnNav.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(28, 330)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(91, 23)
        Me.btnFirst.TabIndex = 63
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(271, 330)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 23)
        Me.btnNext.TabIndex = 64
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(145, 330)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(91, 23)
        Me.btnPrevious.TabIndex = 65
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(386, 330)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(91, 23)
        Me.btnLast.TabIndex = 66
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(565, 104)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 23)
        Me.btnDelete.TabIndex = 67
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(565, 133)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(91, 23)
        Me.btnFind.TabIndex = 68
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(565, 162)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 23)
        Me.btnUpdate.TabIndex = 69
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 24)
        Me.MenuStrip1.TabIndex = 70
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.BookingToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RoomToolStripMenuItem.Text = "New"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HelpToolStripMenuItem.Text = "Help "
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomidDataGridViewTextBoxColumn, Me.RoomnumberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.NumbedsDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn, Me.FloorDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(27, 379)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(845, 150)
        Me.DataGridView1.TabIndex = 71
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'NumbedsDataGridViewTextBoxColumn
        '
        Me.NumbedsDataGridViewTextBoxColumn.DataPropertyName = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.HeaderText = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.Name = "NumbedsDataGridViewTextBoxColumn"
        '
        'AvailabilityDataGridViewTextBoxColumn
        '
        Me.AvailabilityDataGridViewTextBoxColumn.DataPropertyName = "availability"
        Me.AvailabilityDataGridViewTextBoxColumn.HeaderText = "availability"
        Me.AvailabilityDataGridViewTextBoxColumn.Name = "AvailabilityDataGridViewTextBoxColumn"
        '
        'FloorDataGridViewTextBoxColumn
        '
        Me.FloorDataGridViewTextBoxColumn.DataPropertyName = "floor"
        Me.FloorDataGridViewTextBoxColumn.HeaderText = "floor"
        Me.FloorDataGridViewTextBoxColumn.Name = "FloorDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me.HRRISdbDataSet
        '
        'HRRISdbDataSet
        '
        Me.HRRISdbDataSet.DataSetName = "HRRISdbDataSet"
        Me.HRRISdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'txtRmType
        '
        Me.txtRmType.FormattingEnabled = True
        Me.txtRmType.Items.AddRange(New Object() {"Normal ", "Economy", "Deluxe ", "Luxury", "Diamond"})
        Me.txtRmType.Location = New System.Drawing.Point(134, 105)
        Me.txtRmType.Name = "txtRmType"
        Me.txtRmType.Size = New System.Drawing.Size(343, 21)
        Me.txtRmType.TabIndex = 72
        '
        'txtRmAva
        '
        Me.txtRmAva.FormattingEnabled = True
        Me.txtRmAva.Items.AddRange(New Object() {"Normal ", "Economy", "Deluxe ", "Luxury", "Diamond"})
        Me.txtRmAva.Location = New System.Drawing.Point(134, 217)
        Me.txtRmAva.Name = "txtRmAva"
        Me.txtRmAva.Size = New System.Drawing.Size(343, 21)
        Me.txtRmAva.TabIndex = 73
        '
        'txtRmFl
        '
        Me.txtRmFl.FormattingEnabled = True
        Me.txtRmFl.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.txtRmFl.Location = New System.Drawing.Point(134, 253)
        Me.txtRmFl.Name = "txtRmFl"
        Me.txtRmFl.Size = New System.Drawing.Size(343, 21)
        Me.txtRmFl.TabIndex = 74
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 541)
        Me.Controls.Add(Me.txtRmFl)
        Me.Controls.Add(Me.txtRmAva)
        Me.Controls.Add(Me.txtRmType)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNav)
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
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Room"
        Me.Text = "Room Input Validation"
        CType(Me.PicRmBedNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmFl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmAva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRmDes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRRISdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRmDes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRmPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRmNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRmID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PicRmBedNum As System.Windows.Forms.PictureBox
    Friend WithEvents PicRmPrice As System.Windows.Forms.PictureBox
    Friend WithEvents PicRmNum As System.Windows.Forms.PictureBox
    Friend WithEvents PicRmID As System.Windows.Forms.PictureBox
    Friend WithEvents txtRmBedNum As System.Windows.Forms.TextBox
    Friend WithEvents PicRmFl As System.Windows.Forms.PictureBox
    Friend WithEvents PicRmType As System.Windows.Forms.PictureBox
    Friend WithEvents PicRmAva As System.Windows.Forms.PictureBox
    Friend WithEvents PicRmDes As System.Windows.Forms.PictureBox
    Friend WithEvents btnNav As System.Windows.Forms.Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HRRISdbDataSet As WindowsApplication1.HRRISdbDataSet
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter As WindowsApplication1.HRRISdbDataSetTableAdapters.roomTableAdapter
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumbedsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FloorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRmType As System.Windows.Forms.ComboBox
    Friend WithEvents txtRmAva As System.Windows.Forms.ComboBox
    Friend WithEvents txtRmFl As System.Windows.Forms.ComboBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
