using System;



namespace Console_game
{
    public class Program
    {

        static player player = new player();
        
        
        public static int Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            /*string Intrudaction = "It is been while when this dried area was the one of the centre of human civilizacion. Now, it is place where the lost like you is searching " +
            "for leftovers of that civilization for rising bounty.Your goal- to capture this area with your friend and defend the bosses, that are controlling and destroying " +
            "your teritory, LETS GO!!!";
            foreach (char c in Intrudaction)
            {
                Console.Beep(459, 100);
                Console.Write(c);
                Thread.Sleep(1);
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();*/

            
            string inp_name = "Input your name: ";
            string? name;
            foreach (char c1 in inp_name)
            {
                Console.Beep(459, 100);
                Console.Write(c1);
                Thread.Sleep(1);
            }
            name = Console.ReadLine();
            Console.WriteLine();
            player.Constructor(100, name);
            Console.Clear();


            string inp_name1 = $"Ok, {name}, it is start of your journey)";
            foreach (char c12 in inp_name1)
            {
                Console.Beep(459, 100);
                Console.Write(c12);
                Thread.Sleep(1);
            }
            name = Console.ReadLine();
            Console.WriteLine();
            player.Constructor(100, name);
            Console.Clear();





            string f_b = "Now, you will fight with your first boss";
            foreach (char c2 in f_b)
            {
                Console.Beep(459, 100);
                Console.Write(c2);
                Thread.Sleep(1);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

            


            string words = "To fight your first enemy you have to figure out the quetion";
            foreach (char c3 in words)
            {
                Console.Beep(459, 100);
                Console.Write(c3);
                Thread.Sleep(1);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();




            Random rnd = new Random();
            int a, b, cr, r;


            bool first_boss = true;
            int b1_health = 40;
            while (first_boss)
            {
                Console.WriteLine("Boss health: " + b1_health);
                Console.WriteLine("Your health: " + player.health);
                Console.WriteLine("\n\n\n");
                int b1_damage = rnd.Next(2, 15);
                a = rnd.Next(-10, 10);
                b = rnd.Next(-10, 10);
                cr = a * b;
                Console.WriteLine($"How many is {a} * {b}");
                r = Convert.ToInt32(Console.ReadLine());
                if(r == cr)
                {
                    int dp = rnd.Next(10, 15);
                    Console.WriteLine("Boss took damage: "+ dp);
                    b1_health -= dp;
                }
                else
                {
                    player.Take_damage(b1_damage);
                }
                Console.ReadKey();
                Console.Clear();
                if(player.health < 0)
                {
                    Console.WriteLine("GG");
                    break;
                    return 0;
                } else if(b1_health < 0)
                {
                    Console.WriteLine("Boss is defended");
                    string win = "Wow, you are good at it, let`s continue in that way)";
                    foreach (char c33 in win)
                    {
                        Console.Beep(459, 100);
                        Console.Write(c33);
                        Thread.Sleep(1);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine();
                    break;
                }
            }



            string words1 = "After the fight you became a little bit stronger, so you will give more damage to enemy, but you will also take more, so lets move on...";
            foreach (char c34 in words1)
            {
                Console.Beep(459, 100);
                Console.Write(c34);
                Thread.Sleep(1);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();


            Console.Write("Two mounths left");
            string words12 = ".......";
            foreach (char c344 in words12)
            {
                Console.Beep(459, 100);
                Console.Write(c344);
                Thread.Sleep(1);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();


            string words122 = "After that time you became much stronger, so you are ready to fight with last two bosses \nAnd" +
                " for that you came to the dungeon, where placed your goal- two bosses of this area......loading" +
                ".....\nYou walkes in............searching...............OH!!!! HERE IS FIRST!!";
            foreach (char c344 in words122)
            {
                Console.Beep(459, 100);
                Console.Write(c344);
                Thread.Sleep(1);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();




            player.Heal(200);

            bool second_boss = true;
            int b2_health = 400;
            while (second_boss)
            {
                Console.WriteLine("Boss health: " + b2_health);
                Console.WriteLine("Your health: " + player.health);
                Console.WriteLine("\n\n\n");
                int b1_damage = rnd.Next(50, 100);
                a = rnd.Next(-20, 20);
                b = rnd.Next(-20, 20);
                cr = a * b;
                Console.WriteLine($"How many is {a} * {b}");
                r = Convert.ToInt32(Console.ReadLine());
                if (r == cr)
                {
                    int dp = rnd.Next(30, 95);
                    Console.WriteLine("Boss took damage: " + dp);
                    b2_health -= dp;
                }
                else
                {
                    player.Take_damage(b1_damage);
                }
                Console.ReadKey();
                Console.Clear();
                if (player.health < 0)
                {
                    Console.WriteLine("GG");
                    break;
                    return 0;
                }
                else if (b2_health < 0)
                {
                    words = "Great, it was unexpected, but we did it well. Behind beaten creatur was placcing the gate, i think, you are ready to open it\n\n" +
                        "Take it potion, it make you stronger and heal you\n" +
                        "............+200HP.......+20damage.......\n" +
                        "Ok, we are ready, OPEN THE GATE!!!!";
                    foreach (char c333 in words)
                    {
                        Console.Beep(459, 100);
                        Console.Write(c333);
                        Thread.Sleep(1);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine();
                    break;
                }
            }


            player.Heal(100);

            first_boss = true;
            b1_health = 1000;
            while (first_boss)
            {
                Console.WriteLine("Boss health: " + b1_health);
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
                    int dp = rnd.Next(100, 150);
                    Console.WriteLine("Boss took damage: " + dp);
                    b1_health -= dp;
                }
                else
                {
                    player.Take_damage(b1_damage);
                }
                Console.ReadKey();
                Console.Clear();
                if (player.health < 0)
                {
                    Console.WriteLine("GG");
                    break;
                    return 0;
                }
                else if (b1_health < 0)
                {
                    words = "Wow, we did it, that was hard, but wonderful, this area is ours, maybe, we will continue uor journey in next episods, bye))";
                    foreach (char c323 in words)
                    {
                        Console.Beep(459, 100);
                        Console.Write(c323);
                        Thread.Sleep(1);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine();
                    break;
                }
            }







            return 0;
        }
    }
}