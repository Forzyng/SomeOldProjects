﻿-- SELECT ABS ( CHECKSUM( NEWID() ) ) % 100
SELECT 
'2021-05-10'
+ DATEADD(DAY, ABS ( CHECKSUM( NEWID() ) ) % 365, 0)

+ DATEADD(MINUTE, + ABS ( CHECKSUM( NEWID() ) ) % 1440, 0)
+ DATEADD(SECOND,  ABS ( CHECKSUM( NEWID() ) ) % 60, 0)
-- + DATEADD(MINUTE, 480 + ABS ( CHECKSUM( NEWID() ) ) % 720, 0)