class ChatBotExpception
{
    // return a string - reply method
    public string Reply(string message)
    {
        // try , don't crash
        try
        {
            // convert text to number
            // Parse = Convert
            int number = Int32.Parse(message);

            // return the result
            return $"Your sent number : {number}";
        }
        // Catsh format error
        // FormatException = Letters instead of numbers
        catch (FormatException)
        {
            //ASK for a number
            return "Please send a number, not text!";
            
        }
        //Catsh any other error
        //Exception = any general Error and ex = error details
        
        catch(Exception ex)
        { 
            // ex.Message = Error message
            return $"Something went wrong: {ex.Message}";
        }
    }
}