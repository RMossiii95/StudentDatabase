using System;
using System.Collections.Generic;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("Welcome to our class!");               
                string answer = UserInput("Which student would you like to know more about? Please enter 1-10");
                int name = int.Parse(answer);
                //int choice = Convert.ToInt32(Console.ReadLine());
                         
                List<string> names = new List<string>();
                names.Add("Andy Beer");
                names.Add("Cassly Sullen");
                names.Add("Phillip Conrad");
                names.Add("Zachary Parr");
                names.Add("Cortez Christian");
                names.Add("Erin Walter");
                names.Add("James Mitchell");
                names.Add("Cullin Flynn");
                names.Add("Cordero Ebberhart");
                names.Add("Rick Magdaleno");

                Console.WriteLine(names[name -1]);

                string[] hometown = new string[10];
                hometown[0] = "Hometown is: Berkley, MI";
                hometown[1] = "Hometown is: Detroit, MI";
                hometown[2] = "Hometown is: Canton, MI";
                hometown[3] = "Hometown is: Wyandotte, MI";
                hometown[4] = "Hometown is: Detroit, MI";
                hometown[5] = "Hometown is: Troy, MI";
                hometown[6] = "Hometown is: Yap, FSM";
                hometown[7] = "Hometown is: Fowlerville, MI";
                hometown[8] = "Hometown is: Berkley, MI";
                hometown[9] = "Hometown is: Gilbert, AZ";

                string[] favfood = new string[10];
                favfood[0] = "Favorite food is: French Fries";
                favfood[1] = "Favorite food is: Steak";
                favfood[2] = "Favorite food is: Fried Chicken";
                favfood[3] = "Favorite food is: Sushi";
                favfood[4] = "Favorite food is: Chicken Fettuccine Alfredo";
                favfood[5] = "Favorite food is: Tacos";
                favfood[6] = "Favorite food is: Katsu";
                favfood[7] = "Favorite food is: Pad Thai";
                favfood[8] = "Favorite food is: BBQ";
                favfood[9] = "Favorite food is: Hamburger";

                //I have lost my sanity trying to get this to work but I was attempting to have incorrect input be rejected and run it again but it broke my program.
                /*if (choice >= 1 && choice <= 10)
                {
                    Console.WriteLine();
                }
                else if (choice <= 1 || choice >= 10)
                {
                    Console.WriteLine("That was not a valid input! Please try again.");
                    Continue();
                }*/


                string reply = UserInput("Now that you have chosen your student, please choose to learn about either Hometown or FavoriteFood!");
                if (reply == "Hometown")
                {
                    Console.WriteLine(hometown[name - 1]);                
                }
                else if(reply == "FavoriteFood")
                {
                    Console.WriteLine(favfood[name -1]);
                }
                else
                {
                    Console.WriteLine("That was not an acceptable answer! Please try again!");
                    Continue();
                }

               goOn = Continue();
            }

        }
        public static string UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
            
        }
        public static bool Continue()
        {
            string response = UserInput("Would you like to know more about another student? y/n");

            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                Console.WriteLine("Good bye!");
                return false;
                
            }
            else
            {
                Console.WriteLine("That was not a valid response, please try again!");
                return Continue();
            }
        }
        
    }
}
