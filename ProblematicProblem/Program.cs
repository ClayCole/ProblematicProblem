using System;


using System.Collections.Generic;
using System.Threading;


public static class Program
{
    static Random rng = new Random();
    static readonly bool cont = true;

    static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
    

    static void Main(string[] args)
    {
        string userName = "";
        int userAge = 0;

        Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
        bool yesOrNo = Console.ReadLine().ToLower() == "yes" ? true : false;
        if (yesOrNo == false)
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }

        if (yesOrNo == true)
        {
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();


        }


        Console.Write("Would you like to see the current list of activities? Yes or No ?: ");
        bool seeList = Console.ReadLine().ToLower() == "yes" ? true : false;

        if (seeList == true)
        {
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            bool addToList = Console.ReadLine().ToLower() == "yes" ? true : false;


            if (addToList == true)
            {
                do
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");

                    bool addToList2 = Console.ReadLine().ToLower() == "yes" ? true : false;

                    if (addToList2 == false)
                    {
                        addToList = false;
                    }

                } while (addToList == true);
            }


        }

        while (cont)
        {
            Console.Write("Connecting to the database");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                //Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("Choosing your random activity");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(". ");
                //Thread.Sleep(500);
            }

            Console.WriteLine();

            int randomNumber = rng.Next(activities.Count);

            string randomActivity = activities[randomNumber];

            if (userAge < 21 && randomActivity == "Wine Tasting")
            {
                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                Console.WriteLine("Pick something else!");
                activities.Remove(randomActivity);
                randomNumber = rng.Next(activities.Count);
                randomActivity = activities[randomNumber];
            }


            Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity} ! Is this ok or do you want to grab another activity? Keep/Redo: ");
            Console.WriteLine();
            var cont = Console.ReadLine().ToLower() == "redo" ? true: false;
            

            if (cont == false)
            {
                Console.WriteLine($"Have fun with {randomActivity}");
                Environment.Exit(0);
            }

            //if (keepOrRedo.Contains("redo"))
            //{
            //    do
            //    {
            //        randomNumber = rng.Next(activities.Count);
            //        string randomActivity2 = activities[randomNumber];

            //        Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity2} ! Is this ok or do you want to grab another activity? Keep/Redo: ");
            //        keepOrRedo = Console.ReadLine();

            //    } while (keepOrRedo.Contains("redo"));

            //}

            


        }

    }


}

