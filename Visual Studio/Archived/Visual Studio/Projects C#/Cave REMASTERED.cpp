#include <iostream>
#include "windows.h"
#include <string>
#include <fstream>
#include <iomanip>
#include <math.h>
#include <ctime>
#include <cstdlib>
#include <time.h>
using namespace std;


//---------------------------------------------------------------------------------------
//void HeroUr(string Class_Hero)
//{
//    if (Class_Hero == "Warrior")
//    {
//        std::cout << "                        ¶¶                           \n";
//        std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶¶              ¶     \n";
//        std::cout << "                     ¶¶¶¶¶¶¶    ¶¶¶            ¶     \n";
//        std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶           ¶¶    \n";
//        std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶$¶¶¶¶           ¶¶    \n";
//        std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶  ¶            ¶¶    \n";
//        std::cout << "                      ¶¶¶o¶¶¶¶¶¶¶¶             ¶¶    \n";
//        std::cout << "                      ¶¶__¶¶¶¶¶¶¶_¶¶¶          ¶¶    \n";
//        std::cout << "                     q¶¶¶¶¶¶¶¶¶¶¶3¶¶¶_¶¶       ¶¶    \n";
//        std::cout << "                  ¶v¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶8_¶       ¶¶    \n";
//        std::cout << "               _$¶¶$¶¶¶¶¶¶8____¶¶¶___¶¶¶       ¶¶    \n";
//        std::cout << "              ¶o¶_¶¶¶¶¶¶¶¶¶3___¶¶¶_¶¶¶¶¶¶      ¶¶    \n";
//        std::cout << "             ¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶      ¶¶    \n";
//        std::cout << "          ¶¶¶¶¶¶¶¶    ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶    ¶¶    \n";
//        std::cout << "         ¶__¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶  ¶¶¶¶   \n";
//        std::cout << "         8_¶¶¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶¶   ¶¶¶¶¶¶¶¶¶¶¶¶¶ \n";
//        std::cout << "            ¶¶¶¶¶¶    ¶¶¶¶¶¶¶8___¶¶¶       ¶¶¶¶¶¶¶¶¶ \n";
//        std::cout << "            ¶¶¶¶¶¶  ¶¶¶¶¶¶¶¶¶¶oo¶¶¶¶      ¶¶¶¶¶¶8¶¶¶ \n";
//        std::cout << "              ¶¶¶¶ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶¶¶   \n";
//        std::cout << "               ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶    \n";
//        std::cout << "                 ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶               \n";
//        std::cout << "                ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶                \n";
//        std::cout << "                ¶¶__o¶¶¶¶¶   ¶¶¶¶¶o_8¶               \n";
//        std::cout << "                ¶3___¶¶¶¶     ¶¶¶¶___¶               \n";
//        std::cout << "                ¶¶_q¶¶¶¶      ¶¶¶¶¶_¶¶               \n";
//        std::cout << "               ¶¶¶¶¶¶¶¶        ¶¶¶¶¶¶¶q              \n";
//        std::cout << "             ¶__o¶¶¶¶           ¶¶¶$                 \n";
//        std::cout << "             ¶_v¶¶¶             ¶¶¶¶¶o¶              \n";
//        std::cout << "             ¶¶¶¶¶3             ¶¶¶¶¶¶               \n";
//        std::cout << "            ¶__¶¶¶v             ¶¶¶¶o                \n";
//        std::cout << "           ¶__¶¶¶¶               ¶¶¶¶¶q              \n";
//        std::cout << "            ¶¶¶¶¶                 ¶¶¶_¶_¶            \n";
//        std::cout << "          ¶¶¶¶¶                    ¶¶¶¶_¶            \n";
//        std::cout << "         ¶¶¶¶                      ¶¶¶¶q¶¶           \n";
//        std::cout << "        ¶¶¶¶¶¶                      ¶¶¶¶_¶8¶¶¶       \n";
//        std::cout << "    ¶¶8¶8¶¶¶¶¶                         ¶¶¶¶¶¶¶¶¶     \n\n\n";
//    }
//    if (Class_Hero == "Archer")
//    {
//        std::cout << "                        ¶¶                           \n";
//        std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶¶                    \n";
//        std::cout << "                     ¶¶¶¶¶¶¶    ¶¶¶                  \n";
//        std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶                 \n";
//        std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶$¶¶¶¶    ¶¶           \n";
//        std::cout << "             ^   ^   ¶¶¶¶¶¶¶¶¶¶¶  ¶     | ¶8         \n";
//        std::cout << "             |   |    ¶¶¶o¶¶¶¶¶¶¶¶      |  ¶¶        \n";
//        std::cout << "             |   |    ¶¶__¶¶¶¶¶¶¶_¶¶¶   |   ¶¶       \n";
//        std::cout << "           ¶¶v_$¶¶v  q¶¶¶¶¶¶¶¶¶¶¶3¶¶¶_¶¶|    ¶8      \n";
//        std::cout << "            ¶¶v_$¶¶v¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶8_¶|     ¶¶     \n";
//        std::cout << "            ¶¶v_$¶¶$¶¶¶¶¶¶8____¶¶¶___¶¶¶       ¶¶    \n";
//        std::cout << "              ¶o¶_¶¶¶¶¶¶¶¶¶3___¶¶¶_¶¶¶¶¶¶       ¶¶   \n";
//        std::cout << "             ¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶        ¶¶  \n";
//        std::cout << "          ¶¶¶¶¶¶¶¶    ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶      ¶q$¶\n";
//        std::cout << "        ¶___¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶     ¶q$¶\n";
//        std::cout << "         8_¶¶¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶¶   ¶¶¶¶¶¶¶¶¶¶¶¶¶ \n";
//        std::cout << "            ¶¶¶¶¶¶    ¶¶¶¶¶¶¶8___¶¶¶    |  ¶¶¶¶¶¶¶¶¶ \n";
//        std::cout << "            ¶¶¶¶¶¶  ¶¶¶¶¶¶¶¶¶¶oo¶¶¶¶    | ¶¶¶¶¶¶8¶¶¶ \n";
//        std::cout << "              ¶¶¶¶ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶    |    ¶¶_o    \n";
//        std::cout << "               ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶   |   ¶¶       \n";
//        std::cout << "                 ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶  |  ¶¶        \n";
//        std::cout << "                ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶   | ¶¶         \n";
//        std::cout << "                ¶¶__o¶¶¶¶¶   ¶¶¶¶¶o_8¶  |¶¶          \n";
//        std::cout << "                ¶3___¶¶¶¶     ¶¶¶¶___¶ ¶¶            \n";
//        std::cout << "                ¶¶_q¶¶¶¶      ¶¶¶¶¶_¶¶               \n";
//        std::cout << "               ¶¶¶¶¶¶¶¶        ¶¶¶¶¶¶¶q              \n";
//        std::cout << "             ¶__o¶¶¶¶           ¶¶¶$                 \n";
//        std::cout << "             ¶_v¶¶¶             ¶¶¶¶¶o¶              \n";
//        std::cout << "             ¶¶¶¶¶3             ¶¶¶¶¶¶               \n";
//        std::cout << "            ¶__¶¶¶v             ¶¶¶¶o                \n";
//        std::cout << "           ¶__¶¶¶¶               ¶¶¶¶¶q              \n";
//        std::cout << "            ¶¶¶¶¶                 ¶¶¶_¶_¶            \n";
//        std::cout << "          ¶¶¶¶¶                    ¶¶¶¶_¶            \n";
//        std::cout << "         ¶¶¶¶                      ¶¶¶¶q¶¶           \n";
//        std::cout << "        ¶¶¶¶¶¶                      ¶¶¶¶_¶8¶¶¶       \n";
//        std::cout << "    ¶¶8¶8¶¶¶¶¶                         ¶¶¶¶¶¶¶¶¶     \n\n\n";
//    }
//    if (Class_Hero == "Wizard")
//    {
//        std::cout << "                        ¶¶                           \n";
//        std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶¶            ¶¶¶¶¶¶  \n";
//        std::cout << "                     ¶¶¶¶¶¶¶    ¶¶¶         ¶      ¶ \n";
//        std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶        ¶      ¶ \n";
//        std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶$¶¶¶¶         ¶¶¶¶¶¶  \n";
//        std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶  ¶            ¶¶    \n";
//        std::cout << "                      ¶¶¶o¶¶¶¶¶¶¶¶             ¶¶    \n";
//        std::cout << "                      ¶¶__¶¶¶¶¶¶¶_¶¶¶          ¶¶    \n";
//        std::cout << "                     q¶¶¶¶¶¶¶¶¶¶¶3¶¶¶_¶¶       ¶¶    \n";
//        std::cout << "                  ¶v¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶8_¶       ¶¶    \n";
//        std::cout << "               _$¶¶$¶¶¶¶¶¶8____¶¶¶___¶¶¶       ¶¶    \n";
//        std::cout << "              ¶o¶_¶¶¶¶¶¶¶¶¶3___¶¶¶_¶¶¶¶¶¶      ¶¶    \n";
//        std::cout << "             ¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶      ¶¶    \n";
//        std::cout << "          ¶¶¶¶¶¶¶¶    ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶    ¶¶    \n";
//        std::cout << "         ¶__¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶   ¶¶    \n";
//        std::cout << "         8_¶¶¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶¶   ¶¶¶¶¶¶¶¶¶¶¶¶¶ \n";
//        std::cout << "            ¶¶¶¶¶¶    ¶¶¶¶¶¶¶8___¶¶¶       ¶¶¶¶¶¶¶¶¶ \n";
//        std::cout << "            ¶¶¶¶¶¶  ¶¶¶¶¶¶¶¶¶¶oo¶¶¶¶      ¶¶¶¶¶¶8¶¶¶ \n";
//        std::cout << "              ¶¶¶¶ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶¶¶   \n";
//        std::cout << "               ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶    \n";
//        std::cout << "                 ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶         ¶¶    \n";
//        std::cout << "                ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶    \n";
//        std::cout << "                ¶¶__o¶¶¶¶¶   ¶¶¶¶¶o_8¶         ¶¶    \n";
//        std::cout << "                ¶3___¶¶¶¶     ¶¶¶¶___¶         ¶¶    \n";
//        std::cout << "                ¶¶_q¶¶¶¶      ¶¶¶¶¶_¶¶         ¶¶    \n";
//        std::cout << "               ¶¶¶¶¶¶¶¶        ¶¶¶¶¶¶¶q        ¶¶    \n";
//        std::cout << "             ¶__o¶¶¶¶           ¶¶¶$           ¶¶    \n";
//        std::cout << "             ¶_v¶¶¶             ¶¶¶¶¶o¶        ¶¶    \n";
//        std::cout << "             ¶¶¶¶¶3             ¶¶¶¶¶¶         ¶¶    \n";
//        std::cout << "            ¶__¶¶¶v             ¶¶¶¶o          ¶¶    \n";
//        std::cout << "           ¶__¶¶¶¶               ¶¶¶¶¶q        ¶¶    \n";
//        std::cout << "            ¶¶¶¶¶                 ¶¶¶_¶_¶      ¶¶    \n";
//        std::cout << "          ¶¶¶¶¶                    ¶¶¶¶_¶      ¶¶    \n";
//        std::cout << "         ¶¶¶¶                      ¶¶¶¶q¶¶           \n";
//        std::cout << "        ¶¶¶¶¶¶                      ¶¶¶¶_¶8¶¶¶       \n";
//        std::cout << "    ¶¶8¶8¶¶¶¶¶                         ¶¶¶¶¶¶¶¶¶     \n\n\n";
//    }
//}

////---------------------------------------------------------------------------------------
//void profile(int level, char* name, int Class_Hero, int health, int mana, int strong, int money)
//{
//        std::cout << "|---------| " << name << " | " << Class_Hero << " | " << money << "\n";
//        std::cout << "|  lvl:" << level << "  |---------------------\n";
//        std::cout << "|===(O)===| HP: " << health << " M: " << mana << " УР: " << strong << "\n";
//}
//---------------------------------------------------------------------------------------

////==================================================================
//void saveLvlarea(int lvlsave)
//{
//    std::ofstream out_file("lvlarea.txt"); //, std::fstream::app
//    out_file << lvlsave;
//    out_file.close();
//    std::cout << "\nSaved Lvl of area!\n";
//    system("pause");
//}
//void saveLvlHero(int lvl)
//{
//    std::ofstream out_file("lvlhero.txt"); //, std::fstream::app
//    out_file << lvl;
//    out_file.close();
//    std::cout << "\nSaved Lvl of Hero!\n";
//    system("pause");
//}
//void saveMoneyHero(int money)
//{
//    std::ofstream out_file("moneyhero.txt"); //, std::fstream::app
//    out_file << money;
//    out_file.close();
//    std::cout << "\nSaved money of Hero!\n";
//    system("pause");
//}
//void saveNowxpHero(int nowLVLVhp)
//{
//    std::ofstream out_file("xphero.txt"); //, std::fstream::app
//    out_file << nowLVLVhp;
//    out_file.close();
//    std::cout << "\nSaved xp of Hero!\n";
//    system("pause");
//}
//void saveChoiceHero(int UserChoiceHero)
//{
//    if (UserChoiceHero == 1)
//    {
//        std::ofstream out_file("Choicehero.txt"); //, std::fstream::app
//        out_file << 1;
//        out_file.close();
//        std::cout << "\nSaved class of Hero!\n";
//        system("pause");
//    }
//    if (UserChoiceHero == 2)
//    {
//        std::ofstream out_file("Choicehero.txt"); //, std::fstream::app
//        out_file << 2;
//        out_file.close();
//        std::cout << "\nSaved class of Hero!\n";
//        system("pause");
//    }
//    if (UserChoiceHero == 3)
//    {
//        std::ofstream out_file("Choicehero.txt"); //, std::fstream::app
//        out_file << 3;
//        out_file.close();
//        std::cout << "\nSaved class of Hero!\n";
//        system("pause");
//    }
//}
//void saveHealPotion(int HealPotion)
//{
//    std::ofstream out_file("Healhero.txt"); //, std::fstream::app
//    out_file << HealPotion;
//    out_file.close();
//    std::cout << "\nSaved Heal potion of Hero!\n";
//    system("pause");
//}
//void saveManaPotion(int ManaPotion)
//{
//    std::ofstream out_file("Manahero.txt"); //, std::fstream::app
//    out_file << ManaPotion;
//    out_file.close();
//    std::cout << "\nSaved Mana potion of Hero!\n";
//    system("pause");
//}
//void saveAttackPotion(int AttackPotion)
//{
//    std::ofstream out_file("Attackhero.txt"); //, std::fstream::app
//    out_file << AttackPotion;
//    out_file.close();
//    std::cout << "\nSaved Attack potion of Hero!\n";
//    system("pause");
//}
//void saveDefendPotion(int DefendPotion)
//{
//    std::ofstream out_file("Defendhero.txt"); //, std::fstream::app
//    out_file << DefendPotion;
//    out_file.close();
//    std::cout << "\nSaved Defend potion of Hero!\n";
//    system("pause");
//}
//void saveNameHero(char* name)
//{
//    std::ofstream out_file("HeroName.txt"); //, std::fstream::app
//    out_file << name;
//    out_file.close();
//    std::cout << "\nSaved name of Hero!\n";
//    system("pause");
//}
//void savestrongHero(int strong)
//{
//    std::ofstream out_file("stronghero.txt"); //, std::fstream::app
//    out_file << strong;
//    out_file.close();
//    std::cout << "\nSaved strong of Hero!\n";
//    system("pause");
//}
//void savehealthHero(int health)
//{
//    std::ofstream out_file("healthhero.txt"); //, std::fstream::app
//    out_file << health;
//    out_file.close();
//    std::cout << "\nSaved health of Hero!\n";
//    system("pause");
//}
//void saveintelectHero(int intelect)
//{
//    std::ofstream out_file("intelecthero.txt"); //, std::fstream::app
//    out_file << intelect;
//    out_file.close();
//    std::cout << "\nSaved intelect of Hero!\n";
//    system("pause");
//}
//void savefastHero(int fast)
//{
//    std::ofstream out_file("fasthero.txt"); //, std::fstream::app
//    out_file << fast;
//    out_file.close();
//    std::cout << "\nSaved fast of Hero!\n";
//    system("pause");
//}
//void savedefendHero(int defend)
//{
//    std::ofstream out_file("HeroDefend.txt"); //, std::fstream::app
//    out_file << defend;
//    out_file.close();
//    std::cout << "\nSaved defend of Hero!\n";
//    system("pause");
//}
//void savemagicalHero(int magical)
//{
//    std::ofstream out_file("magicalhero.txt"); //, std::fstream::app
//    out_file << magical;
//    out_file.close();
//    std::cout << "\nSaved magical of Hero!\n";
//    system("pause");
//}
//void savemanaHero(int mana)
//{
//    std::ofstream out_file("manahero.txt"); //, std::fstream::app
//    out_file << mana;
//    out_file.close();
//    std::cout << "\nSaved mana of Hero!\n";
//    system("pause");
//}
//void savenewLvlPLUS(int newLvlPLUS)
//{
//    std::ofstream out_file("NewLvl.txt"); //, std::fstream::app
//    out_file << newLvlPLUS;
//    out_file.close();
//    std::cout << "\nSaved mana of Hero!\n";
//    system("pause");
//}
////============================================================================
////============================================================================
////============================================================================
//int LOADLvlarea()
//{
//    std::ifstream input_file("lvlarea.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADLvlHero()
//{
//    std::ifstream input_file("lvlhero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADMoneyHero()
//{
//    std::ifstream input_file("moneyhero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADNowxpHero()
//{
//    std::ifstream input_file("xphero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADChoiceHero()
//{
//    std::ifstream input_file("Choicehero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADHealPotion()
//{
//    std::ifstream input_file("Healhero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADManaPotion()
//{
//    std::ifstream input_file("Manahero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADAttackPotion()
//{
//    std::ifstream input_file("Attackhero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADDdefendPotion()
//{
//    std::ifstream input_file("Defendhero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//char* LOADNameHero(char* str)
//{
//    std::ifstream input_file("HeroName.txt");
//    input_file.getline(str, 20);
//    std::cout << str << std::endl;
//    input_file.close();
//    return str;
//}
//int LOADstrongHero()
//{
//    std::ifstream input_file("stronghero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADhealthHero()
//{
//    std::ifstream input_file("healthhero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADintelectHero()
//{
//    std::ifstream input_file("intelecthero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADfastHero()
//{
//    std::ifstream input_file("fasthero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//
//int LOADdefendHero()
//{
//    std::ifstream input_file("HeroDefend.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADmagicalHero()
//{
//    std::ifstream input_file("magicalhero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADmanaHero()
//{
//    std::ifstream input_file("manahero.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
//int LOADnewLvlPLUS()
//{
//    std::ifstream input_file("NewLvl.txt");
//    string s;
//    getline(input_file, s);
//    int n;
//    n = atoi(s.c_str());
//    std::cout << s << std::endl;
//    input_file.close();
//    return n;
//}
////============================================================================
////============================================================================
////============================================================================
//int newLVL(int lvl, int xpnow)
//{
//    int nowlvlXp = 100;
//    for (int i = 1; i < lvl; i++)
//    {
//        nowlvlXp += 50;
//    }
//    return nowlvlXp;
//}
//char* ClasLuchnik()
//{
//    char* ClasHero = new char[7]{ "Лучник" };
//    return ClasHero;
//}
//char* ClasWarrior()
//{
//    char* ClassHero = new char[5]{ "Воин" };
//    return ClassHero;
//}
//char* ClasMagic()
//{
//    char* ClassHero = new char[4]{ "Маг" };
//    return ClassHero;
//}
//---------------------------------------------------------------------------------------

////---------------------------------------------------------------------------------------
//int MonsterAttack_ENEMY1(int defend_user, int fast_user, int health_enemy)
//{
//    string ENEMY1 = "Склет";
//    string hit_ENEMY1_1 = "Удар косточкой";
//    string hit_ENEMY1_2 = "Волшебная пыль Склета Легендарного качества Прмямо с завода";
//    int bot_attack, enemy_attack = 0;
//    bot_attack = rand() % 2 + 1;
//    int Luck_fast;
//    switch (bot_attack)
//    {
//    case 1:
//        std::cout << "                  \tКласс Врага: " << ENEMY1 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY1_1 << "\n";
//        Luck_fast = rand() % 100 + 1;
//        enemy_attack = (rand() % 50 + 1) - (defend_user / 2);
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//
//            return 0;
//        }
//        return enemy_attack;
//        break;
//    case 2:
//        std::cout << "                  \tКласс Врага: " << ENEMY1 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY1_2 << "\n";
//        Luck_fast = rand() % 100 + 1;
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//            system("pause");
//            return 0;
//        }
//        enemy_attack = (rand() % 80 + 1) - (defend_user / 2);
//        std::cout << "                 Нанесен урон: " << enemy_attack << "\n\n";
//        return enemy_attack;
//        break;
//    }
//}
//
//int MonsterAttack_ENEMY2(int defend_user, int fast_user, int health_enemy)
//{
//    string ENEMY2 = "Летучая МышЪ";
//    string hit_ENEMY2_1 = "Укус";
//    string hit_ENEMY2_2 = "Вампиризм";
//    int bot_attack, enemy_attack = 0;
//    bot_attack = rand() % 2 + 1;
//    int Luck_fast;
//    switch (bot_attack)
//    {
//    case 1:
//        std::cout << "                  \tКласс Врага: " << ENEMY2 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY2_1 << "\n";
//        Luck_fast = rand() % 100 + 1;
//        enemy_attack = (rand() % 50 + 1) - (defend_user / 2);
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//
//            return 0;
//        }
//        std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
//        return enemy_attack;
//        break;
//    case 2:
//        std::cout << "                  \tКласс Врага: " << ENEMY2 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY2_2 << "\n";
//        Luck_fast = rand() % 100 + 1;
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//            return 0;
//        }
//        enemy_attack = (rand() % 70 + 1) - (defend_user / 2);
//        std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
//        return enemy_attack;
//        break;
//    }
//    return enemy_attack;
//}
//int MonsterAttack_ENEMY3(int defend_user, int fast_user, int health_enemy)
//{
//    string ENEMY3 = "Орк";
//    string hit_ENEMY3_1 = "Пинок";
//    string hit_ENEMY3_2 = "Тяжелый удар";
//    int bot_attack, enemy_attack = 0;
//    bot_attack = rand() % 2 + 1;
//    int Luck_fast;
//    switch (bot_attack)
//    {
//    case 1:
//        std::cout << "                  \tКласс Врага: " << ENEMY3 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY3_1 << "\n";
//        Luck_fast = rand() % 100 + 1;
//        enemy_attack = (rand() % 70 + 1) - (defend_user / 2);
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//            return 0;
//        }
//        std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
//        return enemy_attack;
//        break;
//    case 2:
//        std::cout << "                  \tКласс Врага: " << ENEMY3 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY3_2 << "\n";
//        Luck_fast = rand() % 100 + 1;
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//            return 0;
//        }
//        enemy_attack = (rand() % 100 + 1) - (defend_user / 2);
//        std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
//        return enemy_attack;
//        break;
//    }
//    return enemy_attack;
//}
//int MonsterAttack_ENEMY4(int defend_user, int fast_user, int health_enemy)
//{
//    string ENEMY4 = "Гоблин";
//    string hit_ENEMY4_1 = "Удар мечом";
//    string hit_ENEMY4_2 = "Золотая лихорадка";
//    int bot_attack, enemy_attack = 0;
//    bot_attack = rand() % 2 + 1;
//    int Luck_fast;
//    switch (bot_attack)
//    {
//    case 1:
//        std::cout << "                  \tКласс Врага: " << ENEMY4 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY4_1 << "\n";
//
//        Luck_fast = rand() % 100 + 1;
//        enemy_attack = (rand() % 60 + 1) - (defend_user / 2);
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//            return 0;
//        }
//        std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
//        return enemy_attack;
//        break;
//    case 2:
//        std::cout << "                  \tКласс Врага: " << ENEMY4 << " | Здоровье: " << health_enemy << "\n";
//        std::cout << "                  \tАтакует с помощью: " << hit_ENEMY4_2 << "\n";
//        Luck_fast = rand() % 100 + 1;
//        if (Luck_fast <= fast_user)
//        {
//            std::cout << "\n\tВы уклонились\n";
//            return 0;
//        }
//        enemy_attack = (rand() % 100 + 1) - (defend_user / 2);
//        std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
//        return enemy_attack;
//        break;
//    }
//    return enemy_attack;
//}
////---------------------------------------------------------------------------------------
//int CreateMonster(int defend_user, int fast_user, int health_enemy, int new_bot)
//{
//    switch (new_bot)
//    {
//    case 1:
//        return MonsterAttack_ENEMY1(defend_user, fast_user, health_enemy);
//        break;
//    case 2:
//        return MonsterAttack_ENEMY2(defend_user, fast_user, health_enemy);
//        break;
//    case 3:
//        return MonsterAttack_ENEMY3(defend_user, fast_user, health_enemy);
//        break;
//    case 4:
//        return MonsterAttack_ENEMY4(defend_user, fast_user, health_enemy);
//        break;
//    }
//}

//---------------------------------------------------------------------------------------
int newLVL(int lvl, int xpnow)
{
    int nowlvlXp = 100;
    for (int i = 1; i < lvl; i++)
    {
        nowlvlXp += 50;
    }
    return nowlvlXp;
}
//---------------------------------------------------------------------------------------
void printWin(int lvl, int xpnow)
{
    system("cls");
    std::cout << "\t" << "You win!!!" << std::endl;
    std::cout << "\n\n" << xpnow << "/";
    newLVL(lvl, xpnow);
}
//---------------------------------------------------------------------------------------
void printLose(int lvl, int xpnow)
{
    system("cls");
    std::cout << "\t" << "You Lose" << std::endl;
    std::cout << "\n\n" << xpnow << "/";
    newLVL(lvl, xpnow);
}
//---------------------------------------------------------------------------------------
void info_about_skill_Character()
{
    printf("\tCила - Урон, который ты наносишь\n");
    printf("\tЗдоровье - Твое количество здоровья, если будет ниже нуля, ты начинаешь заново\n");
    printf("\tИнтелект - Шанс критического удара (*2 от твоего урона)\n");
    printf("\tскорость - Шанс уворота от удара\n");
    printf("\tЗащита - Блокируемый урон\n");
    printf("\tМана - Возможность использовать атаки\n\n");
    system("pause");
    system("cls");
}
//---------------------------------------------------------------------------------------
class Hero 
{
public:
    string hit_1, hit_2, hit_3, hit_4;
    int strong ;
    int health ;
    int intelect ;
    int fast ;
    int defend ;
    int magical ;
    int mana ;
    //
    string nameUser;
    string Class_Hero;
    //
    int level;
    int levelArea;
    int money;
    int xpnow;
    int newLvlPLUS;
    //
    int HealHero_potion;
    int ManaHero_potion;
    int AttackHero_potion;
    int DefendHero_potion;
    //
    int fight_HP;
    int fight_defend ;
    int Mana_fight ;
    int fight_strong;
    int kolvo_max_potion ;
    //
    int is_dead{ false };
public:
    //--------------------------------------------------------------------------------------------------------------------------------------------
    Hero()
    {

    }
    Hero(Hero& obj)
    {
        hit_1 = obj.hit_1;
        hit_2 = obj.hit_2;
        hit_3 = obj.hit_3;
        hit_4 = obj.hit_4;
        strong =  obj.strong;//
        health = obj.health;//
        intelect = obj.intelect;//
        fast = obj.fast;//
        defend = obj.defend;//
        magical = obj.magical;//
        mana = obj.mana;//
        nameUser = obj.nameUser;//
        Class_Hero = obj.Class_Hero;//
        level = obj.level;
        levelArea = obj.levelArea;
        money = obj.money;
        xpnow = obj.xpnow;
        newLvlPLUS = obj.newLvlPLUS;
        //
        HealHero_potion = obj.HealHero_potion;
        ManaHero_potion = obj.ManaHero_potion;
        AttackHero_potion = obj.AttackHero_potion;
        DefendHero_potion = obj.DefendHero_potion;
        //
        fight_HP = obj.fight_HP;
        fight_defend = obj.fight_defend;
        Mana_fight = obj.Mana_fight;
        fight_strong = obj.fight_strong;
        kolvo_max_potion = obj.kolvo_max_potion;

    }
    Hero(int _strong, int _health, int _intelect, int _fast, int _defend, int _magical, int _mana, string _nameUser, string s1, string s2, string s3, string s4, string CH)
        : strong(_strong), health(_health), intelect(_intelect), fast(_fast), defend(_defend), magical(_magical), mana(_mana), nameUser(_nameUser), hit_1(s1), hit_2(s2), hit_3(s3), hit_4(s4),  Class_Hero(CH)
    {
        level = 1;
        levelArea = 1;
        money = 200;
        xpnow = 0;
        newLvlPLUS = 1;
       
        HealHero_potion = 1;
        ManaHero_potion = 1;
        AttackHero_potion = 1;
        DefendHero_potion = 1;

        fight_HP = health;
        fight_defend = defend;
        Mana_fight = mana;
        fight_strong = strong;
        kolvo_max_potion = 0;

    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------------------------------------------------------------------
    int Get_Fast()
    {
        return fast;
    }
    int Get_Defend()
    {
        return fast;
    }
    int Get_Strong()
    {
        return strong;
    }
    int Get_Health()
    {
        return health;
    }
    int Get_Intelect()
    {
        return intelect;
    }
    int Get_Magical()
    {
        return magical;
    }
    int Get_Mana_Now()
    {
        return Mana_fight;
    }
    //---------------------------------------
    string Get_Name()
    {
        return nameUser;
    }
    string Class_ofHero()
    {
        return Class_Hero;
    }
    string Hit_1()
    {
        return hit_1;
    }
    string Hit_2()
    {
        return hit_2;
    }
    string Hit_3()
    {
        return hit_3;
    }
    string Hit_4()
    {
        return hit_4;
    }
    //---------------------------------------
    int Get_level()
    {
        return level;
    }
    int Get_levelArea()
    {
        return levelArea;
    }
    int Get_money()
    {
        return money;
    }
    int Get_xpnow()
    {
        return xpnow;
    }
    int Get_newLvlPLUS()
    {
        return newLvlPLUS;
    }
    void Show()
    {
        std::cout << "Speed: " << Get_Fast();
        std::cout << "Defend: " << Get_Defend();
        std::cout << "Strong: " << Get_Strong();
        std::cout << "Healtg: " << Get_Health();
        std::cout << "Intelect: " << Get_Intelect();
        std::cout << "Magical: " << Get_Magical();
        std::cout << "Mana: " << Get_Mana_Now();
        std::cout << "Name: " << Get_Name();
        std::cout << "Class: " << Class_ofHero();
        std::cout << "Hit 1: " << Hit_1();
        std::cout << "Hit 2: " << Hit_2();
        std::cout << "Hit 3: " << Hit_3();
        std::cout << "Hit 3: " << Hit_4();
        std::cout << "Level of Hero: " << Get_level();
        std::cout << "Level of Area: " << Get_levelArea();
        std::cout << "Money: " << Get_money();
        std::cout << "XP: " << Get_xpnow();
        std::cout << "LVLS to up: " << Get_newLvlPLUS();
    }  
    //--------------------------------------------------------------------------------------------------------------------------------------------
    void HeroUr()
    {
        if (Class_Hero == "Warrior")
        {
            std::cout << "                        ¶¶                           \n";
            std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶¶              ¶     \n";
            std::cout << "                     ¶¶¶¶¶¶¶    ¶¶¶            ¶     \n";
            std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶           ¶¶    \n";
            std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶$¶¶¶¶           ¶¶    \n";
            std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶  ¶            ¶¶    \n";
            std::cout << "                      ¶¶¶o¶¶¶¶¶¶¶¶             ¶¶    \n";
            std::cout << "                      ¶¶__¶¶¶¶¶¶¶_¶¶¶          ¶¶    \n";
            std::cout << "                     q¶¶¶¶¶¶¶¶¶¶¶3¶¶¶_¶¶       ¶¶    \n";
            std::cout << "                  ¶v¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶8_¶       ¶¶    \n";
            std::cout << "               _$¶¶$¶¶¶¶¶¶8____¶¶¶___¶¶¶       ¶¶    \n";
            std::cout << "              ¶o¶_¶¶¶¶¶¶¶¶¶3___¶¶¶_¶¶¶¶¶¶      ¶¶    \n";
            std::cout << "             ¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶      ¶¶    \n";
            std::cout << "          ¶¶¶¶¶¶¶¶    ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶    ¶¶    \n";
            std::cout << "         ¶__¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶  ¶¶¶¶   \n";
            std::cout << "         8_¶¶¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶¶   ¶¶¶¶¶¶¶¶¶¶¶¶¶ \n";
            std::cout << "            ¶¶¶¶¶¶    ¶¶¶¶¶¶¶8___¶¶¶       ¶¶¶¶¶¶¶¶¶ \n";
            std::cout << "            ¶¶¶¶¶¶  ¶¶¶¶¶¶¶¶¶¶oo¶¶¶¶      ¶¶¶¶¶¶8¶¶¶ \n";
            std::cout << "              ¶¶¶¶ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶¶¶   \n";
            std::cout << "               ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶    \n";
            std::cout << "                 ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶               \n";
            std::cout << "                ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶                \n";
            std::cout << "                ¶¶__o¶¶¶¶¶   ¶¶¶¶¶o_8¶               \n";
            std::cout << "                ¶3___¶¶¶¶     ¶¶¶¶___¶               \n";
            std::cout << "                ¶¶_q¶¶¶¶      ¶¶¶¶¶_¶¶               \n";
            std::cout << "               ¶¶¶¶¶¶¶¶        ¶¶¶¶¶¶¶q              \n";
            std::cout << "             ¶__o¶¶¶¶           ¶¶¶$                 \n";
            std::cout << "             ¶_v¶¶¶             ¶¶¶¶¶o¶              \n";
            std::cout << "             ¶¶¶¶¶3             ¶¶¶¶¶¶               \n";
            std::cout << "            ¶__¶¶¶v             ¶¶¶¶o                \n";
            std::cout << "           ¶__¶¶¶¶               ¶¶¶¶¶q              \n";
            std::cout << "            ¶¶¶¶¶                 ¶¶¶_¶_¶            \n";
            std::cout << "          ¶¶¶¶¶                    ¶¶¶¶_¶            \n";
            std::cout << "         ¶¶¶¶                      ¶¶¶¶q¶¶           \n";
            std::cout << "        ¶¶¶¶¶¶                      ¶¶¶¶_¶8¶¶¶       \n";
            std::cout << "    ¶¶8¶8¶¶¶¶¶                         ¶¶¶¶¶¶¶¶¶     \n\n\n";
        }
        if (Class_Hero == "Archer")
        {
            std::cout << "                        ¶¶                           \n";
            std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶¶                    \n";
            std::cout << "                     ¶¶¶¶¶¶¶    ¶¶¶                  \n";
            std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶                 \n";
            std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶$¶¶¶¶    ¶¶           \n";
            std::cout << "             ^   ^   ¶¶¶¶¶¶¶¶¶¶¶  ¶     | ¶8         \n";
            std::cout << "             |   |    ¶¶¶o¶¶¶¶¶¶¶¶      |  ¶¶        \n";
            std::cout << "             |   |    ¶¶__¶¶¶¶¶¶¶_¶¶¶   |   ¶¶       \n";
            std::cout << "           ¶¶v_$¶¶v  q¶¶¶¶¶¶¶¶¶¶¶3¶¶¶_¶¶|    ¶8      \n";
            std::cout << "            ¶¶v_$¶¶v¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶8_¶|     ¶¶     \n";
            std::cout << "            ¶¶v_$¶¶$¶¶¶¶¶¶8____¶¶¶___¶¶¶       ¶¶    \n";
            std::cout << "              ¶o¶_¶¶¶¶¶¶¶¶¶3___¶¶¶_¶¶¶¶¶¶       ¶¶   \n";
            std::cout << "             ¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶        ¶¶  \n";
            std::cout << "          ¶¶¶¶¶¶¶¶    ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶      ¶q$¶\n";
            std::cout << "        ¶___¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶     ¶q$¶\n";
            std::cout << "         8_¶¶¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶¶   ¶¶¶¶¶¶¶¶¶¶¶¶¶ \n";
            std::cout << "            ¶¶¶¶¶¶    ¶¶¶¶¶¶¶8___¶¶¶    |  ¶¶¶¶¶¶¶¶¶ \n";
            std::cout << "            ¶¶¶¶¶¶  ¶¶¶¶¶¶¶¶¶¶oo¶¶¶¶    | ¶¶¶¶¶¶8¶¶¶ \n";
            std::cout << "              ¶¶¶¶ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶    |    ¶¶_o    \n";
            std::cout << "               ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶   |   ¶¶       \n";
            std::cout << "                 ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶  |  ¶¶        \n";
            std::cout << "                ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶   | ¶¶         \n";
            std::cout << "                ¶¶__o¶¶¶¶¶   ¶¶¶¶¶o_8¶  |¶¶          \n";
            std::cout << "                ¶3___¶¶¶¶     ¶¶¶¶___¶ ¶¶            \n";
            std::cout << "                ¶¶_q¶¶¶¶      ¶¶¶¶¶_¶¶               \n";
            std::cout << "               ¶¶¶¶¶¶¶¶        ¶¶¶¶¶¶¶q              \n";
            std::cout << "             ¶__o¶¶¶¶           ¶¶¶$                 \n";
            std::cout << "             ¶_v¶¶¶             ¶¶¶¶¶o¶              \n";
            std::cout << "             ¶¶¶¶¶3             ¶¶¶¶¶¶               \n";
            std::cout << "            ¶__¶¶¶v             ¶¶¶¶o                \n";
            std::cout << "           ¶__¶¶¶¶               ¶¶¶¶¶q              \n";
            std::cout << "            ¶¶¶¶¶                 ¶¶¶_¶_¶            \n";
            std::cout << "          ¶¶¶¶¶                    ¶¶¶¶_¶            \n";
            std::cout << "         ¶¶¶¶                      ¶¶¶¶q¶¶           \n";
            std::cout << "        ¶¶¶¶¶¶                      ¶¶¶¶_¶8¶¶¶       \n";
            std::cout << "    ¶¶8¶8¶¶¶¶¶                         ¶¶¶¶¶¶¶¶¶     \n\n\n";
        }
        if (Class_Hero == "Wizard")
        {
            std::cout << "                        ¶¶                           \n";
            std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶¶            ¶¶¶¶¶¶  \n";
            std::cout << "                     ¶¶¶¶¶¶¶    ¶¶¶         ¶      ¶ \n";
            std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶¶_¶¶¶        ¶      ¶ \n";
            std::cout << "                    ¶¶¶¶¶¶¶¶¶¶¶$¶¶¶¶         ¶¶¶¶¶¶  \n";
            std::cout << "                     ¶¶¶¶¶¶¶¶¶¶¶  ¶            ¶¶    \n";
            std::cout << "                      ¶¶¶o¶¶¶¶¶¶¶¶             ¶¶    \n";
            std::cout << "                      ¶¶__¶¶¶¶¶¶¶_¶¶¶          ¶¶    \n";
            std::cout << "                     q¶¶¶¶¶¶¶¶¶¶¶3¶¶¶_¶¶       ¶¶    \n";
            std::cout << "                  ¶v¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶8_¶       ¶¶    \n";
            std::cout << "               _$¶¶$¶¶¶¶¶¶8____¶¶¶___¶¶¶       ¶¶    \n";
            std::cout << "              ¶o¶_¶¶¶¶¶¶¶¶¶3___¶¶¶_¶¶¶¶¶¶      ¶¶    \n";
            std::cout << "             ¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶      ¶¶    \n";
            std::cout << "          ¶¶¶¶¶¶¶¶    ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶    ¶¶    \n";
            std::cout << "         ¶__¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶   ¶¶    \n";
            std::cout << "         8_¶¶¶¶¶¶      ¶¶¶¶¶¶¶¶¶¶¶¶¶   ¶¶¶¶¶¶¶¶¶¶¶¶¶ \n";
            std::cout << "            ¶¶¶¶¶¶    ¶¶¶¶¶¶¶8___¶¶¶       ¶¶¶¶¶¶¶¶¶ \n";
            std::cout << "            ¶¶¶¶¶¶  ¶¶¶¶¶¶¶¶¶¶oo¶¶¶¶      ¶¶¶¶¶¶8¶¶¶ \n";
            std::cout << "              ¶¶¶¶ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶¶¶   \n";
            std::cout << "               ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶    \n";
            std::cout << "                 ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶         ¶¶    \n";
            std::cout << "                ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶          ¶¶    \n";
            std::cout << "                ¶¶__o¶¶¶¶¶   ¶¶¶¶¶o_8¶         ¶¶    \n";
            std::cout << "                ¶3___¶¶¶¶     ¶¶¶¶___¶         ¶¶    \n";
            std::cout << "                ¶¶_q¶¶¶¶      ¶¶¶¶¶_¶¶         ¶¶    \n";
            std::cout << "               ¶¶¶¶¶¶¶¶        ¶¶¶¶¶¶¶q        ¶¶    \n";
            std::cout << "             ¶__o¶¶¶¶           ¶¶¶$           ¶¶    \n";
            std::cout << "             ¶_v¶¶¶             ¶¶¶¶¶o¶        ¶¶    \n";
            std::cout << "             ¶¶¶¶¶3             ¶¶¶¶¶¶         ¶¶    \n";
            std::cout << "            ¶__¶¶¶v             ¶¶¶¶o          ¶¶    \n";
            std::cout << "           ¶__¶¶¶¶               ¶¶¶¶¶q        ¶¶    \n";
            std::cout << "            ¶¶¶¶¶                 ¶¶¶_¶_¶      ¶¶    \n";
            std::cout << "          ¶¶¶¶¶                    ¶¶¶¶_¶      ¶¶    \n";
            std::cout << "         ¶¶¶¶                      ¶¶¶¶q¶¶           \n";
            std::cout << "        ¶¶¶¶¶¶                      ¶¶¶¶_¶8¶¶¶       \n";
            std::cout << "    ¶¶8¶8¶¶¶¶¶                         ¶¶¶¶¶¶¶¶¶     \n\n\n";
        }
    }
    void profile()
    {
        system("cls");
        std::cout << "|---------| " << nameUser << " | " << Class_Hero << " | " << money << "\n";
        std::cout << "|  lvl:" << level << "  |---------------------\n";
        std::cout << "|===(O)===| HP: " << health << " M: " << mana << " УР: " << strong << "\n";
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    void Make_Choice_UP()
    {
        system("cls");
        profile();
        int ChoiceInfo;
        if (Class_Hero == "Warrior" || Class_Hero == "Archer")
        {
            printf("\n\tCкорость: %d%s", fast, "\n");
        }
        if (Class_Hero == "Wizard")
        {
            printf("\tМагическая сила: %d%s", magical, "\n");
        }
        //Show()
        printf("\tИнтелект: %d%s", intelect, "\n");
        printf("\tЗащита: %d%s", defend, "\n");
        printf("\tЗолотых монет: %d%s", money, "\n");
        printf("\tУ вас есть: %d%s", newLvlPLUS, " очков прокачки\n");
        std::cout << "\tПродвижение по уровням: ";
        std::cout << xpnow << "/";
        std::cout << newLVL(level, xpnow) << endl << endl;
        std::cout << "\t" << "Выбирите действие: " << endl
            << "\t" << "1) Потратить очки" << endl
            << "\t" << "2) Выход" << endl
            << "\t" << "Ваш выбор: ";
        do
        {
            std::cin >> ChoiceInfo;
        } while (ChoiceInfo < 0 || ChoiceInfo > 2);
        if (ChoiceInfo == 1)
        {
            if (newLvlPLUS == 0)
            {
                printf("\nНедостаточно очков\n\n");
                system("pause");
                system("cls");
            }
            else
            {
                int Choice;
                std::cout << "\n\nВыбирите куда потратить очки: \n";
                std::cout << "1) Сила: " << strong << endl;
                std::cout << "2) Здоровье: " << health << "HP" << endl;
                std::cout << "3) Ловкость: " << fast << endl;
                std::cout << "4) Интеллект: " << intelect << endl;
                std::cout << "5) Магическая сила: " << magical << endl;
                std::cout << "6) Защита: " << defend << endl;
                std::cout << "7) Мана: " << mana << endl;
                do
                {
                    std::cout << "\t" << "Выбирите куда потратить очки: ";
                    std::cin >> Choice;
                } while (Choice < 0 || Choice > 7);
                switch (Choice)
                {
                case 1:
                    strong += 20;
                    std::cout << "\n\tСила: " << strong << endl;
                    newLvlPLUS--;
                    break;
                case 2:
                    health += 100;
                    std::cout << "\n\tЗдоровье: " << health << endl;
                    newLvlPLUS--;
                    break;
                case 3:
                    if (Class_Hero == "Warrior" || Class_Hero == "Archer")
                    {
                        fast += 5;
                        std::cout << "\n\tЛовкость: " << fast << endl;
                        newLvlPLUS--;
                        break;
                    }
                    else
                    {
                        std::cout << "\n\tУ вас нету возможности прокачивать эту ветку ";
                        system("pause");
                    }
                    break;
                case 4:
                    intelect += 2;
                    std::cout << "\n\tИнтеллект: " << intelect << endl;
                    newLvlPLUS--;
                    break;
                case 5:
                    if (Class_Hero == "Wizard")
                    {
                        magical += 50;
                        std::cout << "\n\tМагическая сила: " << magical << endl;
                        newLvlPLUS--;
                        break;
                    }
                    else
                    {
                        std::cout << "\n\tУ вас нету возможности прокачивать эту ветку ";
                        system("pause");
                    }
                    break;
                case 6:
                    defend += 25;
                    std::cout << "\n\tЗащита: " << defend << endl;
                    newLvlPLUS--;
                    break;
                case 7:
                    mana += 5;
                    std::cout << "\n\tМана: " << mana << endl;
                    newLvlPLUS--;
                    break;
                }
            }
        }
        else
        {
            system("pause");
            system("cls");
        }
    }
    int Make_Choice()
    {
        Mana_fight += 15;
        fight_defend = defend;
        if (Mana_fight > mana)
        {
            Mana_fight = mana;
        }
        fight_defend = defend;
        fight_strong = strong;
        int Choice_fight;
        do
        {
            std::cout << "\n1) Атака \n"
                << "2) Использовать зелья\n"
                << "3) Стать в защиту\n"
                << "Ваш выбор: ";
            std::cin >> Choice_fight;

        } while (Choice_fight > 3 || Choice_fight < 1);

        if (Choice_fight == 1)
        {
            return Make_choice_fight();
        }

        if (Choice_fight == 2)
        {
            if (HealHero_potion != 0 || ManaHero_potion != 0 || AttackHero_potion != 0 || DefendHero_potion != 0)
            {
                Make_choice_poision();
            }
            return 0;
        }

        if (Choice_fight == 3)
        {
            fight_defend += 20;
            return 0;
        }
    }
    void Make_choice_poision()
    {
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
        std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
        std::cout << "|kolvo: " << HealHero_potion << "|" << "    |kolvo: " << ManaHero_potion << "|" << "    |kolvo: " << AttackHero_potion << "|" << "    |kolvo: " << DefendHero_potion << "|" << "\n";
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
        int Choice_Zealya;
        do
        {
            std::cout << "\n\tВыбери зелье: ";
            std::cin >> Choice_Zealya;
        } while (Choice_Zealya > 4 || Choice_Zealya < 1);
        switch (Choice_Zealya)
        {
        case 1:
            if (HealHero_potion == 0)
            {
                std::cout << "\n\tУ вас нет зелья даного типа\n";
            }
            else
            {
                if (kolvo_max_potion > 4)
                {
                    std::cout << "Вы не можете выпить больше 4 зелей за один бой";
                }
                else
                {
                    fight_HP += 50;
                    if (fight_HP > health)
                    {
                        fight_HP = health;
                        kolvo_max_potion++;
                        HealHero_potion--;
                    }
                    else
                    {
                        kolvo_max_potion++;
                        HealHero_potion--;
                    }
                }
            }
            std::cout << "\n\n";
            system("pause");

            break;
        case 2:
            if (ManaHero_potion == 0)
            {
                std::cout << "\n\tУ вас нет зелья даного типа\n";
            }
            else
            {
                if (kolvo_max_potion > 4)
                {
                    std::cout << "Вы не можете выпить больше 4 зелей за один бой";
                }
                else
                {
                    Mana_fight += 20;
                    if (Mana_fight > mana)
                    {
                        Mana_fight = mana;
                        kolvo_max_potion++;
                        ManaHero_potion--;
                    }
                    else
                    {
                        kolvo_max_potion++;
                        ManaHero_potion--;
                    }
                }
            }
            std::cout << "\n\n";
            system("pause");

            break;
        case 3:
            if (AttackHero_potion == 0)
            {
                std::cout << "\n\tУ вас нет зелья даного типа\n";
            }
            else
            {
                if (kolvo_max_potion > 4)
                {
                    std::cout << "Вы не можете выпить больше 4 зелей за один бой";
                }
                else
                {
                    fight_strong += 15;
                    kolvo_max_potion++;
                    AttackHero_potion--;
                }
            }
            std::cout << "\n\n";
            system("pause");
        }
    }
    int Make_choice_fight()
    {
        std::cout << "\n\n\tВаши умения: \n";
        std::cout << "1) " << Hit_1() << "\n";
        std::cout << "2) " << Hit_2() << "\n";
        std::cout << "3) " << Hit_3() << "\n";
        std::cout << "4) " << Hit_4() << "\n";
        int decision;
        do
        {
        std::cout << "\n\nEnter your decision of attack: ";
        std::cin >> decision;
        } while (decision > 4 || decision < 1);
        switch (decision)
        {
            case 1:
                return attack1();
                break;
            case 2:
                return attack2();
                break;
            case 3:
                return attack3();
                break;

            case 4:
               return attack4();
                break;
        }
    }
    //---------------------------------------
    virtual int attack4()
    {
        int LuckIntelect;
        int hit_ur;
        if (Mana_fight < 40)
        {
            std::cout << "Недостаточно маны\n\n";
        }
        else
        {
            LuckIntelect = rand() % 100 + 1;
            if (LuckIntelect < intelect)
            {
                hit_ur = (rand() % strong * 3 + 1 + (magical / 5)) * 2;
                std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                system("pause");
               // set_attack(hit_ur);
                Mana_fight -= 40;
                return hit_ur;
            }
            else
            {
                hit_ur = (rand() % strong) * 3 + 1 + (magical / 5);
                std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                system("pause");
                //set_attack(hit_ur);
                Mana_fight -= 40;
                return hit_ur;
            }

        }
    }
    virtual int attack3()
    {
        int LuckIntelect;
        int hit_ur;

        if (Mana_fight < 30)
        {
            std::cout << "Недостаточно маны\n\n";
        }
        else
        {
            LuckIntelect = rand() % 100 + 1;
            if (LuckIntelect < intelect)
            {
                hit_ur = (rand() % strong * 2 + 1 + (magical / 5)) * 2;
                std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                system("pause");
                //set_attack(hit_ur);
                Mana_fight -= 30;
                return hit_ur;
            }
            else
            {
                hit_ur = rand() % strong * 2 + 1 + (magical / 5);
                std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                system("pause");
                //set_attack(hit_ur);
                Mana_fight -= 30;
                return hit_ur;
            }
            
        }

    }
    virtual int attack2()
    {
        int LuckIntelect;
        int hit_ur;
        
        if (Mana_fight < 20)
        {
            std::cout << "Недостаточно маны\n\n";
        }
        else
        {
            LuckIntelect = rand() % 100 + 1;
            if (LuckIntelect < intelect)
            {
                hit_ur = (rand() % strong + 10 + (magical / 5)) * 2;
                std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                system("pause");
                //set_attack(hit_ur);
                Mana_fight -= 20;
                return hit_ur;
            }
            else
            {
                hit_ur = rand() % strong + 10 + (magical / 5);
                std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                system("pause");
               // set_attack(hit_ur);
                Mana_fight -= 20;
                return hit_ur;
            }
           
        }
    }
    virtual int attack1()
    {

        int LuckIntelect;
        int hit_ur;

            if (Mana_fight < 10)
            {
                std::cout << "Недостаточно маны\n\n";
            }
            else
            {
                LuckIntelect = rand() % 100 + 1;
                if (LuckIntelect < intelect)
                {
                    hit_ur = rand() % strong + 1 + (magical / 5);
                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                    system("pause");
                   // set_attack(hit_ur);
                    Mana_fight -= 10;
                    return hit_ur;
                }
                else
                {
                    hit_ur = (rand() % strong + 1 + (magical / 5)) * 2;
                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
                    system("pause");
                   // set_attack(hit_ur);
                    Mana_fight -= 10;
                    return hit_ur;
                }
                
        }
    }
    //---------------------------------------
    void Minus_Hp(int Attack_power)
    {
        fight_HP -= Attack_power;
    }
    void regeneretion()
    {
        fight_HP = health;
        fight_defend = defend;
        Mana_fight = mana;
        fight_strong = strong;
        kolvo_max_potion = 0;
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------------------------------------------------------------------
    void If_Win()
    {
        int Give_Potion;
        xpnow += rand() % 50;
        while (xpnow >= newLVL(level, xpnow))
        {
            checker_newLVL();
        }
        printWin(level, xpnow);
        levelArea++;
        money += rand() % 50;
        std::cout <<  " | Money: " << money << " | New potion: ";
        Give_Potion = rand() % 4 + 1;
        switch (Give_Potion)
        {
        case 1:
            HealHero_potion++;
            std::cout << "Heal potion \n\n";
            break;
        case 2:
            ManaHero_potion++;
            std::cout << "Mana potion \n\n";
            break;
        case 3:
            AttackHero_potion++;
            std::cout << "Attack potion \n\n";
            break;
        case 4:
            DefendHero_potion++;
            std::cout << "Defend potion \n\n";
            break;
        }

        system("pause");


    }
    void If_Lose()
    {
            xpnow += (rand() % 20) / 2;
            while (xpnow >= xpnow >= newLVL(level, xpnow))
            {
                checker_newLVL();
            }
            money += rand() % 20;
            printLose(level, xpnow);
            std::cout << " | Money: " << money;
            system("pause");
    }
    void checker_newLVL()
    {
            xpnow -= newLVL(level, xpnow);
            newLvlPLUS++;
            level++;
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------------------------------------------------------------------
    bool isDead()
    {
        if (fight_HP <= 0)
        {
            is_dead = true;
        }
            
    }
    virtual ~Hero()
    {
        std::cout << "Buy!\n";
    }
};

//================================================================================================================================================

class Enemy1 
{
protected:
    string ENEMY1;
    string hit_ENEMY1_1 ;
    string hit_ENEMY1_2 ;
        int health_enemy;
        int health_enemy_h;
        int is_dead{ false };
public:
    Enemy1(int Health_User)
    {
        ENEMY1 = "Летучая МышЪ";
        hit_ENEMY1_1 = "Укус";
        hit_ENEMY1_2 = "Вампиризм";
        health_enemy_h = Health_User - (rand() % Health_User);
        health_enemy = health_enemy_h;
    }

    bool isDead()
    {
        if (health_enemy <= 0)
        {
            is_dead = true;
        }
            
    }

    int attack(int fast_user, int defend_user)
    {
        int enemy_attack;
        int bot_attack = 0;
        int Luck_fast;
        bot_attack = rand() % 2 + 1;
        switch (bot_attack)
        {
        case 1:
            std::cout << "                  \tКласс Врага: " << ENEMY1 << " | Здоровье: " << health_enemy << "\n";
            std::cout << "                  \tАтакует с помощью: " << hit_ENEMY1_1 << "\n";
            Luck_fast = rand() % 100 + 1;
            enemy_attack = (rand() % 50 + 1) - (defend_user / 2);
            if (Luck_fast <= fast_user)
            {
                std::cout << "\n\tВы уклонились\n";

                return 0; 
            }
            std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
            return enemy_attack;
            break;
        case 2:
            std::cout << "                  \tКласс Врага: " << ENEMY1 << " | Здоровье: " << health_enemy << "\n";
            std::cout << "                  \tАтакует с помощью: " << hit_ENEMY1_2 << "\n";
            Luck_fast = rand() % 100 + 1;
            if (Luck_fast <= fast_user)
            {
                std::cout << "\n\tВы уклонились\n";
                return 0;
            }
            enemy_attack = (rand() % 70 + 1) - (defend_user / 2);
            std::cout << "                 Нанесен урон: " << enemy_attack << "\n";
            return enemy_attack;
            break;
        }
      
    }

    void Minus_Hp(int Attack_power)
    {
        health_enemy -= Attack_power;
    }

    void regeneretion()
    {
        health_enemy = health_enemy_h;
    }
};

//================================================================================================================================================

/*class Archer final : public Hero 
{
private:
    int arrow;
public:
    Archer(int _strong, int _health, int _intelect, int _fast, int _defend, int _magical, int _mana, string _nameUser)
        : Hero{ _strong,_health, _intelect, _fast, _defend, _magical, _mana, _nameUser }
    {
        std::cout << "ctor Archer!\n";
    }
    //void attack() override 
    //{
    //    //c.hp -= this->damage;
    //    std::cout << "attack one player from Archer!\n";
    //    isDead();
    //}
    ~Archer()
    {
        std::cout << "~ Archer!\n";
    }
    void shot(Enemy1& c) {
        Hero::attack(c);
        arrow--;
    }
};

class Warrior final : public Hero 
{
private:

public:
    Warrior(int _strong, int _health, int _intelect, int _fast, int _defend, int _magical, int _mana, string _nameUser)
        : Hero{ _strong,_health, _intelect, _fast, _defend, _magical, _mana, _nameUser }
    {
        
    }
    
    ~Warrior()
    {
        
    }
    void shoot(Enemy1& c) 
    {
        Hero::attack(c);
   
        std::cout << "attacked";
        std::cout  << std::endl;
    }
};
class Magic final : public Hero
{
protected:
    int ammo;
public:
    Magic(int _strong, int _health, int _intelect, int _fast, int _defend, int _magical, int _mana, string _nameUser)
        : Hero{ _strong,_health, _intelect, _fast, _defend, _magical, _mana, _nameUser }
    {

    }


    ~Magic()
    {

    }
};
*/

//================================================================================================================================================

class Arena : public Hero, public Enemy1 // Еще не доделанная, Переменная = возврат урона Героя (Врага)
{ //Здоровье врага -= Переменная                         По такому принципу
protected:
    int Attack_power;
    int fast_user;
    int defend_user;
    int Health_User;
public:
    void set_all_user(Hero& obj)
    {
        fast_user = obj.Get_Fast();
        defend_user = obj.Get_Defend();
        Health_User = obj.Get_Health();
    }

    void set_attack(int a)
    {
        Attack_power = a;
    }
};

//================================================================================================================================================

class Saver 
{
public:
    Saver()
    {

    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    void saveLvlarea(Hero& obj)
    {
        std::ofstream out_file("LVL_area_hero.txt"); //, std::fstream::app
        out_file << obj.levelArea;
        out_file.close();
        std::cout << "\nSaved Lvl of area!\n";
        system("pause");
    }
    void saveLvlHero(Hero& obj)
    {
        std::ofstream out_file("LVL_hero.txt"); //, std::fstream::app
        out_file << obj.level;
        out_file.close();
        std::cout << "\nSaved Lvl of Hero!\n";
        system("pause");
    }
    void saveMoneyHero(Hero& obj)
    {
        std::ofstream out_file("Money_hero.txt"); //, std::fstream::app
        out_file << obj.money;
        out_file.close();
        std::cout << "\nSaved money of Hero!\n";
        system("pause");
    }
    void saveNowxpHero(Hero& obj)
    {
        std::ofstream out_file("XP_hero.txt"); //, std::fstream::app
        out_file << obj.xpnow;
        out_file.close();
        std::cout << "\nSaved xp of Hero!\n";
        system("pause");
    }
    void saveHealPotion(Hero& obj)
    {
        std::ofstream out_file("HealPotion_hero.txt"); //, std::fstream::app
        out_file << obj.HealHero_potion;
        out_file.close();
        std::cout << "\nSaved Heal potion of Hero!\n";
        system("pause");
    }
    void saveManaPotion(Hero& obj)
    {
        std::ofstream out_file("ManaPotion_hero.txt"); //, std::fstream::app
        out_file << obj.ManaHero_potion;
        out_file.close();
        std::cout << "\nSaved Mana potion of Hero!\n";
        system("pause");
    }
    void saveAttackPotion(Hero& obj)
    {
        std::ofstream out_file("AttackPotion_hero.txt"); //, std::fstream::app
        out_file << obj.AttackHero_potion;
        out_file.close();
        std::cout << "\nSaved Attack potion of Hero!\n";
        system("pause");
    }
    void saveDefendPotion(Hero& obj)
    {
        std::ofstream out_file("DefendPotion_hero.txt"); //, std::fstream::app
        out_file << obj.DefendHero_potion;
        out_file.close();
        std::cout << "\nSaved Defend potion of Hero!\n";
        system("pause");
    }
    void saveNameHero(Hero& obj)
    {
        std::ofstream out_file("Hero_Name.txt"); //, std::fstream::app
        out_file << obj.nameUser;
        out_file.close();
        std::cout << "\nSaved name of Hero!\n";
        system("pause");
    }
    void savehit1(Hero& obj)
    {
        std::ofstream out_file("Hit_1.txt"); //, std::fstream::app
        out_file << obj.hit_1;
        out_file.close();
        std::cout << "\nSaved hit_1 of Hero!\n";
        system("pause");
    }
    void savehit2(Hero& obj)
    {
        std::ofstream out_file("Hit_2.txt"); //, std::fstream::app
        out_file << obj.hit_2;
        out_file.close();
        std::cout << "\nSaved hit_2 of Hero!\n";
        system("pause");
    }
    void savehit3(Hero& obj)
    {
        std::ofstream out_file("Hit_3.txt"); //, std::fstream::app
        out_file << obj.hit_3;
        out_file.close();
        std::cout << "\nSaved hit_3 of Hero!\n";
        system("pause");
    }
    void savehit4(Hero& obj)
    {
        std::ofstream out_file("Hit_4.txt"); //, std::fstream::app
        out_file << obj.hit_4;
        out_file.close();
        std::cout << "\nSaved hit_4 of Hero!\n";
        system("pause");
    }
    void savestrongHero(Hero& obj)
    {
        std::ofstream out_file("Strong_hero.txt"); //, std::fstream::app
        out_file << obj.strong;
        out_file.close();
        std::cout << "\nSaved strong of Hero!\n";
        system("pause");
    }
    void savehealthHero(Hero& obj)
    {
        std::ofstream out_file("Health_hero.txt"); //, std::fstream::app
        out_file << obj.health;
        out_file.close();
        std::cout << "\nSaved health of Hero!\n";
        system("pause");
    }
    void saveintelectHero(Hero& obj)
    {
        std::ofstream out_file("Intelect_hero.txt"); //, std::fstream::app
        out_file << obj.intelect;
        out_file.close();
        std::cout << "\nSaved intelect of Hero!\n";
        system("pause");
    }
    void savefastHero(Hero& obj)
    {
        std::ofstream out_file("Fast_hero.txt"); //, std::fstream::app
        out_file << obj.fast;
        out_file.close();
        std::cout << "\nSaved fast of Hero!\n";
        system("pause");
    }
    void savedefendHero(Hero& obj)
    {
        std::ofstream out_file("Hero_Defend.txt"); //, std::fstream::app
        out_file << obj.defend;
        out_file.close();
        std::cout << "\nSaved defend of Hero!\n";
        system("pause");
    }
    void savemagicalHero(Hero& obj)
    {
        std::ofstream out_file("Magical_hero.txt"); //, std::fstream::app
        out_file << obj.magical;
        out_file.close();
        std::cout << "\nSaved magical of Hero!\n";
        system("pause");
    }
    void savemanaHero(Hero& obj)
    {
        std::ofstream out_file("Mana_hero.txt"); //, std::fstream::app
        out_file << obj.mana;
        out_file.close();
        std::cout << "\nSaved mana of Hero!\n";
        system("pause");
    }
    void savenewLvlPLUS(Hero& obj)
    {
        std::ofstream out_file("NewLvl.txt"); //, std::fstream::app
        out_file << obj.newLvlPLUS;
        out_file.close();
        std::cout << "\nSaved mana of Hero!\n";
        system("pause");
    }
    void Save_Class_Hero(Hero& obj)
    {
        std::ofstream out_file("Class_hero.txt"); //, std::fstream::app
        out_file << obj.Class_Hero;
        out_file.close();
        std::cout << "\nSaved class of Hero!\n";
        system("pause");
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    void Save(Hero& obj)
    {
        std::ofstream out;
        out.open("Save.txt");
        if (out.is_open())
        {
            saveLvlarea(obj);
            saveManaPotion(obj);
            saveAttackPotion(obj);
            saveMoneyHero(obj);
            saveNowxpHero(obj);
            saveLvlHero(obj);
            saveHealPotion(obj);
            saveDefendPotion(obj);
            saveNameHero(obj);
            savestrongHero(obj);
            savehealthHero(obj);
            saveintelectHero(obj);
            savefastHero(obj);
            savedefendHero(obj);
            savemagicalHero(obj);
            savemanaHero(obj);
            savenewLvlPLUS(obj);
            Save_Class_Hero(obj);
            savehit1(obj);
            savehit2(obj);
            savehit3(obj);
            savehit4(obj);
        }
        else
        {

            std::cout << "Error";
        }
        out.close();
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    ~Saver()
    {

    }
};        

//================================================================================================================================================

class Loader 
{
public:
    Loader()
    {

    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    int LOADLvlarea()
    {
        std::ifstream input_file("LVL_area_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADLvlHero()
    {
        std::ifstream input_file("LVL_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADMoneyHero()
    {
        std::ifstream input_file("Money_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADNowxpHero()
    {
        std::ifstream input_file("XP_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADHealPotion()
    {
        std::ifstream input_file("HealPotion_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADManaPotion()
    {
        std::ifstream input_file("ManaPotion_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADAttackPotion()
    {
        std::ifstream input_file("AttackPotion_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADDdefendPotion()
    {
        std::ifstream input_file("DefendPotion_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    string LOADNameHero()
    {
        string str;
        std::ifstream input_file("Hero_Name.txt");
        input_file >> str;
        std::cout << str << std::endl;
        input_file.close();
        return str;
    }
    string LOADhit1()
    {
        string str;
        std::ifstream input_file("Hit_1.txt");
        input_file >> str;
        std::cout << str << std::endl;
        input_file.close();
        return str;
    }
    string LOADhit2()
    {
        string str;
        std::ifstream input_file("Hit_2.txt");
        input_file >> str;
        std::cout << str << std::endl;
        input_file.close();
        return str;
    }
    string LOADhit3()
    {
        string str;
        std::ifstream input_file("Hit_3.txt");
        input_file >> str;
        std::cout << str << std::endl;
        input_file.close();
        return str;
    }
    string LOADhit4()
    {
        string str;
        std::ifstream input_file("Hit_4.txt");
        input_file >> str;
        std::cout << str << std::endl;
        input_file.close();
        return str;
    }
    string LOADClassHero()
    {
        string str;
        std::ifstream input_file("Class_hero.txt");
        input_file >> str;
        std::cout << str << std::endl;
        input_file.close();
        return str;
    }
    int LOADstrongHero()
    {
        std::ifstream input_file("Strong_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADhealthHero()
    {
        std::ifstream input_file("Health_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADintelectHero()
    {
        std::ifstream input_file("Intelect_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADfastHero()
    {
        std::ifstream input_file("Fast_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADdefendHero()
    {
        std::ifstream input_file("Hero_Defend.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADmagicalHero()
    {
        std::ifstream input_file("Magical_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADmanaHero()
    {
        std::ifstream input_file("Mana_hero.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    int LOADnewLvlPLUS()
    {
        std::ifstream input_file("NewLvl.txt");
        string s;
        getline(input_file, s);
        int n;
        n = atoi(s.c_str());
        std::cout << s << std::endl;
        input_file.close();
        return n;
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------------------------------------------------------------------
    Hero Load(Hero& obj)
    {
        obj.levelArea = LOADLvlarea();
        obj.level = LOADLvlHero();
        obj.money = LOADMoneyHero();
        obj.xpnow = LOADNowxpHero();
        obj.HealHero_potion = LOADHealPotion();
        obj.ManaHero_potion = LOADManaPotion();
        obj.AttackHero_potion = LOADAttackPotion();
        obj.DefendHero_potion = LOADDdefendPotion();
        obj.nameUser = LOADNameHero();
        obj.Class_Hero = LOADClassHero();
        obj.strong = LOADstrongHero();
        obj.health = LOADhealthHero();
        obj.intelect = LOADintelectHero();
        obj.fast = LOADfastHero();
        obj.defend = LOADdefendHero();
        obj.magical = LOADmagicalHero();
        obj.mana = LOADmanaHero();
        obj.newLvlPLUS = LOADnewLvlPLUS();
        obj.hit_1 = LOADhit1();
        obj.hit_2 = LOADhit2();
        obj.hit_3 = LOADhit3();
        obj.hit_4 = LOADhit4();
        return obj;
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    ~Loader()
    {

    }
};

//================================================================================================================================================

class Shop 
{
public:
    Shop()
    {

    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------------------------------------------------------------------
    void Buy(Hero& obj)
    {
        int Choise_shop;
        system("cls");
        std::cout << "\tКоличество ваших Золотых монет: " << obj.money << "\n\n";
        std::cout << "\tПредметы на продажу: \n";
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
        std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
        std::cout << "|50 - ЗМ |" << "    |50 - ЗМ |" << "    |50 - ЗМ |" << "    |50 - ЗМ |" << "\n";
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n\n";
        do
        {
            std::cout << "Выберите предмет для покупки: ";
            std::cin >> Choise_shop;
        } while (Choise_shop < 1 || Choise_shop > 4);
        switch (Choise_shop)
        {
        case 1:
            if (obj.money < 50)
            {
                std::cout << "\n" << "Не достаточно золотых монет\n\n";
                system("pause");
            }
            else
            {
                obj.HealHero_potion++;
                obj.money -= 50;
            }
            break;
        case 2:
            if (obj.money < 50)
            {
                std::cout << "\n" << "Не достаточно золотых монет\n\n";
                system("pause");
            }
            else
            {
                obj.ManaHero_potion++;
                obj.money -= 50;
            }
            break;
        case 3:
            if (obj.money < 50)
            {
                std::cout << "\n" << "Не достаточно золотых монет\n\n";
                system("pause");
            }
            else
            {
                obj.AttackHero_potion++;
                obj.money -= 50;
            }
            break;
        case 4:
            if (obj.money < 50)
            {
                std::cout << "\n" << "Не достаточно золотых монет\n\n";
                system("pause");
            }
            else
            {
                obj.DefendHero_potion++;
                obj.money -= 50;
            }
            break;
        }
        std::cout << "Ваши зелья: \n\n";
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
        std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
        std::cout << "|kolvo: " << obj.HealHero_potion << "|" << "    |kolvo: " << obj.ManaHero_potion << "|" << "    |kolvo: " << obj.AttackHero_potion << "|" << "    |kolvo: " << obj.DefendHero_potion << "|" << "\n";
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
        system("pause");
   }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------------------------------------------------------------------
    ~Shop()
    {

    }
};

//================================================================================================================================================

class Inventory
{
public:
    Inventory()
    {

    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    void My_Inv(Hero& obj)
    {
        std::cout << "Ваши зелья: \n\n";
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
        std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
        std::cout << "|kolvo: " << obj.HealHero_potion << "|" << "    |kolvo: " << obj.ManaHero_potion << "|" << "    |kolvo: " << obj.AttackHero_potion << "|" << "    |kolvo: " << obj.DefendHero_potion << "|" << "\n";
        std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n\n";
        system("pause");
        std::cout << "\n\n У вас пока нет экипировки\n\n";
        system("pause");
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    ~Inventory()
    {

    }
};

//================================================================================================================================================


int main()
{
    setlocale(LC_ALL, "rus");
   
   /* Hero hero;*/
   /*Saver s;
   s.Save(hero);*/

   /*Hero h;
   Loader l;
   l.Load(h);
   h.Show();
   Inventory i;*/

  ///* hero.Make_Choice_UP();
  // system("cls");
   

           //Shop sh;
           //sh.Buy(hero);
   
           //hero.Get_money();
    Hero hero;
   int game;
   int UserChoiceHERO;
   char AcceptHero;
   string name;
  /* std::cout << "Enter ur name, wonderer: ";
   std::cin >> name;
   Hero hero(30, 500, 30, 40, 15, 0, 100, name, "Hit_1 - Выстрел - 10 маны ", "Hit_2 -Выстрел ядовитой стрелой - 20 маны", "Hit_3 -Вылетающий клинок - 30 маны", "Hit_4 - 1000 ударов - 40 маны", "Archer");*/
  /* do
   {
       std::cout << "Continue or New Game?: ";
       std::cin >> game;
           std::cout << endl;
   } while (game < 1 || game > 2);
   switch (game)
   {
   case 1:
       
       l.Load(hero);
       break;
   case 2:
       system("cls");
      do
      {
          system("cls");
          do
          {
              std::cout << "What`s Your name wanderer?: ";
              std::cin >> name;
              system("cls");
              std::cout << "Welcome, " << name;
              std::cout << "\n\n\tChoose ur class: ";
              std::cout << endl;
              std::cout << "\t" << "Клас героев:" << endl
                  << "1) Воин" << endl
                  << "2) Лучник" << endl
                  << "3) Маг" << endl;
              std::cout << "\t" << "Ваш выбор: ";
              std::cin >> UserChoiceHERO;
              system("cls");
              info_about_skill_Character();
          } while (UserChoiceHERO < 0 || UserChoiceHERO>3);
          if (UserChoiceHERO == 1)
          {
             
              printf("\tКлас героя: %s%s", "Warrior", "\n");
              printf("\tСила: %d%s", 50, "\n");
              printf("\tЗдоровье: %d%s", 700, "\n");
              printf("\tИнтелект: %d%s", 10, "\n");
              printf("\tCкорость: %d%s", 10, "\n");
              printf("\tЗащита: %d%s", 50, "\n");
              printf("\tМана: %d%s", 50, "\n\n");
              std::cout << "\t" << "Умения: " << endl;
              printf("\nHit_1 - Удар мечом - 10 маны");
              printf("\nHit_2 - Точный удар - 20 маны");
              printf("\nHit_3 - Вылетающий клинок - 30 маны");
              printf("\nHit_4 - 1000 ударов - 40 маны");
              
                 
              do
              {
                  std::cout << "\t" << "Вы подтверждаете выбор(Y/N): ";
                  std::cin >> AcceptHero;
              } while (AcceptHero != 'Y' && AcceptHero != 'y' && AcceptHero != 'N' && AcceptHero != 'n');
              if (AcceptHero == 'Y' || AcceptHero == 'y')
              {
                  Hero hero1(50, 700, 10, 10, 50, 0, 50, name, "Hit_1 - Удар мечом - 10 маны 1", "Hit_2 -Точный удар - 20 маны", "Hit_3 -Вылетающий клинок - 30 маны", "Hit_4 - 1000 ударов - 40 маны", "Warrior");
                  hero(hero1);
              }
          }
          if (UserChoiceHERO == 2)
          {
              printf("\tКлас героя: %s%s", "Archer", "\n");
              printf("\tСила: %d%s", 30, "\n");
              printf("\tЗдоровье: %d%s", 500, "\n");
              printf("\tИнтелект: %d%s", 30, "\n");
              printf("\tCкорость: %d%s", 40, "\n");
              printf("\tЗащита: %d%s", 15, "\n");
              printf("\tМана: %d%s", 100, "\n\n");
              std::cout << "\t" << "Умения: " << endl;
              printf("\nHit_1 - Выстрел - 10 маны");
              printf("\nHit_2 - Выстрел ядовитой стрелой - 20 маны");
              printf("\nHit_3 - Точный Выстрел - 30 маны");
              printf("\nHit_4 - Очередь выстрелов - 40 маны");   
              do
              {
                  std::cout << "\t" << "Вы подтверждаете выбор(Y/N): ";
                  std::cin >> AcceptHero;
              } while (AcceptHero != 'Y' && AcceptHero != 'y' && AcceptHero != 'N' && AcceptHero != 'n');
              if (AcceptHero == 'Y' || AcceptHero == 'y')
              {
                  Hero hero2(30, 500, 30, 40, 15, 0, 100, name, "Hit_1 -Выстрел - 10 маны", "Hit_2 -Выстрел ядовитой стрелой - 20 маны", "Hit_3 -Точный Выстрел - 30 маны", "Hit_4 -Очередь выстрелов - 40 маны", "Archer");
                  hero(hero2);
              }
          }
          if (UserChoiceHERO == 3)
          {
              printf("\tКлас героя: %s%s","Wizard", "\n");
              printf("\tСила: %d%s", 45, "\n");
              printf("\tЗдоровье: %d%s", 300, "\n");
              printf("\tИнтелект: %d%s", 40, "\n");
              printf("\tМагическая сила: %d%s", 20, "\n");
              printf("\tЗащита: %d%s", 10, "\n");
              printf("\tМана: %d%s", 150, "\n\n");
              std::cout << "\t" << "Умения: " << endl;
              printf("\nHit_1 - Удар палкой по голове - 10 маны");
              printf("\nHit_2 - Удар молнией - 20 маны");
              printf("\nHit_3 - Фаер-бол - 30 маны");
              printf("\nHit_4 - Метеоритный дождь - 40 маны");
              
              do
              {
                  std::cout << "\t" << "Вы подтверждаете выбор(Y/N): ";
                  std::cin >> AcceptHero;
              } while (AcceptHero != 'Y' && AcceptHero != 'y' && AcceptHero != 'N' && AcceptHero != 'n');
              if (AcceptHero == 'Y' || AcceptHero == 'y')
              {
                  Hero hero3(45, 300, 40, 40, 0, 10, 150, name, "Hit_1 -Выстрел - 10 маны", "Hit_2 -Выстрел ядовитой стрелой - 20 маны", "Hit_3 -Точный Выстрел - 30 маны", "Hit_4 -Очередь выстрелов - 40 маны", "Archer");
                  hero(hero3);
              }
          }
          system("cls");
      } while (AcceptHero != 'Y' && AcceptHero != 'y');
       break;
 }


*/


Loader l;
l.Load(hero);

   int Choice;
   Shop shop;
   Inventory inventory;
   Saver save;
   do
   {
       do
       {
           hero.profile();
           hero.HeroUr();
           printf("\n\tПрофиль: 1 | Начать бой: 2 | Покупка снаряжения: 3 | Инвентарь: 4 | Сохранить: 5 | Выход: 6\n");

           printf("\tВыбор: ");
           std::cin >> Choice;
           printf("\n");
       } while (Choice < 1 || Choice > 6);


       switch (Choice)
       {
       case 1:
           hero.Make_Choice_UP();
           break;
       case 2:

           break;
       case 3:
           shop.Buy(hero);
           break;
       case 4:
           inventory.My_Inv(hero);
           break;
       case 5:
           save.Save(hero);
       }
   } while (Choice != 6);





 //   Enemy1 e;
 //   Arena a;
 //   a.set_all_user(hero);
 //   while(!hero.isDead() && !e.isDead())
 //   {
 //       hero.Make_choice_fight();
 //       
 //       if (e.isDead())
 //       {
 //           std::cout << "\n\nYOU WIN\n\n";
 //       }
 //       else
 //       {
 //           e.attack();
 //           hero.Minus_Hp();
 //           if (hero.isDead())
 //           {
 //               std::cout << "\n\nYOU LOSE\n\n";
 //           }
 //       }
 //       
 //}
    



//
//    
//    //
//    srand(time(NULL));
//    //
//    char name[20];
//    std::cout << "Введите имя вашего героя: ";
//    cin.getline(name, 20);
//    system("cls");
//    std::cout << "\t1) Продолжить игру\n"
//        << "\t2) Новая игра\n";
//    int NewOrContinue;
//    do
//    {
//        std::cout << "Ваш выбор: ";
//        std::cin >> NewOrContinue;
//        if (LOADhealthHero() == 0)
//        {
//            NewOrContinue = 2;
//        }
//    } while (NewOrContinue < 1 || NewOrContinue>2);
//
//    string hit_1, hit_2, hit_3, hit_4;
//    int strong = 0;
//    int health = 0;
//    int intelect = 0;
//    int fast = 0;
//    int defend = 0;
//    int magical = 0;
//    int mana = 0;
//    int UserChoiceHERO;
//    char AcceptHero;
//    char* nameUser = new char[20];
//    int level;
//    int levelArea;
//    int money;
//    int xpnow;
//    int newLvlPLUS;
//    //
//    int HealHero_potion;
//    int ManaHero_potion;
//    int AttackHero_potion;
//    int DefendHero_potion;
//    //
//    switch (NewOrContinue)
//    {
//    case 1:
//        system("cls");
//        std::cout << "\n\tВаши достижения при последнем сохранении: \n\n";
//        std::cout << "\nLVL arena: ";
//        levelArea = LOADLvlarea();
//        std::cout << "\nLVL Hero: ";
//        level = LOADLvlHero();
//        std::cout << "\nMoney: ";
//        money = LOADMoneyHero();
//        std::cout << "\nXP: ";
//        xpnow = LOADNowxpHero();
//        std::cout << "\nChoice of Class: ";
//        UserChoiceHERO = LOADChoiceHero();
//        std::cout << "\nHeal potion kol-vo: ";
//        HealHero_potion = LOADHealPotion();
//        std::cout << "\nMana potion kol-vo: ";
//        ManaHero_potion = LOADManaPotion();
//        std::cout << "\nAttack potion kol-vo: ";
//        AttackHero_potion = LOADAttackPotion();
//        std::cout << "\nDefend potion kol-vo: ";
//        DefendHero_potion = LOADDdefendPotion();
//        std::cout << "\nName: ";
//        nameUser = LOADNameHero(nameUser);
//        std::cout << "\nStrong: ";
//        strong = LOADstrongHero();
//        std::cout << "\nHealth: ";
//        health = LOADhealthHero();
//        std::cout << "\nIntelect: ";
//        intelect = LOADintelectHero();
//        std::cout << "\nFast: ";
//        fast = LOADfastHero();
//        std::cout << "\nDefend: ";
//        defend = LOADdefendHero();
//        std::cout << "\nMagic: ";
//        magical = LOADmagicalHero();
//        std::cout << "\nMana: ";
//        mana = LOADmanaHero();
//        std::cout << "\nPoints LvL: ";
//        newLvlPLUS = LOADnewLvlPLUS();
//        system("pause");
//        break;
//    case 2:
//        system("cls");
//        do
//        {
//            system("cls");
//            do
//            {
//                system("cls");
//                std::ofstream out_file("HeroName.txt"); //, std::fstream::app
//                out_file << name;
//                out_file.close();
//                std::cout << "\n\nWelcome, ";
//                nameUser = LOADNameHero(nameUser);
//                system("pause");
//                std::cout << endl;
//                std::cout << "\t" << "Клас героев:" << endl
//                    << "1) Воин" << endl
//                    << "2) Лучник" << endl
//                    << "3) Маг" << endl;
//                std::cout << "\t" << "Ваш выбор: ";
//                std::cin >> UserChoiceHERO;
//                system("cls");
//                info_about_skill_Character();
//            } while (UserChoiceHERO < 0 || UserChoiceHERO>3);
//            if (UserChoiceHERO == 1)
//            {
//                printf("\tКлас героя: %s%s", ClasWarrior(), "\n");
//                strong += 50;
//                printf("\tСила: %d%s", strong, "\n");
//                health += 700;
//                printf("\tЗдоровье: %d%s", health, "\n");
//                intelect += 10;
//                printf("\tИнтелект: %d%s", intelect, "\n");
//                fast += 10;
//                printf("\tCкорость: %d%s", fast, "\n");
//                defend += 50;
//                printf("\tЗащита: %d%s", defend, "\n");
//                mana += 50;
//                printf("\tМана: %d%s", mana, "\n\n");
//                hit_1 = "Удар мечом - 10 маны";
//                hit_2 = "Точный удар - 20 маны";
//                hit_3 = "Вылетающий клинок - 30 маны";
//                hit_4 = "1000 ударов - 40 маны";
//                std::cout << "\t" << "Умения: " << endl
//                    << "1) " << hit_1 << endl
//                    << "2) " << hit_2 << endl
//                    << "3) " << hit_3 << endl
//                    << "4) " << hit_4 << endl << endl;
//                do
//                {
//                    std::cout << "\t" << "Вы подтверждаете выбор(Y/N): ";
//                    std::cin >> AcceptHero;
//                } while (AcceptHero != 'Y' && AcceptHero != 'y' && AcceptHero != 'N' && AcceptHero != 'n');
//                if (AcceptHero == 'N' || AcceptHero == 'n')
//                {
//                    strong = 0;
//                    health = 0;
//                    intelect = 0;
//                    fast = 0;
//                    defend = 0;
//                    magical = 0;
//                    mana = 0;
//                }
//            }
//            if (UserChoiceHERO == 2)
//            {
//                printf("\tКлас героя: %s%s", ClasLuchnik(), "\n");
//                strong += 30;
//                printf("\tСила: %d%s", strong, "\n");
//                health += 500;
//                printf("\tЗдоровье: %d%s", health, "\n");
//                intelect += 30;
//                printf("\tИнтелект: %d%s", intelect, "\n");
//                fast += 40;
//                printf("\tCкорость: %d%s", fast, "\n");
//                defend += 15;
//                printf("\tЗащита: %d%s", defend, "\n");
//                mana += 100;
//                printf("\tМана: %d%s", mana, "\n\n");
//                hit_1 = "Выстрел - 10 маны";
//                hit_2 = "Выстрел ядовитой стрелой - 20 маны";
//                hit_3 = "Точный Выстрел - 30 маны";
//                hit_4 = "Очередь выстрелов - 40 маны";
//                std::cout << "\t" << "Умения: " << endl
//                    << "1) " << hit_1 << endl
//                    << "2) " << hit_2 << endl
//                    << "3) " << hit_3 << endl
//                    << "4) " << hit_4 << endl << endl;
//                do
//                {
//                    std::cout << "\t" << "Вы подтверждаете выбор(Y/N): ";
//                    std::cin >> AcceptHero;
//                } while (AcceptHero != 'Y' && AcceptHero != 'y' && AcceptHero != 'N' && AcceptHero != 'n');
//                if (AcceptHero == 'N' || AcceptHero == 'n')
//                {
//                    strong = 0;
//                    health = 0;
//                    intelect = 0;
//                    fast = 0;
//                    defend = 0;
//                    magical = 0;
//                    mana = 0;
//                }
//            }
//            if (UserChoiceHERO == 3)
//            {
//                printf("\tКлас героя: %s%s", ClasMagic(), "\n");
//                strong += 45;
//                printf("\tСила: %d%s", strong, "\n");
//                health += 300;
//                printf("\tЗдоровье: %d%s", health, "\n");
//                intelect += 40;
//                printf("\tИнтелект: %d%s", intelect, "\n");
//                magical += 20;
//                printf("\tМагическая сила: %d%s", magical, "\n");
//                defend += 10;
//                printf("\tЗащита: %d%s", defend, "\n");
//                mana += 150;
//                printf("\tМана: %d%s", mana, "\n\n");
//                hit_1 = "Удар палкой по голове - 10 маны";
//                hit_2 = "Удар молнией - 20 маны";
//                hit_3 = "Фаер-бол - 30 маны";
//                hit_4 = "Метеоритный дождь - 40 маны";
//                std::cout << "\t" << "Умения: " << endl
//                    << "1) " << hit_1 << endl
//                    << "2) " << hit_2 << endl
//                    << "3) " << hit_3 << endl
//                    << "4) " << hit_4 << endl << endl;
//                do
//                {
//                    std::cout << "\t" << "Вы подтверждаете выбор(Y/N): ";
//                    std::cin >> AcceptHero;
//                } while (AcceptHero != 'Y' && AcceptHero != 'y' && AcceptHero != 'N' && AcceptHero != 'n');
//                if (AcceptHero == 'N' || AcceptHero == 'n')
//                {
//                    strong = 0;
//                    health = 0;
//                    intelect = 0;
//                    fast = 0;
//                    defend = 0;
//                    magical = 0;
//                    mana = 0;
//                }
//            }
//            system("cls");
//        } while (AcceptHero != 'Y' && AcceptHero != 'y');
//        //
//        level = 1;
//        levelArea = 1;
//        money = 200;
//        xpnow = 0;
//        newLvlPLUS = 1;
//        int Peremenaya = 1;
//
//        HealHero_potion = 1;
//        ManaHero_potion = 1;
//        AttackHero_potion = 1;
//        DefendHero_potion = 1;
//        break;
//
//    }
//    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//    int fight_HP = health;
//    int fight_defend = defend;
//    int Choice_fight;
//    int Mana_fight = mana;
//    int fight_strong = strong;
//    int checker = 1;
//    char Choice_arena;
//    int kolvo_max_potion = 0;
//    int health_enemy = 0;
//    int new_bot;
//    int LuckIntelect;
//    int Give_Potion;
//    //
//    int Choice;
//    do
//    {
//        system("cls");
//        profile(level, nameUser, UserChoiceHERO, health, mana, strong, money);
//        HeroUr(UserChoiceHERO);
//        printf("\n\tПрофиль: 1 | Начать бой: 2 | Покупка снаряжения: 3 | Инвентарь: 4 | Сохранить: 5 | Выход: 6\n");
//        do
//        {
//            printf("\tВыбор: ");
//            std::cin >> Choice;
//            printf("\n");
//        } while (Choice < 1 || Choice > 6);
//        switch (Choice)
//        {
//        case 1:
//            system("cls");
//            profile(level, nameUser, UserChoiceHERO, health, mana, strong, money);
//            int ChoiceInfo;
//            if (UserChoiceHERO == 2 || UserChoiceHERO == 1)
//            {
//                printf("\n\tCкорость: %d%s", fast, "\n");
//            }
//            if (UserChoiceHERO == 3)
//            {
//                printf("\tМагическая сила: %d%s", magical, "\n");
//            }
//            printf("\tИнтелект: %d%s", intelect, "\n");
//            printf("\tЗащита: %d%s", defend, "\n");
//            printf("\tЗолотых монет: %d%s", money, "\n");
//            printf("\tУ вас есть: %d%s", newLvlPLUS, " очков прокачки\n");
//            std::cout << "\tПродвижение по уровням: ";
//            std::cout << xpnow << "/";
//            std::cout << newLVL(level, xpnow) << endl << endl;
//            std::cout << "\t" << "Выбирите действие: " << endl
//                << "\t" << "1) Потратить очки" << endl
//                << "\t" << "2) Выход" << endl
//                << "\t" << "Ваш выбор: ";
//            do
//            {
//                std::cin >> ChoiceInfo;
//            } while (ChoiceInfo < 0 || ChoiceInfo > 2);
//            if (ChoiceInfo == 1)
//            {
//                if (newLvlPLUS == 0)
//                {
//                    printf("\nНедостаточно очков\n\n");
//                    system("pause");
//                    system("cls");
//                }
//                else
//                {
//                    int Choice;
//                    std::cout << "\n\nВыбирите куда потратить очки: \n";
//                    std::cout << "1) Сила: " << strong << endl;
//                    std::cout << "2) Здоровье: " << health << "HP" << endl;
//                    std::cout << "3) Ловкость: " << fast << endl;
//                    std::cout << "4) Интеллект: " << intelect << endl;
//                    std::cout << "5) Магическая сила: " << magical << endl;
//                    std::cout << "6) Защита: " << defend << endl;
//                    std::cout << "7) Мана: " << mana << endl;
//                    do
//                    {
//                        std::cout << "\t" << "Выбирите куда потратить очки: ";
//                        std::cin >> Choice;
//                    } while (Choice < 0 || Choice > 7);
//                    switch (Choice)
//                    {
//                    case 1:
//                        strong += 20;
//                        std::cout << "\n\tСила: " << strong << endl;
//                        newLvlPLUS--;
//                        break;
//                    case 2:
//                        health += 100;
//                        std::cout << "\n\tЗдоровье: " << health << endl;
//                        newLvlPLUS--;
//                        break;
//                    case 3:
//                        if (UserChoiceHERO == 1 || UserChoiceHERO == 2)
//                        {
//                            fast += 5;
//                            std::cout << "\n\tЛовкость: " << fast << endl;
//                            newLvlPLUS--;
//                            break;
//                        }
//                        else
//                        {
//                            std::cout << "\n\tУ вас нету возможности прокачивать эту ветку ";
//                            system("pause");
//                        }
//                        break;
//                    case 4:
//                        intelect += 2;
//                        std::cout << "\n\tИнтеллект: " << intelect << endl;
//                        newLvlPLUS--;
//                        break;
//                    case 5:
//                        if (UserChoiceHERO == 3)
//                        {
//                            magical += 50;
//                            std::cout << "\n\tМагическая сила: " << magical << endl;
//                            newLvlPLUS--;
//                            break;
//                        }
//                        else
//                        {
//                            std::cout << "\n\tУ вас нету возможности прокачивать эту ветку ";
//                            system("pause");
//                        }
//                        break;
//                    case 6:
//                        defend += 25;
//                        std::cout << "\n\tЗащита: " << defend << endl;
//                        newLvlPLUS--;
//                        break;
//                    case 7:
//                        mana += 5;
//                        std::cout << "\n\tМана: " << mana << endl;
//                        newLvlPLUS--;
//                        break;
//                    }
//                }
//            }
//            else
//            {
//                system("pause");
//                system("cls");
//            }
//            break;
//            //==========================================================================
//            //==========================================================================
//            //==========================================================================
//            //==========================================================================
//            //==========================================================================
//        case 2:
//            system("cls");
//            profile(level, nameUser, UserChoiceHERO, health, mana, strong, money);
//            std::cout << "\n\n\n                                                _____\n";
//            std::cout << "                                         \t| " << levelArea << " |\n";
//            std::cout << "                                         \t-----\n\n";
//            do
//            {
//                std::cout << "Продолжить?(Y/N): ";
//                std::cin >> Choice_arena;
//            } while (Choice_arena != 'Y' && Choice_arena != 'y' && Choice_arena != 'N' && Choice_arena != 'n');
//            if (Choice_arena == 'Y' || Choice_arena == 'y')
//            {
//                fight_HP = health;
//                fight_defend = defend;
//                Choice_fight;
//                Mana_fight = mana;
//                fight_strong = strong;
//                system("cls");
//                profile(level, nameUser, UserChoiceHERO, fight_HP, Mana_fight, strong, money);
//                HeroUr(UserChoiceHERO);
//                new_bot = rand() % 4 + 1;
//                int health_enemy = 0;
//                switch (new_bot)
//                {
//                case 1:
//                    health_enemy += 200;
//                    break;
//                case 2:
//                    health_enemy += 250;
//                    break;
//                case 3:
//                    health_enemy += 300;
//                    break;
//                case 4:
//                    health_enemy += 400;
//                    break;
//                }
//                do
//                {
//                    do
//                    {
//                        Mana_fight += 15;
//                        fight_defend = defend;
//                        if (Mana_fight > mana)
//                        {
//                            Mana_fight = mana;
//                        }
//                        fight_defend = defend;
//                        fight_strong = strong;
//
//                        system("cls");
//                        profile(level, nameUser, UserChoiceHERO, fight_HP, Mana_fight, strong, money);
//                        HeroUr(UserChoiceHERO);
//                        std::cout << "\n1) Атака \n"
//                            << "2) Использовать зелья\n"
//                            << "3) Стать в защиту\n"
//                            << "Ваш выбор: ";
//                        std::cin >> Choice_fight;
//
//                    } while (Choice_fight > 3 || Choice_fight < 1);
//                    if (Choice_fight == 1)
//                    {
//                        int hit_ur;
//                        int Choice_attack;
//                        system("cls");
//                        profile(level, nameUser, UserChoiceHERO, fight_HP, Mana_fight, strong, money);
//                        HeroUr(UserChoiceHERO);
//                        do
//                        {
//                            std::cout << "\n\n\tВаши умения: \n";
//                            std::cout << "1) " << hit_1 << "\n";
//                            std::cout << "2) " << hit_2 << "\n";
//                            std::cout << "3) " << hit_3 << "\n";
//                            std::cout << "4) " << hit_4 << "\n";
//                            std::cout << "Ваш выбор атаки: ";
//                            std::cin >> Choice_attack;
//                        } while (Choice_attack > 4 || Choice_attack < 1);
//
//                        switch (Choice_attack)
//                        {
//
//                        case 1:
//                            if (Mana_fight < 10)
//                            {
//                                std::cout << "Недостаточно маны\n\n";
//                            }
//                            else
//                            {
//                                LuckIntelect = rand() % 100 + 1;
//                                if (LuckIntelect < intelect)
//                                {
//                                    hit_ur = rand() % strong + 1 + (magical / 5);
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                }
//                                else
//                                {
//                                    hit_ur = (rand() % strong + 1 + (magical / 5)) * 2;
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                }
//                                break;
//                        case 2:
//                            if (Mana_fight < 20)
//                            {
//                                std::cout << "Недостаточно маны\n\n";
//                            }
//                            else
//                            {
//                                LuckIntelect = rand() % 100 + 1;
//                                if (LuckIntelect < intelect)
//                                {
//                                    hit_ur = (rand() % strong + 10 + (magical / 5)) * 2;
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                    Mana_fight -= 20;
//                                }
//                                else
//                                {
//                                    hit_ur = rand() % strong + 10 + (magical / 5);
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                    Mana_fight -= 20;
//                                }
//                                break;
//                            }
//
//                        case 3:
//                            if (Mana_fight < 30)
//                            {
//                                std::cout << "Недостаточно маны\n\n";
//                            }
//                            else
//                            {
//                                LuckIntelect = rand() % 100 + 1;
//                                if (LuckIntelect < intelect)
//                                {
//                                    hit_ur = (rand() % strong * 2 + 1 + (magical / 5)) * 2;
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                    Mana_fight -= 30;
//                                }
//                                else
//                                {
//                                    hit_ur = rand() % strong * 2 + 1 + (magical / 5);
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                    Mana_fight -= 30;
//                                }
//                                break;
//                            }
//                        case 4:
//                            if (Mana_fight < 40)
//                            {
//                                std::cout << "Недостаточно маны\n\n";
//                            }
//                            else
//                            {
//                                LuckIntelect = rand() % 100 + 1;
//                                if (LuckIntelect < intelect)
//                                {
//                                    hit_ur = (rand() % strong * 3 + 1 + (magical / 5)) * 2;
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                    Mana_fight -= 40;
//                                }
//                                else
//                                {
//                                    hit_ur = (rand() % strong) * 3 + 1 + (magical / 5);
//                                    std::cout << "\nВаш удар нанес урона: " << hit_ur << "\n\n";
//                                    system("pause");
//                                    health_enemy -= hit_ur;
//                                    Mana_fight -= 40;
//                                }
//                                break;
//                            }
//                            }
//                        }
//                    }
//                    if (Choice_fight == 2)
//                    {
//                        if (HealHero_potion != 0 || ManaHero_potion != 0 || AttackHero_potion != 0 || DefendHero_potion != 0)
//                        {
//                            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
//                            std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
//                            std::cout << "|kolvo: " << HealHero_potion << "|" << "    |kolvo: " << ManaHero_potion << "|" << "    |kolvo: " << AttackHero_potion << "|" << "    |kolvo: " << DefendHero_potion << "|" << "\n";
//                            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
//                            int Choice_Zealya;
//                            do
//                            {
//                                std::cout << "\n\tВыбери зелье: ";
//                                std::cin >> Choice_Zealya;
//                            } while (Choice_Zealya > 4 || Choice_Zealya < 1);
//                            switch (Choice_Zealya)
//                            {
//                            case 1:
//                                if (HealHero_potion == 0)
//                                {
//                                    std::cout << "\n\tУ вас нет зелья даного типа\n";
//                                }
//                                else
//                                {
//                                    if (kolvo_max_potion > 4)
//                                    {
//                                        std::cout << "Вы не можете выпить больше 4 зелей за один бой";
//                                    }
//                                    else
//                                    {
//                                        fight_HP += 50;
//                                        if (fight_HP > health)
//                                        {
//                                            fight_HP = health;
//                                            kolvo_max_potion++;
//                                            HealHero_potion--;
//                                        }
//                                        else
//                                        {
//                                            kolvo_max_potion++;
//                                            HealHero_potion--;
//                                        }
//                                    }
//                                }
//                                std::cout << "\n\n";
//                                system("pause");
//                                checker = 1;
//                                break;
//                            case 2:
//                                if (ManaHero_potion == 0)
//                                {
//                                    std::cout << "\n\tУ вас нет зелья даного типа\n";
//                                }
//                                else
//                                {
//                                    if (kolvo_max_potion > 4)
//                                    {
//                                        std::cout << "Вы не можете выпить больше 4 зелей за один бой";
//                                    }
//                                    else
//                                    {
//                                        Mana_fight += 20;
//                                        if (Mana_fight > mana)
//                                        {
//                                            Mana_fight = mana;
//                                            kolvo_max_potion++;
//                                            ManaHero_potion--;
//                                        }
//                                        else
//                                        {
//                                            kolvo_max_potion++;
//                                            ManaHero_potion--;
//                                        }
//                                    }
//                                }
//                                std::cout << "\n\n";
//                                system("pause");
//
//                                break;
//                            case 3:
//                                if (AttackHero_potion == 0)
//                                {
//                                    std::cout << "\n\tУ вас нет зелья даного типа\n";
//                                }
//                                else
//                                {
//                                    if (kolvo_max_potion > 4)
//                                    {
//                                        std::cout << "Вы не можете выпить больше 4 зелей за один бой";
//                                    }
//                                    else
//                                    {
//                                        fight_strong += 15;
//                                        kolvo_max_potion++;
//                                        AttackHero_potion--;
//                                    }
//                                }
//                                std::cout << "\n\n";
//                                system("pause");
//                                checker = 1;
//                                break;
//                            case 4:
//                                if (DefendHero_potion == 0)
//                                {
//                                    std::cout << "\n\tУ вас нет зелья даного типа\n";
//                                }
//                                else
//                                {
//                                    if (kolvo_max_potion > 4)
//                                    {
//                                        std::cout << "Вы не можете выпить больше 4 зелей за один бой";
//                                    }
//                                    else
//                                    {
//                                        fight_defend += 30;
//                                        kolvo_max_potion++;
//                                        DefendHero_potion--;
//                                    }
//                                }
//                                std::cout << "\n\n";
//                                system("pause");
//                                checker = 1;
//                                break;
//                            }
//                        }
//                        else
//                        {
//                            std::cout << "\n\nУ вас нет зелей\n\n";
//                            system("pause");
//                        }
//                    }
//                    if (Choice_fight == 3)
//                    {
//                        fight_defend += 20;
//                    }
//                    ///////////////////////////
//                    if (health_enemy <= 0)
//                    {
//                        xpnow += rand() % 50;
//                        if (xpnow >= 100)
//                        {
//                            xpnow -= 100;
//                            newLvlPLUS++;
//                            level++;
//                        }
//                        printWin(level, xpnow);
//                        levelArea++;
//                        money += rand() % 50;
//                        std::cout << "\n\n XP: " << xpnow << " | Money: " << money << " | New potion: ";
//                        Give_Potion = rand() % 4 + 1;
//                        switch (Give_Potion)
//                        {
//                        case 1:
//                            HealHero_potion++;
//                            std::cout << "Heal potion \n\n";
//                            break;
//                        case 2:
//                            ManaHero_potion++;
//                            std::cout << "Mana potion \n\n";
//                            break;
//                        case 3:
//                            AttackHero_potion++;
//                            std::cout << "Attack potion \n\n";
//                            break;
//                        case 4:
//                            DefendHero_potion++;
//                            std::cout << "Defend potion \n\n";
//                            break;
//                        }
//
//                        system("pause");
//                    }
//                    else
//                    {
//                        fight_HP -= CreateMonster(defend, fast, health_enemy, new_bot);
//                        system("pause");
//                    }
//                    if (fight_HP <= 0)
//                    {
//                        xpnow += (rand() % 20) / 2;
//                        if (xpnow >= 100)
//                        {
//                            xpnow -= 100;
//                            newLvlPLUS++;
//                            level++;
//                        }
//                        money += rand() % 20;
//                        printLose(level, xpnow);
//                        std::cout << "\n\n XP: " << xpnow << " | Money: " << money;
//                        system("pause");
//                    }
//                } while (health_enemy > 0 && fight_HP > 0);
//
//                break;
//                system("cls");
//            }
//            if (Choice_arena == 'N' || Choice_arena == 'n')
//            {
//                system("cls");
//            }
//            break;
//            //=================================================================================
//            //=================================================================================
//            //=================================================================================
//        case 3:
//            int Choise_shop;
//            system("cls");
//            std::cout << "\tКоличество ваших Золотых монет: " << money << "\n\n";
//            std::cout << "\tПредметы на продажу: \n";
//            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
//            std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
//            std::cout << "|50 - ЗМ |" << "    |50 - ЗМ |" << "    |50 - ЗМ |" << "    |50 - ЗМ |" << "\n";
//            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n\n";
//            do
//            {
//                std::cout << "Выберите предмет для покупки: ";
//                std::cin >> Choise_shop;
//            } while (Choise_shop < 1 || Choise_shop > 4);
//            switch (Choise_shop)
//            {
//            case 1:
//                if (money < 50)
//                {
//                    std::cout << "\n" << "Не достаточно золотых монет\n\n";
//                    system("pause");
//                }
//                else
//                {
//                    HealHero_potion++;
//                    money -= 50;
//                }
//                break;
//            case 2:
//                if (money < 50)
//                {
//                    std::cout << "\n" << "Не достаточно золотых монет\n\n";
//                    system("pause");
//                }
//                else
//                {
//                    ManaHero_potion++;
//                    money -= 50;
//                }
//                break;
//            case 3:
//                if (money < 50)
//                {
//                    std::cout << "\n" << "Не достаточно золотых монет\n\n";
//                    system("pause");
//                }
//                else
//                {
//                    AttackHero_potion++;
//                    money -= 50;
//                }
//                break;
//            case 4:
//                if (money < 50)
//                {
//                    std::cout << "\n" << "Не достаточно золотых монет\n\n";
//                    system("pause");
//                }
//                else
//                {
//                    DefendHero_potion++;
//                    money -= 50;
//                }
//                break;
//            }
//            std::cout << "Ваши зелья: \n\n";
//            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
//            std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
//            std::cout << "|kolvo: " << HealHero_potion << "|" << "    |kolvo: " << ManaHero_potion << "|" << "    |kolvo: " << AttackHero_potion << "|" << "    |kolvo: " << DefendHero_potion << "|" << "\n";
//            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
//            system("pause");
//            break;
//        case 4:
//            std::cout << "Ваши зелья: \n\n";
//            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n";
//            std::cout << "|  Heal  |" << "    |  Mana  |" << "    | strong |" << "    | defend |" << "\n";
//            std::cout << "|kolvo: " << HealHero_potion << "|" << "    |kolvo: " << ManaHero_potion << "|" << "    |kolvo: " << AttackHero_potion << "|" << "    |kolvo: " << DefendHero_potion << "|" << "\n";
//            std::cout << "----------" << "    ----------" << "    ----------" << "    ----------" << "\n\n";
//            system("pause");
//            std::cout << "\n\n У вас пока нет экипировки\n\n";
//            system("pause");
//            break;
//        case 5:
//            system("cls");
//
//            saveLvlarea(levelArea);
//
//            saveLvlHero(level);
//
//            saveMoneyHero(money);
//
//            saveNowxpHero(xpnow);
//
//            saveChoiceHero(UserChoiceHERO);
//
//            saveHealPotion(HealHero_potion);
//
//            saveManaPotion(ManaHero_potion);
//
//            saveAttackPotion(AttackHero_potion);
//
//            saveDefendPotion(DefendHero_potion);
//
//            saveNameHero(nameUser);
//
//            savestrongHero(strong);
//
//            savehealthHero(health);
//
//            saveintelectHero(intelect);
//
//            savefastHero(fast);
//
//            savedefendHero(defend);
//
//            savemagicalHero(magical);
//
//            savemanaHero(mana);
//
//            savenewLvlPLUS(newLvlPLUS);
//            break;
//        }
//    } while (Choice != 6);
}
