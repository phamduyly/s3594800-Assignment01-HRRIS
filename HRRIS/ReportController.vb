Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports System.IO


'Name: report generate 
'Date: 15/4/2017
'Author: Pham Duy Ly 


Public Class ReportController
    Public Const CONNECTION_STRING As String =
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRISdb.accdb"
#Region "SQL section"
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

    'Break report 
    'Break report 1
    'Find from booking bookingID and MOnth AND yEAR
    Public Function BreakReport1(ByVal iMonths As Integer, ByVal iYears As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "SELECT * FROM booking WHERE DatePart (""yyyy"", booking_date) = " & iYears & " AND DatePart(""m"", booking_date) = " & iMonths & ";"

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
    
    'Break reprot 2 
      Public Function BreakReport1(ByVal iMonths As Integer, ByVal iYears As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            oConnection.Open()
            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'date from invoice table 
            '" AND DatePart(""m"", date) = " & iMonths & 
            oCommand.CommandText = "SELECT * FROM invoice WHERE DatePart (""yyyy"", date) = " & iYears & ";"

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
#End Region

#Region "HTML section"

    'REPORT SECTION
    'Content generating section - HTML file 
    'Create report 1 - cusID 
    'Function used inside : 1.BookingsFindById, 2.generateReport (generateTable) 3.SaveReport 
    Public Sub createReport01(ByVal sCusId As String)
        'Note: by val sCusID is important becasue it dim the value which will be use for the function
        'which is very needed

        Debug.Print("Create Report ... ")

        Dim lsKeys As New List(Of String)
        lsKeys.Add("customer_id ")
        lsKeys.Add("booking_date")
        lsKeys.Add("num_days")

        Dim lsData = CusbyId(sCusId)
        Dim sReportTitle = "Customer booking Report by ..."

        Dim sReportContent = generateReport03(lsData, sReportTitle, lsKeys)

        Dim sReportFilename = "CustomerReportbyID-01.html"


        saveReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

        'rm the code system.Diagnostics. 
    End Sub

    Private Sub saveReport(ByVal sReportCusIDContent As String, ByVal sReportfilename As String)
        Debug.Print("SaveReport: " & sReportfilename)

        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportfilename)

        'Check if the file is open before starting to write to it 

        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportCusIDContent)
            oReportFile.Close()
        End If
    End Sub

    '2ND report "Create Report2 section

    'SELECT booking_date, total_price FROM booking WHERE room_id = ?; 
    'a.CreateReport02 fucntion
    Public Sub CreateReport02(ByVal sRoomId As String)

        Debug.Print("Create Room Booking Information Report")

        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)

        'Modify lskey value
        lsKeys.Add("room_id")
        lsKeys.Add("booking_date")
        lsKeys.Add("total_price")

        'modify dim 
        Dim lsData = SecondReport(sRoomId)
        Dim sReportTitle = "Room Booking Information Report"
        Dim sReportContent = generateReport03(lsData, sReportTitle, lsKeys)
        Dim sReportFileName = "RoomReport-01.html"
        'Stop modify

        saveReport(sReportContent, sReportFileName)


        'This part can be reuse cause it is unchangeable 
        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub

    '3RD report " report section 
    'a.CreateReport 
    Public Sub CreateReport03(ByVal sCusId As String, ByVal iMonths As Integer, ByVal iYears As Integer)
        Debug.Print("Create Room Booking Information Report")

        'modify dim 
        Dim lsKeys As New List(Of String)
        lsKeys.Add("room_id")

        Dim lsData = ThirdReport(sCusId, iMonths, iYears)
        Dim sReportTitle = "Customer Booking Report from month " & iMonths & " to year " & iYears & ""
        Dim sReportContent = generateReport03(lsData, sReportTitle, lsKeys)
        Dim sReportFileName = "Room booked by customer in given period"
        'Stop modify

        saveReport(sReportContent, sReportFileName)


        'This part can be reuse cause it is unchangeable 
        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub

    'Create report 4th - booking in given period
    Public Sub CreateReport04(ByVal iMonths As Integer, ByVal iYears As Integer)
        Debug.Print("Create Room Booking Information Report")

        'modify dim 
        Dim lsKeys As New List(Of String)
        'Modify lskey value
        lsKeys.Add("booking_id")
        lsKeys.Add("booking_date")
        lsKeys.Add("room_id")
        lsKeys.Add("customer_id")
        lsKeys.Add("num_days")
        lsKeys.Add("num_guests")
        lsKeys.Add("checkin_date")
        lsKeys.Add("total_price")
        lsKeys.Add("comments")



        Dim lsData = FourthReport(iMonths, iYears)
        Dim sReportTitle = "booking maded in given period, from month " & iMonths & " and year " & iYears & ""
        Dim sReportContent = generateReport03(lsData, sReportTitle, lsKeys)
        Dim sReportFileName = "Room booked by customer in given period"
        'Stop modify

        saveReport(sReportContent, sReportFileName)


        'This part can be reuse cause it is unchangeable 
        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub
    'Create report 5 
    Public Sub CreateReport05(ByVal iMonths As Integer, ByVal iYears As Integer)
        Debug.Print("Create Room Booking Information Report")

        'modify dim 
        Dim lsKeys As New List(Of String)
        'Modify lskey value
        lsKeys.Add("booking_id")
        lsKeys.Add("booking_date")
        lsKeys.Add("room_id")
        lsKeys.Add("customer_id")
        lsKeys.Add("num_days")
        lsKeys.Add("num_guests")
        lsKeys.Add("checkin_date")
        lsKeys.Add("total_price")
        lsKeys.Add("comments")



        Dim lsData = FifthReport(iMonths, iYears)
        Dim sReportTitle = "Customer who are late for month" & iMonths & " and year " & iYears & ""
        Dim sReportContent = generateReport03(lsData, sReportTitle, lsKeys)
        Dim sReportFileName = "Late checking customer"
        'Stop modify

        saveReport(sReportContent, sReportFileName)


        'This part can be reuse cause it is unchangeable 
        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub

    'Create report 6
    Public Sub CreateReport06(ByVal sRmId As String, ByVal iMonths As Integer, ByVal iYears As Integer)
        Debug.Print("report")

        'modify dim 
        Dim lsKeys As New List(Of String)
        'Modify lskey value
        lsKeys.Add("booking_id")
        lsKeys.Add("booking_date")
        lsKeys.Add("room_id")
        lsKeys.Add("customer_id")
        lsKeys.Add("num_days")
        lsKeys.Add("num_guests")
        lsKeys.Add("checkin_date")
        lsKeys.Add("total_price")
        lsKeys.Add("comments")



        Dim lsData = SixthReport(sRmId, iMonths, iYears)
        Dim sReportTitle = "Room booked frequency" & sRmId & " in months" & iMonths & " and year " & iYears & ""
        Dim sReportContent = generateReport03(lsData, sReportTitle, lsKeys)
        Dim sReportFileName = "Room booked by customer in given period"
        'Stop modify

        saveReport(sReportContent, sReportFileName)


        'This part can be reuse cause it is unchangeable 
        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub

    'GENERATE REPORT SECTION FOR THE REPORT ONLY - BREAK REPORT IS BELLOW THis

    Private Function generateReport03(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String, ByVal lsKeys As List(Of String)) As String

        Dim sReportContent As String

        '1.Generate the start of the HTML file

        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""eng"">"
        Dim sHeadTitle As String = "<head>" & vbCrLf &
            "<title>" & sReportTitle & "</title>" & vbCrLf &
        "<meta charset=""utf-8"">" & vbCrLf &
        "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">" & vbCrLf &
        "<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">" & vbCrLf &
        "<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>" & vbCrLf &
        "<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>" & vbCrLf &
        "</head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        '2.Generate the product table and its rows 
        Dim sTable = generateTable03(lsData, lsKeys)
        sReportContent &= sTable & vbCrLf

        '3.Generate the end of the HTML file 
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



        Return sReportContent

    End Function

    'c.Generating table 
    Private Function generateTable03(ByVal lsData As List(Of Hashtable), ByVal lsKeys As List(Of String)) As String
        'Generate the start of the table
        'vbCrLf = down a line and going to the left or feed or st
        Dim sTable = "<table class =""table table-hover"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys

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

    'BREAK REPORT:
    'Need to summary all the funciton needed in order to run this function 
    'Not modified yet

    Public Sub createBreakReport(ByVal iMonths As Integer, ByVal iYears As Integer)
        Debug.Print("CreatBreakReport...")

        'lskey part 

        Dim lsData = BreakReport1(iMonths, iYears)
        Dim sReportTitle = "First controll break report "
        Dim sReportContent = generateBreakReport(lsData, sReportTitle)
        'lsData is ... sReporttiltle is 
        Dim sReportFilename = "HRRIS First Control Break Report.html"
        saveReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub

    Private Function generateBreakReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        'This part seem like the code is going to take the value from 1.the lsDATA whihc was dimed before in the clas
        'and the sReportitle whihc is going to be printed in the things ]

        Debug.Print("GenerateBreakeReport ...")

        Dim sReportContent As String

        '1.Generate the start of the HTML file

        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""eng"">"
        Dim sHeadTitle As String = "<head>" & vbCrLf &
            "<title>" & sReportTitle & "</title>" & vbCrLf &
        "<meta charset=""utf-8"">" & vbCrLf &
        "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">" & vbCrLf &
        "<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">" & vbCrLf &
        "<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>" & vbCrLf &
        "<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>" & vbCrLf &
        "</head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        '2.Generate the product table and its rows 
        Dim sTable = generateControlBreakeTale(lsData)
        sReportContent &= sTable & vbCrLf


        '3.Generate the end of the HTML file 
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



        Return sReportContent

    End Function

    Private Function generateControlBreakeTale(ByVal lsData As List(Of Hashtable)) As String
        Dim sTable = "<table class =""table table-hover"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("booking_id")
        lsKeys.Add("booking_date")
        lsKeys.Add("room_id")
        lsKeys.Add("customer_id")
        lsKeys.Add("num_days")
        lsKeys.Add("num_guests")
        lsKeys.Add("checkin_date")
        lsKeys.Add("total_price")
        lsKeys.Add("comments")

        ' Generate the header row
        Dim sHeadderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeadderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeadderRow)
        sTable &= sHeadderRow

        'Generate the table rows 
        sTable &= generateTableRows(lsData, lsKeys)

        'Generate the end of the table 
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function


    Private Function generateTableRows(ByVal lsData As List(Of Hashtable), ByVal lsKeys As List(Of String)) As String

        '1.Instalisation 
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerCategory As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a product and set the current key
            Dim booking As Hashtable = record
            sCurrentControlField = CStr(booking("booking_id"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total booking in " & sPreviousControlField _
                        & " booking form: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerCategory = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(booking(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerCategory += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total Booking in " & iCountRecordsPerCategory _
                        & " booking in the given year is : " & sCurrentControlField _
                        & "</td></tr>" _
                        & vbCrLf


        sRows &= sTableRow

        Return sRows
    End Function
#End Region

#Region "2"

    Public Sub createBreakReport(ByVal iMonths As Integer, ByVal iYears As Integer)
        Debug.Print("CreatBreakReport...")

        'lskey part 

        Dim lsData = BreakReport1(iMonths, iYears)
        Dim sReportTitle = "First controll break report "
        Dim sReportContent = generateBreakReport(lsData, sReportTitle)
        'lsData is ... sReporttiltle is 
        Dim sReportFilename = "HRRIS First Control Break Report.html"
        saveReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub

    Private Function generateBreakReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        'This part seem like the code is going to take the value from 1.the lsDATA whihc was dimed before in the clas
        'and the sReportitle whihc is going to be printed in the things ]

        Debug.Print("GenerateBreakeReport ...")

        Dim sReportContent As String

        '1.Generate the start of the HTML file

        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""eng"">"
        Dim sHeadTitle As String = "<head>" & vbCrLf &
            "<title>" & sReportTitle & "</title>" & vbCrLf &
        "<meta charset=""utf-8"">" & vbCrLf &
        "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">" & vbCrLf &
        "<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">" & vbCrLf &
        "<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>" & vbCrLf &
        "<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>" & vbCrLf &
        "</head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        '2.Generate the product table and its rows 
        Dim sTable = generateControlBreakeTale(lsData)
        sReportContent &= sTable & vbCrLf


        '3.Generate the end of the HTML file 
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



        Return sReportContent

    End Function

    Private Function generateControlBreakeTale(ByVal lsData As List(Of Hashtable)) As String
        Dim sTable = "<table class =""table table-hover"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("booking_id")
        lsKeys.Add("date")
        lsKeys.Add("amount")


        ' Generate the header row
        Dim sHeadderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeadderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeadderRow)
        sTable &= sHeadderRow

        'Generate the table rows 
        sTable &= generateTableRows(lsData, lsKeys)

        'Generate the end of the table 
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function


    Private Function generateTableRows(ByVal lsData As List(Of Hashtable), ByVal lsKeys As List(Of String)) As String

        '1.Instalisation 
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerCategory As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a product and set the current key
            Dim booking As Hashtable = record
            sCurrentControlField = CStr(booking("booking_id"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                    & " Total invoice in " & sPreviousControlField _
                        & " booking form: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerCategory = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
'The part for each break record 
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
sTableRow &= "<td>" & ""'month(name(month(cdate(invoice)))) '"" & "</td>" & vbCrLf
'Cstr(invoice(date))
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerCategory += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total Booking in " & iCountRecordsPerCategory _
                        & " booking in the given year is : " & sCurrentControlField _
                        & "</td></tr>" _
                        & vbCrLf


        sRows &= sTableRow

        Return sRows
    End Function

#End Region 

End Class
