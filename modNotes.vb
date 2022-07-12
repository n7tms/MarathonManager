Module modNotes
    'Next
    ' create new event
    ' 


    'The app will use a variety of open windows
    ' . main control
    ' . sitings
    ' . traffic
    ' . assignments
    ' . reporting and/or participant status screens


    'I think I need separate databases
    ' . ...A people database which contains ...
    '       . Persons
    '       . Volunteers
    '       . Users
    ' . ...And an events database that contains the information for the current event
    '
    ' . but i'm not sure I can have two databases open at the same time and "join"ing the tables
    ' . how does a SQLite project work?




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



    '================================================================================
    ' For Posperity
    '================================================================================
    '
    'ConfigurationErrorsException: Unrecognized configuration section system.diagnostics
    ' I needed to add a section to the config file so that the system.diagnositics section would be recognized.
    ' (https://stackoverflow.com/questions/57078166/net-core-using-system-diagnostics-in-app-config)
    '
    '<configSections>
    '   <section name = "system.diagnostics" type="System.Diagnostics.DiagnosticsConfigurationHandler"/>
    '</configSections>
    '---------------------------------------------------------------------------------


End Module
