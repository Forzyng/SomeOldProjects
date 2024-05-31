--CREATE PROC [dbo].[sp_Add_Author]
--@name NVARCHAR(MAX),
--@surname NVARCHAR(MAX),
--@country_name NVARCHAR(MAX),
--@id UNIQUEIDENTIFIER out
--AS
--BEGIN
--    INSERT INTO Authors 
--    ([Name], [Surname], [CountriesID])
--    VALUES
--    (@name, @surname, (SELECT C.Id FROM Countries C WHERE C.Name = @country_name));
--       SELECT 
--          @id = [Id] 
--       FROM
--          Authors 
--       WHERE
--          ([Name] = @name)
--          AND
--          ([Surname] = @surname)
--          AND
--          ([CountriesID] = (SELECT C.Id FROM Countries C WHERE C.Name = @country_name))
--       RETURN 0
--END

--DROP PROC sp_Add_Author

DECLARE @return_value INT,
        @id UNIQUEIDENTIFIER

        EXEC @return_value = [dbo].[sp_Add_Author]
        @name = N'Леся',
        @surname = N'Українка',
        @country_name = N'Украина',
        @id = @id OUTPUT

        SELECT @id AS N'@id'

        SELECT @return_value AS 'Return value'

        GO