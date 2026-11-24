using System;

namespace DebuggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AIBot myBot = new AIBot("ChatBot");

            myBot.Reply();

            myBot.PredictData();

        }
    }
    
}