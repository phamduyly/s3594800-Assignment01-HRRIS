Option Strict On
Option Explicit On

'Name: Login form 
'date: 6/4/2017
'Author: Ly Pham Duy
'Purpose: add login to the program

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtUserName.Text = "Admin") And (txtPass.Text = "12345") Then
            Dim nav As New Navigation
            nav.Show()
            Me.Hide()
        Else
            MsgBox("Your Username/PassWord is not right")
        End If
    End Sub

End Class