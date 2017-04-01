Option Explicit On
Option Strict On

'Name: navigation form 
'Date: 30/3/2017
'Author: Ly Pham Duy 

Public Class Navigation
    Private Sub Navigation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCusForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusForm.Click

        Dim customer2 As New Customer
        customer2.Show()
        Me.Hide()

      

    End Sub

    Private Sub btnRoomForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomForm.Click

        Dim room2 As New Room
        room2.Show()
        Me.Hide()

    End Sub

    Private Sub btnBookingForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookingForm.Click

        Dim booking1 As New Booking
        booking1.Show()
        Me.Hide()
    End Sub


End Class