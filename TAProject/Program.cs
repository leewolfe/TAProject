using System;

namespace TAProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my base");
            Console.WriteLine("Would you like a tour?");

            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("Awesome! Let's grab some food and fur before we go.");
                Console.WriteLine("I hope you got enough food. It's cold down here!");
                Console.WriteLine("Let's begin.");
                Console.WriteLine("On our left we have a bunch of junk dinos that we really never use.");
                Console.WriteLine("That's correct. Just some extra kibbles dinosaurs, and stuff people don't want to organize.");
                Console.WriteLine("Would you like to Continue or Stop?");

                string ContinueOrStop = Console.ReadLine();
                if (ContinueOrStop == "Continue")
                {
                    Console.WriteLine("On our right we continue down the pathway to a few of a smaller herbivore dinos.");
                    Console.WriteLine("Our trikes and stegos are very good. You can check the stats if you want.");
                    Console.WriteLine("The other creatures are just average.");
                    Console.WriteLine("Let me know if you are getting too cold, or you would like to stop.");
                    Console.WriteLine("Here is the garden. We piped in running water which was a pain!");
                    Console.WriteLine("We make all our food here in addition to the vegetable cakes.");
                    Console.WriteLine("Do you want to Continue or Stop?");

                    string ContinueOrStop1 = Console.ReadLine();
                    if (ContinueOrStop1 == "Continue")
                    {

                        Console.WriteLine("As we keep going you can see the breeding area.");
                        Console.WriteLine("Here we have the teleporter which goes to the surface so we can do quick meat and berry runs.");
                        Console.WriteLine("Yes, the tek troughs are a must for any breeding area. They make it 10 times easier to raise babies.");
                        Console.WriteLine("I know it is getting very cold. We only have one more section to see.");
                        Console.WriteLine("Would you like to Continue the tour or stop early?");
                        string ContinueOrStop2 = Console.ReadLine();
                        if (ContinueOrStop2 == "Continue")
                        {

                            Console.WriteLine("Awesome! This is my favorite part of the cave.");
                            Console.WriteLine("We store all the war dinosaurs here in addition to the gear and supplies we need for just about anything.");
                            Console.WriteLine("Ofcourse we have a transmitter. If you step this way a little bit you can see it.");
                            Console.WriteLine("The vaults are locked. We don't want anyone not a full member to be taking anything that is not thiers.");
                            Console.WriteLine("I hope you understand.");
                            Console.WriteLine("Well, I am getting a bit chilly now and there is no more to see. I will walk you back to the entrance.");
                            Console.WriteLine("I hope you enjoyed the tour of our cave base. Have a nice day!");
                        }
                        else
                        {
                            Console.WriteLine("Okay, have a nice day!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Okay, have a nice day!");
                    }

                }
                else
                {
                    Console.WriteLine("Okay, have a nice day!");
                }

            }
            else
            {
                Console.WriteLine("Okay, have a nice day!");
            }
        }
    }
}
