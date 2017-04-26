Option Strict On
Option Explicit On

'Name: Report form for report group and generating
'Date: 27/4/2017
'Author: Ly Pham Duy 


Public Class BreakReport

    'Controll break report 1 and 2 ssection 
    'This is the part of control break report 
    Private Sub btnBreakReport1_Click(sender As Object, e As EventArgs)
        Dim breakReport1 As New ReportController

        Try
            Dim iMonths = cboReportMonth.Text
            Dim iYears = txtReportYear.Text

            breakReport1.createBreakReport(CInt(iMonths), CInt(iYears))


        Catch ex As Exception
            Debug.Print("the error is :" & ex.Message)
            MsgBox("The report could not generate, please recheck")

        End Try
    End Sub

    Private Sub btnBreakReport2_Click(sender As Object, e As EventArgs)
        Dim breakreport2 As New ReportController

        Try
            Dim iYears = txtReportYear.Text
            breakreport2.createBreakReport2(CInt(iYears))

        Catch ex As Exception
            Debug.Print("the error is :" & ex.Message)
            MsgBox("The report could not generate, please recheck")
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