Option Strict On
Option Explicit On


Imports System.Data.OleDb
Imports System.IO

'Name: booking input and validation form for HRRI systems
'Date: 11 March 2017
'Author: Ly Pham Duy 

'Note: wondring how to input bien string s

'Nore : modifing combo box, checkbox , radio box 
'ACTUALLY, the report can be do by menustrip , do not need to add so much btn 

'

Public Class Booking
    ' this code is for navigation between form

    Dim lsDataMov As New List(Of Hashtable)
    Dim iCurrentIndex As Integer


    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet3.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter1.Fill(Me.HRRISdbDataSet3.booking)
        Me.Refresh()

        'Enable booking ID field whenever click into the form in order to perform CRUD task 

        'Tooltip part for
        Dim tootipBookg As New ToolTip
        'Input fields part 
        tootipBookg.SetToolTip(txtID, "Input ID to perform program function")
        tootipBookg.SetToolTip(txtDate, "Choose booking date here")
        tootipBookg.SetToolTip(txtType, "Choose room type for the customer")
        tootipBookg.SetToolTip(cboCusId, "Choose customer ID from the dropdown box")
        tootipBookg.SetToolTip(cboStays, "Choose customer stays days from the dropdown box")
        tootipBookg.SetToolTip(cboStays, "Choose number of guest from the dropdown box")
        tootipBookg.SetToolTip(txtCheckinDate, "Choose customer checkin date here")
        tootipBookg.SetToolTip(txtPrice, "Booking price will be automatic calculate")
        tootipBookg.SetToolTip(txtCmt, "Input comment here if there are some")
        'Button part 
        tootipBookg.SetToolTip(btnAdd, "Click New to input new record")
        tootipBookg.SetToolTip(btnDelete, "Input booking ID to delete record")
        tootipBookg.SetToolTip(btnFind, "Input ID to booking ID to find record")
        tootipBookg.SetToolTip(btnInvoince, "Click here to generate booking invoice")
        tootipBookg.SetToolTip(btnFirst, "Navigation")
        tootipBookg.SetToolTip(btnNext, "Navigation")
        tootipBookg.SetToolTip(btnPrevious, "Navigation")
        tootipBookg.SetToolTip(btnLast, "Navigation")

        'Form part 





        Dim Moving As BookingDataController = New BookingDataController
        lsDataMov = Moving.BookingfindALl()

        'Combobox room - traacking data from database and populate() to the box
        ''TODO: import ID while showing type"

        cboRoomID.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As RoomDataController = New RoomDataController
        Dim lsData1 = oController1.RoomfindALl()
        'change here to finding the data for type 
        For Each Room In lsData1
            cboRoomID.Items.Add(CStr(Room("room_id")))
        Next

        'Comboxbox cusID - traacking data from database and populate() to the box
        'main point: show name , import id
        cboCusId.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ooController As CustomerDataController = New CustomerDataController
        Dim lsData3 = ooController.CusfindALl()
        For Each Customer In lsData3
            cboCusId.Items.Add(CStr(Customer("firstname")))
        Next

        'allow to gain from ROOm id with room type
        Dim selectedIndex As Integer = cboRoomID.SelectedIndex
        Dim selectedItem As Object = cboRoomID.SelectedItem

        Dim selectedIndex1 As Integer = cboCusId.SelectedIndex
        Dim selectedItem1 As Object = cboCusId.SelectedItem

        'populate() data when open - populateBookingFields()
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsDataMov.Item(iIndex)
        populateBookingFields(lsDataMov.Item(iIndex))




    End Sub
    'Combo box part - using txt inorder to keep track on and modify the code less 
    Private Sub cboRoomID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoomID.SelectedIndexChanged


        Dim selectedIndex As Integer = cboRoomID.SelectedIndex
        Dim selectedItem As Object = cboRoomID.SelectedItem

        MsgBox("Room ID Is: " & selectedIndex.ToString())



    End Sub

    Private Sub cboCusId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCusId.SelectedIndexChanged
        Dim selectedIndex1 As Integer = cboCusId.SelectedIndex
        Dim selectedItem1 As Object = cboCusId.SelectedItem

        MsgBox("Customer ID is: " & selectedIndex1.ToString())
        Debug.Print(CStr(cboCusId.SelectedIndex))

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim bIsValid = BookValid()

        If bIsValid Then

            Dim bookingData As Hashtable = New Hashtable

            bookingData("customer_id") = cboCusId.SelectedIndex
            bookingData("booking_date") = txtDate.Text
            bookingData("room_id") = cboRoomID.SelectedIndex
            bookingData("num_days") = cboStays.Text
            bookingData("num_guests") = cboGuestNum.Text
            bookingData("checkin_date") = txtCheckinDate.Text
            bookingData("total_price") = txtPrice.Text
            bookingData("comments") = txtCmt.Text

            Dim bookingimport As BookingDataController = New BookingDataController
            bookingimport.BookingInsert(bookingData)


        End If

    End Sub

    'validate private function


    Private Function BookValid() As Boolean

        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

        bIsValid = oValidation.IsNameRight(cboCusId.Text)
        If bIsValid Then
            PicCusID.Visible = False
        Else
            PicCusID.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(cboRoomID.Text)
        If bIsValid Then
            PicRoomID.Visible = False
        Else
            PicRoomID.Visible() = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(cboStays.Text)
        If bIsValid Then
            PicStayingDay.Visible = False

        Else
            PicStayingDay.Visible = True
            bAllFieldsValid = False
        End If

        'Date section
        bIsValid = IsDate(txtDate.Text)
        If bIsValid Then
            PicDate.Visible = False
        Else
            PicDate.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsDate(txtCheckinDate.Text)
        If bIsValid Then
            PicCkinDt.Visible = False
        Else
            PicCkinDt.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(cboGuestNum.Text)
        If bIsValid Then
            PicGuestNum.Visible = False
        Else
            PicGuestNum.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtPrice.Text)
        If bIsValid Then
            PicPrice.Visible = False
        Else
            PicPrice.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtCmt.Text)
        If bIsValid Then
            PicCmt.Visible = False
        Else
            PicCmt.Visible = True
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            MsgBox("Click OK to import data")
        Else
            MsgBox("Please recheck data where the error pop-up appear")
        End If

        Return bAllFieldsValid


    End Function

    ' CRUD fucntion 

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsDataMov.Item(iIndex)
        populateBookingFields(lsDataMov.Item(iIndex))


    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsDataMov.Item(iIndex)
            populateBookingFields(lsDataMov.Item(iIndex))
        Catch ex As Exception
            MsgBox("end of record")
        End Try

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Try
            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            htData = lsDataMov.Item(iIndex)
            populateBookingFields(lsDataMov.Item(iIndex))
        Catch ex As Exception
            MsgBox("Very first record")
        End Try


    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = lsDataMov.Count - 1
        iCurrentIndex = iIndex
        htData = lsDataMov.Item(iIndex)
        populateBookingFields(lsDataMov.Item(iIndex))

    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As BookingDataController = New BookingDataController
        Dim sId = txtID.Text

        Select Case MsgBox("Are you sure to delete this record", MsgBoxStyle.YesNo, "delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = oController.BookingsDelete(sId)
                If iNumRows = 1 Then
                    clearForm()
                    MsgBox("The record was delete")
                End If
            Case MsgBoxResult.No
                MsgBox("The record was not delete")
        End Select

    End Sub

    Private Sub clearForm()

        txtID.Clear()
        cboRoomID.Items.Clear()
        cboCusId.Items.Clear()
        cboStays.Items.Clear()
        cboGuestNum.Items.Clear()
        txtPrice.Clear()
        txtCmt.Clear()

    End Sub


    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim oControler As BookingDataController = New BookingDataController
        Dim sId = txtID.Text
        Dim lsData = oControler.BookingsFindById(sId)

        If lsData.Count = 1 Then
            populateBookingFields(lsData.Item(0))

        Else
            Debug.Print("no record were found")

        End If
    End Sub

    'Initial function room (checked box) - generate ID to the next 

    'Populate is still missing two combobox - try to figure out how to populate data into a cbo that relating to database dropdown list
    Private Sub populateBookingFields(ByRef bookingData As Hashtable)

        txtID.Text = CStr(CInt(bookingData("booking_id")))
        txtDate.Text = CStr(CDate(bookingData("booking_date")))
        cboRoomID.ValueMember = CStr(CStr(bookingData("room_id")))
        cboCusId.ValueMember = CStr(CStr(bookingData("customer_id")))
        cboStays.Text = CStr(CInt(bookingData("num_days")))
        cboGuestNum.Text = CStr(CInt(bookingData("num_guests")))
        txtCheckinDate.Text = CStr(CDate(bookingData("checkin_date")))
        txtPrice.Text = CStr(CInt(bookingData("total_price")))
        txtCmt.Text = CStr(CStr(bookingData("comments")))






    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Dim oController As BookingDataController = New BookingDataController
        Dim iNumRows = oController.BookingsUpdate(getBookingData)

        If iNumRows = 1 Then
            Debug.Print("The record was updated. check")
        Else
            Debug.Print("The record was not update")

        End If

    End Sub

    Private Function getBookingData() As Hashtable
        Dim BookingData As Hashtable = New Hashtable
        'This part is suppiciosus
        BookingData("booking_id") = txtID.Text
        BookingData("booking_date") = txtDate.Text
        BookingData("type") = cboRoomID.SelectedIndex
        BookingData("firstname") = cboCusId.SelectedIndex
        BookingData("num_days") = cboStays.Text
        BookingData("num_guests") = cboGuestNum.Text
        BookingData("checkin_date") = txtCheckinDate.Text
        BookingData("total_price") = txtPrice.Text
        BookingData("comments") = txtCmt.Text


        Return BookingData

    End Function

    'Calculating done - add more elseif inorder to provide more right calculation

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        If cboRoomID.SelectedIndex = 1 Then
            Dim i As Integer = 30
            txtPrice.Text = CStr(CInt(cboStays.Text) * i)
        ElseIf cboRoomID.SelectedIndex = 2 Then
            Dim i As Integer = 40
            txtPrice.Text = CStr(CInt(cboStays.Text) * i)
        ElseIf cboRoomID.SelectedIndex = 4 Then
            Dim i As Integer = 50
            txtPrice.Text = CStr(CInt(cboStays.Text) * i)

            MsgBox("There are no room type, please reinput")
        End If
    End Sub




    ' REPORT BUTTON SECTION 
    'IDEA: 
    ' using checked box - idead: can create another same findbyID in room DB to group and return the value for room ID by room type: 
    ' ther are 4 room type , 4 floor, 

    'Code for checked box and DIMING bien 
    ' Dim str As String
    '   str = " "
    '   If CheckBox1.Checked = True Then
    '       str &= CheckBox1.Text
    '       str &= " "
    '   End If
    ' If CheckBox2.Checked = True Then
    '       str &= CheckBox2.Text
    '       str &= " "
    '   End If
    ' If CheckBox3.Checked = True Then
    '       str &= CheckBox3.Text
    '       str &= " "
    '   End If
    ' 'Interesting code :
    ' Private Sub CheckBox4_CheckedChanged(sender As Object,
    'e As EventArgs) Handles CheckBox4.CheckedChanged
    '     Label1.Visible = True
    '     TextBox1.Visible = True
    ' End Sub

    '1.generate cus report ABOUT last-booking time , days booked  
    Private Sub btnCusReport_Click(sender As Object, e As EventArgs) Handles btnCusReport.Click

        Dim GenerateCusReportByID As BookingDataController = New BookingDataController



        Try
            Dim sCusId = cboCusId.SelectedIndex
            GenerateCusReportByID.createReport01(CStr(sCusId))
        Catch ex As Exception
            Debug.Print("the error is " & ex.Message)
            MsgBox("Please choose a customer")
        End Try



    End Sub

    '2.Generate room_id report ABOUT booking_date, total_price 
    'SQL statement SELECT booking_date, total_price FROM booking WHERE room_id = ?; 
    Private Sub btnReport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport2.Click

        Dim Report2 As New BookingDataController

        'For excepttion and case that forgot to choose room ID
        Try
            Dim sRoomId = cboRoomID.SelectedIndex
            Report2.CreateReport02(CStr(sRoomId))

        Catch ex As Exception
            Debug.Print("error is : " & ex.Message)
            MsgBox("Please choose room ID ")

        End Try



    End Sub
    '3.Report customer_id report ABOUT given period = " year and month = 
    'SQL code is SELECT * FROM booking WHERE customer_id = ? AND booking_date = ?; 
    'Create input for months(cbbox) and years(text), dim here 
    Private Sub btnReport3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport3.Click

        Dim report3 As New BookingDataController

        'Dim iYears =  txtYear.Text
        'Dim iMonths = cboMonths.Text

    End Sub
    '4. all bookings in given months and years (??)
    'SQL code is SELECT * FROM booking WHERE (bookingdate = ?); find how to do it with date and year
    Private Sub btnReport4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport4.Click



        'Dim iYears =  txtYear.Text
        'Dim iMonths = cboMonths.Text
    End Sub
    '5.show customer = ? who are due for checkin in a given month or year 
    'SQL code is SELECT * FROM booking WHERE 
    'Clue: using the visible and invisible radio box 

    Private Sub btnReport5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport5.Click


        'Dim iYears =  txtYear.Text
        'Dim iMonths = cboMonths.Text
    End Sub
    '6.show room_id = ? ABOUT bookings * in given months or year 
    'SQL code is SELECT * FROM bookings WHERE room_id = ? AND month = ? OR year = ?;
    Private Sub btnReport6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport6.Click

    End Sub

    'Move to invoice form 
    Private Sub btnInvoince_Click(sender As Object, e As EventArgs) Handles btnInvoince.Click

        Dim invoiceNav As New Invoice
        invoiceNav.ShowDialog()


    End Sub

    'MENU SECTION 
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtID.Clear()
        txtID.Enabled = False

    End Sub


    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim customer As New Customer
        customer.Show()


    End Sub

    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click, CustomerToolStripMenuItem.Click
        Dim bok As New Booking
        bok.Show()
    End Sub


    Private Sub txtType_Leave(sender As Object, e As EventArgs) Handles txtType.Leave
        Dim sType As String = txtType.SelectedIndex.ToString
        cboRoomID.DropDownStyle = ComboBoxStyle.DropDownList

        'change here to finding the data for type 
        For Each Room In lsData1
            cboRoomID.Items.Add(CStr(Room("room_id")))
        Next

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData1 As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT room_id FROM room WHERE type = @type"
            oCommand.Parameters.AddWithValue("@type", txtType.Text)

            'https://www.experts-exchange.com/questions/22853165/VB-NET-Combo-Box-Conversion-from-type-%27DataRowView%27-to-type-%27String%27-is-not-valid-error.html
            'MyCommand = New SqlCommand("UPDATE SeansMessage SET Message = @TicBoxText WHERE Number = 1", dbConn)
            'MyCommand.Parameters.AddWithValue("@TicBoxText", TicBoxText.Text)
            'sqlstring = ("SELECT level FROM Users WHERE Id='" & _txtUsername.Text &

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("room_number") = CInt(oDataReader("room_number"))
                htTempData("type") = CStr(oDataReader("type"))
                htTempData("price") = CInt(oDataReader("price"))
                htTempData("num_beds") = CInt(oDataReader("num_beds"))
                htTempData("availability") = CStr(oDataReader("availability"))
                htTempData("floor") = CInt(oDataReader("floor"))
                htTempData("description") = CStr(oDataReader("description"))
                lsData1.Add(htTempData)
            Loop


            Debug.Print("the records were found")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An Error occurred. The records could not be found! Here")
        Finally
            oConnection.Close()
        End Try


    End Sub



End Class
