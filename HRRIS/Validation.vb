Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

'description: class containing validation methods

Public Class Validation

    Public Function isNumericVal(ByVal strVal As String) As Boolean
        '•	isNumeric(ByVal strVal As String) is a Public Function (can be accessed from outside of Validation.vb, cannot be accessed from outside if it was declared Private).
        '•	It accepts a single parameter (strVal) which is defined as a String. Furthermore, this parameter is passed by value meaning that the function receives a copy of the variable and not the actual location of the variable. 
        ' thus, any changes that you make to strVal will not be reflected in the actual variable. If you wanted to be able to change the value of the strVal, then you should pass it by reference i.e. ByRef.
        '•	Finally, since we are dealing with a function here (a function returns a value, while a subroutine does not), we need to specify the type of the return value. This is done by the As Boolean keywords.

        Try
            Return isNumericVal(strVal)
        Catch ex As Exception
            Debug.Print("error:" & ex.Message)

            Return False
        End Try
    End Function

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

 
End Class
