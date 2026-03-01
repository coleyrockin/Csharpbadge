namespace CatWorx.BadgeMaker;

/// <summary>
/// Provides utility methods for displaying and exporting employee badge data.
/// All members are static because <see cref="Util"/> acts as a stateless service
/// with no per-instance data.
/// </summary>
static class Util
{
    /// <summary>
    /// Prints a formatted, tab-aligned table of all employees to standard output.
    /// </summary>
    public static void PrintEmployees(List<Employee> employees)
    {
        foreach (Employee e in employees)
            Console.WriteLine($"{e.Id,-10}\t{e.GetFullName(),-20}\t{e.PhotoUrl}");
    }

    /// <summary>
    /// Writes employee data to <c>data/employees.csv</c>.
    /// The <c>data/</c> directory is created automatically if it does not exist.
    /// An existing file at that path is overwritten.
    /// </summary>
    public static void MakeCSV(List<Employee> employees)
    {
        if (!Directory.Exists("data"))
            Directory.CreateDirectory("data");

        using StreamWriter file = new("data/employees.csv");

        file.WriteLine("ID,Name,PhotoUrl");
        foreach (Employee e in employees)
            file.WriteLine($"{e.Id},{e.GetFullName()},{e.PhotoUrl}");
    }
}
