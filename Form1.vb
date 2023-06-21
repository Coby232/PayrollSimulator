Public Class Form1

    Public TotalNumberOfPieces, TotalPay, PersonCount As Integer
    Public AveragePayPerPerson As Double
    Dim errProvider As New ErrorProvider

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MessageBox.Show("Total number of pieces:  " &
            TotalNumberOfPieces & vbNewLine & "Total pay: " & TotalPay & vbNewLine & "Average pay per person: " & AveragePayPerPerson, "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to exit", "Close", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Application.ExitThread()
        Else

        End If
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Try
            If (IsNumeric(NumPiecesTextBox.Text) And IsNumeric(WorkerNameTextBox.Text) <> True) And WorkerNameTextBox.Text <> "" Then
                'Declare Variables
                Dim NumberOfPiecesCompletedInteger, AmountEarned As Integer
                Const Between1and200 As Integer = 60
                Const Between201and400 As Integer = 65
                Const Between401and600 As Integer = 70
                Const MoreThan600 As Integer = 75


                'Assign Prices per pieces completed
                NumberOfPiecesCompletedInteger = Integer.Parse(NumPiecesTextBox.Text)
                If NumberOfPiecesCompletedInteger >= 1 And NumberOfPiecesCompletedInteger <= 200 Then
                    AmountEarned = Between1and200
                ElseIf NumberOfPiecesCompletedInteger >= 201 And NumberOfPiecesCompletedInteger <= 400 Then
                    AmountEarned = Between201and400
                ElseIf NumberOfPiecesCompletedInteger >= 401 And NumberOfPiecesCompletedInteger <= 600 Then
                    AmountEarned = Between401and600
                ElseIf NumberOfPiecesCompletedInteger > 600 Then
                    AmountEarned = MoreThan600
                End If

                'Summation
                TotalNumberOfPieces += NumberOfPiecesCompletedInteger
                PersonCount += 1
                TotalPay += AmountEarned
                AveragePayPerPerson = TotalPay / PersonCount
                'fill textboxes
                AmountEarnedTextBox.Text = AmountEarned.ToString("C2")
                EmployeeTextBox.Text = WorkerNameTextBox.Text
                PiecesTextBox.Text = NumPiecesTextBox.Text
            Else
                'Custom Error Handling
                If IsNumeric(WorkerNameTextBox.Text.Trim) = True Or String.IsNullOrEmpty(WorkerNameTextBox.Text.Trim) Then
                    errProvider.SetError(Me.WorkerNameTextBox, "Invalid Input")
                    WorkerNameTextBox.Focus()
                Else
                    errProvider.SetError(Me.WorkerNameTextBox, "")
                End If
                '
                If IsNumeric(NumPiecesTextBox.Text.Trim) = False Then
                    errProvider.SetError(Me.NumPiecesTextBox, "Invalid Input")
                    NumPiecesTextBox.Focus()
                Else
                    errProvider.SetError(Me.NumPiecesTextBox, "")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        WorkerNameTextBox.Clear()
        EmployeeTextBox.Clear()
        AmountEarnedTextBox.Clear()
        NumPiecesTextBox.Clear()
        PiecesTextBox.Clear()
    End Sub
End Class
