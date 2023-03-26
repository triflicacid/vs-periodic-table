Public Class Form2
    Private Sub viewWiki_Click(sender As Object, e As EventArgs) Handles viewWiki.Click
        Dim element As String = Me.tmpElName.Text
        FormWiki.Show()
        FormWiki.WikiFrame.Navigate("https://en.wikipedia.org/wiki/" & element)
        FormWiki.Text = "Wikipedia - " & element
        FormWiki.TopMost = True
    End Sub
End Class