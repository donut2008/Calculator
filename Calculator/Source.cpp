#include<iostream>
#include<math.h>
#include<conio.h>
using namespace std;
int main()
{
	int ch, a, b, sum = 0, prd = 0, quo = 0, rem = 0, res = 0;
	cout << "Simple calculator v0.3 beta\n\n";
	cout << "\nThis calculator only supports operations in a/b format.\n\n";
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
	cout << "\n1. Add\n2. Subtract\n3. Quotient\n4. Remainder\n5. Product\n6. Square root\n7. Cube root\n8. Exponent (a^b)\n";
LOOP:cout << "\nEnter your choice: ";
	cin >> ch;
	if (ch == 1)
	{
		sum = a + b;
		cout << "Result = " << sum << endl << endl;
	}
	else if (ch == 2)
	{
		res = a - b;
		cout << "Result = " << res << endl << endl;
	}
	else if (ch == 3)
	{
		quo = a / b;
		cout << "Result = " << quo << endl << endl;
	}
	else if (ch == 4)
	{
		rem = a % b;
		cout << "Result = " << rem << endl << endl;
	}
	else if (ch == 5)
	{
		prd = a * b;
		cout << "Result = " << prd << endl << endl;
	}
	else if (ch == 6)
	{
		cout << "Square root of " << a << " is " << sqrt(a) << endl;
		cout << "Square root of " << b << " is " << sqrt(b) << endl << endl;
	}
	else if (ch == 7)
	{
		cout << "Cube root of " << a << " is " << cbrt(a) << endl;
		cout << "Cube root of " << b << " is " << cbrt(b) << endl << endl;
	}
	else if (ch == 8)
		cout << "Result = " << pow(a, b) << endl << endl;
	else
	{
		cout << "Invalid choice, please enter a valid choice.\n";
		goto LOOP;
	}
	cout << "Press any key to exit.";
	_getch();
	return 0;
}