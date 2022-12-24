
public class DepartmentService
{
    private List<Department> departments;
    public DepartmentService()
    {
        departments = new List<Department>();
    }
    public List<Department> GetDepartments()
    {
        return departments;
    }
    public void Add(Department department)
    {
        departments.Add(department);
    }
    public void Update(Department department, int id)
    {
        var existing = departments.Find(e=>e.Id == department.Id);
        if(existing == null) System.Console.WriteLine("Id can't be null"); 

        existing.Id = department.Id;
        existing.Name = department.Name;
        existing.Description = department.Description;
    }
    // public Department GetDepartmentById(int id)
    // {
    //     return
    // }
   
    public void Delete(int id)
    {
        var existing = departments.Find(x=>x.Id == id);
        if(existing == null) return;
        departments.Remove(existing);
    }
    public int Count()
    {
        var existing = departments.Count();
        return existing;
    }
}