namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree<int> tree = new MyBinaryTree<int>();
            string input;

            while (true)
            {
                Console.Write("Inserisci un numero (q per uscire): ");
                input = Console.ReadLine();

                if (input == "q")
                    break;

                int value = int.Parse(input);

                tree.Insert(value);

                Console.WriteLine("Elementi nell'albero:");
                tree.PrintDebug();
                Console.WriteLine("------------------");
            }
        }
    }
    
}