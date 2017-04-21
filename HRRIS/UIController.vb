Option Strict On
Option Explicit On

'Author: Ly Pham 
'date: 
'Name: UI controller 
Imports System.IO

'About: this is UI controller which incharge of moving PANEL

'This controller is use to modify panel for user interface enhancement

'Dim: 
'Function need to write: 
'1.Move ngang
'- Arrow - Current state 
' - Booking
' - Customer
' - room 

'2.Move doc
' - Arrow - current function
' - Add 
' - Find
' - UPdate
' - Delete

Public Class UIController

    Public Sub Displayoption(ByVal DownStart As PictureBox, ByVal Panel2 As Panel, ByVal UpClose As PictureBox)

        DownStart.Hide()
        While (Panel2.Height < 420)

            Panel2.Height += 1

        End While
        UpClose.Show()

    End Sub


    Public Sub CloseOptions(ByVal DownStart As PictureBox, ByVal Panel2 As Panel, ByVal UpClose As PictureBox)
        UpClose.Hide()
        While (Panel2.Height > 65)

            Panel2.Height -= 1

        End While
        DownStart.Show()

    End Sub



    Public Sub FindOptions(ByVal DownStart As PictureBox, ByVal Panel2 As Panel, ByVal UpClose As PictureBox, ByVal AddStatus As PictureBox, ByVal FindStatus As PictureBox, ByVal UpdatetingsStatus As PictureBox, ByVal DeleteStatus As PictureBox)
        'Action: after click find in panel
        'Appear FindStatus picture
        'ToDo: 1.Close pannel 2.Appear status on top 
        FindStatus.Show()
        UpdatetingsStatus.Hide()
        DeleteStatus.Hide()
        AddStatus.Hide()
        CloseOptions(DownStart, Panel2, UpClose)





    End Sub

    Public Sub UpdateOptions(ByVal DownStart As PictureBox, ByVal Panel2 As Panel, ByVal UpClose As PictureBox, ByVal AddStatus As PictureBox, ByVal FindStatus As PictureBox, ByVal UpdatetingsStatus As PictureBox, ByVal DeleteStatus As PictureBox)

        'Action: after click update in panel
        'Appear UpdateStatus picture
        'ToDo: 1.Close pannel 2.Appear status on top 
        FindStatus.Hide()
        UpdatetingsStatus.Show()
        DeleteStatus.Hide()
        AddStatus.Hide()
        CloseOptions(DownStart, Panel2, UpClose)



    End Sub

    Public Sub DeleteOptions(ByVal DownStart As PictureBox, ByVal Panel2 As Panel, ByVal UpClose As PictureBox, ByVal AddStatus As PictureBox, ByVal FindStatus As PictureBox, ByVal UpdatetingsStatus As PictureBox, ByVal DeleteStatus As PictureBox)

        'Action: after click delete in panel
        'Appear DeleteStatus picture 
        'ToDo: 1.Close pannel 2.Appear status on top 
        FindStatus.Hide()
        UpdatetingsStatus.Hide()
        DeleteStatus.Show()
        AddStatus.Hide()
        CloseOptions(DownStart, Panel2, UpClose)


    End Sub


    Public Sub AddOptions(ByVal DownStart As PictureBox, ByVal Panel2 As Panel, ByVal UpClose As PictureBox, ByVal AddStatus As PictureBox, ByVal FindStatus As PictureBox, ByVal UpdatetingsStatus As PictureBox, ByVal DeleteStatus As PictureBox)

        'Action: after click delete in panel
        'Appear DeleteStatus picture 
        'ToDo: 1.Close pannel 2.Appear status on top 
        FindStatus.Hide()
        UpdatetingsStatus.Hide()
        DeleteStatus.Hide()
        AddStatus.Show()
        CloseOptions(DownStart, Panel2, UpClose)


    End Sub



End Class
