using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{
    public partial class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(NorthwindContext context) : base(context)
        {
        }

        public override bool GetPredicate(Customer item, string id)
        {
            if (item.CustomerID.Equals(id))
            {
                return true;
            }
            return false;
        }
    }
}
