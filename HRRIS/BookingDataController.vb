Option Explicit On
Option Strict On

'Name: Data Import Controller
'Date:
'Author: Pham Duy Ly 

'Note: adding a  fucntion with calling ID and GROUP room type - writing on roomDataController - based on findsbyID 
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
            oConection.Close()
        Catch ex As Exception
            MsgBox("data input fail")
        End Try

    End Sub

    'ROOM SECTION
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
    'Done after fixing the database collum and type which relating to the Database 
    Public Function BookingsFindById(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        'Try
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



        'Catch ex As Exception
        '    Debug.Print("ERROR: " & ex.Message)
        '    MsgBox("an error occured. The record(s) could not be found")
        'Finally
        '    oConnection.Close()

        'End Try

        Return lsData
    End Function

    'CRUD room data 
    'room update
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

    'Generate report 
    '<summary
    'Generate report by Customer ID - Require: Booking Date & Last time booked
    '</summary>
    Public Sub createReport01()

        Debug.Print("Create Report ... ")

        Dim lsData = BookingfindALl()
        Dim sReportTitle = "Customer booking Report by ..."

        Dim sReportContent = generateCusReportId(lsData, sReportTitle)

        Dim sReportFilename = "CustomerReportbyID-01.html"


        saveCusReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

        'rm the code system.Diagnostics. 
    End Sub

    Private Function generateCusReportId(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateReport01 ...")

        Dim sReportCusIDContent As String

        '1.Generate the start of the HTML file

        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""eng"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportCusIDContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        '2.Generate the product table and its rows 
        Dim sTable = generateTable(lsData)
        sReportCusIDContent &= sTable & vbCrLf

        '3.Generate the end of the HTML file 
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportCusIDContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



        Return sReportCusIDContent

    End Function

    Private Sub saveCusReport(ByVal sReportCusIDContent As String, ByVal sReportfilename As String)
        Debug.Print("SaveReport: " & sReportfilename)

        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportfilename)

        'Check if the file is open before starting to write to it 

        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportCusIDContent)
            oReportFile.Close()
        End If
    End Sub
    'fucntion is to generate the CUS id table 
    Private Function generateTable(ByVal lsData As List(Of Hashtable)) As String
        'Generate the start of the table
        'vbCrLf = down a line and going to the left or feed or st
        Dim sTable = "<table border""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("Customer_id ")
        lsKeys.Add("booking_date")
        lsKeys.Add("checkin_date")




        ' Generate the header row
        Dim sHeadderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeadderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeadderRow)
        sTable &= sHeadderRow

        'Generate the table rows 
        For Each record In lsData
            Dim product As Hashtable = record
            Dim sTableRow = "<tr>" & vbCrLf

            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sTable &= sTableRow
        Next
        'Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function

End Class

