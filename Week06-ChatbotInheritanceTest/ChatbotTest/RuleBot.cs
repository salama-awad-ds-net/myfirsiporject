namespace ChatbotTest; // 
public class RuleBot: Chatbot // child
{
    public override string Reply(string question)
    {
        if (question == "hi") // if hi
           return "Hello"; // new replty
        return base.Reply(question); //new reply
    }
}