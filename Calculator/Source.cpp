#include<iostream>
using namespace std;
int main()
{
	int ch, a, b, sum = 0, prd = 0, quo = 0, rem = 0, res = 0;
	cout << "Simple calculator v0.1 beta\n\n";
	cout << "\nPlease note that this calculator ONLY supports operations like a+b,a*b,etc!\n";
	cout << "\nEnter two numbers: ";
	cin >> a >> b;
	cout << "\n1. Add\n2. Subtract\n3. Quotient\n4. Remainder\n5. Product\n";
	LOOP:cout << "\nEnter your choice: ";
	cin >> ch;
	if (ch == 1)
	{
		sum = a + b;
		cout << "Result = " << sum << endl;
	}
	else if (ch == 2)
	{
		res = a - b;
		cout << "Result = " << res << endl;
	}
	else if (ch == 3)
	{
		quo = a / b;
		cout << "Result = " << quo << endl;
	}
	else if (ch == 4)
	{
		rem = a % b;
		cout << "Result = " << rem << endl;
	}
	else if (ch == 5)
	{
		prd = a * b;
		cout << "Result = " << prd << endl;
	}
	else
	{
		cout << "Invalid choice, please enter a valid choice.\n";
		goto LOOP;
	}
	return 0;
}