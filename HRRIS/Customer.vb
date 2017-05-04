Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports System.IO

'Name:Customer form
'Date: 11 March 2017
'Authors: Ly Pham Duy - s3594800 RMIT VN 


Public Class Customer

    'moving between record section
    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer
    Dim tootipBookg As New ToolTip


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRRISdbDataSet1.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.HRRISdbDataSet1.customer)

        Dim tootipBookg As New ToolTip
        'Input fields part 
        tootipBookg.SetToolTip(txtCusID, "Input ID to perform program function")
        tootipBookg.SetToolTip(txtCusTitl, "Choose title here")
        tootipBookg.SetToolTip(txtGender, "Choose customer gender here")
        tootipBookg.SetToolTip(txtCusFirName, "Input customer first name")
        tootipBookg.SetToolTip(txtCusLasName, "Input customer last name")
        tootipBookg.SetToolTip(txtCusPhone, "Input customer phone number")
        tootipBookg.SetToolTip(txtCusAdd, "Input customer address")
        tootipBookg.SetToolTip(txtCusEmail, "Input customer email")
        tootipBookg.SetToolTip(txtCusDOB, "Input customer date of birth")

        'Button part 
        tootipBookg.SetToolTip(btnFirst, "Click New to input new record")
        tootipBookg.SetToolTip(btnDelete, "Input booking ID to delete record")
        tootipBookg.SetToolTip(btnFind, "Input ID to booking ID to find record")

        tootipBookg.SetToolTip(btnFirst, "Navigation")
        tootipBookg.SetToolTip(btnNext, "Navigation")
        tootipBookg.SetToolTip(btnPrevious, "Navigation")
        tootipBookg.SetToolTip(btnLast, "Navigation")
        'Implemeting tooltip for the Customer form 
        Dim tooltip1 As New ToolTip

        displayNmove()
        'For disslay first record and moving between record
    End Sub

    'Display the very first record in the database and moving bewtween record
    Private Sub displayNmove()

        Dim MoveRecord As CustomerDataController = New CustomerDataController
        lsData = MoveRecord.CusfindALl()

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

    End Sub

    'btnInsert and validate data: Valiate data stage - trying using menu 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bIsValid = CusValid()

        If bIsValid Then
            'After the validation function return that all of the input fieds are valid to input, theen the code precive to this part which 
            'Add all the data into the hashtable inorder to import the data into the database 

            Dim CusData As Hashtable = New Hashtable

            CusData("title") = txtCusTitl.Text
            CusData("gender") = txtGender.Text
            CusData("firstname") = txtCusFirName.Text
            CusData("lastname") = txtCusLasName.Text
            CusData("phone") = txtCusPhone.Text
            CusData("address") = txtCusAdd.Text
            CusData("email") = txtCusEmail.Text
            CusData("dob") = txtCusDOB.Text

            'Select case allow to choose whether you want to import the data into the database by choosing yes or no 
            Select Case MsgBox("Ready to be added to the database ?", MsgBoxStyle.YesNo, "Insert")
                Case MsgBoxResult.Yes
                    'If the user choose YES, the customer data controller then is dimed under the name of cusimport. 
                    'After that , we call the CusInsert function in customerdatacontroller class and import the Cusdata hastable
                    Dim Cusimport As CustomerDataController = New CustomerDataController
                    Cusimport.CusInsert(CusData)

                    'then the msgbox appear 
                    'Bellow code allow the Datagrid view to refresh
                    Me.CustomerTableAdapter.Fill(Me.HRRISdbDataSet1.customer)
                Case MsgBoxResult.No
                    'The choose no, the result is the data is not inserted and the msgbox is appear. 
                    MsgBox("The record was not inserted")
            End Select
        End If



    End Sub

    'VAlidation
    Private Function CusValid() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

        bIsValid = oValidation.IsNameRight(txtCusFirName.Text) And txtCusFirName.TextLength < 20
        If bIsValid Then
            PicFName.Visible = False
        Else
            tootipBookg.SetToolTip(txtCusFirName, "First Letter have to be capital")
            PicFName.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.IsNameRight(txtCusLasName.Text) And txtCusLasName.TextLength < 20
        If bIsValid Then
            PicLName.Visible = False
        Else
            tootipBookg.SetToolTip(txtCusLasName, "First Letter have to be capital")
            PicLName.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isPhoneVal(txtCusPhone.Text) And txtCusPhone.TextLength < 11
        If bIsValid Then
            PicPhone.Visible = False

        Else
            tootipBookg.SetToolTip(txtCusPhone, "Missing Zero at the begining")
            PicPhone.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAddressRight(txtCusAdd.Text)
        If bIsValid Then
            PicAddr.Visible = False
        Else
            tootipBookg.SetToolTip(txtCusAdd, "Address format wrong")
            PicAddr.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isEmailAdress(txtCusEmail.Text)
        If bIsValid Then
            PicEmal.Visible = False
        Else
            tootipBookg.SetToolTip(txtCusEmail, "Email Format wrong")
            PicEmal.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsDate(txtCusDOB.Text)
        If bIsValid Then
            PicDOB.Visible = False
        Else
            PicDOB.Visible = True
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then

        Else
            MsgBox("Unable to add data where Error pop up appears due to reason bellow:" & vbCrLf & "1.Out of range" & vbCrLf & "2.Wrong format" & vbCrLf & "Point to where popup appear to see the error")
        End If


        Return bAllFieldsValid = True
        'this allow the fucntion to not add the inputed data into the database 


    End Function
#Region "CRUD"

    'CRUD
    'Moving between records
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))

    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try

            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsData.Item(iIndex)
            populateCusFields(lsData.Item(iIndex))

        Catch ex As Exception
            MsgBox("End of record")
        End Try


    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Try

            Dim htData As Hashtable
            Dim iIndex As Integer
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            htData = lsData.Item(iIndex)
            populateCusFields(lsData.Item(iIndex))

        Catch ex As Exception
            MsgBox("Very first record")
        End Try

    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click

        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = lsData.Count - 1
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)
        populateCusFields(lsData.Item(iIndex))



    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim oController As CustomerDataController = New CustomerDataController
        Dim sId = txtCusID.Text

        'User choose yes no the the delete record 
        Select Case MsgBox("Are you sure to delete this record", MsgBoxStyle.YesNo, "delete")
            'if choose yes, the outcome will be bellow 
            Case MsgBoxResult.Yes
                Dim iNumRows = oController.CustsDelete(sId)
                If iNumRows = 1 Then
                    clearForm()
                    MsgBox("The record was delete")
                End If
                Me.CustomerTableAdapter.Fill(Me.HRRISdbDataSet1.customer)
                ' if choose no, the outcome will be below 
            Case MsgBoxResult.No
                MsgBox("The record was not delete")
        End Select



    End Sub

    Private Sub clearForm()
        txtCusID.Clear()
        txtCusTitl.ResetText()
        txtGender.ResetText()
        txtCusFirName.Clear()
        txtCusLasName.Clear()
        txtCusPhone.Clear()
        txtCusAdd.Clear()
        txtCusEmail.Clear()

    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        Dim bIsValid As Boolean
        bIsValid = IsNumeric(txtCusID.Text)

        If bIsValid Then
            Dim oControler As CustomerDataController = New CustomerDataController
            Dim sId = txtCusID.Text
            Dim lsData = oControler.CusFindById(sId)
            If lsData.Count = 1 Then
                populateCusFields(lsData.Item(0))

            Else
                Debug.Print("no record were found")

            End If
        End If


    End Sub

    Private Sub populateCusFields(ByRef CusData As Hashtable)
        txtCusID.Text = CStr(CInt(CusData("customer_id")))
        txtCusTitl.Text = CStr(CusData("title"))
        txtGender.Text = CStr(CusData("gender"))
        txtCusFirName.Text = CStr(CusData("firstname"))
        txtCusLasName.Text = CStr(CusData("lastname"))
        txtCusPhone.Text = CStr(CusData("phone"))
        txtCusAdd.Text = CStr(CusData("address"))
        txtCusEmail.Text = CStr(CusData("email"))
        txtCusDOB.Text = CStr(CDate(CusData("dob")))

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Dim bIsValid = CusValid()

        Select Case MsgBox("Are you sure to Update this record", MsgBoxStyle.YesNo, "Update")
            Case MsgBoxResult.Yes

                If bIsValid Then
                    Dim oController As CustomerDataController = New CustomerDataController
                    Dim iNumRows = oController.CustsUpdate(getCusData)

                    If iNumRows = 1 Then
                        Debug.Print("The record was updated")
                    End If
                    Me.CustomerTableAdapter.Fill(Me.HRRISdbDataSet1.customer)

                End If
            Case MsgBoxResult.No
                MsgBox("The record was not Updated")
        End Select

    End Sub

    Private Function getCusData() As Hashtable
        Dim CusData As Hashtable = New Hashtable

        CusData("title") = txtCusTitl.Text
        CusData("gender") = txtGender.Text
        CusData("firstname") = txtCusFirName.Text
        CusData("lastname") = txtCusLasName.Text
        CusData("phone") = txtCusPhone.Text
        CusData("address") = txtCusAdd.Text
        CusData("email") = txtCusEmail.Text
        CusData("dob") = txtCusDOB.Text
        CusData("customer_id") = txtCusID.Text

        Return CusData

    End Function
#End Region


#Region "menu"
    'menu section : File part - New, Navigation between form, Exit

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'in order to set a new and fresh to import new data . TxtID will be clear and disable and the form will also be clear as well.

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        txtCusID.Clear()
        txtCusID.Enabled = False
        Button1.Visible = True
        btnDelete.Visible = False
        btnUpdate.Visible = False
        btnFind.Visible = False
        lstBox.Visible = False
        clearForm()



    End Sub
    '.hide and showdailog is for the able to close purpose 
    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click

        Dim room1 As New Room
        Me.Hide()
        room1.ShowDialog()
        Me.Close()

    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click

        Dim booking1 As New Booking
        Me.Hide()
        booking1.ShowDialog()
        Me.Close()

    End Sub
    'Menu: EDIT part
    'This allow the user to access all EDIT function of the program. Morever, turn on the ehance feature of lstBox which alow to 
    'Show all the customer with the finding need on to the listbox. 
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        txtCusID.Enabled = True
        btnDelete.Visible = True
        btnUpdate.Visible = True
        btnFind.Visible = True
        lstBox.Visible = True
        Button1.Visible = False
        displayNmove()
        'displayNmove is for sub display and move which also beused in form_load
    End Sub

    'Help and about page part: - this part allow to open help and about HTML 
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'This part can be reuse cause it is unchangeable 
        Dim sAbout As String
        sAbout = "About.html "
        Dim sParam As String = """" & Application.StartupPath & "\" & sAbout & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)
    End Sub

    Private Sub HelpPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpPageToolStripMenuItem.Click
        'This part can be reuse cause it is unchangeable 
        Dim sHelp As String
        sHelp = "Help.html"
        Dim sParam As String = """" & Application.StartupPath & "\" & sHelp & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)
    End Sub

    Private Sub BreakReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BreakReportToolStripMenuItem.Click
        Dim brkre As New BreakReport
        Me.Hide()
        brkre.ShowDialog()
        Me.Close()

    End Sub

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        Dim re As New Report
        Me.Hide()
        re.ShowDialog()
        Me.Close()
    End Sub

#End Region


#Region "More about find"
    Private Sub txtCusFirName_Leave(sender As Object, e As EventArgs) Handles txtCusFirName.Leave

        If txtCusID.Text = Nothing Then

        Else
            Dim sFNAme As String = txtCusFirName.Text
            Dim lsDataFCus As List(Of Hashtable)
            Dim oController As New CustomerDataController
            lsDataFCus = oController.findCusByFirstName(sFNAme)

            If lsDataFCus.Count = 1 Then
                populateCusFields(lsDataFCus.Item(0))
                'this is for populate the data in to the fields if only the record found = 1 

            ElseIf lsDataFCus.Count > 1 Then
                'This is for showing the records to list bos only the list box if the record > 1

                lstBox.Items.Clear()
                Dim sFDetails As String
                For Each customer In lsDataFCus
                    sFDetails = CStr(customer("customer_id"))
                    sFDetails = sFDetails & " | " & CStr(customer("title"))
                    sFDetails = sFDetails & " | " & CStr(customer("gender"))
                    sFDetails = sFDetails & " | " & CStr(customer("firstname"))
                    sFDetails = sFDetails & " | " & CStr(customer("lastname"))
                    sFDetails = sFDetails & " | " & CStr(customer("phone"))
                    sFDetails = sFDetails & " | " & CStr(customer("address"))
                    sFDetails = sFDetails & " | " & CStr(customer("email"))
                    sFDetails = sFDetails & " | " & CDate(customer("dob"))

                    lstBox.Items.Add(sFDetails)
                Next
            Else
                'If there are no record found
                MsgBox("The record was not found", MsgBoxStyle.MsgBoxHelp, "Help")
            End If
        End If

    End Sub

    Private Sub txtCusLasName_Leave(sender As Object, e As EventArgs) Handles txtCusLasName.Leave
        If txtCusID.Text = Nothing Then
        Else
            Dim sLNAme As String = txtCusLasName.Text
            Dim lsDataLCus As List(Of Hashtable)
            Dim oController As New CustomerDataController
            lsDataLCus = oController.findCusByLastName(sLNAme)

            If lsDataLCus.Count = 1 Then
                populateCusFields(lsDataLCus.Item(0))
                'this is for populate the data in to the fields if only the record found = 1 

            ElseIf lsDataLCus.Count > 1 Then
                'This is for showing the records to list bos only the list box if the record > 1

                lstBox.Items.Clear()
                Dim sLDetails As String
                For Each customer In lsDataLCus
                    sLDetails = CStr(customer("customer_id"))
                    sLDetails = sLDetails & " | " & CStr(customer("title"))
                    sLDetails = sLDetails & " | " & CStr(customer("gender"))
                    sLDetails = sLDetails & " | " & CStr(customer("firstname"))
                    sLDetails = sLDetails & " | " & CStr(customer("lastname"))
                    sLDetails = sLDetails & " | " & CStr(customer("phone"))
                    sLDetails = sLDetails & " | " & CStr(customer("address"))
                    sLDetails = sLDetails & " | " & CStr(customer("email"))
                    sLDetails = sLDetails & " | " & CDate(customer("dob"))

                    lstBox.Items.Add(sLDetails)
                Next
            Else
                'If there are no record found
                MsgBox("The record was not found", MsgBoxStyle.MsgBoxHelp, "Help")
            End If
        End If

    End Sub

    Private Sub txtCusPhone_Leave(sender As Object, e As EventArgs) Handles txtCusPhone.Leave

        If txtCusID.Text = Nothing Then
        Else
            Dim sPhone As String = txtCusPhone.Text
            Dim lsDataPhone As List(Of Hashtable)
            Dim oController As New CustomerDataController
            lsDataPhone = oController.findCusByPhone(sPhone)

            If lsDataPhone.Count = 1 Then
                populateCusFields(lsDataPhone.Item(0))
                'this is for populate the data in to the fields if only the record found = 1 
            ElseIf lsDataPhone.Count > 1 Then
                'This is for showing the records to list bos only the list box if the record > 1
                lstBox.Items.Clear()
                Dim sPhoneDetails As String
                For Each customer In lsDataPhone
                    sPhoneDetails = CStr(customer("customer_id"))
                    sPhoneDetails = sPhoneDetails & " | " & CStr(customer("title"))
                    sPhoneDetails = sPhoneDetails & " | " & CStr(customer("gender"))
                    sPhoneDetails = sPhoneDetails & " | " & CStr(customer("firstname"))
                    sPhoneDetails = sPhoneDetails & " | " & CStr(customer("lastname"))
                    sPhoneDetails = sPhoneDetails & " | " & CStr(customer("phone"))
                    sPhoneDetails = sPhoneDetails & " | " & CStr(customer("address"))
                    sPhoneDetails = sPhoneDetails & " | " & CStr(customer("email"))
                    sPhoneDetails = sPhoneDetails & " | " & CDate(customer("dob"))

                    lstBox.Items.Add(sPhoneDetails)
                Next
            Else
                'If there are no record found
                MsgBox("The record was not found", MsgBoxStyle.MsgBoxHelp, "Help")
            End If
        End If

    End Sub

    Private Sub txtCusEmail_Leave(sender As Object, e As EventArgs) Handles txtCusEmail.Leave
        If txtCusID.Text = Nothing Then
        Else
            Dim sEmail As String = txtCusEmail.Text
            Dim lsDataCusE As List(Of Hashtable)
            Dim oController As New CustomerDataController
            lsDataCusE = oController.findCusByEmail(sEmail)

            If lsDataCusE.Count = 1 Then
                populateCusFields(lsDataCusE.Item(0))
                'this is for populate the data in to the fields if only the record found = 1 

            ElseIf lsDataCusE.Count > 1 Then
                'This is for showing the records to list bos only the list box if the record > 1
                lstBox.Items.Clear()
                Dim sEDetails As String
                For Each customer In lsDataCusE
                    sEDetails = CStr(customer("customer_id"))
                    sEDetails = sEDetails & " | " & CStr(customer("title"))
                    sEDetails = sEDetails & " | " & CStr(customer("gender"))
                    sEDetails = sEDetails & " | " & CStr(customer("firstname"))
                    sEDetails = sEDetails & " | " & CStr(customer("lastname"))
                    sEDetails = sEDetails & " | " & CStr(customer("phone"))
                    sEDetails = sEDetails & " | " & CStr(customer("address"))
                    sEDetails = sEDetails & " | " & CStr(customer("email"))
                    sEDetails = sEDetails & " | " & CDate(customer("dob"))

                    lstBox.Items.Add(sEDetails)
                Next
            Else
                'If there are no record found
                MsgBox("The record was not found", MsgBoxStyle.MsgBoxHelp, "Help")
            End If
        End If

    End Sub




#End Region

End Class
