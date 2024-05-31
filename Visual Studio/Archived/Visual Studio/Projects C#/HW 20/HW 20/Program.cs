using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(3);
            while (game.Player_Move())
            {

            }
            Console.ReadKey(true);
        }

        #region Player
        public class Player
        {
            public List<Card> cards = new List<Card>();
        }

        #endregion

        #region Cards
        public class Card
        {

            public readonly CardValue crdValue;
            public readonly CardSuit crdSuit;

            public Card(CardValue value, CardSuit suit)
            {
                this.crdValue = value;
                this.crdSuit = suit;
            }

            public override string ToString()
            {
                return $"{crdValue} {crdSuit}";
            }
        }

        #endregion

        #region Game
        public class Game
        {
            public List<Card> Coloda;
            public List<Player> Players;

            private Random rand;
            private int Count_Cards = 36;
            public Game(int playersCount = 2)
            {
                rand = new Random();

                Players = new List<Player>();
                for (int i = 0; i < playersCount; i++)
                {
                    Players.Add(new Player());
                }

                Coloda = CreateColodaCart();
                ShuffleCards(Coloda);

                GivingCrads(Players, Coloda);
            }
            #endregion

            #region Coloda Cart i Robota s nimi
            public List<Card> CreateColodaCart()
            {
                Coloda = new List<Card>();
                int Count_Suit = Count_Cards / 4;

                for (int i = 0; i < Count_Suit; i++)
                {
                    Coloda.Add(new Card((CardValue)i, (CardSuit)0));
                    Coloda.Add(new Card((CardValue)i, (CardSuit)1));
                    Coloda.Add(new Card((CardValue)i, (CardSuit)2));
                    Coloda.Add(new Card((CardValue)i, (CardSuit)3));
                }

                return Coloda;
            }


            public static void ShuffleCards<T>(List<T> list)
            {
                Random rand = new Random();

                for (int i = list.Count - 1; i >= 1; i--)
                {
                    int j = rand.Next(i + 1);

                    T tmp = list[j];
                    list[j] = list[i];
                    list[i] = tmp;
                }
            }


            public void GivingCrads(List<Player> players, List<Card> cards)
            {
                int Player_Now = 0;

                for (int i = 0; i < cards.Count; i++)
                {
                    players[Player_Now].cards.Add(cards[i]);

                    Player_Now++;
                    Player_Now %= players.Count;
                }
            }
            #endregion


            public bool Player_Move()
            {
                Console.WriteLine("Player\t\tColvo\t\tMove");

                int Value_Max = -1;
                Player PlayerMaxVal = null;
                Stack<Card> Crd_Stack = new Stack<Card>();

                for (int i = 0; i < Players.Count; i++)
                {
                    Player player = Players[i];

                    if (player.cards.Count > 0)
                    {
                        Card card = player.cards[rand.Next(player.cards.Count)];

                        Console.WriteLine($"{i}" +
                            $"\t\t{player.cards.Count}" +
                            $"\t\t{card}");

                        player.cards.Remove(card);

                        if ((int)card.crdValue > Value_Max)
                        {
                            Value_Max = (int)card.crdValue;
                            PlayerMaxVal = player;
                        }

                        Crd_Stack.Push(card);

                    }
                }

                PlayerMaxVal.cards.AddRange(Crd_Stack);
                Console.WriteLine($"Took Player -> {Players.IndexOf(PlayerMaxVal)}.");
                Console.WriteLine("=================================================");

                if (PlayerMaxVal.cards.Count == Count_Cards)
                {
                    Console.WriteLine($"Won player -> {Players.IndexOf(PlayerMaxVal)}");
                    return false;
                }

                return true;
            }
        }

       

        public enum CardValue
        {
            Six = 0, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        public enum CardSuit
        {
            Hearts = 0, Diamonds, Clubs, Spades
        }
     






    }
}
