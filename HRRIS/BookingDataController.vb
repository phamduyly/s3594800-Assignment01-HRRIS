Option Explicit On
Option Strict On

'Name: Data Import Controller
'Date:
'Author: Pham Duy Ly 

Imports System.Data.OleDb
Imports System.IO

Public Class BookingDataController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"

    'booking ms access data insert 
    Public Sub BookingInsert(ByRef bookingData As Hashtable)

        Dim oConection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        oConection.Open()

        Try

            Dim ooCommand As OleDbCommand = New OleDbCommand
            ooCommand.Connection = oConection

            ooCommand.CommandText = "INSERT INTO booking (booking_date,room_id,customer_id,num_days,num_guests,checkin_date,total_price,comments) VALUES(?,?,?,?,?,?,?,?)"

            ooCommand.Parameters.Add("booking_date", OleDbType.Date, 255)
            ooCommand.Parameters.Add("room_id", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("customer_id", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("num_days", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("num_guests", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("checkin_date", OleDbType.Date, 255)
            ooCommand.Parameters.Add("total_price", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("comments", OleDbType.VarChar, 255)

            ooCommand.Parameters("booking_date").Value = CDate(bookingData("booking_date"))
            ooCommand.Parameters("room_id").Value = CInt(bookingData("room_id"))
            ooCommand.Parameters("customer_id").Value = CInt(bookingData("customer_id"))
            ooCommand.Parameters("num_days").Value = CInt(bookingData("num_days"))
            ooCommand.Parameters("num_guests").Value = CInt(bookingData("num_guests"))
            ooCommand.Parameters("checkin_date").Value = CDate(bookingData("checkin_date"))
            ooCommand.Parameters("total_price").Value = CInt(bookingData("total_price"))
            ooCommand.Parameters("comments").Value = CStr(bookingData("comments"))



            ooCommand.Prepare()
            Debug.Print("SQL:" & ooCommand.CommandText)
            ooCommand.ExecuteNonQuery()

            MsgBox("the data is imported")
        Catch ex As Exception
            MsgBox("data input fail")
        End Try

    End Sub

End Class
