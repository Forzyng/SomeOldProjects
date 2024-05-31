SELECT
   S.*
FROM
   Sales AS S
WHERE 
     CAST (S.Moment AS DATE) > '2020-06-01'
   AND
     CAST (S.Moment AS DATE) < DATEADD(MONTH, 1, '2020-06-01')
   AND
     S.ID_manager = '521C07BE-6FBD-411F-BCCB-93E2672BD50E'
   AND
     S.ID_product = '7B08197B-C55F-4389-891F-BF12A575DFFB'
ORDER BY
     S.Cnt DESC
   
   -- S.Moment BETWEEN '2020-06-15' AND DATEADD(Day, 1, '2020-06-15')
   -- S.Moment BETWEEN '2020-06-15' AND '2020-06-16'

   /*
   S.Moment >= '2020-06-15'
   AND
   S.Moment < '2020-06-16'
   */