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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.lblMasterDatabase = New System.Windows.Forms.Label()
        Me.txtMasterDatabasePath = New System.Windows.Forms.TextBox()
        Me.butOpenDBFile = New System.Windows.Forms.Button()
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
        Me.TabPage1.Controls.Add(Me.butOpenDBFile)
        Me.TabPage1.Controls.Add(Me.txtMasterDatabasePath)
        Me.TabPage1.Controls.Add(Me.lblMasterDatabase)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Global"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        'lblMasterDatabase
        '
        Me.lblMasterDatabase.AutoSize = True
        Me.lblMasterDatabase.Location = New System.Drawing.Point(30, 35)
        Me.lblMasterDatabase.Name = "lblMasterDatabase"
        Me.lblMasterDatabase.Size = New System.Drawing.Size(94, 15)
        Me.lblMasterDatabase.TabIndex = 0
        Me.lblMasterDatabase.Text = "Master Database"
        '
        'txtMasterDatabasePath
        '
        Me.txtMasterDatabasePath.Location = New System.Drawing.Point(130, 32)
        Me.txtMasterDatabasePath.Name = "txtMasterDatabasePath"
        Me.txtMasterDatabasePath.Size = New System.Drawing.Size(344, 23)
        Me.txtMasterDatabasePath.TabIndex = 1
        '
        'butOpenDBFile
        '
        Me.butOpenDBFile.Location = New System.Drawing.Point(480, 31)
        Me.butOpenDBFile.Name = "butOpenDBFile"
        Me.butOpenDBFile.Size = New System.Drawing.Size(30, 23)
        Me.butOpenDBFile.TabIndex = 2
        Me.butOpenDBFile.Text = "..."
        Me.butOpenDBFile.UseVisualStyleBackColor = True
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
    Friend WithEvents butOpenDBFile As Button
    Friend WithEvents txtMasterDatabasePath As TextBox
    Friend WithEvents lblMasterDatabase As Label
End Class
