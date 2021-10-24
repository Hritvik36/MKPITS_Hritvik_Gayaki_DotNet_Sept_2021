#include<stdio.h>
void Dollar_Rs(int);
int main()
{
 int Dollar;
     printf("\nenter the dollar");
	    scanf("%d",&Dollar);
		Dollar_Rs(Dollar);
return 0;
}

/* 2 step */
 void Dollar_Rs(int Dollar)
 {
 float Rs=74.99*Dollar;
 
 
 printf("%d Dollar= %.3f Rs",Dollar,Rs);
 
 }

