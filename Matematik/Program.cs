using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 9);
            dortIslem.Topla(21, 9);
            Console.Read();
        }
    }
}
