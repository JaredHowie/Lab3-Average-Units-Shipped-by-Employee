Public Class frmAverageUnitsShippedByEmployee
    Dim dayNumber As Integer = 1
    Dim unitsShipped(2, 6) As Integer
    Dim currentEmployee As Integer = 1
    Dim overallAverage As Double
    Private Sub frmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbDay.Text() = "Day " + dayNumber.ToString()
        For employee As Integer = 0 To 2

            For units As Integer = 0 To 6

                unitsShipped(employee, units) = -1

            Next units

        Next employee
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dayNumber = 1
        currentEmployee = 1
        overallAverage = 0.0
        lbAverageEmployeeOne.ResetText()
        lbAverageEmployeeTwo.ResetText()
        lbAverageEmployeeThree.ResetText()
        lbAveragePerDay.ResetText()
        lbDay.Text() = "Day " + dayNumber.ToString
        tbEmployeeOne.ResetText()
        tbEmployeeTwo.ResetText()
        tbEmployeeThree.ResetText()
        tbUnits.ResetText()

        tbUnits.SelectionStart = 0
        tbUnits.SelectionLength = tbUnits.Text.Length
        tbUnits.Select()
        For employee As Integer = 0 To 2

            For units As Integer = 0 To 6

                unitsShipped(employee, units) = -1

            Next units

        Next employee

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim input As String
        Dim validInput As Integer
        Dim employeeAverage As Double = 0.0


        input = tbUnits.Text()

        If (Integer.TryParse(input, validInput)) Then

            If (validInput >= 0 And validInput <= 1000) Then
                If (currentEmployee = 1) Then
                    For units As Integer = 0 To 6
                        If (unitsShipped(0, units) = -1) Then
                            unitsShipped(0, units) = validInput
                            tbEmployeeOne.Text() = tbEmployeeOne.Text() + vbNewLine + validInput.ToString()
                            dayNumber = dayNumber + 1
                            If (units = 6) Then
                                employeeAverage = Math.Round(averagePerEmployee(currentEmployee), 2)
                                overallAverage = overallAverage + employeeAverage
                                lbAverageEmployeeOne.Text() = "Average: " + employeeAverage.ToString
                                dayNumber = 1
                                lbDay.Text() = "Day " + dayNumber.ToString

                                currentEmployee = 2
                            Else
                                units = 6
                            End If
                        End If
                    Next units
                    If (dayNumber = 8) Then
                        dayNumber = 7
                        lbDay.Text() = "Day " + dayNumber.ToString
                    Else
                        lbDay.Text() = "Day " + dayNumber.ToString
                    End If
                    Exit Sub
                End If
                If (currentEmployee = 2) Then

                    For units As Integer = 0 To 6
                        If (unitsShipped(1, units) = -1) Then
                            unitsShipped(1, units) = validInput
                            tbEmployeeTwo.Text() = tbEmployeeTwo.Text() + vbNewLine + validInput.ToString()
                            dayNumber = dayNumber + 1
                            If (units = 6) Then
                                employeeAverage = Math.Round(averagePerEmployee(currentEmployee), 2)
                                overallAverage = overallAverage + employeeAverage
                                lbAverageEmployeeTwo.Text() = "Average: " + employeeAverage.ToString
                                currentEmployee = 3
                                dayNumber = 1
                                lbDay.Text() = "Day " + dayNumber.ToString
                                'calculate average of employee 2 here and display
                            Else
                                units = 6
                            End If
                        End If
                    Next units
                    If (dayNumber = 8) Then
                        dayNumber = 7
                        lbDay.Text() = "Day " + dayNumber.ToString
                    Else
                        lbDay.Text() = "Day " + dayNumber.ToString
                    End If

                    Exit Sub
                End If
                If (currentEmployee = 3) Then

                    For units As Integer = 0 To 6
                        If (unitsShipped(2, units) = -1) Then
                            unitsShipped(2, units) = validInput
                            tbEmployeeThree.Text() = tbEmployeeThree.Text() + vbNewLine + validInput.ToString()
                            dayNumber = dayNumber + 1
                            If (units = 6) Then
                                employeeAverage = Math.Round(averagePerEmployee(currentEmployee), 2)
                                overallAverage = overallAverage + employeeAverage
                                lbAverageEmployeeThree.Text() = "Average: " + employeeAverage.ToString
                                currentEmployee = 4

                                lbDay.Text() = "Day " + dayNumber.ToString

                                'calculate average of employee 3 here and display
                            Else
                                units = 6
                            End If
                        End If
                    Next units
                    If (dayNumber = 8) Then
                        dayNumber = 7
                        lbDay.Text() = "Day " + dayNumber.ToString
                    Else
                        lbDay.Text() = "Day " + dayNumber.ToString
                    End If

                    Exit Sub
                End If
                If (currentEmployee = 4) Then
                    overallAverage = overallAverage / 3
                    overallAverage = Math.Round(overallAverage, 2)
                    lbAveragePerDay.Text() = "Average per day: " + overallAverage.ToString
                End If
            Else
                MessageBox.Show("The number entered must be between 0 and 1000 inclusive!")
                tbUnits.SelectionStart = 0
                tbUnits.SelectionLength = tbUnits.Text.Length
                tbUnits.Select()
                dayNumber = dayNumber - 1
            End If

        Else
            MessageBox.Show("Please enter a whole number!")
            tbUnits.SelectionStart = 0
            tbUnits.SelectionLength = tbUnits.Text.Length
            tbUnits.Select()
            dayNumber = dayNumber - 1
        End If

        tbUnits.SelectionStart = 0
        tbUnits.SelectionLength = tbUnits.Text.Length
        tbUnits.Select()

    End Sub


    Function averagePerEmployee(ByVal employee) As Double
        Dim average As Double = 0.0
        For units As Integer = 0 To 6

            average = average + unitsShipped(employee - 1, units)

        Next units
        Return average / 7
    End Function
End Class
