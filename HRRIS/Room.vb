Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

'Name: room form 
'Date: 11 March 2017
'Author: Ly Pham Duy 

Public Class Room

    'moving betweeen record section
    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer


    'Binding for datagrid refresh


    Private Sub Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet.room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.HRRISdbDataSet.room)

        Dim tootipBookg As New ToolTip
        'Input fields part 
        tootipBookg.SetToolTip(txtRmID, "Choose room ID")
        tootipBookg.SetToolTip(txtRmNum, "Choose room number")
        tootipBookg.SetToolTip(txtRmType, "Choose room type")
        tootipBookg.SetToolTip(txtRmPrice, "choose room price")
        tootipBookg.SetToolTip(txtRmBedNum, "choose room bed number")
        tootipBookg.SetToolTip(txtRmAva, "Choose room avalibility")
        tootipBookg.SetToolTip(txtRmFl, "Choose room floor from the drop down list")
        tootipBookg.SetToolTip(txtRmDes, "Input room description")


        'Button part 
        tootipBookg.SetToolTip(btnFirst, "Click New to input new record")
        tootipBookg.SetToolTip(btnDelete, "Input room ID to delete record")
        tootipBookg.SetToolTip(btnFind, "Input room ID to find record")

        tootipBookg.SetToolTip(btnFirst, "Navigation")
        tootipBookg.SetToolTip(btnNext, "Navigation")
        tootipBookg.SetToolTip(btnPrevious, "Navigation")
        tootipBookg.SetToolTip(btnLast, "Navigation")
        movingAndDisplay()

    End Sub

    'moving betweeen record section
    'Display the very first record of room from database 
    Private Sub movingAndDisplay()

        Dim MoveRecord As RoomDataController = New RoomDataController
        lsData = MoveRecord.RoomfindALl()

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateRoomsFields(lsData.Item(iIndex))

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bIsValid1 = valid()

        If bIsValid1 = True Then

            Dim roomData As Hashtable = New Hashtable

            roomData("room_number") = txtRmNum.Text
            roomData("type") = txtRmType.Text
            roomData("price") = txtRmPrice.Text
            roomData("num_beds") = txtRmBedNum.Text
            roomData("availability") = txtRmAva.Text
            roomData("floor") = txtRmFl.Text
            roomData("description") = txtRmDes.Text

            Select Case MsgBox("Are you sure to insert this record", MsgBoxStyle.YesNo, "delete")
                Case MsgBoxResult.Yes
                    Dim Roomimport As RoomDataController = New RoomDataController
                    Roomimport.RoomInsert(roomData)
                    Me.RoomTableAdapter.Fill(Me.HRRISdbDataSet.room)
                Case MsgBoxResult.No
                    MsgBox("The record was not Inserted")
            End Select

        End If


    End Sub

    Private Function valid() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

        'boking ID
        bIsValid = IsNumeric(txtRmNum.Text)
        If bIsValid Then
            PicRmNum.Visible = False
        Else
            PicRmNum.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.IsType(txtRmType.Text)
        If bIsValid Then
            PicRmType.Visible = False
        Else
            PicRmType.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtRmPrice.Text)
        If bIsValid Then
            PicRmPrice.Visible = False

        Else
            PicRmPrice.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtRmBedNum.Text)
        If bIsValid Then
            PicRmBedNum.Visible = False
        Else
            PicRmBedNum.Visible = True
            bAllFieldsValid = False
        End If

        ''Only can choose yes or no 
        'bIsValid = oValidation.IsRm(txtRmAva.Text)
        'If bIsValid Then
        '    PicRmAva.Visible = False
        'Else
        '    PicRmAva.Visible = True
        '    bAllFieldsValid = False
        'End If


        bIsValid = IsNumeric(txtRmFl.Text)
        If bIsValid Then
            PicRmFl.Visible = False
        Else
            PicRmFl.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtRmDes.Text)
        If bIsValid Then
            PicRmDes.Visible = False
        Else
            PicRmDes.Visible = True
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then

        Else
            MsgBox("Unable to add data where Error pop up appears due to reason bellow:" & vbCrLf & "1.Out of range" & vbCrLf & "2.Wrong format" & vbCrLf & "Point to where popup appear to see the error")
        End If

        Return bAllFieldsValid = True

    End Function



    'New added features - for assignment 2: Delete , Find all,  
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateRoomsFields(lsData.Item(iIndex))

    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsData.Item(iIndex)
            populateRoomsFields(lsData.Item(iIndex))

        Catch ex As Exception
            MsgBox("End of Record")
        End Try

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Try
            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            htData = lsData.Item(iIndex)
            populateRoomsFields(lsData.Item(iIndex))

        Catch ex As Exception
            MsgBox("Very first record")
        End Try

    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = lsData.Count - 1
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateRoomsFields(lsData.Item(iIndex))

    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As RoomDataController = New RoomDataController
        Dim sId = txtRmID.Text

        Select Case MsgBox("Are you sure to delete this record", MsgBoxStyle.YesNo, "delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = oController.RoomsDelete(sId)
                If iNumRows = 1 Then
                    clearForm()
                    MsgBox("The record was delete")
                End If
            Case MsgBoxResult.No
                MsgBox("The record was not delete")
        End Select

        Me.RoomTableAdapter.Fill(Me.HRRISdbDataSet.room)

    End Sub

    Private Sub clearForm()

        txtRmID.Clear()
        txtRmNum.Clear()
        txtRmType.ResetText()
        txtRmPrice.Clear()
        txtRmBedNum.Clear()
        txtRmAva.ResetText()
        txtRmFl.ResetText()
        txtRmDes.Clear()

    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim bIsValid As Boolean
        bIsValid = IsNumeric(txtRmID.Text)
        If bIsValid Then
            Dim oControler As RoomDataController = New RoomDataController
            Dim sId = txtRmID.Text
            Dim lsData = oControler.RoomsFindById(sId)

            If lsData.Count = 1 Then
                populateRoomsFields(lsData.Item(0))

            Else
                Debug.Print("no record were found")

            End If
        End If

    End Sub

    Private Sub populateRoomsFields(ByRef roomData As Hashtable)

        txtRmID.Text = CStr(CInt(roomData("room_id")))
        txtRmNum.Text = CStr(roomData("room_number"))
        txtRmType.Text = CStr(roomData("type"))
        txtRmPrice.Text = CStr(roomData("price"))
        txtRmBedNum.Text = CStr(roomData("num_beds"))
        txtRmAva.Text = CStr(roomData("availability"))
        txtRmFl.Text = CStr(roomData("floor"))
        txtRmDes.Text = CStr(roomData("description"))

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Dim bIsValid = valid()

        If bIsValid Then
            Select Case MsgBox("Are you sure to update booking ?", MsgBoxStyle.YesNo, "Update")
                Case MsgBoxResult.Yes
                    'If the user choose YES, the customer data controller then is dimed under the name of cusimport. 
                    'After that , we call the CusInsert function in customerdatacontroller class and import the Cusdata hastable
                    Dim oController As RoomDataController = New RoomDataController
                    Dim iNumRows = oController.RoomsUpdate(getRoomData)

                    If iNumRows = 1 Then
                        Debug.Print("The record was updated. check")
                    Else
                        Debug.Print("The record was not update")

                    End If
                    MsgBox("The record was updated")
                    'then the msgbox appear 
                    'Bellow code allow the Datagrid view to refresh
                    Me.RoomTableAdapter.Fill(Me.HRRISdbDataSet.room)

                Case MsgBoxResult.No
                    'The choose no, the result is the data is not inserted and the msgbox is appear. 
                    MsgBox("The record was not updated")
            End Select
        End If
    End Sub

    Private Function getRoomData() As Hashtable
        Dim roomData As Hashtable = New Hashtable
        roomData("room_id") = txtRmID.Text
        roomData("room_number") = txtRmNum.Text
        roomData("type") = txtRmType.Text
        roomData("price") = txtRmPrice.Text
        roomData("num_beds") = txtRmBedNum.Text
        roomData("availability") = txtRmAva.Text
        roomData("floor") = txtRmFl.Text
        roomData("description") = txtRmDes.Text

        Return roomData

    End Function
    'This region is for menu
#Region "menu"
    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click
        txtRmID.Clear()
        txtRmID.Enabled = False
        Button1.Visible = True
        btnDelete.Visible = False
        btnFind.Visible = False
        btnUpdate.Visible = False
        clearForm()



    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim cus1 As New Customer
        Me.Hide()
        cus1.ShowDialog()
        Me.Close()

    End Sub



    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        Dim bok1 As New Booking
        Me.Hide()
        bok1.ShowDialog()
        Me.Close()

    End Sub
    'Purpose: enable all fucntion for RUD relating to database 
    'Displaying the first record 
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        txtRmID.Enabled = True
        Button1.Visible = False
        btnDelete.Visible = True
        btnFind.Visible = True
        btnUpdate.Visible = True

        movingAndDisplay()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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
        Dim sHelp As String
        sHelp = "Help.html"
        Dim sParam As String = """" & Application.StartupPath & "\" & sHelp & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)
    End Sub

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        Dim repor1 As New Report
        Me.Hide()
        repor1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BreakReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BreakReportToolStripMenuItem.Click
        Dim brkreport1 As New BreakReport
        Me.Hide()
        brkreport1.ShowDialog()
        Me.Close()
    End Sub
#End Region




End Class

