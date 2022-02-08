#include <iostream>

class KontoBankowe
{
private:
	std::string imie, nazwisko;
	std::string numerKonta;
	std::string haslo;
	float saldo;

	bool czyZalogowano;

public:
	KontoBankowe(std::string i, std::string n, std::string nK, std::string h)
	{
		imie = i;
		nazwisko = n;
		numerKonta = nK;
		haslo = h;
		saldo = 0;
		czyZalogowano = false;
	}

	void Loguj(std::string h)
	{
		//czyZalogowano = (haslo == h);
		if (haslo == h)
			czyZalogowano = true;
	}

	void Info()
	{
		if (czyZalogowano)
		{
			std::cout << "------------------------------\n";
			std::cout << "Wlasciciel " << imie << " " << nazwisko << "\n";
			std::cout << "Numer konta " << numerKonta << "\n";
			std::cout << "Saldo " << saldo << "\n";
			std::cout << "------------------------------\n";
		}
		else
			std::cout << "Nie zalogowano do konta\n";
	}

	void Wplata(float kwota)
	{
		if (kwota > 0)
			saldo += kwota;
	}

	bool Wyplata(float kwota)
	{
		if (kwota > 0 && saldo >= kwota && czyZalogowano)
		{
			saldo -= kwota;
			return true;
		}
		return false;
	}

	void Przelew(float kwota, KontoBankowe& kontoDocelowe)
	{
		if (Wyplata(kwota))
		{
			kontoDocelowe.Wplata(kwota);
			//kontoDocelowe.saldo += kwota;
		}
	}

};


int main()
{
	KontoBankowe konto("Jan", "Kowalski", "001", "1234");
	konto.Loguj("1234");
	//konto.Loguj("123");
	//konto.Info();
	konto.Wplata(100);
	konto.Info();

	KontoBankowe konto2("Paweł", "Nowak", "002", "4321");
	konto2.Loguj("4321");
	konto2.Info();

	konto.Przelew(250, konto2);
	konto.Info();
	konto2.Info();

	//konto.saldo = 15;
}
