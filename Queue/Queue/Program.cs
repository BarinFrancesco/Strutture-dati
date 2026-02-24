using Lista;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> Coda = new MyQueue<int>();
            MyStak<int> stack = new MyStak<int>();


            string operation;

            Console.WriteLine("Inserire la propria espressie qui sotto");
            Console.Write(">");

            operation = Console.ReadLine();
        }

        static bool isValid(string operation)
        {
            foreach (char carattere in operation)
            {
                if (char.IsLetter(carattere) &&
                    carattere != '+' &&
                    carattere != '-' &&
                    carattere != '*' &&
                    carattere != '/' &&
                    carattere != '(' &&
                    carattere != ')'
                    )
                {
                    return false;
                }
            }

            return true;

        }
    }
}