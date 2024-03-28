// On the creative side, the program was able to choose a random scripture.
// Using System namespace for basic functionalities.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a reference object.
        //Reference reference = new Reference("2 Nephi", 4, 16);
        // Creating a scripture object with a reference and text.
        //Scripture scripture = new Scripture(
        //reference,
        //"Behold, my soul delighteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard."
        //);
        // Array of 10 scriptures from the Book of Mormon in English with their references

        // Continued list of scriptures with a total of 10
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "Behold, my soul delighteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard."
            ),
            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."
            ),
            new Scripture(
                new Reference("Alma", 37, 35),
                "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God."
            ),
            new Scripture(
                new Reference("Helaman", 5, 12),
                "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."
            ),
            new Scripture(
                new Reference("3 Nephi", 17, 21),
                "And it came to pass that when Jesus had made an end of praying he came again to the disciples, and said unto them: So great faith have I never seen among all the Jews; wherefore I could not show unto them so great miracles, because of their unbelief."
            ),
            new Scripture(
                new Reference("Mormon", 8, 12),
                "And whoso receiveth this record, and shall not condemn it because of the imperfections which are in it, the same shall know of greater things than these. Behold, I am Moroni; and were it possible, I would make all things known unto you."
            ),
            new Scripture(
                new Reference("Ether", 12, 27),
                "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
            ),
            new Scripture(
                new Reference("Moroni", 10, 4),
                "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."
            ),
            new Scripture(
                new Reference("Mosiah", 2, 17),
                "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."
            ),
            new Scripture(
                new Reference("Doctrine and Covenants", 58, 27),
                "Verily I say, men should be anxiously engaged in a good cause, and do many things of their own free will, and bring to pass much righteousness; For the power is in them, wherein they are agents unto themselves. And inasmuch as men do good they shall in nowise lose their reward."
            )
        };
        // Generate a random number to select a scripture
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        // Get the randomly selected scripture
        Scripture scripture = scriptures[randomIndex];
        // Clearing console screen.
        // Variable to hold user input.
        string answer = "";
        // Loop to display scripture text and interact with user until "quit" is entered.
        while (answer != "quit")
        {
            Console.Clear();
            // Displaying scripture text.
            Console.WriteLine(scripture.GetDisplayText());
            // Prompting user to continue or quit.
            Console.WriteLine(
                "\nPlease press enter to continue or type \"quit\" to finish the program: "
            );
            // Reading user input.
            answer = Console.ReadLine().ToLower();
            // Clearing console screen.
            Console.Clear();
            // Exiting loop if scripture text is completely hidden.
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            // Hiding random words in the scripture text.
            scripture.HideRandomWords(3);
        }
    }
}
