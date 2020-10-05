using System;

namespace Sänkaskepp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jag ber om ursäkt för att jag lämnar in sent, av någon anledning måste jag skriva nästan hela mina json filer själv vilket är lagom tidskrävande (om det är rätt ord)
            bool hit = false;
            string PlayerCords;
            while (hit == false){
                System.Console.WriteLine("Welcome to \"Battleship\"");
                System.Console.WriteLine("Enter coordinations [1-10]");
                PlayerCords = Console.ReadLine();
                if (PlayerCords == "6"){
                    Console.Clear();
                    hit = true;
                }
                else if (PlayerCords == "1" || PlayerCords == "2" || PlayerCords == "3" || PlayerCords == "9" || PlayerCords == "10") {
                    Console.Clear();
                    System.Console.WriteLine("Miss!");
                    System.Console.WriteLine("Try again");
                }
                else if (PlayerCords == "4" || PlayerCords == "5" || PlayerCords == "7" || PlayerCords == "8"){
                    Console.Clear();
                    System.Console.WriteLine("Near miss!");
                    System.Console.WriteLine("Try again");
                
                }
                else{
                    Console.Clear();
                    System.Console.WriteLine("Answer must be a number and between 1 and 10");
                    System.Console.WriteLine("Try again");
                    hit = false;
                }
            }
            if (hit == true){
                System.Console.WriteLine("Hit");
                System.Console.WriteLine("Press enter to EXIT");
            }
            Console.ReadLine();
        }
    }
}
// kunde vara mer elegant, men men, det funkar iallafall