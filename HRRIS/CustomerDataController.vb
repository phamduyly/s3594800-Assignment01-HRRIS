Option Explicit On
Option Strict On

'Name: Data Import Controller
'Date:
'Author: Pham Duy Ly 

Imports System.Data.OleDb
Imports System.IO

Public Class CustomerDataController
    Public Const CONNECTION_STRING As String = _
  "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"

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
            oConection.Close()
        Catch ex As Exception
            MsgBox("data input fail")
        End Try
    End Sub

    'Add new features
    'Find all function 
    Public Function CusfindALl() As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM customer ORDER BY customer_id;"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("customer_id") = CInt(oDataReader("customer_id"))
                htTempData("title") = CStr(oDataReader("title"))
                htTempData("gender") = CStr(oDataReader("gender"))
                htTempData("firstname") = CStr(oDataReader("firstname"))
                htTempData("lastname") = CStr(oDataReader("lastname"))
                htTempData("phone") = CInt(oDataReader("phone"))
                htTempData("address") = CStr(oDataReader("address"))
                htTempData("email") = CStr(oDataReader("email"))
                htTempData("dob") = CDate(oDataReader("dob"))
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

    Public Function CusFindById(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand

            oCommand.Connection = oConnection
            oCommand.CommandText = "SELECT * FROM customer WHERE customer_id = ?;"
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
            oCommand.Parameters("customer_id").Value = CInt(sId)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("customer_id") = CInt(oDataReader("customer_id"))
                htTempData("title") = CStr(oDataReader("title"))
                htTempData("gender") = CStr(oDataReader("gender"))
                htTempData("firstname") = CStr(oDataReader("firstname"))
                htTempData("lastname") = CStr(oDataReader("lastname"))
                htTempData("phone") = CInt(oDataReader("phone"))
                htTempData("address") = CStr(oDataReader("address"))
                htTempData("email") = CStr(oDataReader("email"))
                htTempData("dob") = CDate(oDataReader("dob"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("the records were found")

            'this could be made as a smaller sub


        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("an error occured. The record(s) could not be found")
        Finally
            oConnection.Close()

        End Try

        Return lsData
    End Function

    Public Function CustsUpdate(ByVal CusData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'Todo 

            oCommand.CommandText = "UPDATE customer SET title = ?, gender = ?, firstname = ?, lastname = ?, phone = ?, address = ?, email = ?, dob = ?, WHERE customer_id = ?;"

            oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("gender", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("phone", OleDbType.VarChar, 12)
            oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("dob", OleDbType.Date, 30)
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 2)

            oCommand.Parameters("title").Value = CStr(CusData("title"))
            oCommand.Parameters("gender").Value = CStr(CusData("gender"))
            oCommand.Parameters("firstname").Value = CStr(CusData("firstname"))
            oCommand.Parameters("lastname").Value = CStr(CusData("lastname"))
            oCommand.Parameters("phone").Value = CStr(CusData("phone"))
            oCommand.Parameters("address").Value = CStr(CusData("address"))
            oCommand.Parameters("email").Value = CStr(CusData("email"))
            oCommand.Parameters("dob").Value = CStr(CusData("dob"))
            oCommand.Parameters("customer_id").Value = CInt(CusData("customer_id"))

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

    Public Function CustsDelete(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'todo
            oCommand.CommandText = "DELETE FROM customer WHERE customer_id = ?;"
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
            oCommand.Parameters("customer_id").Value = CInt(sId)
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
