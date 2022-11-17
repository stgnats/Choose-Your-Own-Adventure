namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.\nIt begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            string ans1 = Console.ReadLine();
            if (ans1.ToLower() == "no") //putting the strings all to lower makes sure if the user types "no" in any way it will still work properly
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!\nTHE END");
                goto end; //ends the program when the story ends
            }
            else if (ans1.ToLower() == "yes")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");
            }
            string ans2 = Console.ReadLine();
            if (ans2.ToLower() == "knock")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                string riddleAns = Console.ReadLine();
                if (riddleAns.ToLower() == "nothing")
                {
                    Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                    goto end;
                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open\nTHE END");
                    goto end;
                }
            }
            else if (ans2.ToLower() == "open")
            {
                Console.Write("The door is locked! See if one of your three keys will open it...\nEnter a number: ");
                string numAns = Console.ReadLine();
                switch (numAns)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END");
                        goto end;
                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't ");
                        goto end;
                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't ");
                        goto end;
                    default:
                        Console.WriteLine("You didn't choose a key. What a moron.\nTHE END");
                        goto end;
                }
            }

        end:;
        }
    }
}



