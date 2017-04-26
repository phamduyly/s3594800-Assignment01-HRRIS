Option Strict On
Option Explicit On

'Name: Report form for report group and generating
'Date: 27/4/2017
'Author: Ly Pham Duy 

Public Class Report

    '1.generate cus report ABOUT last-booking time , days booked  
    Private Sub btnCusReport_Click(sender As Object, e As EventArgs)
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
    Private Sub btnReport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
    Private Sub btnReport3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Private Sub btnReport4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnReport5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Private Sub btnReport6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
End Class
