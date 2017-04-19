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
    'Find for content section for the things 
    '1ST report generator function - CusID = ? ; find num_days, booking_date NOTE: cus_id, num_days still missing 
    Public Function CusbyId(ByVal sCusId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        'Try
        oConnection.Open()
        Debug.Print("Connection String: " & oConnection.ConnectionString)


        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection

        oCommand.CommandText = "SELECT num_days, booking_date FROM booking WHERE customer_id = ?;"

        oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
        oCommand.Parameters("customer_id").Value = CInt(sCusId)
        oCommand.Prepare()


        Dim oDataReader = oCommand.ExecuteReader()

        Dim htTempData As Hashtable

        Do While oDataReader.Read() = True
            htTempData = New Hashtable
            'since the SQL only retrive 3 value, try delete value that not in sql cmd
            'htTempData value = 0 (Wrong)
            'htTempData("customer_id") = CInt(CStr(oDataReader("customer_id")))
            'This have problem - clue: bc of data type - not figure out yet. When put it a side the report run smooth as f
            htTempData("num_days") = CInt(oDataReader("num_days"))
            htTempData("booking_date") = CDate(oDataReader("booking_date"))

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

    '2ND report generator function 
    'Still having problem wiht cus, roomID
    Public Function SecondReport(ByVal sRmId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        'Try
        oConnection.Open()
        Debug.Print("Connection String: " & oConnection.ConnectionString)
        'st wrong here

        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection

        oCommand.CommandText = "SELECT total_price, booking_date FROM booking WHERE room_id = ?;"
        'SELECT booking_date, total_price FROM booking WHERE room_id = ?; 

        'st wrong here
        'SQL cmd is red in F8 
        oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
        oCommand.Parameters("room_id").Value = CInt(sRmId)
        oCommand.Prepare()



        Dim oDataReader = oCommand.ExecuteReader()

        Dim htTempData As Hashtable

        Do While oDataReader.Read() = True
            htTempData = New Hashtable
            'since the SQL only retrive 3 value, try delete value that not in sql cmd
            'htTempData value = 0 (Wrong)
            'htTempData("") = CInt(CStr(oDataReader("customer_id")))
            'This have problem - clue: bc of data type - not figure out yet. When put it a side the report run smooth as f
            htTempData("total_price") = CInt(oDataReader("total_price"))
            htTempData("booking_date") = CDate(oDataReader("booking_date"))

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

    '3rd report generator function 
    'Select 1.CusId, Month, year = room ID information
    Public Function ThirdReport(ByVal sCusId As String, ByVal iMonths As Integer, ByVal iYears As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        'Try
        oConnection.Open()
        Debug.Print("Connection String: " & oConnection.ConnectionString)
        'st wrong here

        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection

        oCommand.CommandText = "SELECT  room_id FROM booking WHERE DatePart (""yyyy"", booking_date) = " & iYears & " And DatePart(""m"", booking_date) = " & iMonths & " And customer_id = ?;"
        'SELECT booking_date, total_price FROM booking WHERE room_id = ?; 

        'st wrong here
        'SQL cmd is red in F8 
        oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
        oCommand.Parameters("customer_id").Value = CInt(sCusId)
        oCommand.Prepare()



        Dim oDataReader = oCommand.ExecuteReader()

        Dim htTempData As Hashtable

        Do While oDataReader.Read() = True
            htTempData = New Hashtable
            'since the SQL only retrive 3 value, try delete value that not in sql cmd
            'htTempData value = 0 (Wrong)
            'htTempData("") = CInt(CStr(oDataReader("customer_id")))
            'This have problem - clue: bc of data type - not figure out yet. When put it a side the report run smooth as f
            htTempData("room_id") = CInt(oDataReader("room_id"))
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

    'Report 4th function


    'Report 5th function


    'Report 6th fucntion 


    'REPORT SECTION
    'Content generating section - HTML file 
    'Create report 1 - cusID 
    'Function used inside : 1.BookingsFindById, 2.generateReport (generateTable) 3.SaveReport 
    Public Sub createReport01(ByVal sCusId As String)
        'Note: by val sCusID is important becasue it dim the value which will be use for the function
        'which is very needed

        Debug.Print("Create Report ... ")

        Dim lsData = CusbyId(sCusId)
        Dim sReportTitle = "Customer booking Report by ..."

        Dim sReportContent = generateReport(lsData, sReportTitle)

        Dim sReportFilename = "CustomerReportbyID-01.html"


        saveReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

        'rm the code system.Diagnostics. 
    End Sub
    'function for HTML (un-reuseable)
    'Createting HTML FRAME ( have one relating line - generatetable)
    Private Function generateReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateReport01 ...")

        Dim sReportCusIDContent As String

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
    'Function for web only (reuseable)
    Private Sub saveReport(ByVal sReportCusIDContent As String, ByVal sReportfilename As String)
        Debug.Print("SaveReport: " & sReportfilename)

        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportfilename)

        'Check if the file is open before starting to write to it 

        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportCusIDContent)
            oReportFile.Close()
        End If
    End Sub
    'fucntion is to generate the table ( cannot be reuse
    'FOR CusId Report 
    Private Function generateTable(ByVal lsData As List(Of Hashtable)) As String
        'Generate the start of the table
        'vbCrLf = down a line and going to the left or feed or st
        Dim sTable = "<table class=""table table-hover"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'error here -  but its work last night, index is out of range
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("Customer_id ")
        lsKeys.Add("booking_date")
        lsKeys.Add("nums_days")




        ' Generate the header row
        Dim sHeadderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeadderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeadderRow)
        sTable &= sHeadderRow

        'Generate the table rows 
        'This part still has not been modified clearly
        'Need more researc
        For Each record In lsData
            Dim product As Hashtable = record
            Dim sCusRow = "<tr>" & vbCrLf

            For Each key In lsKeys
                sCusRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sCusRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sCusRow)
            sTable &= sCusRow
        Next
        'Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function


    '2ND report "Create Report2 section

    'SELECT booking_date, total_price FROM booking WHERE room_id = ?; 
    'a.CreateReport02 fucntion
    Public Sub CreateReport02(ByVal sRoomId As String)

        Debug.Print("Create Room Booking Information Report")

        'modify dim 
        Dim lsData = SecondReport(sRoomId)
        Dim sReportTitle = "Room Booking Information Report"
        Dim sReportContent = generateReport02(lsData, sReportTitle)
        Dim sReportFileName = "RoomReport-01.html"
        'Stop modify

        saveReport(sReportContent, sReportFileName)


        'This part can be reuse cause it is unchangeable 
        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub
    'b.Generating report
    Private Function generateReport02(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateReport02 ...")

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
        Dim sTable = generateTable02(lsData)
        sReportContent &= sTable & vbCrLf

        '3.Generate the end of the HTML file 
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



        Return sReportContent

    End Function

    'c.Generating table 
    Private Function generateTable02(ByVal lsData As List(Of Hashtable)) As String
        'Generate the start of the table
        'vbCrLf = down a line and going to the left or feed or st
        Dim sTable = "<table class =""table table-hover"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)

        'Modify lskey value
        lsKeys.Add("room_id")
        lsKeys.Add("booking_date")
        lsKeys.Add("total_price")



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


    '3RD report " report section 
    'a.CreateReport 
    Public Sub CreateReport03(ByVal sCusId As String, ByVal iMonths As Integer, ByVal iYears As Integer)
        Debug.Print("Create Room Booking Information Report")

        'modify dim 
        Dim lsKeys As List(Of String) = New List(Of String)

        'Modify lskey value
        lsKeys.Add("room_id")


        Dim lsData = ThirdReport(sCusId, iMonths, iYears)
        Dim sReportTitle = "Report 03"
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
    'b.Generating report
    Private Function generateReport03(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String, ByVal lsKeys As List(Of String)) As String
        Debug.Print("GenerateReport02 ...")

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



    '4Th report " Report section
    ''a.CreateReport 
    'Public Sub CreateReport03(ByVal sRoomId As String)

    '    Debug.Print("Create Room Booking Information Report")

    '    'modify dim 

    '    Dim lsData = ThirdReport(sRoomId)
    '    Dim sReportTitle = "Report 03"
    '    Dim sReportContent = generateReport03(lsData, sReportTitle)
    '    Dim sReportFileName = "RoomReport-01.html"
    '    'Stop modify

    '    saveReport(sReportContent, sReportFileName)


    '    'This part can be reuse cause it is unchangeable 
    '    Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
    '    ' the """"" can fix into the access to the file path
    '    Debug.Print("sParam: " & sParam)

    '    System.Diagnostics.Process.Start(sParam)

    'End Sub
    ''b.Generating report
    'Private Function generateReport03(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
    '    Debug.Print("GenerateReport02 ...")

    '    Dim sReportContent As String

    '    '1.Generate the start of the HTML file

    '    Dim sDoctype As String = "<!DOCTYPE html>"
    '    Dim sHtmlStartTag As String = "<html lang=""eng"">"
    '    Dim sHeadTitle As String = "<head>" & vbCrLf & _
    '        "<title>" & sReportTitle & "</title>" & vbCrLf & _
    '    "<meta charset=""utf-8"">" & vbCrLf & _
    '    "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">" & vbCrLf & _
    '    "<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">" & vbCrLf & _
    '    "<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>" & vbCrLf & _
    '    "<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>" & vbCrLf & _
    '    "</head>"
    '    Dim sBodyStartTag As String = "<body>"
    '    Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
    '    sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

    '    '2.Generate the product table and its rows 
    '    Dim sTable = generateTable03(lsData)
    '    sReportContent &= sTable & vbCrLf

    '    '3.Generate the end of the HTML file 
    '    Dim sBodyEndTag As String = "</body>"
    '    Dim sHTMLEndTag As String = "</html>"
    '    sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



    '    Return sReportContent

    'End Function

    ''c.Generating table 
    'Private Function generateTable03(ByVal lsData As List(Of Hashtable)) As String
    '    'Generate the start of the table
    '    'vbCrLf = down a line and going to the left or feed or st
    '    Dim sTable = "<table class =""table table-hover"">" & vbCrLf
    '    Dim htSample As Hashtable = lsData.Item(0)
    '    'Dim lsKeys = htSample.Keys
    '    Dim lsKeys As List(Of String) = New List(Of String)

    '    'Modify lskey value
    '    lsKeys.Add("room_id")
    '    lsKeys.Add("booking_date")
    '    lsKeys.Add("total_price")



    '    ' Generate the header row
    '    Dim sHeadderRow = "<tr>" & vbCrLf
    '    For Each key In lsKeys
    '        sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
    '    Next
    '    sHeadderRow &= "</tr>" & vbCrLf
    '    Debug.Print("sHeaderRow: " & sHeadderRow)
    '    sTable &= sHeadderRow

    '    'Generate the table rows 
    '    For Each record In lsData
    '        Dim product As Hashtable = record
    '        Dim sTableRow = "<tr>" & vbCrLf

    '        For Each key In lsKeys
    '            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
    '        Next
    '        sTableRow &= "</tr>" & vbCrLf
    '        Debug.Print("sTableRow: " & sTableRow)
    '        sTable &= sTableRow
    '    Next
    '    'Generate the end of the table
    '    sTable &= "</table>" & vbCrLf

    '    Return sTable
    'End Function




    '5Th report " report section

    ''a.CreateReport 
    'Public Sub CreateReport03(ByVal sRoomId As String)

    '    Debug.Print("Create Room Booking Information Report")

    '    'modify dim 

    '    Dim lsData = ThirdReport(sRoomId)
    '    Dim sReportTitle = "Report 03"
    '    Dim sReportContent = generateReport03(lsData, sReportTitle)
    '    Dim sReportFileName = "RoomReport-01.html"
    '    'Stop modify

    '    saveReport(sReportContent, sReportFileName)


    '    'This part can be reuse cause it is unchangeable 
    '    Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
    '    ' the """"" can fix into the access to the file path
    '    Debug.Print("sParam: " & sParam)

    '    System.Diagnostics.Process.Start(sParam)

    'End Sub
    ''b.Generating report
    'Private Function generateReport03(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
    '    Debug.Print("GenerateReport02 ...")

    '    Dim sReportContent As String

    '    '1.Generate the start of the HTML file

    '    Dim sDoctype As String = "<!DOCTYPE html>"
    '    Dim sHtmlStartTag As String = "<html lang=""eng"">"
    '    Dim sHeadTitle As String = "<head>" & vbCrLf & _
    '        "<title>" & sReportTitle & "</title>" & vbCrLf & _
    '    "<meta charset=""utf-8"">" & vbCrLf & _
    '    "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">" & vbCrLf & _
    '    "<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">" & vbCrLf & _
    '    "<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>" & vbCrLf & _
    '    "<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>" & vbCrLf & _
    '    "</head>"
    '    Dim sBodyStartTag As String = "<body>"
    '    Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
    '    sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

    '    '2.Generate the product table and its rows 
    '    Dim sTable = generateTable03(lsData)
    '    sReportContent &= sTable & vbCrLf

    '    '3.Generate the end of the HTML file 
    '    Dim sBodyEndTag As String = "</body>"
    '    Dim sHTMLEndTag As String = "</html>"
    '    sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



    '    Return sReportContent

    'End Function

    ''c.Generating table 
    'Private Function generateTable03(ByVal lsData As List(Of Hashtable)) As String
    '    'Generate the start of the table
    '    'vbCrLf = down a line and going to the left or feed or st
    '    Dim sTable = "<table class =""table table-hover"">" & vbCrLf
    '    Dim htSample As Hashtable = lsData.Item(0)
    '    'Dim lsKeys = htSample.Keys
    '    Dim lsKeys As List(Of String) = New List(Of String)

    '    'Modify lskey value
    '    lsKeys.Add("room_id")
    '    lsKeys.Add("booking_date")
    '    lsKeys.Add("total_price")



    '    ' Generate the header row
    '    Dim sHeadderRow = "<tr>" & vbCrLf
    '    For Each key In lsKeys
    '        sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
    '    Next
    '    sHeadderRow &= "</tr>" & vbCrLf
    '    Debug.Print("sHeaderRow: " & sHeadderRow)
    '    sTable &= sHeadderRow

    '    'Generate the table rows 
    '    For Each record In lsData
    '        Dim product As Hashtable = record
    '        Dim sTableRow = "<tr>" & vbCrLf

    '        For Each key In lsKeys
    '            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
    '        Next
    '        sTableRow &= "</tr>" & vbCrLf
    '        Debug.Print("sTableRow: " & sTableRow)
    '        sTable &= sTableRow
    '    Next
    '    'Generate the end of the table
    '    sTable &= "</table>" & vbCrLf

    '    Return sTable
    'End Function



    '6TH report " report section 


    ''a.CreateReport 
    'Public Sub CreateReport03(ByVal sRoomId As String)

    '    Debug.Print("Create Room Booking Information Report")

    '    'modify dim 

    '    Dim lsData = ThirdReport(sRoomId)
    '    Dim sReportTitle = "Report 03"
    '    Dim sReportContent = generateReport03(lsData, sReportTitle)
    '    Dim sReportFileName = "RoomReport-01.html"
    '    'Stop modify

    '    saveReport(sReportContent, sReportFileName)


    '    'This part can be reuse cause it is unchangeable 
    '    Dim sParam As String = """" & Application.StartupPath & "\" & sReportFileName & """"
    '    ' the """"" can fix into the access to the file path
    '    Debug.Print("sParam: " & sParam)

    '    System.Diagnostics.Process.Start(sParam)

    'End Sub
    ''b.Generating report
    'Private Function generateReport03(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
    '    Debug.Print("GenerateReport02 ...")

    '    Dim sReportContent As String

    '    '1.Generate the start of the HTML file

    '    Dim sDoctype As String = "<!DOCTYPE html>"
    '    Dim sHtmlStartTag As String = "<html lang=""eng"">"
    '    Dim sHeadTitle As String = "<head>" & vbCrLf & _
    '        "<title>" & sReportTitle & "</title>" & vbCrLf & _
    '    "<meta charset=""utf-8"">" & vbCrLf & _
    '    "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">" & vbCrLf & _
    '    "<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">" & vbCrLf & _
    '    "<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>" & vbCrLf & _
    '    "<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>" & vbCrLf & _
    '    "</head>"
    '    Dim sBodyStartTag As String = "<body>"
    '    Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
    '    sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

    '    '2.Generate the product table and its rows 
    '    Dim sTable = generateTable03(lsData)
    '    sReportContent &= sTable & vbCrLf

    '    '3.Generate the end of the HTML file 
    '    Dim sBodyEndTag As String = "</body>"
    '    Dim sHTMLEndTag As String = "</html>"
    '    sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



    '    Return sReportContent

    'End Function

    ''c.Generating table 
    'Private Function generateTable03(ByVal lsData As List(Of Hashtable)) As String
    '    'Generate the start of the table
    '    'vbCrLf = down a line and going to the left or feed or st
    '    Dim sTable = "<table class =""table table-hover"">" & vbCrLf
    '    Dim htSample As Hashtable = lsData.Item(0)
    '    'Dim lsKeys = htSample.Keys
    '    Dim lsKeys As List(Of String) = New List(Of String)

    '    'Modify lskey value
    '    lsKeys.Add("room_id")
    '    lsKeys.Add("booking_date")
    '    lsKeys.Add("total_price")



    '    ' Generate the header row
    '    Dim sHeadderRow = "<tr>" & vbCrLf
    '    For Each key In lsKeys
    '        sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
    '    Next
    '    sHeadderRow &= "</tr>" & vbCrLf
    '    Debug.Print("sHeaderRow: " & sHeadderRow)
    '    sTable &= sHeadderRow

    '    'Generate the table rows 
    '    For Each record In lsData
    '        Dim product As Hashtable = record
    '        Dim sTableRow = "<tr>" & vbCrLf

    '        For Each key In lsKeys
    '            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
    '        Next
    '        sTableRow &= "</tr>" & vbCrLf
    '        Debug.Print("sTableRow: " & sTableRow)
    '        sTable &= sTableRow
    '    Next
    '    'Generate the end of the table
    '    sTable &= "</table>" & vbCrLf

    '    Return sTable
    'End Function


    'sql in ass2 doc 

End Class
