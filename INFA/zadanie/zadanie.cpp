#include <iostream>
#include <cmath>
using namespace std;
int dziesietny, x = 0, y, wypisywanie;

int main()
{
	cout << "Podaj liczbe w sysytemie dziesietnym: ";
	cin >> dziesietny;

	wypisywanie = dziesietny;
	y = dziesietny;
	while (y > 0)
	{
		y = y / 2;
		x++;
	}

	int T[x];
	x = -1;

	while (dziesietny > 0)
	{
		x++;
		T[x] = dziesietny % 2;
		dziesietny = dziesietny / 2;
	}

	cout << "(" << wypisywanie << ")"
		 << " W systemie binarnym to: ";

	while (x >= 0)
	{
		cout << T[x];
		x--;
	}

	return 0;
}