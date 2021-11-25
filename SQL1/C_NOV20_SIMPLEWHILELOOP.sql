DECLARE @counter INT =5;
WHILE @counter = 1
BEGIN
PRINT @counter;
SET @counter =@counter -1;
END
--int counter=1
--while(counter<=5)
--{
--printf("%d",counter);
--counter++
--....}