namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStak<Char> Pila = new MyStak<Char>();

            Print("Benvenuto nel nostro programma, qua puù inserire delle operazioni matematiche, noi le diremo se le parentesi sono state messe enll'ordine corretto", 0);
            string continua = "Y";
            while (continua == "Y" || continua == "y")
            {


                string Operazione;

                Print("Per favore inserire la vostra espressione", 0);
                Console.Write(">");

                Operazione = Console.ReadLine();


                foreach (char carattere in Operazione)
                {
                    if(carattere == '{' || carattere == '[' || carattere == '(')
                    {

                    }
                }








                Print("Ha altre operazioni da inserire? [Y/N]", 4);
                while (continua != "Y" && continua != "y" && continua != "N" && continua != "n") 
                {
                    Print("per favore inserire una della opzioni sopra elencate [Y/N]", 2);
                }
            }
        }

        private static void Print(string s, int col) 
        {
            switch(col) 
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine(s);   

            Console.ResetColor();
        }
    }
}