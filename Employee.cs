namespace CatWorx.BadgeMaker;

/// <summary>
/// Represents a CatWorx employee whose security badge will be generated.
/// Encapsulates the identifying information required to produce a physical badge:
/// name, employee ID, and a URL pointing to the employee's photo.
/// </summary>
public sealed class Employee
{
    /// <summary>Gets the employee's first name.</summary>
    public string FirstName { get; }

    /// <summary>Gets the employee's last name.</summary>
    public string LastName { get; }

    /// <summary>Gets the unique numeric identifier assigned to this employee.</summary>
    public int Id { get; }

    /// <summary>Gets the URL of the employee's badge photo.</summary>
    public string PhotoUrl { get; }

    /// <summary>
    /// Initializes a new <see cref="Employee"/> with all required badge fields.
    /// </summary>
    public Employee(string firstName, string lastName, int id, string photoUrl)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        PhotoUrl = photoUrl;
    }

    /// <summary>Returns the employee's full name as a single formatted string.</summary>
    public string GetFullName() => $"{FirstName} {LastName}";
}
