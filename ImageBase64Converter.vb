Imports System.IO

Public Class ImageBase64Converter
    Public Function ImgToB64(pbox As PictureBox) As String
        Dim ms As New MemoryStream()
        pbox.Image.Save(ms, pbox.Image.RawFormat)
        MessageBox.Show("Converted!")
        Return Convert.ToBase64String(ms.ToArray())
    End Function

    Public Function B64ToImg(str64 As String) As Image
        Dim img As Byte() = Convert.FromBase64String(str64)
        Dim ms As New MemoryStream(img)
        Return Image.FromStream(ms)
    End Function
End Class
