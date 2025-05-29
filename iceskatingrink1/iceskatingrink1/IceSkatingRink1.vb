' Program :Ice Skating Rink
' Author:City Hussen
'Date :7/03/2022
'Purpose:This application calculates and displays the total
'volume of Ice skating Rink for a given lenth,width and depth.

Option Strict On

Public Class windowIceSkatingRink1

    Private Sub btnFindVolume_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindVolume.Click
        'This event handler is executed when the user clicks the
        'Find volume button.It calculates and displays the total volume 
        'of the Ice skating rink(length*width*Depth).
        Dim strLength As String
        Dim strWidth As String
        Dim strDepth As String
        Dim decLength As Decimal
        Dim decWidth As Decimal
        Dim decDepth As Decimal
        Dim decTotalVolume As Decimal

        strLength = txtLength.Text
        strWidth = txtWidth.Text
        strDepth = txtDepth.Text
        decLength = Convert.ToDecimal(strLength)
        decWidth = Convert.ToDecimal(strWidth)
        decDepth = Convert.ToDecimal(strDepth)
        decTotalVolume = decLength * decWidth * decDepth
        lblTotalVolume.Text = decTotalVolume.ToString("G") + "ft^3"

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user clicks the
        'Clear button.It clears all the numbers entered and found

        txtLength.Clear()
        txtWidth.Clear()
        txtDepth.Clear()
        lblTotalVolume.Text = ""
        txtLength.Focus()
    End Sub

    Private Sub windowIceSkatingRink1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded.
        'It displays the Discription of the program,clears the values entered
        'and found then set the focus to txtlength Textbox object.

        txtLength.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        'Close the window and terminates the application
        Close()
    End Sub
End Class




