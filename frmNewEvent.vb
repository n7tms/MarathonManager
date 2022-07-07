Public Class frmNewEvent
    Private Sub butCreate_Click(sender As Object, e As EventArgs) Handles butCreate.Click
        'Is there anything in the "Copy From" field?
        ' . Yes: 

        'Prompt for a location/name of the database file and then create the database file
        Dim dlgOpenFile As New OpenFileDialog
        dlgOpenFile.Title = "Select New Database Name"
        dlgOpenFile.FileName = ReplaceInvalidCharacters(txtEventName.Text.Replace(" ", String.Empty)) + ".db"
        dlgOpenFile.Filter = "Databases (*.db)|*.db|All files (*.*)|*.*"
        dlgOpenFile.CheckFileExists = False

        If dlgOpenFile.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            MsgBox(dlgOpenFile.FileName)
            CreateNewDatabase(dlgOpenFile.FileName)
        End If

        'Populate the event table with the information on this form


    End Sub

    Private Sub frmNewEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class