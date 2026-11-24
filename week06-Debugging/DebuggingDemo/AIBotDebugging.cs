using System;


namespace DebuggingDemo

{
    public class AIBot: BaseBot
    {
        public AIBot(String name): base(name)
        {
            
        }
        public override void Reply()
        {
            Console.WriteLine($"{BotName}: Hello! I'm an AI model ready to learn");
        }
        public void PredictData()
        {
            Console.WriteLine($"{BotName} is processing ML data ...");
        }

    }
}