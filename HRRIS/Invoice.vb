Option Strict On
Option Explicit On

'Name: invoice 
'Date: 10/4/2017
'Author: Ly Pham Duy 


Public Class Invoice
    Public Property bookingIdPass As String
    Dim lsDataMov1 As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet3.invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.HRRISdbDataSet3.invoice)

        Dim InvoiceMov As InvoiceDataController = New InvoiceDataController
        lsDataMov1 = InvoiceMov.InvoiceFindALl()

        'This line of code related to form booking. The purpose of it is that allow the form to take the current value in booking ID in Booking form to populate right into the invoce form 
        txtId.Text = bookingIdPass

        'Tooltip - this part sometimes is very usefull
        Dim tl As New ToolTip
        'Button part 
        tl.SetToolTip(btnAdd, "click this to save record to Invoice database")
        tl.SetToolTip(btnDelete, "click this to delete Invoice record from database")
        tl.SetToolTip(btnUpdate, "click this to Update record in Invocie Database")
        tl.SetToolTip(btnFind, "click this to find the record in Invoice Database")
        tl.SetToolTip(btnBookingNav, "click this to back to booking form")

        'text part
        tl.SetToolTip(txtId, "Input ID to find for Invoice Record")
        tl.SetToolTip(txtAmount, "Invoice Money")
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim sBookingId = txtId.Text

        Dim oController As New InvoiceDataController
        Dim lsData = oController.InvoicePop(sBookingId)
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

            Dim InvoiceData As New Hashtable
            InvoiceData("booking_id") = txtId.Text
            InvoiceData("invoice_date") = txtInvoiceDate.Text
            InvoiceData("amount") = txtAmount.Text

            Dim InvoiceImport As New InvoiceDataController
            InvoiceImport.InvoiceInsert(InvoiceData)

        End If

        Me.InvoiceTableAdapter.Fill(Me.HRRISdbDataSet3.invoice)
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

    Private Sub PopulateInvoice(ByRef InvoiceData As Hashtable)

        txtId.Text = CStr(CInt(InvoiceData("booking_id")))
        txtAmount.Text = CStr(CInt(InvoiceData("amount")))


    End Sub
    'btn add - after populate the record into the form by performing
    'Bookingfindall() - then the record can now be add into the database 
    ' 
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsDataMov1.Item(iIndex)
        PopulateInvoice(htData)

    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsDataMov1.Item(iIndex)
            PopulateInvoice(lsDataMov1.Item(iIndex))
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
            htData = lsDataMov1.Item(iIndex)
            PopulateInvoice(lsDataMov1.Item(iIndex))
        Catch ex As Exception
            MsgBox("Very first record")
        End Try


    End Sub
    'This function is to move to the last
    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = lsDataMov1.Count - 1
        iCurrentIndex = iIndex
        htData = lsDataMov1.Item(iIndex)
        PopulateInvoice(lsDataMov1.Item(iIndex))

    End Sub
    'This function is to delete the record
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As New InvoiceDataController
        Dim sId As String = txtId.Text

        Select Case MsgBox("Are you sure to delete this record", MsgBoxStyle.YesNo, "delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = oController.InvoiceDelete(sId)
                If iNumRows = 1 Then
                    clearForm()
                    MsgBox("The record was delete")
                End If
            Case MsgBoxResult.No
                MsgBox("The record was not delete")
        End Select

        clearForm()


        Me.InvoiceTableAdapter.Fill(Me.HRRISdbDataSet3.invoice)

    End Sub
    'This fucntion allow to update the record in the invoice database 
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim bIsValid1 = validInvoice()

        If bIsValid1 = True Then

            Dim InvoiceData As Hashtable = New Hashtable

            InvoiceData("invoice_date") = txtInvoiceDate.Text
            InvoiceData("amount") = txtAmount.Text
            InvoiceData("booking_id") = txtId.Text

            Dim InvoiceImport As New InvoiceDataController
            InvoiceImport.InvoiceUpdate(InvoiceData)

        End If

        Me.InvoiceTableAdapter.Fill(Me.HRRISdbDataSet3.invoice)
    End Sub
    'This function is to clear the form 
    Private Sub clearForm()
        txtId.Clear()
        txtAmount.Clear()

    End Sub

    'This fucntio is to populate the price acording to the BOOKING id VALUE to the form

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim bIsvalid As Boolean
        bIsvalid = IsNumeric(txtId.Text)

        Dim oControler As New InvoiceDataController
        Dim sId = txtId.Text
        Dim lsData = oControler.InvoiceFindByID(sId)

        If lsData.Count = 1 Then
            populateInvoice(lsData.Item(0))

        Else
            MsgBox("the booking have not been made")

        End If
    End Sub

#Region "Menuthings"

    'This part is just open and close, moving between form and so on - for the file menu 
    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Dim b1 As New Booking
        Me.Hide()
        b1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        Dim r1 As New Room
        Me.Hide()
        r1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim cs As New Customer
        Me.Hide()
        cs.ShowDialog()
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'This part can be reuse cause it is unchangeable 
        Dim sAbout As String
        sAbout = "About.html "
        Dim sParam As String = """" & Application.StartupPath & "\" & sAbout & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)
    End Sub

    Private Sub HelpPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpPageToolStripMenuItem.Click
        'This part can be reuse cause it is unchangeable 
        Dim sAbout As String
        sAbout = "Help.html "
        Dim sParam As String = """" & Application.StartupPath & "\" & sAbout & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)
    End Sub


#End Region

End Class
