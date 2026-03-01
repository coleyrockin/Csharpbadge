namespace CatWorx.BadgeMaker;

class Program
{
    /// <summary>
    /// Interactively collects employee records from the console.
    /// The loop continues until the user submits an empty first name,
    /// and validates that the employee ID is a whole number before accepting it.
    /// </summary>
    static List<Employee> GetEmployees()
    {
        var employees = new List<Employee>();

        while (true)
        {
            Console.Write("Enter first name (leave empty to finish): ");
            string firstName = Console.ReadLine() ?? string.Empty;

            if (firstName == string.Empty)
                break;

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine() ?? string.Empty;

            int id;
            Console.Write("Enter ID: ");
            while (!int.TryParse(Console.ReadLine(), out id))
                Console.Write("Invalid ID — please enter a whole number: ");

            Console.Write("Enter photo URL: ");
            string photoUrl = Console.ReadLine() ?? string.Empty;

            employees.Add(new Employee(firstName, lastName, id, photoUrl));
        }

        return employees;
    }

    static void Main(string[] args)
    {
        List<Employee> employees = GetEmployees();
        Util.PrintEmployees(employees);
        Util.MakeCSV(employees);
    }
}
