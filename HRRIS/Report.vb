Option Strict On
Option Explicit On

'Name: Report form for report group and generating
'Date: 27/4/2017
'Author: Ly Pham Duy 

Public Class Report

    '1.generate cus report ABOUT last-booking time , days booked  
    Private Sub btnCusReport_Click(sender As Object, e As EventArgs) Handles btnCusReport.Click



        Dim GenerateCusReportByID As New ReportController
        Try
            Dim sCusId = cboCusId.Text
            GenerateCusReportByID.createReport01(CStr(sCusId))
        Catch ex As Exception
            Debug.Print("the error is " & ex.Message)
            MsgBox("Please choose a customer")
        End Try

    End Sub

    '2.Generate room_id report ABOUT booking_date, total_price 
    'SQL statement SELECT booking_date, total_price FROM booking WHERE room_id = ?; 
    Private Sub btnReport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport2.Click

        Dim Report2 As New ReportController

        'For excepttion and case that forgot to choose room ID
        Try
            Dim sRoomId = cboRoomID.Text
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
        Dim report3 As New ReportController
        Try
            Dim sCusID = cboCusId.Text
            Dim iYears = txtReportYear.Text
            Dim iMonths = cboReportMonth.Text

            report3.CreateReport03(CStr(sCusID), CInt(iMonths), CInt(iYears))
        Catch ex As Exception
            Debug.Print("the erros is: " & ex.Message)
            MsgBox("The report could not generate, it could be because" & Environment.NewLine & " Customer ID, months or year is not selected")
        End Try

    End Sub
    '4. all bookings in given months and years (??)
    'SQL code is SELECT * FROM booking WHERE (bookingdate = ?); find how to do it with date and year
    Private Sub btnReport4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport4.Click
        Dim report4 As New ReportController

        Try
            Dim iYears = txtReportYear.Text
            Dim iMonths = cboReportMonth.Text
            report4.CreateReport04(CInt(iMonths), CInt(iYears))
        Catch ex As Exception
            Debug.Print("the erros is: " & ex.Message)
            MsgBox("The report could not generate, it could be because" & vbCrLf & " months or year is not selected")
        End Try
    End Sub

    '5.show customer = ? who are due for checkin in a given month or year 
    'SQL code is SELECT * FROM booking WHERE 
    'Clue: using the visible and invisible radio box 

    Private Sub btnReport5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport5.Click
        Dim report5 As New ReportController

        Try
            Dim iYears = txtReportYear.Text
            Dim iMonths = cboReportMonth.Text

            report5.CreateReport05(CInt(iMonths), CInt(iYears))

        Catch ex As Exception
            Debug.Print("the erros is: " & ex.Message)
            MsgBox("The report could not generate, it could be because" & vbCrLf & " months or year is not selected")
        End Try
    End Sub
    '6.show room_id = ? ABOUT bookings * in given months or year 
    'SQL code is SELECT * FROM bookings WHERE room_id = ? AND month = ? OR year = ?;
    Private Sub btnReport6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport6.Click
        Dim report6 As New ReportController

        Try
            Dim sRmId = cboRoomID.Text
            Dim iYears = txtReportYear.Text
            Dim iMonths = cboReportMonth.Text

            report6.CreateReport06(CStr(sRmId), CInt(iMonths), CInt(iYears))

        Catch ex As Exception
            Debug.Print("the erros is: " & ex.Message)
            MsgBox("The report could not generate, it could be because" & vbCrLf & " room ID, months or year is not selected")
        End Try
    End Sub
    'Addition Validation function for further use
    Private Function YearValidate() As Boolean
        Dim iValid As Boolean

        iValid = IsNumeric(txtReportYear.Text)
        If iValid = True Then
        Else
            Yearerror.Visible = True

        End If

        Return iValid
    End Function

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reporttip As New ToolTip
        reporttip.SetToolTip(btnCusReport, "Choose customer ID")
        reporttip.SetToolTip(btnReport2, "Choose customer ID and time period")
        reporttip.SetToolTip(btnReport3, "Choose customer ID and time period")
        reporttip.SetToolTip(btnReport4, "Choose time period")
        reporttip.SetToolTip(btnReport5, "Choose time period")
        reporttip.SetToolTip(btnReport6, "Choose room ID and time period")

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

        cboBookId.DropDownStyle = ComboBoxStyle.DropDownList
        Dim vController As New BookingDataController
        Dim lsData4 = vController.BookingfindALl()
        For Each book In lsData4
            cboBookId.Items.Add(CStr(book("booking_id")))
        Next
    End Sub
#Region "menu"
    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        Dim rm As New Room
        rm.Show()
        Me.Hide()

    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim ivnoe As New Invoice
        ivnoe.Show()
        Me.Hide()

    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Dim book As New Booking
        book.Show()
        Me.Hide()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim csu As New Customer
        csu.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
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
        Dim sHelp As String
        sHelp = "Help.html"
        Dim sParam As String = """" & Application.StartupPath & "\" & sHelp & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)
    End Sub
#End Region

End Class
