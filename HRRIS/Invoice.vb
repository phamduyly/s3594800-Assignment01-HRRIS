Option Strict On
Option Explicit On

'Name: Invoice form
'Date:15/4/2017
'Author: Pham Duy Ly 

'Idea: generate ivoince after finsind booking form, search and populate into form by llooking into the Booking for bookingID and total amouont of 
'money

'The FLOW: 1.find from booking (btnName: create INVOICE) - 2.Populate from booking (price only)
'3. Add record into DB. 4. perform left over task (navigaiton)
'
'OUTSIDEr: UPDATE fucntion also be reusee becasue if ([price].booking cahgne -> 
'Price of invoice change 

'Missing: NEED TO WRITE FINDALL function for invoice and delete function 
'


Imports System.Data.OleDb
Imports System.IO



Public Class Invoice

    'code for navi
    Dim lsDataMov As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate booking id to the fields 

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As New BookingDataController
        Dim lsData = oController1.BookingfindALl()
        For Each booking In lsData
            ComboBox1.Items.Add(CStr(booking("booking_id")))

        Next

        'Dim Moving As New BookingDataController
        'lsDataMov = Moving.invoiceFindALl()
        'This fucntion is have not written yet

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    'btn add - after populate the record into the form by performing
    'Bookingfindall() - then the record can now be add into the database 
    ' 

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsDataMov.Item(iIndex)
        populateInvoice(lsDataMov.Item(iIndex))


    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsDataMov.Item(iIndex)
            populateInvoice(lsDataMov.Item(iIndex))
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
            populateInvoice(lsDataMov.Item(iIndex))
        Catch ex As Exception
            MsgBox("Very first record")
        End Try


    End Sub
    'This function is to move to the last
    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = lsDataMov.Count - 1
        iCurrentIndex = iIndex
        htData = lsDataMov.Item(iIndex)
        populateInvoice(lsDataMov.Item(iIndex))

    End Sub
    'This function is to delete the record
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As BookingDataController = New BookingDataController
        Dim sId = ComboBox1.Text

        Select Case MsgBox("Are you sure to delete this record", MsgBoxStyle.YesNo, "delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = oController.InvoiceDelete(sId)
                'The fucntio have not been written
                If iNumRows = 1 Then
                    clearForm()
                    MsgBox("The record was delete")
                End If
            Case MsgBoxResult.No
                MsgBox("The record was not delete")
        End Select

    End Sub
    'This function is to clear the form 
    Private Sub clearForm()

        TextBox1.Clear()
        ComboBox1.Items.Clear()
        TextBox2.Clear()

    End Sub

    'This fucntio is to populate the price acording to the BOOKING id VALUE to the form

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim oControler As BookingDataController = New BookingDataController
        Dim sId = ComboBox1.Text
        Dim lsData = oControler.BookingsFindById(sId)

        If lsData.Count = 1 Then
            populateInvoice(lsData.Item(0))

        Else
            MsgBox("the booking have not been made")

        End If
    End Sub

    'Initial function room (checked box) - generate ID to the next 

    'Populate is still missing two combobox - try to figure out how to populate data into a cbo that relating to database dropdown list
    'only popuate the price into form 
    'Date is now - the day that perform the purchasing 

    Private Sub populateInvoice(ByRef bookingData As Hashtable)

        TextBox1.Text = CStr(CInt(bookingData("total_price")

    End Sub

    'Missing exit and navgation between fomr
    'Missing the add function

End Class