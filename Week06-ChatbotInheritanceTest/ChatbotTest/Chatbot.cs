namespace ChatbotTest; // same project name

public class Chatbot // parent Chatbot salama
{
    public virtual string Reply(string question) // PARENT REPLAY  VIRTUAL - CON BE CHANGE
    {
         return "I don't understand"; // general reply
    }
}