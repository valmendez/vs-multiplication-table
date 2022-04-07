Public Class frmprogram7
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'Multiplication for 10. Must loop at least once. Format with seperation.


        For i As Integer = 1 To 10
            lstBox.Items.Add(i & "  " & i * 2 & "  " & i * 3 & "  " & i * 4 & "  " & i * 5 & "  " & i * 6 & "  " & i * 7 & "  " & i * 8 & "  " & i * 9 & "  " & i * 10)

        Next


    End Sub
End Class
