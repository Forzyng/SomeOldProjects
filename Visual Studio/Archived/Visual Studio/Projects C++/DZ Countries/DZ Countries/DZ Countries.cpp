
#include <string>
#include <map>
#include <iostream>
#include <fstream>
#include <algorithm>
#include <Windows.h>
#include <locale>

int main()
{
    setlocale(LC_ALL, "Rus");

    bool checker = true;
    int choose;

    while (checker)
    {
        system("cls");
        std::cout
            << "1) Add \n"
            << "2) Find \n"
            << "3) Exit \n";

        std::cout << "Enter option - > ";
        std::cin >> choose;
        std::cout << "\n\n";
        switch (choose)
        {

        case 1:
        {
            int i;
            char city[25];
            char country[25];

            std::ofstream cout("Dictionary", std::ios::app);
            do
            {
                std::cout << "Continue(1) Stop(0) -> ",
                    std::cin >> i;
                fflush(stdin);
                if (!i || i == 0)
                {
                    break;
                }

                std::cout << "\n";
                std::cout << "\n";
                std::cout << "Enter city -> ";
                std::cin >> city;

                std::cout << "\n";
                std::cout << "Enter country -> ";
                std::cin >> country;

                cout << "\n" << country << " " << city;
                std::cout << "\n\n";

            } while (i || i == 0);
            break;
        }

        case 2:
        {
            std::ifstream Read_File("Dictionary");
            std::string str1, str2;

            std::map < std::string, std::string> dictionar;

            while (Read_File >> str1 >> str2)
            {

                dictionar[str1] = str2;
                dictionar[str2] = str1;
            }

            Read_File.close();

            /*while (1)
            {*/
            std::cout << "Enter country or city -> ";
            std::cin >> str1;

            if (dictionar.find(str1) != dictionar.end())
            {
                std::cout << "It`s match with -> ";
                std::cout << dictionar[str1] << std::endl;
            }
            else
            {
                std::cout << "0 Results" << std::endl;
            }

            system("pause");
            /*}*/

            break;
        }

        case 3:
        {
            checker = false;
            break;
        }


        }
    }
}
