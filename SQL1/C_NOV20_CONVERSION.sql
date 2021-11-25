SELECT 1 + '1' AS result;--implicit conversion
SELECT 1 + CAST('1' AS INT) result;--explicit conversion
select 1 + 10 result;
select 100+ cast('abc50' as int)result;--can not convert explicity also bacause it is not pure number(abc50)

select cast(5.95 as int)result;---float to int
select cast('3.13945' as dec(10,2)) result;--string to decinal
select cast('1/15/2021' as smalldatetime) result;--string to date


select cast(5.95 as int) result--float to int
select convert(money,9) result--int to money
select convert(datetime,'01/13/2020')result--string to datetime
select convert(smalldatetime,'01/13/2020')result--string to smalldatetime
select convert(varchar(13),'2020-01-20 00:00:00.000')result
select convert(varchar(13),getdate())result