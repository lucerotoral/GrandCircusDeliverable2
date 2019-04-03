
using System;

namespace GrandCircusDeliverable2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numberMood;
            int numberOfGuests;
            string guestMood;
            string guestActivity;
            string guestTravel;


            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options:");

            Console.WriteLine("    1) Action");
            // Stock Car Racing
            Console.WriteLine("    2) Chill times");
            // Hiking
            Console.WriteLine("    3) Danger");
            // Skydiving                                               
            Console.WriteLine("    4) Good food");
            // To Taco Bell

            numberMood = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("How many people are you bringing with you?");

            numberOfGuests = Convert.ToInt32(Console.ReadLine());


            if (numberMood == 1)
            {
                guestMood = "action";
                guestActivity = "Stock Car Racing";
            }
            else if (numberMood == 2)
            {
                guestMood = "chill times";
                guestActivity = "hiking";
            }
            else if (numberMood == 3)
            {
                guestMood = "danger";
                guestActivity = "skydiving";
            }
            else
            {
                guestMood = "good food";
                guestActivity = "to Taco Bell";
            }



            // 0 = sneakers
            // 1-4 = a sedan
            // 5-10 = a Volkswagen Bus
            // 11+ = an airplane

            if (numberOfGuests == 0)
            {
                guestTravel = "sneakers.";
            }

            else if (numberOfGuests <= 4)
            {
                guestTravel = "a sedan.";
            }

            else if (numberOfGuests <= 10)
            {
                guestTravel = "a Volkswagen bus.";
            }

            else
            {
                guestTravel = "an airplane.";
            }



            Console.WriteLine(" ");

            Console.WriteLine("Okay if you're in the mood for " + guestMood +
                   ", then you should go to " + guestActivity +
                   " and you should travel in " + guestTravel);

            Console.WriteLine(" ");

            Console.WriteLine("Goodbye");
        }
    }
}