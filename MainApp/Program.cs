var department = new Department();

department.Id = 1;
department.Name = "HR";
department.Description = "bla";

var department2 = new Department();

department2.Id = 2;
department2.Name = "It";
department2.Description = "blabla";

var department3 = new Department();

department3.Id = 3;
department3.Name = "It";
department3.Description = "blabla";


var employee = new Employee();

employee.Id = 1;
employee.FirstName = "Ardasher";
employee.LastName = "Sattori";
employee.BirthDate = DateTime.Now;
employee.Address = "Dushanbe";
employee.Phone = "+992000000000";

var employee2 = new Employee();

employee2.Id = 2;
employee2.FirstName = "Korigari";
employee2.LastName = "Duyum";
employee2.BirthDate = DateTime.Now;
employee2.Address = "Vanj";
employee2.Phone = "+992000000000";

var employee3 = new Employee();

employee3.Id = 3;
employee3.FirstName = "Korigari";
employee3.LastName = "Seyum";
employee3.BirthDate = DateTime.Now;
employee3.Address = "Pomir";
employee3.Phone = "+992000000000";

var employee4 = new Employee();

employee4.Id = 4;
employee4.FirstName = "Korigari";
employee4.LastName = "Chorum";
employee4.BirthDate = DateTime.Now;
employee4.Address = "Hisor";
employee4.Phone = "+992000000000";

var employee5 = new Employee();

employee5.Id = 5;
employee5.FirstName = "Korigari";
employee5.LastName = "Panjum";
employee5.BirthDate = DateTime.Now;
employee5.Address = "Kulob";
employee5.Phone = "+992000000000";


var role = new Role();
role.Id = 1;
role.Name = "user";
role.Description = "blabla";
role.EmployeeId = employee.Id;

var role2 = new Role();
role2.Id = 1;
role2.Name = "IT";
role2.Description = "blabla";
role2.EmployeeId = employee.Id;


var experience = new Experience();
experience.Id = 1;
experience.Name = "Alif";
experience.Description = "lalala";
experience.Company = "Alif";
experience.EmployeeId = employee.Id;

var experience2 = new Experience();
experience2.Id = 2;
experience2.Name = "Mohir";
experience2.Description = "lalala";
experience2.Company = "Mohir";
experience2.EmployeeId = employee.Id;

var employeeService = new EmployeeService();
var empl = employeeService.GetEmployees();

System.Console.WriteLine();
System.Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
    

var departmentService = new DepartmentService();
var dep = departmentService.GetDepartments();

System.Console.WriteLine($"Department: {department.Name}");

var experienceService = new ExperienceService();
var exp = experienceService.GetExperiences();

System.Console.WriteLine($"Experiences: {experience.Company}, {experience2.Company}");

var roleService = new RoleService();
var rol = roleService.GetRoles();

System.Console.WriteLine($"Roles: {role.Name}, {role2.Name}");