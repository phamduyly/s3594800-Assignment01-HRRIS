Option Explicit On
Option Strict On

'Name: Data Import Controller
'Date:
'Author: Pham Duy Ly 

Imports System.Data.OleDb
Imports System.IO

Public Class RoomDataController

    Public Const CONNECTION_STRING As String =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"


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
    'Find all fucntion for room
    Public Function RoomfindALl() As List(Of Hashtable)
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
    'This is used in combobox - findby ID function
    Public Function RoomsFindById(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand

            oCommand.Connection = oConnection
            oCommand.CommandText = "SELECT * FROM room WHERE room_id = ?;"

            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters("room_id").Value = CStr(sId)
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

            Debug.Print("the record was found.")



        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("an error occured. The record(s) could not be found")
        Finally
            oConnection.Close()

        End Try

        Return lsData
    End Function
    'This purely for display purpose of combobox
    Public Function DisplayByRmId(ByRef sRmId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)


        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT price, type FROM room WHERE  room_id = ?;"

            oCommand.Parameters.Add("sRmId", OleDbType.Integer, 15)
            oCommand.Parameters("sRmId").Value = CInt(sRmId)

            oCommand.Prepare()
            Debug.Print(oCommand.CommandText)

            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable

                htTempData("type") = CStr(oDataReader("type"))
                htTempData("price") = CInt(oDataReader("price"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("the record was found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)

        Finally
            oConnection.Close()

        End Try

        Return lsData
    End Function



    'Room finds by type 
    'variable : sType - finds tools
    'Purely for populate data about room into the field
    Public Function DisplayByType(ByRef sType As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)


        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM room WHERE  type = """ + sType + """;"

            oCommand.Prepare()
            Debug.Print(oCommand.CommandText)

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

            Debug.Print("the record was found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        Finally
            oConnection.Close()

        End Try

        Return lsData
    End Function

    'CRUD room data 
    'room update
    Public Function RoomsUpdate(ByVal roomData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'Todo 

            oCommand.CommandText = "UPDATE room SET room_number = ?, type = ?, price = ?, num_beds = ?, availability = ?, floor = ?, description = ? WHERE room_id = ?;"

            oCommand.Parameters.Add("room_number", OleDbType.Integer, 10)
            oCommand.Parameters.Add("type", OleDbType.VarChar, 50)
            oCommand.Parameters.Add("price", OleDbType.Integer, 50)
            oCommand.Parameters.Add("num_beds", OleDbType.Integer, 10)
            oCommand.Parameters.Add("availability", OleDbType.VarChar, 100)
            oCommand.Parameters.Add("floor", OleDbType.Integer, 10)
            oCommand.Parameters.Add("description", OleDbType.VarChar, 100)
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 10)

            oCommand.Parameters("room_number").Value = CInt(roomData("room_number"))
            oCommand.Parameters("type").Value = CStr(roomData("type"))
            oCommand.Parameters("price").Value = CInt(roomData("price"))
            oCommand.Parameters("num_beds").Value = CInt(roomData("num_beds"))
            oCommand.Parameters("availability").Value = CStr(roomData("availability"))
            oCommand.Parameters("floor").Value = CInt(roomData("floor"))
            oCommand.Parameters("description").Value = CStr(roomData("description"))
            oCommand.Parameters("room_id").Value = CInt(roomData("room_id"))

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

    Public Function RoomsDelete(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'todo
            oCommand.CommandText = "DELETE FROM room WHERE room_id = ?;"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters("room_id").Value = CInt(sId)
            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was deleted.")

        Catch ex As Exception
            Debug.Print(CStr(iNumRows))
            Debug.Print("Please Delete booking record which have this room ID first")

        Finally
            oConnection.Close()
        End Try

        Return iNumRows

    End Function


End Class