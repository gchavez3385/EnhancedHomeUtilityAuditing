<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gregory_Chavez_Enhanced_Home_Utility_Auditing_Program
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHoursPerDay = New System.Windows.Forms.Label()
        Me.lblApplianceKWH = New System.Windows.Forms.Label()
        Me.lblCostKWH = New System.Windows.Forms.Label()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.cboSelectAppliance = New System.Windows.Forms.ComboBox()
        Me.txtHoursPerDay = New System.Windows.Forms.TextBox()
        Me.txtApplianceKWH = New System.Windows.Forms.TextBox()
        Me.txtCostPerKWH = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDailyCost = New System.Windows.Forms.TextBox()
        Me.txtSelectedAppliance = New System.Windows.Forms.TextBox()
        Me.lblDailyCost = New System.Windows.Forms.Label()
        Me.lblSelectedAppliance = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.Appliance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HoursPerDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DailyCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddToList
        '
        Me.btnAddToList.Location = New System.Drawing.Point(228, 94)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToList.TabIndex = 5
        Me.btnAddToList.Text = "Add to List"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(228, 135)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHoursPerDay)
        Me.GroupBox1.Controls.Add(Me.lblApplianceKWH)
        Me.GroupBox1.Controls.Add(Me.lblCostKWH)
        Me.GroupBox1.Controls.Add(Me.lblAppliance)
        Me.GroupBox1.Controls.Add(Me.cboSelectAppliance)
        Me.GroupBox1.Controls.Add(Me.txtHoursPerDay)
        Me.GroupBox1.Controls.Add(Me.txtApplianceKWH)
        Me.GroupBox1.Controls.Add(Me.txtCostPerKWH)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblHoursPerDay
        '
        Me.lblHoursPerDay.AutoSize = True
        Me.lblHoursPerDay.Location = New System.Drawing.Point(6, 159)
        Me.lblHoursPerDay.Name = "lblHoursPerDay"
        Me.lblHoursPerDay.Size = New System.Drawing.Size(75, 13)
        Me.lblHoursPerDay.TabIndex = 7
        Me.lblHoursPerDay.Text = "Hours per Day"
        '
        'lblApplianceKWH
        '
        Me.lblApplianceKWH.AutoSize = True
        Me.lblApplianceKWH.Location = New System.Drawing.Point(6, 114)
        Me.lblApplianceKWH.Name = "lblApplianceKWH"
        Me.lblApplianceKWH.Size = New System.Drawing.Size(88, 13)
        Me.lblApplianceKWH.TabIndex = 6
        Me.lblApplianceKWH.Text = "Appliance k/Wh:"
        '
        'lblCostKWH
        '
        Me.lblCostKWH.AutoSize = True
        Me.lblCostKWH.Location = New System.Drawing.Point(6, 73)
        Me.lblCostKWH.Name = "lblCostKWH"
        Me.lblCostKWH.Size = New System.Drawing.Size(62, 13)
        Me.lblCostKWH.TabIndex = 5
        Me.lblCostKWH.Text = "Cost k/Wh:"
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(6, 27)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(57, 13)
        Me.lblAppliance.TabIndex = 4
        Me.lblAppliance.Text = "Appliance:"
        '
        'cboSelectAppliance
        '
        Me.cboSelectAppliance.FormattingEnabled = True
        Me.cboSelectAppliance.Items.AddRange(New Object() {"None", "Air Conditioner", "Clothes Dryer", "Clothes Washer", "Dish Washer", "Electric Oven", "Microwave Oven", "Refridgerator ", "Water Heater"})
        Me.cboSelectAppliance.Location = New System.Drawing.Point(81, 19)
        Me.cboSelectAppliance.Name = "cboSelectAppliance"
        Me.cboSelectAppliance.Size = New System.Drawing.Size(95, 21)
        Me.cboSelectAppliance.TabIndex = 1
        '
        'txtHoursPerDay
        '
        Me.txtHoursPerDay.Location = New System.Drawing.Point(94, 152)
        Me.txtHoursPerDay.Name = "txtHoursPerDay"
        Me.txtHoursPerDay.Size = New System.Drawing.Size(82, 20)
        Me.txtHoursPerDay.TabIndex = 4
        '
        'txtApplianceKWH
        '
        Me.txtApplianceKWH.Location = New System.Drawing.Point(94, 107)
        Me.txtApplianceKWH.Name = "txtApplianceKWH"
        Me.txtApplianceKWH.Size = New System.Drawing.Size(82, 20)
        Me.txtApplianceKWH.TabIndex = 3
        '
        'txtCostPerKWH
        '
        Me.txtCostPerKWH.Location = New System.Drawing.Point(94, 66)
        Me.txtCostPerKWH.Name = "txtCostPerKWH"
        Me.txtCostPerKWH.Size = New System.Drawing.Size(82, 20)
        Me.txtCostPerKWH.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDailyCost)
        Me.GroupBox2.Controls.Add(Me.txtSelectedAppliance)
        Me.GroupBox2.Controls.Add(Me.lblDailyCost)
        Me.GroupBox2.Controls.Add(Me.lblSelectedAppliance)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'txtDailyCost
        '
        Me.txtDailyCost.Location = New System.Drawing.Point(153, 60)
        Me.txtDailyCost.Name = "txtDailyCost"
        Me.txtDailyCost.Size = New System.Drawing.Size(100, 20)
        Me.txtDailyCost.TabIndex = 100
        '
        'txtSelectedAppliance
        '
        Me.txtSelectedAppliance.Location = New System.Drawing.Point(153, 28)
        Me.txtSelectedAppliance.Name = "txtSelectedAppliance"
        Me.txtSelectedAppliance.Size = New System.Drawing.Size(100, 20)
        Me.txtSelectedAppliance.TabIndex = 200
        '
        'lblDailyCost
        '
        Me.lblDailyCost.AutoSize = True
        Me.lblDailyCost.Location = New System.Drawing.Point(19, 63)
        Me.lblDailyCost.Name = "lblDailyCost"
        Me.lblDailyCost.Size = New System.Drawing.Size(54, 13)
        Me.lblDailyCost.TabIndex = 1
        Me.lblDailyCost.Text = "Daily Cost"
        '
        'lblSelectedAppliance
        '
        Me.lblSelectedAppliance.AutoSize = True
        Me.lblSelectedAppliance.Location = New System.Drawing.Point(19, 31)
        Me.lblSelectedAppliance.Name = "lblSelectedAppliance"
        Me.lblSelectedAppliance.Size = New System.Drawing.Size(102, 13)
        Me.lblSelectedAppliance.TabIndex = 0
        Me.lblSelectedAppliance.Text = "Selected Appliance:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(228, 180)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Appliance, Me.HoursPerDay, Me.DailyCost})
        Me.lstView.HideSelection = False
        Me.lstView.Location = New System.Drawing.Point(323, 31)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(368, 341)
        Me.lstView.TabIndex = 300
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'Appliance
        '
        Me.Appliance.Text = "Appliance Name"
        Me.Appliance.Width = 120
        '
        'HoursPerDay
        '
        Me.HoursPerDay.Text = "Use Hours Per Day"
        Me.HoursPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HoursPerDay.Width = 120
        '
        'DailyCost
        '
        Me.DailyCost.Text = "Cost Per Day"
        Me.DailyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DailyCost.Width = 120
        '
        'Gregory_Chavez_Enhanced_Home_Utility_Auditing_Program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 408)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAddToList)
        Me.Name = "Gregory_Chavez_Enhanced_Home_Utility_Auditing_Program"
        Me.Text = " Enhanced Home Utility Auditing Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddToList As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboSelectAppliance As ComboBox
    Friend WithEvents txtHoursPerDay As TextBox
    Friend WithEvents txtApplianceKWH As TextBox
    Friend WithEvents txtCostPerKWH As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblHoursPerDay As Label
    Friend WithEvents lblApplianceKWH As Label
    Friend WithEvents lblCostKWH As Label
    Friend WithEvents lblAppliance As Label
    Friend WithEvents txtDailyCost As TextBox
    Friend WithEvents txtSelectedAppliance As TextBox
    Friend WithEvents lblDailyCost As Label
    Friend WithEvents lblSelectedAppliance As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lstView As ListView
    Friend WithEvents Appliance As ColumnHeader
    Friend WithEvents DailyCost As ColumnHeader
    Friend WithEvents HoursPerDay As ColumnHeader
End Class
