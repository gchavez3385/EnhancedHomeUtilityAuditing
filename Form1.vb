'Imports System.Windows.Forms
'Imports System.IO

Public Class Gregory_Chavez_Enhanced_Home_Utility_Auditing_Program

    Public SelectedItem As String

    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectAppliance.SelectedIndexChanged

        Dim SelectedItem As String = ""
        Dim None As String = "None"
        Dim AirConditioner As String = "Air Conditioner"
        Dim ClothesDryer As String = "Clothes Dryer"
        Dim ClothesWasher As String = "Clothes Washer"
        Dim Dishwasher As String = "Dishwasher"
        Dim ElectricOven As String = "Electric Oven"
        Dim MicrowaveOven As String = "Microwave Oven"
        Dim Refridgerator As String = "Refridgerator"
        Dim WaterHeater As String = "WaterHeater"

        Select Case cboSelectAppliance.SelectedItem.ToString
            Case "None"
                SelectedItem = None
            Case "Air Conditioner"
                SelectedItem = AirConditioner
            Case "Clothes Dryer"
                SelectedItem = ClothesDryer
            Case "Clothes Washer"
                SelectedItem = ClothesWasher
            Case "Dishwasher"
                SelectedItem = Dishwasher
            Case "Electric Oven"
                SelectedItem = ElectricOven
            Case "Microwave Oven"
                SelectedItem = MicrowaveOven
            Case "Refridgerator"
                SelectedItem = Refridgerator
            Case "Water Heater"
                SelectedItem = WaterHeater

                'If SelectedItem = ClothesWasher, DishWasher, WaterHeater Then

                'End If

                If (cboSelectAppliance.SelectedItem Is "") Then

                    Console.WriteLine()
                    txtSelectedAppliance.Text = CType(cboSelectAppliance.SelectedItem, String)

                Else

                    txtSelectedAppliance.Text = cboSelectAppliance.SelectedItem.ToString()
                End If
        End Select
    End Sub

    Private Sub TextBoxInteger1_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerKWH.TextChanged
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub TextBoxInteger1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCostPerKWH.Validating
        e.Cancel = Not IsTextInteger1(CType(sender, TextBox))
    End Sub

    Private Function IsTextInteger1(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) Then
            Return True
        Else
            MessageBox.Show("Text entered must be an integer.")
            target.SelectAll()
            Return False
        End If
    End Function

    Private Sub TextBoxValue1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCostPerKWH.Validating
        e.Cancel = Not TextBoxValue1(CType(sender, TextBox))
    End Sub

    Private Function TextBoxValue1(target As TextBox) As Boolean
        Dim value1 As Integer = 0

        If Integer.TryParse(target.Text, value1) Then
            If value1 > 0 Then
                Return True
            Else
                MessageBox.Show("No Negative Numbers")
                target.SelectAll()
                Return False
            End If
        End If
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtApplianceKWH.TextChanged
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApplianceKWH.Validating
        e.Cancel = Not IsTextInteger2(CType(sender, TextBox))
    End Sub

    Private Function IsTextInteger2(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) Then
            Return True
        Else
            MessageBox.Show("Text entered must be an integer.")
            target.SelectAll()
            Return False
        End If
    End Function

    Private Sub TextBoxValue2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApplianceKWH.Validating
        e.Cancel = Not TextBoxValue2(CType(sender, TextBox))
    End Sub

    Private Function TextBoxValue2(target As TextBox) As Boolean
        Dim value2 As Integer = 0

        If Integer.TryParse(target.Text, value2) Then
            If value2 > 0 Then
                Return True
            Else
                MessageBox.Show("No Negative Numbers")
                target.SelectAll()
                Return False
            End If
        End If
    End Function

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtHoursPerDay.TextChanged
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoursPerDay.Validating
        e.Cancel = Not IsTextInteger3(CType(sender, TextBox))
    End Sub

    Private Function IsTextInteger3(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) Then
            Return True
        Else
            MessageBox.Show("Text entered must be an integer.")
            target.SelectAll()
            Return False
        End If
    End Function

    Private Sub TextBoxValue3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoursPerDay.Validating
        e.Cancel = Not TextBoxValue3(CType(sender, TextBox))
    End Sub

    Private Function TextBoxValue3(target As TextBox) As Boolean
        Dim Value3 As Integer = 0
        If Integer.TryParse(target.Text, Value3) Then
            If Value3 > 0 Then
                Return True
            Else
                MessageBox.Show("No Negative Numbers")
                target.SelectAll()
                Return False
            End If
        End If
    End Function

    Private Sub TextBoxTimeFrame3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoursPerDay.Validating
        e.Cancel = Not TextBoxTimeFrame3(CType(sender, TextBox))
    End Sub

    Private Function TextBoxTimeFrame3(target As TextBox) As Boolean
        Dim Value3 As Integer = 0
        If Integer.TryParse(target.Text, Value3) Then
            If Value3 > 1 Then
                If Value3 < 25 Then
                    'End If
                    Return True
                Else
                    MessageBox.Show("Enter an Integer between 1 and 24")
                    target.SelectAll()
                    Return False
                End If
            End If
        End If
    End Function

    Private Sub txtSelectedAppliance_TextChanged(sender As Object, e As EventArgs) Handles txtSelectedAppliance.TextChanged
        txtSelectedAppliance.Text = cboSelectAppliance.SelectedItem.ToString()
    End Sub

    Private Sub txtDailyCost_TextChanged(sender As Object, e As EventArgs) Handles txtDailyCost.TextChanged
        'Dim dblDailyCost As Double
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        Dim item As New ListViewItem(cboSelectAppliance.Text$)
        item.SubItems.Add(txtHoursPerDay.Text$)
        item.SubItems.Add(txtDailyCost.Text$)
        lstView.Items.Add(item)
        txtSelectedAppliance.Clear()
        txtHoursPerDay.Clear()
        txtDailyCost.Clear()
        txtCostPerKWH.Clear()
        txtApplianceKWH.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Application.Restart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class
