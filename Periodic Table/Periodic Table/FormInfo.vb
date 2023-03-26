Public Class FormInfo
    Public clickTimes As Integer = 0
    Private Sub viewIsotopes_Click(sender As Object, e As EventArgs) Handles viewIsotopes.Click, viewIsotopes2.Click
        If clickTimes >= 1 Then
            MsgBox("Unable to re-generate isotope table. Please reselect the element from the Periodic Table to generate the isotope table.", vbExclamation)
        Else
            FormIsotopes.Show()
            FormIsotopes.TopMost = True
            clickTimes = clickTimes + 1
        End If
    End Sub

    Private Sub viewWiki_Click(sender As Object, e As EventArgs) Handles viewWiki.Click
        Try
            FormWiki.Show()
            FormWiki.Text = "Information - " & tmpElName.Text
            FormWiki.WebBrowser1.Navigate("https://en.wikipedia.org/wiki/" & tmpElName.Text.ToString())
            FormWiki.TopMost = True
        Catch ex As Exception
            MsgBox("Unable to open Wikipedia page for '" & tmpElName.Text & "':" & vbCrLf & ex.Message, vbCritical)
        End Try
    End Sub
End Class