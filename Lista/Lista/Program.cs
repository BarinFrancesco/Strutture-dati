namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStak<char> Pila = new MyStak<char>();

            Print("Benvenuto nel nostro programma, qua puù inserire delle operazioni matematiche, noi le diremo se le parentesi sono state messe enll'ordine corretto", 0);
            string continua = "Y";
            while (continua == "Y" || continua == "y")
            {

                string Operazione;

                Print("Per favore inserire la vostra espressione", 0);
                Console.Write(">");

                Operazione = Console.ReadLine();
                bool isCorrect = true;

                foreach (char carattere in Operazione)
                {
                    if(carattere == '{' || carattere == '[' || carattere == '(')
                    {
                        Pila.push(carattere);
                    }


                    if( carattere == '}' || carattere == ']' || carattere == ')')
                    {
                        try
                        {
                            char temp = Pila.pop();

                            if (!(temp == '{' && carattere == '}' ||
                                 temp == '[' && carattere == ']' ||
                                 temp == '(' && carattere == ')'))
                            {
                                isCorrect = false;
                                break;
                            }
                        } catch (Exception ex) //se ci sono eccezioi tipo 
                        {
                            isCorrect = false;
                            break;
                        }
                            
                        
                    }

                }


                if (isCorrect && Pila.isEmpty())
                {
                    Print("Le parentesi sono state messe nell'ordine corretto", 1);
                } else
                {
                    Print("Le parentesi sono state messe nell'ordine SBAGLIATO", 2);
                }

                Pila.clear();

                Print("Ha altre operazioni da inserire? [Y/N]", 4);
                Console.Write(">");
                continua = Console.ReadLine();

                while (continua != "Y" && continua != "y" && continua != "N" && continua != "n") 
                {
                    Print("per favore inserire una della opzioni sopra elencate [Y/N]", 2);
                    Console.Write(">");
                    continua = Console.ReadLine();
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