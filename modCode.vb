Module modCode
    'A collection of common code used or referenced throughout the project

    'Static Variables
    Public sDBPath As String = Nothing
    Public Const iCURRENTDBVERSION = 1


    'Other code

    '==================================================================================
    ' Initialize App
    '
    Public Sub InitializeApp()
        'Check for the presence of the Settings database

        ' If there is an argument on the commandline, use it.
        If Environment.GetCommandLineArgs().Count > 1 Then
            Dim aVars As Array
            aVars = Environment.GetCommandLineArgs

            sDBPath = aVars(1)
        End If

        ' Check for the default name in the working directory.
        If sDBPath Is Nothing Then
            If My.Computer.FileSystem.FileExists("MarathonManagerSettings.db") Then
                sDBPath = Environment.CurrentDirectory + "\MarathonManagerSettings.db"
            End If
        End If

        ' Ask the user to locate it OR create a new one with defaults
        If sDBPath Is Nothing Then
            Dim iResult As Integer
            iResult = MsgBox("Unable to locate the master database (MarathonManagerSettings.db). " + vbCrLf + vbCrLf +
                             "'YES' to create a new one;" + vbCrLf +
                             "'NO' to select an existing one.",
                             vbYesNoCancel Or vbExclamation, "Missing Master Database")
            If iResult = Windows.Forms.DialogResult.No Then
                Dim dlgFileOpen As New OpenFileDialog
                dlgFileOpen.FileName = "MarathonManagerSettings.db"
                dlgFileOpen.Title = "Specify Master Database"
                dlgFileOpen.Filter = "db files (*.db)|*.db|All files (*.*)|*.*"
                If dlgFileOpen.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                    sDBPath = dlgFileOpen.FileName
                End If
            ElseIf iResult = Windows.Forms.DialogResult.Yes Then
                sDBPath = "MarathonManagerSettings.db"
                CreateMasterDatabase()
            Else
                End
            End If
        End If

        'MsgBox("Using: " + sDBPath, vbOKOnly Or vbInformation, "DB Path")

        'Check for the correct database version
        Dim iDBVersion As Integer
        iDBVersion = GetDBVersion()
        If iDBVersion <> iCURRENTDBVERSION Then
            MsgBox("Wrong DB Version!" + vbCrLf + vbCrLf + "Found: " + iDBVersion.ToString + vbCrLf + "Looking for: " + iCURRENTDBVERSION.ToString, vbOKOnly Or vbExclamation, "Oops!")

            '**** TODO: Handle the case where the wrong version is found.
        End If


        'Load the settings from the settings database

    End Sub

    Private Function GetDBVersion() As Integer
        Dim db As New clsDatabaseSQLite(sDBPath)
        Dim sStmt As String
        Dim rList As New List(Of Dictionary(Of String, Object))

        sStmt = "SELECT SettingValue FROM Settings WHERE SettingName = 'DBVersion' LIMIT 1"
        rList = db.dbSelect(sStmt)
        Return rList(0)("SettingValue")
    End Function

    Private Sub CreateMasterDatabase()
        Dim sStmt As String

        '== Create the file ==
        Dim db As New clsDatabaseSQLite("MarathonManagerSettings.db")

        sStmt = "CREATE TABLE Settings (SettingID INTEGER UNIQUE, SettingName TEXT, SettingValue TEXT, PRIMARY KEY(SettingID AUTOINCREMENT))"
        db.dbUpdate(sStmt)

        sStmt = "CREATE TABLE Recents (RecentID INTEGER UNIQUE,	EventName TEXT,	DBPath TEXT, PRIMARY KEY(RecentID AUTOINCREMENT))"
        db.dbUpdate(sStmt)

        ' Add the settings fields
        sStmt = "INSERT INTO Settings (SettingName, SettingValue) VALUES ('DBVersion','1')"
        db.dbUpdate(sStmt)
    End Sub
    '==================================================================================




    '==================================================================================
    ' Create a new database
    '
    Public Function CreateNewDatabase(sDBPath As String) As Boolean
        'This function creates a new SQLite database and populates it with the appropriate tables
        'There is no error checking (e.g. does the file already exist, etc.)

        Dim sStmt As String

        '== Create the file ==
        Dim db As New clsDatabaseSQLite(sDBPath)

        '**** TODO: This should probably be done as a transaction

        '== Create the tables ==
        'Persons Table
        sStmt = "CREATE TABLE Persons (
                PersonID INTEGER UNIQUE, 
                Firstname TEXT, 
                Lastname TEXT, 
                Gender TEXT, 
                Birthdate TEXT, 
                Phone TEXT, 
                Textable INTEGER, 
                Email TEXT,
                Street1 TEXT, 
                Street2 TEXT, 
                City TEXT, 
                State TEXT, 
                Zipcode TEXT, 
                EContactName TEXT, 
                EContactPhone TEXT, 
                Callsign TEXT, 
                PRIMARY KEY(PersonID AUTOINCREMENT)
            );"
        db.dbUpdate(sStmt)

        'Users Table
        sStmt ="CREATE TABLE Users (
	            UserID	INTEGER,
	            PersonID	INTEGER,
	            Username	TEXT,
                Password	TEXT,
	            Permission	INTEGER
            )"
        db.dbUpdate(sStmt)

        'Volunteers Table
        sStmt = "CREATE TABLE Volunteers (
	            VolunteerID	INTEGER UNIQUE,
	            PersonID	INTEGER,
	            EventID	INTEGER,
	            Assignment	TEXT,
	            Checkin	TEXT,
	            Checkout	TEXT,
	            PRIMARY KEY(VolunteerID AUTOINCREMENT)
            )"
        db.dbUpdate(sStmt)

        'Participants Table
        sStmt = "CREATE TABLE Participants (
	            PersonID	INTEGER UNIQUE,
	            EventID	INTEGER,
	            RaceID	INTEGER,
	            Bib	INTEGER,
                PRIMARY KEY(PersonID AUTOINCREMENT)
            )"
        db.dbUpdate(sStmt)

        'Events Table
        sStmt = "CREATE TABLE Events (
	            EventID	INTEGER UNIQUE,
	            EventName	TEXT,
	            Description	TEXT,
	            Location	TEXT,
	            Starttime	TEXT,
	            Endtime	TEXT,
	            PublicCode	TEXT UNIQUE,
	            PRIMARY KEY(EventID AUTOINCREMENT)
            );"
        db.dbUpdate(sStmt)

        'Races Table
        sStmt = "CREATE TABLE Races (
	            RaceID	INTEGER UNIQUE,
	            EventID	INTEGER,
	            RaceName	TEXT,
	            Distance	TEXT,
	            Color	TEXT,
	            PRIMARY KEY(RaceID AUTOINCREMENT)
            );"
        db.dbUpdate(sStmt)

        'Checkpoints Table
        sStmt = "CREATE TABLE Checkpoints (
	            CheckpointID	INTEGER UNIQUE,
	            EventID	INTEGER,
	            CPName	TEXT,
                Description	TEXT,
	            Longitude	NUMERIC,
	            Latitude	NUMERIC,
	            PRIMARY KEY(CheckpointID AUTOINCREMENT)
            );"
        db.dbUpdate(sStmt)

        'Sitings Table
        sStmt = "CREATE TABLE Sitings (
	            SitingID	INTEGER UNIQUE,
	            EventID	INTEGER,
	            CheckpointID	INTEGER,
	            ParticipantID	INTEGER,
	            Sitingtime	TEXT,
	            PRIMARY KEY(SitingID AUTOINCREMENT)
            );"
        db.dbUpdate(sStmt)

        'Traffic Table
        sStmt = "CREATE TABLE Traffic (
	            TrafficID	INTEGER UNIQUE,
	            EventID	INTEGER,
	            Logtime	TEXT,
	            Message	TEXT,
	            AssignedTo	TEXT,
	            CompletedTime	TEXT,
	            Status	TEXT,
	            PRIMARY KEY(TrafficID AUTOINCREMENT)
            );"
        db.dbUpdate(sStmt)

        Return True

    End Function

    '==================================================================================


    '==================================================================================
    ' Remove invalid characters from a potential/propsed filename
    '
    Public Function ReplaceInvalidCharacters(sFilename As String, Optional sReplacementChar As String = "") As String
        Dim illegalInFilename As New System.Text.RegularExpressions.Regex("[\\/:*?""<>|]")
        Return illegalInFilename.Replace(sFilename, sReplacementChar)
    End Function
    '==================================================================================


End Module
