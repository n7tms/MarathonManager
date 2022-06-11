Public Class frmTest
    Dim db As clsDatabaseSQLite

    Private Sub butCreateDatabase_Click(sender As Object, e As EventArgs) Handles butCreateDatabase.Click
        db = New clsDatabaseSQLite("d:\test1.db")
    End Sub

    Private Sub butInsert_Click(sender As Object, e As EventArgs) Handles butInsert.Click
        If db Is Nothing Then
            MsgBox("Create database first.", vbOKOnly, vbAbort)
        Else
            db.dbUpdate(txtInsert.Text)
        End If
    End Sub
End Class
