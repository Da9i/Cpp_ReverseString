#include<iostream>
using namespace std;
int main()
{
	char a[] = "This is a text code";
	char *ptr;
	int length = strlen(a);
	for (int i = length; i >= 0; i--)
	{
		ptr = &a[i];
		cout << *ptr;
	}
	system("pause>0");
}
