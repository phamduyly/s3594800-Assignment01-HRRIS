Option Explicit On
Option Strict On

'Name: Data Import Controller
'Date:
'Author: Pham Duy Ly 

Imports System.Data.OleDb
Imports System.IO

Public Class DataController

    Public Const CONNECTION_STRING As String = _
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"

    'Customer ms access data insert 
    Public Sub CusInsert(ByRef CusData As Hashtable)

        Dim oConection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        oConection.Open()

        Try
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConection



            oCommand.CommandText = "INSERT INTO customer (title,gender,firstname,lastname,phone,address,email,dob) VALUES(?,?,?,?,?,?,?,?)"


            oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("gender", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("phone", OleDbType.VarChar, 12)
            oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("dob", OleDbType.Date, 30)


            oCommand.Parameters("title").Value = CStr(CusData("title"))
            oCommand.Parameters("gender").Value = CStr(CusData("gender"))
            oCommand.Parameters("firstname").Value = CStr(CusData("firstname"))
            oCommand.Parameters("lastname").Value = CStr(CusData("lastname"))
            oCommand.Parameters("phone").Value = CStr(CusData("phone"))
            oCommand.Parameters("address").Value = CStr(CusData("address"))
            oCommand.Parameters("email").Value = CStr(CusData("email"))
            oCommand.Parameters("dob").Value = CStr(CusData("dob"))

            oCommand.Prepare()
            Debug.Print("SQL:" & oCommand.CommandText)
            oCommand.ExecuteNonQuery()
            MsgBox("the data is imported")
        Catch ex As Exception
            MsgBox("data input fail")
        End Try
    End Sub

    'room ms access data insert
    Public Sub RoomInsert(ByRef roomData As Hashtable)
        Dim oConection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        oConection.Open()

        Try
            Dim ooCommand As OleDbCommand = New OleDbCommand
            ooCommand.Connection = oConection

            ooCommand.CommandText = "INSERT INTO room(room_number,type,price,num_beds,availability,floor,description) VALUES (?,?,?,?,?,?,?)"

            ooCommand.Parameters.Add("room_number", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("type", OleDbType.VarChar, 255)
            ooCommand.Parameters.Add("price", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("num_beds", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("availability", OleDbType.VarChar, 255)
            ooCommand.Parameters.Add("floor", OleDbType.Integer, 255)
            ooCommand.Parameters.Add("description", OleDbType.VarChar, 255)

            ooCommand.Parameters("room_number").Value = CInt(roomData("room_number"))
            ooCommand.Parameters("type").Value = CStr(roomData("type"))
            ooCommand.Parameters("price").Value = CInt(roomData("price"))
            ooCommand.Parameters("num_beds").Value = CInt(roomData("num_beds"))
            ooCommand.Parameters("availability").Value = CStr(roomData("availability"))
            ooCommand.Parameters("floor").Value = CInt(roomData("floor"))
            ooCommand.Parameters("description").Value = CStr(roomData("description"))

            ooCommand.Prepare()
            Debug.Print("SQL:" & ooCommand.CommandText)
            ooCommand.ExecuteNonQuery()
            MsgBox("Data is imported")
        
        Catch ex As Exception
            MsgBox("data input fail")
        End Try
    End Sub
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

    'findall()
    Public Function findALl() As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM room ORDER BY room_id;"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("room_number") = CInt(oDataReader("room_number"))
                htTempData("type") = CStr(oDataReader("type"))
                htTempData("price") = CInt(oDataReader("price"))
                htTempData("num_beds") = CInt(oDataReader("num_beds"))
                htTempData("availability") = CStr(oDataReader("availability"))
                htTempData("floor") = CInt(oDataReader("floor"))
                htTempData("description") = CStr(oDataReader("description"))
                lsData.Add(htTempData)
                Loop

                Debug.Print("the records were found")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An Error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData
    End Function


End Class
