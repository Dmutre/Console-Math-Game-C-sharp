using System;



namespace Console_game
{
    public class Program
    {

        static player player = new();
        
        public static void Text_Output(string a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char c in a)
            {
                Console.Beep(459, 100);
                Console.Write(c);
                Thread.Sleep(0);
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
            
        }


        public static string Name_Input(string a)
        { 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (char c in a)
            {
                Console.Beep(459, 100);
                Console.Write(c);
                Thread.Sleep(0);
            }
            string? name = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            return name;
        }
  

        public static int Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string Intrudaction = "It is been while when this dried area was the one of the centre of human civilizacion. Now, it is place where the lost like you is searching " +
            "for leftovers of that civilization for rising bounty.Your goal- to capture this area with your friend and defend the bosses, that are controlling and destroying " +
            "your teritory, LETS GO!!!";
            //Text_Output(Intrudaction);


            string inp_name = "Input your name: ";
            string? name;
            name = Name_Input(inp_name);
            player.Constructor(100, name, 15);
            Console.Clear();

            string Greeting = $"Ok, {name}, it is start of your journey)";
            Text_Output(Greeting);


            string f_b = "Now, you will fight with your first boss";
            Text_Output(f_b);            


            string words = "To fight your first enemy you have to figure out the quetion";
            Text_Output(words);


            Random rnd = new();
            int a, b, cr, r;


            Bosses Athul = new();
            Athul.Constructor(40, 10, "Athul");
            while (Athul.health > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Boss health: " + Athul.health);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your health: " + player.health);
                Console.WriteLine("\n\n\n");
                int b1_damage = rnd.Next(2, 15);
                a = rnd.Next(-10, 10);
                b = rnd.Next(-10, 10);
                cr = a * b;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"How many is {a} * {b}");
                r = Convert.ToInt32(Console.ReadLine());
                if(r == cr)
                {
                    Athul.Take_damage(player.Give_damage());
                }
                else
                {
                    player.Take_damage(Athul.Give_damage());
                }
                Console.ReadKey();
                Console.Clear();
                if(player.health < 0)
                {
                    Console.WriteLine("GG");
                    break;
                    return 0;
                } 
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Boss is defended");
            string win = "Wow, you are good at it, let`s continue in that way)";
            Text_Output(win);



            string words1 = "After the fight you became a little bit stronger, so you will give more damage to enemy, but you will also take more, so lets move on...";
            Text_Output(words1);


            Console.Write("Two mounths left");
            string words12 = ".......";
            Text_Output(words12);


            string words122 = "After that time you became much stronger, so you are ready to fight with last two bosses \nAnd" +
                " for that you came to the dungeon, where placed your goal- two bosses of this area......loading" +
                ".....\nYou walkes in............searching...............OH!!!! HERE IS SECOND!!";
            Text_Output(words122);



            player.Increas_damage(80);
            player.Heal(200);


            Bosses Vova = new();
            Vova.Constructor(400, 70, "Vova");
            while (Vova.health > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Boss health: " + Vova.health);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your health: " + player.health);
                Console.WriteLine("\n\n\n");
                a = rnd.Next(-20, 20);
                b = rnd.Next(-20, 20);
                cr = a * b;
                Console.WriteLine($"How many is {a} * {b}");
                r = Convert.ToInt32(Console.ReadLine());
                if (r == cr)
                {
                    Vova.Take_damage(player.Give_damage());
                }
                else
                {
                    player.Take_damage(Vova.Give_damage());
                }
                Console.ReadKey();
                Console.Clear();
                if (player.health < 0)
                {
                    Console.WriteLine("GG");
                    break;
                    return 0;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("BOSS is defended");

            words = "Great, it was unexpected, but we did it well. Behind beaten creatur was placcing the gate, i think, you are ready to open it\n\n" +
                        "Take it potion, it make you stronger and heal you\n" +
                        "............+200HP.......+20damage.......\n" +
                        "Ok, we are ready, OPEN THE GATE!!!!";
            Text_Output(words);

            player.Increas_damage(20);
            player.Heal(100);



            Bosses Last = new();
            Last.Constructor(1000, 100, "Last");
            while (Last.health > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Boss health: " + Last.health);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your health: " + player.health);
                Console.WriteLine("\n\n\n");
                int b1_damage = rnd.Next(70, 90);
                a = rnd.Next(-30, 20);
                b = rnd.Next(-20, 25);
                cr = a * b;
                Console.WriteLine($"How many is {a} * {b}");
                r = Convert.ToInt32(Console.ReadLine());
                if (r == cr)
                {
                    Last.Take_damage(player.Give_damage());
                }
                else
                {
                    player.Take_damage(Last.Give_damage());
                }
                Console.ReadKey();
                Console.Clear();
                if (player.health < 0)
                {
                    Console.WriteLine("GG");
                    break;
                    return 0;
                }
                
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("BOSS IS DEFENDED");
            words = "Wow, we did it, that was hard, but wonderful, this area is ours, maybe, we will continue uor journey in next episods, bye))";
            Text_Output(words);

            return 0;
        }
    }
}