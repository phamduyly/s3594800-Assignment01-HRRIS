
Option Explicit On


Imports System.Data.OleDb
Imports System.IO

'Name: booking input and validation form for HRRI systems
'Date: 11 March 2017
'Author: Ly Pham Duy 

Public Class Booking
    ' this code is for navigation between form

    Dim lsDataMov As New List(Of Hashtable)
    Dim iCurrentIndex As Integer


    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet3.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter1.Fill(Me.HRRISdbDataSet3.booking)
        Me.Refresh()


        Dim Moving As BookingDataController = New BookingDataController
        lsDataMov = Moving.BookingfindALl()

        'Combobox room - traacking data from database and populate() to the box
        'TODO: import ID while showing type"
        cboRoomID.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As RoomDataController = New RoomDataController
        Dim lsData1 = oController1.RoomfindALl()
        For Each Room In lsData1
            cboRoomID.Items.Add(CStr(Room("type")))
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
    Private Sub txtRoomID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomID.SelectedIndexChanged

        Dim selectedIndex As Integer = cboRoomID.SelectedIndex
        Dim selectedItem As Object = cboRoomID.SelectedItem

        MsgBox("Room ID is: " & selectedIndex.ToString())



    End Sub

    Private Sub txtCusId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCusId.SelectedIndexChanged
        Dim selectedIndex1 As Integer = cboCusId.SelectedIndex
        Dim selectedItem1 As Object = cboCusId.SelectedItem

        MsgBox("Customer ID is: " & selectedIndex1.ToString())

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim bIsValid = BookValid()

        If bIsValid Then

            Dim bookingData As Hashtable = New Hashtable

            bookingData("customer_id") = cboCusId.SelectedItem
            bookingData("booking_date") = txtDate.Text
            bookingData("room_id") = cboRoomID.SelectedItem
            bookingData("num_days") = txtStay.Text
            bookingData("num_guests") = txtGuesNum.Text
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

        bIsValid = IsNumeric(txtStay.Text)
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

        bIsValid = IsNumeric(txtGuesNum.Text)
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

    ''' <summary>
    ''' Menu - File - Navigation section 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click

        Dim customer2 As New Customer
        customer2.ShowDialog()


    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click

        Dim room2 As New Room
        room2.Show()


    End Sub

    ''' <summary>
    ''' CRUD fucntion 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
        Dim sureToDelte = DeleteValide()
        Dim iNumRows = oController.BookingsDelete(sId)

        If iNumRows = 1 Then
            clearForm()
            Debug.Print("Deleted")

        Else
            Debug.Print("Not Deleted")
        End If


    End Sub

    Private Sub clearForm()

        txtID.Clear()
        cboRoomID.Items.Clear()
        cboCusId.Items.Clear()
        txtStay.Clear()
        txtGuesNum.Clear()
        txtPrice.Clear()
        txtCmt.Clear()

    End Sub
    ' Not really right but I beliveD I am in the right direction
    Private Function DeleteValide() As Boolean
        Dim Sure As Boolean = True
        If Sure Then
            MsgBox("Click OK to delete data")
        Else
            MsgBox("the Data have not been deleted ")
        End If

        Return Sure
    End Function

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
        txtStay.Text = CStr(CInt(bookingData("num_days")))
        txtGuesNum.Text = CStr(CInt(bookingData("num_guests")))
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
        BookingData("num_days") = txtStay.Text
        BookingData("num_guests") = txtGuesNum.Text
        BookingData("checkin_date") = txtCheckinDate.Text
        BookingData("total_price") = txtPrice.Text
        BookingData("comments") = txtCmt.Text


        Return BookingData

    End Function
    ''' <summary>
    ''' Calculating done - add more elseif inorder to provide more right calculation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        If cboRoomID.SelectedIndex = 1 Then
            Dim i As Integer = 30
            txtPrice.Text = CStr(CInt(txtStay.Text) * i)
        ElseIf cboRoomID.SelectedIndex = 2 Then
            Dim i As Integer = 40
            txtPrice.Text = CStr(CInt(txtStay.Text) * i)
        ElseIf cboRoomID.SelectedIndex = 4 Then
            Dim i As Integer = 50
            txtPrice.Text = CStr(CInt(txtStay.Text) * i)
        Else
            MsgBox("There are no room type, please reinput")
        End If
    End Sub




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




End Class
