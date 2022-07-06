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

        '== Create the tables= ==
        'Persons Table
        sStmt = "CREATE TABLE Persons (
                PersonID	INTEGER UNIQUE,
	            Firstname	TEXT,
	            Lastname	TEXT,
                Gender	TEXT,
	            Birthdate	TEXT,
                Phone	TEXT,
	            Textable	INTEGER,
                Email	TEXT,
	            Street1	TEXT,
	            Street2	TEXT,
	            City	TEXT,
                State	TEXT,
	            Zipcode	TEXT,
                EContactName	TEXT,
	            EContactPhone	TEXT,
	            PRIMARY KEY(PersonID AUTOINCREMENT)
            )"
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





    End Function


    '==================================================================================


End Module
