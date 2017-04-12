Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

'description: class containing validation methods

Public Class Validation

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

    Public Function IsNameRight(ByRef strVal As String) As Boolean
        Dim pattern As Regex = New Regex("^[a-zA-Z ]*$")
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' is number right 
    ''' </summary>
    ''' <param name="strVal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isAddressRight(ByVal strVal As String) As Boolean
        'a public function to check strVal right or wrong
        Dim pattern As Regex = New Regex("^[a-zA-Z0-9 _.,]*$")
        'checking the string whether its contains only alphanumeric value
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' is phone right
    ''' </summary>
    ''' <param name="strVal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    Public Function isTitleVal(ByVal strVal As String) As Boolean
        'a public function to check strVal right or wrong
        Dim pattern As Regex = New Regex("^[0]+[0-9]*$")
        'checking the string whether its contains only alphanumeric value
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
End Class
