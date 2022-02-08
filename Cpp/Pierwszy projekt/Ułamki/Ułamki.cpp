#include <iostream>

class Ulamek
{
private:
	int licznik, mianownik;
public:
	Ulamek(int l, int m)
	{
		licznik = l;
		mianownik = m;
		SkrocUlamek();
	}

	void Wyswietl()
	{
		std::cout << licznik << "\\" << mianownik;
	}

#pragma region Operacje arytmetyczne - metody

	void Dodawanie(Ulamek u)
	{
		licznik = licznik * u.mianownik + u.licznik * mianownik;
		mianownik = mianownik * u.mianownik;
		SkrocUlamek();
	}

	Ulamek Dodawanie2(Ulamek u)
	{
		return Ulamek(licznik * u.mianownik + u.licznik * mianownik, mianownik * u.mianownik);
	}

	void Odejmowanie(Ulamek u)
	{
		licznik = licznik * u.mianownik - u.licznik * mianownik;
		mianownik = mianownik * u.mianownik;
		SkrocUlamek();
	}

	Ulamek Odejmowanie2(Ulamek u)
	{
		return Ulamek(licznik * u.mianownik - u.licznik * mianownik, mianownik * u.mianownik);
	}

	void Mnozenie(Ulamek u)  //ulamek1.Mnozenie(ulamek2);  ulamek1 = ulamek1 * ulamek2;
	{
		licznik = licznik * u.licznik;
		mianownik = mianownik * u.mianownik;
		SkrocUlamek();
	}

	Ulamek Mnozenie2(Ulamek u)  //ulamek3 = ulamek1.Mnozenie2(ulamek2);  ulamek3 = ulamek1 * ulamek2;
	{
		return Ulamek(licznik * u.licznik, mianownik * u.mianownik);
	}

	void Dzielenie(Ulamek u)
	{
		licznik = licznik * u.mianownik;
		mianownik = mianownik * u. licznik;
		SkrocUlamek();
	}

	Ulamek Dzielenie2(Ulamek u)
	{
		return Ulamek(licznik * u.mianownik, mianownik * u.licznik);
	}

#pragma endregion

#pragma region Operacje arytmetyczne - operatory

	Ulamek operator+(Ulamek u) //ulamek3 = ulamek1 - ulamek2;
	{
		return Ulamek(licznik * u.mianownik + u.licznik * mianownik, mianownik * u.mianownik);
	}

	Ulamek operator-(Ulamek u) //ulamek3 = ulamek1 - ulamek2;
	{
		return Ulamek(licznik * u.mianownik - u.licznik * mianownik, mianownik * u.mianownik);
	}

	Ulamek operator*(Ulamek u)
	{
		return Ulamek(licznik * u.licznik, mianownik * u.mianownik);
	}

	Ulamek operator*(int u)
	{
		return Ulamek(licznik * u, mianownik * 1);
	}

	Ulamek operator/(Ulamek u)
	{
		return Ulamek(licznik * u.mianownik, mianownik * u.licznik);
	}

#pragma endregion

#pragma region Operatory porównania

	bool operator>(Ulamek u)
	{
		if (licznik * u.mianownik > u.licznik * mianownik)
			return true;
		return false;
	}

	bool operator<(Ulamek u)
	{
		if (licznik * u.mianownik < u.licznik * mianownik)
			return true;
		return false;
	}

	bool operator==(Ulamek u)
	{
		if (licznik * u.mianownik == u.licznik * mianownik)
			return true;
		return false;
	}

	bool operator==(int u)
	{
		if (licznik * 1 == u * mianownik)
			return true;
		return false;
	}

#pragma endregion
	
	void SkrocUlamek()
	{
		int a = licznik;
		int b = mianownik;

		while (b != 0)
		{
			int tmp = a;
			a = b;
			b = tmp % b;
		}
		//NWD = a
		if (a != 1 && a != -1 && a !=0)
		{
			licznik = licznik / a;
			mianownik = mianownik / a;
		}
	}
};


int main()
{
	float u1 = 0.333;
	float u2 = 0.75;

	float u3 = u1 * u2;

	Ulamek ulamek1(1, 3);
	Ulamek ulamek2(3, 4);

	Ulamek ulamek3 = ulamek1 * ulamek2; //ulamek1.operator *(ulamek2);
	ulamek3.Wyswietl();
	std::cout << "\n";

	if (ulamek1 == 5)
	{
		std::cout << "Wiekszy jest ";
		ulamek1.Wyswietl();
		std::cout << "\n";
	}
	else
	{
		std::cout << "Wiekszy jest ";
		ulamek2.Wyswietl();
		std::cout << "\n";
	}
}
