using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = " ";
        while (menu != "4")
        {
            Console.Clear();
            Console.Write(
                "Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\nSelect a choice from the menu:  "
            );
            menu = Console.ReadLine();
            if (menu == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
                );
                Console.Clear();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (menu == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity(
                    "Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );
                Console.Clear();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }
            else if (menu == "3")
            {
                ListingActivity listingActivity = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                );
                Console.Clear();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
        }
    }
}
