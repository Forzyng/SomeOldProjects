CREATE TABLE Lectures(
   Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
   DayOfWeek INT NOT NULL CHECK( DayOfWeek > 0 AND DayOfWeek <= 7 ),
   LectureRoom nvarchar(max) NOT NULL CHECK( LectureRoom != '' )
) ;

