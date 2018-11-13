using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                string webAdd1 = "www.omdbapi.com/", webAdd2 = "", webAdd; // webAdd short for web address
                bool optval = false;
                char[] choice = new char[3];
                Console.WriteLine("Which database would you like to search, OMDbAPI (O) or Movie Db (M)?");
                choice[0] = char.ToUpper(Console.ReadKey().KeyChar);
                do {
                    if (choice[0] == 'O')
                    {
                        Console.WriteLine("You have chosen to search OMDbAPI");
                        /*
                         how do we want to structure the rest of this?
                         depending on how the second db works we can either put two copies of the code in either /n
                         one of the if statements for both of the                 
                     
                     */

                    }
                    else if (choice[0] == 'M')
                    {
                        Console.WriteLine("You have chosen to seach Then Movive Db");
                        Console.WriteLine("Select what field you would like to search"); // this is where we need to look into how the second db works
                    }
                    else
                    {

                    }
                } while (optval);
                optval = false;
                Console.WriteLine("Search on title or IMDb ID (T/I)");
                choice[1] = char.ToUpper(Console.ReadKey().KeyChar); // Console.WriteLine(choice); //used to check to upper is working
                // repeat until valid input is given
                do
                {
                    if (choice[1] == 'I')
                    {
                        // enter imdb id number
                        Console.Write("Enter movie IMDb ID: ");
                        webAdd2 = Console.ReadLine();
                        optval = true;
                    }
                    else if (choice[1] == 'T')
                    {
                        Console.Write("Enter movie title: ");
                        webAdd2 = "?t=" + Console.ReadLine() + "&apikey=d6b3c2ae";
                        optval = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error - wrong input option\n\nPlease enter a new option (T/I)"); // create validation loop around if statement
                    }
                    webAdd = webAdd1 + webAdd2;
                    Console.WriteLine(webAdd);

                } while (optval);
                var contents = client.DownloadString(webAdd); // when using avengers as the input program is returning an illegal character in path exception on this line
                Console.WriteLine(contents);
                            
                Console.Read();

            }
        }

    }
}
