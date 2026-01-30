Imports System.Security.Cryptography
Imports System.Text

Public Class cripto
    'La EncryptionKey tiene que tener 32 digitos
    Private Shared ReadOnly EncryptionKey As Byte() = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1s5")
    Private Shared ReadOnly IV As Byte() = ASCIIEncoding.ASCII.GetBytes("1234567890123456")

    Public Function Encriptar(ByVal Input As String) As String
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Using aes As Aes = Aes.Create()
            aes.Key = EncryptionKey
            aes.IV = IV
            'aes.IV = "asdfghjko2u36sx092"
            aes.Mode = CipherMode.CBC
            aes.Padding = PaddingMode.PKCS7
            Using encryptor = aes.CreateEncryptor()
                Dim encryptedBytes() As Byte = encryptor.TransformFinalBlock(buffer, 0, buffer.Length)
                Return Convert.ToBase64String(encryptedBytes)
            End Using
        End Using
    End Function

    Public Function Desencriptar(ByVal input As String) As String
        Try
            Dim buffer() As Byte = Convert.FromBase64String(input)
            Using aes As Aes = Aes.Create()
                aes.Key = EncryptionKey
                aes.IV = IV
                aes.Mode = CipherMode.CBC
                aes.Padding = PaddingMode.PKCS7

                Using decrypter = aes.CreateDecryptor()
                    Dim decrypedBytes() As Byte = decrypter.TransformFinalBlock(buffer, 0, buffer.Length)
                    Return Encoding.UTF8.GetString(decrypedBytes)
                End Using
            End Using
        Catch ex As Exception
            Return "Error al Desencriptar: " & ex.Message
        End Try
    End Function

End Class
