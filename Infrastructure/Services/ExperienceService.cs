public class ExperienceService
{
    private List<Experience> experiences;
    public ExperienceService()
    {
        experiences = new List<Experience>();
    }
    public List<Experience> GetExperiences()
    {
        return experiences;
    }
    public void Add(Experience Experience)
    {
        experiences.Add(Experience);
    }
    public void Update(Experience Experience, int id)
    {
        var existing = experiences.Find(e=>e.Id == Experience.Id);
        if(existing == null) System.Console.WriteLine("Id can't be null"); 

        existing.Id = Experience.Id;
        existing.Name = Experience.Name;
        existing.Description = Experience.Description;
    }
    // public Experience GetExperienceById(int id)
    // {
    //     var existing = experiences.Find(e=>e.Id == id);
    //     return experiences;
    // }
   
    public void Delete(int id)
    {
        var existing = experiences.Find(x=>x.Id == id);
        if(existing == null) return;
        experiences.Remove(existing);
    }
    public int Count()
    {
        var existing = experiences.Count();
        return existing;
    }
}