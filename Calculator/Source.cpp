#include<iostream>
#include<math.h>
#include<conio.h>
using namespace std;
int main()
{
	int ch, a, b, sum = 0, prd = 0, quo = 0, rem = 0, res = 0;
	cout << "Simple calculator v0.2 alpha\n\n";
	cout << "\nNote about this calculator: Currently only supports operations like a+b, a-b, a*b etc.\n\n";
INPUT:cout << "Enter two numbers: ";
	cin >> a;
	if (!cin)
	{
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
		cout << "Please enter two valid numbers.\n\n";
		goto INPUT;
	}
	cin >> b;
	if (!cin)
	{
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
		cout << "Please enter two valid numbers.\n\n";
		goto INPUT;
	}
	cout << "\n1. Add\n2. Subtract\n3. Quotient\n4. Remainder\n5. Product\n6. Square root\n";
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
	else if (ch == 6)
	{
		cout << "Square root of " << a << " is " << sqrt(a) << endl;
		cout << "Square root of " << b << " is " << sqrt(b);
	}
	else
	{
		cout << "Invalid choice, please enter a valid choice.\n";
		goto LOOP;
	}
	cout << "Press any key to exit.";
	_getch();
	return 0;
}