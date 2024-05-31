using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    abstract class Hero
    {
        public string hit_1{ get; set; }
        public string  hit_2 { get; set; }
        public string hit_3 { get; set; }
        public string hit_4 { get; set; }
        public int strong { get; set; }
        public int health { get; set; }
        public int intelect { get; set; }
        // 

        //
        public int mana { get; set; }
        //
        public string nameUser { get; set; }
        public string Class_Hero { get; set; }
        //
        public int level { get; set; }
        public int levelArea { get; set; }
        public int money { get; set; }
        public int xpnow { get; set; }
        public int newLvlPLUS { get; set; }
        //
        public int HealHero_potion { get; set; }
        public int ManaHero_potion { get; set; }
        public int AttackHero_potion { get; set; }
        public int DefendHero_potion { get; set; }
        //


        public abstract void Info();
    }


    class Warrior : Hero // Наследование ":"
    {
        public int defend { get; set; }

        public Warrior()
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

            strong = 0;
            health = 0;
            intelect = 0;

            defend = 0;

            mana = 0;
            nameUser = "";
            hit_1 = "";
            hit_2 = "";
            hit_3 = "";
            hit_4 = "";
            Class_Hero = "";
        }
        public Warrior(int _strong, int _health, int _intelect, int _defend, int _mana, string _nameUser, string s1, string s2, string s3, string s4, string CH)
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

            strong = _strong;
            health = _health;
            intelect = _intelect;

            defend = _defend;

            mana = _mana;
            nameUser = _nameUser;
            hit_1 = s1;
            hit_2 = s2;
            hit_3 = s3;
            hit_4 = s4;
            Class_Hero = CH;
        }
        public override void Info()
        {
            Console.WriteLine($"Name: {nameUser}");
            Console.WriteLine($"Class: {Class_Hero}");
            Console.WriteLine($"Level of Hero: {level}");
            Console.WriteLine($"Level of Area: {levelArea}");
            Console.WriteLine($"Money: {money}");
            Console.WriteLine($"XP: {xpnow}");
            Console.WriteLine($"LVLS to up: {newLvlPLUS}");
            Console.WriteLine($"Defend: {defend}");
            Console.WriteLine($"Strong: {strong}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Intelect: {intelect}");
            Console.WriteLine($"Mana: {mana}");
            Console.WriteLine($"Hit 1: {hit_1}");
            Console.WriteLine($"Hit 2: {hit_2}");
            Console.WriteLine($"Hit 3: {hit_3}");
            Console.WriteLine($"Hit 4: {hit_4}");
        }
    }



    class Archer : Hero
    {
        public int fast { get; set; }
        public Archer()
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

            strong = 0;
            health = 0;
            intelect = 0;

            fast = 0;

            mana = 0;
            nameUser = "";
            hit_1 = "";
            hit_2 = "";
            hit_3 = "";
            hit_4 = "";
            Class_Hero = "";
        }
        public Archer(int _strong, int _health, int _intelect, int _fast, int _mana, string _nameUser, string s1, string s2, string s3, string s4, string CH)
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

            strong = _strong;
            health = _health;
            intelect = _intelect;

            fast = _fast;

            mana = _mana;
            nameUser = _nameUser;
            hit_1 = s1;
            hit_2 = s2;
            hit_3 = s3;
            hit_4 = s4;
            Class_Hero = CH;
        }
        public override void Info()
        {
            Console.WriteLine($"Name: {nameUser}");
            Console.WriteLine($"Class: {Class_Hero}");
            Console.WriteLine($"Level of Hero: {level}");
            Console.WriteLine($"Level of Area: {levelArea}");
            Console.WriteLine($"Money: {money}");
            Console.WriteLine($"XP: {xpnow}");
            Console.WriteLine($"LVLS to up: {newLvlPLUS}");
            Console.WriteLine($"Fast: {fast}");
            Console.WriteLine($"Strong: {strong}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Intelect: {intelect}");
            Console.WriteLine($"Mana: {mana}");
            Console.WriteLine($"Hit 1: {hit_1}");
            Console.WriteLine($"Hit 2: {hit_2}");
            Console.WriteLine($"Hit 3: {hit_3}");
            Console.WriteLine($"Hit 4: {hit_4}");
        }
    }



    class Wizzard : Hero
    {
        public int magical { get; set; }
        public Wizzard()
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

            strong = 0;
            health = 0;
            intelect = 0;

            magical = 0;

            mana = 0;
            nameUser = "";
            hit_1 = "";
            hit_2 = "";
            hit_3 = "";
            hit_4 = "";
            Class_Hero = "";
        }
        public Wizzard(int _strong, int _health, int _intelect, int _magical, int _mana, string _nameUser, string s1, string s2, string s3, string s4, string CH)
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

            strong = _strong;
            health = _health;
            intelect = _intelect;

            magical = _magical;

            mana = _mana;
            nameUser = _nameUser;
            hit_1 = s1;
            hit_2 = s2;
            hit_3 = s3;
            hit_4 = s4;
            Class_Hero = CH;
        }
        public override void Info()
        {
            Console.WriteLine($"Name: {nameUser}");
            Console.WriteLine($"Class: {Class_Hero}");
            Console.WriteLine($"Level of Hero: {level}");
            Console.WriteLine($"Level of Area: {levelArea}");
            Console.WriteLine($"Money: {money}");
            Console.WriteLine($"XP: {xpnow}");
            Console.WriteLine($"LVLS to up: {newLvlPLUS}");
            Console.WriteLine($"Magical: {magical}");
            Console.WriteLine($"Strong: {strong}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Intelect: {intelect}");
            Console.WriteLine($"Mana: {mana}");
            Console.WriteLine($"Hit 1: {hit_1}");
            Console.WriteLine($"Hit 2: {hit_2}");
            Console.WriteLine($"Hit 3: {hit_3}");
            Console.WriteLine($"Hit 4: {hit_4}");
        }
    
            
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> Funds = new List<Hero>();
            Funds.Add(new Wizzard() { strong = 100,  health = 200,  intelect = 40,  magical = 40,  mana = 500,  nameUser = "Hero 1",  hit_1 = "Удар палкой по голове",  hit_2 = "Удар молнией",  hit_3 = "Фаер-бол",  hit_4 = "Метеоритный дождь", Class_Hero = "Wizzard" });
            Funds.Add(new Archer() { strong = 200, health = 300, intelect = 20, fast = 40, mana = 300, nameUser = "Hero 2", hit_1 = "Выстрел", hit_2 = "Выстрел ядовитой стрелой", hit_3 = "Точный Выстрел", hit_4 = "Очередь выстрелов", Class_Hero = "Archer" });
            Funds.Add(new Warrior() { strong = 300, health = 500, intelect = 10, defend = 40, mana = 100, nameUser = "Hero 3", hit_1 = "Удар мечом", hit_2 = "Точный удар", hit_3 = "Вылетающий клинок", hit_4 = "1000 ударов", Class_Hero = "Warrior" });


            foreach (Hero hero in Funds)
            {
                hero.Info();
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
