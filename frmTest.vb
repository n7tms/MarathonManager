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

    Private Sub butBrowse_Click(sender As Object, e As EventArgs) Handles butBrowse.Click
        Dim result As List(Of Dictionary(Of String, Object))

        If db Is Nothing Then
            MsgBox("Create database first.", vbOKOnly, vbAbort)
        Else
            result = db.dbSelect(txtInsert.Text)
            If result.Count > 0 Then
                For i As Integer = 0 To result.Count - 1
                    MsgBox(result(i).Item("first"))
                    MsgBox(result(i).Item("num"))
                Next
            End If
        End If
    End Sub


End Class
