Option Strict On
Option Explicit On

'Name: controller for additional features for booking form 1.Customer section 2.Room section 3. For calculating money
'Date: 22/4/2017
'Author: Pham Duy Ly 

Imports System.Data.OleDb
Imports System.IO


Public Class AdditionalController

    Public Const CONNECTION_STRING As String =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"

    'FUCNTIO FOR finding room section 
    Public Function RoomFind(ByVal sType As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT room_id, room_number, type FROM room WHERE  type = """ + sType + """;"
            'This is working now 
            Debug.Print(oCommand.CommandText)
            'oCommand.Parameters.Add("sRmId", OleDbType.Integer, 15)
            'oCommand.Parameters("sRmId").Value = sType

            'oCommand.Parameters.Add("availability", OleDbType.VarChar, 15)
            'oCommand.Parameters("availability").Value = sAva
            oCommand.Prepare()
            Debug.Print(oCommand.CommandText)



            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("type") = CStr(oDataReader("type"))
                htTempData("room_number") = CInt(oDataReader("room_numer"))
                htTempData("availability") = CStr(oDataReader("availability"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("the record was found.")



        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("this find room still not work, ")
        Finally
            oConnection.Close()

        End Try

        Return lsData
    End Function

    'ROOM SECTION
    'Find all function
    
End Class
