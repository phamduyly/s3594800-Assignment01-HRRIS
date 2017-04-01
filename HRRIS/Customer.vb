Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports System.IO

'Name:Customer form
'Date: 11 March 2017
'Authors: Ly Pham Duy - s3594800 RMIT VN 


Public Class Customer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    'btnInsert and validate data: Valiate data stage 
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

            Dim Cusimport As DataController = New DataController
            Cusimport.CusInsert(CusData)

        End If


    End Sub


    'Form navigation section: the form will move to booking form and room form
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Dim room1 As New Room
            room1.ShowDialog()

        Catch ex As Exception
            MsgBox("You have already opened Room Form")
        End Try

    End Sub

    Private Sub btnBookingFrm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim booking1 As New Booking
            booking1.ShowDialog()
        Catch ex As Exception
            MsgBox("You have already opened Booking Form")
        End Try

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

        Return True



    End Function


    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

        Dim Navigation As New Navigation
        Navigation.Show()
        Me.Hide()

    End Sub
End Class
