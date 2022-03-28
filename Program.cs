// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, LINQ!");



using CodeFirst.Data;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ArtistsContext();

            //evaluation takes place on the server since this expression is completely convertible
            var employees = context.Employees
                .Select(
                    employee =>
                        new
                        {
                            Id = employee.Id,
                            FirstName = employee.FirstName,
                            LastName = employee.LastName
                        }
                )
                .ToList();

            Console.WriteLine("Server evaluation occurs here:");

            foreach (var employee in employees)
            {
                Console.WriteLine(
                    "{0} {1} {2}",
                    employee.Id,
                    employee.FirstName,
                    employee.LastName
                );
            }

            //FormatNames method is unknown to the database, hence partial client evaluation takes place
            var employeesWithFormattedNames = context.Employees
                .Select(
                    employee =>
                        new
                        {
                            Id = employee.Id,
                            Name = FormatNames(employee.FirstName, employee.LastName)
                        }
                )
                .ToList();

            Console.WriteLine("Partial client evaluation occurs below:");
            foreach (var employee in employeesWithFormattedNames)
            {
                Console.WriteLine("{0} {1}", employee.Id, employee.Name);
            }
        }

        public static string FormatNames(string firstname, string lastname)
        {
            var result = string.Empty;

            if (!string.IsNullOrWhiteSpace(firstname) && !string.IsNullOrWhiteSpace(lastname))
            {
                result = firstname.ToUpper() + ' ' + lastname.ToUpper();
            }

            return result;
        }
    }
}
