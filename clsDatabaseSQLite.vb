'clsDatabaseSQLite.vb
'Database class which implements SQLite connectivity
'

Imports System.Data.SqlClient

Public Class clsDatabaseSQLite
    Dim dbFileName As String
    Dim ConnectionString As String

    Public Sub New(sDBFileName As String)
        dbFileName = sDBFileName
        ConnectionString = String.Format("Data Source = {0}", dbFileName)

        Dim SqlConn As New SQLite.SQLiteConnection(ConnectionString)
        SqlConn.Open()
        SqlConn.Close()

        'If Not duplicateDatabase(sDBFileName) Then
        '    Me.createDatabase()
        'End If
    End Sub

    Public Sub createDatabase()
        Dim createTable As String = "CREATE TABLE `testTable` (
                                    `id` INTEGER PRIMARY KEY AUTOINCREMENT,
                                    `first` TEXT,
                                    'num' INTEGER
                                    );"
        Using SqlConn As New SQLite.SQLiteConnection(ConnectionString)
            Dim cmd As New SQLite.SQLiteCommand(createTable, SqlConn)
            SqlConn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub deleteDatabase()

    End Sub


    Public Function dbSelect(sSelectStatement As String) As List(Of Dictionary(Of String, Object))
        Dim lstDataset As New List(Of Dictionary(Of String, Object))

        Using sqlconn As New SQLite.SQLiteConnection(ConnectionString)
            Dim cmd As New SQLite.SQLiteCommand(sSelectStatement, sqlconn)
            sqlconn.Open()
            Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
            While rdr.Read()
                'rdr.FieldCount
                'rdr.GetName(i)   -- get the column name

                Dim dctRow As New Dictionary(Of String, Object)
                For i As Integer = 0 To rdr.FieldCount - 1
                    'MsgBox(rdr.GetName(i) + ": " + rdr.GetValue(i).ToString)

                    dctRow.Add(rdr.GetName(i), rdr.GetValue(i))
                Next
                lstDataset.Add(dctRow)
            End While
        End Using

        Return lstDataset
    End Function

    Public Sub dbUpdate(sUpdateStatement As String)
        Using sqlconn As New SQLite.SQLiteConnection(ConnectionString)
            Dim cmd As New SQLite.SQLiteCommand(sUpdateStatement, sqlconn)
            sqlconn.Open()
            cmd.ExecuteNonQuery()
        End Using

    End Sub


    Private Function duplicateDatabase(sFileName As String) As Boolean
        Return System.IO.File.Exists(sFileName)
    End Function



End Class
