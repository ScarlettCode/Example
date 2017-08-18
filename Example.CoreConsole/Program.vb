Imports System

Module Program
    Sub Main(args As String())

        Dim repo As New Data.Repo

        Try
            Console.WriteLine(repo.Get())
        Catch ex As Exception
            Console.WriteLine("Can't load" & vbCrLf & ex.Message)
        End Try

        Console.ReadLine()

    End Sub
End Module
