#include<iostream>
#include <stdlib.h>     
#include <time.h>
using namespace std;

const int SIZE = 10;

struct Bus
{
	int number;
	int passengers;
	char line;
};

void inputBuses(Bus * buses)
{
	srand(time(NULL));
	Bus bus;
	int number;
	int pass;
	char line;
	for (int i = 0; i < SIZE; i++)
	{	
			int Rnumber = rand() % 3 ;
			switch (Rnumber)
			{
			case 0: 
				bus.line = 'A';
				break;
			case 1:
				bus.line = 'B';
				break;
			case 2:
				bus.line = 'C';
				break;
			default:
				bus.line = 'A';
				break;
			}
	
			bus.passengers =  rand() % 80 + 1;
			bus.number = rand() % 1000 ;
		
		buses[i] = bus;
	}
}

void countPass(Bus* buses)
{
	int count = 0;
	for (int i = 0; i < SIZE; i++)
	{
		count += buses[i].passengers;
	}
	std::cout << "\n\n(All) Passengers: " << count;
}

void countPassOnLines(Bus* buses)
{
	int countA = 0;
	int countB = 0;
	int countC = 0;
	for (int i = 0; i < SIZE; i++)
	{
		switch (buses[i].line)
		{
		case 'A':
			countA += buses[i].passengers;;
			break;
		case 'B':
			countB += buses[i].passengers;;
			break;
		case 'C':
			countC += buses[i].passengers;;
			break;
		default:
			break;
		}
	}
	std::cout << "\n\n(Line A) Passengers: " << countA;
	std::cout << "(Line B) Passengers: " << countB;
	std::cout << "(Line C) Passengers: " << countC;
}

void countAvgPassOnLines(Bus* buses)
{
	int countPassA = 0;
	int countPassB = 0;
	int countPassC = 0;

	int Acount = 0;
	int Bcount = 0;
	int Ccount = 0;
	for (int i = 0; i < SIZE; i++)
	{
		switch (buses[i].line)
		{
		case 'A':
			Acount++;
			countPassA += buses[i].passengers;
			break;
		case 'B':
			Bcount++;
			countPassB += buses[i].passengers;
			break;
		case 'C':
			countPassC += buses[i].passengers;
			Ccount++;
			break;
		default:
			break;
		}
	}
	if(countPassA != 0)
	std::cout << "\n\n(Line A) Avg Passengers: " << countPassA / Acount;
	if (countPassB != 0)
	std::cout << "(Line B) Avg Passengers: " << countPassB / Bcount;
	if (countPassC != 0)
	std::cout << "(Line C) Avg Passengers: " << countPassC / Ccount;
}

int main() {
	
	Bus buses[10];

	

	inputBuses(buses);

	for (int i = 0; i < SIZE; i++)
	{
		std::cout << "Passengers: " << buses[i].passengers << endl;
		std::cout << "Number: " << buses[i].number << endl;
		std::cout << "Line: "  << buses[i].line << endl;
	}
	countPass(buses);
	countPassOnLines(buses);
	countAvgPassOnLines(buses);
	
	
	
	return 0;
}