using System;
namespace DebuggingDemo
{
    public class BaseBot
    {
        public string BotName{get; set;}

        public BaseBot(string name)
        {
            BotName = name;
        }

        public virtual void Reply()
        {
            Console.WriteLine($"{BotName}: I'm a basic bot .");
        }
    }
}