<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTest
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
        Me.butCreateDatabase = New System.Windows.Forms.Button()
        Me.txtInsert = New System.Windows.Forms.TextBox()
        Me.lblInsert = New System.Windows.Forms.Label()
        Me.butInsert = New System.Windows.Forms.Button()
        Me.butBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butCreateDatabase
        '
        Me.butCreateDatabase.Location = New System.Drawing.Point(254, 31)
        Me.butCreateDatabase.Name = "butCreateDatabase"
        Me.butCreateDatabase.Size = New System.Drawing.Size(75, 23)
        Me.butCreateDatabase.TabIndex = 0
        Me.butCreateDatabase.Text = "Create DB"
        Me.butCreateDatabase.UseVisualStyleBackColor = True
        '
        'txtInsert
        '
        Me.txtInsert.Location = New System.Drawing.Point(54, 86)
        Me.txtInsert.Name = "txtInsert"
        Me.txtInsert.Size = New System.Drawing.Size(253, 23)
        Me.txtInsert.TabIndex = 1
        Me.txtInsert.Text = "select first from testTable"
        '
        'lblInsert
        '
        Me.lblInsert.AutoSize = True
        Me.lblInsert.Location = New System.Drawing.Point(12, 89)
        Me.lblInsert.Name = "lblInsert"
        Me.lblInsert.Size = New System.Drawing.Size(28, 15)
        Me.lblInsert.TabIndex = 2
        Me.lblInsert.Text = "SQL"
        '
        'butInsert
        '
        Me.butInsert.Location = New System.Drawing.Point(313, 86)
        Me.butInsert.Name = "butInsert"
        Me.butInsert.Size = New System.Drawing.Size(75, 23)
        Me.butInsert.TabIndex = 3
        Me.butInsert.Text = "Insert"
        Me.butInsert.UseVisualStyleBackColor = True
        '
        'butBrowse
        '
        Me.butBrowse.Location = New System.Drawing.Point(394, 86)
        Me.butBrowse.Name = "butBrowse"
        Me.butBrowse.Size = New System.Drawing.Size(75, 23)
        Me.butBrowse.TabIndex = 4
        Me.butBrowse.Text = "Browse"
        Me.butBrowse.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 208)
        Me.Controls.Add(Me.butBrowse)
        Me.Controls.Add(Me.butInsert)
        Me.Controls.Add(Me.lblInsert)
        Me.Controls.Add(Me.txtInsert)
        Me.Controls.Add(Me.butCreateDatabase)
        Me.Name = "frmTest"
        Me.Text = "Test Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butCreateDatabase As Button
    Friend WithEvents txtInsert As TextBox
    Friend WithEvents lblInsert As Label
    Friend WithEvents butInsert As Button
    Friend WithEvents butBrowse As Button
End Class
