Public Class SoftwareSales
    Private Sub CloseFormButton_Click(sender As Object, e As EventArgs) Handles CloseFormButton.Click
        Me.Close()
    End Sub

    Private Sub SoftwareSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yearlyLicenseRadioButton.Checked = True
    End Sub

    Private Sub ClearFormButton_Click(sender As Object, e As EventArgs) Handles ClearFormButton.Click
        levelThreeTechSupportCheckBox.Checked = False
        OnsiteTrainingCheckBox.Checked = False
        CloudBackupCheckBox.Checked = False
        yearlyLicenseRadioButton.Checked = True
        totalOptionalCostLabel.Text = String.Empty
        SoftwareCostLabel.Text = String.Empty

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Const YEARLY_LEASE_PRICE = 5000
        Const ONETIME_PURCHSE_PRICE = 20000
        Const LEVELTHREE_TECH_SUPPORT_PRICE = 3500
        Const ONSITE_TRAINING_PRICE = 2000
        Const CLOUD_BACKUP_PRICE = 300

        Dim optionalCostTotal As Integer = 0
        Dim softwareLicenseCostTotal As Integer

        If yearlyLicenseRadioButton.Checked Then
            softwareLicenseCostTotal = YEARLY_LEASE_PRICE
        ElseIf oneTimePurchaseRadioButton.Checked Then
            softwareLicenseCostTotal = ONETIME_PURCHSE_PRICE
        End If

        If levelThreeTechSupportCheckBox.Checked Then
            optionalCostTotal += LEVELTHREE_TECH_SUPPORT_PRICE
        End If
        If OnsiteTrainingCheckBox.Checked Then
            optionalCostTotal += ONSITE_TRAINING_PRICE
        End If
        If CloudBackupCheckBox.Checked Then
            optionalCostTotal += CLOUD_BACKUP_PRICE
        End If

        SoftwareCostLabel.Text = softwareLicenseCostTotal.ToString("n2")
        totalOptionalCostLabel.Text = optionalCostTotal.ToString("n2")
    End Sub
End Class
