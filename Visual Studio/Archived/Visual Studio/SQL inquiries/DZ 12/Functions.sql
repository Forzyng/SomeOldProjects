--CREATE FUNCTION Minimal_And_Max(@one INT , @two INT ,  @three INT , @four INT , @five INT) 
--RETURNS INT
--BEGIN
--	RETURN
--	(
--		SELECT
--			MIN(mt.number) + MAX(mt.number)
--		FROM
--		(
--				SELECT
--				@one AS 'number'
--					UNION
--				SELECT
--				@two
--					UNION
--				SELECT
--				@three
--					UNION 
--				SELECT
--				@four
--					UNION
--				SELECT
--				@five
--			) mt
--	)
--END

-- DROP FUNCTION NamderMinMax

SELECT 
	dbo.Minimal_And_Max(2 , 10 , 9 , 4 , 0)



/*
CREATE FUNCTION
 On2OrNot2(@A INT, @B INT, @C BIT)
RETURNS
  @range TABLE(numbers INT)
AS
BEGIN
  DECLARE @tmp INT = @A

  WHILE @tmp < @B
  BEGIN

    IF @tmp % 2 = 0 AND @C = 0
      INSERT INTO @range VALUES
        (@tmp)

    IF @tmp % 2 <> 0 AND @C = 1
      INSERT INTO @range VALUES
        (@tmp)

    SET @tmp = @tmp + 1

  END
  RETURN
END
*/

--SELECT
--	numbers AS [НеЧёт.]
--FROM
--	dbo.NumChetNotChet(-10, 0, 1)

--SELECT
--	numbers AS [Чёт.]
--FROM
--	dbo.NumChetNotChet(3, 6, 0)
