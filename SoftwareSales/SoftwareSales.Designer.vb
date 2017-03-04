<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoftwareSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.licensingOptionsGroup = New System.Windows.Forms.GroupBox()
        Me.OptionalFeaturesGroup = New System.Windows.Forms.GroupBox()
        Me.yearlyLicenseRadioButton = New System.Windows.Forms.RadioButton()
        Me.oneTimePurchaseRadioButton = New System.Windows.Forms.RadioButton()
        Me.levelThreeTechSupportCheckBox = New System.Windows.Forms.CheckBox()
        Me.OnsiteTrainingCheckBox = New System.Windows.Forms.CheckBox()
        Me.CloudBackupCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.licenseCostLabel = New System.Windows.Forms.Label()
        Me.optionalCostsLabel = New System.Windows.Forms.Label()
        Me.SoftwareCostLabel = New System.Windows.Forms.Label()
        Me.totalOptionalCostLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearFormButton = New System.Windows.Forms.Button()
        Me.CloseFormButton = New System.Windows.Forms.Button()
        Me.licensingOptionsGroup.SuspendLayout()
        Me.OptionalFeaturesGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'licensingOptionsGroup
        '
        Me.licensingOptionsGroup.BackColor = System.Drawing.SystemColors.ControlLight
        Me.licensingOptionsGroup.Controls.Add(Me.oneTimePurchaseRadioButton)
        Me.licensingOptionsGroup.Controls.Add(Me.yearlyLicenseRadioButton)
        Me.licensingOptionsGroup.Location = New System.Drawing.Point(28, 39)
        Me.licensingOptionsGroup.Name = "licensingOptionsGroup"
        Me.licensingOptionsGroup.Size = New System.Drawing.Size(275, 265)
        Me.licensingOptionsGroup.TabIndex = 0
        Me.licensingOptionsGroup.TabStop = False
        Me.licensingOptionsGroup.Text = "Licensing Options"
        '
        'OptionalFeaturesGroup
        '
        Me.OptionalFeaturesGroup.BackColor = System.Drawing.SystemColors.ControlLight
        Me.OptionalFeaturesGroup.Controls.Add(Me.CloudBackupCheckBox)
        Me.OptionalFeaturesGroup.Controls.Add(Me.OnsiteTrainingCheckBox)
        Me.OptionalFeaturesGroup.Controls.Add(Me.levelThreeTechSupportCheckBox)
        Me.OptionalFeaturesGroup.Location = New System.Drawing.Point(327, 39)
        Me.OptionalFeaturesGroup.Name = "OptionalFeaturesGroup"
        Me.OptionalFeaturesGroup.Size = New System.Drawing.Size(388, 265)
        Me.OptionalFeaturesGroup.TabIndex = 0
        Me.OptionalFeaturesGroup.TabStop = False
        Me.OptionalFeaturesGroup.Text = "Optional Features (yearly)"
        '
        'yearlyLicenseRadioButton
        '
        Me.yearlyLicenseRadioButton.AutoSize = True
        Me.yearlyLicenseRadioButton.Location = New System.Drawing.Point(27, 77)
        Me.yearlyLicenseRadioButton.Name = "yearlyLicenseRadioButton"
        Me.yearlyLicenseRadioButton.Size = New System.Drawing.Size(124, 24)
        Me.yearlyLicenseRadioButton.TabIndex = 0
        Me.yearlyLicenseRadioButton.TabStop = True
        Me.yearlyLicenseRadioButton.Text = "Yearly license"
        Me.yearlyLicenseRadioButton.UseVisualStyleBackColor = True
        '
        'oneTimePurchaseRadioButton
        '
        Me.oneTimePurchaseRadioButton.AutoSize = True
        Me.oneTimePurchaseRadioButton.Location = New System.Drawing.Point(27, 150)
        Me.oneTimePurchaseRadioButton.Name = "oneTimePurchaseRadioButton"
        Me.oneTimePurchaseRadioButton.Size = New System.Drawing.Size(167, 24)
        Me.oneTimePurchaseRadioButton.TabIndex = 1
        Me.oneTimePurchaseRadioButton.TabStop = True
        Me.oneTimePurchaseRadioButton.Text = "One-Time Purchase"
        Me.oneTimePurchaseRadioButton.UseVisualStyleBackColor = True
        '
        'levelThreeTechSupportCheckBox
        '
        Me.levelThreeTechSupportCheckBox.AutoSize = True
        Me.levelThreeTechSupportCheckBox.Location = New System.Drawing.Point(38, 41)
        Me.levelThreeTechSupportCheckBox.Name = "levelThreeTechSupportCheckBox"
        Me.levelThreeTechSupportCheckBox.Size = New System.Drawing.Size(211, 24)
        Me.levelThreeTechSupportCheckBox.TabIndex = 0
        Me.levelThreeTechSupportCheckBox.Text = "Level-3 Technical Support"
        Me.levelThreeTechSupportCheckBox.UseVisualStyleBackColor = True
        '
        'OnsiteTrainingCheckBox
        '
        Me.OnsiteTrainingCheckBox.AutoSize = True
        Me.OnsiteTrainingCheckBox.Location = New System.Drawing.Point(38, 112)
        Me.OnsiteTrainingCheckBox.Name = "OnsiteTrainingCheckBox"
        Me.OnsiteTrainingCheckBox.Size = New System.Drawing.Size(139, 24)
        Me.OnsiteTrainingCheckBox.TabIndex = 1
        Me.OnsiteTrainingCheckBox.Text = "On-site Training"
        Me.OnsiteTrainingCheckBox.UseVisualStyleBackColor = True
        '
        'CloudBackupCheckBox
        '
        Me.CloudBackupCheckBox.AutoSize = True
        Me.CloudBackupCheckBox.Location = New System.Drawing.Point(38, 189)
        Me.CloudBackupCheckBox.Name = "CloudBackupCheckBox"
        Me.CloudBackupCheckBox.Size = New System.Drawing.Size(127, 24)
        Me.CloudBackupCheckBox.TabIndex = 2
        Me.CloudBackupCheckBox.Text = "Cloud Backup"
        Me.CloudBackupCheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.totalOptionalCostLabel)
        Me.Panel1.Controls.Add(Me.SoftwareCostLabel)
        Me.Panel1.Controls.Add(Me.optionalCostsLabel)
        Me.Panel1.Controls.Add(Me.licenseCostLabel)
        Me.Panel1.Location = New System.Drawing.Point(139, 324)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 127)
        Me.Panel1.TabIndex = 1
        '
        'licenseCostLabel
        '
        Me.licenseCostLabel.AutoSize = True
        Me.licenseCostLabel.Location = New System.Drawing.Point(40, 25)
        Me.licenseCostLabel.Name = "licenseCostLabel"
        Me.licenseCostLabel.Size = New System.Drawing.Size(194, 20)
        Me.licenseCostLabel.TabIndex = 0
        Me.licenseCostLabel.Text = "Cost of software licensing:"
        '
        'optionalCostsLabel
        '
        Me.optionalCostsLabel.AutoSize = True
        Me.optionalCostsLabel.Location = New System.Drawing.Point(47, 68)
        Me.optionalCostsLabel.Name = "optionalCostsLabel"
        Me.optionalCostsLabel.Size = New System.Drawing.Size(187, 20)
        Me.optionalCostsLabel.TabIndex = 1
        Me.optionalCostsLabel.Text = "Cost of optional features:"
        '
        'SoftwareCostLabel
        '
        Me.SoftwareCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SoftwareCostLabel.Location = New System.Drawing.Point(296, 25)
        Me.SoftwareCostLabel.Name = "SoftwareCostLabel"
        Me.SoftwareCostLabel.Size = New System.Drawing.Size(115, 30)
        Me.SoftwareCostLabel.TabIndex = 2
        '
        'totalOptionalCostLabel
        '
        Me.totalOptionalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalOptionalCostLabel.Location = New System.Drawing.Point(296, 68)
        Me.totalOptionalCostLabel.Name = "totalOptionalCostLabel"
        Me.totalOptionalCostLabel.Size = New System.Drawing.Size(115, 30)
        Me.totalOptionalCostLabel.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(124, 477)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(148, 38)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearFormButton
        '
        Me.ClearFormButton.Location = New System.Drawing.Point(310, 477)
        Me.ClearFormButton.Name = "ClearFormButton"
        Me.ClearFormButton.Size = New System.Drawing.Size(117, 38)
        Me.ClearFormButton.TabIndex = 3
        Me.ClearFormButton.Text = "Clear"
        Me.ClearFormButton.UseVisualStyleBackColor = True
        '
        'CloseFormButton
        '
        Me.CloseFormButton.Location = New System.Drawing.Point(484, 477)
        Me.CloseFormButton.Name = "CloseFormButton"
        Me.CloseFormButton.Size = New System.Drawing.Size(111, 38)
        Me.CloseFormButton.TabIndex = 4
        Me.CloseFormButton.Text = "Close"
        Me.CloseFormButton.UseVisualStyleBackColor = True
        '
        'SoftwareSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(747, 554)
        Me.Controls.Add(Me.CloseFormButton)
        Me.Controls.Add(Me.ClearFormButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OptionalFeaturesGroup)
        Me.Controls.Add(Me.licensingOptionsGroup)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SoftwareSales"
        Me.Text = "Sofware Sales"
        Me.licensingOptionsGroup.ResumeLayout(False)
        Me.licensingOptionsGroup.PerformLayout()
        Me.OptionalFeaturesGroup.ResumeLayout(False)
        Me.OptionalFeaturesGroup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents licensingOptionsGroup As GroupBox
    Friend WithEvents OptionalFeaturesGroup As GroupBox
    Friend WithEvents oneTimePurchaseRadioButton As RadioButton
    Friend WithEvents yearlyLicenseRadioButton As RadioButton
    Friend WithEvents CloudBackupCheckBox As CheckBox
    Friend WithEvents OnsiteTrainingCheckBox As CheckBox
    Friend WithEvents levelThreeTechSupportCheckBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents totalOptionalCostLabel As Label
    Friend WithEvents SoftwareCostLabel As Label
    Friend WithEvents optionalCostsLabel As Label
    Friend WithEvents licenseCostLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearFormButton As Button
    Friend WithEvents CloseFormButton As Button
End Class
