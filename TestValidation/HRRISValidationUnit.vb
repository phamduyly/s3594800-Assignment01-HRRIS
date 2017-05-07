Option Strict On
Option Explicit On

'Name: HRRIS Valdation unit testing 
'Date: 20/4/2017
'Author: Ly Pham Duy

Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports HRRIS.Validation


<TestClass()> Public Class TestValidation


    <TestMethod()> Public Sub TestAlphaIsNumericVal_01()
        Dim oValidation As New HRRIS.Validation
        Dim sAlphabet = "drrt"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphabet))
    End Sub

    <TestMethod()> Public Sub TestAlphaIsNumericVal_02()
        Dim oValidation As New HRRIS.Validation
        Dim sAlphabet = "d123rrt"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphabet))
    End Sub

    <TestMethod()> Public Sub TestIsAlphaNumericVal_03()
        Dim oValidation As New HRRIS.Validation
        Dim iAlphabet = 12345
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(iAlphabet.ToString))
    End Sub

    <TestMethod()> Public Sub TestAddress_01()
        Dim oValidation As New HRRIS.Validation
        Dim sAddress = "28, 43 str, Binh Tan Dist, HCM city"
        Assert.AreEqual(True, oValidation.isAddressRight(sAddress))
    End Sub

    <TestMethod()> Public Sub TestAddress_02()
        Dim oValidation As New HRRIS.Validation
        Dim sAddress = "29/12, Le Van Dong str, Dist 2, HCM"
        Assert.AreEqual(True, oValidation.isAddressRight(sAddress))
    End Sub

    <TestMethod()> Public Sub TestEmailAddress_01()
        Dim oValidation As New HRRIS.Validation
        Dim sEmail = "s3594800@rmit.edu.vn"
        Assert.AreEqual(True, oValidation.isEmailAdress(sEmail))
    End Sub

    <TestMethod()> Public Sub TestEmailAddress_02()
        Dim oValidation As New HRRIS.Validation
        Dim sEmail = "s3594800@rmit@edu.vn"
        Assert.AreEqual(True, oValidation.isEmailAdress(sEmail))
    End Sub


    <TestMethod()> Public Sub TestEmailAddress_03()
        Dim oValidation As New HRRIS.Validation
        Dim sEmail = "phamduyly1997@gmail.com"
        Assert.AreEqual(True, oValidation.isEmailAdress(sEmail))
    End Sub

    <TestMethod()> Public Sub TestEmailAddress_04()
        Dim oValidation As New HRRIS.Validation
        Dim sEmail = "f45ds6a46521231dsa1"
        Assert.AreEqual(False, oValidation.isEmailAdress(sEmail))
    End Sub

    <TestMethod()> Public Sub TestName_01()
        Dim oValidation As New HRRIS.Validation
        Dim sName = "Ly"
        Assert.AreEqual(True, oValidation.IsNameRight(sName))
    End Sub


    <TestMethod()> Public Sub TestName_02()
        Dim oValidation As New HRRIS.Validation
        Dim sName = "ly12"
        Assert.AreEqual(False, oValidation.IsNameRight(sName))
    End Sub

    <TestMethod()> Public Sub TestName_03()
        Dim oValidation As New HRRIS.Validation
        Dim sName = "PhamDuy"
        Assert.AreEqual(True, oValidation.IsNameRight(sName))
    End Sub

    <TestMethod()> Public Sub TestName_04()
        Dim oValidation As New HRRIS.Validation
        Dim sName = "David'"
        Assert.AreEqual(True, oValidation.IsNameRight(sName))
    End Sub

    <TestMethod()> Public Sub TestPhone_01()
        Dim oValidation As New HRRIS.Validation
        Dim sPhone = "01668166548"
        Assert.AreEqual(True, oValidation.isPhoneVal(sPhone))
    End Sub

    <TestMethod()> Public Sub TestPhone_02()
        Dim oValidation As New HRRIS.Validation
        Dim sPhone = "1668166548"
        Assert.AreEqual(False, oValidation.isPhoneVal(sPhone))
    End Sub
    <TestMethod()> Public Sub TestPhone_03()
        Dim oValidation As New HRRIS.Validation
        Dim sPhone = "01668166 548"
        Assert.AreEqual(False, oValidation.isPhoneVal(sPhone))
    End Sub
    <TestMethod()> Public Sub TestPhone_04()
        Dim oValidation As New HRRIS.Validation
        Dim sPhone = "01668166548a"
        Assert.AreEqual(False, oValidation.isPhoneVal(sPhone))
    End Sub
    <TestMethod()> Public Sub TestPhone_05()
        Dim oValidation As New HRRIS.Validation
        Dim sPhone = "16681665480"
        Assert.AreEqual(False, oValidation.isPhoneVal(sPhone))
    End Sub
    <TestMethod()> Public Sub TestPhone_06()
        Dim oValidation As New HRRIS.Validation
        Dim sPhone = "number"
        Assert.AreEqual(False, oValidation.isPhoneVal(sPhone))
    End Sub
    'Test type for only the part in the Room form because it is needed
    <TestMethod()> Public Sub TestType_01()
        Dim oValidation As New HRRIS.Validation
        Dim iNum = "Economy"
        Assert.AreEqual(True, oValidation.IsType(iNum))
    End Sub

    'Test month - can only be inputed with the 01-12 elese cannot be input
    <TestMethod()> Public Sub TestMonth_01()
        Dim oValidation As New HRRIS.Validation
        Dim iNum = "01"
        Assert.AreEqual(True, oValidation.IsMonth(iNum))
    End Sub

    <TestMethod()> Public Sub TestMonth_02()
        Dim oValidation As New HRRIS.Validation
        Dim iNum = "43"
        Assert.AreEqual(False, oValidation.IsMonth(iNum))
    End Sub


    'Year : can only be 4 character and in the range of 20..
    <TestMethod()> Public Sub TestYear_01()
        Dim oValidation As New HRRIS.Validation
        Dim iNum = "01"
        Assert.AreEqual(False, oValidation.IsYear(iNum))
    End Sub

    <TestMethod()> Public Sub TestYear_02()
        Dim oValidation As New HRRIS.Validation
        Dim iNum = "2013"
        Assert.AreEqual(True, oValidation.IsYear(iNum))
    End Sub

    <TestMethod()> Public Sub TestYear_03()
        Dim oValidation As New HRRIS.Validation
        Dim iNum = "3001"
        Assert.AreEqual(False, oValidation.IsYear(iNum))
    End Sub

    <TestMethod()> Public Sub TestYear_04()
        Dim oValidation As New HRRIS.Validation
        Dim iNum = "2033"
        Assert.AreEqual(True, oValidation.IsYear(iNum))
    End Sub


End Class