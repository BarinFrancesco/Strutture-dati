using LMyDataStructures;
namespace Robot_e_dinosauri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyQueue<string> CodaComponenti = new MyQueue<string>() ;
            List<Task> taskRobot = new List<Task>() ;

            for (int i = 0; i < 11; i++)
            {
                Robot Newrobot = new Robot(CodaComponenti, i) ;
                taskRobot.Add(Newrobot.AggiungiCompionente());
            }

            Console.WriteLine("Hello, World!");
        }
    }
}