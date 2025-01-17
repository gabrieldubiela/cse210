public class Job {
    public string _title;
    public string _description;
    public string _company;
    
    public void DisplayJobDetails ()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Company: " + _company);
        Console.WriteLine("");
    }
}