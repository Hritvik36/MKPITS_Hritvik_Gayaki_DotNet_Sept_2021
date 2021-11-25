create procedure SPaddstudentmarks(@r int,@e int,@m int,@s int)
as begin
update student set eng=@e,maths=@m,sci=@s where Roll_no=@r;
end
exec SPaddstudentmarks 1,15,16,17
exec SPaddstudentmarks 2,35,40,55
select * from student
