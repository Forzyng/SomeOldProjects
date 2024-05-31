// word_count.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <fstream>
#include <string>
#include <map>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Rus");
    ifstream file("text.txt");
    if (!file)
    {
        std::cout << "Файл не может быть открыт.\n";
        system("pause");
        return -1;
    }
    string word;
    map<string, int> words;
    char c;
    while (file >> word)
    {
        file.get(c);
        cout << word << c;
        words[word]++;
    }
    cout << "\n\nСлово\tКоличество повторений\n";
    map<string, int>::iterator it;
    for (it = words.begin(); it != words.end(); it++)
    {
        cout << it->first << "\t\t" << it->second << endl;
    }
    ofstream out("result.txt");
    out << "Слово\tКоличество повторений\n";
    map<string, int>::iterator it2;
    for (it2 = words.begin(); it2 != words.end(); it2++)
    {
        out << it2->first << "\t\t" << it2->second << endl;
    }
    system("pause");
    return 0;
}