Public Class RoomRate
    'Application figures hotel cusomer bill based on rate of room nights stayed. Misc. charges are also
    'calculated and figured into the bill. Tax due is calculated and the customers Grand total is displayed.
    'Application uses varibales and constants to do math based on user input.
    'Last updated: 2/12/19
    'By: Brian Nicewander

    Private Sub RoomRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads the current date and time onto the form when the application is launched
        lblLiveDate.Text = Now.ToString("D")
        lblLiveTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets the application for a new bill to be figured. Resets Date/Time. Clears input.
        'This button does not clear variables, it only obfuscates their values until new calculations are made.

        'Resets Date/Time
        lblLiveDate.Text = Now.ToString("D")
        lblLiveTime.Text = Now.ToString("T")

        'Reset Input
        txtRate.Text = String.Empty
        txtNights.Text = String.Empty
        txtPhone.Text = String.Empty
        txtService.Text = String.Empty
        txtTV.Text = String.Empty

        'Set output values for next use
        lblLodgeTotal.Text = "Room Rate:"
        lblMiscTotal.Text = "Misc Total:"
        lblSub.Text = "Sub Total:"
        lblTaxTotal.Text = "Tax Total:"
        lblGrand.Text = "Grand Total:"

        'Set focus on Nights textbox
        txtNights.Focus()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'Figures charges based on user input and isplays output in labels.

        'Declare Variables and Constants for calculations
        Dim intNight As Integer
        Dim decRate As Decimal
        Dim decService As Decimal
        Dim decPhone As Decimal
        Dim decTv As Decimal
        Dim decRoomTotal As Decimal
        Dim decMiscTotal As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decGrandtotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        'Begin Calculations
        Try
            'Convert Room Information
            intNight = CInt(txtNights.Text)
            decRate = CDec(txtRate.Text)
            If CInt(txtNights.Text) < 1 Then
                MessageBox.Show("Not enough nights")
                Exit Sub

            End If
            'Calculate Room Charges
            decRoomTotal = intNight * decRate

            'Convert Misc Charges
            decService = CDec(txtService.Text)
            decPhone = CDec(txtPhone.Text)
            decTv = CDec(txtTV.Text)

            'Calculate additional charges
            decMiscTotal = decService + decPhone + decTv

            'Calculate Subtotal Information
            decSubtotal = decRoomTotal + decMiscTotal

            'Calculate Tax
            decTax = decSubtotal * decTAX_RATE

            'Calculate Grandtotal
            decGrandtotal = decSubtotal + decTax

            'Format Output
            lblLodgeTotal.Text = "Room Rate: " + decRoomTotal.ToString("C")
            lblMiscTotal.Text = "Misc Total: " + decMiscTotal.ToString("C")
            lblSub.Text = "Sub Total: " + decSubtotal.ToString("C")
            lblTaxTotal.Text = "Tax Total: " + decTax.ToString("C")
            lblGrand.Text = "Grand Total: " + decGrandtotal.ToString("C")

        Catch ex As Exception
            'Display a message to the user to use correct input
            MessageBox.Show("All input must be numeric, nights stayed must be whole numbers")
            txtRate.Focus()
        End Try
    End Sub
End Class
