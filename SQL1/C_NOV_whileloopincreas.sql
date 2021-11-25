DECLARE @counter INT =1;
WHILE @counter <= 5
BEGIN
PRINT @counter;
SET @counter =@counter +1;
END
--int counter=1
--while(counter<=5)
--{
--printf("%d",counter);
--counter++
--....}