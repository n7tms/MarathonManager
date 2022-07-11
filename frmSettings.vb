Public Class frmSettings
    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click
        'Save the settings
        SaveSettings()

        'Close the form
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFields()
    End Sub

    Private Sub PopulateFields()
        Dim db As New clsDatabaseSQLite(sDBPath)
        Dim sStmt As String
        Dim rList As New List(Of Dictionary(Of String, Object))

        sStmt = "SELECT SettingName, SettingValue FROM Settings"
        rList = db.dbSelect(sStmt)

        For Each dField As Dictionary(Of String, Object) In rList
            Select Case dField("SettingName")
                Case "DBVersion"
                    txtDBVersion.Text = dField("SettingValue")
                Case "Test1"
                    txtTestField1.Text = dField("SettingValue")
                Case "Test2"
                    txtTestField2.Text = dField("SettingValue")

            End Select
        Next
    End Sub

    Private Sub SaveSettings()
        Dim db As New clsDatabaseSQLite(sDBPath)
        Dim sStmt As String

        sStmt = "UPDATE Settings SET SettingValue = '" + txtTestField1.Text + "' WHERE SettingName = 'Test1'"
        db.dbUpdate(sStmt)

        sStmt = "UPDATE Settings SET SettingValue = '" + txtTestField2.Text + "' WHERE SettingName = 'Test2'"
        db.dbUpdate(sStmt)

    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        If MsgBox("If you made changes to the settings, they will be lost. Continue?", vbYesNo Or vbQuestion, "Abandon Changes?") = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class