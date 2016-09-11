namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;

    public partial class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
