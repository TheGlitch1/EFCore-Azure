using System;

namespace EFCoreTuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(EFCoreContext context = new EFCoreContext())
            {
                Console.WriteLine(context.Database.CanConnect());
            }

            Console.ReadLine();
        }
    }
}
