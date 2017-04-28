Option Strict On
Option Explicit On

'Name: Report form for report group and generating
'Date: 27/4/2017
'Author: Ly Pham Duy 


Public Class BreakReport

    'Controll break report 1 and 2 ssection 
    'This is the part of control break report 
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

        iValid = IsNumeric(txtReportYear.Text)
        If iValid = True Then
        Else
            Yearerror.Visible = True

        End If

        Return iValid
    End Function

    Private Sub BreakReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRoomID.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As New RoomDataController
        Dim lsData1 = oController1.RoomfindALl()
        For Each Room In lsData1
            cboRoomID.Items.Add(CStr(Room("room_id")))
        Next

        Dim breakrep As New ToolTip
        breakrep.SetToolTip(btnBreakReport1, "Choose room ID and time period")
        breakrep.SetToolTip(btnBreakReport1, "Choose year only")
    End Sub
#Region "Menu"
    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        Dim rom As New Room
        rom.Show()
        Me.Hide()

    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim invoi As New Invoice
        invoi.Show()
        Me.Hide()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Dim bok As New Booking
        bok.Show()
        Me.Hide()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim cus As New Customer
        cus.Show()
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