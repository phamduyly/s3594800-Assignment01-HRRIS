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
    Dim UImodi As New UIController


    Private Sub Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet.room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.HRRISdbDataSet.room)
        Me.Refresh()
        ' moving betweeen record section
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


            Dim Roomimport As RoomDataController = New RoomDataController

            Roomimport.RoomInsert(roomData)


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

        bIsValid = oValidation.isAlphaNumericVal(txtRmType.Text)
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

        bIsValid = oValidation.isAlphaNumericVal(txtRmAva.Text)
        If bIsValid Then
            PicRmAva.Visible = False
        Else
            PicRmAva.Visible = True
            bAllFieldsValid = False
        End If


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
            MsgBox("Click OK to import data")
        Else
            MsgBox("Please recheck data where the error pop-up appear")
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

    End Sub

    Private Sub clearForm()

        txtRmID.Clear()
        txtRmNum.Clear()
        txtRmType.Items.Clear()
        txtRmPrice.Clear()
        txtRmBedNum.Clear()
        txtRmAva.Items.Clear()
        txtRmFl.Items.Clear()
        txtRmDes.Clear()

    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim oControler As RoomDataController = New RoomDataController
        Dim sId = txtRmID.Text
        Dim lsData = oControler.RoomsFindById(sId)

        If lsData.Count = 1 Then
            populateRoomsFields(lsData.Item(0))

        Else
            Debug.Print("no record were found")

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
        Dim oController As RoomDataController = New RoomDataController
        Dim iNumRows = oController.RoomsUpdate(getRoomData)

        If iNumRows = 1 Then
            Debug.Print("The record was updated. check")
        Else
            Debug.Print("The record was not update")

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
    'Menu section

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Try
            Dim customer3 As New Customer
            customer3.ShowDialog()
        Catch ex As Exception
            MsgBox("You have already opened Customer Form")
        End Try
    End Sub



    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        Try
            Dim book3 As New Booking
            book3.ShowDialog()
        Catch ex As Exception
            MsgBox("You have already opened Booking Form")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'UI fucntion 
    'Uisng piccture box and panel for UI
    Private Sub DownStart_Click(sender As Object, e As EventArgs) Handles DownStart.Click
        UIModi.Displayoption(DownStart, Panel2, UpClose)

    End Sub

    Private Sub Adds1_Click(sender As Object, e As EventArgs) Handles Adds1.Click
        UIModi.AddOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
        Button1.Visible = True
        btnDelete.Visible = False
        btnFind.Visible = False
        btnUpdate.Visible = False

    End Sub

    Private Sub Find_Click(sender As Object, e As EventArgs) Handles Find.Click
        UIModi.FindOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
        btnFind.Visible = True
        btnDelete.Visible = False
        Button1.Visible = False
        btnUpdate.Visible = False
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        UIModi.DeleteOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
        btnDelete.Visible = True
        Button1.Visible = False
        btnFind.Visible = False
        btnUpdate.Visible = False

    End Sub

    Private Sub UpClose_Click(sender As Object, e As EventArgs) Handles UpClose.Click
        UIModi.CloseOptions(DownStart, Panel2, UpClose)

    End Sub

    Private Sub Updatetings_Click(sender As Object, e As EventArgs) Handles Updatetings.Click
        UIModi.UpdateOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
        Button1.Visible = False
        btnDelete.Visible = False
        btnFind.Visible = False
        btnUpdate.Visible = True
    End Sub

End Class

