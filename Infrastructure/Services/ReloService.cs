public class RoleService
{
    private List<Role> roles;
    public RoleService()
    {
        roles = new List<Role>();
    }
    public List<Role> GetRoles()
    {
        return roles;
    }
    public void Add(Role Role)
    {
        roles.Add(Role);
    }
    public void Update(Role Role, int id)
    {
        var existing = roles.Find(e=>e.Id == Role.Id);
        if(existing == null) System.Console.WriteLine("Id can't be null"); 

        existing.Id = Role.Id;
        existing.Name = Role.Name;
        existing.Description = Role.Description;
    }
    // public Role GetRoleById(int id)
    // {
    //     var existing = roles.Find(e=>e.Id == id);
    //     return roles;
    // }
   
    public void Delete(int id)
    {
        var existing = roles.Find(x=>x.Id == id);
        if(existing == null) return;
        roles.Remove(existing);
    }
    public int Count()
    {
        var existing = roles.Count();
        return existing;
    }
}