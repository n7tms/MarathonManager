Public Class frmSettings
    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click
        'Write all the fields to the corresponding setting values
        My.Settings.MasterDatabasePath = txtMasterDatabasePath.Text

        'Save the settings
        My.Settings.Save()

        'Close the form
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFields()
    End Sub

    Private Sub PopulateFields()
        txtMasterDatabasePath.Text = My.Settings.MasterDatabasePath
    End Sub
End Class