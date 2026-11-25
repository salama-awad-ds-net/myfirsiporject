namespace ChatbotTest;

/*I created a Chatbot test with xUnit.
Test1 check RuleBot inherit from ChatBot. 
Test2 Check RuleBot USES parent reply.
Both tests passed.*/
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
      RuleBot bot = new RuleBot();

      // act run chatbot
      string answer = bot.Reply("hi");

      // assert check chabot
      Assert.Equal("Hello", answer); // must be hello
    }
    [Fact]
    public void Test2_parent_Reply()
    {
       RuleBot bot = new RuleBot();

       string answer = bot.Reply("Bye");

       // assert uses parent
       Assert.Equal("I don't understand",answer);
    }
}
