Option Strict On
Option Explicit On


Imports System.Data.OleDb
Imports System.IO

'Name: booking input and validation form for HRRI systems
'Date: 11 March 2017
'Author: Ly Pham Duy 

'Nore : modifing combo box, checkbox , radio box 
'ACTUALLY, the report can be do by menustrip , do not need to add so much btn 



Public Class Booking
    ' this code is for navigation within form

    Dim lsDataMov As New List(Of Hashtable)
    Dim iCurrentIndex As Integer
    Dim UIModi As New UIController
    Dim bindingsource1 As New BindingSource

    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet2.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.HRRISdbDataSet2.booking)
        'TODO: This line of code loads data into the 'HRRISdbDataSet3.booking' table. You can move, or remove it, as needed.


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
        tootipBookg.SetToolTip(cboRoomID, "RoomID that available and at the choose Type")
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

        'ComboBox Room - traacking data from database And populate() to the box
        'TODO: import ID while showing type"
        cboRoomID.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As New RoomDataController
        Dim lsData1 = oController1.RoomfindALl()
        For Each Room In lsData1
            cboRoomID.Items.Add(CStr(Room("room_id")))
        Next

        'Comboxbox cusID - traacking data from database and populate() to the box
        'main point: show name , import id
        cboCusId.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ooController As CustomerDataController = New CustomerDataController
        Dim lsData3 = ooController.CusfindALl()
        For Each Customer In lsData3
            cboCusId.Items.Add(CStr(Customer("customer_id")))
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
    Private Sub cboRoomID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomID.SelectedIndexChanged

        Dim selectedIndex As Integer = cboRoomID.SelectedIndex
        Dim selectedItem As Object = cboRoomID.SelectedItem

    End Sub

    Private Sub cboCusId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCusId.SelectedIndexChanged
        Dim selectedIndex1 As Integer = cboCusId.SelectedIndex
        Dim selectedItem1 As Object = cboCusId.SelectedItem

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

        Me.BookingTableAdapter.Fill(Me.HRRISdbDataSet2.booking)

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

        Me.BookingTableAdapter.Fill(Me.HRRISdbDataSet2.booking)

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
        Dim bIsValid As Boolean
        bIsValid = IsNumeric(txtID.Text)

        If bIsValid Then
            Dim oControler As BookingDataController = New BookingDataController
            Dim sId = txtID.Text
            Dim lsData = oControler.BookingsFindById(sId)

            If lsData.Count = 1 Then
                populateBookingFields(lsData.Item(0))

            Else
                Debug.Print("no record were found")

            End If
        End If

    End Sub

    'Initial function room (checked box) - generate ID to the next 

    'Populate is still missing two combobox - try to figure out how to populate data into a cbo that relating to database dropdown list
    Private Sub populateBookingFields(ByRef bookingData As Hashtable)

        txtID.Text = CStr(CInt(bookingData("booking_id")))
        txtDate.Text = CStr(CDate(bookingData("booking_date")))
        cboRoomID.Text = CStr(CType(bookingData("room_id"), String))
        cboCusId.Text = CStr(CType(bookingData("customer_id"), String))
        cboStays.Text = CStr(CInt(bookingData("num_days")))
        cboGuestNum.Text = CStr(CInt(bookingData("num_guests")))
        txtCheckinDate.Text = CStr(CDate(bookingData("checkin_date")))
        txtPrice.Text = CStr(CInt(bookingData("total_price")))
        txtCmt.Text = CStr(CStr(bookingData("comments")))

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Dim bIsValid = BookValid()


        If bIsValid Then
            Dim oController As BookingDataController = New BookingDataController
            Dim iNumRows = oController.BookingsUpdate(getBookingData)

            If iNumRows = 1 Then
                Debug.Print("The record was updated. check")
            Else
                Debug.Print("The record was not update")

            End If
        End If

        Me.BookingTableAdapter.Fill(Me.HRRISdbDataSet2.booking)

    End Sub

    Private Function getBookingData() As Hashtable
        Dim BookingData As Hashtable = New Hashtable
        BookingData("booking_id") = txtID.Text
        BookingData("booking_date") = txtDate.Text
        BookingData("room_id") = cboRoomID.Text
        BookingData("customer_id") = cboCusId.Text
        BookingData("num_days") = cboStays.Text
        BookingData("num_guests") = cboGuestNum.Text
        BookingData("checkin_date") = txtCheckinDate.Text
        BookingData("total_price") = txtPrice.Text
        BookingData("comments") = txtCmt.Text


        Return BookingData

    End Function

    'Calculating done - add more elseif inorder to provide more right calculation
    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        txtPrice.Text = CStr(CInt(cboStays.Text) * CInt(txtRmNum.Text))

        MsgBox("There are no room type, please reinput")

    End Sub

    'Move to invoice form 
    Private Sub btnInvoince_Click(sender As Object, e As EventArgs) Handles btnInvoince.Click

        Dim invoiceform As New Invoice
        invoiceform.bookingIdPass = txtID.Text
        invoiceform.Show()
        Me.Hide()


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

    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        Dim bok As New Room
        bok.Show()
    End Sub

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        Dim repor1 As New Report
        repor1.Show()
        Me.Hide()

    End Sub

    Private Sub BreakReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BreakReportToolStripMenuItem.Click
        Dim brkreport1 As New BreakReport
        brkreport1.Show()
        Me.Hide()
    End Sub


#Region "enhance"
    Private Sub cboCusId_TextChanged(sender As Object, e As EventArgs) Handles cboCusId.TextChanged
        Dim sCusId = cboCusId.Text

        Dim oController As New CustomerDataController
        Dim lsData = oController.CustomerFind(sCusId)

        If lsData.Count = 1 Then
            populatecus(lsData.Item(0))
        End If

    End Sub

    Private Sub cboRoomID_TextChanged(sender As Object, e As EventArgs) Handles cboRoomID.TextChanged
        Dim sRmId = cboRoomID.Text

        Dim oController As New RoomDataController
        Dim lsData = oController.DisplayByRmId(sRmId)

        If lsData.Count = 1 Then
            populateroom(lsData.Item(0))
        End If
    End Sub

    Private Sub populatecus(ByRef cusData As Hashtable)

        txtFirstName.Text = CStr(cusData("firstname"))
    End Sub

    Private Sub populateroom(ByRef roomData As Hashtable)

        txtType.Text = CStr(roomData("type"))
        txtRmNum.Text = CStr(CInt(roomData("price")))

    End Sub

#End Region

#Region "UI PART"

    'UI fucntion 
    'Uisng piccture box and panel for UI
    '    Private Sub DownStart_Click(sender As Object, e As EventArgs) Handles DownStart.Click
    '        UIModi.Displayoption(DownStart, Panel2, UpClose)

    '    End Sub

    '    Private Sub Adds1_Click(sender As Object, e As EventArgs) Handles Adds1.Click
    '        UIModi.AddOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    '        Button1.Visible = True
    '        btnDelete.Visible = False
    '        btnFind.Visible = False
    '        btnUpdate.Visible = False

    '    End Sub

    '    Private Sub Find_Click(sender As Object, e As EventArgs) Handles Find.Click
    '        UIModi.FindOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    '        btnFind.Visible = True
    '        btnDelete.Visible = False
    '        Button1.Visible = False
    '        btnUpdate.Visible = False
    '    End Sub

    '    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
    '        UIModi.DeleteOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    '        btnDelete.Visible = True
    '        Button1.Visible = False
    '        btnFind.Visible = False
    '        btnUpdate.Visible = False

    '    End Sub

    '    Private Sub UpClose_Click(sender As Object, e As EventArgs) Handles UpClose.Click
    '        UIModi.CloseOptions(DownStart, Panel2, UpClose)

    '    End Sub

    '    Private Sub Updatetings_Click(sender As Object, e As EventArgs) Handles Updatetings.Click
    '        UIModi.UpdateOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    '        Button1.Visible = False
    '        btnDelete.Visible = False
    '        btnFind.Visible = False
    '        btnUpdate.Visible = True
    '    End Sub

    '    Private Sub cboRoomID_Leave(sender As Object, e As EventArgs) Handles cboRoomID.Leave
    '        Dim sRmId = cboRoomID.Text

    '        Dim oController As New RoomDataController
    '        Dim lsData = oController.DisplayByRmId(sRmId)

    '        If lsData.Count = 1 Then
    '            populateroom(lsData.Item(0))
    '        End If
    '    End Sub
#End Region

End Class
