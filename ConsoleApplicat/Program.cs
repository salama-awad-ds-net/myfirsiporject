using System;
// Salama 
public interface IChatBot
{
    void SendMessage();
}

public abstract class ChatBot : IChatBot
{
    public string BotName { get; set; }
    public void SendMessage() { Console.WriteLine($"[{BotName}] is sending a message..."); }
}

public class AIChatBot : ChatBot
{
    public string AIModel { get; set; } 
}

class Program
{
    static void Main()
    {
        ChatBot myBot = new AIChatBot();
        myBot.BotName = "Salama-Bot";

        if (myBot is AIChatBot)
        {
            Console.WriteLine("Yes, this is an AI Chatbot.");
        }

        AIChatBot specificBot = myBot as AIChatBot;
        if (specificBot != null)
        {
            specificBot.AIModel = "GPT-4";
            Console.WriteLine($"AI Model: {specificBot.AIModel}");
        }

        myBot.SendMessage();
    }
}