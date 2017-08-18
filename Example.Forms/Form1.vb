Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim repo As New Data.Repo
        Try
            MsgBox(repo.Get())
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try

    End Sub
End Class
