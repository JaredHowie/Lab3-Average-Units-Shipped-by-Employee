<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTipAverageUnitsShippedByEmployee = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbAveragePerDay = New System.Windows.Forms.Label()
        Me.lbAverageEmployeeOne = New System.Windows.Forms.Label()
        Me.lbAverageEmployeeTwo = New System.Windows.Forms.Label()
        Me.lbAverageEmployeeThree = New System.Windows.Forms.Label()
        Me.tbEmployeeOne = New System.Windows.Forms.TextBox()
        Me.tbEmployeeTwo = New System.Windows.Forms.TextBox()
        Me.tbEmployeeThree = New System.Windows.Forms.TextBox()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.lbEmployeeOne = New System.Windows.Forms.Label()
        Me.lbEmployeeTwo = New System.Windows.Forms.Label()
        Me.lbEmployeeThree = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.AccessibleName = "btnReset"
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(172, 332)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(148, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.btnReset, "Resets all text on the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.AccessibleName = "btnEnter"
        Me.btnEnter.Location = New System.Drawing.Point(12, 332)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(148, 23)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.btnEnter, "Calculate the average uinits shipped")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.Location = New System.Drawing.Point(332, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.btnExit, "Exits the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbAveragePerDay
        '
        Me.lbAveragePerDay.AccessibleName = "lbAveragePerDay"
        Me.lbAveragePerDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAveragePerDay.Location = New System.Drawing.Point(12, 308)
        Me.lbAveragePerDay.Name = "lbAveragePerDay"
        Me.lbAveragePerDay.Size = New System.Drawing.Size(468, 21)
        Me.lbAveragePerDay.TabIndex = 4
        Me.lbAveragePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lbAveragePerDay, "Displays the average unit shipped per day for all three employees")
        '
        'lbAverageEmployeeOne
        '
        Me.lbAverageEmployeeOne.AccessibleName = "lbAverageEmployeeOne"
        Me.lbAverageEmployeeOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageEmployeeOne.Location = New System.Drawing.Point(12, 277)
        Me.lbAverageEmployeeOne.Name = "lbAverageEmployeeOne"
        Me.lbAverageEmployeeOne.Size = New System.Drawing.Size(148, 22)
        Me.lbAverageEmployeeOne.TabIndex = 5
        Me.lbAverageEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lbAverageEmployeeOne, "Displays the average units shipped for Employee One")
        '
        'lbAverageEmployeeTwo
        '
        Me.lbAverageEmployeeTwo.AccessibleName = "lbAverageEmployeeTwo"
        Me.lbAverageEmployeeTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageEmployeeTwo.Location = New System.Drawing.Point(172, 277)
        Me.lbAverageEmployeeTwo.Name = "lbAverageEmployeeTwo"
        Me.lbAverageEmployeeTwo.Size = New System.Drawing.Size(148, 22)
        Me.lbAverageEmployeeTwo.TabIndex = 6
        Me.lbAverageEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lbAverageEmployeeTwo, "Displays the average units shipped for Employee Two")
        '
        'lbAverageEmployeeThree
        '
        Me.lbAverageEmployeeThree.AccessibleName = "lbAverageEmployeeThree"
        Me.lbAverageEmployeeThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageEmployeeThree.Location = New System.Drawing.Point(332, 277)
        Me.lbAverageEmployeeThree.Name = "lbAverageEmployeeThree"
        Me.lbAverageEmployeeThree.Size = New System.Drawing.Size(148, 22)
        Me.lbAverageEmployeeThree.TabIndex = 7
        Me.lbAverageEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lbAverageEmployeeThree, "Displays the average units shipped for Employee Three")
        '
        'tbEmployeeOne
        '
        Me.tbEmployeeOne.AccessibleName = "tbEmployeeOne"
        Me.tbEmployeeOne.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbEmployeeOne.Enabled = False
        Me.tbEmployeeOne.Location = New System.Drawing.Point(12, 107)
        Me.tbEmployeeOne.Multiline = True
        Me.tbEmployeeOne.Name = "tbEmployeeOne"
        Me.tbEmployeeOne.ReadOnly = True
        Me.tbEmployeeOne.Size = New System.Drawing.Size(148, 167)
        Me.tbEmployeeOne.TabIndex = 0
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.tbEmployeeOne, "Displays the units shipped for Employee One")
        '
        'tbEmployeeTwo
        '
        Me.tbEmployeeTwo.AccessibleName = "tbEmployeeTwo"
        Me.tbEmployeeTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbEmployeeTwo.Enabled = False
        Me.tbEmployeeTwo.Location = New System.Drawing.Point(172, 107)
        Me.tbEmployeeTwo.Multiline = True
        Me.tbEmployeeTwo.Name = "tbEmployeeTwo"
        Me.tbEmployeeTwo.ReadOnly = True
        Me.tbEmployeeTwo.Size = New System.Drawing.Size(148, 167)
        Me.tbEmployeeTwo.TabIndex = 0
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.tbEmployeeTwo, "Displays the units shipped for Employee Two")
        '
        'tbEmployeeThree
        '
        Me.tbEmployeeThree.AccessibleName = "tbEmployeeThree"
        Me.tbEmployeeThree.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbEmployeeThree.Enabled = False
        Me.tbEmployeeThree.Location = New System.Drawing.Point(332, 107)
        Me.tbEmployeeThree.Multiline = True
        Me.tbEmployeeThree.Name = "tbEmployeeThree"
        Me.tbEmployeeThree.ReadOnly = True
        Me.tbEmployeeThree.Size = New System.Drawing.Size(148, 167)
        Me.tbEmployeeThree.TabIndex = 0
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.tbEmployeeThree, "Displays the units shipped for Employee Three")
        '
        'lbDay
        '
        Me.lbDay.AccessibleName = "lbDay"
        Me.lbDay.Location = New System.Drawing.Point(12, 26)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(60, 17)
        Me.lbDay.TabIndex = 15
        Me.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lbDay, "Current day you are on")
        '
        'tbUnits
        '
        Me.tbUnits.AccessibleName = "tbUnits"
        Me.tbUnits.Location = New System.Drawing.Point(79, 56)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(56, 22)
        Me.tbUnits.TabIndex = 1
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.tbUnits, "Enter the Units Shipped Here")
        '
        'lbEmployeeOne
        '
        Me.lbEmployeeOne.AccessibleName = "lbEmployeeOne"
        Me.lbEmployeeOne.Location = New System.Drawing.Point(12, 81)
        Me.lbEmployeeOne.Name = "lbEmployeeOne"
        Me.lbEmployeeOne.Size = New System.Drawing.Size(148, 23)
        Me.lbEmployeeOne.TabIndex = 11
        Me.lbEmployeeOne.Text = "Employee 1"
        Me.lbEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployeeTwo
        '
        Me.lbEmployeeTwo.AccessibleName = "lbEmployeeTwo"
        Me.lbEmployeeTwo.Location = New System.Drawing.Point(172, 81)
        Me.lbEmployeeTwo.Name = "lbEmployeeTwo"
        Me.lbEmployeeTwo.Size = New System.Drawing.Size(148, 23)
        Me.lbEmployeeTwo.TabIndex = 12
        Me.lbEmployeeTwo.Text = "Employee 2"
        Me.lbEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployeeThree
        '
        Me.lbEmployeeThree.AccessibleName = "lbEmployeeThree"
        Me.lbEmployeeThree.Location = New System.Drawing.Point(332, 81)
        Me.lbEmployeeThree.Name = "lbEmployeeThree"
        Me.lbEmployeeThree.Size = New System.Drawing.Size(148, 23)
        Me.lbEmployeeThree.TabIndex = 13
        Me.lbEmployeeThree.Text = "Employee 3"
        Me.lbEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 8)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        '
        'lbUnits
        '
        Me.lbUnits.AccessibleName = "lbUnits"
        Me.lbUnits.Location = New System.Drawing.Point(12, 54)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(60, 23)
        Me.lbUnits.TabIndex = 16
        Me.lbUnits.Text = "Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AccessibleName = "frmAverageUnitsShippedByEmployee"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(492, 367)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbEmployeeThree)
        Me.Controls.Add(Me.lbEmployeeTwo)
        Me.Controls.Add(Me.lbEmployeeOne)
        Me.Controls.Add(Me.tbEmployeeThree)
        Me.Controls.Add(Me.tbEmployeeTwo)
        Me.Controls.Add(Me.tbEmployeeOne)
        Me.Controls.Add(Me.lbAverageEmployeeThree)
        Me.Controls.Add(Me.lbAverageEmployeeTwo)
        Me.Controls.Add(Me.lbAverageEmployeeOne)
        Me.Controls.Add(Me.lbAveragePerDay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnReset)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTipAverageUnitsShippedByEmployee As ToolTip
    Friend WithEvents lbAveragePerDay As Label
    Friend WithEvents lbAverageEmployeeOne As Label
    Friend WithEvents lbAverageEmployeeTwo As Label
    Friend WithEvents lbAverageEmployeeThree As Label
    Friend WithEvents tbEmployeeOne As TextBox
    Friend WithEvents tbEmployeeTwo As TextBox
    Friend WithEvents tbEmployeeThree As TextBox
    Friend WithEvents lbEmployeeOne As Label
    Friend WithEvents lbEmployeeTwo As Label
    Friend WithEvents lbEmployeeThree As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbDay As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUnits As TextBox
End Class
