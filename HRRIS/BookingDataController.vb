Option Explicit On
Option Strict On

'Name: Data Import Controller
'Date:
'Author: Pham Duy Ly 

'Note: adding a  fucntion with calling ID and GROUP room type - writing on roomDataController - based on findsbyID 
Imports System.Data.OleDb
Imports System.IO

Public Class BookingDataController
    Public Const CONNECTION_STRING As String =
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
            oConection.Close()
        Catch ex As Exception
            MsgBox("data input fail")
        End Try

    End Sub


    'Find all function
    Public Function BookingfindALl() As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM booking ORDER BY booking_id;"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CInt(oDataReader("booking_id"))
                htTempData("booking_date") = CDate(oDataReader("booking_date"))
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("customer_id") = CInt(oDataReader("customer_id"))
                htTempData("num_days") = CInt(oDataReader("num_days"))
                htTempData("num_guests") = CInt(oDataReader("num_guests"))
                htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData("total_price") = CInt(oDataReader("total_price"))
                htTempData("comments") = CStr(oDataReader("comments"))
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
    'For Invoice 
    'Purpose: populate information into the form
    Public Function InvoiceFindALl() As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM invoice ORDER BY booking_id;"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CInt(oDataReader("booking_id"))
                htTempData("date") = CDate(oDataReader("date"))
                htTempData("total_price") = CInt(oDataReader("total_price"))
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
    'Done after fixing the database collum and type which relating to the Database 
    Public Function BookingsFindById(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM booking WHERE booking_id = ?;"
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)
            oCommand.Parameters("booking_id").Value = CInt(sId)
            oCommand.Prepare()



            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CInt(oDataReader("booking_id"))
                htTempData("booking_date") = CDate(oDataReader("booking_date"))
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("customer_id") = CInt(oDataReader("customer_id"))
                htTempData("num_days") = CInt(oDataReader("num_days"))
                htTempData("num_guests") = CInt(oDataReader("num_guests"))
                htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData("total_price") = CInt(oDataReader("total_price"))
                htTempData("comments") = CStr(oDataReader("comments"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("the record was found.")



        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("an error occured. The record(s) could not be found")
        Finally
            oConnection.Close()

        End Try

        Return lsData
    End Function

    'Continue with CRUD fucntion 
    Public Function BookingsUpdate(ByVal bookingData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'Todo 

            oCommand.CommandText = "UPDATE booking SET booking_date = ?, room_id = ?, customer_id = ?, num_days = ?, num_guests = ?, checkin_date = ?, total_price = ?, comments = ? WHERE booking_id = ?;"

            oCommand.Parameters.Add("booking_date", OleDbType.Date, 255)
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 255)
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 255)
            oCommand.Parameters.Add("num_days", OleDbType.Integer, 255)
            oCommand.Parameters.Add("num_guests", OleDbType.Integer, 255)
            oCommand.Parameters.Add("checkin_date", OleDbType.Date, 255)
            oCommand.Parameters.Add("total_price", OleDbType.Integer, 255)
            oCommand.Parameters.Add("comments", OleDbType.VarChar, 255)

            oCommand.Parameters("booking_date").Value = CDate(bookingData("booking_date"))
            oCommand.Parameters("room_id").Value = CInt(bookingData("room_id"))
            oCommand.Parameters("customer_id").Value = CInt(bookingData("customer_id"))
            oCommand.Parameters("num_days").Value = CInt(bookingData("num_days"))
            oCommand.Parameters("num_guests").Value = CInt(bookingData("num_guests"))
            oCommand.Parameters("checkin_date").Value = CDate(bookingData("checkin_date"))
            oCommand.Parameters("total_price").Value = CInt(bookingData("total_price"))
            oCommand.Parameters("comments").Value = CStr(bookingData("comments"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("the record was updated.")



        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox(" an error occured. The record was not updated")

        Finally
            oConnection.Close()

        End Try

        Return iNumRows

    End Function

    'Delete a record lab 5.4
    ' Delete seems to be working 
    Public Function BookingsDelete(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'todo
            oCommand.CommandText = "DELETE FROM booking WHERE booking_id = ?;"
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)
            oCommand.Parameters("booking_id").Value = CInt(sId)
            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was deleted.")

        Catch ex As Exception
            Debug.Print(CStr(iNumRows))
            Debug.Print("an error occured. the record was not deleted")

        Finally
            oConnection.Close()
        End Try

        Return iNumRows

    End Function

    'Invoice delete function
    'Purpose : to delete the invoice information
    Public Function InvoiceDelete(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'todo
            oCommand.CommandText = "DELETE FROM invoice WHERE booking_id = ?;"
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)
            oCommand.Parameters("booking_id").Value = CInt(sId)
            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was deleted.")

        Catch ex As Exception
            Debug.Print(CStr(iNumRows))
            Debug.Print("an error occured. the record was not deleted")

        Finally
            oConnection.Close()
        End Try

        Return iNumRows

    End Function
    

End Class

