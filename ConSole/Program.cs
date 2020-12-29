using System;
using MyLib;

namespace ConSole
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine e = new Engine("Belarus", "AKAB228", EngineType.Diesel);
            Cabin c = new Cabin("Cyberpunk", "A1077", CabinType.Tropic);
            Tractor t = new Tractor("Naruto", "Saske", e, c);
            Console.WriteLine(t.Serialize());
        }
    }
}
