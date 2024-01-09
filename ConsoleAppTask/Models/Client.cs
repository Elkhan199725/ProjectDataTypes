using ConsoleAppTask.Bases;
using ConsoleAppTask.Interfaces;

namespace ConsoleAppTask.Models;

public class Client : ClientBase, IClient
{
    public Client(int id, string name, string email)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        }

        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentException($"'{nameof(email)}' cannot be null or empty.", nameof(email));
        }

        Id = id;
        Name = name;
        Email = email;
    }

    public override int Id { get; set; }
    public override string Name { get; set; }
    public override string Email { get; set; }

}
