using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Assignment___Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum  = generator.Next(1, 4);

            if (randNum == 1)
            {
                drawDog();
            }
            else if (randNum == 2) 
            {
                drawCat();
            }
            else if (randNum == 3)
            {
                drawBunny();
            }

            Console.WriteLine("Press ENTER for a joke");
            Console.ReadLine();
            tellJoke();
        }

        public static void drawDog()
        {
            Console.WriteLine();
            Console.WriteLine("        |`-.__  ");
            Console.WriteLine(@"        / ' _/ ");
            Console.WriteLine("        ****`   ");
            Console.WriteLine(@"      /   \    ");
            Console.WriteLine(@"     /     }   ");
            Console.WriteLine(@"    /   \ /    ");
            Console.WriteLine(@"\ /`   \\\     ");
            Console.WriteLine(@" `\    /_\\    ");
            Console.WriteLine("   `~~~~~``~`   ");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void drawCat()
        {
            Console.WriteLine();
            Console.WriteLine("  _                     ");
            Console.WriteLine(@"( \                    ");
            Console.WriteLine(" ) )                    ");
            Console.WriteLine(@"( (  .-''''-.  A.-.A   ");
            Console.WriteLine(@" \ \/        \/ , , \  ");
            Console.WriteLine(@"  \   \      =;  t  /= ");
            Console.WriteLine(@"   \   |''''_  ',--'   ");
            Console.WriteLine(@"   /  //    | ||       ");
            Console.WriteLine("   /_,))     |_,))      ");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void drawBunny()
        {
            Console.WriteLine(@"     / \             ");
            Console.WriteLine(@"    / _ \            ");
            Console.WriteLine(@"   | / \ |           ");
            Console.WriteLine(@"   ||   || _______   ");
            Console.WriteLine(@"   ||   || |\     \  ");
            Console.WriteLine(@"   ||   || ||\     \ ");
            Console.WriteLine(@"   ||   || || \    | ");
            Console.WriteLine(@"   ||   || ||  \__/  ");
            Console.WriteLine(@"   ||   || ||   ||   ");
            Console.WriteLine(@"    \\_/ \_/ \_//    ");
            Console.WriteLine(@"   /   _     _   \   ");
            Console.WriteLine(@"  /               \  ");
            Console.WriteLine(@"  |    O     O    |  ");
            Console.WriteLine(@"  |   \  ___  /   |  ");
            Console.WriteLine(@" /     \ \_/ /     \ ");
            Console.WriteLine(@"/  -----  |  -----  \");
            Console.WriteLine(@"|     \__/|\__/     |");
            Console.WriteLine(@"\       |_|_|       /");
            Console.WriteLine(@"\_____       _____/  ");
            Console.WriteLine(@"       \     /       ");
            Console.WriteLine(@"       |     |       ");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void tellJoke()
        {
            Console.WriteLine("Knock knock");
            Thread.Sleep(750);
            Console.WriteLine("Who's there?");
            Thread.Sleep(750);
            Console.WriteLine("Nobel");
            Thread.Sleep(750);
            Console.WriteLine("Nobel who?");
            Thread.Sleep(1200);
            Console.WriteLine("No bell, that's why I knocked.");
        }
       
    }
}