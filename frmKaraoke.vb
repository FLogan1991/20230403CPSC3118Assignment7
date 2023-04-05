Option Strict On

Public Class frmKaraoke
    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D
    Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub
    Private Function ValidateInput() As Boolean
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            intNumber = Convert.ToInt32(txtRentalTotal.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch Execption As FormatException
            'This catch clock detects leters, symbols, blank entries, etc
            MsgBox("Please enter a valid amount", , "Error")
        Catch Exception As OverflowException
            'This catchblock detect numbers that are out of scope
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch Exception As SystemException
            'This catches exceptions not caught in the earlier blocks
            MsgBox("Entry invalid. Please enter a valid number representing the number in your party", , "Error")
        End Try
        txtRentalTotal.Focus()
        txtRentalTotal.Clear()
        Return blnValid

    End Function
    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong

        Return decPassCost
    End Function
    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourlyRate

        Return decTicketCost
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears the form
        ClearForm()
    End Sub

    Private Sub ClearForm()
        'clears the form
        cbxSelection.SelectedIndex = -1
        lblSelected.Visible = False
        txtRentalTotal.Visible = False
        btnCost.Visible = False
        btnClear.Visible = False
        lblTotalCost.Visible = False
        txtRentalTotal.Clear()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        blnAmountIsValid = ValidateInput()
        If blnAmountIsValid = True Then
            'input is assigned to variable
            intValue = Convert.ToInt32(txtRentalTotal.Text)
            If cbxSelection.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)
            End If

            lblTotalCost.Visible = True
            lblTotalCost.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")
        End If

    End Sub

    Private Sub cbxSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelection.SelectedIndexChanged
        'checks index of combobox and then sets the text after setting the label makes label visible
        If cbxSelection.SelectedIndex = 0 Then
            lblSelected.Text = "Number of Karaoke Songs:"
            fnVisibility()
        ElseIf cbxSelection.SelectedIndex = 1 Then
            lblSelected.Text = "Hourly Rental of Karaoke Room:"
            fnVisibility()
        End If
    End Sub

    Private Sub fnVisibility()
        'makes labels visible then places focus on the textbox
        lblSelected.Visible = True
        txtRentalTotal.Visible = True
        btnClear.Visible = True
        btnCost.Visible = True
        'Place focus on the textbox
        txtRentalTotal.Focus()
    End Sub
End Class
