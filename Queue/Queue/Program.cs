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
            MyStak<int> stack = new MyStak<int>();
            int num = 0;
            foreach (char carattere in operation)
            {
                if (int.TryParse(""+carattere, out int x))
                {
                    num = (num * 10) + x;
                }
            }



            return true;
        }
    }
}