Option Strict On
Option Explicit On

'Name: SQL controller
'Date: 22/4/2017
'Author: Pham Duy Ly 

Imports System.Data.OleDb
Imports System.IO

Public Class SQLController
    Public Const CONNECTION_STRING As String =
 "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"

    Public Function CusbyId(ByVal sCusId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT customer_id, num_days, booking_date FROM booking WHERE customer_id = ?;"
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
            oCommand.Parameters("customer_id").Value = CInt(sCusId)
            oCommand.Prepare()

            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("customer_id") = CInt(oDataReader("customer_id"))
                htTempData("num_days") = CInt(oDataReader("num_days"))
                htTempData("booking_date") = CDate(oDataReader("booking_date"))

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

    '2ND report generator function 

    Public Function SecondReport(ByVal sRmId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT room_id, total_price, booking_date FROM booking WHERE room_id = ?;"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters("room_id").Value = CInt(sRmId)
            oCommand.Prepare()

            Dim oDataReader = oCommand.ExecuteReader()
            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("total_price") = CInt(oDataReader("total_price"))
                htTempData("booking_date") = CDate(oDataReader("booking_date"))

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

    '3rd report generator function 
    'Select 1.CusId, Month, year = room ID information
    Public Function ThirdReport(ByVal sCusId As String, ByVal iMonths As Integer, ByVal iYears As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT  room_id FROM booking WHERE DatePart (""yyyy"", booking_date) = " & iYears & " And DatePart(""m"", booking_date) = " & iMonths & " And customer_id = ?;"


            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
            oCommand.Parameters("customer_id").Value = CInt(sCusId)
            oCommand.Prepare()



            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable

                htTempData("room_id") = CInt(oDataReader("room_id"))
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
    '4th report
    Public Function FourthReport(ByVal iMonths As Integer, ByVal iYears As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT  * FROM booking WHERE DatePart (""yyyy"", booking_date) = " & iYears & " And DatePart(""m"", booking_date) = " & iMonths & ";"
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
    '5th fucntion 
    'pp: select customer late for given date and months, NOT WORKING RIGTH
    Public Function FifthReport(ByVal iMonths As Integer, ByVal iYears As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT customer_id FROM booking WHERE  checkin_date < NOW();"
            'Not NOW() but have to be the part that iYears, iMonths
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

    '6th fucntion
    'pp: show booking for a room (sRmId) in year and month 
    Public Function SixthReport(ByVal sRmId As String, ByVal iMonths As Integer, ByVal iYears As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM booking WHERE room_id = ? AND DatePart (""yyyy"", booking_date) = " & iYears & " AND DatePart(""m"", booking_date) = " & iMonths & ";"

            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters("room_id").Value = CInt(sRmId)
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
End Class
