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

        If Not duplicateDatabase(sDBFileName) Then
            Me.createDatabase()
        End If
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


    'You're working right here
    'Figure out a way to get the results of a select statement into a list of something to 
    'pass back to the calling function.
    Public Function dbSelect(sSelectStatement As String) As


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
