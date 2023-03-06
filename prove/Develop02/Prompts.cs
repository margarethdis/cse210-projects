public class Prompts
{
    public List<string> _questions = new List<string>()
    {
        "What was the best part of your day?",
        "Who did you talk today?",
        "How would you describe my mood lately?",
        "What moments of revelation did you have today?",
        "What are my goals for the next month?"

    };

    public string RandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return  _questions[index];
    }



//
}
