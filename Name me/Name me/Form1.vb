Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Sai-Akuto")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 1000
            ListBox1.Items.Add("Sai-Akuto")
        Next i
    End Sub
End Class
