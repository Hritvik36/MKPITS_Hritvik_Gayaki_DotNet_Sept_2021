/*while loop example to display 1 to 100 numbers */
#include<stdio.h>
int main()
{
 int i=1,sum=0;
 while(i<=100)
 {
 printf("%4d",i);
 sum+=i;
 i++;
 
 }
 printf("\nsum is =%d",sum);
 return 0;
 }

