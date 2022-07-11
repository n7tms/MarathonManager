<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtDBVersion = New System.Windows.Forms.TextBox()
        Me.lblDBVersion = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTestField1 = New System.Windows.Forms.TextBox()
        Me.txtTestField2 = New System.Windows.Forms.TextBox()
        Me.tabSettings.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.TabPage1)
        Me.tabSettings.Controls.Add(Me.TabPage2)
        Me.tabSettings.Location = New System.Drawing.Point(12, 12)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.Size = New System.Drawing.Size(776, 367)
        Me.tabSettings.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtTestField2)
        Me.TabPage1.Controls.Add(Me.txtTestField1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtDBVersion)
        Me.TabPage1.Controls.Add(Me.lblDBVersion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Global"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtDBVersion
        '
        Me.txtDBVersion.Enabled = False
        Me.txtDBVersion.Location = New System.Drawing.Point(115, 310)
        Me.txtDBVersion.Name = "txtDBVersion"
        Me.txtDBVersion.Size = New System.Drawing.Size(100, 23)
        Me.txtDBVersion.TabIndex = 1
        '
        'lblDBVersion
        '
        Me.lblDBVersion.AutoSize = True
        Me.lblDBVersion.Location = New System.Drawing.Point(10, 313)
        Me.lblDBVersion.Name = "lblDBVersion"
        Me.lblDBVersion.Size = New System.Drawing.Size(99, 15)
        Me.lblDBVersion.TabIndex = 0
        Me.lblDBVersion.Text = "Database Version:"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.Location = New System.Drawing.Point(477, 406)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 23)
        Me.butCancel.TabIndex = 1
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butSave
        '
        Me.butSave.Location = New System.Drawing.Point(584, 406)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(109, 23)
        Me.butSave.TabIndex = 2
        Me.butSave.Text = "Save Settings"
        Me.butSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Test Field 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Test Field 2:"
        '
        'txtTestField1
        '
        Me.txtTestField1.Location = New System.Drawing.Point(127, 38)
        Me.txtTestField1.Name = "txtTestField1"
        Me.txtTestField1.Size = New System.Drawing.Size(100, 23)
        Me.txtTestField1.TabIndex = 4
        '
        'txtTestField2
        '
        Me.txtTestField2.Location = New System.Drawing.Point(127, 83)
        Me.txtTestField2.Name = "txtTestField2"
        Me.txtTestField2.Size = New System.Drawing.Size(100, 23)
        Me.txtTestField2.TabIndex = 5
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.tabSettings)
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        Me.tabSettings.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabSettings As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents butCancel As Button
    Friend WithEvents butSave As Button
    Friend WithEvents txtDBVersion As TextBox
    Friend WithEvents lblDBVersion As Label
    Friend WithEvents txtTestField2 As TextBox
    Friend WithEvents txtTestField1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
