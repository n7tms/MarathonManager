Module modCode
    'A collection of common code used or referenced throughout the project

    'Static Variables



    'Other code

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



    End Function


    '==================================================================================


End Module
