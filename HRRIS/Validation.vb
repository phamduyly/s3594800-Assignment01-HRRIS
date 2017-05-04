Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

'description: class containing validation methods

Public Class Validation
    'isAlphaNumericVal widely used in many form due to its only purpose is to check whether the input is alphanumeric or not. 
    Public Function isAlphaNumericVal(ByVal strVal As String) As Boolean
        'a public function to check strVal right or wrong
        Dim pattern As Regex = New Regex("^[a-zA-Z0-9 _]*$")
        'checking the string whether its contains only alphanumeric value
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
    'isEmailAdress to chekc the email address in customer form
    Public Function isEmailAdress(ByVal strVal As String) As Boolean
        Dim pattern As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        'regex for email address
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If

    End Function

    'regex for name
    'IsNameRight to check both firs name and last name - Requriement: first letter have to be capital 
    Public Function IsNameRight(ByRef strVal As String) As Boolean
        Dim pattern As Regex = New Regex("^[A-Z]+[A-Za-z' ]*$")
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
    'isAddressRight to check the address in customer form

    Public Function isAddressRight(ByVal strVal As String) As Boolean
        'a public function to check strVal right or wrong
        Dim pattern As Regex = New Regex("^[a-zA-Z0-9 _.,/]*$")
        'checking the string whether its contains only alphanumeric value
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    'IsPhoneVal is to validate the phone in custorm form 
    Public Function isPhoneVal(ByVal strVal As String) As Boolean
        'a public function to check strVal right or wrong
        Dim pattern As Regex = New Regex("^[0]+[0-9]*$")
        'checking the string whether its contains only alphanumeric value
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
    'IsNum mostly is for limit the number of customer in booking form. The number come from normal hotel persons/room 
    Public Function isNum(ByVal strVal As String) As Boolean
        'a public function to check strVal right or wrong
        Dim pattern As Regex = New Regex("^[1-5]*$")
        'checking the string whether its contains only alphanumeric value
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    ' This is for room ava only can choose yes or no
    Public Function IsRm(ByVal txtRmAva As String) As Boolean

        If txtRmAva = "Yes" Or txtRmAva = "No" Then
            Return True

        Else
            Return False
        End If

    End Function
    'Check room type 
    Public Function IsType(ByVal txtRmType As String) As Boolean

        If txtRmType = "Normal" Or txtRmType = "Economy" Or txtRmType = "Deluxe" Or txtRmType = "Luxury" Or txtRmType = "Diamond" Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
