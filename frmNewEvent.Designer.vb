<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEvent
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
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.lblCopyFrom = New System.Windows.Forms.Label()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblZoomLevel = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.butCopy = New System.Windows.Forms.Button()
        Me.butClear = New System.Windows.Forms.Button()
        Me.butCreate = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtLongitude = New System.Windows.Forms.TextBox()
        Me.txtLatitude = New System.Windows.Forms.TextBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.tbrZoomLevel = New System.Windows.Forms.TrackBar()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.txtCopyFrom = New System.Windows.Forms.TextBox()
        CType(Me.tbrZoomLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(115, 79)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(243, 23)
        Me.txtEventName.TabIndex = 0
        '
        'lblCopyFrom
        '
        Me.lblCopyFrom.AutoSize = True
        Me.lblCopyFrom.Location = New System.Drawing.Point(40, 25)
        Me.lblCopyFrom.Name = "lblCopyFrom"
        Me.lblCopyFrom.Size = New System.Drawing.Size(69, 15)
        Me.lblCopyFrom.TabIndex = 2
        Me.lblCopyFrom.Text = "Copy From:"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Location = New System.Drawing.Point(35, 82)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(74, 15)
        Me.lblEventName.TabIndex = 3
        Me.lblEventName.Text = "Event Name:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(42, 121)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(67, 15)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(115, 118)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(251, 117)
        Me.txtDescription.TabIndex = 1
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(394, 118)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(56, 15)
        Me.lblLocation.TabIndex = 6
        Me.lblLocation.Text = "Location:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(394, 156)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(142, 15)
        Me.lblLongitude.TabIndex = 7
        Me.lblLongitude.Text = "Course Center: Longitude"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(394, 190)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(131, 15)
        Me.lblLatitude.TabIndex = 8
        Me.lblLatitude.Text = "Course Center: Latitude"
        '
        'lblZoomLevel
        '
        Me.lblZoomLevel.AutoSize = True
        Me.lblZoomLevel.Location = New System.Drawing.Point(394, 220)
        Me.lblZoomLevel.Name = "lblZoomLevel"
        Me.lblZoomLevel.Size = New System.Drawing.Size(214, 15)
        Me.lblZoomLevel.TabIndex = 9
        Me.lblZoomLevel.Text = "Course Center: Map Zoom Level (2-18):"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(48, 271)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(98, 15)
        Me.lblStart.TabIndex = 10
        Me.lblStart.Text = "Start Date / Time:"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(52, 306)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(94, 15)
        Me.lblEnd.TabIndex = 11
        Me.lblEnd.Text = "End Date / Time:"
        '
        'butCopy
        '
        Me.butCopy.Location = New System.Drawing.Point(364, 21)
        Me.butCopy.Name = "butCopy"
        Me.butCopy.Size = New System.Drawing.Size(75, 23)
        Me.butCopy.TabIndex = 14
        Me.butCopy.Text = "Copy..."
        Me.butCopy.UseVisualStyleBackColor = True
        '
        'butClear
        '
        Me.butClear.Location = New System.Drawing.Point(394, 284)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(75, 23)
        Me.butClear.TabIndex = 12
        Me.butClear.Text = "Clear Form"
        Me.butClear.UseVisualStyleBackColor = True
        '
        'butCreate
        '
        Me.butCreate.Location = New System.Drawing.Point(614, 277)
        Me.butCreate.Name = "butCreate"
        Me.butCreate.Size = New System.Drawing.Size(101, 37)
        Me.butCreate.TabIndex = 10
        Me.butCreate.Text = "Create Event"
        Me.butCreate.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(456, 112)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(295, 23)
        Me.txtLocation.TabIndex = 2
        '
        'txtLongitude
        '
        Me.txtLongitude.Location = New System.Drawing.Point(542, 153)
        Me.txtLongitude.Name = "txtLongitude"
        Me.txtLongitude.Size = New System.Drawing.Size(209, 23)
        Me.txtLongitude.TabIndex = 3
        '
        'txtLatitude
        '
        Me.txtLatitude.Location = New System.Drawing.Point(542, 187)
        Me.txtLatitude.Name = "txtLatitude"
        Me.txtLatitude.Size = New System.Drawing.Size(209, 23)
        Me.txtLatitude.TabIndex = 4
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(157, 268)
        Me.dtpStartDate.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 23)
        Me.dtpStartDate.TabIndex = 6
        '
        'tbrZoomLevel
        '
        Me.tbrZoomLevel.Location = New System.Drawing.Point(614, 220)
        Me.tbrZoomLevel.Maximum = 18
        Me.tbrZoomLevel.Minimum = 2
        Me.tbrZoomLevel.Name = "tbrZoomLevel"
        Me.tbrZoomLevel.Size = New System.Drawing.Size(137, 45)
        Me.tbrZoomLevel.TabIndex = 5
        Me.tbrZoomLevel.Value = 13
        '
        'butCancel
        '
        Me.butCancel.Location = New System.Drawing.Point(504, 284)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 23)
        Me.butCancel.TabIndex = 11
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpStartTime.CustomFormat = "HH:mm"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTime.Location = New System.Drawing.Point(275, 268)
        Me.dtpStartTime.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpStartTime.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(61, 23)
        Me.dtpStartTime.TabIndex = 7
        Me.dtpStartTime.Value = New Date(2022, 7, 7, 6, 0, 0, 0)
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(157, 302)
        Me.dtpEndDate.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 23)
        Me.dtpEndDate.TabIndex = 8
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpEndTime.CustomFormat = "HH:mm"
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndTime.Location = New System.Drawing.Point(275, 302)
        Me.dtpEndTime.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpEndTime.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(61, 23)
        Me.dtpEndTime.TabIndex = 9
        Me.dtpEndTime.Value = New Date(2022, 7, 7, 15, 0, 0, 0)
        '
        'txtCopyFrom
        '
        Me.txtCopyFrom.Location = New System.Drawing.Point(115, 21)
        Me.txtCopyFrom.Name = "txtCopyFrom"
        Me.txtCopyFrom.Size = New System.Drawing.Size(243, 23)
        Me.txtCopyFrom.TabIndex = 15
        '
        'frmNewEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 353)
        Me.Controls.Add(Me.txtCopyFrom)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartTime)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.tbrZoomLevel)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.txtLatitude)
        Me.Controls.Add(Me.txtLongitude)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.butCreate)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.butCopy)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblZoomLevel)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblEventName)
        Me.Controls.Add(Me.lblCopyFrom)
        Me.Controls.Add(Me.txtEventName)
        Me.Name = "frmNewEvent"
        Me.Text = "New Event"
        CType(Me.tbrZoomLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEventName As TextBox
    Friend WithEvents lblCopyFrom As Label
    Friend WithEvents lblEventName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblZoomLevel As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents butCopy As Button
    Friend WithEvents butClear As Button
    Friend WithEvents butCreate As Button
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtLongitude As TextBox
    Friend WithEvents txtLatitude As TextBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents tbrZoomLevel As TrackBar
    Friend WithEvents butCancel As Button
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents txtCopyFrom As TextBox
End Class
