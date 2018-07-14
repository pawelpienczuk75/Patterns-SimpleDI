using System;

namespace CodersLab.DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
	        ILogger logger = new DatabaseLogger();

			User user = new User(logger); // przez konstruktor
			user.LogIn();

			Role role = new Role();
			role.Logger = logger; // przez właściwość
			role.RemoveUserFromRole("Usunięto użytkownika - wyswietlono za pomocą wstrzykniętego komponentu.");
			
			Database database = new Database();
			database.SetLogger(logger); // przez metodę
	        database.Open();

	        Console.ReadLine();
        }
    }
}
