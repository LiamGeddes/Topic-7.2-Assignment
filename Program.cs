namespace Topic_7._2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT 1 - COUNTING DOWN");

            for (int i = 10; i >= 0; i = i - 1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Blast Off!");

            Console.WriteLine();


            //Assignment 2 

            Console.WriteLine("ASSIGNMENT 2 - X AND Y");
            Console.WriteLine("X\tY");
            Console.WriteLine("-----------");

            for (int i = -10; i <= 10; i = i + 2)
            {
                int y = i * i;
                Console.WriteLine(i + "\t" + y);
            }

            Console.WriteLine();



            //Assignment 3

            Console.WriteLine("ASSIGNMENT 3 - FOR LOOPS FUN");
            int times = 10;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (name == "Aldworth")
            {
                times = 5;
            }

            for (int i = 1; i <= times; i = i + 1)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
