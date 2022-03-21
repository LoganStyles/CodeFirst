using CodeFirst.Entities;

namespace CodeFirst
{
    public class Order
    {
        public long TrackingId { get; set; }
        public string Name { get; set; } = null!;
        public SalesOutlet SalesOutlet { get; set; }= null!;
    }
}
