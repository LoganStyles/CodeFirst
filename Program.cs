// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, LINQ!");

using CodeFirst.Data;

namespace CodeFirstTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ArtistsContext();
            var employees = context.Employees
                .Select(
                    employee =>
                        new
                        {
                            Id = employee.Id,
                            Name = FormatNames(employee.FirstName, employee.LastName)
                        }
                )
                .ToList();

            foreach (var employee in employees)
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
