Imports System.Security.Cryptography
Imports System.Text




Public Class ClassHash

    Public Shared Function Hash(ByVal input As String) As String
        If String.IsNullOrEmpty(input) Then
            Return String.Empty
        End If
        Dim md5 As New MD5CryptoServiceProvider()
        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input))
        Dim result As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(input))
        Return Convert.ToBase64String(result)

    End Function

End Class
