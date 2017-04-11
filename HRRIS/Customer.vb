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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet2.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.HRRISdbDataSet2.customer)
        'moving between record section
        Dim MoveRecord As CustomerDataController = New CustomerDataController
        lsData = MoveRecord.CusfindALl()

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

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

        bIsValid = oValidation.isAlphaNumericVal(txtCusTitl.Text)
        If bIsValid Then
            PicTitle.Visible = False
        Else
            PicTitle.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtGender.Text)
        If bIsValid Then
            PicGender.Visible = False
        Else
            PicGender.Visible = True
            bAllFieldsValid = False
        End If

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

        bIsValid = IsNumeric(txtCusPhone.Text)
        If bIsValid Then
            PicPhone.Visible = False

        Else
            PicPhone.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtCusAdd.Text)
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

        Return bAllFieldsValid



    End Function

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
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

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click

        Dim room1 As New Room
        room1.ShowDialog()
        Me.Hide()
       
    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click

        Dim booking1 As New Booking
        booking1.ShowDialog()
        Me.Hide()
    End Sub

    'CRUD
    'Moving between records
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

        Dim sCusDetails As String
        sCusDetails = CStr(htData("customer_id"))
        sCusDetails = sCusDetails & " | " & CStr(htData("title"))
        sCusDetails = sCusDetails & " | " & CStr(htData("gender"))
        sCusDetails = sCusDetails & " | " & CStr(htData("firstname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("lastname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("phone"))
        sCusDetails = sCusDetails & " | " & CStr(htData("address"))
        sCusDetails = sCusDetails & " | " & CStr(htData("email"))
        sCusDetails = sCusDetails & " | " & CDate(htData("dob"))
        Debug.Print("CusDetails: " & vbCrLf & sCusDetails)





    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = iCurrentIndex + 1
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

        Dim sCusDetails As String
        sCusDetails = CStr(htData("customer_id"))
        sCusDetails = sCusDetails & " | " & CStr(htData("title"))
        sCusDetails = sCusDetails & " | " & CStr(htData("gender"))
        sCusDetails = sCusDetails & " | " & CStr(htData("firstname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("lastname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("phone"))
        sCusDetails = sCusDetails & " | " & CStr(htData("address"))
        sCusDetails = sCusDetails & " | " & CStr(htData("email"))
        sCusDetails = sCusDetails & " | " & CDate(htData("dob"))
        Debug.Print("CusDetails: " & vbCrLf & sCusDetails)

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = iCurrentIndex - 1
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

        Dim sCusDetails As String
        sCusDetails = CStr(htData("customer_id"))
        sCusDetails = sCusDetails & " | " & CStr(htData("title"))
        sCusDetails = sCusDetails & " | " & CStr(htData("gender"))
        sCusDetails = sCusDetails & " | " & CStr(htData("firstname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("lastname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("phone"))
        sCusDetails = sCusDetails & " | " & CStr(htData("address"))
        sCusDetails = sCusDetails & " | " & CStr(htData("email"))
        sCusDetails = sCusDetails & " | " & CDate(htData("dob"))
        Debug.Print("CusDetails: " & vbCrLf & sCusDetails)


    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = lsData.Count - 1
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

        Dim sCusDetails As String
        sCusDetails = CStr(htData("customer_id"))
        sCusDetails = sCusDetails & " | " & CStr(htData("title"))
        sCusDetails = sCusDetails & " | " & CStr(htData("gender"))
        sCusDetails = sCusDetails & " | " & CStr(htData("firstname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("lastname"))
        sCusDetails = sCusDetails & " | " & CStr(htData("phone"))
        sCusDetails = sCusDetails & " | " & CStr(htData("address"))
        sCusDetails = sCusDetails & " | " & CStr(htData("email"))
        sCusDetails = sCusDetails & " | " & CDate(htData("dob"))
        Debug.Print("CusDetails: " & vbCrLf & sCusDetails)


    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As CustomerDataController = New CustomerDataController
        Dim sId = txtCusID.Text
        Dim iNumRows = oController.CustsDelete(sId)

        If iNumRows = 1 Then
            clearForm()
            Debug.Print("Deleted")

        Else
            Debug.Print("Not Deleted")
        End If


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


End Class
