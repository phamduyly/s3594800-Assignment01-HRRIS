Option Strict On
Option Explicit On

'Name: Report form for report group and generating
'Date: 27/4/2017
'Author: Ly Pham Duy 


Public Class BreakReport

    'Controll break report 1 and 2 ssection 
    'This is the part of control break report 
    'Button 1 - break down report about room information divien by room iD 
    Private Sub btnBreakReport1_Click(sender As Object, e As EventArgs) Handles btnBreakReport1.Click
        Dim breakReport1 As New ReportController
        Dim iValid = YearValidate()

        If iValid Then
            Try
                Dim iMonths = cboReportMonth.Text
                Dim iYears = txtReportYear.Text

                breakReport1.createBreakReport(CInt(iMonths), CInt(iYears))

            Catch ex As Exception
                Debug.Print("the error is :" & ex.Message)
                MsgBox("The report could not generate, please recheck")

            End Try
        Else
        End If
    End Sub
    'Button 2 - break report 2 - c break down invoice dividen by month 
    Private Sub btnBreakReport2_Click(sender As Object, e As EventArgs) Handles btnBreakReport2.Click
        Dim breakreport2 As New ReportController
        Dim valid = YearValidate()
        If valid Then
            Try
                Dim iYears = txtReportYear.Text
                breakreport2.createBreakReport2(CInt(iYears))

            Catch ex As Exception
                Debug.Print("the error is :" & ex.Message)
                MsgBox("The report could not generate, please recheck")
            End Try
        End If

    End Sub

    'Addition Validation function for further use
    Private Function YearValidate() As Boolean
        Dim iValid As Boolean
        Dim oValidation As New Validation
        Dim bAllFieldsValid As Boolean = True


        iValid = IsNumeric(cboReportMonth.Text)
        If iValid Then
            bAllFieldsValid = True
        Else
            MonthError.Visible = True
            bAllFieldsValid = False
        End If

        iValid = IsNumeric(txtReportYear.Text)
        If iValid = True Then
            bAllFieldsValid = True
        Else
            Yearerror.Visible = True
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
        Else
            MsgBox("Unable to create report where Error pop up appears due to reason bellow:" & vbCrLf & "1.Out of range" & vbCrLf & "2.Wrong format" & vbCrLf & "Point to where popup appear to see the error")
        End If

        Return bAllFieldsValid = True

    End Function
    'Load form 
    Private Sub BreakReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim breakrep As New ToolTip
        breakrep.SetToolTip(btnBreakReport1, "Choose room ID and time period")
        breakrep.SetToolTip(btnBreakReport1, "Choose year only")
    End Sub
    'menu section
#Region "Menu"
    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        Dim rm As New Room
        Me.Hide()
        rm.ShowDialog()
        Me.Close()

    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim ivn As New Invoice
        Me.Hide()
        ivn.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Dim bk As New Booking
        Me.Hide()
        bk.ShowDialog()
        Me.Close()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim cus As New Customer
        Me.Hide()
        cus.ShowDialog()
        Me.Close()

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

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim rs As New Report
        Me.Hide()
        rs.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtReportYear.Clear()
        cboReportMonth.ResetText()

    End Sub



#End Region

End Class