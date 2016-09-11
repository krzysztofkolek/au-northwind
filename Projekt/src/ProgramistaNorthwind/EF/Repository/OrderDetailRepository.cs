namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;

    public partial class OrderDetailRepository : BaseRepository<Order_Detail>
    {
        public OrderDetailRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
