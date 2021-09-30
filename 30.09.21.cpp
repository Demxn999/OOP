1
#include <iostream>
using namespace std;
int main()
{
    int a, b, c;
    cout << "Enter a,b,c:";
    cin >> a >> b >> c;
    int tmp = a;
    a = b;
    b = c;
    c = tmp;
    cout << b << " " << a << " " << c;
    return 0;
}

1 сек, 625 кб




2.1

#include <iostream>
using namespace std;
void main()
{
    char a, b;
    cout << "vvedite a: "<<'\n';
    cin >> a;
    cout << "vvedite b: " << '\n';
    cin >> b;
    if ((a <= '9') && (a >= '1') && (b <= '9') && (b >= '1')) {
       
        cout << "vi vveli 4islo" << '\n';
       
    }
    else
        cout << "vvedite snova" << '\n';
}


3.1


#include <iostream>
#include <cmath>
using namespace std;
int main()
{

   int x, y;
   while (true) {
        cout << "Enter x from 0 to 100: ";
        cin >> x;
        if (x < 0 || x > 100) {
            cout << "Error, try again" << endl;
        continue;
        }
    y = 5;
    cout << "X^5 = " << pow(x, y);
    return 0;
    }
}

629 кб и 1с


3.2
#include <iostream>
#include <cmath>
using namespace std;
int main()
{
        int x, y;
        cout << "Enter x from 0 to 100: ";
        cin >> x;
        y = x * x * x * x * x;
        cout << y;
        return 0;
    }

638кб памяти, чуть меньше секунды





5

#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
	int month;
	cout << "enter number of the month"<<'\n';
	cin >> month;
	if (month < 3 || month == 12) 
		cout<<"Winter";
	else if (month < 6) 
		cout<<"Spring";
	else if (month < 9) 
		cout<<"Summer";
	else if (month < 12)
		cout<<"Autumn";
	else cout<<"Error";
}


6
#include <iostream>
using namespace std;
int main() {
    int N, a = 1, sum = 0, k1 = 0, k2 = 0;
    cout << "Enter N" << endl;
    cin >> N;
    int n1 = N + 1;
    while (a < n1) {
        sum += a;
        int a1 = a;
        if (a1 % 2 == 0) {
            k1++;
        }
        else {
            k2++;
        }
        a++;
    }
    cout << sum << " " << k1 << " " << k2;
}

 4
#include <iostream>
using namespace std;

int main() {
	setlocale(LC_ALL, "RUSSIAN");
	int min = 0, max = 250, number;

	while (true) {
		cout<< "Введите число: ";
		cin>> number;

		if ((number >= min) && (number <= max)) {
			break;
		}
		else {
			cout<< endl<< "Число вне диапазона. Попробуйте еще раз";
		}
	}

	int i, x, y, z;
	bool b;
	x = y = z = 1;
	b = 0;

	for (i = 1; i < number; i++)
	{
		y = x;
		x = z;
		z = y + x;
		if (z == number) { b = 1; }
	}
	if (b) { cout<< "Это число Фибоначчи"<< endl; }
	else { cout<< "Это не число Фибоначчи"<< endl; };
	system("pause");
	return 0;
}


8
#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Russian");
    int a1 = 0;
    int a2 = 0;

    cout << "Введите два числа: ";
    cin >> a1 >> a2;

    if (a1 > a2)
    {
        int tmp = a2;
        a2 = a1;
        a1 = tmp;
    }

    cout << "Пифагоровы тройки чисел от "
        << a1 << " до " << a2 << " включительно:" << endl;
    for (int i = a1; i <= a2; i++)
    {
        for (int j = a1; j <= a2; j++)
        {
            for (int k = a1; k <= a2; k++)
            {
                if (i * i + j * j == k * k)
                    cout << "{" << i << ";" << j << ";" << k << "}" << endl;
            }
        }
    }

    return 0;
}

7
#include <iostream>
using namespace std;
int main() {
    int N, a = 0, k = 0;
    cout << "Enter N" << endl;
    cin >> N;
    if (N < 250) {
        int n1 = N + 1;
        while (a < n1) {
            a++;
            if (N % a == 0)
                k++;
        }
    }
    cout << k;
}

11

#include <iostream>
using namespace std;
int main() {
    int a;
    int A[10] = { 1,2,3,4,5,6,7,8,9,10 };
    for (int i = 0; i < 10; i++) {
        a = A[i];
    }
    cout << a << endl;
}


12

#include <iostream>
using namespace std;
int main() {
    int A[] = { 1,2,3,4,5,6,7,8,9,10};
    int i = 0;
    int N = 10;
    for (int i = N - 1; i + 1; i--)
        cout << A[i] << ' ';
}

