<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.txtCusTitl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCusFirName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCusLasName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCusPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCusAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCusEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PicCusID = New System.Windows.Forms.PictureBox()
        Me.PicDOB = New System.Windows.Forms.PictureBox()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.PicPhone = New System.Windows.Forms.PictureBox()
        Me.PicTitle = New System.Windows.Forms.PictureBox()
        Me.PicGender = New System.Windows.Forms.PictureBox()
        Me.PicFName = New System.Windows.Forms.PictureBox()
        Me.PicLName = New System.Windows.Forms.PictureBox()
        Me.PicAddr = New System.Windows.Forms.PictureBox()
        Me.PicEmal = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.txtCusDOB = New System.Windows.Forms.DateTimePicker()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAddr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEmal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer ID"
        '
        'txtCusID
        '
        Me.txtCusID.Enabled = False
        Me.txtCusID.Location = New System.Drawing.Point(134, 24)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(330, 20)
        Me.txtCusID.TabIndex = 2
        '
        'txtCusTitl
        '
        Me.txtCusTitl.Location = New System.Drawing.Point(134, 62)
        Me.txtCusTitl.Name = "txtCusTitl"
        Me.txtCusTitl.Size = New System.Drawing.Size(330, 20)
        Me.txtCusTitl.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Gender"
        '
        'txtCusFirName
        '
        Me.txtCusFirName.Location = New System.Drawing.Point(134, 144)
        Me.txtCusFirName.Name = "txtCusFirName"
        Me.txtCusFirName.Size = New System.Drawing.Size(330, 20)
        Me.txtCusFirName.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "First Name "
        '
        'txtCusLasName
        '
        Me.txtCusLasName.Location = New System.Drawing.Point(134, 185)
        Me.txtCusLasName.Name = "txtCusLasName"
        Me.txtCusLasName.Size = New System.Drawing.Size(330, 20)
        Me.txtCusLasName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Last Name "
        '
        'txtCusPhone
        '
        Me.txtCusPhone.Location = New System.Drawing.Point(134, 223)
        Me.txtCusPhone.Name = "txtCusPhone"
        Me.txtCusPhone.Size = New System.Drawing.Size(330, 20)
        Me.txtCusPhone.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Phone "
        '
        'txtCusAdd
        '
        Me.txtCusAdd.Location = New System.Drawing.Point(134, 254)
        Me.txtCusAdd.Name = "txtCusAdd"
        Me.txtCusAdd.Size = New System.Drawing.Size(330, 20)
        Me.txtCusAdd.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Address"
        '
        'txtCusEmail
        '
        Me.txtCusEmail.Location = New System.Drawing.Point(134, 289)
        Me.txtCusEmail.Name = "txtCusEmail"
        Me.txtCusEmail.Size = New System.Drawing.Size(330, 20)
        Me.txtCusEmail.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Date Of Birth"
        '
        'PicCusID
        '
        Me.PicCusID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicCusID.Location = New System.Drawing.Point(498, 27)
        Me.PicCusID.Name = "PicCusID"
        Me.PicCusID.Size = New System.Drawing.Size(20, 16)
        Me.PicCusID.TabIndex = 19
        Me.PicCusID.TabStop = False
        Me.PicCusID.Visible = False
        '
        'PicDOB
        '
        Me.PicDOB.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicDOB.Location = New System.Drawing.Point(498, 321)
        Me.PicDOB.Name = "PicDOB"
        Me.PicDOB.Size = New System.Drawing.Size(20, 24)
        Me.PicDOB.TabIndex = 24
        Me.PicDOB.TabStop = False
        Me.PicDOB.Visible = False
        '
        'txtGender
        '
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Location = New System.Drawing.Point(134, 98)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(330, 21)
        Me.txtGender.TabIndex = 58
        '
        'PicPhone
        '
        Me.PicPhone.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicPhone.Location = New System.Drawing.Point(498, 227)
        Me.PicPhone.Name = "PicPhone"
        Me.PicPhone.Size = New System.Drawing.Size(20, 16)
        Me.PicPhone.TabIndex = 59
        Me.PicPhone.TabStop = False
        Me.PicPhone.Visible = False
        '
        'PicTitle
        '
        Me.PicTitle.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicTitle.Location = New System.Drawing.Point(498, 73)
        Me.PicTitle.Name = "PicTitle"
        Me.PicTitle.Size = New System.Drawing.Size(20, 16)
        Me.PicTitle.TabIndex = 60
        Me.PicTitle.TabStop = False
        Me.PicTitle.Visible = False
        '
        'PicGender
        '
        Me.PicGender.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicGender.Location = New System.Drawing.Point(498, 104)
        Me.PicGender.Name = "PicGender"
        Me.PicGender.Size = New System.Drawing.Size(20, 16)
        Me.PicGender.TabIndex = 61
        Me.PicGender.TabStop = False
        Me.PicGender.Visible = False
        '
        'PicFName
        '
        Me.PicFName.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicFName.Location = New System.Drawing.Point(498, 144)
        Me.PicFName.Name = "PicFName"
        Me.PicFName.Size = New System.Drawing.Size(20, 16)
        Me.PicFName.TabIndex = 62
        Me.PicFName.TabStop = False
        Me.PicFName.Visible = False
        '
        'PicLName
        '
        Me.PicLName.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicLName.Location = New System.Drawing.Point(498, 185)
        Me.PicLName.Name = "PicLName"
        Me.PicLName.Size = New System.Drawing.Size(20, 16)
        Me.PicLName.TabIndex = 63
        Me.PicLName.TabStop = False
        Me.PicLName.Visible = False
        '
        'PicAddr
        '
        Me.PicAddr.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicAddr.Location = New System.Drawing.Point(498, 257)
        Me.PicAddr.Name = "PicAddr"
        Me.PicAddr.Size = New System.Drawing.Size(20, 16)
        Me.PicAddr.TabIndex = 64
        Me.PicAddr.TabStop = False
        Me.PicAddr.Visible = False
        '
        'PicEmal
        '
        Me.PicEmal.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicEmal.Location = New System.Drawing.Point(498, 289)
        Me.PicEmal.Name = "PicEmal"
        Me.PicEmal.Size = New System.Drawing.Size(20, 16)
        Me.PicEmal.TabIndex = 65
        Me.PicEmal.TabStop = False
        Me.PicEmal.Visible = False
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(557, 16)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(93, 23)
        Me.btnHome.TabIndex = 66
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'txtCusDOB
        '
        Me.txtCusDOB.Location = New System.Drawing.Point(134, 321)
        Me.txtCusDOB.Name = "txtCusDOB"
        Me.txtCusDOB.Size = New System.Drawing.Size(330, 20)
        Me.txtCusDOB.TabIndex = 67
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 402)
        Me.Controls.Add(Me.txtCusDOB)
        Me.Controls.Add(Me.btnHome)
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
        Me.Controls.Add(Me.txtCusTitl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCusID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Customer"
        Me.Text = "Customer Input Validation"
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAddr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEmal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCusID As System.Windows.Forms.TextBox
    Friend WithEvents txtCusTitl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCusFirName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCusLasName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCusPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCusAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCusEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PicCusID As System.Windows.Forms.PictureBox
    Friend WithEvents PicDOB As System.Windows.Forms.PictureBox
    Friend WithEvents txtGender As System.Windows.Forms.ComboBox
    Friend WithEvents PicPhone As System.Windows.Forms.PictureBox
    Friend WithEvents PicTitle As System.Windows.Forms.PictureBox
    Friend WithEvents PicGender As System.Windows.Forms.PictureBox
    Friend WithEvents PicFName As System.Windows.Forms.PictureBox
    Friend WithEvents PicLName As System.Windows.Forms.PictureBox
    Friend WithEvents PicAddr As System.Windows.Forms.PictureBox
    Friend WithEvents PicEmal As System.Windows.Forms.PictureBox
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents txtCusDOB As System.Windows.Forms.DateTimePicker

End Class
