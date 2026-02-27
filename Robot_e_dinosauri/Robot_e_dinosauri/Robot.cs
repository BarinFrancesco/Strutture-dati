using LMyDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_e_dinosauri
{
    public class Robot
    {
        static string[] Nomi = 
        {
        "Cemento",
        "Calcestruzzo",
        "Mattoni",
        "Blocchi in laterizio",
        };
        static int seq = 0;

        public MyQueue<string> Coda;
        public int ID;

        public Robot(MyQueue<string> coda, int id) 
        {
            Coda = coda;
            ID = id;
        }

        public async Task AggiungiCompionente()
        {
            while (true)
            {
                Task.Delay(500);

                string Componente = Nomi[Random.Shared.Next(3)] + $"{seq}";
                seq++;

                Coda.Enqueue(Componente);

                Console.WriteLine($"Robot:{ID}  Ha aggiunto {Componente}");
            }
            
        } 
    }
}
