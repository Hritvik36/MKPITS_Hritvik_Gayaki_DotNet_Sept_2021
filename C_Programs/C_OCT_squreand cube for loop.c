#include<stdio.h>
int main()
{
int i=1,n;
printf("enter the number 1 to n");
scanf("%d",&n);
printf("\n  num square cube");
for(;i<=n;i++)
{

printf("\n%5d%5d%5d",i,i*i,i*i*i);
}
return 0;
}

