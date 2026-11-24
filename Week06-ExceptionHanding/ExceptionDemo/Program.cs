// Main file
class program
{
    //starting point
    static void Main()
    {
        // create new bot
        ChatBotExpception bot = new ChatBotExpception();
        // Ask the user
        Console.WriteLine("Write a number: ");
        // Read user input
        string? input = Console.ReadLine();
        
        // Call Reply and print result - Reply means if , use empty string ""?
        Console.WriteLine(bot.Reply(input ?? ""));
    }
}