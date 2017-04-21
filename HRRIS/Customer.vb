Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports System.IO

'Name:Customer form
'Date: 11 March 2017
'Authors: Ly Pham Duy - s3594800 RMIT VN 


Public Class Customer

    'moving between record section
    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    Dim UIModi As New UIController


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet2.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.HRRISdbDataSet2.customer)
        Me.Refresh()
        'moving between record section
        Dim MoveRecord As CustomerDataController = New CustomerDataController
        lsData = MoveRecord.CusfindALl()

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

        'Implemeting tooltip for the Customer form 
        Dim tooltip1 As New ToolTip
        tooltip1.SetToolTip(txtCusID, "Customer ID")




    End Sub
    'btnInsert and validate data: Valiate data stage - trying using menu 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bIsValid = CusValid()

        If bIsValid Then

            Dim CusData As Hashtable = New Hashtable

            CusData("title") = txtCusTitl.Text
            CusData("gender") = txtGender.Text
            CusData("firstname") = txtCusFirName.Text
            CusData("lastname") = txtCusLasName.Text
            CusData("phone") = txtCusPhone.Text
            CusData("address") = txtCusAdd.Text
            CusData("email") = txtCusEmail.Text
            CusData("dob") = txtCusDOB.Text

            Dim Cusimport As CustomerDataController = New CustomerDataController
            Cusimport.CusInsert(CusData)

        End If


    End Sub

    'VAlidation
    Private Function CusValid() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

        'bIsValid = oValidation.isAlphaNumericVal(txtCusTitl.Text)
        'If bIsValid Then
        '    PicTitle.Visible = False
        'Else
        '    PicTitle.Visible = True
        '    bAllFieldsValid = False
        'End If

        'bIsValid = oValidation.isAlphaNumericVal(txtGender.Text)
        'If bIsValid Then
        '    PicGender.Visible = False
        'Else
        '    PicGender.Visible = True
        '    bAllFieldsValid = False
        'End If

        bIsValid = oValidation.IsNameRight(txtCusFirName.Text)
        If bIsValid Then
            PicFName.Visible = False
        Else
            PicFName.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.IsNameRight(txtCusLasName.Text)
        If bIsValid Then
            PicLName.Visible = False
        Else
            PicLName.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isPhoneVal(txtCusPhone.Text)
        If bIsValid Then
            PicPhone.Visible = False

        Else
            PicPhone.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAddressRight(txtCusAdd.Text)
        If bIsValid Then
            PicAddr.Visible = False
        Else
            PicAddr.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isEmailAdress(txtCusEmail.Text)
        If bIsValid Then
            PicEmal.Visible = False
        Else
            PicEmal.Visible = True
            bAllFieldsValid = False
        End If


        bIsValid = IsDate(txtCusDOB.Text)
        If bIsValid Then
            PicDOB.Visible = False
        Else
            PicDOB.Visible = True
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            MsgBox("Click OK to import Data")
        Else
            MsgBox("Please recheck input at where error pop up appear")
        End If

        Return bAllFieldsValid = True



    End Function


    'CRUD
    'Moving between records
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))




    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try

            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsData.Item(iIndex)
            populateCusFields(lsData.Item(iIndex))

        Catch ex As Exception
            MsgBox("End of record")
        End Try


    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Try

            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            htData = lsData.Item(iIndex)
            populateCusFields(lsData.Item(iIndex))

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
        populateCusFields(lsData.Item(iIndex))



    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As CustomerDataController = New CustomerDataController
        Dim sId = txtCusID.Text

        Select Case MsgBox("Are you sure to delete this record", MsgBoxStyle.YesNo, "delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = oController.CustsDelete(sId)
                If iNumRows = 1 Then
                    clearForm()
                    MsgBox("The record was delete")
                End If
            Case MsgBoxResult.No
                MsgBox("The record was not delete")
        End Select
    End Sub

    Private Sub clearForm()
        txtCusID.Clear()
        txtCusTitl.Items.Clear()
        txtGender.Items.Clear()
        txtCusFirName.Clear()
        txtCusLasName.Clear()
        txtCusPhone.Clear()
        txtCusAdd.Clear()
        txtCusEmail.Clear()

    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim oControler As CustomerDataController = New CustomerDataController
        Dim sId = txtCusID.Text
        Dim lsData = oControler.CusFindById(sId)

        If lsData.Count = 1 Then
            populateCusFields(lsData.Item(0))

        Else
            Debug.Print("no record were found")

        End If
    End Sub

    Private Sub populateCusFields(ByRef CusData As Hashtable)
        txtCusID.Text = CStr(CInt(CusData("customer_id")))
        txtCusTitl.Text = CStr(CusData("title"))
        txtGender.Text = CStr(CusData("gender"))
        txtCusFirName.Text = CStr(CusData("firstname"))
        txtCusLasName.Text = CStr(CusData("lastname"))
        txtCusPhone.Text = CStr(CusData("phone"))
        txtCusAdd.Text = CStr(CusData("address"))
        txtCusEmail.Text = CStr(CusData("email"))
        txtCusDOB.Text = CStr(CDate(CusData("dob")))

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Dim oController As CustomerDataController = New CustomerDataController
        Dim iNumRows = oController.CustsUpdate(getCusData)

        If iNumRows = 1 Then
            Debug.Print("The record was updated. check")
        Else
            Debug.Print("The record was not update")

        End If

    End Sub

    Private Function getCusData() As Hashtable
        Dim CusData As Hashtable = New Hashtable
        CusData("title") = txtCusTitl.Text
        CusData("gender") = txtGender.Text
        CusData("firstname") = txtCusFirName.Text
        CusData("lastname") = txtCusLasName.Text
        CusData("phone") = txtCusPhone.Text
        CusData("address") = txtCusAdd.Text
        CusData("email") = txtCusEmail.Text
        CusData("dob") = txtCusDOB.Text


        Return CusData

    End Function

    'menu section
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        txtCusID.Visible = False
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click

        Dim room1 As New Room
        room1.ShowDialog()


    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click

        Dim booking1 As New Booking
        booking1.ShowDialog()

    End Sub

    'UI fucntion 
    'Uisng piccture box and panel for UI
    Private Sub DownStart_Click(sender As Object, e As EventArgs) Handles DownStart.Click
        UIModi.Displayoption(DownStart,Panel2,UpClose)
    End Sub

    Private Sub Adds1_Click(sender As Object, e As EventArgs) Handles Adds1.Click
        UIModi.AddOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    End Sub

    Private Sub Find_Click(sender As Object, e As EventArgs) Handles Find.Click
        UIModi.FindOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        UIModi.DeleteOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    End Sub

    Private Sub UpClose_Click(sender As Object, e As EventArgs) Handles UpClose.Click
        UIModi.CloseOptions(DownStart, Panel2, UpClose)
    End Sub

    Private Sub Updatetings_Click(sender As Object, e As EventArgs) Handles Updatetings.Click
        UIModi.UpdateOptions(DownStart, Panel2, UpClose, AddStatus, FindStatus, UpdatetingsStatus, DeleteStatus)
    End Sub
End Class
