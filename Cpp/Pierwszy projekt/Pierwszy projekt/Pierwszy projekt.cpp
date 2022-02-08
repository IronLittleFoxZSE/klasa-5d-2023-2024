#include <iostream>

namespace OsobaV1
{
	void FunkcjaGlowna()
	{
		std::string imie, nazwisko;
		short wiek;

		std::cout << "Podaj imie\n";
		std::cin >> imie;
		std::cout << "Podaj nazwisko\n";
		std::cin >> nazwisko;
		std::cout << "Podaj wiek\n";
		std::cin >> wiek;

		std::cout << "Podano:\n";
		std::cout << "Dane: " << imie << " " << nazwisko << "\n";
		std::cout << "Wiek: " << wiek << "\n";
	}
}

namespace OsobaV2
{
	void FunkcjaGlowna()
	{
		std::string imie[3], nazwisko[3];
		short wiek[3];

		for (int i = 0; i <= 2; i++)
		{
			std::cout << "Podaj imie\n";
			std::cin >> imie[i];
			std::cout << "Podaj nazwisko\n";
			std::cin >> nazwisko[i];
			std::cout << "Podaj wiek\n";
			std::cin >> wiek[i];
		}

		for (int i = 0; i <= 2; i++)
		{
			std::cout << "Podano:\n";
			std::cout << "Dane: " << imie[i] << " " << nazwisko[i] << "\n";
			std::cout << "Wiek: " << wiek[i] << "\n";
		}

		for (int i = 0; i < 3; i++)
			for (int j = 0; j < 2; j++)
			{
				if (wiek[j] > wiek[j + 1])
				{
					int tmpWiek = wiek[j];
					wiek[j] = wiek[j + 1];
					wiek[j + 1] = tmpWiek;

					std::string tmpImie = imie[j];
					imie[j] = imie[j + 1];
					imie[j + 1] = tmpImie;

					std::string tmpNazwisko = nazwisko[j];
					nazwisko[j] = nazwisko[j + 1];
					nazwisko[j + 1] = tmpNazwisko;
				}
			}

		std::cout << "------------------------\n";
		std::cout << "Po posortowaniu:\n";
		for (int i = 0; i <= 2; i++)
		{
			std::cout << "Podano:\n";
			std::cout << "Dane: " << imie[i] << " " << nazwisko[i] << "\n";
			std::cout << "Wiek: " << wiek[i] << "\n";
		}
	}
}

namespace OsobaV3
{
	void Wyswietl(std::string imie[], std::string nazwisko[], short wiek[], int rozmiar)
	{
		for (int i = 0; i < rozmiar; i++)
		{
			std::cout << "Podano:\n";
			std::cout << "Dane: " << imie[i] << " " << nazwisko[i] << "\n";
			std::cout << "Wiek: " << wiek[i] << "\n";
		}
	}
	void FunkcjaGlowna()
	{
		std::string imie[3], nazwisko[3];
		short wiek[3];

		for (int i = 0; i <= 2; i++)
		{
			std::cout << "Podaj imie\n";
			std::cin >> imie[i];
			std::cout << "Podaj nazwisko\n";
			std::cin >> nazwisko[i];
			std::cout << "Podaj wiek\n";
			std::cin >> wiek[i];

		}

		Wyswietl(imie, nazwisko, wiek, 3);

		for (int i = 0; i < 3; i++)
			for (int j = 0; j < 2; j++)
			{
				if (wiek[j] > wiek[j + 1])
				{
					int tmpWiek = wiek[j];
					wiek[j] = wiek[j + 1];
					wiek[j + 1] = tmpWiek;

					std::string tmpImie = imie[j];
					imie[j] = imie[j + 1];
					imie[j + 1] = tmpImie;

					std::string tmpNazwisko = nazwisko[j];
					nazwisko[j] = nazwisko[j + 1];
					nazwisko[j + 1] = tmpNazwisko;
				}
			}

		std::cout << "------------------------\n";
		std::cout << "Po posortowaniu:\n";
		Wyswietl(imie, nazwisko, wiek, 3);
	}
}

namespace OsobaV4
{
	void wyswietl(std::string imie, std::string nazwisko, short wiek)
	{
		std::cout << "Podano:\n";
		std::cout << "Dane: " << imie << " " << nazwisko << "\n";
		std::cout << "Wiek: " << wiek << "\n";
	}

	void FunkcjaGlowna()
	{
		std::string imie, nazwisko;
		short wiek;

		std::cout << "Podaj imie\n";
		std::cin >> imie;
		std::cout << "Podaj nazwisko\n";
		std::cin >> nazwisko;
		std::cout << "Podaj wiek\n";
		std::cin >> wiek;

		wyswietl(imie, nazwisko, wiek);
	}
}

namespace OsobaV5
{
	struct Osoba
	{
		std::string imie, nazwisko;
		short wiek;
	};
	void wyswietl(Osoba o)
	{
		std::cout << "Podano:\n";
		std::cout << "Dane: " << o.imie << " " << o.nazwisko << "\n";
		std::cout << "Wiek: " << o.wiek << "\n";
	}

	void FunkcjaGlowna()
	{
		Osoba osoba_1;

		std::cout << "Podaj imie\n";
		std::cin >> osoba_1.imie;
		std::cout << "Podaj nazwisko\n";
		std::cin >> osoba_1.nazwisko;
		std::cout << "Podaj wiek\n";
		std::cin >> osoba_1.wiek;

		wyswietl(osoba_1);
	}
}

namespace OsobaV6
{
	class Osoba
	{
	private:
		std::string imie, nazwisko;
		short wiek;
	
	public:
		void Wyswietl()
		{
			std::cout << "Podano:\n";
			std::cout << "Dane: " << imie << " " << nazwisko << "\n";
			std::cout << "Wiek: " << wiek << "\n";
		}
	private:

	};

	void FunkcjaGlowna()
	{
		//Osoba osoba_1 = new Osoba();
		Osoba osoba_1;

		std::cout << "Podaj imie\n";
		std::cin >> osoba_1.imie;
		std::cout << "Podaj nazwisko\n";
		std::cin >> osoba_1.nazwisko;
		std::cout << "Podaj wiek\n";
		std::cin >> osoba_1.wiek;

		osoba_1.Wyswietl();
	}
}

int main()
{
	//std::cout << "Hello World!\n";
	OsobaV6::FunkcjaGlowna();
}

