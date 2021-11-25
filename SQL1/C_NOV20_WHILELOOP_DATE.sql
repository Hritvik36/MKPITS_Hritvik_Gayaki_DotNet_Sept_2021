DECLARE @myTable TABLE(WeekNumber int,DateStarting smalldatetime)
DECLARE @n int = 0
DECLARE @firstWeek smalldatetime ='11/01/2021'

--Loop Through Weeks
WHILE @n <=4
BEGIN
  INSERT INTO @myTable VALUES (@n,DATEADD(wk,@n,@firstweek));
  SEt @n = @n + 1
END

--show results
select Weeknumber,Datestarting from @myTable