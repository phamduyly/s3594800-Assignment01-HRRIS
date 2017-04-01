Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

'Name: room form 
'Date: 11 March 2017
'Author: Ly Pham Duy 

Public Class Room

    Private Sub Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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


            Dim Roomimport As DataController = New DataController
            Roomimport.RoomInsert(roomData)


        End If

    End Sub

    'Navigation to Customer form and Booking form
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Dim customer3 As New Customer
            customer3.ShowDialog()
        Catch ex As Exception
            MsgBox("You have already opened Customer Form")
        End Try

    End Sub

    Private Sub btnBookFrm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim book3 As New Booking
            book3.ShowDialog()
        Catch ex As Exception
            MsgBox("You have already opened Booking Form")
        End Try

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

        Return True

    End Function

    Private Sub btnNav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNav.Click

        Dim Navigation As New Navigation
        Navigation.Show()
        Me.Hide()

    End Sub
End Class

