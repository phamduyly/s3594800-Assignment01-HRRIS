Option Strict On
Option Explicit On

'Name: Invoice data controller for invoice form 
'Date: 10/4/2017
'Author: Pham Duy Ly 

Imports System.Data.OleDb
Imports System.IO


Public Class InvoiceDataController

    Public Const CONNECTION_STRING As String =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"
    'Invoice function 

    Public Sub InvoiceInsert(ByRef InvoiceData As Hashtable)
        Dim oConection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        oConection.Open()

        Try
            Dim ooCommand As OleDbCommand = New OleDbCommand
            ooCommand.Connection = oConection

            ooCommand.CommandText = "INSERT INTO invoice(booking_id, invoice_date, amount) VALUES (?,?,?);"

            ooCommand.Parameters.Add("booking_id", OleDbType.Integer, 10)
            ooCommand.Parameters.Add("amount", OleDbType.Integer, 100)
            ooCommand.Parameters.Add("invoice_date", OleDbType.VarChar, 20)


            ooCommand.Parameters("booking_id").Value = CInt(InvoiceData("booking_id"))
            ooCommand.Parameters("amount").Value = CInt(InvoiceData("amount"))
            ooCommand.Parameters("invoice_date").Value = CStr(InvoiceData("invoice_date"))

            ooCommand.Prepare()
            Debug.Print("SQL:" & ooCommand.CommandText)
            ooCommand.ExecuteNonQuery()
            MsgBox("Data is imported")

        Catch ex As Exception
            MsgBox("data input fail")
        End Try
    End Sub

    'Findall
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
                htTempData("invoice_date") = CDate(oDataReader("invoice_date"))
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

    Public Function InvoiceFindByID(ByRef sId As String) As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM invoice WHERE booking_id = ?;"
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 10)
            oCommand.Parameters("bookind_id").Value = CStr(sId)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CInt(oDataReader("booking_id"))
                htTempData("invoice_date") = CDate(oDataReader("invoice_date"))
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
