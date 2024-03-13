public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public Resume()
    {
        _jobs = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job qJobs in _jobs)
        {
            Console.WriteLine(
                $"{qJobs._jobTitle} ({qJobs._company}) {qJobs._startYear}-{qJobs._endYear}"
            );
        }
    }
}
