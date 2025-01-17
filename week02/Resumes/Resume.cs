public class Resume {
    public string _name;
    public List<Job> _job = new List<Job>();

    public void DisplayJobDetails ()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs:");
        Console.WriteLine("");
        foreach (Job job in _job)
        {
            job.DisplayJobDetails();
        }
        
    }
}
