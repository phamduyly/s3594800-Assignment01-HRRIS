Option Strict On
Option Explicit On

'Name: invoice 
'Date: 10/4/2017
'Author: Ly Pham Duy 

Imports System.Data.OleDb
Imports System.IO

Public Class Invoice
    Public Property bookingIdPass As String
    Dim lsDataMov As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet3.invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.HRRISdbDataSet3.invoice)

        Dim Moving As New BookingDataController
        lsDataMov = Moving.InvoiceFindALl()

        txtId.Text = bookingIdPass

        txtInvoiceDate.Text = CStr(Now())

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim sBookingId = txtId.Text

        Dim oController As New BookingDataController
        Dim lsData = oController.BookingsFindById(sBookingId)

        If lsData.Count = 1 Then
            PopulateAtOpen(lsData.Item(0))
        End If
    End Sub
    Private Sub PopulateAtOpen(ByRef bookingData As Hashtable)

        txtAmount.Text = CStr(CInt(bookingData("total_price")))


    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim bIsValid1 = validInvoice()

        If bIsValid1 = True Then

            Dim InvoiceData As Hashtable = New Hashtable
            InvoiceData("booking_id") = txtId.Text
            InvoiceData("invoice_date") = txtInvoiceDate.Text
            InvoiceData("amount") = txtAmount.Text

            Dim InvoiceImport As New InvoiceDataController
            InvoiceImport.InvoiceInsert(InvoiceData)

        End If

    End Sub

    Private Function validInvoice() As Boolean
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

        bIsValid = IsNumeric(txtId.Text)
        If bIsValid Then
            PictxtId.Visible = False
        Else
            PictxtId.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtAmount.Text)
        If bIsValid Then
            PicAmountEr.Visible = False
        Else
            PicAmountEr.Visible = True
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid

    End Function

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
        Dim sId = cboBookingID.Text

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
        txtId.Clear()
        txtAmount.Clear()

    End Sub

    'This fucntio is to populate the price acording to the BOOKING id VALUE to the form

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click

        Dim oControler As New InvoiceDataController
        Dim sId = cboBookingID.Text
        Dim lsData = oControler.InvoiceFindByID(sId)

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

    Private Sub populateInvoice(ByRef invoiceData As Hashtable)

        txtAmount.Text = CStr(CInt(invoiceData("total_price")))

    End Sub



    Private Sub comboBokId()

        cboBookingID.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As New BookingDataController
        Dim lsData = oController1.BookingfindALl()
        For Each booking In lsData
            cboBookingID.Items.Add(CStr(booking("booking_id")))

        Next
    End Sub
#Region "Menuthings"
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click

    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Dim bk1 As New Booking
        bk1.Show()
        Me.Hide()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        Dim rm1 As New Room
        rm1.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



#End Region

End Class
