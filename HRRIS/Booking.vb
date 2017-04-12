Option Strict On
Option Explicit On


Imports System.Data.OleDb
Imports System.IO

'Name: booking input and validation form for HRRI systems
'Date: 11 March 2017
'Author: Ly Pham Duy 

Public Class Booking
    ' this code is for navigation between form
    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer


    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet3.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter1.Fill(Me.HRRISdbDataSet3.booking)
        'TODO: This line of code loads data into the 'HRRISdbDataSet1.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.HRRISdbDataSet1.booking)

        Dim oController As BookingDataController = New BookingDataController
        Dim lsData = oController.BookingfindALl()
        lsData = oController.BookingfindALl()

        'Combobox room - traacking data from database and populate to the box
        txtRoomID.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As RoomDataController = New RoomDataController
        Dim lsData1 = oController1.RoomfindALl()
        For Each Room In lsData1

            txtRoomID.Items.Add(CStr(Room("type")))

        Next

        'Comboxbox cusID - traacking data from database and populate to the box
        'main point: show name , import id
        txtCusId.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ooController As CustomerDataController = New CustomerDataController
        Dim lsData3 = ooController.CusfindALl()
        For Each Customer In lsData3

            txtCusId.Items.Add(CStr(Customer("firstname")))

        Next

        'allow to gain from ROOm id with room type
        Dim selectedIndex As Integer = txtRoomID.SelectedIndex
        Dim selectedItem As Object = txtRoomID.SelectedItem

        Dim selectedIndex1 As Integer = txtCusId.SelectedIndex
        Dim selectedItem1 As Object = txtCusId.SelectedItem

        'populate data when open
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateBookingFields(lsData.Item(iIndex))


    End Sub
    'Combo box part - using txt inorder to keep track on and modify the code less 
    Private Sub txtRoomID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomID.SelectedIndexChanged

        Dim selectedIndex As Integer = txtRoomID.SelectedIndex
        Dim selectedItem As Object = txtRoomID.SelectedItem

        MsgBox("Room ID is: " & selectedIndex.ToString())
        Debug.Print(selectedItem.ToString())


    End Sub

    Private Sub txtCusId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusId.SelectedIndexChanged
        Dim selectedIndex1 As Integer = txtCusId.SelectedIndex
        Dim selectedItem1 As Object = txtCusId.SelectedItem

        MsgBox("Customer ID is: " & selectedIndex1.ToString())
        Debug.Print(selectedItem1.ToString())
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim bIsValid = BookValid()

        If bIsValid = True Then

            Dim bookingData As Hashtable = New Hashtable

            bookingData("customer_id") = txtCusId.SelectedIndex
            bookingData("booking_date") = txtDate.Text
            bookingData("room_id") = txtRoomID.SelectedIndex
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

        bIsValid = oValidation.IsNameRight(txtCusId.Text)
        If bIsValid Then
            PicCusID.Visible = False
        Else
            PicCusID.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtRoomID.Text)
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

        Return bAllFieldsValid = True


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
        Me.Hide()

    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click

        Dim room2 As New Room
        room2.ShowDialog()
        Me.Hide()

    End Sub


    ''' <summary>
    ''' Calculating price
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' Need to fix this fucntion
    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        If CBool((Trim(CStr(txtRoomID.Text <> String.Empty)))) Then

            If txtRoomID.Text = "Normal" Then
                Dim i As Integer = 30
                txtPrice.Text = CStr((CInt(CDbl(txtStay.Text) * i)))
            ElseIf txtRoomID.Text = "Deluxe" Then
                Dim i As Integer = 40
                txtPrice.Text = CStr((CInt(CDbl(txtStay.Text) * i)))
            ElseIf txtRoomID.Text = "Luxury" Then
                Dim i As Integer = 50
                txtPrice.Text = CStr((CInt(CDbl(txtStay.Text) * i)))
            Else
                MsgBox("There are no room type, please reinput")
            End If

        End If
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
        htData = lsData.Item(iIndex)
        populateBookingFields(lsData.Item(iIndex))

        Dim sBookingsDetails As String
        sBookingsDetails = CStr(htData("booking_id"))
        sBookingsDetails = sBookingsDetails & " | " & CDate(htData("booking_date"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("type"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("firstname"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_days"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_guests"))
        sBookingsDetails = sBookingsDetails & " | " & CDate(htData("checkin_date"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("total_price"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("comments"))
        Debug.Print("Booking Details: " & vbCrLf & sBookingsDetails)





    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsData.Item(iIndex)
            populateBookingFields(lsData.Item(iIndex))

            Dim sBookingsDetails As String
            sBookingsDetails = CStr(htData("booking_id"))
            sBookingsDetails = sBookingsDetails & " | " & CDate(htData("booking_date"))
            sBookingsDetails = sBookingsDetails & " | " & CStr(htData("type"))
            sBookingsDetails = sBookingsDetails & " | " & CStr(htData("firstname"))
            sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_days"))
            sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_guests"))
            sBookingsDetails = sBookingsDetails & " | " & CDate(htData("checkin_date"))
            sBookingsDetails = sBookingsDetails & " | " & CInt(htData("total_price"))
            sBookingsDetails = sBookingsDetails & " | " & CStr(htData("comments"))
            Debug.Print("Booking Details: " & vbCrLf & sBookingsDetails)
        Catch ex As Exception
            MsgBox("end of record")
        End Try
        


    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = iCurrentIndex - 1
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateBookingFields(lsData.Item(iIndex))

        Dim sBookingsDetails As String
        sBookingsDetails = CStr(htData("booking_id"))
        sBookingsDetails = sBookingsDetails & " | " & CDate(htData("booking_date"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("type"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("firstname"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_days"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_guests"))
        sBookingsDetails = sBookingsDetails & " | " & CDate(htData("checkin_date"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("total_price"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("comments"))
        Debug.Print("Booking Details: " & vbCrLf & sBookingsDetails)



    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = lsData.Count - 1
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateBookingFields(lsData.Item(iIndex))

        Dim sBookingsDetails As String
        sBookingsDetails = CStr(htData("booking_id"))
        sBookingsDetails = sBookingsDetails & " | " & CDate(htData("booking_date"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("type"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("firstname"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_days"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("num_guests"))
        sBookingsDetails = sBookingsDetails & " | " & CDate(htData("checkin_date"))
        sBookingsDetails = sBookingsDetails & " | " & CInt(htData("total_price"))
        sBookingsDetails = sBookingsDetails & " | " & CStr(htData("comments"))
        Debug.Print("Booking Details: " & vbCrLf & sBookingsDetails)



    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As BookingDataController = New BookingDataController
        Dim sId = txtID.Text
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
        txtRoomID.Items.Clear()
        txtCusId.Items.Clear()
        txtStay.Clear()
        txtGuesNum.Clear()
        txtPrice.Clear()
        txtCmt.Clear()

    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim oControler As BookingDataController = New BookingDataController
        Dim sId = txtCusID.Text
        Dim lsData = oControler.BookingsFindById(sId)

        If lsData.Count = 1 Then
            populateBookingFields(lsData.Item(0))

        Else
            Debug.Print("no record were found")

        End If
    End Sub

    Private Sub populateBookingFields(ByRef bookingData As Hashtable)

        txtID.Text = CStr(CInt(bookingData("booking_id")))
        txtDate.Text = CStr(CDate(bookingData("booking_date")))
        txtRoomID.SelectedText = CStr(CStr(bookingData("type")))
        txtCusId.SelectedText = CStr(CStr(bookingData("firstname")))
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
        BookingData("type") = txtRoomID.Text
        BookingData("firstname") = txtCusId.Text
        BookingData("num_days") = txtStay.Text
        BookingData("num_guests") = txtGuesNum.Text
        BookingData("checkin_date") = txtCheckinDate.Text
        BookingData("total_price") = txtPrice.Text
        BookingData("comments") = txtCmt.Text


        Return BookingData

    End Function


End Class
