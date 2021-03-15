using System;

namespace Morra_Cinese_AI
{
    class Program
    {
        public static string mossa_giocatore1 = "";
        public static string mossa_AI = "";
        public static string nome_giocatore_1 = "";
        public static string Scelta_Giocatore_1;
        public static int Scelta_AI;
        public static int Vittorie_giocatore1 = 0;
        public static int Vittorie_giocatore2 = 0;
        public static string Sasso = "Sasso";
        public static string Carta = "Carta";
        public static string Forbice = "Forbice";

        static void Nomi_Giocatore() //Vengono richiesti i nomi di entrambi i giocatori
        {
            Console.WriteLine("Benvenuto nel gioco della morra cinese.");

            Console.Write("\nInserisci il nome del ");
            Console.ForegroundColor = ConsoleColor.Blue; //cambio colore delle parole a schermo
            Console.Write("giocatore 1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");

            nome_giocatore_1 = Console.ReadLine();
        }

        static void Giocatore_1() //Viene richiesta la mossa del giocatore 1
        {
            Console.Clear(); //pulisce la console

            Console.Write("Ora e' il turno del giocatore ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{nome_giocatore_1}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");


            Console.Write("Scegli che se vuoi buttare sasso ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(digita S), ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("forbice ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(digita D) ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("o carta ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(digita A)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");

            Scelta_Giocatore_1 = Convert.ToString(Console.ReadKey(true).KeyChar); //assegnazione valore di Scelta_Giocatore_1 e do valore letto da schermo (il valore è solo un carattere)

            while (Scelta_Giocatore_1 != "S" && Scelta_Giocatore_1 != "D" && Scelta_Giocatore_1 != "A") //ciclo che controlla che l'utente abbia messo una riposta accettabile
            {
                Console.Clear();
                Console.WriteLine("La risposta inserita non e' corretta...");

                Console.Write("Scegli che se vuoi buttare sasso ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita S), ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("forbice ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita D) ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("o carta ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita A)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Scelta_Giocatore_1 = Convert.ToString(Console.ReadKey(true).KeyChar); //assegnazione valore di Scelta_Giocatore_1 e do valore letto da schermo (il valore è solo un carattere)
            }
        }

        static void Convertitore_Giocatore_1() //Converte la scelta del giocatore 1 da i caratteri inseriti a Sasso, Carta o Forbice
        {
            if (Scelta_Giocatore_1 == "S") //converte la scelta del giocatore Sasso
            {
                mossa_giocatore1 = Sasso;
            }
            else if (Scelta_Giocatore_1 == "D") //converte la scelta del giocatore Forbice
            {
                mossa_giocatore1 = Forbice;
            }
            else if (Scelta_Giocatore_1 == "A") //converte la scelta del giocatore Carta
            {
                mossa_giocatore1 = Carta;
            }
        }

        static void Giocatore_AI() //Viene richiesta la mossa del giocatore 2
        {
            Random random = new Random(); //Inizializza la classe random 

            Console.Write("\nOra e' il turno del giocatore ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("della AI");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");

            Scelta_AI = random.Next(0, 2); //generatore random
        }

        static void Convertitore_Giocatore_AI() //Converte la scelta del giocatore 2 da i caratteri inseriti a Sasso, Carta o Forbice
        {
            if (Scelta_AI == 0) //converte la scelta del giocatore Sasso
            {
                mossa_AI = Sasso;
            }
            else if (Scelta_AI == 1) //converte la scelta del giocatore Forbice
            {
                mossa_AI = Forbice;
            }
            else if (Scelta_AI == 2) //converte la scelta del giocatore Carta
            {
                mossa_AI = Carta;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nLa AI ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ha tirato ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{mossa_AI}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");
        }       

        static void Vittorie_Parziali() //Restituisce chi ha vinto fra la scelta del giocatore 1 e il giocatore 2
        {
            if (mossa_giocatore1 == mossa_AI)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPAREGGIO");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (mossa_giocatore1 == Sasso && mossa_AI == Forbice)
            {
                Console.Write("\nHA VINTO IL GIOCATORE ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Vittorie_giocatore1++;
            }
            else if (mossa_giocatore1 == Sasso && mossa_AI == Carta)
            {
                Console.Write("\nHA VINTO IL GIOCATORE ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"LA AI");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Vittorie_giocatore2++;
            }
            else if (mossa_giocatore1 == Forbice && mossa_AI == Sasso)
            {
                Console.Write("\nHA VINTO IL GIOCATORE ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"LA AI");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Vittorie_giocatore2++;
            }
            else if (mossa_giocatore1 == Forbice && mossa_AI == Carta)
            {
                Console.Write("\nHA VINTO IL GIOCATORE ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Vittorie_giocatore1++;
            }
            else if (mossa_giocatore1 == Carta && mossa_AI == Sasso)
            {
                Console.Write("\nHA VINTO IL GIOCATORE ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Vittorie_giocatore1++;
            }
            else if (mossa_giocatore1 == Carta && mossa_AI == Forbice)
            {
                Console.Write("\nHA VINTO IL GIOCATORE ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"LA AI");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Vittorie_giocatore2++;
            }
        }

        static void Digita_X() //digitata la frase "Per continuare premere qualsiasi tasto, però se vuoi terminare il gioco, premi X"
        {
            Console.Write("\nPer continuare premere qualsiasi tasto, però se vuoi terminare il gioco, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("premi X");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");
        }

        static void Vittorie_finali() //Restituisce chi ha vinto in conclusione fra il giocatore 1 e il giocatore 2
        {
            if (Vittorie_giocatore1 == Vittorie_giocatore2) //pareggio
            {
                Console.Write("Il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("e il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"la AI ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("hanno pareggiato");
                Console.WriteLine(".");
            }
            else if (Vittorie_giocatore1 > Vittorie_giocatore2) //vince giocatore 1
            {
                Console.Write("Il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ha vinto contro ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"la AI");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");
            }
            else if (Vittorie_giocatore2 > Vittorie_giocatore1) //vince giocatore 2
            {
                Console.Write("Il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"la AI ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ha vinto contro il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");
            }
        }

        static void Numero_Vittorie() //Restitusce il numero di vittorie finali di entrabi i giocatori
        {
            Console.Write("\nIl Giocatore ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{nome_giocatore_1} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ha vinto n°: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Vittorie_giocatore1}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", mentre ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"la AI ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ha vinto n°: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Vittorie_giocatore2}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");
        }

        static void Main(string[] args)
        {
            Nomi_Giocatore(); //Vengono richiesti i nomi di entrambi i giocatori

            do
            {
                Giocatore_1(); //Viene richiesta la mossa del giocatore 1
                Convertitore_Giocatore_1(); //Converte la scelta del giocatore 1 da i caratteri inseriti a Sasso, Carta o Forbice

                Giocatore_AI(); //Viene richiesta la mossa del giocatore 2
                Convertitore_Giocatore_AI(); //Converte la scelta del giocatore 2 da i caratteri inseriti a Sasso, Carta o Forbice

                Vittorie_Parziali(); //Restituisce chi ha vinto fra la scelta del giocatore 1 e il giocatore 2

                Digita_X(); //digitata la frase "Per continuare premere qualsiasi tasto, però se vuoi terminare il gioco, premi X"

            } while (Console.ReadKey().Key != ConsoleKey.X); //do while che continua fino a quando digiti X

            Console.Clear();

            Vittorie_finali(); //Restituisce chi ha vinto in conclusione fra il giocatore 1 e il giocatore 2

            Numero_Vittorie(); //Restitusce il numero di vittorie finali di entrabi i giocatori

            Console.ReadKey();
        }        
    }
}
