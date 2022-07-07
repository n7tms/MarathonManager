Public Class frmMain
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New frmAbout
        frm.ShowDialog()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Dim frm As New frmTest
        frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim iResult As Integer

        iResult = MsgBox("Are you sure you want to exit?", vbYesNo Or vbQuestion, "MarathonManager: Exit?")
        If iResult = vbYes Then
            End
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim dlg As New frmNewEvent
        dlg.ShowDialog()


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dlg As New frmTest
        dlg.ShowDialog()



    End Sub
End Class