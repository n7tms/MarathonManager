﻿Module modNotes
    'Next
    ' . build the high-level structure of the app
    ' . . the main forms



    'There may be some value in this code
    'Dim conn As New SQLiteConnection("Data Source=myDatabase.sql3;Version=3;")
    '    conn.Open()
    '    Dim SQL As String = "SELECT * from lang;"
    'Dim da As New SQLiteDataAdapter(SQL, conn)
    'Dim ds As New DataSet
    '    da.Fill(ds, "lang")
    '    'Close the connection
    '    conn.Close()
    '    'ListView1
    '    With ListView1
    '.View = View.Details
    '.HeaderStyle = ColumnHeaderStyle.Nonclickable ' set to whatever you need
    '.Columns.Clear() ' make sure columnscollection is empty
    '' Add 3 columns
    '.Columns.Add(ds.Tables(0).Columns(0).ColumnName)
    '.Columns.Add(ds.Tables(0).Columns(1).ColumnName)
    '.Columns.Add(ds.Tables(0).Columns(2).ColumnName)

    'End With
    'For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '        ListView1.Items.Add(New ListViewItem({ds.Tables(0).Rows(i).Item(0).ToString(), ds.Tables(0).Rows(i).Item(1).ToString(), ds.Tables(0).Rows(i).Item(2).ToString()}))
    '    Next


End Module