string userInput = Console.ReadLine();
int userText = Convert.ToInt32(userInput);
if (userText < 0)
    Console.WriteLine("Salta");
else if (userText < 20)
    Console.WriteLine("Vesu");
else if (userText > 20)
    Console.WriteLine("Karsta");