public class PromptGen
{
    //Creating a list of promts that the class can store
    List<string> _promts = new List<string>(){
        "What are some areas of my life where I tend to have a fixed mindset?",
        "What is something silly that always makes me laugh?",
        "What is one quote or saying that inspires me, and how can I apply its wisdom to my life?",
        "What are three things I love about myself?",
        "What are some activities or hobbies that help me relax and de-stress?"};

    public string GetPromt()
    {
        // Since we do not want the whole list, we will create a way for one random promt to be pulled
        Random randomPromt = new Random();
        int index = randomPromt.Next(_promts.Count);

        return _promts[index];
    }
}