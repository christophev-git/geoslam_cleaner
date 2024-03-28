Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabdos As System.Collections.Generic.List(Of String) = New System.Collections.Generic.List(Of String)(System.IO.Directory.EnumerateDirectories("C:\Users\Agex_Videos\AppData\Local\geoslam-data"))
        Dim i As Integer = 0
        For Each s As String In tabdos
            s = tabdos(i)
            s = s.Split("\")(UBound(s.Split("\"), 1))
            If System.IO.File.Exists(tabdos(i) & "\results.laz") Then
                My.Computer.FileSystem.RenameFile(tabdos(i) & "\results.laz", s & ".laz")
            End If
            i = i + 1
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tabdos As System.Collections.Generic.List(Of String) = New System.Collections.Generic.List(Of String)(System.IO.Directory.EnumerateDirectories("C:\Users\Agex_Videos\AppData\Local\geoslam-data"))
        Dim i As Integer = 0
        For Each s As String In tabdos

            For Each foundfile In My.Computer.FileSystem.GetFiles(tabdos(i))

                If Not foundfile.EndsWith(".laz") Then
                    My.Computer.FileSystem.DeleteFile(foundfile)
                End If


            Next

            i = i + 1
        Next
    End Sub
End Class
