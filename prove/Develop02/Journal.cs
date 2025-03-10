public class JournalEntry
{
    private string _date;
    private string _prompt;
    private string _response;

    public void CreateEntry(string prompt)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = prompt;
        Console.WriteLine("Enter your response:");
        _response = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n");
    }
}
