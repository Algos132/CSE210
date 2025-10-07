using System;

class reflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public reflectingActivity()
    : base("reflecting activity", "Think deeply, take some time considering an experience based on the given prompt. Then, when ask a question, reflect more deeply about details of the experience. You may discover more depth than you previously realized.")
    {

        _prompts.Add("Think of a time when you felt strength");
        _prompts.Add("Think of a time when you felt successful");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you felt the Holy Ghost this month");

        _questions.Add("If you could do one thing differently, what would you do? Why?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What is your favorite part about this experience?");
        _questions.Add("When could you have seen the Lord's hand in this experience?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions when they appear, and think of how they relate to your experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        for (int i = _duration; i > 0;)
        {
            Console.Clear();
            Random question = new Random();
            int asking = question.Next(0, _questions.Count);
            Console.WriteLine(_questions[asking]);
            _questions.RemoveAt(asking);
            ShowSpinner(10);
            i -= 10;
        }

        DisplayEndingMessage();
    }
}