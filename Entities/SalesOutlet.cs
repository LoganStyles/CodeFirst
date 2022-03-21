namespace CodeFirst.Entities
{
    public class SalesOutlet {

        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;
        public string State { get; set; } = null!;
        public List<Order> Orders { get; set; } = null!;
     }
}
