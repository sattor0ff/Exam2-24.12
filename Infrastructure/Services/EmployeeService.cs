public class EmployeeService
{
    private List<Employee> employees;

    public EmployeeService()
    {
        employees = new List<Employee>(); 
    }
    public List<Employee> GetEmployees()
    {
        return employees;
    }
    public void Add(Employee employee)
    {
        employees.Add(employee);
    }
    public void Update(Employee employee, int id)
    {
        var existing = employees.Find(e=>e.Id == employee.Id);
        if(existing == null) System.Console.WriteLine("Id can't be null");

        existing.Id = employee.Id;
        existing.FirstName = employee.FirstName;
        existing.LastName = employee.LastName;
        existing.BirthDate = employee.BirthDate;
        existing.Address = employee.Address;
    }
    // public Employee GetEmployeeById(int id)
    // {
    //     return <id>;
    // }
    // public List<Role> GetRolesByUserId(int id)
    // {
    //     return 
    // }
    // public List<Experience> GetExperienceByUserId(int id)
    // {
    //     return 
    // }

    public void Delete(int id)
    {
        var existing = employees.Find(x=>x.Id == id);
        if(existing == null) return;
        employees.Remove(existing);
    }
    public int Count()
    {
        var existing = employees.Count();
        return existing;
    }
}